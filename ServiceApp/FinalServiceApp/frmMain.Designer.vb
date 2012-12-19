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
        Me.SuspendLayout()
        '
        'btnTech
        '
        Me.btnTech.Location = New System.Drawing.Point(93, 214)
        Me.btnTech.Name = "btnTech"
        Me.btnTech.Size = New System.Drawing.Size(114, 42)
        Me.btnTech.TabIndex = 5
        Me.btnTech.Text = "Service Technicians"
        Me.btnTech.UseVisualStyleBackColor = True
        '
        'btnWorkorder
        '
        Me.btnWorkorder.Location = New System.Drawing.Point(93, 153)
        Me.btnWorkorder.Name = "btnWorkorder"
        Me.btnWorkorder.Size = New System.Drawing.Size(114, 43)
        Me.btnWorkorder.TabIndex = 3
        Me.btnWorkorder.Text = "Service Workorders"
        Me.btnWorkorder.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(93, 90)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(114, 43)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "Customer Accounts"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnEquipment
        '
        Me.btnEquipment.Location = New System.Drawing.Point(268, 153)
        Me.btnEquipment.Name = "btnEquipment"
        Me.btnEquipment.Size = New System.Drawing.Size(114, 43)
        Me.btnEquipment.TabIndex = 4
        Me.btnEquipment.Text = "Equipment"
        Me.btnEquipment.UseVisualStyleBackColor = True
        '
        'btnManufacturer
        '
        Me.btnManufacturer.Location = New System.Drawing.Point(268, 90)
        Me.btnManufacturer.Name = "btnManufacturer"
        Me.btnManufacturer.Size = New System.Drawing.Size(114, 43)
        Me.btnManufacturer.TabIndex = 2
        Me.btnManufacturer.Text = "Manufacturers"
        Me.btnManufacturer.UseVisualStyleBackColor = True
        '
        'btnParts
        '
        Me.btnParts.Location = New System.Drawing.Point(268, 214)
        Me.btnParts.Name = "btnParts"
        Me.btnParts.Size = New System.Drawing.Size(114, 42)
        Me.btnParts.TabIndex = 6
        Me.btnParts.Text = "Parts"
        Me.btnParts.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(490, 337)
        Me.Controls.Add(Me.btnParts)
        Me.Controls.Add(Me.btnManufacturer)
        Me.Controls.Add(Me.btnEquipment)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnWorkorder)
        Me.Controls.Add(Me.btnTech)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "L & M Tractor Repair"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTech As System.Windows.Forms.Button
    Friend WithEvents btnWorkorder As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnEquipment As System.Windows.Forms.Button
    Friend WithEvents btnManufacturer As System.Windows.Forms.Button
    Friend WithEvents btnParts As System.Windows.Forms.Button
End Class
