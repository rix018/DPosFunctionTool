Imports System.Security.Cryptography
Imports System.Text
Public Class frmMain

    Private Sub btnGetFieldResult_Click(sender As Object, e As EventArgs) Handles btnGetFieldResult.Click
        If (Me.txtGetFieldString.Text <> "" And Me.txtGetFieldDelimeter.Text <> "" And Me.txtGetFieldCount.Text <> "") And (IsNumeric(Me.txtGetFieldCount.Text)) Then
            Me.lblGetFieldResult.Text = "Result: " & GetField(Me.txtGetFieldString.Text, Me.txtGetFieldDelimeter.Text, Me.txtGetFieldCount.Text)
        Else
            Me.lblGetFieldResult.Text = "Result: "
        End If
    End Sub

    Private Sub btnCommand_Click(sender As Object, e As EventArgs) Handles btnCommand.Click
        If Me.txtCommand.Text <> "" Then
            CMDShellMySQL(Me.txtCommand.Text, False, chkCMMRunas.CheckState)
        End If

    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        EncryptDecryptProcess("Encrypt")
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        EncryptDecryptProcess("Decrypt")
    End Sub

    Private Sub EncryptDecryptProcess(ByVal sMethod As String)
        Me.txtEnDeOutput.Text = ""
        If Me.txtEnDeString.Text <> "" Then
            If sMethod = "Encrypt" Then
                Me.txtEnDeOutput.Text = Encrypt(Me.txtEnDeString.Text)
            Else
                Me.txtEnDeOutput.Text = Decrypt(Me.txtEnDeString.Text)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim textbytes, encryptedtextbytes As Byte()
        Dim rsa As New RSACryptoServiceProvider
        Dim encoder As New UTF8Encoding

        Dim DecryptedText As String = Me.txtRSAIOriginal.Text

        textbytes = encoder.GetBytes(DecryptedText)

        encryptedtextbytes = rsa.Encrypt(textbytes, True)

        txtRSAIEncrypt.Text = Convert.ToBase64String(encryptedtextbytes)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRSAI.Click

        Dim textbytes, encryptedtextbytes As Byte()
        Dim rsa As New RSACryptoServiceProvider
        Dim encoder As New UTF8Encoding

        Dim DecryptedText As String = Me.txtRSAIOriginal.Text

        textbytes = encoder.GetBytes(DecryptedText)

        encryptedtextbytes = rsa.Encrypt(textbytes, True)

        txtRSAIEncrypt.Text = Convert.ToBase64String(encryptedtextbytes)

        textbytes = rsa.Decrypt(encryptedtextbytes, True)

        txtRSAIDecrypt.Text = encoder.GetString(textbytes)


    End Sub

    Private Function RSAalgo(ByVal sToConvert As ArrayList, ByVal sMethod As String) As String
        Dim oReturn As Object = Nothing
        Dim PrimeNo1 As Integer
        Dim PrimeNo2 As Integer
        Dim e As Integer
        Dim k As Integer
        Dim thisPhi As Integer
        Dim thisPublicKey As Integer
        Dim thisPrivateKey As Integer

        'RSA constants
        PrimeNo1 = 57
        PrimeNo2 = 59
        e = 2
        k = 3

        thisPhi = (PrimeNo1 - 1) * (PrimeNo2 - 1)

        thisPublicKey = PrimeNo1 * PrimeNo2         'encrypt and n
        thisPrivateKey = (1 + (k * thisPhi)) / e    'decrypt

        If sMethod = "Encrypt" Then
            For Each cCode As Integer In sToConvert
                Dim enc As Double = Math.Pow(thisPublicKey, cCode)
                enc = enc \ thisPublicKey
                oReturn &= enc
            Next
        Else
            For Each cCode As Integer In sToConvert
                Dim dec As Double = Math.Pow(thisPrivateKey, cCode)
                dec = dec \ thisPublicKey
                oReturn &= dec
            Next
        End If

        Return oReturn
    End Function

    Private Function convertEachLettertoAscii(ByVal sString As String) As ArrayList
        Dim iReturn As New ArrayList
        Dim thisChar As Char

        For Each thisChar In sString
            iReturn.Add(Asc(thisChar).ToString.PadLeft(3, "0"))
        Next

        Return iReturn
    End Function

    Private Function convertEachLettertoAscii2(ByVal sString As String) As String
        Dim iReturn As String = ""
        Dim thisChar As Char

        For Each thisChar In sString
            iReturn &= Asc(thisChar).ToString.PadLeft(3, "0")
        Next

        Return iReturn
    End Function
    Private Function convertAsciitoLetter(ByVal sString As String) As ArrayList
        Dim iReturn As New ArrayList

        For Each thisChar In sString
            iReturn.Add(thisChar.ToString.PadLeft(3, "0"))
        Next

        Return iReturn
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblOSInfoPCName.Text = "Computer Name: " & My.Computer.Name.ToString
        Me.lblOSInfoOSFull.Text = "OS Full Name: " & My.Computer.Info.OSFullName.ToString
        Me.lblOSInfoDSOFTPw.Text = "DSOFT Password: " & GetDSoftPassword()
        Me.lblOSInfoCHAINPw.Text = "CHAIN Password: " & GetChainPassword()
    End Sub

    Private Sub btnLettertoCharcode_Click(sender As Object, e As EventArgs) Handles btnLettertoCharcode.Click
        Me.txtCharCode.Text = convertEachLettertoAscii2(Me.txtLetter.Text).ToString
        'Me.txtCharCode.Text = RSAalgo(convertEachLettertoAscii(Me.txtLetter.Text), "Encrypt")
    End Sub

    Private Function keme(ByVal sString As String) As String
        Dim sReturn As String = ""

        sString = sString.Replace("\", "/")

        sReturn = sString

        Return sReturn
    End Function

    Private Sub btnOSFULL_Click(sender As Object, e As EventArgs) Handles btnOSFULL.Click
        MessageBox.Show("OS Full Name: " & My.Computer.Info.OSFullName.ToString)
    End Sub

    Private Sub txtCharCount_TextChanged(sender As Object, e As EventArgs) Handles txtCharCount.TextChanged
        Me.lblCharCount.Text = "Character Count: " & Me.txtCharCount.Text.Length
    End Sub

    Private Sub btnGenerateID_Click(sender As Object, e As EventArgs) Handles btnGenerateID.Click
        If txtClientID.Text.Trim <> "" Then
            txtToken.Text = GenerateClientID(txtClientID.Text)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox1.Text.Length <> 8 Then
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            Exit Sub
        End If

        Try
            Dim sFormattedDate As Date = CDate(TextBox1.Text.Substring(0, 4) & "/" & TextBox1.Text.Substring(4, 2) & "/" & TextBox1.Text.Substring(6, 2))
        Catch ex As Exception

        End Try



    End Sub
End Class
