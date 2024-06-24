Public Class ChangeSerial_Form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        MainPanel_Load()
    End Sub

    Private Sub ChangeSerial_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComPort()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ButtonSaveSerial()
    End Sub
End Class