Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Public Class Form3

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub InvoiceRegBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InvoiceRegBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Invoice_Register_DataBaseDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Invoice_Register_DataBaseDataSet.InvoiceReg' table. You can move, or remove it, as needed.
        Me.InvoiceRegTableAdapter.Fill(Me.Invoice_Register_DataBaseDataSet.InvoiceReg)
        Rec_NoTextBox.Enabled = False
        Rec_ValTextBox.Enabled = False
        Rec_DateDateTimePicker.Enabled = False
        Invoice_NoTextBox.Enabled = False
        DateDateTimePicker.Enabled = False
        Ref_No_TextBox.Enabled = False
        Sent_ByTextBox.Enabled = False
        Client_NameTextBox.Enabled = False
        DetailsTextBox.Enabled = False
        Invoice_ValueTextBox.Enabled = False
        NBTTextBox.Enabled = False
        VATTextBox.Enabled = False
        Total_ValueTextBox.Enabled = False
        InvoiceRegDataGridView.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim msg As String
        msg = MsgBox("Did you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete")
        If msg = vbYes Then
            InvoiceRegBindingSource.RemoveCurrent()
            InvoiceRegBindingSource.EndEdit()
            InvoiceRegTableAdapter.Update(Invoice_Register_DataBaseDataSet.InvoiceReg)
            MsgBox("Deleted")
        Else
            If msg = vbNo Then

                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        InvoiceRegBindingSource.MoveNext()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        InvoiceRegBindingSource.MovePrevious()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        InvoiceRegBindingSource.MoveFirst()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        InvoiceRegBindingSource.MoveLast()

    End Sub

    Private Sub InvoiceRegDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InvoiceRegDataGridView.CellContentClick

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error GoTo SerErr
        If TextBox1.Text = "" Then
            Exit Sub
        Else
            Dim cantdine As String = TextBox1.Text
            InvoiceRegBindingSource.Filter = "(Convert([Invoice No], 'System.String') Like '" & TextBox1.Text & "%')"
        End If
        If InvoiceRegBindingSource.Count <> 0 Then
            With InvoiceRegDataGridView
                .DataSource = InvoiceRegBindingSource
            End With
        Else
            MsgBox("-->" & vbNewLine & "This item is not Found.", MsgBoxStyle.Information, "Notics")
            InvoiceRegBindingSource.Filter = Nothing
            With InvoiceRegDataGridView
                .ClearSelection()
                .ReadOnly = False
                .MultiSelect = False
                .DataSource = InvoiceRegBindingSource

            End With
        End If
Errex:
        Exit Sub

SerErr:
        MsgBox("Error Number" & Err.Number & vbNewLine & _
              "Error Description" & Err.Description, MsgBoxStyle.Critical, "Reset Error!")
        Resume Errex

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        On Error GoTo Errfe
        TextBox1.Select()
        InvoiceRegBindingSource.Filter = Nothing

        With InvoiceRegDataGridView
            .ClearSelection()
            .ReadOnly = False
            .MultiSelect = False
            .DataSource = InvoiceRegBindingSource

        End With
Errex:
        Exit Sub
Errfe:
        MsgBox("Error Number" & Err.Number & vbNewLine & _
               "Error Description" & Err.Description, MsgBoxStyle.Critical, "Reset Error!")
        Resume Errex


    End Sub
End Class