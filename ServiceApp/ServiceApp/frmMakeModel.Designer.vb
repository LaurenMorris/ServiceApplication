<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeModel
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvMake = New System.Windows.Forms.DataGridView()
        Me.dgvModel = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabMakeModel = New System.Windows.Forms.TabPage()
        Me.dgvMakeModel = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MakeID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ModelID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tabMake = New System.Windows.Forms.TabPage()
        Me.tabModel = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabMakeModel.SuspendLayout()
        CType(Me.dgvMakeModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMake.SuspendLayout()
        Me.tabModel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(903, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(98, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(98, 22)
        Me.mnuExit.Text = "Exit"
        '
        'dgvMake
        '
        Me.dgvMake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMake.Location = New System.Drawing.Point(18, 75)
        Me.dgvMake.Name = "dgvMake"
        Me.dgvMake.Size = New System.Drawing.Size(821, 150)
        Me.dgvMake.TabIndex = 1
        '
        'dgvModel
        '
        Me.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModel.Location = New System.Drawing.Point(18, 75)
        Me.dgvModel.Name = "dgvModel"
        Me.dgvModel.Size = New System.Drawing.Size(825, 150)
        Me.dgvModel.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMakeModel)
        Me.TabControl1.Controls.Add(Me.tabMake)
        Me.TabControl1.Controls.Add(Me.tabModel)
        Me.TabControl1.Location = New System.Drawing.Point(12, 51)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(879, 396)
        Me.TabControl1.TabIndex = 1
        '
        'tabMakeModel
        '
        Me.tabMakeModel.BackColor = System.Drawing.Color.Silver
        Me.tabMakeModel.Controls.Add(Me.dgvMakeModel)
        Me.tabMakeModel.Location = New System.Drawing.Point(4, 22)
        Me.tabMakeModel.Name = "tabMakeModel"
        Me.tabMakeModel.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMakeModel.Size = New System.Drawing.Size(871, 370)
        Me.tabMakeModel.TabIndex = 0
        Me.tabMakeModel.Text = "MakeModel"
        '
        'dgvMakeModel
        '
        Me.dgvMakeModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakeModel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Version, Me.LastUpdated, Me.Deleted, Me.MakeID, Me.ModelID})
        Me.dgvMakeModel.Location = New System.Drawing.Point(19, 81)
        Me.dgvMakeModel.Name = "dgvMakeModel"
        Me.dgvMakeModel.Size = New System.Drawing.Size(826, 150)
        Me.dgvMakeModel.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Version
        '
        Me.Version.DataPropertyName = "Version"
        Me.Version.HeaderText = "Version"
        Me.Version.Name = "Version"
        '
        'LastUpdated
        '
        Me.LastUpdated.DataPropertyName = "LastUpdated"
        Me.LastUpdated.HeaderText = "Last Updated"
        Me.LastUpdated.Name = "LastUpdated"
        '
        'Deleted
        '
        Me.Deleted.DataPropertyName = "Deleted"
        Me.Deleted.HeaderText = "Deleted"
        Me.Deleted.Name = "Deleted"
        '
        'MakeID
        '
        Me.MakeID.DataPropertyName = "MakeID"
        Me.MakeID.HeaderText = "Make ID"
        Me.MakeID.Name = "MakeID"
        '
        'ModelID
        '
        Me.ModelID.DataPropertyName = "ModelID"
        Me.ModelID.HeaderText = "Model ID"
        Me.ModelID.Name = "ModelID"
        '
        'tabMake
        '
        Me.tabMake.BackColor = System.Drawing.Color.Silver
        Me.tabMake.Controls.Add(Me.dgvMake)
        Me.tabMake.Location = New System.Drawing.Point(4, 22)
        Me.tabMake.Name = "tabMake"
        Me.tabMake.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMake.Size = New System.Drawing.Size(871, 370)
        Me.tabMake.TabIndex = 1
        Me.tabMake.Text = "Make"
        '
        'tabModel
        '
        Me.tabModel.BackColor = System.Drawing.Color.Silver
        Me.tabModel.Controls.Add(Me.dgvModel)
        Me.tabModel.Location = New System.Drawing.Point(4, 22)
        Me.tabModel.Name = "tabModel"
        Me.tabModel.Padding = New System.Windows.Forms.Padding(3)
        Me.tabModel.Size = New System.Drawing.Size(871, 370)
        Me.tabModel.TabIndex = 2
        Me.tabModel.Text = "Model"
        '
        'frmMakeModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 506)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMakeModel"
        Me.Text = "frmMakeModel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabMakeModel.ResumeLayout(False)
        CType(Me.dgvMakeModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMake.ResumeLayout(False)
        Me.tabModel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvMake As System.Windows.Forms.DataGridView
    Friend WithEvents dgvModel As System.Windows.Forms.DataGridView
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabMakeModel As System.Windows.Forms.TabPage
    Friend WithEvents dgvMakeModel As System.Windows.Forms.DataGridView
    Friend WithEvents tabMake As System.Windows.Forms.TabPage
    Friend WithEvents tabModel As System.Windows.Forms.TabPage
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Version As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MakeID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ModelID As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
