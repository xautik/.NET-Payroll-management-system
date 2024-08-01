<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregister))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BasicTextBox = New System.Windows.Forms.TextBox()
        Me.GenPayFinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenerallPayrollDataSet = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSet()
        Me.DateofOriginDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.DesignationComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.BloodTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.PlantIDTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GenPayFinalTableAdapter = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.GenPayFinalTableAdapter()
        Me.TableAdapterManager = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.TableAdapterManager()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnDeleteJHS = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenPayFinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerallPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlantIDLabel
        '
        PlantIDLabel.AutoSize = True
        PlantIDLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlantIDLabel.Location = New System.Drawing.Point(66, 16)
        PlantIDLabel.Name = "PlantIDLabel"
        PlantIDLabel.Size = New System.Drawing.Size(76, 18)
        PlantIDLabel.TabIndex = 0
        PlantIDLabel.Text = "Plant ID:"
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.AutoSize = True
        EmployeeNameLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeNameLabel.Location = New System.Drawing.Point(4, 48)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(138, 18)
        EmployeeNameLabel.TabIndex = 2
        EmployeeNameLabel.Text = "Employee Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(68, 76)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(74, 18)
        AddressLabel.TabIndex = 4
        AddressLabel.Text = "Address:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactNumberLabel.Location = New System.Drawing.Point(3, 107)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(141, 18)
        ContactNumberLabel.TabIndex = 6
        ContactNumberLabel.Text = "Contact Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(88, 144)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(58, 18)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'BloodTypeLabel
        '
        BloodTypeLabel.AutoSize = True
        BloodTypeLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BloodTypeLabel.Location = New System.Drawing.Point(46, 179)
        BloodTypeLabel.Name = "BloodTypeLabel"
        BloodTypeLabel.Size = New System.Drawing.Size(99, 18)
        BloodTypeLabel.TabIndex = 10
        BloodTypeLabel.Text = "Blood Type:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(40, 218)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(106, 18)
        DepartmentLabel.TabIndex = 12
        DepartmentLabel.Text = "Department:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignationLabel.Location = New System.Drawing.Point(40, 260)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(105, 18)
        DesignationLabel.TabIndex = 14
        DesignationLabel.Text = "Designation:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.Location = New System.Drawing.Point(68, 299)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(76, 18)
        PositionLabel.TabIndex = 16
        PositionLabel.Text = "Position:"
        '
        'DateofOriginLabel
        '
        DateofOriginLabel.AutoSize = True
        DateofOriginLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateofOriginLabel.Location = New System.Drawing.Point(29, 337)
        DateofOriginLabel.Name = "DateofOriginLabel"
        DateofOriginLabel.Size = New System.Drawing.Size(117, 18)
        DateofOriginLabel.TabIndex = 18
        DateofOriginLabel.Text = "Dateof Origin:"
        '
        'BasicLabel
        '
        BasicLabel.AutoSize = True
        BasicLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BasicLabel.Location = New System.Drawing.Point(37, 371)
        BasicLabel.Name = "BasicLabel"
        BasicLabel.Size = New System.Drawing.Size(109, 18)
        BasicLabel.TabIndex = 20
        BasicLabel.Text = "Basic Salary:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(BasicLabel)
        Me.GroupBox1.Controls.Add(Me.BasicTextBox)
        Me.GroupBox1.Controls.Add(DateofOriginLabel)
        Me.GroupBox1.Controls.Add(Me.DateofOriginDateTimePicker)
        Me.GroupBox1.Controls.Add(PositionLabel)
        Me.GroupBox1.Controls.Add(Me.PositionComboBox)
        Me.GroupBox1.Controls.Add(DesignationLabel)
        Me.GroupBox1.Controls.Add(Me.DesignationComboBox)
        Me.GroupBox1.Controls.Add(DepartmentLabel)
        Me.GroupBox1.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox1.Controls.Add(BloodTypeLabel)
        Me.GroupBox1.Controls.Add(Me.BloodTypeComboBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(ContactNumberLabel)
        Me.GroupBox1.Controls.Add(Me.ContactNumberTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(EmployeeNameLabel)
        Me.GroupBox1.Controls.Add(Me.EmployeeNameTextBox)
        Me.GroupBox1.Controls.Add(PlantIDLabel)
        Me.GroupBox1.Controls.Add(Me.PlantIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 405)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(342, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 12)
        Me.Label1.TabIndex = 230
        Me.Label1.Text = "Ex. SDSSU-2018-**"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(344, 370)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 229
        Me.PictureBox3.TabStop = False
        '
        'BasicTextBox
        '
        Me.BasicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Basic", True))
        Me.BasicTextBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BasicTextBox.Location = New System.Drawing.Point(156, 370)
        Me.BasicTextBox.Name = "BasicTextBox"
        Me.BasicTextBox.Size = New System.Drawing.Size(182, 23)
        Me.BasicTextBox.TabIndex = 21
        '
        'GenPayFinalBindingSource
        '
        Me.GenPayFinalBindingSource.DataMember = "GenPayFinal"
        Me.GenPayFinalBindingSource.DataSource = Me.GenerallPayrollDataSet
        '
        'GenerallPayrollDataSet
        '
        Me.GenerallPayrollDataSet.DataSetName = "GenerallPayrollDataSet"
        Me.GenerallPayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateofOriginDateTimePicker
        '
        Me.DateofOriginDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GenPayFinalBindingSource, "DateofOrigin", True))
        Me.DateofOriginDateTimePicker.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateofOriginDateTimePicker.Location = New System.Drawing.Point(156, 334)
        Me.DateofOriginDateTimePicker.Name = "DateofOriginDateTimePicker"
        Me.DateofOriginDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.DateofOriginDateTimePicker.TabIndex = 19
        '
        'PositionComboBox
        '
        Me.PositionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Position", True))
        Me.PositionComboBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"TEMPORARY FACULTY", "ADMINISTRATIVE & SUPPORT STAFF", "CONTRUCTUAL INSTRUCTORS", "CONTRUCTUAL NON-TEACHING STAFF", "ASSOCIATE PROFESSOR IV", "ASSOCIATE PROFESSOR II", "ASSOCIATE PROFESSOR I", "ASSISTANT PROFESSOR I", "ASSISTANT PROFESSOR IV", "ASSISTANT PROFESSOR III", "ASSISTANT PROFESSOR II", "ASSISTANT PROFESSOR I", "INSTRUCTOR I", "INSTRUCTOR II", "INSTRUCTOR III"})
        Me.PositionComboBox.Location = New System.Drawing.Point(156, 295)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(273, 26)
        Me.PositionComboBox.TabIndex = 17
        '
        'DesignationComboBox
        '
        Me.DesignationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Designation", True))
        Me.DesignationComboBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationComboBox.FormattingEnabled = True
        Me.DesignationComboBox.Items.AddRange(New Object() {"Registered Nurse", "Computer Engineer", "Hardware Engineer", "Web Applications Developer", "IT Analyst", "Financial Analyst", "Chemical Engineer", "Computer Engineer", "Guidance Counselor", "Mathematics Teacher", "Physics Teacher", "Research Assistant", "Political Science Teacher", "IT Teacher", "Science Teacher", "Automotive Teacher", "Filipino Teacher", "Graphic Designer", "Clerk/Encoder", "Architect", "Utility", "Truck Driver", "Human Resources Assistant", "Training Specialist"})
        Me.DesignationComboBox.Location = New System.Drawing.Point(156, 257)
        Me.DesignationComboBox.Name = "DesignationComboBox"
        Me.DesignationComboBox.Size = New System.Drawing.Size(273, 26)
        Me.DesignationComboBox.TabIndex = 15
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Department", True))
        Me.DepartmentComboBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"CEBM", "CECST", "ADMIN"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(156, 216)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(110, 26)
        Me.DepartmentComboBox.TabIndex = 13
        '
        'BloodTypeComboBox
        '
        Me.BloodTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "BloodType", True))
        Me.BloodTypeComboBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodTypeComboBox.FormattingEnabled = True
        Me.BloodTypeComboBox.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
        Me.BloodTypeComboBox.Location = New System.Drawing.Point(156, 175)
        Me.BloodTypeComboBox.Name = "BloodTypeComboBox"
        Me.BloodTypeComboBox.Size = New System.Drawing.Size(110, 26)
        Me.BloodTypeComboBox.TabIndex = 11
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(156, 143)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(182, 23)
        Me.EmailTextBox.TabIndex = 9
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(156, 107)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(182, 23)
        Me.ContactNumberTextBox.TabIndex = 7
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(156, 75)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(182, 23)
        Me.AddressTextBox.TabIndex = 5
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "EmployeeName", True))
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(156, 45)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(182, 23)
        Me.EmployeeNameTextBox.TabIndex = 3
        '
        'PlantIDTextBox
        '
        Me.PlantIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PlantID", True))
        Me.PlantIDTextBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlantIDTextBox.Location = New System.Drawing.Point(156, 14)
        Me.PlantIDTextBox.Name = "PlantIDTextBox"
        Me.PlantIDTextBox.Size = New System.Drawing.Size(182, 23)
        Me.PlantIDTextBox.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 362)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(276, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 238
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 237)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 237
        Me.PictureBox1.TabStop = False
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(457, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 500)
        Me.TabControl1.TabIndex = 57
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 474)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlantIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.BasicDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.BloodTypeDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.DateofOriginDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GenPayFinalBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        Me.txtReceipt1.Location = New System.Drawing.Point(1, 0)
        Me.txtReceipt1.Name = "txtReceipt1"
        Me.txtReceipt1.Size = New System.Drawing.Size(521, 474)
        Me.txtReceipt1.TabIndex = 0
        Me.txtReceipt1.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(12, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(906, 537)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 75
        Me.Button6.Text = "Print"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(228, 423)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 34)
        Me.Button8.TabIndex = 74
        Me.Button8.Text = "< Move Previous"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(341, 423)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 34)
        Me.Button7.TabIndex = 73
        Me.Button7.Text = "Move Next >"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.YellowGreen
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(455, 533)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(132, 40)
        Me.btnLogin.TabIndex = 228
        Me.btnLogin.Text = "Add New"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnDeleteJHS
        '
        Me.btnDeleteJHS.BackColor = System.Drawing.Color.YellowGreen
        Me.btnDeleteJHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteJHS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteJHS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteJHS.Image = CType(resources.GetObject("btnDeleteJHS.Image"), System.Drawing.Image)
        Me.btnDeleteJHS.Location = New System.Drawing.Point(731, 533)
        Me.btnDeleteJHS.Name = "btnDeleteJHS"
        Me.btnDeleteJHS.Size = New System.Drawing.Size(138, 40)
        Me.btnDeleteJHS.TabIndex = 227
        Me.btnDeleteJHS.Text = " Delete"
        Me.btnDeleteJHS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteJHS.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.YellowGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(593, 533)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 40)
        Me.Button5.TabIndex = 226
        Me.Button5.Text = "Save"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
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
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(731, 12)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(201, 31)
        Me.TextBox14.TabIndex = 229
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(624, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Search ID"
        '
        'frmregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(992, 576)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnDeleteJHS)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmregister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SURIGAO DEL SUR STATE UNIVERSITY, CANTILAN CAMPUS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenPayFinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerallPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GenerallPayrollDataSet As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSet
    Friend WithEvents GenPayFinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenPayFinalTableAdapter As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.GenPayFinalTableAdapter
    Friend WithEvents TableAdapterManager As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BasicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateofOriginDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PositionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DesignationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BloodTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlantIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtReceipt1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Public WithEvents btnLogin As System.Windows.Forms.Button
    Public WithEvents btnDeleteJHS As System.Windows.Forms.Button
    Public WithEvents Button5 As System.Windows.Forms.Button
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
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
