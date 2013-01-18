<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkorderEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkorderEdit))
        Me.lblDateClosed = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDateOpened = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboWorkorder = New System.Windows.Forms.ComboBox()
        Me.dgvWorkorderComment = New System.Windows.Forms.DataGridView()
        Me.WorkorderCommentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderCommentVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderCommentLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderCommentDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WorkorderCommentWorkorderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvWorkorderLabor = New System.Windows.Forms.DataGridView()
        Me.WorkorderLaborID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderLaborVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderLaborLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderLaborDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WorkorderLaborWorkorderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TechID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaborDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaborHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvWorkorderPart = New System.Windows.Forms.DataGridView()
        Me.WorkorderPartID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderPartVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderPartLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkorderPartDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WorkorderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLaborRate = New System.Windows.Forms.TextBox()
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.cboModel = New System.Windows.Forms.ComboBox()
        Me.cboSerial = New System.Windows.Forms.ComboBox()
        CType(Me.dgvWorkorderComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWorkorderLabor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWorkorderPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDateClosed
        '
        Me.lblDateClosed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDateClosed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateClosed.Location = New System.Drawing.Point(612, 29)
        Me.lblDateClosed.Name = "lblDateClosed"
        Me.lblDateClosed.Size = New System.Drawing.Size(104, 27)
        Me.lblDateClosed.TabIndex = 7
        Me.lblDateClosed.Text = "12/12/9999"
        Me.lblDateClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(520, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date Closed:"
        '
        'cboCustomer
        '
        Me.cboCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(256, 76)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(325, 24)
        Me.cboCustomer.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(172, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Customer:"
        '
        'lblDateOpened
        '
        Me.lblDateOpened.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDateOpened.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOpened.Location = New System.Drawing.Point(367, 31)
        Me.lblDateOpened.Name = "lblDateOpened"
        Me.lblDateOpened.Size = New System.Drawing.Size(104, 27)
        Me.lblDateOpened.TabIndex = 25
        Me.lblDateOpened.Text = "1/08/2013"
        Me.lblDateOpened.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Date Opened:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Workorder:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(282, 635)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 43)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save Workorder"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(398, 635)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 43)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Close Workorder"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Model :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(488, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Serial Number :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Make :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Parts :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Labor :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-2, 534)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Comments :"
        '
        'cboWorkorder
        '
        Me.cboWorkorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWorkorder.FormattingEnabled = True
        Me.cboWorkorder.Location = New System.Drawing.Point(120, 31)
        Me.cboWorkorder.Name = "cboWorkorder"
        Me.cboWorkorder.Size = New System.Drawing.Size(134, 24)
        Me.cboWorkorder.TabIndex = 54
        '
        'dgvWorkorderComment
        '
        Me.dgvWorkorderComment.AllowUserToDeleteRows = False
        Me.dgvWorkorderComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkorderComment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorkorderCommentID, Me.WorkorderCommentVersion, Me.WorkorderCommentLastUpdated, Me.WorkorderCommentDeleted, Me.WorkorderCommentWorkorderID, Me.Comment})
        Me.dgvWorkorderComment.Location = New System.Drawing.Point(82, 484)
        Me.dgvWorkorderComment.Name = "dgvWorkorderComment"
        Me.dgvWorkorderComment.Size = New System.Drawing.Size(677, 110)
        Me.dgvWorkorderComment.TabIndex = 57
        '
        'WorkorderCommentID
        '
        Me.WorkorderCommentID.DataPropertyName = "ID"
        Me.WorkorderCommentID.HeaderText = "ID"
        Me.WorkorderCommentID.Name = "WorkorderCommentID"
        Me.WorkorderCommentID.Visible = False
        Me.WorkorderCommentID.Width = 500
        '
        'WorkorderCommentVersion
        '
        Me.WorkorderCommentVersion.DataPropertyName = "Version"
        Me.WorkorderCommentVersion.HeaderText = "Version"
        Me.WorkorderCommentVersion.Name = "WorkorderCommentVersion"
        Me.WorkorderCommentVersion.Visible = False
        '
        'WorkorderCommentLastUpdated
        '
        Me.WorkorderCommentLastUpdated.DataPropertyName = "LastUpdated"
        Me.WorkorderCommentLastUpdated.HeaderText = "Last Updated"
        Me.WorkorderCommentLastUpdated.Name = "WorkorderCommentLastUpdated"
        Me.WorkorderCommentLastUpdated.Visible = False
        '
        'WorkorderCommentDeleted
        '
        Me.WorkorderCommentDeleted.DataPropertyName = "Deleted"
        Me.WorkorderCommentDeleted.HeaderText = "Deleted"
        Me.WorkorderCommentDeleted.Name = "WorkorderCommentDeleted"
        Me.WorkorderCommentDeleted.Visible = False
        '
        'WorkorderCommentWorkorderID
        '
        Me.WorkorderCommentWorkorderID.DataPropertyName = "WorkorderID"
        Me.WorkorderCommentWorkorderID.HeaderText = "WorkorderID"
        Me.WorkorderCommentWorkorderID.Name = "WorkorderCommentWorkorderID"
        Me.WorkorderCommentWorkorderID.Visible = False
        '
        'Comment
        '
        Me.Comment.DataPropertyName = "Comment"
        Me.Comment.HeaderText = "Comment"
        Me.Comment.Name = "Comment"
        Me.Comment.Width = 800
        '
        'dgvWorkorderLabor
        '
        Me.dgvWorkorderLabor.AllowUserToDeleteRows = False
        Me.dgvWorkorderLabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkorderLabor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorkorderLaborID, Me.WorkorderLaborVersion, Me.WorkorderLaborLastUpdated, Me.WorkorderLaborDeleted, Me.WorkorderLaborWorkorderID, Me.TechID, Me.LaborDate, Me.LaborHours})
        Me.dgvWorkorderLabor.Location = New System.Drawing.Point(82, 334)
        Me.dgvWorkorderLabor.Name = "dgvWorkorderLabor"
        Me.dgvWorkorderLabor.Size = New System.Drawing.Size(385, 110)
        Me.dgvWorkorderLabor.TabIndex = 56
        '
        'WorkorderLaborID
        '
        Me.WorkorderLaborID.DataPropertyName = "ID"
        Me.WorkorderLaborID.HeaderText = "ID"
        Me.WorkorderLaborID.Name = "WorkorderLaborID"
        Me.WorkorderLaborID.Visible = False
        '
        'WorkorderLaborVersion
        '
        Me.WorkorderLaborVersion.DataPropertyName = "Version"
        Me.WorkorderLaborVersion.HeaderText = "Version"
        Me.WorkorderLaborVersion.Name = "WorkorderLaborVersion"
        Me.WorkorderLaborVersion.Visible = False
        '
        'WorkorderLaborLastUpdated
        '
        Me.WorkorderLaborLastUpdated.DataPropertyName = "LastUpdated"
        Me.WorkorderLaborLastUpdated.HeaderText = "Last Updated"
        Me.WorkorderLaborLastUpdated.Name = "WorkorderLaborLastUpdated"
        Me.WorkorderLaborLastUpdated.Visible = False
        '
        'WorkorderLaborDeleted
        '
        Me.WorkorderLaborDeleted.DataPropertyName = "Deleted"
        Me.WorkorderLaborDeleted.HeaderText = "Deleted"
        Me.WorkorderLaborDeleted.Name = "WorkorderLaborDeleted"
        Me.WorkorderLaborDeleted.Visible = False
        '
        'WorkorderLaborWorkorderID
        '
        Me.WorkorderLaborWorkorderID.DataPropertyName = "WorkorderID"
        Me.WorkorderLaborWorkorderID.HeaderText = "Workorder ID"
        Me.WorkorderLaborWorkorderID.Name = "WorkorderLaborWorkorderID"
        Me.WorkorderLaborWorkorderID.Visible = False
        '
        'TechID
        '
        Me.TechID.DataPropertyName = "TechID"
        Me.TechID.HeaderText = "Tech ID"
        Me.TechID.Name = "TechID"
        '
        'LaborDate
        '
        Me.LaborDate.DataPropertyName = "Date"
        Me.LaborDate.HeaderText = "Date"
        Me.LaborDate.Name = "LaborDate"
        '
        'LaborHours
        '
        Me.LaborHours.DataPropertyName = "LaborHours"
        Me.LaborHours.HeaderText = "Labor Hours"
        Me.LaborHours.Name = "LaborHours"
        '
        'dgvWorkorderPart
        '
        Me.dgvWorkorderPart.AllowUserToDeleteRows = False
        Me.dgvWorkorderPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkorderPart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorkorderPartID, Me.WorkorderPartVersion, Me.WorkorderPartLastUpdated, Me.WorkorderPartDeleted, Me.WorkorderID, Me.PartID, Me.Quantity, Me.CostPrice})
        Me.dgvWorkorderPart.Location = New System.Drawing.Point(82, 197)
        Me.dgvWorkorderPart.Name = "dgvWorkorderPart"
        Me.dgvWorkorderPart.Size = New System.Drawing.Size(385, 110)
        Me.dgvWorkorderPart.TabIndex = 55
        '
        'WorkorderPartID
        '
        Me.WorkorderPartID.DataPropertyName = "ID"
        Me.WorkorderPartID.HeaderText = "ID"
        Me.WorkorderPartID.Name = "WorkorderPartID"
        Me.WorkorderPartID.Visible = False
        '
        'WorkorderPartVersion
        '
        Me.WorkorderPartVersion.DataPropertyName = "Version"
        Me.WorkorderPartVersion.HeaderText = "Version"
        Me.WorkorderPartVersion.Name = "WorkorderPartVersion"
        Me.WorkorderPartVersion.Visible = False
        '
        'WorkorderPartLastUpdated
        '
        Me.WorkorderPartLastUpdated.DataPropertyName = "LastUpdated"
        Me.WorkorderPartLastUpdated.HeaderText = "LastUpdated"
        Me.WorkorderPartLastUpdated.Name = "WorkorderPartLastUpdated"
        Me.WorkorderPartLastUpdated.Visible = False
        '
        'WorkorderPartDeleted
        '
        Me.WorkorderPartDeleted.DataPropertyName = "Deleted"
        Me.WorkorderPartDeleted.HeaderText = "Deleted"
        Me.WorkorderPartDeleted.Name = "WorkorderPartDeleted"
        Me.WorkorderPartDeleted.Visible = False
        '
        'WorkorderID
        '
        Me.WorkorderID.DataPropertyName = "WorkorderID"
        Me.WorkorderID.HeaderText = "WorkorderID"
        Me.WorkorderID.Name = "WorkorderID"
        Me.WorkorderID.Visible = False
        '
        'PartID
        '
        Me.PartID.DataPropertyName = "PartID"
        Me.PartID.HeaderText = "PartID"
        Me.PartID.Name = "PartID"
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'CostPrice
        '
        Me.CostPrice.DataPropertyName = "CostPrice"
        Me.CostPrice.HeaderText = "CostPrice"
        Me.CostPrice.Name = "CostPrice"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(485, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Labor Rate :"
        '
        'txtLaborRate
        '
        Me.txtLaborRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLaborRate.Location = New System.Drawing.Point(572, 383)
        Me.txtLaborRate.Name = "txtLaborRate"
        Me.txtLaborRate.Size = New System.Drawing.Size(155, 26)
        Me.txtLaborRate.TabIndex = 59
        '
        'cboMake
        '
        Me.cboMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Location = New System.Drawing.Point(92, 127)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(145, 24)
        Me.cboMake.TabIndex = 60
        '
        'cboModel
        '
        Me.cboModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModel.FormattingEnabled = True
        Me.cboModel.Location = New System.Drawing.Point(314, 127)
        Me.cboModel.Name = "cboModel"
        Me.cboModel.Size = New System.Drawing.Size(145, 24)
        Me.cboModel.TabIndex = 61
        '
        'cboSerial
        '
        Me.cboSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSerial.FormattingEnabled = True
        Me.cboSerial.Location = New System.Drawing.Point(594, 127)
        Me.cboSerial.Name = "cboSerial"
        Me.cboSerial.Size = New System.Drawing.Size(145, 24)
        Me.cboSerial.TabIndex = 62
        '
        'frmWorkorderEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(775, 690)
        Me.Controls.Add(Me.cboSerial)
        Me.Controls.Add(Me.cboModel)
        Me.Controls.Add(Me.cboMake)
        Me.Controls.Add(Me.txtLaborRate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvWorkorderComment)
        Me.Controls.Add(Me.dgvWorkorderLabor)
        Me.Controls.Add(Me.dgvWorkorderPart)
        Me.Controls.Add(Me.cboWorkorder)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblDateOpened)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDateClosed)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWorkorderEdit"
        Me.Text = "Edit Workorder"
        CType(Me.dgvWorkorderComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWorkorderLabor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWorkorderPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDateClosed As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDateOpened As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboWorkorder As System.Windows.Forms.ComboBox
    Friend WithEvents dgvWorkorderComment As System.Windows.Forms.DataGridView
    Friend WithEvents WorkorderCommentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderCommentVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderCommentLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderCommentDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WorkorderCommentWorkorderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvWorkorderLabor As System.Windows.Forms.DataGridView
    Friend WithEvents WorkorderLaborID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderLaborVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderLaborLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderLaborDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WorkorderLaborWorkorderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaborDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaborHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvWorkorderPart As System.Windows.Forms.DataGridView
    Friend WithEvents WorkorderPartID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderPartVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderPartLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderPartDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WorkorderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLaborRate As System.Windows.Forms.TextBox
    Friend WithEvents cboMake As System.Windows.Forms.ComboBox
    Friend WithEvents cboModel As System.Windows.Forms.ComboBox
    Friend WithEvents cboSerial As System.Windows.Forms.ComboBox
End Class
