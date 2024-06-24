Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MainPanel_Load()

        GetSerialName()
        SerialPort1.PortName = Serial1

        'Timer1.Enabled = True
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.ExitThread()
    End Sub

    Private Sub AddAssociateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAssociateToolStripMenuItem.Click
        AddUser_Load()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PLCTimerFunction()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2Function()
    End Sub

    Private Sub ChangeSerialNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSerialNameToolStripMenuItem.Click
        ChangeSerial_Load()
    End Sub
End Class
