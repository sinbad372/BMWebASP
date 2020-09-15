Public Class BMSupervisor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DirectCast(FindControl("UserIDLabel"), Label).Text = CurrentUser.EmpID
        DirectCast(FindControl("UsernameLabel"), Label).Text = CurrentUser.EmpName

        Dim a As New BMWebMainDataSetTableAdapters.CompLocationTableAdapter
        Dim b As New BMWebMainDataSet.CompLocationDataTable
        a.FillBySupervisorID(b, CurrentUser.EmpID)
        ddlLocation.DataSource = b
        ddlLocation.DataTextField = "Complocation"
        ddlLocation.DataValueField = "Complocation"
        ddlLocation.DataBind()

    End Sub
End Class