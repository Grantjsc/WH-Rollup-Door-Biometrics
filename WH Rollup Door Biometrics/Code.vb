Imports System.Data.OleDb
Imports System.Dynamic
Imports System.IO.Ports
Imports System.Threading
Imports System.Configuration

Module Form1_Module
    Sub MainPanel_Load()

        With MainPanel_Form
            .TopLevel = False
            Form1.MainPanel.Controls.Add(MainPanel_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub

    Sub AddUser_Load()
        MainPanel_Form.Close()
        With AddUser_Form
            .TopLevel = False
            Form1.MainPanel.Controls.Add(AddUser_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub ChangeSerial_Load()
        MainPanel_Form.Close()
        AddUser_Form.Close()
        With ChangeSerial_Form
            .TopLevel = False
            Form1.MainPanel.Controls.Add(ChangeSerial_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Timer2Function()
        MainPanel_Form.Label2.Text = "Please scan your finger to open the door."
        MainPanel_Form.Timer1.Enabled = False
        MainPanel_Form.txtName.Clear()
        MainPanel_Form.txtDept.Clear()
        MainPanel_Form.PictureBox2.Image = My.Resources.Closed
        'MainPanel_Form.Label1.Text = "Please scan your finger to open the door."
    End Sub
End Module

Module ChangeSerial_Module
    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Public Serial1 As String
    Public NewSerialName As String

    Sub GetSerialName()
        Dim serial As String = System.Configuration.ConfigurationManager.AppSettings("Serialname")
        Console.WriteLine(serial)

        Serial1 = serial
    End Sub

    Sub GetNewSerial()
        NewSerialName = ChangeSerial_Form.cboSerialList.Text
    End Sub

    Sub SaveChangesInSerial()
        config.AppSettings.Settings("Serialname").Value = NewSerialName ' Rewrite
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
    Sub LoadComPort()

        Dim Serials As String() = SerialPort.GetPortNames()
        For Each portname As String In Serials
            ChangeSerial_Form.cboSerialList.Items.Add(portname)
        Next
    End Sub
    Sub ButtonSaveSerial()
        If ChangeSerial_Form.cboSerialList.Text = "" Then
            MsgBox("Please input serial name", MsgBoxStyle.Critical)
        Else
            GetNewSerial()
            SaveChangesInSerial()
        End If

        GetSerialName()
        Form1.SerialPort1.PortName = Serial1
        ChangeSerial_Form.Close()

        MainPanel_Load()
    End Sub
End Module


Module OmronPLC_Module

    Public TX As String
    Public FCS As String
    Public RXD As String
    Sub PLCTimerFunction()
        Form1.Timer1.Enabled = False
        'Display current date and time
        'Form1.Label1.Text = System.DateTime.Now
        Try
            If Form1.SerialPort1.IsOpen = False Then
                Form1.SerialPort1.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCr & "Connect to PLC Error!", vbCritical)
            End
        End Try
        'Check DM AREA DM486 data update; range: 9
        TX = "@00RD01050005"
        GetFCS()
        'Console.WriteLine(FCS)
        communicate()
        Form1.SerialPort1.Close()
        ' Set information on the screen

        'Console.WriteLine(RXD)
        'Form1.lblDone105.Text = RXD.Substring(7, 4) 'CInt("&H" & RXD.Substring(7, 4))
        'Form1.lbl106.Text = RXD.Substring(11, 4) 'CInt("&H" & RXD.Substring(11, 4))
        'Form1.lbl107.Text = RXD.Substring(15, 4)
        'Form1.lbl108.Text = RXD.Substring(19, 4)
        'Form1.lbl109.Text = RXD.Substring(23, 4)

        'Form1.lblTrayCounter.Text = (CInt(RXD.Substring(15, 4) & RXD.Substring(11, 4))).ToString("N0")
        'Form1.lblRemTrayQty.Text = (CInt(RXD.Substring(23, 4) & RXD.Substring(19, 4))).ToString("N0")

        ''actl_qty_lbl.Text = (CInt(RXD.Substring(15, 4))).ToString("N0")
        'actl_tray_qty_lbl.Text = (CInt(RXD.Substring(19, 4))).ToString("N0")
        'actl_qty_lbl.Text = ((CDec(RXD.Substring(19, 4))) * slide_qty).ToString("N0")
        'PLC_alarm = CInt(RXD.Substring(23, 4))
        'temp1_plus_offset = CInt(RXD.Substring(27, 4))
        'temp1_neg_offset = CInt(RXD.Substring(31, 4))
        'temp2_plus_offset = CInt(RXD.Substring(35, 4))
        'temp2_neg_offset = CInt(RXD.Substring(39, 4))

        If RXD = "error" Then
            Form1.send_status_lbl.Text = "Communication lost..."
        Else
            Form1.send_status_lbl.Text = "Connected to PLC."
        End If
        Form1.Timer1.Enabled = True
    End Sub

    Sub GetFCS()
        'This will calculate the FCS value for the communications
        Dim trans_text As Integer
        Dim sumcheck_single As String
        Dim running_check As String
        trans_text = Len(TX)
        sumcheck_single = 0
        For n = 1 To trans_text
            running_check = Mid$(TX, n, 1)
            sumcheck_single = Asc(running_check) Xor sumcheck_single
        Next n
        FCS = Hex$(sumcheck_single)
        If Len(FCS) = 1 Then FCS = "0" + FCS
    End Sub

    Sub communicate()
        'This will communicate to the Omron PLC
        Dim BufferTX As String
        Dim fcs_rxd As String
        Try
            RXD = ""
            BufferTX = TX + FCS + "*" + Chr(13)

            'Send the information out the serial port
            Form1.SerialPort1.Write(BufferTX)

            'Sleep for 50 msec so the information can be sent on the port
            System.Threading.Thread.Sleep(50)

            'Set the timeout for the serial port at 100 msec
            Form1.SerialPort1.ReadTimeout = 100

            'Read up to the carriage return
            RXD = (Form1.SerialPort1.ReadTo(Chr(13)))
            'Console.WriteLine(RXD)
        Catch ex As Exception
            'If an error occurs then indicate communication error
            RXD = "error"
        End Try

        'Get the FCS of the returned information
        fcs_rxd = RXD.Substring(RXD.Length - 3, 2)
        If RXD.Substring(0, 1) = "@" Then
            TX = RXD.Substring(0, RXD.Length - 3)
        ElseIf RXD.Substring(2, 1) = "@" Then
            TX = RXD.Substring(2, RXD.Length - 5)
            RXD = RXD.Substring(2, RXD.Length - 1)
        End If

        'Check the FCS of the return information. If they are not the same then an error has occurred.
        GetFCS()
        If FCS <> fcs_rxd Then
            RXD = "Communication Error"
        End If
    End Sub

    Public tosend As String

    Public Sub to_PLC(mystring As String)
        Form1.send_status_lbl.Text = "Send to PLC initiated.."
        If Form1.SerialPort1.IsOpen = False Then
            Form1.SerialPort1.Open()
        End If
        System.Threading.Thread.Sleep(50)
        ' write data to D0,D1,D2,D3,D4,D5,D6
        tosend = mystring '"@00WD0000" & "F000" & "E000"
        Dim trans_text As Integer
        Dim sumcheck_single As String
        Dim running_check As String
        trans_text = Len(tosend)
        sumcheck_single = 0
        For n = 1 To trans_text
            running_check = Mid$(tosend, n, 1)
            sumcheck_single = Asc(running_check) Xor sumcheck_single
        Next n
        FCS = Hex$(sumcheck_single)
        If Len(FCS) = 1 Then FCS = "0" + FCS



        Dim BufferTX As String
        Try
            RXD = ""
            BufferTX = tosend + FCS + "*" + Chr(13)

            'Send the information out the serial port
            Form1.SerialPort1.Write(BufferTX)

            'Sleep for 50 msec so the information can be sent on the port
            System.Threading.Thread.Sleep(50)

            'Set the timeout for the serial port at 100 msec
            Form1.SerialPort1.ReadTimeout = 100

            'Read up to the carriage return
            RXD = (Form1.SerialPort1.ReadTo(Chr(13)))
            If RXD = "@00WD0053*" Then
                Form1.send_status_lbl.Text = "Send to PLC success.."
            Else
                MsgBox("Send to PLC error!", vbCritical)
            End If

            'Console.WriteLine(RXD)
        Catch ex As Exception
            'If an error occurs then indicate communication error
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Module

Module OmronPLCCommand_Module

    Sub DoorOpen()
        to_PLC("@00WD00000001") 'Start Conveyor
    End Sub

End Module

Module SaveHistory_Module
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\LF Warehouse BioData.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfwhbiometrics"
    Public connection As New OleDbConnection(connString)
    Sub Traceability()
        Dim mycommand As String
        Dim _dateNtime As String = Date.Now.ToString("MM-dd-yyyy HH:mm tt")
        Dim _Name As String = MainPanel_Form.F1_get_user
        Dim _Dept As String = MainPanel_Form.F1_get_title


        Try
            connection.Open()
            mycommand = "INSERT INTO [History_tb] ([Associate_Name],[_Department],[_DateaAndTime]) VALUES (@_name, @Department, @_dateNtime)"
            Using command As New OleDbCommand(mycommand, connection)
                command.Parameters.AddWithValue("@_name", _Name)
                command.Parameters.AddWithValue("@Department", _Dept)
                command.Parameters.AddWithValue("@_dateNtime", _dateNtime)
                command.ExecuteNonQuery()
            End Using
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Module