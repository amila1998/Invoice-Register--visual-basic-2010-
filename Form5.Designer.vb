<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.CrystalReport11 = New Invoice_Register.CrystalReport1()
        Me.Invoice_Register_DataBaseDataSet1 = New Invoice_Register.Invoice_Register_DataBaseDataSet1()
        Me.InvoiceRegBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceRegTableAdapter = New Invoice_Register.Invoice_Register_DataBaseDataSet1TableAdapters.InvoiceRegTableAdapter()
        Me.TableAdapterManager = New Invoice_Register.Invoice_Register_DataBaseDataSet1TableAdapters.TableAdapterManager()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport12 = New Invoice_Register.CrystalReport1()
        Me.CrystalReport21 = New Invoice_Register.CrystalReport2()
        CType(Me.Invoice_Register_DataBaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceRegBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Invoice_Register_DataBaseDataSet1
        '
        Me.Invoice_Register_DataBaseDataSet1.DataSetName = "Invoice_Register_DataBaseDataSet1"
        Me.Invoice_Register_DataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceRegBindingSource
        '
        Me.InvoiceRegBindingSource.DataMember = "InvoiceReg"
        Me.InvoiceRegBindingSource.DataSource = Me.Invoice_Register_DataBaseDataSet1
        '
        'InvoiceRegTableAdapter
        '
        Me.InvoiceRegTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InvoiceRegTableAdapter = Me.InvoiceRegTableAdapter
        Me.TableAdapterManager.UpdateOrder = Invoice_Register.Invoice_Register_DataBaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport21
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(771, 531)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 531)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form5"
        Me.Text = "Invoice Register"
        CType(Me.Invoice_Register_DataBaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceRegBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReport11 As Invoice_Register.CrystalReport1
    Friend WithEvents Invoice_Register_DataBaseDataSet1 As Invoice_Register.Invoice_Register_DataBaseDataSet1
    Friend WithEvents InvoiceRegBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceRegTableAdapter As Invoice_Register.Invoice_Register_DataBaseDataSet1TableAdapters.InvoiceRegTableAdapter
    Friend WithEvents TableAdapterManager As Invoice_Register.Invoice_Register_DataBaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport12 As Invoice_Register.CrystalReport1
    Friend WithEvents CrystalReport21 As Invoice_Register.CrystalReport2
    'Friend WithEvents CrystalReport11 As Invoice_Register.CrystalReport1
End Class
