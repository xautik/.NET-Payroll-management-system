<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.EmployeeName = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.button6)
        Me.GroupBox2.Controls.Add(Me.button8)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 87)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(629, 72)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(55, 20)
        Me.txtEmployee.TabIndex = 7
        Me.txtEmployee.Visible = False
        '
        'button6
        '
        Me.button6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.Location = New System.Drawing.Point(124, 28)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(94, 40)
        Me.button6.TabIndex = 4
        Me.button6.Text = "&Export Excel"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button8.Location = New System.Drawing.Point(24, 28)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(94, 40)
        Me.button8.TabIndex = 1
        Me.button8.Text = "&Reset"
        Me.button8.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 111)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1077, 461)
        Me.DataGridView1.TabIndex = 11
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.label6)
        Me.groupBox5.Controls.Add(Me.EmployeeName)
        Me.groupBox5.Location = New System.Drawing.Point(12, 18)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(358, 87)
        Me.groupBox5.TabIndex = 9
        Me.groupBox5.TabStop = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(21, 16)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(109, 18)
        Me.label6.TabIndex = 6
        Me.label6.Text = "Employee Name"
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmployeeName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.FormattingEnabled = True
        Me.EmployeeName.Location = New System.Drawing.Point(24, 42)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(291, 26)
        Me.EmployeeName.TabIndex = 2
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 589)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.groupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSearch"
        Me.Text = "Search "
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmployee As System.Windows.Forms.TextBox
    Friend WithEvents button6 As System.Windows.Forms.Button
    Friend WithEvents button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents EmployeeName As System.Windows.Forms.ComboBox
End Class
