Public Class BMLogin
    Inherits System.Web.UI.Page
    Private TAEmployeesPass As New BMDataSetTableAdapters.EmployeesPassTableAdapter
    Private TAEmployees As New BMDataSetTableAdapters.EmployeesTableAdapter

    Protected Sub BMLogin_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles BMLogin.Authenticate
        If FireCurrentUser(BMLogin.UserName, BMLogin.Password) Then
            e.Authenticated = True
            Response.Redirect("UIMain\BMWebMain.aspx")
        Else
            e.Authenticated = False
        End If
    End Sub
    Private Function FireCurrentUser(ByVal strEmpID As String, ByVal strEmpPass As String) As Boolean
        Try
            Dim rsA = TAEmployees.GetDataByEmpID(strEmpID)
            Dim rsC = TAEmployeesPass.GetDataByEmpID(strEmpID)
            If rsA.Rows.Count = 0 Then
                Throw New Exception("Invalid User Name or Password")
            ElseIf rsC.Rows.Count = 0 Then
                Throw New Exception("Invalid User Name or Password")
            ElseIf rsC(0).EmpPassword <> strEmpPass Then
                Throw New Exception("Invalid User Name or Password")
            Else
                CurrentUser.EmpID = rsA.Rows(0).Item("EmpID")
                CurrentUser.EmpName = rsA.Rows(0).Item("EmpName").ToString
                CurrentUser.EmpJob = rsA.Rows(0).Item("EmpJob").ToString
                CurrentUser.UserLevel = rsA.Rows(0).Item("UserLevel").ToString
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Class