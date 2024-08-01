<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprintpay
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
        Dim BasicLabel As System.Windows.Forms.Label
        Dim PERALabel As System.Windows.Forms.Label
        Dim GrossAmountLabel As System.Windows.Forms.Label
        Dim WtaxLabel As System.Windows.Forms.Label
        Dim GSISPremiumLabel As System.Windows.Forms.Label
        Dim GSISSalaryLoanLabel As System.Windows.Forms.Label
        Dim GSISELLabel As System.Windows.Forms.Label
        Dim GSISEMRGLLabel As System.Windows.Forms.Label
        Dim GSISPLLabel As System.Windows.Forms.Label
        Dim PagIbigPremLabel As System.Windows.Forms.Label
        Dim PagIbigMLLabel As System.Windows.Forms.Label
        Dim PagIbig2Label As System.Windows.Forms.Label
        Dim PhilHealthPremiunLabel As System.Windows.Forms.Label
        Dim LEAPLabel As System.Windows.Forms.Label
        Dim IGPLabel As System.Windows.Forms.Label
        Dim FacultyUnionLabel As System.Windows.Forms.Label
        Dim RefundDisallowLabel As System.Windows.Forms.Label
        Dim TuitionLabel As System.Windows.Forms.Label
        Dim LBPPaymentLabel As System.Windows.Forms.Label
        Dim CitySavingsLabel As System.Windows.Forms.Label
        Dim NetAmountLabel As System.Windows.Forms.Label
        Dim TotalDeductionLabel As System.Windows.Forms.Label
        Dim NoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprintpay))
        Dim DueDateLabel As System.Windows.Forms.Label
        Me.PlantIDTextBox = New System.Windows.Forms.TextBox()
        Me.GenPayFinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenerallPayrollDataSet = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSet()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.BasicTextBox = New System.Windows.Forms.TextBox()
        Me.PERATextBox = New System.Windows.Forms.TextBox()
        Me.GrossAmountTextBox = New System.Windows.Forms.TextBox()
        Me.WtaxTextBox = New System.Windows.Forms.TextBox()
        Me.GSISPremiumTextBox = New System.Windows.Forms.TextBox()
        Me.GSISSalaryLoanTextBox = New System.Windows.Forms.TextBox()
        Me.GSISELTextBox = New System.Windows.Forms.TextBox()
        Me.GSISEMRGLTextBox = New System.Windows.Forms.TextBox()
        Me.GSISPLTextBox = New System.Windows.Forms.TextBox()
        Me.PagIbigPremTextBox = New System.Windows.Forms.TextBox()
        Me.PagIbigMLTextBox = New System.Windows.Forms.TextBox()
        Me.PagIbig2TextBox = New System.Windows.Forms.TextBox()
        Me.PhilHealthPremiunTextBox = New System.Windows.Forms.TextBox()
        Me.LEAPTextBox = New System.Windows.Forms.TextBox()
        Me.IGPTextBox = New System.Windows.Forms.TextBox()
        Me.FacultyUnionTextBox = New System.Windows.Forms.TextBox()
        Me.RefundDisallowTextBox = New System.Windows.Forms.TextBox()
        Me.TuitionTextBox = New System.Windows.Forms.TextBox()
        Me.LBPPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.CitySavingsTextBox = New System.Windows.Forms.TextBox()
        Me.NetAmountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDeductionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PlantIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WtaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSISSalaryLoanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSISELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSISEMRGLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSISPLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagIbigPremDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagIbigMLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagIbig2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhilHealthPremiunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEAPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacultyUnionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefundDisallowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TuitionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBPPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitySavingsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSISPremiumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReceipt = New System.Windows.Forms.RichTextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GenPayFinalTableAdapter = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.GenPayFinalTableAdapter()
        Me.TableAdapterManager = New sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.DueDateTextBox = New System.Windows.Forms.TextBox()
        PlantIDLabel = New System.Windows.Forms.Label()
        EmployeeNameLabel = New System.Windows.Forms.Label()
        BasicLabel = New System.Windows.Forms.Label()
        PERALabel = New System.Windows.Forms.Label()
        GrossAmountLabel = New System.Windows.Forms.Label()
        WtaxLabel = New System.Windows.Forms.Label()
        GSISPremiumLabel = New System.Windows.Forms.Label()
        GSISSalaryLoanLabel = New System.Windows.Forms.Label()
        GSISELLabel = New System.Windows.Forms.Label()
        GSISEMRGLLabel = New System.Windows.Forms.Label()
        GSISPLLabel = New System.Windows.Forms.Label()
        PagIbigPremLabel = New System.Windows.Forms.Label()
        PagIbigMLLabel = New System.Windows.Forms.Label()
        PagIbig2Label = New System.Windows.Forms.Label()
        PhilHealthPremiunLabel = New System.Windows.Forms.Label()
        LEAPLabel = New System.Windows.Forms.Label()
        IGPLabel = New System.Windows.Forms.Label()
        FacultyUnionLabel = New System.Windows.Forms.Label()
        RefundDisallowLabel = New System.Windows.Forms.Label()
        TuitionLabel = New System.Windows.Forms.Label()
        LBPPaymentLabel = New System.Windows.Forms.Label()
        CitySavingsLabel = New System.Windows.Forms.Label()
        NetAmountLabel = New System.Windows.Forms.Label()
        TotalDeductionLabel = New System.Windows.Forms.Label()
        NoLabel = New System.Windows.Forms.Label()
        DueDateLabel = New System.Windows.Forms.Label()
        CType(Me.GenPayFinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerallPayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlantIDLabel
        '
        PlantIDLabel.AutoSize = True
        PlantIDLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlantIDLabel.Location = New System.Drawing.Point(42, 30)
        PlantIDLabel.Name = "PlantIDLabel"
        PlantIDLabel.Size = New System.Drawing.Size(75, 19)
        PlantIDLabel.TabIndex = 1
        PlantIDLabel.Text = "Plant ID:"
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.AutoSize = True
        EmployeeNameLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeNameLabel.Location = New System.Drawing.Point(3, 56)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(133, 19)
        EmployeeNameLabel.TabIndex = 2
        EmployeeNameLabel.Text = "Employee Name:"
        '
        'BasicLabel
        '
        BasicLabel.AutoSize = True
        BasicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BasicLabel.Location = New System.Drawing.Point(36, 29)
        BasicLabel.Name = "BasicLabel"
        BasicLabel.Size = New System.Drawing.Size(46, 15)
        BasicLabel.TabIndex = 6
        BasicLabel.Text = "Basic:"
        '
        'PERALabel
        '
        PERALabel.AutoSize = True
        PERALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PERALabel.Location = New System.Drawing.Point(33, 55)
        PERALabel.Name = "PERALabel"
        PERALabel.Size = New System.Drawing.Size(47, 15)
        PERALabel.TabIndex = 8
        PERALabel.Text = "PERA:"
        '
        'GrossAmountLabel
        '
        GrossAmountLabel.AutoSize = True
        GrossAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrossAmountLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        GrossAmountLabel.Location = New System.Drawing.Point(7, 17)
        GrossAmountLabel.Name = "GrossAmountLabel"
        GrossAmountLabel.Size = New System.Drawing.Size(108, 16)
        GrossAmountLabel.TabIndex = 10
        GrossAmountLabel.Text = "Gross Amount:"
        '
        'WtaxLabel
        '
        WtaxLabel.AutoSize = True
        WtaxLabel.Location = New System.Drawing.Point(83, 24)
        WtaxLabel.Name = "WtaxLabel"
        WtaxLabel.Size = New System.Drawing.Size(44, 18)
        WtaxLabel.TabIndex = 14
        WtaxLabel.Text = "Wtax:"
        '
        'GSISPremiumLabel
        '
        GSISPremiumLabel.AutoSize = True
        GSISPremiumLabel.Location = New System.Drawing.Point(43, 50)
        GSISPremiumLabel.Name = "GSISPremiumLabel"
        GSISPremiumLabel.Size = New System.Drawing.Size(107, 18)
        GSISPremiumLabel.TabIndex = 16
        GSISPremiumLabel.Text = "GSISPremium:"
        '
        'GSISSalaryLoanLabel
        '
        GSISSalaryLoanLabel.AutoSize = True
        GSISSalaryLoanLabel.Location = New System.Drawing.Point(27, 76)
        GSISSalaryLoanLabel.Name = "GSISSalaryLoanLabel"
        GSISSalaryLoanLabel.Size = New System.Drawing.Size(123, 18)
        GSISSalaryLoanLabel.TabIndex = 18
        GSISSalaryLoanLabel.Text = "GSISSalary Loan:"
        '
        'GSISELLabel
        '
        GSISELLabel.AutoSize = True
        GSISELLabel.Location = New System.Drawing.Point(70, 105)
        GSISELLabel.Name = "GSISELLabel"
        GSISELLabel.Size = New System.Drawing.Size(61, 18)
        GSISELLabel.TabIndex = 20
        GSISELLabel.Text = "GSISEL:"
        '
        'GSISEMRGLLabel
        '
        GSISEMRGLLabel.AutoSize = True
        GSISEMRGLLabel.Location = New System.Drawing.Point(45, 131)
        GSISEMRGLLabel.Name = "GSISEMRGLLabel"
        GSISEMRGLLabel.Size = New System.Drawing.Size(92, 18)
        GSISEMRGLLabel.TabIndex = 22
        GSISEMRGLLabel.Text = "GSISEMRGL:"
        '
        'GSISPLLabel
        '
        GSISPLLabel.AutoSize = True
        GSISPLLabel.Location = New System.Drawing.Point(70, 157)
        GSISPLLabel.Name = "GSISPLLabel"
        GSISPLLabel.Size = New System.Drawing.Size(61, 18)
        GSISPLLabel.TabIndex = 24
        GSISPLLabel.Text = "GSISPL:"
        '
        'PagIbigPremLabel
        '
        PagIbigPremLabel.AutoSize = True
        PagIbigPremLabel.Location = New System.Drawing.Point(42, 183)
        PagIbigPremLabel.Name = "PagIbigPremLabel"
        PagIbigPremLabel.Size = New System.Drawing.Size(102, 18)
        PagIbigPremLabel.TabIndex = 26
        PagIbigPremLabel.Text = "Pag Ibig Prem:"
        '
        'PagIbigMLLabel
        '
        PagIbigMLLabel.AutoSize = True
        PagIbigMLLabel.Location = New System.Drawing.Point(51, 209)
        PagIbigMLLabel.Name = "PagIbigMLLabel"
        PagIbigMLLabel.Size = New System.Drawing.Size(87, 18)
        PagIbigMLLabel.TabIndex = 28
        PagIbigMLLabel.Text = "Pag Ibig ML:"
        '
        'PagIbig2Label
        '
        PagIbig2Label.AutoSize = True
        PagIbig2Label.Location = New System.Drawing.Point(63, 235)
        PagIbig2Label.Name = "PagIbig2Label"
        PagIbig2Label.Size = New System.Drawing.Size(71, 18)
        PagIbig2Label.TabIndex = 30
        PagIbig2Label.Text = "Pag Ibig2:"
        '
        'PhilHealthPremiunLabel
        '
        PhilHealthPremiunLabel.AutoSize = True
        PhilHealthPremiunLabel.Location = New System.Drawing.Point(16, 261)
        PhilHealthPremiunLabel.Name = "PhilHealthPremiunLabel"
        PhilHealthPremiunLabel.Size = New System.Drawing.Size(148, 18)
        PhilHealthPremiunLabel.TabIndex = 32
        PhilHealthPremiunLabel.Text = "Phil Health Premiun:"
        '
        'LEAPLabel
        '
        LEAPLabel.AutoSize = True
        LEAPLabel.Location = New System.Drawing.Point(82, 285)
        LEAPLabel.Name = "LEAPLabel"
        LEAPLabel.Size = New System.Drawing.Size(45, 18)
        LEAPLabel.TabIndex = 34
        LEAPLabel.Text = "LEAP:"
        '
        'IGPLabel
        '
        IGPLabel.AutoSize = True
        IGPLabel.Location = New System.Drawing.Point(91, 311)
        IGPLabel.Name = "IGPLabel"
        IGPLabel.Size = New System.Drawing.Size(35, 18)
        IGPLabel.TabIndex = 36
        IGPLabel.Text = "IGP:"
        '
        'FacultyUnionLabel
        '
        FacultyUnionLabel.AutoSize = True
        FacultyUnionLabel.Location = New System.Drawing.Point(44, 337)
        FacultyUnionLabel.Name = "FacultyUnionLabel"
        FacultyUnionLabel.Size = New System.Drawing.Size(104, 18)
        FacultyUnionLabel.TabIndex = 38
        FacultyUnionLabel.Text = "Faculty Union:"
        '
        'RefundDisallowLabel
        '
        RefundDisallowLabel.AutoSize = True
        RefundDisallowLabel.Location = New System.Drawing.Point(32, 363)
        RefundDisallowLabel.Name = "RefundDisallowLabel"
        RefundDisallowLabel.Size = New System.Drawing.Size(117, 18)
        RefundDisallowLabel.TabIndex = 40
        RefundDisallowLabel.Text = "Refund Disallow:"
        '
        'TuitionLabel
        '
        TuitionLabel.AutoSize = True
        TuitionLabel.Location = New System.Drawing.Point(77, 389)
        TuitionLabel.Name = "TuitionLabel"
        TuitionLabel.Size = New System.Drawing.Size(61, 18)
        TuitionLabel.TabIndex = 42
        TuitionLabel.Text = "Tuition:"
        '
        'LBPPaymentLabel
        '
        LBPPaymentLabel.AutoSize = True
        LBPPaymentLabel.Location = New System.Drawing.Point(48, 415)
        LBPPaymentLabel.Name = "LBPPaymentLabel"
        LBPPaymentLabel.Size = New System.Drawing.Size(95, 18)
        LBPPaymentLabel.TabIndex = 44
        LBPPaymentLabel.Text = "LBPPayment:"
        '
        'CitySavingsLabel
        '
        CitySavingsLabel.AutoSize = True
        CitySavingsLabel.Location = New System.Drawing.Point(51, 441)
        CitySavingsLabel.Name = "CitySavingsLabel"
        CitySavingsLabel.Size = New System.Drawing.Size(95, 18)
        CitySavingsLabel.TabIndex = 46
        CitySavingsLabel.Text = "City Savings:"
        '
        'NetAmountLabel
        '
        NetAmountLabel.AutoSize = True
        NetAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NetAmountLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        NetAmountLabel.Location = New System.Drawing.Point(9, 20)
        NetAmountLabel.Name = "NetAmountLabel"
        NetAmountLabel.Size = New System.Drawing.Size(101, 18)
        NetAmountLabel.TabIndex = 48
        NetAmountLabel.Text = "Net Amount:"
        '
        'TotalDeductionLabel
        '
        TotalDeductionLabel.AutoSize = True
        TotalDeductionLabel.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalDeductionLabel.ForeColor = System.Drawing.Color.Red
        TotalDeductionLabel.Location = New System.Drawing.Point(7, 22)
        TotalDeductionLabel.Name = "TotalDeductionLabel"
        TotalDeductionLabel.Size = New System.Drawing.Size(138, 18)
        TotalDeductionLabel.TabIndex = 50
        TotalDeductionLabel.Text = "Total Deduction:"
        '
        'NoLabel
        '
        NoLabel.AutoSize = True
        NoLabel.Location = New System.Drawing.Point(105, 90)
        NoLabel.Name = "NoLabel"
        NoLabel.Size = New System.Drawing.Size(24, 13)
        NoLabel.TabIndex = 4
        NoLabel.Text = "No:"
        '
        'PlantIDTextBox
        '
        Me.PlantIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PlantID", True))
        Me.PlantIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlantIDTextBox.Location = New System.Drawing.Point(135, 31)
        Me.PlantIDTextBox.Name = "PlantIDTextBox"
        Me.PlantIDTextBox.ReadOnly = True
        Me.PlantIDTextBox.Size = New System.Drawing.Size(167, 24)
        Me.PlantIDTextBox.TabIndex = 2
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
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "EmployeeName", True))
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(135, 57)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.ReadOnly = True
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(167, 24)
        Me.EmployeeNameTextBox.TabIndex = 3
        '
        'BasicTextBox
        '
        Me.BasicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Basic", True))
        Me.BasicTextBox.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicTextBox.Location = New System.Drawing.Point(86, 28)
        Me.BasicTextBox.Name = "BasicTextBox"
        Me.BasicTextBox.ReadOnly = True
        Me.BasicTextBox.Size = New System.Drawing.Size(165, 20)
        Me.BasicTextBox.TabIndex = 7
        '
        'PERATextBox
        '
        Me.PERATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PERA", True))
        Me.PERATextBox.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PERATextBox.Location = New System.Drawing.Point(86, 54)
        Me.PERATextBox.Name = "PERATextBox"
        Me.PERATextBox.ReadOnly = True
        Me.PERATextBox.Size = New System.Drawing.Size(165, 20)
        Me.PERATextBox.TabIndex = 9
        '
        'GrossAmountTextBox
        '
        Me.GrossAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "GrossAmount", True))
        Me.GrossAmountTextBox.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossAmountTextBox.Location = New System.Drawing.Point(119, 14)
        Me.GrossAmountTextBox.Name = "GrossAmountTextBox"
        Me.GrossAmountTextBox.ReadOnly = True
        Me.GrossAmountTextBox.Size = New System.Drawing.Size(125, 23)
        Me.GrossAmountTextBox.TabIndex = 11
        '
        'WtaxTextBox
        '
        Me.WtaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Wtax", True))
        Me.WtaxTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WtaxTextBox.Location = New System.Drawing.Point(186, 19)
        Me.WtaxTextBox.Name = "WtaxTextBox"
        Me.WtaxTextBox.ReadOnly = True
        Me.WtaxTextBox.Size = New System.Drawing.Size(145, 25)
        Me.WtaxTextBox.TabIndex = 15
        '
        'GSISPremiumTextBox
        '
        Me.GSISPremiumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "GSISPremium", True))
        Me.GSISPremiumTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSISPremiumTextBox.Location = New System.Drawing.Point(186, 45)
        Me.GSISPremiumTextBox.Name = "GSISPremiumTextBox"
        Me.GSISPremiumTextBox.ReadOnly = True
        Me.GSISPremiumTextBox.Size = New System.Drawing.Size(145, 25)
        Me.GSISPremiumTextBox.TabIndex = 17
        '
        'GSISSalaryLoanTextBox
        '
        Me.GSISSalaryLoanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "GSISSalaryLoan", True))
        Me.GSISSalaryLoanTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSISSalaryLoanTextBox.Location = New System.Drawing.Point(186, 71)
        Me.GSISSalaryLoanTextBox.Name = "GSISSalaryLoanTextBox"
        Me.GSISSalaryLoanTextBox.ReadOnly = True
        Me.GSISSalaryLoanTextBox.Size = New System.Drawing.Size(145, 25)
        Me.GSISSalaryLoanTextBox.TabIndex = 19
        '
        'GSISELTextBox
        '
        Me.GSISELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "GSISEL", True))
        Me.GSISELTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSISELTextBox.Location = New System.Drawing.Point(186, 100)
        Me.GSISELTextBox.Name = "GSISELTextBox"
        Me.GSISELTextBox.ReadOnly = True
        Me.GSISELTextBox.Size = New System.Drawing.Size(145, 25)
        Me.GSISELTextBox.TabIndex = 21
        '
        'GSISEMRGLTextBox
        '
        Me.GSISEMRGLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "GSISEMRGL", True))
        Me.GSISEMRGLTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSISEMRGLTextBox.Location = New System.Drawing.Point(186, 126)
        Me.GSISEMRGLTextBox.Name = "GSISEMRGLTextBox"
        Me.GSISEMRGLTextBox.ReadOnly = True
        Me.GSISEMRGLTextBox.Size = New System.Drawing.Size(145, 25)
        Me.GSISEMRGLTextBox.TabIndex = 23
        '
        'GSISPLTextBox
        '
        Me.GSISPLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "GSISPL", True))
        Me.GSISPLTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSISPLTextBox.Location = New System.Drawing.Point(186, 152)
        Me.GSISPLTextBox.Name = "GSISPLTextBox"
        Me.GSISPLTextBox.ReadOnly = True
        Me.GSISPLTextBox.Size = New System.Drawing.Size(145, 25)
        Me.GSISPLTextBox.TabIndex = 25
        '
        'PagIbigPremTextBox
        '
        Me.PagIbigPremTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PagIbigPrem", True))
        Me.PagIbigPremTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagIbigPremTextBox.Location = New System.Drawing.Point(186, 178)
        Me.PagIbigPremTextBox.Name = "PagIbigPremTextBox"
        Me.PagIbigPremTextBox.ReadOnly = True
        Me.PagIbigPremTextBox.Size = New System.Drawing.Size(145, 25)
        Me.PagIbigPremTextBox.TabIndex = 27
        '
        'PagIbigMLTextBox
        '
        Me.PagIbigMLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PagIbigML", True))
        Me.PagIbigMLTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagIbigMLTextBox.Location = New System.Drawing.Point(186, 204)
        Me.PagIbigMLTextBox.Name = "PagIbigMLTextBox"
        Me.PagIbigMLTextBox.ReadOnly = True
        Me.PagIbigMLTextBox.Size = New System.Drawing.Size(145, 25)
        Me.PagIbigMLTextBox.TabIndex = 29
        '
        'PagIbig2TextBox
        '
        Me.PagIbig2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PagIbig2", True))
        Me.PagIbig2TextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagIbig2TextBox.Location = New System.Drawing.Point(186, 230)
        Me.PagIbig2TextBox.Name = "PagIbig2TextBox"
        Me.PagIbig2TextBox.ReadOnly = True
        Me.PagIbig2TextBox.Size = New System.Drawing.Size(145, 25)
        Me.PagIbig2TextBox.TabIndex = 31
        '
        'PhilHealthPremiunTextBox
        '
        Me.PhilHealthPremiunTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "PhilHealthPremiun", True))
        Me.PhilHealthPremiunTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhilHealthPremiunTextBox.Location = New System.Drawing.Point(186, 256)
        Me.PhilHealthPremiunTextBox.Name = "PhilHealthPremiunTextBox"
        Me.PhilHealthPremiunTextBox.ReadOnly = True
        Me.PhilHealthPremiunTextBox.Size = New System.Drawing.Size(145, 25)
        Me.PhilHealthPremiunTextBox.TabIndex = 33
        '
        'LEAPTextBox
        '
        Me.LEAPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "LEAP", True))
        Me.LEAPTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEAPTextBox.Location = New System.Drawing.Point(186, 282)
        Me.LEAPTextBox.Name = "LEAPTextBox"
        Me.LEAPTextBox.ReadOnly = True
        Me.LEAPTextBox.Size = New System.Drawing.Size(145, 25)
        Me.LEAPTextBox.TabIndex = 35
        '
        'IGPTextBox
        '
        Me.IGPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "IGP", True))
        Me.IGPTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IGPTextBox.Location = New System.Drawing.Point(186, 308)
        Me.IGPTextBox.Name = "IGPTextBox"
        Me.IGPTextBox.ReadOnly = True
        Me.IGPTextBox.Size = New System.Drawing.Size(145, 25)
        Me.IGPTextBox.TabIndex = 37
        '
        'FacultyUnionTextBox
        '
        Me.FacultyUnionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "FacultyUnion", True))
        Me.FacultyUnionTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacultyUnionTextBox.Location = New System.Drawing.Point(186, 334)
        Me.FacultyUnionTextBox.Name = "FacultyUnionTextBox"
        Me.FacultyUnionTextBox.ReadOnly = True
        Me.FacultyUnionTextBox.Size = New System.Drawing.Size(145, 25)
        Me.FacultyUnionTextBox.TabIndex = 39
        '
        'RefundDisallowTextBox
        '
        Me.RefundDisallowTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "RefundDisallow", True))
        Me.RefundDisallowTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefundDisallowTextBox.Location = New System.Drawing.Point(186, 360)
        Me.RefundDisallowTextBox.Name = "RefundDisallowTextBox"
        Me.RefundDisallowTextBox.ReadOnly = True
        Me.RefundDisallowTextBox.Size = New System.Drawing.Size(145, 25)
        Me.RefundDisallowTextBox.TabIndex = 41
        '
        'TuitionTextBox
        '
        Me.TuitionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "Tuition", True))
        Me.TuitionTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuitionTextBox.Location = New System.Drawing.Point(186, 386)
        Me.TuitionTextBox.Name = "TuitionTextBox"
        Me.TuitionTextBox.ReadOnly = True
        Me.TuitionTextBox.Size = New System.Drawing.Size(145, 25)
        Me.TuitionTextBox.TabIndex = 43
        '
        'LBPPaymentTextBox
        '
        Me.LBPPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "LBPPayment", True))
        Me.LBPPaymentTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPPaymentTextBox.Location = New System.Drawing.Point(186, 412)
        Me.LBPPaymentTextBox.Name = "LBPPaymentTextBox"
        Me.LBPPaymentTextBox.ReadOnly = True
        Me.LBPPaymentTextBox.Size = New System.Drawing.Size(145, 25)
        Me.LBPPaymentTextBox.TabIndex = 45
        '
        'CitySavingsTextBox
        '
        Me.CitySavingsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "CitySavings", True))
        Me.CitySavingsTextBox.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitySavingsTextBox.Location = New System.Drawing.Point(186, 438)
        Me.CitySavingsTextBox.Name = "CitySavingsTextBox"
        Me.CitySavingsTextBox.ReadOnly = True
        Me.CitySavingsTextBox.Size = New System.Drawing.Size(145, 25)
        Me.CitySavingsTextBox.TabIndex = 47
        '
        'NetAmountTextBox
        '
        Me.NetAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "NetAmount", True))
        Me.NetAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetAmountTextBox.Location = New System.Drawing.Point(116, 17)
        Me.NetAmountTextBox.Name = "NetAmountTextBox"
        Me.NetAmountTextBox.ReadOnly = True
        Me.NetAmountTextBox.Size = New System.Drawing.Size(172, 24)
        Me.NetAmountTextBox.TabIndex = 49
        '
        'TotalDeductionTextBox
        '
        Me.TotalDeductionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "TotalDeduction", True))
        Me.TotalDeductionTextBox.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDeductionTextBox.ForeColor = System.Drawing.Color.Red
        Me.TotalDeductionTextBox.Location = New System.Drawing.Point(149, 20)
        Me.TotalDeductionTextBox.Name = "TotalDeductionTextBox"
        Me.TotalDeductionTextBox.ReadOnly = True
        Me.TotalDeductionTextBox.Size = New System.Drawing.Size(157, 26)
        Me.TotalDeductionTextBox.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.WtaxTextBox)
        Me.GroupBox1.Controls.Add(WtaxLabel)
        Me.GroupBox1.Controls.Add(Me.GSISPremiumTextBox)
        Me.GroupBox1.Controls.Add(GSISPremiumLabel)
        Me.GroupBox1.Controls.Add(Me.GSISSalaryLoanTextBox)
        Me.GroupBox1.Controls.Add(CitySavingsLabel)
        Me.GroupBox1.Controls.Add(GSISSalaryLoanLabel)
        Me.GroupBox1.Controls.Add(Me.CitySavingsTextBox)
        Me.GroupBox1.Controls.Add(Me.GSISELTextBox)
        Me.GroupBox1.Controls.Add(LBPPaymentLabel)
        Me.GroupBox1.Controls.Add(GSISELLabel)
        Me.GroupBox1.Controls.Add(Me.LBPPaymentTextBox)
        Me.GroupBox1.Controls.Add(Me.GSISEMRGLTextBox)
        Me.GroupBox1.Controls.Add(TuitionLabel)
        Me.GroupBox1.Controls.Add(GSISEMRGLLabel)
        Me.GroupBox1.Controls.Add(Me.TuitionTextBox)
        Me.GroupBox1.Controls.Add(Me.GSISPLTextBox)
        Me.GroupBox1.Controls.Add(RefundDisallowLabel)
        Me.GroupBox1.Controls.Add(GSISPLLabel)
        Me.GroupBox1.Controls.Add(Me.RefundDisallowTextBox)
        Me.GroupBox1.Controls.Add(Me.PagIbigPremTextBox)
        Me.GroupBox1.Controls.Add(FacultyUnionLabel)
        Me.GroupBox1.Controls.Add(PagIbigPremLabel)
        Me.GroupBox1.Controls.Add(Me.FacultyUnionTextBox)
        Me.GroupBox1.Controls.Add(Me.PagIbigMLTextBox)
        Me.GroupBox1.Controls.Add(IGPLabel)
        Me.GroupBox1.Controls.Add(PagIbigMLLabel)
        Me.GroupBox1.Controls.Add(Me.IGPTextBox)
        Me.GroupBox1.Controls.Add(Me.PagIbig2TextBox)
        Me.GroupBox1.Controls.Add(LEAPLabel)
        Me.GroupBox1.Controls.Add(PagIbig2Label)
        Me.GroupBox1.Controls.Add(Me.LEAPTextBox)
        Me.GroupBox1.Controls.Add(Me.PhilHealthPremiunTextBox)
        Me.GroupBox1.Controls.Add(PhilHealthPremiunLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(324, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 532)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deductions"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TotalDeductionTextBox)
        Me.GroupBox2.Controls.Add(TotalDeductionLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 467)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 57)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(NoLabel)
        Me.GroupBox3.Controls.Add(Me.NoTextBox)
        Me.GroupBox3.Controls.Add(Me.PlantIDTextBox)
        Me.GroupBox3.Controls.Add(PlantIDLabel)
        Me.GroupBox3.Controls.Add(Me.EmployeeNameTextBox)
        Me.GroupBox3.Controls.Add(EmployeeNameLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 114)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        '
        'NoTextBox
        '
        Me.NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "No", True))
        Me.NoTextBox.Location = New System.Drawing.Point(135, 87)
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.ReadOnly = True
        Me.NoTextBox.Size = New System.Drawing.Size(58, 20)
        Me.NoTextBox.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.BasicTextBox)
        Me.GroupBox4.Controls.Add(BasicLabel)
        Me.GroupBox4.Controls.Add(Me.PERATextBox)
        Me.GroupBox4.Controls.Add(PERALabel)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 148)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(269, 136)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GrossAmountTextBox)
        Me.GroupBox5.Controls.Add(GrossAmountLabel)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(251, 44)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NetAmountTextBox)
        Me.GroupBox6.Controls.Add(NetAmountLabel)
        Me.GroupBox6.Location = New System.Drawing.Point(667, 584)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(306, 51)
        Me.GroupBox6.TabIndex = 55
        Me.GroupBox6.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(667, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(588, 500)
        Me.TabControl1.TabIndex = 222
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(580, 471)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlantIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.BasicDataGridViewTextBoxColumn, Me.PERADataGridViewTextBoxColumn, Me.GrossAmountDataGridViewTextBoxColumn, Me.WtaxDataGridViewTextBoxColumn, Me.GSISSalaryLoanDataGridViewTextBoxColumn, Me.GSISELDataGridViewTextBoxColumn, Me.GSISEMRGLDataGridViewTextBoxColumn, Me.GSISPLDataGridViewTextBoxColumn, Me.PagIbigPremDataGridViewTextBoxColumn, Me.PagIbigMLDataGridViewTextBoxColumn, Me.PagIbig2DataGridViewTextBoxColumn, Me.PhilHealthPremiunDataGridViewTextBoxColumn, Me.LEAPDataGridViewTextBoxColumn, Me.IGPDataGridViewTextBoxColumn, Me.FacultyUnionDataGridViewTextBoxColumn, Me.RefundDisallowDataGridViewTextBoxColumn, Me.TuitionDataGridViewTextBoxColumn, Me.LBPPaymentDataGridViewTextBoxColumn, Me.CitySavingsDataGridViewTextBoxColumn, Me.TotalDeductionDataGridViewTextBoxColumn, Me.NetAmountDataGridViewTextBoxColumn, Me.NoDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn, Me.GSISPremiumDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GenPayFinalBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.MenuText
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(577, 477)
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
        'PERADataGridViewTextBoxColumn
        '
        Me.PERADataGridViewTextBoxColumn.DataPropertyName = "PERA"
        Me.PERADataGridViewTextBoxColumn.HeaderText = "PERA"
        Me.PERADataGridViewTextBoxColumn.Name = "PERADataGridViewTextBoxColumn"
        Me.PERADataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrossAmountDataGridViewTextBoxColumn
        '
        Me.GrossAmountDataGridViewTextBoxColumn.DataPropertyName = "GrossAmount"
        Me.GrossAmountDataGridViewTextBoxColumn.HeaderText = "GrossAmount"
        Me.GrossAmountDataGridViewTextBoxColumn.Name = "GrossAmountDataGridViewTextBoxColumn"
        Me.GrossAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WtaxDataGridViewTextBoxColumn
        '
        Me.WtaxDataGridViewTextBoxColumn.DataPropertyName = "Wtax"
        Me.WtaxDataGridViewTextBoxColumn.HeaderText = "Wtax"
        Me.WtaxDataGridViewTextBoxColumn.Name = "WtaxDataGridViewTextBoxColumn"
        Me.WtaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GSISSalaryLoanDataGridViewTextBoxColumn
        '
        Me.GSISSalaryLoanDataGridViewTextBoxColumn.DataPropertyName = "GSISSalaryLoan"
        Me.GSISSalaryLoanDataGridViewTextBoxColumn.HeaderText = "GSISSalaryLoan"
        Me.GSISSalaryLoanDataGridViewTextBoxColumn.Name = "GSISSalaryLoanDataGridViewTextBoxColumn"
        Me.GSISSalaryLoanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GSISELDataGridViewTextBoxColumn
        '
        Me.GSISELDataGridViewTextBoxColumn.DataPropertyName = "GSISEL"
        Me.GSISELDataGridViewTextBoxColumn.HeaderText = "GSISEL"
        Me.GSISELDataGridViewTextBoxColumn.Name = "GSISELDataGridViewTextBoxColumn"
        Me.GSISELDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GSISEMRGLDataGridViewTextBoxColumn
        '
        Me.GSISEMRGLDataGridViewTextBoxColumn.DataPropertyName = "GSISEMRGL"
        Me.GSISEMRGLDataGridViewTextBoxColumn.HeaderText = "GSISEMRGL"
        Me.GSISEMRGLDataGridViewTextBoxColumn.Name = "GSISEMRGLDataGridViewTextBoxColumn"
        Me.GSISEMRGLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GSISPLDataGridViewTextBoxColumn
        '
        Me.GSISPLDataGridViewTextBoxColumn.DataPropertyName = "GSISPL"
        Me.GSISPLDataGridViewTextBoxColumn.HeaderText = "GSISPL"
        Me.GSISPLDataGridViewTextBoxColumn.Name = "GSISPLDataGridViewTextBoxColumn"
        Me.GSISPLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagIbigPremDataGridViewTextBoxColumn
        '
        Me.PagIbigPremDataGridViewTextBoxColumn.DataPropertyName = "PagIbigPrem"
        Me.PagIbigPremDataGridViewTextBoxColumn.HeaderText = "PagIbigPrem"
        Me.PagIbigPremDataGridViewTextBoxColumn.Name = "PagIbigPremDataGridViewTextBoxColumn"
        Me.PagIbigPremDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagIbigMLDataGridViewTextBoxColumn
        '
        Me.PagIbigMLDataGridViewTextBoxColumn.DataPropertyName = "PagIbigML"
        Me.PagIbigMLDataGridViewTextBoxColumn.HeaderText = "PagIbigML"
        Me.PagIbigMLDataGridViewTextBoxColumn.Name = "PagIbigMLDataGridViewTextBoxColumn"
        Me.PagIbigMLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagIbig2DataGridViewTextBoxColumn
        '
        Me.PagIbig2DataGridViewTextBoxColumn.DataPropertyName = "PagIbig2"
        Me.PagIbig2DataGridViewTextBoxColumn.HeaderText = "PagIbig2"
        Me.PagIbig2DataGridViewTextBoxColumn.Name = "PagIbig2DataGridViewTextBoxColumn"
        Me.PagIbig2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhilHealthPremiunDataGridViewTextBoxColumn
        '
        Me.PhilHealthPremiunDataGridViewTextBoxColumn.DataPropertyName = "PhilHealthPremiun"
        Me.PhilHealthPremiunDataGridViewTextBoxColumn.HeaderText = "PhilHealthPremiun"
        Me.PhilHealthPremiunDataGridViewTextBoxColumn.Name = "PhilHealthPremiunDataGridViewTextBoxColumn"
        Me.PhilHealthPremiunDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LEAPDataGridViewTextBoxColumn
        '
        Me.LEAPDataGridViewTextBoxColumn.DataPropertyName = "LEAP"
        Me.LEAPDataGridViewTextBoxColumn.HeaderText = "LEAP"
        Me.LEAPDataGridViewTextBoxColumn.Name = "LEAPDataGridViewTextBoxColumn"
        Me.LEAPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IGPDataGridViewTextBoxColumn
        '
        Me.IGPDataGridViewTextBoxColumn.DataPropertyName = "IGP"
        Me.IGPDataGridViewTextBoxColumn.HeaderText = "IGP"
        Me.IGPDataGridViewTextBoxColumn.Name = "IGPDataGridViewTextBoxColumn"
        Me.IGPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacultyUnionDataGridViewTextBoxColumn
        '
        Me.FacultyUnionDataGridViewTextBoxColumn.DataPropertyName = "FacultyUnion"
        Me.FacultyUnionDataGridViewTextBoxColumn.HeaderText = "FacultyUnion"
        Me.FacultyUnionDataGridViewTextBoxColumn.Name = "FacultyUnionDataGridViewTextBoxColumn"
        Me.FacultyUnionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RefundDisallowDataGridViewTextBoxColumn
        '
        Me.RefundDisallowDataGridViewTextBoxColumn.DataPropertyName = "RefundDisallow"
        Me.RefundDisallowDataGridViewTextBoxColumn.HeaderText = "RefundDisallow"
        Me.RefundDisallowDataGridViewTextBoxColumn.Name = "RefundDisallowDataGridViewTextBoxColumn"
        Me.RefundDisallowDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TuitionDataGridViewTextBoxColumn
        '
        Me.TuitionDataGridViewTextBoxColumn.DataPropertyName = "Tuition"
        Me.TuitionDataGridViewTextBoxColumn.HeaderText = "Tuition"
        Me.TuitionDataGridViewTextBoxColumn.Name = "TuitionDataGridViewTextBoxColumn"
        Me.TuitionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LBPPaymentDataGridViewTextBoxColumn
        '
        Me.LBPPaymentDataGridViewTextBoxColumn.DataPropertyName = "LBPPayment"
        Me.LBPPaymentDataGridViewTextBoxColumn.HeaderText = "LBPPayment"
        Me.LBPPaymentDataGridViewTextBoxColumn.Name = "LBPPaymentDataGridViewTextBoxColumn"
        Me.LBPPaymentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CitySavingsDataGridViewTextBoxColumn
        '
        Me.CitySavingsDataGridViewTextBoxColumn.DataPropertyName = "CitySavings"
        Me.CitySavingsDataGridViewTextBoxColumn.HeaderText = "CitySavings"
        Me.CitySavingsDataGridViewTextBoxColumn.Name = "CitySavingsDataGridViewTextBoxColumn"
        Me.CitySavingsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDeductionDataGridViewTextBoxColumn
        '
        Me.TotalDeductionDataGridViewTextBoxColumn.DataPropertyName = "TotalDeduction"
        Me.TotalDeductionDataGridViewTextBoxColumn.HeaderText = "TotalDeduction"
        Me.TotalDeductionDataGridViewTextBoxColumn.Name = "TotalDeductionDataGridViewTextBoxColumn"
        Me.TotalDeductionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NetAmountDataGridViewTextBoxColumn
        '
        Me.NetAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount"
        Me.NetAmountDataGridViewTextBoxColumn.HeaderText = "NetAmount"
        Me.NetAmountDataGridViewTextBoxColumn.Name = "NetAmountDataGridViewTextBoxColumn"
        Me.NetAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoDataGridViewTextBoxColumn
        '
        Me.NoDataGridViewTextBoxColumn.DataPropertyName = "No"
        Me.NoDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NoDataGridViewTextBoxColumn.Name = "NoDataGridViewTextBoxColumn"
        Me.NoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        Me.DueDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GSISPremiumDataGridViewTextBoxColumn
        '
        Me.GSISPremiumDataGridViewTextBoxColumn.DataPropertyName = "GSISPremium"
        Me.GSISPremiumDataGridViewTextBoxColumn.HeaderText = "GSISPremium"
        Me.GSISPremiumDataGridViewTextBoxColumn.Name = "GSISPremiumDataGridViewTextBoxColumn"
        Me.GSISPremiumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtReceipt)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(580, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtReceipt
        '
        Me.txtReceipt.Location = New System.Drawing.Point(0, 0)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.ReadOnly = True
        Me.txtReceipt.Size = New System.Drawing.Size(580, 474)
        Me.txtReceipt.TabIndex = 0
        Me.txtReceipt.Text = ""
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(1124, 597)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(127, 36)
        Me.Button9.TabIndex = 234
        Me.Button9.Text = "Back"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(667, 524)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(102, 23)
        Me.Button8.TabIndex = 233
        Me.Button8.Text = "< Move Previous"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(775, 524)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(92, 23)
        Me.Button7.TabIndex = 232
        Me.Button7.Text = "Move Next >"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1174, 523)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 230
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 484)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(276, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 236
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 355)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 235
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(897, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Search ID"
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(1004, 7)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(201, 31)
        Me.TextBox14.TabIndex = 237
        '
        'DueDateLabel
        '
        DueDateLabel.AutoSize = True
        DueDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DueDateLabel.Location = New System.Drawing.Point(366, 46)
        DueDateLabel.Name = "DueDateLabel"
        DueDateLabel.Size = New System.Drawing.Size(74, 18)
        DueDateLabel.TabIndex = 238
        DueDateLabel.Text = "Due Date:"
        '
        'DueDateTextBox
        '
        Me.DueDateTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.DueDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GenPayFinalBindingSource, "DueDate", True))
        Me.DueDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueDateTextBox.Location = New System.Drawing.Point(451, 43)
        Me.DueDateTextBox.Name = "DueDateTextBox"
        Me.DueDateTextBox.ReadOnly = True
        Me.DueDateTextBox.Size = New System.Drawing.Size(204, 29)
        Me.DueDateTextBox.TabIndex = 239
        '
        'frmprintpay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1275, 660)
        Me.Controls.Add(DueDateLabel)
        Me.Controls.Add(Me.DueDateTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmprintpay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SURIGAO DEL SUR STATE UNIVERSITY, CANTILAN CAMPUS"
        CType(Me.GenPayFinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerallPayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GenerallPayrollDataSet As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSet
    Friend WithEvents GenPayFinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenPayFinalTableAdapter As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.GenPayFinalTableAdapter
    Friend WithEvents TableAdapterManager As sdssuHOLLISTICPayrollsystem.GenerallPayrollDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlantIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BasicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PERATextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrossAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WtaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GSISPremiumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GSISSalaryLoanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GSISELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GSISEMRGLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GSISPLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagIbigPremTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagIbigMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagIbig2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhilHealthPremiunTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LEAPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IGPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FacultyUnionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefundDisallowTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TuitionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LBPPaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitySavingsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDeductionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtReceipt As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PlantIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PERADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrossAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WtaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSISSalaryLoanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSISELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSISEMRGLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSISPLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagIbigPremDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagIbigMLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagIbig2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhilHealthPremiunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LEAPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacultyUnionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefundDisallowDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TuitionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LBPPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CitySavingsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDeductionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSISPremiumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents DueDateTextBox As System.Windows.Forms.TextBox
End Class
