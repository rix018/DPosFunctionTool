<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGetFieldCount = New System.Windows.Forms.TextBox()
        Me.lblGetFieldResult = New System.Windows.Forms.Label()
        Me.btnGetFieldResult = New System.Windows.Forms.Button()
        Me.txtGetFieldDelimeter = New System.Windows.Forms.TextBox()
        Me.txtGetFieldString = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEnDeOutput = New System.Windows.Forms.TextBox()
        Me.txtEnDeString = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkCMMRunas = New System.Windows.Forms.CheckBox()
        Me.btnCommand = New System.Windows.Forms.Button()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRSAI = New System.Windows.Forms.Button()
        Me.txtRSAIDecrypt = New System.Windows.Forms.TextBox()
        Me.txtRSAIEncrypt = New System.Windows.Forms.TextBox()
        Me.txtRSAIOriginal = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCharCode = New System.Windows.Forms.TextBox()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.btnLettertoCharcode = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblOSInfoCHAINPw = New System.Windows.Forms.Label()
        Me.lblOSInfoDSOFTPw = New System.Windows.Forms.Label()
        Me.btnOSFULL = New System.Windows.Forms.Button()
        Me.lblOSInfoOSFull = New System.Windows.Forms.Label()
        Me.lblOSInfoPCName = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblCharCount = New System.Windows.Forms.Label()
        Me.txtCharCount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.btnGenerateID = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "String"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtGetFieldCount)
        Me.GroupBox1.Controls.Add(Me.lblGetFieldResult)
        Me.GroupBox1.Controls.Add(Me.btnGetFieldResult)
        Me.GroupBox1.Controls.Add(Me.txtGetFieldDelimeter)
        Me.GroupBox1.Controls.Add(Me.txtGetFieldString)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 129)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GetField"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Count"
        '
        'txtGetFieldCount
        '
        Me.txtGetFieldCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetFieldCount.Location = New System.Drawing.Point(75, 85)
        Me.txtGetFieldCount.Name = "txtGetFieldCount"
        Me.txtGetFieldCount.Size = New System.Drawing.Size(89, 20)
        Me.txtGetFieldCount.TabIndex = 17
        '
        'lblGetFieldResult
        '
        Me.lblGetFieldResult.AutoSize = True
        Me.lblGetFieldResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGetFieldResult.Location = New System.Drawing.Point(188, 88)
        Me.lblGetFieldResult.Name = "lblGetFieldResult"
        Me.lblGetFieldResult.Size = New System.Drawing.Size(43, 13)
        Me.lblGetFieldResult.TabIndex = 16
        Me.lblGetFieldResult.Text = "Result: "
        '
        'btnGetFieldResult
        '
        Me.btnGetFieldResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetFieldResult.Location = New System.Drawing.Point(237, 33)
        Me.btnGetFieldResult.Name = "btnGetFieldResult"
        Me.btnGetFieldResult.Size = New System.Drawing.Size(82, 39)
        Me.btnGetFieldResult.TabIndex = 15
        Me.btnGetFieldResult.Text = "Return"
        Me.btnGetFieldResult.UseVisualStyleBackColor = True
        '
        'txtGetFieldDelimeter
        '
        Me.txtGetFieldDelimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetFieldDelimeter.Location = New System.Drawing.Point(75, 59)
        Me.txtGetFieldDelimeter.Name = "txtGetFieldDelimeter"
        Me.txtGetFieldDelimeter.Size = New System.Drawing.Size(156, 20)
        Me.txtGetFieldDelimeter.TabIndex = 14
        '
        'txtGetFieldString
        '
        Me.txtGetFieldString.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetFieldString.Location = New System.Drawing.Point(75, 33)
        Me.txtGetFieldString.Name = "txtGetFieldString"
        Me.txtGetFieldString.Size = New System.Drawing.Size(156, 20)
        Me.txtGetFieldString.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Delimeter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "String"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDecrypt)
        Me.GroupBox2.Controls.Add(Me.btnEncrypt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtEnDeOutput)
        Me.GroupBox2.Controls.Add(Me.txtEnDeString)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 129)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Decrypt/Encrypt"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(145, 88)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(82, 26)
        Me.btnDecrypt.TabIndex = 28
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.Location = New System.Drawing.Point(57, 88)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(82, 26)
        Me.btnEncrypt.TabIndex = 27
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Output"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "String"
        '
        'txtEnDeOutput
        '
        Me.txtEnDeOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnDeOutput.Location = New System.Drawing.Point(71, 59)
        Me.txtEnDeOutput.Name = "txtEnDeOutput"
        Me.txtEnDeOutput.Size = New System.Drawing.Size(156, 20)
        Me.txtEnDeOutput.TabIndex = 24
        '
        'txtEnDeString
        '
        Me.txtEnDeString.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnDeString.Location = New System.Drawing.Point(71, 33)
        Me.txtEnDeString.Name = "txtEnDeString"
        Me.txtEnDeString.Size = New System.Drawing.Size(156, 20)
        Me.txtEnDeString.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCMMRunas)
        Me.GroupBox3.Controls.Add(Me.btnCommand)
        Me.GroupBox3.Controls.Add(Me.txtCommand)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 83)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Run CMD"
        '
        'chkCMMRunas
        '
        Me.chkCMMRunas.AutoSize = True
        Me.chkCMMRunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCMMRunas.Location = New System.Drawing.Point(21, 53)
        Me.chkCMMRunas.Name = "chkCMMRunas"
        Me.chkCMMRunas.Size = New System.Drawing.Size(98, 17)
        Me.chkCMMRunas.TabIndex = 18
        Me.chkCMMRunas.Text = "Run as ADMIN"
        Me.chkCMMRunas.UseVisualStyleBackColor = True
        '
        'btnCommand
        '
        Me.btnCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommand.Location = New System.Drawing.Point(243, 27)
        Me.btnCommand.Name = "btnCommand"
        Me.btnCommand.Size = New System.Drawing.Size(93, 33)
        Me.btnCommand.TabIndex = 16
        Me.btnCommand.Text = "Execute"
        Me.btnCommand.UseVisualStyleBackColor = True
        '
        'txtCommand
        '
        Me.txtCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.Location = New System.Drawing.Point(17, 27)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(220, 20)
        Me.txtCommand.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.btnRSAI)
        Me.GroupBox4.Controls.Add(Me.txtRSAIDecrypt)
        Me.GroupBox4.Controls.Add(Me.txtRSAIEncrypt)
        Me.GroupBox4.Controls.Add(Me.txtRSAIOriginal)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(372, 147)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 143)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RSA Decrypt/Encrypt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Decrypted"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Encrypted"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "String"
        '
        'btnRSAI
        '
        Me.btnRSAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRSAI.Location = New System.Drawing.Point(187, 103)
        Me.btnRSAI.Name = "btnRSAI"
        Me.btnRSAI.Size = New System.Drawing.Size(108, 33)
        Me.btnRSAI.TabIndex = 46
        Me.btnRSAI.Text = "Convert"
        Me.btnRSAI.UseVisualStyleBackColor = True
        '
        'txtRSAIDecrypt
        '
        Me.txtRSAIDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSAIDecrypt.Location = New System.Drawing.Point(88, 77)
        Me.txtRSAIDecrypt.Name = "txtRSAIDecrypt"
        Me.txtRSAIDecrypt.Size = New System.Drawing.Size(207, 20)
        Me.txtRSAIDecrypt.TabIndex = 45
        '
        'txtRSAIEncrypt
        '
        Me.txtRSAIEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSAIEncrypt.Location = New System.Drawing.Point(88, 51)
        Me.txtRSAIEncrypt.Name = "txtRSAIEncrypt"
        Me.txtRSAIEncrypt.Size = New System.Drawing.Size(207, 20)
        Me.txtRSAIEncrypt.TabIndex = 44
        '
        'txtRSAIOriginal
        '
        Me.txtRSAIOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRSAIOriginal.Location = New System.Drawing.Point(88, 25)
        Me.txtRSAIOriginal.Name = "txtRSAIOriginal"
        Me.txtRSAIOriginal.Size = New System.Drawing.Size(156, 20)
        Me.txtRSAIOriginal.TabIndex = 43
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtCharCode)
        Me.GroupBox5.Controls.Add(Me.txtLetter)
        Me.GroupBox5.Controls.Add(Me.btnLettertoCharcode)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 233)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(344, 96)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Char Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Output"
        '
        'txtCharCode
        '
        Me.txtCharCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharCode.Location = New System.Drawing.Point(75, 51)
        Me.txtCharCode.Name = "txtCharCode"
        Me.txtCharCode.Size = New System.Drawing.Size(162, 20)
        Me.txtCharCode.TabIndex = 32
        '
        'txtLetter
        '
        Me.txtLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetter.Location = New System.Drawing.Point(75, 25)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(162, 20)
        Me.txtLetter.TabIndex = 31
        '
        'btnLettertoCharcode
        '
        Me.btnLettertoCharcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLettertoCharcode.Location = New System.Drawing.Point(243, 25)
        Me.btnLettertoCharcode.Name = "btnLettertoCharcode"
        Me.btnLettertoCharcode.Size = New System.Drawing.Size(82, 46)
        Me.btnLettertoCharcode.TabIndex = 30
        Me.btnLettertoCharcode.Text = "Convert"
        Me.btnLettertoCharcode.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblOSInfoCHAINPw)
        Me.GroupBox6.Controls.Add(Me.lblOSInfoDSOFTPw)
        Me.GroupBox6.Controls.Add(Me.btnOSFULL)
        Me.GroupBox6.Controls.Add(Me.lblOSInfoOSFull)
        Me.GroupBox6.Controls.Add(Me.lblOSInfoPCName)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(372, 296)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(344, 123)
        Me.GroupBox6.TabIndex = 45
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "OS information"
        '
        'lblOSInfoCHAINPw
        '
        Me.lblOSInfoCHAINPw.AutoSize = True
        Me.lblOSInfoCHAINPw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSInfoCHAINPw.Location = New System.Drawing.Point(17, 98)
        Me.lblOSInfoCHAINPw.Name = "lblOSInfoCHAINPw"
        Me.lblOSInfoCHAINPw.Size = New System.Drawing.Size(92, 13)
        Me.lblOSInfoCHAINPw.TabIndex = 4
        Me.lblOSInfoCHAINPw.Text = "CHAIN Password:"
        '
        'lblOSInfoDSOFTPw
        '
        Me.lblOSInfoDSOFTPw.AutoSize = True
        Me.lblOSInfoDSOFTPw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSInfoDSOFTPw.Location = New System.Drawing.Point(17, 73)
        Me.lblOSInfoDSOFTPw.Name = "lblOSInfoDSOFTPw"
        Me.lblOSInfoDSOFTPw.Size = New System.Drawing.Size(95, 13)
        Me.lblOSInfoDSOFTPw.TabIndex = 3
        Me.lblOSInfoDSOFTPw.Text = "DSOFT Password:"
        '
        'btnOSFULL
        '
        Me.btnOSFULL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOSFULL.Location = New System.Drawing.Point(317, 44)
        Me.btnOSFULL.Name = "btnOSFULL"
        Me.btnOSFULL.Size = New System.Drawing.Size(21, 23)
        Me.btnOSFULL.TabIndex = 2
        Me.btnOSFULL.Text = "..."
        Me.btnOSFULL.UseVisualStyleBackColor = True
        '
        'lblOSInfoOSFull
        '
        Me.lblOSInfoOSFull.AutoSize = True
        Me.lblOSInfoOSFull.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSInfoOSFull.Location = New System.Drawing.Point(17, 49)
        Me.lblOSInfoOSFull.Name = "lblOSInfoOSFull"
        Me.lblOSInfoOSFull.Size = New System.Drawing.Size(78, 13)
        Me.lblOSInfoOSFull.TabIndex = 1
        Me.lblOSInfoOSFull.Text = "OS Full Name: "
        '
        'lblOSInfoPCName
        '
        Me.lblOSInfoPCName.AutoSize = True
        Me.lblOSInfoPCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSInfoPCName.Location = New System.Drawing.Point(17, 23)
        Me.lblOSInfoPCName.Name = "lblOSInfoPCName"
        Me.lblOSInfoPCName.Size = New System.Drawing.Size(89, 13)
        Me.lblOSInfoPCName.TabIndex = 0
        Me.lblOSInfoPCName.Text = "Computer Name: "
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblCharCount)
        Me.GroupBox7.Controls.Add(Me.txtCharCount)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 335)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(344, 84)
        Me.GroupBox7.TabIndex = 46
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Char Count"
        '
        'lblCharCount
        '
        Me.lblCharCount.AutoSize = True
        Me.lblCharCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharCount.Location = New System.Drawing.Point(74, 54)
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.Size = New System.Drawing.Size(96, 13)
        Me.lblCharCount.TabIndex = 35
        Me.lblCharCount.Text = "Character Count: 0"
        '
        'txtCharCount
        '
        Me.txtCharCount.Location = New System.Drawing.Point(73, 22)
        Me.txtCharCount.Name = "txtCharCount"
        Me.txtCharCount.Size = New System.Drawing.Size(252, 20)
        Me.txtCharCount.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Type Here"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 433)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "ClientID"
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(12, 449)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(252, 20)
        Me.txtClientID.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 481)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Token"
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(12, 497)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(252, 20)
        Me.txtToken.TabIndex = 50
        '
        'btnGenerateID
        '
        Me.btnGenerateID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateID.Location = New System.Drawing.Point(270, 442)
        Me.btnGenerateID.Name = "btnGenerateID"
        Me.btnGenerateID.Size = New System.Drawing.Size(114, 32)
        Me.btnGenerateID.TabIndex = 51
        Me.btnGenerateID.Text = "Generate"
        Me.btnGenerateID.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(778, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 20)
        Me.TextBox1.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(738, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Date"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(778, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(65, 20)
        Me.TextBox2.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(738, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Days"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(800, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(738, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Result: "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 555)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnGenerateID)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DPos Function Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGetFieldCount As TextBox
    Friend WithEvents lblGetFieldResult As Label
    Friend WithEvents btnGetFieldResult As Button
    Friend WithEvents txtGetFieldDelimeter As TextBox
    Friend WithEvents txtGetFieldString As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEnDeOutput As TextBox
    Friend WithEvents txtEnDeString As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkCMMRunas As CheckBox
    Friend WithEvents btnCommand As Button
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRSAI As Button
    Friend WithEvents txtRSAIDecrypt As TextBox
    Friend WithEvents txtRSAIEncrypt As TextBox
    Friend WithEvents txtRSAIOriginal As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCharCode As TextBox
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents btnLettertoCharcode As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblOSInfoOSFull As Label
    Friend WithEvents lblOSInfoPCName As Label
    Friend WithEvents btnOSFULL As Button
    Friend WithEvents lblOSInfoDSOFTPw As Label
    Friend WithEvents lblOSInfoCHAINPw As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblCharCount As Label
    Friend WithEvents txtCharCount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtToken As TextBox
    Friend WithEvents btnGenerateID As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
End Class
