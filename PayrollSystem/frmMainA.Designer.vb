<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainA))
        Me.SystemInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMini = New System.Windows.Forms.Button()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnCataloging = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCirculation = New System.Windows.Forms.Button()
        Me.NotePadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SystemInfoToolStripMenuItem
        '
        Me.SystemInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStaffToolStripMenuItem, Me.RemoveStaffToolStripMenuItem})
        Me.SystemInfoToolStripMenuItem.Image = CType(resources.GetObject("SystemInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemInfoToolStripMenuItem.Name = "SystemInfoToolStripMenuItem"
        Me.SystemInfoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SystemInfoToolStripMenuItem.Size = New System.Drawing.Size(105, 25)
        Me.SystemInfoToolStripMenuItem.Text = "Manage Staff"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Image = CType(resources.GetObject("AddStaffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'RemoveStaffToolStripMenuItem
        '
        Me.RemoveStaffToolStripMenuItem.Image = CType(resources.GetObject("RemoveStaffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveStaffToolStripMenuItem.Name = "RemoveStaffToolStripMenuItem"
        Me.RemoveStaffToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RemoveStaffToolStripMenuItem.Text = "Remove Staff"
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.BackColor = System.Drawing.Color.Transparent
        Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMini.ForeColor = System.Drawing.Color.Transparent
        Me.btnMini.Image = CType(resources.GetObject("btnMini.Image"), System.Drawing.Image)
        Me.btnMini.Location = New System.Drawing.Point(356, 0)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(39, 33)
        Me.btnMini.TabIndex = 62
        Me.btnMini.UseVisualStyleBackColor = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripLabel3.Text = "CONTACT US: 09096510899"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(635, 116)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(71, 19)
        Me.lblDate.TabIndex = 61
        Me.lblDate.Text = "00:00:00"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(401, 23)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(507, 93)
        Me.lblTime.TabIndex = 60
        Me.lblTime.Text = "00:00:00 AM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(79, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 18)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Ide"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Logged As:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 23)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 144)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Image = CType(resources.GetObject("CalculatorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(89, 25)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMaintenance.BackColor = System.Drawing.Color.White
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.Image = CType(resources.GetObject("btnMaintenance.Image"), System.Drawing.Image)
        Me.btnMaintenance.Location = New System.Drawing.Point(-1, 341)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(153, 68)
        Me.btnMaintenance.TabIndex = 56
        Me.btnMaintenance.Text = "BackUp DB"
        Me.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaintenance.UseVisualStyleBackColor = False
        '
        'btnCataloging
        '
        Me.btnCataloging.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCataloging.BackColor = System.Drawing.Color.White
        Me.btnCataloging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCataloging.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCataloging.Image = CType(resources.GetObject("btnCataloging.Image"), System.Drawing.Image)
        Me.btnCataloging.Location = New System.Drawing.Point(-1, 201)
        Me.btnCataloging.Name = "btnCataloging"
        Me.btnCataloging.Size = New System.Drawing.Size(153, 68)
        Me.btnCataloging.TabIndex = 55
        Me.btnCataloging.Text = "Register Employee"
        Me.btnCataloging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCataloging.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(-1, 411)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(153, 68)
        Me.btnLogout.TabIndex = 54
        Me.btnLogout.Text = "Switch User"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnCirculation
        '
        Me.btnCirculation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCirculation.BackColor = System.Drawing.Color.White
        Me.btnCirculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCirculation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCirculation.Image = CType(resources.GetObject("btnCirculation.Image"), System.Drawing.Image)
        Me.btnCirculation.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCirculation.Location = New System.Drawing.Point(-1, 271)
        Me.btnCirculation.Name = "btnCirculation"
        Me.btnCirculation.Size = New System.Drawing.Size(153, 68)
        Me.btnCirculation.TabIndex = 53
        Me.btnCirculation.Text = "Modify Pay-Slip"
        Me.btnCirculation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCirculation.UseVisualStyleBackColor = False
        '
        'NotePadToolStripMenuItem
        '
        Me.NotePadToolStripMenuItem.Image = CType(resources.GetObject("NotePadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NotePadToolStripMenuItem.Name = "NotePadToolStripMenuItem"
        Me.NotePadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NotePadToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.NotePadToolStripMenuItem.Text = "Note Pad"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotePadToolStripMenuItem, Me.CalculatorToolStripMenuItem, Me.SystemInfoToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(900, 25)
        Me.ToolStrip2.TabIndex = 52
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(68, 25)
        Me.ToolStripMenuItem1.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 455)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(900, 25)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(154, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(746, 429)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'frmMainA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 480)
        Me.Controls.Add(Me.btnMini)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnMaintenance)
        Me.Controls.Add(Me.btnCataloging)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCirculation)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMainA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SURIGAO DEL SUR STATE UNIVERSITY, CANTILAN CAMPUS"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SystemInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnMini As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents btnMaintenance As System.Windows.Forms.Button
    Public WithEvents btnCataloging As System.Windows.Forms.Button
    Public WithEvents btnLogout As System.Windows.Forms.Button
    Public WithEvents btnCirculation As System.Windows.Forms.Button
    Friend WithEvents NotePadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AddStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
