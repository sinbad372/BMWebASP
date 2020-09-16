Public Class BMWebMain
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AccessLevelLink()
        ' DirectCast(FindControl("UserIDLabel"), Label).Text = CurrentUser.EmpID
        ' DirectCast(FindControl("UsernameLabel"), Label).Text = CurrentUser.EmpName

        UserIDLabel.Text = CurrentUser.EmpID
        UsernameLabel.Text = CurrentUser.EmpName
    End Sub
    Private Sub AccessLevelLink()
        Select Case CurrentUser.UserLevel
            Case "L3"
                SupervisorVisitLink.Visible = True
                SeniorVisitLink.Visible = False
            Case "L4"
                SupervisorVisitLink.Visible = True
                SeniorVisitLink.Visible = False
            Case Else
                SupervisorVisitLink.Visible = False
                SeniorVisitLink.Visible = False
        End Select
    End Sub
End Class