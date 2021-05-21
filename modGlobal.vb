

Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text

Module modGlobal
    Private iErrorNbr As Integer

    Public Function GenerateClientID(ByVal sStoreID As String) As String

        Dim sMacAddress As String
        Dim sMacAddressSha As String
        Dim sClientIDMD5 As String
        Dim sFirstThreeChar As String
        Dim sGeneratedID As String = ""

        Try
            ' The mac address of the pc.
            sMacAddress = GetMacAddress()

            ' Generate a sha256 hash of the mac address.
            sMacAddressSha = GetSHA256(sMacAddress)

            ' Generate an md5 hash of the clientid.
            sClientIDMD5 = GetMd5Hash(sStoreID)

            ' Extract the first three characters of the md5 hash client id for salting. 
            sFirstThreeChar = sClientIDMD5.Substring(0, 3)

            ' Combine the first three characters of the md5 hash client id to the sha256 hash of the mac address and generate a sha256 hash.
            sGeneratedID = GetSHA256(sFirstThreeChar & sMacAddressSha)

        Catch ex As Exception
            MsgBox("GenerateClientID" & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try

        Return sGeneratedID

    End Function

    ''' <summary>
    ''' This function gets the mac address of the current computer.
    ''' </summary>
    ''' <returns>a string containing the mac address of the current computer.</returns>
    Public Function GetMacAddress() As String

        Dim sMacAddress As String = ""

        Try
            ' Browse through each NIC. (wireless, ethernet, etc.)
            For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                ' Only get the ethernet type and check if it is operational status is up.
                If nic.NetworkInterfaceType = Net.NetworkInformation.NetworkInterfaceType.Ethernet And nic.Name = "Local Area Connection" And nic.OperationalStatus = Net.NetworkInformation.OperationalStatus.Up Then
                    sMacAddress = nic.GetPhysicalAddress.ToString
                    Exit For
                End If

            Next

            ' The ethernet adapter is not available. Use whatever adapter is ipenabled(running).
            If sMacAddress = "" Then
                sMacAddress = GetMacAddressOfIPEnabled()
            End If

            ' There is no active adapter. Get the mac address of the ethernet adapter.
            If sMacAddress = "" Then
                For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                    ' Only get the ethernet type and check if it is operational status is up.
                    If nic.NetworkInterfaceType = Net.NetworkInformation.NetworkInterfaceType.Ethernet And nic.Name = "Local Area Connection" Then
                        sMacAddress = nic.GetPhysicalAddress.ToString
                        Exit For
                    End If

                Next
            End If

            ' There is no ethernet adapter detected. Get the first adapter from the list. Last resort.
            If sMacAddress = "" Then
                Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
                sMacAddress = nics(1).GetPhysicalAddress.ToString
            End If

        Catch ex As Exception
            MsgBox("GetMacAddress" & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try

        Return sMacAddress

    End Function

    ''' <summary>
    ''' This function gets the mac address of the current adapter that is enabled when the ethernet adapter is not present.
    ''' </summary>
    ''' <returns>a string containing the mac address of the current computer.</returns>
    Public Function GetMacAddressOfIPEnabled() As String

        Dim oWMIService As Object
        Dim oColAdapters As Object
        Dim oObjAdapter As Object
        Dim sMacAddress As String = ""

        Try

            oWMIService = GetObject("winmgmts:" & "!\\.\root\cimv2")
            oColAdapters = oWMIService.ExecQuery("Select * from Win32_NetworkAdapterConfiguration Where IPEnabled = True")

            For Each oObjAdapter In oColAdapters
                'MsgBox("MAC address formatted: " & oObjAdapter.MACAddress & vbNewLine & "MAC address unformatted: " & Replace(oObjAdapter.MACAddress, ":", ""))
                sMacAddress = Replace(oObjAdapter.MACAddress, ":", "")
                Exit For
            Next

            oObjAdapter = Nothing
            oColAdapters = Nothing
            oWMIService = Nothing

        Catch ex As Exception
            MsgBox("GetMacAddressOfIPEnabled" & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try

        Return sMacAddress

    End Function


    ''' <summary>
    ''' Hashes the given string using SHA256 encryption.
    ''' </summary>
    ''' <param name="sData">The string to be hashed.</param>
    ''' <returns>the string hashed using SHA256 encryption.</returns>
    Public Function GetSHA256(ByVal sData As String) As String

        Dim sResult As String = ""
        Dim sha = SHA256.Create
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(sData)

        Try
            bytesToHash = sha.ComputeHash(bytesToHash)

            For Each b As Byte In bytesToHash
                sResult += b.ToString("x2")
            Next

            ' Dispose the object to avoid memory leaks.
            sha.Dispose()

        Catch ex As Exception
            MsgBox("GetSHA256" & vbCrLf & ex.ToString, MsgBoxStyle.Critical)
        End Try

        Return sResult

    End Function

    Public Function GetMd5Hash(ByVal sData As String)

        Dim sHashedString As String = ""
        Dim md5Hash As MD5 = MD5.Create()
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(sData))     ' Convert the input string to a byte array and compute the hash. 

        Try
            ' Create a new Stringbuilder to collect the bytes and create a string. 
            Dim sBuilder As New StringBuilder()

            ' Loop through each byte of the hashed data and format each one as a hexadecimal string. 
            Dim iCount As Integer
            For iCount = 0 To data.Length - 1
                sBuilder.Append(data(iCount).ToString("x2"))
            Next iCount

            sHashedString = sBuilder.ToString

            ' Dispose the object to avoid memory leaks.
            md5Hash.Dispose()

        Catch ex As Exception
            MsgBox("GetMd5Hash" & vbCrLf & ex.ToString)
        End Try

        Return sHashedString

    End Function

    Public Function GetDSoftPassword() As String
        Dim i As Integer
        Dim s As String
        Dim iOut As Integer
        Dim sOut As String = ""

        s = Date.Today.Day.ToString.PadLeft(2, "0") & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Year.ToString.Substring(2, 2)
        For i = 0 To 3
            iOut += myCInt(s.Substring(i, 1))
        Next
        sOut = myCStr(iOut)
        sOut = sOut.PadLeft(3, CChar("0"))

        Return sOut
    End Function

    Public Function GetChainPassword() As String
        Dim i As Integer
        Dim s As String
        Dim iOut As Integer
        Dim sOut As String = ""

        s = Date.Today.Day.ToString.PadLeft(2, "0") & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Year.ToString.Substring(2, 2)
        For i = 0 To 2
            iOut = myCInt(s.Substring(i, 1)) + myCInt(s.Substring(5 - i, 1))
            sOut &= myCStr(iOut)
        Next

        Return sOut
    End Function
    Public Function myCInt(ByVal o As Object) As Integer
        Dim iOut As Integer
        If IsDBNull(o) Then
            Return 0
        End If
        If o Is Nothing Then
            Return 0
        End If
        If o.ToString = "" Then
            Return 0
        End If
        Try
            iOut = CInt(o)
        Catch
            iOut = 0
        End Try
        Return iOut
    End Function

    Public Function myCStr(ByVal i As Object) As String
        Dim sOut As String
        Try
            If i Is Nothing OrElse IsDBNull(i) Then
                Return ""
            End If
            sOut = CStr(i)
            If sOut Is Nothing OrElse IsDBNull(sOut) Then
                sOut = ""
            End If
        Catch
            sOut = ""
        End Try
        Return sOut
    End Function
    Function GetField(ByVal sRec As String, ByVal sDelim As Char, ByVal sCount As Integer) As String
        If sRec = "" Then
            'nothing to check
            Return ""
            Exit Function
        End If

        Dim iCharCnt, iItemCnt, iRecLength As Integer
        Dim sTemp As String = ""
        Dim sOut As String = ""
        Try
            iRecLength = sRec.Length
            Do
                Do While sRec.Substring(iCharCnt, 1) <> sDelim
                    sTemp = sTemp & sRec.Substring(iCharCnt, 1)
                    iCharCnt += 1
                    If iRecLength = iCharCnt Then Exit Do
                Loop
                iCharCnt += 1
                iItemCnt += 1
                If iItemCnt = sCount Then
                    sOut = sTemp
                Else
                    sTemp = ""
                End If
            Loop Until iCharCnt >= iRecLength
        Catch ex As Exception
            iErrorNbr = Err.Number
            MessageBox.Show("GetField" & vbCrLf & ex.Message)
        End Try
        Return sOut
    End Function

    Public Function CMDShellMySQL(ByVal sCommand As String, ByVal bHidden As Boolean, ByVal bRunas As Boolean) As Boolean
        Dim bReturn As Boolean = False

        Dim objShell = CreateObject("Shell.Application")


        Try
            'Shell("cmd.exe /k " & sCommand & " runas", AppWinStyle.NormalFocus)

            If bRunas Then
                objShell.ShellExecute("cmd.exe", "/k " & sCommand, "", "runas", 1)
            Else
                objShell.ShellExecute("cmd.exe", "/k " & sCommand, "", "", 1)
            End If

            bReturn = True
        Catch ex As Exception

        End Try

        Return bReturn
    End Function

    Public Function Encrypt(ByVal s As String) As String
        Dim thisChr As Char
        Dim sOut As String = ""

        For Each thisChr In s
            thisChr = Chr(Asc(thisChr) + 10)
            sOut &= thisChr
        Next

        Return sOut

    End Function

    Public Function Decrypt(ByVal s As String) As String
        Dim thisChr As Char
        Dim sOut As String = ""

        For Each thisChr In s
            thisChr = Chr(Asc(thisChr) - 10)
            sOut &= thisChr
        Next

        Return sOut

    End Function
End Module
