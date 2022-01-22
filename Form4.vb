Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Public Class Form4

    Private Sub InvoiceRegBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InvoiceRegBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Invoice_Register_DataBaseDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Invoice_Register_DataBaseDataSet.InvoiceReg' table. You can move, or remove it, as needed.
        Me.InvoiceRegTableAdapter.Fill(Me.Invoice_Register_DataBaseDataSet.InvoiceReg)
        Rec_NoTextBox.Enabled = False
        Rec_ValTextBox.Enabled = False
        Rec_DateDateTimePicker.Enabled = False
        InvoiceRegDataGridView.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Enabled = True Then


            On Error GoTo Saveerr


            InvoiceRegBindingSource.EndEdit()
            InvoiceRegTableAdapter.Update(Invoice_Register_DataBaseDataSet.InvoiceReg)
            MsgBox("Edited")
            Me.Close()



Saveerr:
            Exit Sub
        Else
            If CheckBox1.Enabled = False And Rec_NoTextBox.Text = "" Then
                On Error GoTo Saveerr

                Rec_NoTextBox.Text = ""
                Rec_ValTextBox.Text = ""
                Rec_DateDateTimePicker.Text = ""
                InvoiceRegBindingSource.EndEdit()
                InvoiceRegTableAdapter.Update(Invoice_Register_DataBaseDataSet.InvoiceReg)
                MsgBox("Edited")
                Me.Close()
            End If
            On Error GoTo Saveerr
            InvoiceRegBindingSource.EndEdit()
            InvoiceRegTableAdapter.Update(Invoice_Register_DataBaseDataSet.InvoiceReg)
            MsgBox("Edited")
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Rec_NoTextBox.Enabled = True
        Rec_ValTextBox.Enabled = True
        Rec_DateDateTimePicker.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Invoice_ValueTextBox.Text = "" Then
            MsgBox("Invoice Value box is empty")
        Else
            Total_ValueTextBox.Text = Val(Invoice_ValueTextBox.Text) + Val(NBTTextBox.Text) + Val(VATTextBox.Text)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub InvoiceRegBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InvoiceRegBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Invoice_Register_DataBaseDataSet)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

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