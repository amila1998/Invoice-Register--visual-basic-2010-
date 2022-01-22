Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Public Class Form2

    Private Sub InvoiceRegBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InvoiceRegBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Invoice_Register_DataBaseDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Invoice_Register_DataBaseDataSet.InvoiceReg' table. You can move, or remove it, as needed.
        Me.InvoiceRegTableAdapter.Fill(Me.Invoice_Register_DataBaseDataSet.InvoiceReg)
        InvoiceRegBindingSource.AddNew()
        Rec_NoTextBox.Enabled = False
        Rec_ValTextBox.Enabled = False
        Rec_DateDateTimePicker.Enabled = False
        InvoiceRegBindingNavigator.Enabled = False

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String
        msg = MsgBox("Did you want to Cancel this?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel")
        If msg = vbYes Then
            InvoiceRegBindingSource.RemoveCurrent()
            InvoiceRegBindingSource.EndEdit()
            InvoiceRegTableAdapter.Update(Invoice_Register_DataBaseDataSet.InvoiceReg)
            MsgBox("Cancelled")
        Else
            If msg = vbNo Then

                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Enabled = True Then


            On Error GoTo Saveerr


            InvoiceRegBindingSource.EndEdit()
            InvoiceRegTableAdapter.Update(Invoice_Register_DataBaseDataSet.InvoiceReg)
            MsgBox("Saved")
            Me.Close()



Saveerr:
            Exit Sub
        Else

            On Error GoTo Saveerr

            Rec_NoTextBox.Text = ""
            Rec_ValTextBox.Text = ""
            Rec_DateDateTimePicker.Text = ""
            InvoiceRegBindingSource.EndEdit()
            InvoiceRegTableAdapter.Update(Invoice_Register_DataBaseDataSet.InvoiceReg)
            MsgBox("Saved")
            Me.Close()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Invoice_ValueTextBox.Text = "" Then
            MsgBox("Invoice Value box is empty")
        Else
            Total_ValueTextBox.Text = Val(Invoice_ValueTextBox.Text) + Val(NBTTextBox.Text) + Val(VATTextBox.Text)

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Rec_NoTextBox.Enabled = True
        Rec_ValTextBox.Enabled = True
        Rec_DateDateTimePicker.Enabled = True
    End Sub

    Private Sub InvoiceRegBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InvtoiceRegBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Invoice_Register_DataBaseDataSet)

    End Sub
End Class