<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnTech = New System.Windows.Forms.Button()
        Me.btnWorkorder = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnEquipment = New System.Windows.Forms.Button()
        Me.btnManufacturer = New System.Windows.Forms.Button()
        Me.btnParts = New System.Windows.Forms.Button()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelWorkorder = New System.Windows.Forms.Panel()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnEditWorkorder = New System.Windows.Forms.Button()
        Me.btnNewWorkorder = New System.Windows.Forms.Button()
        Me.panelWorkorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTech
        '
        Me.btnTech.Location = New System.Drawing.Point(116, 285)
        Me.btnTech.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTech.Name = "btnTech"
        Me.btnTech.Size = New System.Drawing.Size(142, 56)
        Me.btnTech.TabIndex = 5
        Me.btnTech.Text = "Service Technicians"
        Me.btnTech.UseVisualStyleBackColor = True
        '
        'btnWorkorder
        '
        Me.btnWorkorder.Location = New System.Drawing.Point(116, 204)
        Me.btnWorkorder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWorkorder.Name = "btnWorkorder"
        Me.btnWorkorder.Size = New System.Drawing.Size(142, 57)
        Me.btnWorkorder.TabIndex = 3
        Me.btnWorkorder.Text = "Service Workorders"
        Me.btnWorkorder.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(116, 120)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(142, 57)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "Customer Accounts"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnEquipment
        '
        Me.btnEquipment.Location = New System.Drawing.Point(335, 204)
        Me.btnEquipment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEquipment.Name = "btnEquipment"
        Me.btnEquipment.Size = New System.Drawing.Size(142, 57)
        Me.btnEquipment.TabIndex = 4
        Me.btnEquipment.Text = "Equipment"
        Me.btnEquipment.UseVisualStyleBackColor = True
        '
        'btnManufacturer
        '
        Me.btnManufacturer.Location = New System.Drawing.Point(335, 120)
        Me.btnManufacturer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManufacturer.Name = "btnManufacturer"
        Me.btnManufacturer.Size = New System.Drawing.Size(142, 57)
        Me.btnManufacturer.TabIndex = 2
        Me.btnManufacturer.Text = "Manufacturers"
        Me.btnManufacturer.UseVisualStyleBackColor = True
        '
        'btnParts
        '
        Me.btnParts.Location = New System.Drawing.Point(335, 285)
        Me.btnParts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnParts.Name = "btnParts"
        Me.btnParts.Size = New System.Drawing.Size(142, 56)
        Me.btnParts.TabIndex = 6
        Me.btnParts.Text = "Parts"
        Me.btnParts.UseVisualStyleBackColor = True
        '
        'panelMain
        '
        Me.panelMain.Location = New System.Drawing.Point(59, 41)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(482, 343)
        Me.panelMain.TabIndex = 7
        '
        'panelWorkorder
        '
        Me.panelWorkorder.Controls.Add(Me.btnMain)
        Me.panelWorkorder.Controls.Add(Me.btnEditWorkorder)
        Me.panelWorkorder.Controls.Add(Me.btnNewWorkorder)
        Me.panelWorkorder.Location = New System.Drawing.Point(55, 41)
        Me.panelWorkorder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelWorkorder.Name = "panelWorkorder"
        Me.panelWorkorder.Size = New System.Drawing.Size(482, 343)
        Me.panelWorkorder.TabIndex = 8
        Me.panelWorkorder.Visible = False
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(4, 0)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(111, 33)
        Me.btnMain.TabIndex = 2
        Me.btnMain.Text = "Main Menu"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnEditWorkorder
        '
        Me.btnEditWorkorder.Location = New System.Drawing.Point(261, 132)
        Me.btnEditWorkorder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditWorkorder.Name = "btnEditWorkorder"
        Me.btnEditWorkorder.Size = New System.Drawing.Size(122, 57)
        Me.btnEditWorkorder.TabIndex = 1
        Me.btnEditWorkorder.Text = "Edit Workorder"
        Me.btnEditWorkorder.UseVisualStyleBackColor = True
        '
        'btnNewWorkorder
        '
        Me.btnNewWorkorder.Location = New System.Drawing.Point(98, 132)
        Me.btnNewWorkorder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewWorkorder.Name = "btnNewWorkorder"
        Me.btnNewWorkorder.Size = New System.Drawing.Size(122, 57)
        Me.btnNewWorkorder.TabIndex = 0
        Me.btnNewWorkorder.Text = "New Workorder"
        Me.btnNewWorkorder.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(612, 449)
        Me.Controls.Add(Me.panelWorkorder)
        Me.Controls.Add(Me.btnParts)
        Me.Controls.Add(Me.btnManufacturer)
        Me.Controls.Add(Me.btnEquipment)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnWorkorder)
        Me.Controls.Add(Me.btnTech)
        Me.Controls.Add(Me.panelMain)
        Me.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmMain"
        Me.Text = "L & M Tractor Repair"
        Me.panelWorkorder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTech As System.Windows.Forms.Button
    Friend WithEvents btnWorkorder As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnEquipment As System.Windows.Forms.Button
    Friend WithEvents btnManufacturer As System.Windows.Forms.Button
    Friend WithEvents btnParts As System.Windows.Forms.Button
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents panelWorkorder As System.Windows.Forms.Panel
    Friend WithEvents btnEditWorkorder As System.Windows.Forms.Button
    Friend WithEvents btnNewWorkorder As System.Windows.Forms.Button
    Friend WithEvents btnMain As System.Windows.Forms.Button
End Class
