Imports DPFP
Imports DPFP.Capture
Imports System.CodeDom
Imports System.Data.OleDb
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows

Public Class MainPanel_Form
    Implements DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Delegate Sub FunctionCall(ByVal param)
    Private Event OnTemplate(ByVal template)
    Private Enroller As DPFP.Processing.Enrollment
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        Process_Verify(Sample)

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        'Throw New NotImplementedException()
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        'Throw New NotImplementedException()
    End Sub

    Public sp As SerialPort = Form1.SerialPort1
    Private Sub Master_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        'Panel1.BackColor = Color.FromArgb(180, 0, 0, 0)
        Init()
        StartCapture()

    End Sub
    Public Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture() 'create capture event
            Enroller = New DPFP.Processing.Enrollment
            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me 'capturing events
            Else
                MsgBox("Can't initiate capture operation")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub StartCapture()
        Try
            If (Not Capturer Is Nothing) Then
                Capturer.StartCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub StopCapture()
        Try
            If (Not Capturer Is Nothing) Then
                Capturer.StopCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub
    Dim _picCount As Integer
    Private Sub _DrawPicture(ByVal bmp)
        Me.PictureBox1.Image = New Bitmap(bmp, Me.PictureBox1.Size)
    End Sub
    Private Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim bitmap As Bitmap = Nothing
        Try
            Dim convertor As New DPFP.Capture.SampleConversion()
            convertor.ConvertToPicture(Sample, bitmap)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return bitmap
    End Function



    Private Function Extract_Features(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Try
            Dim extractor As New DPFP.Processing.FeatureExtraction() 'create feature extractor
            Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
            Dim features As New DPFP.FeatureSet()
            extractor.CreateFeatureSet(Sample, Purpose, feedback, features) 'TODO: return features as a result
            If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
                Return features
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return Nothing
    End Function

    Protected Sub SetStatus(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _SetStatus), status)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
    Public F1_get_id As String
    Public F1_get_user As String
    Public F1_get_pass As String
    Public F1_get_title As String
    Public Sub Process_Verify(ByVal Sample As DPFP.Sample)
        Invoke(Sub()
                   If Form1.Timer1.Enabled = False Then
                       Form1.Timer1.Enabled = True
                   End If
               End Sub)

        Try
            DrawPicture(ConvertSampleToBitmap(Sample))
            Dim Features_Verify As DPFP.FeatureSet = Extract_Features(Sample, DPFP.Processing.DataPurpose.Verification)
            Dim Verificator As New DPFP.Verification.Verification
            Dim result As New DPFP.Verification.Verification.Result()

            If Not Features_Verify Is Nothing Then 'check if quality is good
                Dim conn As New OleDbConnection
                conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\LF Warehouse BioData.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfwhbiometrics")
                conn.Open()

                Dim strsql As String
                strsql = "select Username,Title,Finger FROM Uname"
                Dim cmd As New OleDbCommand(strsql, conn)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                Dim dt As New DataTable
                dt.Load(myreader)

                For Each dr As DataRow In dt.Rows

                    Dim bytes As Byte() = Nothing
                    bytes = dr.Item("Finger")
                    Dim saved_temp As New DPFP.Template
                    saved_temp.DeSerialize(bytes)
                    Verificator.Verify(Features_Verify, saved_temp, result)
                    If result.Verified Then
                        Label1.ForeColor = Color.Black
                        F1_get_user = dr.Item("Username")
                        F1_get_title = dr.Item("Title")

                        StopCapture()

                        '*************************  Record History *****************************

                        Dim mycommand As String
                        Dim _dateNtime As String = Date.Now.ToString("MMM dd, yyyy | hh:mm tt")
                        Dim _Name As String = F1_get_user
                        Dim _Dept As String = F1_get_title


                        Try
                            mycommand = "INSERT INTO [History_tb] ([Associate_Name],[_Department],[_DateaAndTime]) VALUES (@_name, @Department, @_dateNtime)"
                            Using command As New OleDbCommand(mycommand, conn)
                                command.Parameters.AddWithValue("@_name", _Name)
                                command.Parameters.AddWithValue("@Department", _Dept)
                                command.Parameters.AddWithValue("@_dateNtime", _dateNtime)
                                command.ExecuteNonQuery()
                            End Using
                        Catch ex As Exception
                            MsgBox(ex.Message, vbCritical)
                        End Try

                        Invoke(Sub()
                                   Timer1.Interval = 5000
                                   Timer1.Enabled = True
                                   DoorOpen()
                               End Sub)


                        txtName.Text = F1_get_user
                        txtDept.Text = F1_get_title

                        Label1.Text = "Please scan your finger to open the door."
                        Label2.Text = "Please stand in front of the gate."
                        PictureBox2.Image = My.Resources.Open
                        Thread.Sleep(5000)
                        PictureBox1.Image = My.Resources.fingerprint_scanner

                        Init()
                        StartCapture()

                        'Me.Close()
                        'Thread.Sleep(1000)
                        'MainPanel_Load()

                        'Dim Fngerprint = False
                        'While Fngerprint = False

                        'Label1.Text = "Please scan your finger to open the door."

                        'If F1_get_title = "TSG" Then

                        '    DoorOpen()
                        '    Traceability()
                        '    'Fngerprint = True
                        '    Me.Close()
                        '    Thread.Sleep(1000)
                        '    MainPanel_Load()

                        'Else

                        '    MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                        '    Me.Close()
                        '    Thread.Sleep(1000)
                        '    MainPanel_Load()
                        'End If

                        'End While

                        Exit For


                    End If
                Next
                If Not result.Verified Then

                    StopCapture()
                    Label1.ForeColor = Color.Red
                    Label1.Text = "Authorized personnel only!"
                    Label2.Text = "Authorized personnel only!"
                    Thread.Sleep(3000)
                    PictureBox1.Image = My.Resources.fingerprint_scanner
                    Label2.Text = "Please scan your finger to open the door."
                    Thread.Sleep(3000)
                    Init()
                    StartCapture()
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub _SetStatus(ByVal Status)
        Try
            Me.Label1.Text = Status
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Dim msgclose As String
    Private Sub Master_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StopCapture()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtName.Clear()
        txtDept.Clear()
        PictureBox2.Image = My.Resources.Closed

        Timer1.Enabled = False
        Label2.Text = "Please scan your finger to open the door."
    End Sub
End Class