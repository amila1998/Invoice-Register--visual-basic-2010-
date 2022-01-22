<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim Ref_No_Label As System.Windows.Forms.Label
        Dim Sent_ByLabel As System.Windows.Forms.Label
        Dim Invoice_NoLabel As System.Windows.Forms.Label
        Dim Client_NameLabel As System.Windows.Forms.Label
        Dim DetailsLabel As System.Windows.Forms.Label
        Dim Invoice_ValueLabel As System.Windows.Forms.Label
        Dim NBTLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim Total_ValueLabel As System.Windows.Forms.Label
        Dim Rec_ValLabel As System.Windows.Forms.Label
        Dim Rec_DateLabel As System.Windows.Forms.Label
        Dim Rec_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ref_No_TextBox = New System.Windows.Forms.TextBox()
        Me.Sent_ByTextBox = New System.Windows.Forms.TextBox()
        Me.Invoice_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Client_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Invoice_ValueTextBox = New System.Windows.Forms.TextBox()
        Me.NBTTextBox = New System.Windows.Forms.TextBox()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.Total_ValueTextBox = New System.Windows.Forms.TextBox()
        Me.Rec_ValTextBox = New System.Windows.Forms.TextBox()
        Me.Rec_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Rec_NoTextBox = New System.Windows.Forms.TextBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Invoice_Register_DataBaseDataSet = New Invoice_Register.Invoice_Register_DataBaseDataSet()
        Me.InvoiceRegBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceRegTableAdapter = New Invoice_Register.Invoice_Register_DataBaseDataSetTableAdapters.InvoiceRegTableAdapter()
        Me.TableAdapterManager = New Invoice_Register.Invoice_Register_DataBaseDataSetTableAdapters.TableAdapterManager()
        Me.InvoiceRegBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        DateLabel = New System.Windows.Forms.Label()
        Ref_No_Label = New System.Windows.Forms.Label()
        Sent_ByLabel = New System.Windows.Forms.Label()
        Invoice_NoLabel = New System.Windows.Forms.Label()
        Client_NameLabel = New System.Windows.Forms.Label()
        DetailsLabel = New System.Windows.Forms.Label()
        Invoice_ValueLabel = New System.Windows.Forms.Label()
        NBTLabel = New System.Windows.Forms.Label()
        VATLabel = New System.Windows.Forms.Label()
        Total_ValueLabel = New System.Windows.Forms.Label()
        Rec_ValLabel = New System.Windows.Forms.Label()
        Rec_DateLabel = New System.Windows.Forms.Label()
        Rec_NoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Invoice_Register_DataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceRegBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceRegBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoiceRegBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(13, 50)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(43, 18)
        DateLabel.TabIndex = 1
        DateLabel.Text = "Date:"
        '
        'Ref_No_Label
        '
        Ref_No_Label.AutoSize = True
        Ref_No_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ref_No_Label.Location = New System.Drawing.Point(13, 77)
        Ref_No_Label.Name = "Ref_No_Label"
        Ref_No_Label.Size = New System.Drawing.Size(59, 18)
        Ref_No_Label.TabIndex = 3
        Ref_No_Label.Text = "Ref No:"
        '
        'Sent_ByLabel
        '
        Sent_ByLabel.AutoSize = True
        Sent_ByLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sent_ByLabel.Location = New System.Drawing.Point(13, 105)
        Sent_ByLabel.Name = "Sent_ByLabel"
        Sent_ByLabel.Size = New System.Drawing.Size(63, 18)
        Sent_ByLabel.TabIndex = 5
        Sent_ByLabel.Text = "Sent By:"
        '
        'Invoice_NoLabel
        '
        Invoice_NoLabel.AutoSize = True
        Invoice_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Invoice_NoLabel.Location = New System.Drawing.Point(13, 19)
        Invoice_NoLabel.Name = "Invoice_NoLabel"
        Invoice_NoLabel.Size = New System.Drawing.Size(82, 18)
        Invoice_NoLabel.TabIndex = 7
        Invoice_NoLabel.Text = "Invoice No:"
        '
        'Client_NameLabel
        '
        Client_NameLabel.AutoSize = True
        Client_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_NameLabel.Location = New System.Drawing.Point(13, 135)
        Client_NameLabel.Name = "Client_NameLabel"
        Client_NameLabel.Size = New System.Drawing.Size(93, 18)
        Client_NameLabel.TabIndex = 9
        Client_NameLabel.Text = "Client Name:"
        '
        'DetailsLabel
        '
        DetailsLabel.AutoSize = True
        DetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DetailsLabel.Location = New System.Drawing.Point(13, 245)
        DetailsLabel.Name = "DetailsLabel"
        DetailsLabel.Size = New System.Drawing.Size(57, 18)
        DetailsLabel.TabIndex = 11
        DetailsLabel.Text = "Details:"
        '
        'Invoice_ValueLabel
        '
        Invoice_ValueLabel.AutoSize = True
        Invoice_ValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Invoice_ValueLabel.Location = New System.Drawing.Point(15, 19)
        Invoice_ValueLabel.Name = "Invoice_ValueLabel"
        Invoice_ValueLabel.Size = New System.Drawing.Size(98, 18)
        Invoice_ValueLabel.TabIndex = 13
        Invoice_ValueLabel.Text = "Invoice Value:"
        '
        'NBTLabel
        '
        NBTLabel.AutoSize = True
        NBTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NBTLabel.Location = New System.Drawing.Point(15, 47)
        NBTLabel.Name = "NBTLabel"
        NBTLabel.Size = New System.Drawing.Size(42, 18)
        NBTLabel.TabIndex = 15
        NBTLabel.Text = "NBT:"
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VATLabel.Location = New System.Drawing.Point(15, 75)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(39, 18)
        VATLabel.TabIndex = 17
        VATLabel.Text = "VAT:"
        '
        'Total_ValueLabel
        '
        Total_ValueLabel.AutoSize = True
        Total_ValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_ValueLabel.Location = New System.Drawing.Point(15, 103)
        Total_ValueLabel.Name = "Total_ValueLabel"
        Total_ValueLabel.Size = New System.Drawing.Size(85, 18)
        Total_ValueLabel.TabIndex = 19
        Total_ValueLabel.Text = "Total Value:"
        '
        'Rec_ValLabel
        '
        Rec_ValLabel.AutoSize = True
        Rec_ValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rec_ValLabel.Location = New System.Drawing.Point(15, 45)
        Rec_ValLabel.Name = "Rec_ValLabel"
        Rec_ValLabel.Size = New System.Drawing.Size(63, 18)
        Rec_ValLabel.TabIndex = 21
        Rec_ValLabel.Text = "Rec Val:"
        '
        'Rec_DateLabel
        '
        Rec_DateLabel.AutoSize = True
        Rec_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rec_DateLabel.Location = New System.Drawing.Point(15, 74)
        Rec_DateLabel.Name = "Rec_DateLabel"
        Rec_DateLabel.Size = New System.Drawing.Size(74, 18)
        Rec_DateLabel.TabIndex = 23
        Rec_DateLabel.Text = "Rec Date:"
        '
        'Rec_NoLabel
        '
        Rec_NoLabel.AutoSize = True
        Rec_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rec_NoLabel.Location = New System.Drawing.Point(15, 101)
        Rec_NoLabel.Name = "Rec_NoLabel"
        Rec_NoLabel.Size = New System.Drawing.Size(63, 18)
        Rec_NoLabel.TabIndex = 25
        Rec_NoLabel.Text = "Rec No:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(117, 46)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(224, 24)
        Me.DateDateTimePicker.TabIndex = 2
        '
        'Ref_No_TextBox
        '
        Me.Ref_No_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ref_No_TextBox.Location = New System.Drawing.Point(117, 74)
        Me.Ref_No_TextBox.Name = "Ref_No_TextBox"
        Me.Ref_No_TextBox.Size = New System.Drawing.Size(224, 24)
        Me.Ref_No_TextBox.TabIndex = 4
        '
        'Sent_ByTextBox
        '
        Me.Sent_ByTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_ByTextBox.Location = New System.Drawing.Point(117, 102)
        Me.Sent_ByTextBox.Name = "Sent_ByTextBox"
        Me.Sent_ByTextBox.Size = New System.Drawing.Size(224, 24)
        Me.Sent_ByTextBox.TabIndex = 6
        '
        'Invoice_NoTextBox
        '
        Me.Invoice_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_NoTextBox.Location = New System.Drawing.Point(117, 16)
        Me.Invoice_NoTextBox.Name = "Invoice_NoTextBox"
        Me.Invoice_NoTextBox.Size = New System.Drawing.Size(224, 24)
        Me.Invoice_NoTextBox.TabIndex = 8
        '
        'Client_NameTextBox
        '
        Me.Client_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client_NameTextBox.Location = New System.Drawing.Point(117, 132)
        Me.Client_NameTextBox.Multiline = True
        Me.Client_NameTextBox.Name = "Client_NameTextBox"
        Me.Client_NameTextBox.Size = New System.Drawing.Size(224, 104)
        Me.Client_NameTextBox.TabIndex = 10
        '
        'DetailsTextBox
        '
        Me.DetailsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsTextBox.Location = New System.Drawing.Point(117, 242)
        Me.DetailsTextBox.Multiline = True
        Me.DetailsTextBox.Name = "DetailsTextBox"
        Me.DetailsTextBox.Size = New System.Drawing.Size(224, 222)
        Me.DetailsTextBox.TabIndex = 12
        '
        'Invoice_ValueTextBox
        '
        Me.Invoice_ValueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_ValueTextBox.Location = New System.Drawing.Point(131, 16)
        Me.Invoice_ValueTextBox.Name = "Invoice_ValueTextBox"
        Me.Invoice_ValueTextBox.Size = New System.Drawing.Size(224, 24)
        Me.Invoice_ValueTextBox.TabIndex = 14
        '
        'NBTTextBox
        '
        Me.NBTTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NBTTextBox.Location = New System.Drawing.Point(131, 44)
        Me.NBTTextBox.Name = "NBTTextBox"
        Me.NBTTextBox.Size = New System.Drawing.Size(224, 24)
        Me.NBTTextBox.TabIndex = 16
        '
        'VATTextBox
        '
        Me.VATTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VATTextBox.Location = New System.Drawing.Point(131, 72)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(224, 24)
        Me.VATTextBox.TabIndex = 18
        '
        'Total_ValueTextBox
        '
        Me.Total_ValueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_ValueTextBox.Location = New System.Drawing.Point(131, 100)
        Me.Total_ValueTextBox.Name = "Total_ValueTextBox"
        Me.Total_ValueTextBox.Size = New System.Drawing.Size(224, 24)
        Me.Total_ValueTextBox.TabIndex = 20
        '
        'Rec_ValTextBox
        '
        Me.Rec_ValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_ValTextBox.Location = New System.Drawing.Point(135, 42)
        Me.Rec_ValTextBox.Name = "Rec_ValTextBox"
        Me.Rec_ValTextBox.Size = New System.Drawing.Size(224, 24)
        Me.Rec_ValTextBox.TabIndex = 22
        '
        'Rec_DateDateTimePicker
        '
        Me.Rec_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Rec_DateDateTimePicker.Location = New System.Drawing.Point(135, 70)
        Me.Rec_DateDateTimePicker.Name = "Rec_DateDateTimePicker"
        Me.Rec_DateDateTimePicker.Size = New System.Drawing.Size(224, 24)
        Me.Rec_DateDateTimePicker.TabIndex = 24
        '
        'Rec_NoTextBox
        '
        Me.Rec_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_NoTextBox.Location = New System.Drawing.Point(135, 98)
        Me.Rec_NoTextBox.Name = "Rec_NoTextBox"
        Me.Rec_NoTextBox.Size = New System.Drawing.Size(224, 24)
        Me.Rec_NoTextBox.TabIndex = 26
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.Location = New System.Drawing.Point(-4, -1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(771, 60)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(767, 593)
        Me.ShapeContainer1.TabIndex = 27
        Me.ShapeContainer1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(376, 263)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 21)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Paid"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(405, 492)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(306, 35)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(562, 445)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 35)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(405, 445)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 35)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Accept"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 41)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "New Invoice"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(131, 138)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 35)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Total Value"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(Ref_No_Label)
        Me.GroupBox1.Controls.Add(Me.Ref_No_TextBox)
        Me.GroupBox1.Controls.Add(Sent_ByLabel)
        Me.GroupBox1.Controls.Add(Me.Sent_ByTextBox)
        Me.GroupBox1.Controls.Add(Invoice_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Invoice_NoTextBox)
        Me.GroupBox1.Controls.Add(Client_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Client_NameTextBox)
        Me.GroupBox1.Controls.Add(DetailsLabel)
        Me.GroupBox1.Controls.Add(Me.DetailsTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 487)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Invoice_ValueLabel)
        Me.GroupBox2.Controls.Add(Me.Invoice_ValueTextBox)
        Me.GroupBox2.Controls.Add(NBTLabel)
        Me.GroupBox2.Controls.Add(Me.NBTTextBox)
        Me.GroupBox2.Controls.Add(VATLabel)
        Me.GroupBox2.Controls.Add(Me.VATTextBox)
        Me.GroupBox2.Controls.Add(Total_ValueLabel)
        Me.GroupBox2.Controls.Add(Me.Total_ValueTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(369, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 180)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Rec_ValLabel)
        Me.GroupBox3.Controls.Add(Me.Rec_ValTextBox)
        Me.GroupBox3.Controls.Add(Rec_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Rec_DateDateTimePicker)
        Me.GroupBox3.Controls.Add(Rec_NoLabel)
        Me.GroupBox3.Controls.Add(Me.Rec_NoTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(369, 254)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(386, 158)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(771, 509)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Invoice_Register_DataBaseDataSet
        '
        Me.Invoice_Register_DataBaseDataSet.DataSetName = "Invoice_Register_DataBaseDataSet"
        Me.Invoice_Register_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceRegBindingSource
        '
        Me.InvoiceRegBindingSource.DataMember = "InvoiceReg"
        Me.InvoiceRegBindingSource.DataSource = Me.Invoice_Register_DataBaseDataSet
        '
        'InvoiceRegTableAdapter
        '
        Me.InvoiceRegTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InvoiceRegTableAdapter = Me.InvoiceRegTableAdapter
        Me.TableAdapterManager.UpdateOrder = Invoice_Register.Invoice_Register_DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvoiceRegBindingNavigator
        '
        Me.InvoiceRegBindingNavigator.AddNewItem = Nothing
        Me.InvoiceRegBindingNavigator.BindingSource = Me.InvoiceRegBindingSource
        Me.InvoiceRegBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InvoiceRegBindingNavigator.DeleteItem = Nothing
        Me.InvoiceRegBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InvoiceRegBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.InvoiceRegBindingNavigator.Location = New System.Drawing.Point(0, 566)
        Me.InvoiceRegBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InvoiceRegBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InvoiceRegBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InvoiceRegBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InvoiceRegBindingNavigator.Name = "InvoiceRegBindingNavigator"
        Me.InvoiceRegBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InvoiceRegBindingNavigator.Size = New System.Drawing.Size(767, 27)
        Me.InvoiceRegBindingNavigator.TabIndex = 43
        Me.InvoiceRegBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(767, 593)
        Me.Controls.Add(Me.InvoiceRegBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Invoice Register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Invoice_Register_DataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceRegBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceRegBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoiceRegBindingNavigator.ResumeLayout(False)
        Me.InvoiceRegBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ref_No_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sent_ByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Invoice_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Client_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Invoice_ValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NBTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_ValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rec_ValTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rec_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rec_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Invoice_Register_DataBaseDataSet As Invoice_Register.Invoice_Register_DataBaseDataSet
    Friend WithEvents InvoiceRegBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceRegTableAdapter As Invoice_Register.Invoice_Register_DataBaseDataSetTableAdapters.InvoiceRegTableAdapter
    Friend WithEvents TableAdapterManager As Invoice_Register.Invoice_Register_DataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvoiceRegBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
