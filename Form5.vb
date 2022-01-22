Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form5
 
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Invoice_Register_DataBaseDataSet1.InvoiceReg' table. You can move, or remove it, as needed.
        Me.InvoiceRegTableAdapter.Fill(Me.Invoice_Register_DataBaseDataSet1.InvoiceReg)
        'Dim myReport As New CrystalReport1
        'Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        'Dim mylogonInfo As New CrystalDecisions.Shared.TableLogOnInfo

        'For Each myTable In myReport.Database.Tables
        '    With mylogonInfo.ConnectionInfo
        '        .UserID = "new User Id"
        '        .Password = "new password"
        '    End With
        '    myTable.ApplyLogOnInfo(mylogonInfo)
        'Next

        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.Zoom(75%)
        'Dim ds As New DataSet
        'InvoiceRegTableAdapter.Fill(ds)


        'Dim rpt As New CrystalReport1
        'rpt.SetDataSource(ds)

        'CrystalReportViewer1.ReportSource = rpt

    End Sub

    Private Sub InvoiceRegBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InvoiceRegBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Invoice_Register_DataBaseDataSet1)

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim spath2 As String = Environment.CurrentDirectory

        Dim myReport As New CrystalReport1
        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim mylogonInfo As New CrystalDecisions.Shared.TableLogOnInfo

        For Each myTable In myReport.Database.Tables
            With mylogonInfo.ConnectionInfo
                .UserID = "Admin"
                .Password = ""
            End With
            myTable.ApplyLogOnInfo(mylogonInfo)

        Next

    End Sub
End Class