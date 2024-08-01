<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprintinfo
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
        Dim PlantIDLabel As System.Windows.Forms.Label
        Dim EmployeeNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim BloodTypeLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim DateofOriginLabel As System.Windows.Forms.Label
        Dim BasicLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprintinfo))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GenerallPayrollDataSet = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSet()
        Me.GenPayFinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenPayFinalTableAdapter = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.GenPayFinalTableAdapter()
        Me.TableAdapterManager = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.TableAdapterManager()
        Me.PlantIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.BasicTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateofOriginTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.BloodTypeTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PlantIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofOriginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReceipt1 = New System.Windows.Forms.RichTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        PlantIDLabel = New System.Windows.Forms.Label()
        EmployeeNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        BloodTypeLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        DateofOriginLabel = New System.Windows.Forms.Label()
        BasicLabel = New System.Windows.Forms.Label()
        CType(Me.GenerallPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenPayFinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlantIDLabel
        '
        PlantIDLabel.AutoSize = True
        PlantIDLabel.Location = New System.Drawing.Point(49, 38)
        PlantIDLabel.Name = "PlantIDLabel"
        PlantIDLabel.Size = New System.Drawing.Size(68, 16)
        PlantIDLabel.TabIndex = 1
        PlantIDLabel.Text = "Plant ID:"
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.AutoSize = True
        EmployeeNameLabel.Location = New System.Drawing.Point(10, 64)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(123, 16)
        EmployeeNameLabel.TabIndex = 2
        EmployeeNameLabel.Text = "Employee Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(49, 90)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(65, 16)
        AddressLabel.TabIndex = 4
        AddressLabel.Text = "Address:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(10, 116)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(124, 16)
        ContactNumberLabel.TabIndex = 6
        ContactNumberLabel.Text = "Contact Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(62, 142)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(53, 16)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'BloodTypeLabel
        '
        BloodTypeLabel.AutoSize = True
        BloodTypeLabel.Location = New System.Drawing.Point(33, 168)
        BloodTypeLabel.Name = "BloodTypeLabel"
        BloodTypeLabel.Size = New System.Drawing.Size(87, 16)
        BloodTypeLabel.TabIndex = 10
        BloodTypeLabel.Text = "Blood Type:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(32, 195)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(94, 16)
        DepartmentLabel.TabIndex = 12
        DepartmentLabel.Text = "Department:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Location = New System.Drawing.Point(31, 222)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(95, 16)
        DesignationLabel.TabIndex = 14
        DesignationLabel.Text = "Designation:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(50, 249)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(69, 16)
        PositionLabel.TabIndex = 16
        PositionLabel.Text = "Position:"
        '
        'DateofOriginLabel
        '
        DateofOriginLabel.AutoSize = True
        DateofOriginLabel.Location = New System.Drawing.Point(25, 277)
        DateofOriginLabel.Name = "DateofOriginLabel"
        DateofOriginLabel.Size = New System.Drawing.Size(104, 16)
        DateofOriginLabel.TabIndex = 18
        DateofOriginLabel.Text = "Dateof Origin:"
        '
        'BasicLabel
        '
        BasicLabel.AutoSize = True
        BasicLabel.Location = New System.Drawing.Point(61, 302)
        BasicLabel.Name = "BasicLabel"
        BasicLabel.Size = New System.Drawing.Size(48, 16)
        BasicLabel.TabIndex = 20
        BasicLabel.Text = "Basic:"
        '
        'GenerallPayrollDataSet
        '
        Me.GenerallPayrollDataSet.DataSetName = "GenerallPayrollDataSet"
        Me.GenerallPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GenPayFinalBindingSource
        '
        Me.GenPayFinalBindingSource.DataMember = "GenPayFinal"
        Me.GenPayFinalBindingSource.DataSource = Me.GenerallPayrollDataSet
        '
        'GenPayFinalTableAdapter
        '
        Me.GenPayFinalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GenPayFinalTableAdapter = Me.GenPayFinalTableAdapter
        Me.TableAdapterManager.logininfoTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PlantIDTextBox
        '
        Me.PlantIDTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.PlantIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PlantID", True))
        Me.PlantIDTextBox.Location = New System.Drawing.Point(159, 35)
        Me.PlantIDTextBox.Name = "PlantIDTextBox"
        Me.PlantIDTextBox.ReadOnly = True
        Me.PlantIDTextBox.Size = New System.Drawing.Size(200, 23)
        Me.PlantIDTextBox.TabIndex = 2
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "EmployeeName", True))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(159, 61)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.ReadOnly = True
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.EmployeeNameTextBox.TabIndex = 3
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(159, 87)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 23)
        Me.AddressTextBox.TabIndex = 5
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(159, 113)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.ReadOnly = True
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ContactNumberTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(159, 139)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 23)
        Me.EmailTextBox.TabIndex = 9
        '
        'BasicTextBox
        '
        Me.BasicTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BasicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Basic", True))
        Me.BasicTextBox.Location = New System.Drawing.Point(159, 299)
        Me.BasicTextBox.Name = "BasicTextBox"
        Me.BasicTextBox.ReadOnly = True
        Me.BasicTextBox.Size = New System.Drawing.Size(200, 23)
        Me.BasicTextBox.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateofOriginTextBox)
        Me.GroupBox1.Controls.Add(Me.DesignationTextBox)
        Me.GroupBox1.Controls.Add(Me.DepartmentTextBox)
        Me.GroupBox1.Controls.Add(Me.BloodTypeTextBox)
        Me.GroupBox1.Controls.Add(Me.PositionTextBox)
        Me.GroupBox1.Controls.Add(Me.PlantIDTextBox)
        Me.GroupBox1.Controls.Add(BasicLabel)
        Me.GroupBox1.Controls.Add(PlantIDLabel)
        Me.GroupBox1.Controls.Add(Me.BasicTextBox)
        Me.GroupBox1.Controls.Add(Me.EmployeeNameTextBox)
        Me.GroupBox1.Controls.Add(DateofOriginLabel)
        Me.GroupBox1.Controls.Add(EmployeeNameLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(PositionLabel)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.ContactNumberTextBox)
        Me.GroupBox1.Controls.Add(DesignationLabel)
        Me.GroupBox1.Controls.Add(ContactNumberLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(DepartmentLabel)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(BloodTypeLabel)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 498)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'DateofOriginTextBox
        '
        Me.DateofOriginTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DateofOriginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "DateofOrigin", True))
        Me.DateofOriginTextBox.Location = New System.Drawing.Point(159, 272)
        Me.DateofOriginTextBox.Name = "DateofOriginTextBox"
        Me.DateofOriginTextBox.ReadOnly = True
        Me.DateofOriginTextBox.Size = New System.Drawing.Size(200, 23)
        Me.DateofOriginTextBox.TabIndex = 242
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Designation", True))
        Me.DesignationTextBox.Location = New System.Drawing.Point(159, 219)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.ReadOnly = True
        Me.DesignationTextBox.Size = New System.Drawing.Size(200, 23)
        Me.DesignationTextBox.TabIndex = 241
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(159, 193)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.ReadOnly = True
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 23)
        Me.DepartmentTextBox.TabIndex = 240
        '
        'BloodTypeTextBox
        '
        Me.BloodTypeTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.BloodTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "BloodType", True))
        Me.BloodTypeTextBox.Location = New System.Drawing.Point(159, 166)
        Me.BloodTypeTextBox.Name = "BloodTypeTextBox"
        Me.BloodTypeTextBox.ReadOnly = True
        Me.BloodTypeTextBox.Size = New System.Drawing.Size(67, 23)
        Me.BloodTypeTextBox.TabIndex = 239
        '
        'PositionTextBox
        '
        Me.PositionTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(159, 246)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.ReadOnly = True
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 23)
        Me.PositionTextBox.TabIndex = 238
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(402, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 236
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-65, 377)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(276, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 237
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(119, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Employee Information"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(412, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 487)
        Me.TabControl1.TabIndex = 58
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlantIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.BasicDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.BloodTypeDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.DateofOriginDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GenPayFinalBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(522, 474)
        Me.DataGridView1.TabIndex = 0
        '
        'PlantIDDataGridViewTextBoxColumn
        '
        Me.PlantIDDataGridViewTextBoxColumn.DataPropertyName = "PlantID"
        Me.PlantIDDataGridViewTextBoxColumn.HeaderText = "PlantID"
        Me.PlantIDDataGridViewTextBoxColumn.Name = "PlantIDDataGridViewTextBoxColumn"
        Me.PlantIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        Me.EmployeeNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BasicDataGridViewTextBoxColumn
        '
        Me.BasicDataGridViewTextBoxColumn.DataPropertyName = "Basic"
        Me.BasicDataGridViewTextBoxColumn.HeaderText = "Basic"
        Me.BasicDataGridViewTextBoxColumn.Name = "BasicDataGridViewTextBoxColumn"
        Me.BasicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BloodTypeDataGridViewTextBoxColumn
        '
        Me.BloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType"
        Me.BloodTypeDataGridViewTextBoxColumn.HeaderText = "BloodType"
        Me.BloodTypeDataGridViewTextBoxColumn.Name = "BloodTypeDataGridViewTextBoxColumn"
        Me.BloodTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        Me.DesignationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateofOriginDataGridViewTextBoxColumn
        '
        Me.DateofOriginDataGridViewTextBoxColumn.DataPropertyName = "DateofOrigin"
        Me.DateofOriginDataGridViewTextBoxColumn.HeaderText = "DateofOrigin"
        Me.DateofOriginDataGridViewTextBoxColumn.Name = "DateofOriginDataGridViewTextBoxColumn"
        Me.DateofOriginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtReceipt1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 474)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtReceipt1
        '
        Me.txtReceipt1.Location = New System.Drawing.Point(0, 0)
        Me.txtReceipt1.Name = "txtReceipt1"
        Me.txtReceipt1.ReadOnly = True
        Me.txtReceipt1.Size = New System.Drawing.Size(521, 474)
        Me.txtReceipt1.TabIndex = 0
        Me.txtReceipt1.Text = ""
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(331, 382)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 78
        Me.Button6.Text = "Print"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(12, 384)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(89, 23)
        Me.Button8.TabIndex = 77
        Me.Button8.Text = "Move Previous"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(107, 384)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(92, 23)
        Me.Button7.TabIndex = 76
        Me.Button7.Text = "Move Next"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(11, 472)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(127, 36)
        Me.Button9.TabIndex = 235
        Me.Button9.Text = "Back"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(581, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Search ID"
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(688, 7)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(201, 31)
        Me.TextBox14.TabIndex = 236
        '
        'frmprintinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(949, 523)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmprintinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SURIGAO DEL SUR STATE UNIVERSITY, CANTILAN CAMPUS"
        CType(Me.GenerallPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenPayFinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GenerallPayrollDataSet As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSet
    Friend WithEvents GenPayFinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenPayFinalTableAdapter As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.GenPayFinalTableAdapter
    Friend WithEvents TableAdapterManager As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlantIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BasicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtReceipt1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PlantIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofOriginDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateofOriginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
End Class
