Imports System.Net
Imports Microsoft.Win32
Imports System.Text.RegularExpressions
Public Module BMVariableMain
    Public CurrentUser As New clsEmployee
    Public AppVer As String
    Public blnMasterForce As Boolean
    Public dtaLastLogin As Date
    Public dtaNowLogin As Date
    Public strBMFirst As String = ""
    Public strAccessFirst As String = ""
    Public strPOSFirst As String = ""
    Public intLoginNo As Integer
    Public intUpdateMasterDays As Integer
    Public strLogoutEmpID As String
    Public blnLogoutEmpID As Boolean
    Public blnUpdateCancel As Boolean
    Public blnMsgRead As Boolean
    Public blnMsgMustUpdateRead As Boolean
    Public blnProgramClose As Boolean
    Public blnProgramForceClose As Boolean
    Public blnProgramHiddenForceClose As Boolean
    Public blnProgramForceStopUpdate As Boolean
    Public blnProgramForceUpdate As Boolean
    Public blnProgramForceUpdateTools As Boolean
    Public blnProgramUpdateToolsDrive As Boolean
    Public blnPermissionExist As Boolean
    Public blnOnceMsg As Boolean
    Public OldOnceMsg As String = ""
    Public OnceMsg As String
    Public OldUserOnceMsg As String = ""
    Public OldLocOnceMsg As String = ""
    Public blnOldUserOnceMsg As Boolean
    Public blnOldLocOnceMsg As Boolean
    Public intMasterVersion As Integer
    Public blnLevelOnceMsg As Boolean
    Public LevelOldOnceMsg As String = ""
    Public LevelOnceMsg As String
    Public LevelUpdateOnceMsg As String = ""
    Public regBMUpdate As RegistryKey
    Public regBMUpdate2 As RegistryKey
    Public LastProgramVersion As String
    Public BMServerUpdate As Boolean
    Public Const MyApp As String = "BusinessMonitor"
    Public Function GetNumber(StrText As String) As String
        Dim d As String = ""
        If StrText.Length > 0 Then
            Dim a() As Char = StrText.ToCharArray
            For Each s As Char In a
                If Char.IsNumber(s) = True Then
                    d = d & s
                End If
            Next
        End If
        Return d
    End Function
    Public Function GetNumbers(StrText As String) As Integer
        Dim d As String = ""
        If StrText.Length > 0 Then
            Dim a() As Char = StrText.ToCharArray
            For Each s As Char In a
                If Char.IsNumber(s) = True Then
                    d = d & s
                End If
            Next
        End If
        If d = "" Then d = "0"
        Return CInt(d)
    End Function
    Public Function IsValidEmail(strIn As String) As Boolean
        ' Return true if strIn is in valid e-mail format.
        Return Regex.IsMatch(strIn, "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Return Regex.IsMatch(strIn, "\p{IsArabic}")
    End Function
    Public Function IsArabicLang(strIn As String) As Boolean
        ' Return true if strIn is contains any arabic character.
        Return Regex.IsMatch(strIn, "\p{IsArabic}")
    End Function
    Public Function Nzz(ByVal VarValue As Object, ByVal VarIfEmpty As Object) As Object
        'Return Value if Variant is Empty

        If String.IsNullOrEmpty(VarValue) = True Or VarValue = Nothing Then
            Return VarIfEmpty
        Else
            Return VarValue
        End If

    End Function
    Public Function NzZero(ByVal VarValue As Object, ByVal VarIfEmpty As Object) As Object
        'Return Value if Variant is Empty

        If String.IsNullOrEmpty(VarValue) = True Or VarValue = Nothing Or VarValue = 0 Then
            Return VarIfEmpty
        Else
            Return VarValue
        End If

    End Function

End Module

