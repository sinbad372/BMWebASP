Imports Microsoft.Reporting.WebForms

Public Class BMWebMain
    Inherits System.Web.UI.Page
    Private TAEmployees As New BMDataSetTableAdapters.EmployeesTableAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AccessLevelLink()
        ' DirectCast(FindControl("UserIDLabel"), Label).Text = CurrentUser.EmpID
        ' DirectCast(FindControl("UsernameLabel"), Label).Text = CurrentUser.EmpName

        UserIDLabel.Text = CurrentUser.EmpID
        UsernameLabel.Text = CurrentUser.EmpName

    End Sub
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        If Not Page.IsPostBack Then

            'Set the processing mode for the ReportViewer to Local  
            ReportViewer1.ProcessingMode = ProcessingMode.Local

            Dim localReport As LocalReport
            localReport = ReportViewer1.LocalReport

            localReport.ReportPath = "UIMain\Report1.rdlc"

            Dim rsA = TAEmployees.GetDataByEmpID(CurrentUser.EmpID).CopyToDataTable

            'Create a report data source for the sales order data  
            Dim dsSalesOrder As New ReportDataSource()
            dsSalesOrder.Name = "ReportDS"
            dsSalesOrder.Value = rsA

            localReport.DataSources.Add(dsSalesOrder)

        End If

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