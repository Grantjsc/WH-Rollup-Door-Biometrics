<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser_Form))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.F4_Username_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Process_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Prod_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Production_CheckBox = New System.Windows.Forms.CheckBox()
        Me.QA_CheckBox = New System.Windows.Forms.CheckBox()
        Me.TSG_CheckBox = New System.Windows.Forms.CheckBox()
        Me.LEAN_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Log_CheckBox = New System.Windows.Forms.CheckBox()
        Me.WH_CheckBox = New System.Windows.Forms.CheckBox()
        Me.IQA_CheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.F4_Exit_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.F4_Login_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.F4_Username_txt)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(126, 477)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 429)
        Me.Panel2.TabIndex = 80
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Olive
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, -1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(470, 39)
        Me.TextBox1.TabIndex = 72
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "User Name"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F4_Username_txt
        '
        Me.F4_Username_txt.BackColor = System.Drawing.Color.Black
        Me.F4_Username_txt.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F4_Username_txt.ForeColor = System.Drawing.SystemColors.Menu
        Me.F4_Username_txt.Location = New System.Drawing.Point(-1, 36)
        Me.F4_Username_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.F4_Username_txt.Name = "F4_Username_txt"
        Me.F4_Username_txt.Size = New System.Drawing.Size(470, 44)
        Me.F4_Username_txt.TabIndex = 48
        Me.F4_Username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(137, 82)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 16)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "(First name Last name)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Process_CheckBox)
        Me.GroupBox1.Controls.Add(Me.Prod_CheckBox)
        Me.GroupBox1.Controls.Add(Me.Production_CheckBox)
        Me.GroupBox1.Controls.Add(Me.QA_CheckBox)
        Me.GroupBox1.Controls.Add(Me.TSG_CheckBox)
        Me.GroupBox1.Controls.Add(Me.LEAN_CheckBox)
        Me.GroupBox1.Controls.Add(Me.Log_CheckBox)
        Me.GroupBox1.Controls.Add(Me.WH_CheckBox)
        Me.GroupBox1.Controls.Add(Me.IQA_CheckBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(438, 292)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Department:"
        '
        'Process_CheckBox
        '
        Me.Process_CheckBox.AutoSize = True
        Me.Process_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.Process_CheckBox.Location = New System.Drawing.Point(17, 229)
        Me.Process_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Process_CheckBox.Name = "Process_CheckBox"
        Me.Process_CheckBox.Size = New System.Drawing.Size(148, 40)
        Me.Process_CheckBox.TabIndex = 60
        Me.Process_CheckBox.Text = "Process"
        Me.Process_CheckBox.UseVisualStyleBackColor = True
        '
        'Prod_CheckBox
        '
        Me.Prod_CheckBox.AutoSize = True
        Me.Prod_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prod_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.Prod_CheckBox.Location = New System.Drawing.Point(221, 177)
        Me.Prod_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Prod_CheckBox.Name = "Prod_CheckBox"
        Me.Prod_CheckBox.Size = New System.Drawing.Size(143, 40)
        Me.Prod_CheckBox.TabIndex = 59
        Me.Prod_CheckBox.Text = "Product"
        Me.Prod_CheckBox.UseVisualStyleBackColor = True
        '
        'Production_CheckBox
        '
        Me.Production_CheckBox.AutoSize = True
        Me.Production_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Production_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.Production_CheckBox.Location = New System.Drawing.Point(17, 177)
        Me.Production_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Production_CheckBox.Name = "Production_CheckBox"
        Me.Production_CheckBox.Size = New System.Drawing.Size(185, 40)
        Me.Production_CheckBox.TabIndex = 58
        Me.Production_CheckBox.Text = "Production"
        Me.Production_CheckBox.UseVisualStyleBackColor = True
        '
        'QA_CheckBox
        '
        Me.QA_CheckBox.AutoSize = True
        Me.QA_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QA_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.QA_CheckBox.Location = New System.Drawing.Point(221, 128)
        Me.QA_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QA_CheckBox.Name = "QA_CheckBox"
        Me.QA_CheckBox.Size = New System.Drawing.Size(80, 40)
        Me.QA_CheckBox.TabIndex = 57
        Me.QA_CheckBox.Text = "QA"
        Me.QA_CheckBox.UseVisualStyleBackColor = True
        '
        'TSG_CheckBox
        '
        Me.TSG_CheckBox.AutoSize = True
        Me.TSG_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSG_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.TSG_CheckBox.Location = New System.Drawing.Point(17, 128)
        Me.TSG_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSG_CheckBox.Name = "TSG_CheckBox"
        Me.TSG_CheckBox.Size = New System.Drawing.Size(99, 40)
        Me.TSG_CheckBox.TabIndex = 56
        Me.TSG_CheckBox.Text = "TSG"
        Me.TSG_CheckBox.UseVisualStyleBackColor = True
        '
        'LEAN_CheckBox
        '
        Me.LEAN_CheckBox.AutoSize = True
        Me.LEAN_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEAN_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.LEAN_CheckBox.Location = New System.Drawing.Point(221, 41)
        Me.LEAN_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LEAN_CheckBox.Name = "LEAN_CheckBox"
        Me.LEAN_CheckBox.Size = New System.Drawing.Size(104, 40)
        Me.LEAN_CheckBox.TabIndex = 55
        Me.LEAN_CheckBox.Text = "Lean"
        Me.LEAN_CheckBox.UseVisualStyleBackColor = True
        '
        'Log_CheckBox
        '
        Me.Log_CheckBox.AutoSize = True
        Me.Log_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Log_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.Log_CheckBox.Location = New System.Drawing.Point(17, 41)
        Me.Log_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Log_CheckBox.Name = "Log_CheckBox"
        Me.Log_CheckBox.Size = New System.Drawing.Size(150, 40)
        Me.Log_CheckBox.TabIndex = 52
        Me.Log_CheckBox.Text = "Logistcs"
        Me.Log_CheckBox.UseVisualStyleBackColor = True
        '
        'WH_CheckBox
        '
        Me.WH_CheckBox.AutoSize = True
        Me.WH_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WH_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.WH_CheckBox.Location = New System.Drawing.Point(17, 84)
        Me.WH_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.WH_CheckBox.Name = "WH_CheckBox"
        Me.WH_CheckBox.Size = New System.Drawing.Size(196, 40)
        Me.WH_CheckBox.TabIndex = 53
        Me.WH_CheckBox.Text = "Warehouse"
        Me.WH_CheckBox.UseVisualStyleBackColor = True
        '
        'IQA_CheckBox
        '
        Me.IQA_CheckBox.AutoSize = True
        Me.IQA_CheckBox.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IQA_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.IQA_CheckBox.Location = New System.Drawing.Point(221, 84)
        Me.IQA_CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IQA_CheckBox.Name = "IQA_CheckBox"
        Me.IQA_CheckBox.Size = New System.Drawing.Size(89, 40)
        Me.IQA_CheckBox.TabIndex = 54
        Me.IQA_CheckBox.Text = "IQA"
        Me.IQA_CheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(228, 107)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 351)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(701, 107)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 517)
        Me.Panel1.TabIndex = 82
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(46, 25)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(130, 181)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(231, 25)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(130, 181)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(71, 443)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Print 3"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(46, 255)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(130, 181)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 58
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(256, 443)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Print 4"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(2, 473)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(391, 18)
        Me.Label6.TabIndex = 64
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(231, 257)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(130, 181)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 59
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(256, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Print 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(71, 211)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Print 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F4_Exit_btn
        '
        Me.F4_Exit_btn.BorderRadius = 15
        Me.F4_Exit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.F4_Exit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.F4_Exit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.F4_Exit_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.F4_Exit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.F4_Exit_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F4_Exit_btn.FillColor2 = System.Drawing.Color.Maroon
        Me.F4_Exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F4_Exit_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.F4_Exit_btn.Location = New System.Drawing.Point(962, 747)
        Me.F4_Exit_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.F4_Exit_btn.Name = "F4_Exit_btn"
        Me.F4_Exit_btn.Size = New System.Drawing.Size(116, 49)
        Me.F4_Exit_btn.TabIndex = 84
        Me.F4_Exit_btn.Text = "Cancel"
        '
        'F4_Login_btn
        '
        Me.F4_Login_btn.BorderColor = System.Drawing.SystemColors.Control
        Me.F4_Login_btn.BorderRadius = 15
        Me.F4_Login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.F4_Login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.F4_Login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.F4_Login_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.F4_Login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.F4_Login_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.F4_Login_btn.FillColor2 = System.Drawing.Color.LimeGreen
        Me.F4_Login_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F4_Login_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.F4_Login_btn.Location = New System.Drawing.Point(792, 747)
        Me.F4_Login_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.F4_Login_btn.Name = "F4_Login_btn"
        Me.F4_Login_btn.Size = New System.Drawing.Size(116, 49)
        Me.F4_Login_btn.TabIndex = 83
        Me.F4_Login_btn.Text = "Add"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(403, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(405, 68)
        Me.lbl.TabIndex = 85
        Me.lbl.Text = "Add Associate"
        '
        'AddUser_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 917)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.F4_Exit_btn)
        Me.Controls.Add(Me.F4_Login_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddUser_Form"
        Me.Text = "AddUser_Form"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents F4_Username_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Prod_CheckBox As CheckBox
    Friend WithEvents Production_CheckBox As CheckBox
    Friend WithEvents QA_CheckBox As CheckBox
    Friend WithEvents TSG_CheckBox As CheckBox
    Friend WithEvents LEAN_CheckBox As CheckBox
    Friend WithEvents Log_CheckBox As CheckBox
    Friend WithEvents WH_CheckBox As CheckBox
    Friend WithEvents IQA_CheckBox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents F4_Exit_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents F4_Login_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lbl As Label
    Friend WithEvents Process_CheckBox As CheckBox
End Class
