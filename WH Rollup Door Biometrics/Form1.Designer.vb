<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.send_status_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl106 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRemTrayQty = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTrayCounter = New System.Windows.Forms.Label()
        Me.lbl107 = New System.Windows.Forms.Label()
        Me.lbl109 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDone105 = New System.Windows.Forms.Label()
        Me.lbl108 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAssociateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSerialNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button1.Location = New System.Drawing.Point(1251, -1)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(25, 25)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Guna2Button1"
        '
        'send_status_lbl
        '
        Me.send_status_lbl.BackColor = System.Drawing.Color.Transparent
        Me.send_status_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send_status_lbl.Location = New System.Drawing.Point(132, 29)
        Me.send_status_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.send_status_lbl.Name = "send_status_lbl"
        Me.send_status_lbl.Size = New System.Drawing.Size(220, 28)
        Me.send_status_lbl.TabIndex = 122
        Me.send_status_lbl.Text = "Status"
        Me.send_status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.send_status_lbl.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(198, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Qty:"
        Me.Label3.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(170, 248)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Reserve2:"
        Me.Label14.Visible = False
        '
        'lbl106
        '
        Me.lbl106.AutoSize = True
        Me.lbl106.BackColor = System.Drawing.Color.Transparent
        Me.lbl106.Location = New System.Drawing.Point(230, 225)
        Me.lbl106.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl106.Name = "lbl106"
        Me.lbl106.Size = New System.Drawing.Size(25, 13)
        Me.lbl106.TabIndex = 118
        Me.lbl106.Text = "106"
        Me.lbl106.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(200, 272)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Qty:"
        Me.Label2.Visible = False
        '
        'lblRemTrayQty
        '
        Me.lblRemTrayQty.AutoSize = True
        Me.lblRemTrayQty.BackColor = System.Drawing.Color.Transparent
        Me.lblRemTrayQty.Location = New System.Drawing.Point(230, 119)
        Me.lblRemTrayQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRemTrayQty.Name = "lblRemTrayQty"
        Me.lblRemTrayQty.Size = New System.Drawing.Size(13, 13)
        Me.lblRemTrayQty.TabIndex = 130
        Me.lblRemTrayQty.Text = "0"
        Me.lblRemTrayQty.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(172, 201)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Done Lot:"
        Me.Label7.Visible = False
        '
        'lblTrayCounter
        '
        Me.lblTrayCounter.AutoSize = True
        Me.lblTrayCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblTrayCounter.Location = New System.Drawing.Point(232, 272)
        Me.lblTrayCounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTrayCounter.Name = "lblTrayCounter"
        Me.lblTrayCounter.Size = New System.Drawing.Size(13, 13)
        Me.lblTrayCounter.TabIndex = 124
        Me.lblTrayCounter.Text = "0"
        Me.lblTrayCounter.Visible = False
        '
        'lbl107
        '
        Me.lbl107.AutoSize = True
        Me.lbl107.BackColor = System.Drawing.Color.Transparent
        Me.lbl107.Location = New System.Drawing.Point(232, 248)
        Me.lbl107.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl107.Name = "lbl107"
        Me.lbl107.Size = New System.Drawing.Size(25, 13)
        Me.lbl107.TabIndex = 120
        Me.lbl107.Text = "107"
        Me.lbl107.Visible = False
        '
        'lbl109
        '
        Me.lbl109.AutoSize = True
        Me.lbl109.BackColor = System.Drawing.Color.Transparent
        Me.lbl109.Location = New System.Drawing.Point(232, 95)
        Me.lbl109.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl109.Name = "lbl109"
        Me.lbl109.Size = New System.Drawing.Size(25, 13)
        Me.lbl109.TabIndex = 128
        Me.lbl109.Text = "109"
        Me.lbl109.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(172, 225)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Reserve1:"
        Me.Label8.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(172, 72)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Reserve3:"
        Me.Label10.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(170, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Reserve4:"
        Me.Label4.Visible = False
        '
        'lblDone105
        '
        Me.lblDone105.AutoSize = True
        Me.lblDone105.BackColor = System.Drawing.Color.Transparent
        Me.lblDone105.Location = New System.Drawing.Point(230, 201)
        Me.lblDone105.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDone105.Name = "lblDone105"
        Me.lblDone105.Size = New System.Drawing.Size(25, 13)
        Me.lblDone105.TabIndex = 116
        Me.lblDone105.Text = "000"
        Me.lblDone105.Visible = False
        '
        'lbl108
        '
        Me.lbl108.AutoSize = True
        Me.lbl108.BackColor = System.Drawing.Color.Transparent
        Me.lbl108.Location = New System.Drawing.Point(230, 72)
        Me.lbl108.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl108.Name = "lbl108"
        Me.lbl108.Size = New System.Drawing.Size(25, 13)
        Me.lbl108.TabIndex = 126
        Me.lbl108.Text = "108"
        Me.lbl108.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1280, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAssociateToolStripMenuItem, Me.ChangeSerialNameToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AddAssociateToolStripMenuItem
        '
        Me.AddAssociateToolStripMenuItem.Image = CType(resources.GetObject("AddAssociateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddAssociateToolStripMenuItem.Name = "AddAssociateToolStripMenuItem"
        Me.AddAssociateToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AddAssociateToolStripMenuItem.Text = "Add Associate"
        '
        'ChangeSerialNameToolStripMenuItem
        '
        Me.ChangeSerialNameToolStripMenuItem.Image = CType(resources.GetObject("ChangeSerialNameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeSerialNameToolStripMenuItem.Name = "ChangeSerialNameToolStripMenuItem"
        Me.ChangeSerialNameToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ChangeSerialNameToolStripMenuItem.Text = "Change Serial Name"
        '
        'SerialPort1
        '
        Me.SerialPort1.DataBits = 7
        Me.SerialPort1.Parity = System.IO.Ports.Parity.Even
        Me.SerialPort1.StopBits = System.IO.Ports.StopBits.Two
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(158, 966)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Time"
        Me.Label1.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MainPanel.BackColor = System.Drawing.SystemColors.Control
        Me.MainPanel.Controls.Add(Me.send_status_lbl)
        Me.MainPanel.Controls.Add(Me.Label8)
        Me.MainPanel.Controls.Add(Me.Label3)
        Me.MainPanel.Controls.Add(Me.lbl109)
        Me.MainPanel.Controls.Add(Me.Label10)
        Me.MainPanel.Controls.Add(Me.Label14)
        Me.MainPanel.Controls.Add(Me.lbl107)
        Me.MainPanel.Controls.Add(Me.lbl106)
        Me.MainPanel.Controls.Add(Me.Label4)
        Me.MainPanel.Controls.Add(Me.lblTrayCounter)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Controls.Add(Me.lblDone105)
        Me.MainPanel.Controls.Add(Me.Label7)
        Me.MainPanel.Controls.Add(Me.lblRemTrayQty)
        Me.MainPanel.Controls.Add(Me.lbl108)
        Me.MainPanel.Location = New System.Drawing.Point(26, 68)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1225, 917)
        Me.MainPanel.TabIndex = 132
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1280, 1024)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents AddAssociateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRemTrayQty As Label
    Friend WithEvents lbl109 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl108 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl107 As Label
    Friend WithEvents lblTrayCounter As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl106 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents send_status_lbl As Label
    Friend WithEvents lblDone105 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ChangeSerialNameToolStripMenuItem As ToolStripMenuItem
End Class
