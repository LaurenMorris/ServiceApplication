﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvCustomerEmail = New System.Windows.Forms.DataGridView()
        Me.CustomerEmailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmailType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCustomerPhone = New System.Windows.Forms.DataGridView()
        Me.CustomerPhoneID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PhoneType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCustomerAddress = New System.Windows.Forms.DataGridView()
        Me.CustomerAddressID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddressType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSearchEmail = New System.Windows.Forms.Button()
        Me.btnSearchPhone = New System.Windows.Forms.Button()
        Me.btnSearchAddress = New System.Windows.Forms.Button()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.cboEmailOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboEmailSearch = New System.Windows.Forms.ComboBox()
        Me.cboPhoneOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboPhoneSearch = New System.Windows.Forms.ComboBox()
        Me.cboZipOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboZipSearch = New System.Windows.Forms.ComboBox()
        Me.cboStateOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboStateBool = New System.Windows.Forms.ComboBox()
        Me.cboStateSearch = New System.Windows.Forms.ComboBox()
        Me.cboCityOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboCityBool = New System.Windows.Forms.ComboBox()
        Me.cboCitySearch = New System.Windows.Forms.ComboBox()
        Me.cboAddressOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboAddressBool = New System.Windows.Forms.ComboBox()
        Me.cboAddressSearch = New System.Windows.Forms.ComboBox()
        Me.cboNameOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboNameSearch = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
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
        Me.dgvWorkorder = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakeModelID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOpened = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateClosed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaborRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvCustomerEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvWorkorderComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWorkorderLabor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWorkorderPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWorkorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(945, 24)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(921, 558)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.dgvCustomerEmail)
        Me.TabPage1.Controls.Add(Me.dgvCustomerPhone)
        Me.TabPage1.Controls.Add(Me.dgvCustomerAddress)
        Me.TabPage1.Controls.Add(Me.dgvCustomer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(913, 532)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Info"
        '
        'dgvCustomerEmail
        '
        Me.dgvCustomerEmail.AllowUserToDeleteRows = False
        Me.dgvCustomerEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerEmail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerEmailID, Me.CustomerEmailVersion, Me.CustomerEmailLastUpdated, Me.CustomerEmailDeleted, Me.EmailType, Me.Email})
        Me.dgvCustomerEmail.Location = New System.Drawing.Point(275, 395)
        Me.dgvCustomerEmail.Name = "dgvCustomerEmail"
        Me.dgvCustomerEmail.Size = New System.Drawing.Size(421, 115)
        Me.dgvCustomerEmail.TabIndex = 7
        '
        'CustomerEmailID
        '
        Me.CustomerEmailID.DataPropertyName = "ID"
        Me.CustomerEmailID.HeaderText = "ID"
        Me.CustomerEmailID.Name = "CustomerEmailID"
        Me.CustomerEmailID.Visible = False
        '
        'CustomerEmailVersion
        '
        Me.CustomerEmailVersion.DataPropertyName = "Version"
        Me.CustomerEmailVersion.HeaderText = "Version"
        Me.CustomerEmailVersion.Name = "CustomerEmailVersion"
        Me.CustomerEmailVersion.Visible = False
        '
        'CustomerEmailLastUpdated
        '
        Me.CustomerEmailLastUpdated.DataPropertyName = "LastUpdated"
        Me.CustomerEmailLastUpdated.HeaderText = "Last Updated"
        Me.CustomerEmailLastUpdated.Name = "CustomerEmailLastUpdated"
        Me.CustomerEmailLastUpdated.Visible = False
        '
        'CustomerEmailDeleted
        '
        Me.CustomerEmailDeleted.DataPropertyName = "Deleted"
        Me.CustomerEmailDeleted.HeaderText = "Deleted"
        Me.CustomerEmailDeleted.Name = "CustomerEmailDeleted"
        Me.CustomerEmailDeleted.Visible = False
        '
        'EmailType
        '
        Me.EmailType.DataPropertyName = "EmailTypeID"
        Me.EmailType.HeaderText = "Email Type"
        Me.EmailType.Name = "EmailType"
        Me.EmailType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmailType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'dgvCustomerPhone
        '
        Me.dgvCustomerPhone.AllowUserToDeleteRows = False
        Me.dgvCustomerPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerPhone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerPhoneID, Me.CustomerPhoneVersion, Me.CustomerPhoneLastUpdated, Me.CustomerPhoneDeleted, Me.PhoneType, Me.Phone})
        Me.dgvCustomerPhone.Location = New System.Drawing.Point(275, 274)
        Me.dgvCustomerPhone.Name = "dgvCustomerPhone"
        Me.dgvCustomerPhone.Size = New System.Drawing.Size(421, 115)
        Me.dgvCustomerPhone.TabIndex = 6
        '
        'CustomerPhoneID
        '
        Me.CustomerPhoneID.DataPropertyName = "ID"
        Me.CustomerPhoneID.HeaderText = "ID"
        Me.CustomerPhoneID.Name = "CustomerPhoneID"
        Me.CustomerPhoneID.Visible = False
        '
        'CustomerPhoneVersion
        '
        Me.CustomerPhoneVersion.DataPropertyName = "Version"
        Me.CustomerPhoneVersion.HeaderText = "Version"
        Me.CustomerPhoneVersion.Name = "CustomerPhoneVersion"
        Me.CustomerPhoneVersion.Visible = False
        '
        'CustomerPhoneLastUpdated
        '
        Me.CustomerPhoneLastUpdated.DataPropertyName = "LastUpdated"
        Me.CustomerPhoneLastUpdated.HeaderText = "Last Updated"
        Me.CustomerPhoneLastUpdated.Name = "CustomerPhoneLastUpdated"
        Me.CustomerPhoneLastUpdated.Visible = False
        '
        'CustomerPhoneDeleted
        '
        Me.CustomerPhoneDeleted.DataPropertyName = "Deleted"
        Me.CustomerPhoneDeleted.HeaderText = "Deleted"
        Me.CustomerPhoneDeleted.Name = "CustomerPhoneDeleted"
        Me.CustomerPhoneDeleted.Visible = False
        '
        'PhoneType
        '
        Me.PhoneType.DataPropertyName = "PhoneTypeID"
        Me.PhoneType.HeaderText = "Phone Type"
        Me.PhoneType.Name = "PhoneType"
        '
        'Phone
        '
        Me.Phone.DataPropertyName = "Phone"
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        '
        'dgvCustomerAddress
        '
        Me.dgvCustomerAddress.AllowUserToDeleteRows = False
        Me.dgvCustomerAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerAddress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerAddressID, Me.CustomerAddressVersion, Me.CustomerAddressLastUpdated, Me.CustomerAddressDeleted, Me.AddressType, Me.Address, Me.City, Me.State, Me.Zip})
        Me.dgvCustomerAddress.Location = New System.Drawing.Point(189, 153)
        Me.dgvCustomerAddress.Name = "dgvCustomerAddress"
        Me.dgvCustomerAddress.Size = New System.Drawing.Size(577, 115)
        Me.dgvCustomerAddress.TabIndex = 5
        '
        'CustomerAddressID
        '
        Me.CustomerAddressID.DataPropertyName = "ID"
        Me.CustomerAddressID.HeaderText = "ID"
        Me.CustomerAddressID.Name = "CustomerAddressID"
        Me.CustomerAddressID.Visible = False
        '
        'CustomerAddressVersion
        '
        Me.CustomerAddressVersion.DataPropertyName = "Version"
        Me.CustomerAddressVersion.HeaderText = "Version"
        Me.CustomerAddressVersion.Name = "CustomerAddressVersion"
        Me.CustomerAddressVersion.Visible = False
        '
        'CustomerAddressLastUpdated
        '
        Me.CustomerAddressLastUpdated.DataPropertyName = "LastUpdated"
        Me.CustomerAddressLastUpdated.HeaderText = "Last Updated"
        Me.CustomerAddressLastUpdated.Name = "CustomerAddressLastUpdated"
        Me.CustomerAddressLastUpdated.Visible = False
        '
        'CustomerAddressDeleted
        '
        Me.CustomerAddressDeleted.DataPropertyName = "Deleted"
        Me.CustomerAddressDeleted.HeaderText = "Deleted"
        Me.CustomerAddressDeleted.Name = "CustomerAddressDeleted"
        Me.CustomerAddressDeleted.Visible = False
        '
        'AddressType
        '
        Me.AddressType.DataPropertyName = "AddressTypeID"
        Me.AddressType.HeaderText = "Address Type"
        Me.AddressType.Name = "AddressType"
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'City
        '
        Me.City.DataPropertyName = "City"
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'State
        '
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'Zip
        '
        Me.Zip.DataPropertyName = "Zip"
        Me.Zip.HeaderText = "Zip"
        Me.Zip.Name = "Zip"
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Version, Me.LastUpdated, Me.Deleted, Me.CustomerName})
        Me.dgvCustomer.Location = New System.Drawing.Point(275, 32)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(421, 115)
        Me.dgvCustomer.TabIndex = 4
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Version
        '
        Me.Version.DataPropertyName = "Version"
        Me.Version.HeaderText = "Version"
        Me.Version.Name = "Version"
        Me.Version.Visible = False
        '
        'LastUpdated
        '
        Me.LastUpdated.DataPropertyName = "LastUpdated"
        Me.LastUpdated.HeaderText = "Last Updated"
        Me.LastUpdated.Name = "LastUpdated"
        Me.LastUpdated.Visible = False
        '
        'Deleted
        '
        Me.Deleted.DataPropertyName = "Deleted"
        Me.Deleted.HeaderText = "Deleted"
        Me.Deleted.Name = "Deleted"
        Me.Deleted.Visible = False
        '
        'CustomerName
        '
        Me.CustomerName.DataPropertyName = "Name"
        Me.CustomerName.HeaderText = "Name"
        Me.CustomerName.Name = "CustomerName"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.btnSearchEmail)
        Me.TabPage2.Controls.Add(Me.btnSearchPhone)
        Me.TabPage2.Controls.Add(Me.btnSearchAddress)
        Me.TabPage2.Controls.Add(Me.btnSearchCustomer)
        Me.TabPage2.Controls.Add(Me.cboEmailOrderBy)
        Me.TabPage2.Controls.Add(Me.cboEmailSearch)
        Me.TabPage2.Controls.Add(Me.cboPhoneOrderBy)
        Me.TabPage2.Controls.Add(Me.cboPhoneSearch)
        Me.TabPage2.Controls.Add(Me.cboZipOrderBy)
        Me.TabPage2.Controls.Add(Me.cboZipSearch)
        Me.TabPage2.Controls.Add(Me.cboStateOrderBy)
        Me.TabPage2.Controls.Add(Me.cboStateBool)
        Me.TabPage2.Controls.Add(Me.cboStateSearch)
        Me.TabPage2.Controls.Add(Me.cboCityOrderBy)
        Me.TabPage2.Controls.Add(Me.cboCityBool)
        Me.TabPage2.Controls.Add(Me.cboCitySearch)
        Me.TabPage2.Controls.Add(Me.cboAddressOrderBy)
        Me.TabPage2.Controls.Add(Me.cboAddressBool)
        Me.TabPage2.Controls.Add(Me.cboAddressSearch)
        Me.TabPage2.Controls.Add(Me.cboNameOrderBy)
        Me.TabPage2.Controls.Add(Me.cboNameSearch)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.txtPhone)
        Me.TabPage2.Controls.Add(Me.txtZip)
        Me.TabPage2.Controls.Add(Me.txtState)
        Me.TabPage2.Controls.Add(Me.txtCity)
        Me.TabPage2.Controls.Add(Me.txtAddress)
        Me.TabPage2.Controls.Add(Me.txtName)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(913, 532)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        '
        'btnSearchEmail
        '
        Me.btnSearchEmail.Location = New System.Drawing.Point(677, 395)
        Me.btnSearchEmail.Name = "btnSearchEmail"
        Me.btnSearchEmail.Size = New System.Drawing.Size(97, 26)
        Me.btnSearchEmail.TabIndex = 83
        Me.btnSearchEmail.Text = "Search Email"
        Me.btnSearchEmail.UseVisualStyleBackColor = True
        '
        'btnSearchPhone
        '
        Me.btnSearchPhone.Location = New System.Drawing.Point(677, 339)
        Me.btnSearchPhone.Name = "btnSearchPhone"
        Me.btnSearchPhone.Size = New System.Drawing.Size(97, 27)
        Me.btnSearchPhone.TabIndex = 82
        Me.btnSearchPhone.Text = "Search Phone"
        Me.btnSearchPhone.UseVisualStyleBackColor = True
        '
        'btnSearchAddress
        '
        Me.btnSearchAddress.Location = New System.Drawing.Point(677, 206)
        Me.btnSearchAddress.Name = "btnSearchAddress"
        Me.btnSearchAddress.Size = New System.Drawing.Size(97, 34)
        Me.btnSearchAddress.TabIndex = 81
        Me.btnSearchAddress.Text = "Search Address"
        Me.btnSearchAddress.UseVisualStyleBackColor = True
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(677, 66)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(97, 37)
        Me.btnSearchCustomer.TabIndex = 80
        Me.btnSearchCustomer.Text = "Search Customer"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'cboEmailOrderBy
        '
        Me.cboEmailOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailOrderBy.FormattingEnabled = True
        Me.cboEmailOrderBy.Location = New System.Drawing.Point(571, 398)
        Me.cboEmailOrderBy.Name = "cboEmailOrderBy"
        Me.cboEmailOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboEmailOrderBy.TabIndex = 79
        '
        'cboEmailSearch
        '
        Me.cboEmailSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailSearch.FormattingEnabled = True
        Me.cboEmailSearch.Location = New System.Drawing.Point(362, 399)
        Me.cboEmailSearch.Name = "cboEmailSearch"
        Me.cboEmailSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboEmailSearch.TabIndex = 78
        '
        'cboPhoneOrderBy
        '
        Me.cboPhoneOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhoneOrderBy.FormattingEnabled = True
        Me.cboPhoneOrderBy.Location = New System.Drawing.Point(571, 343)
        Me.cboPhoneOrderBy.Name = "cboPhoneOrderBy"
        Me.cboPhoneOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboPhoneOrderBy.TabIndex = 77
        '
        'cboPhoneSearch
        '
        Me.cboPhoneSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhoneSearch.FormattingEnabled = True
        Me.cboPhoneSearch.Location = New System.Drawing.Point(362, 343)
        Me.cboPhoneSearch.Name = "cboPhoneSearch"
        Me.cboPhoneSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboPhoneSearch.TabIndex = 76
        '
        'cboZipOrderBy
        '
        Me.cboZipOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZipOrderBy.FormattingEnabled = True
        Me.cboZipOrderBy.Location = New System.Drawing.Point(571, 271)
        Me.cboZipOrderBy.Name = "cboZipOrderBy"
        Me.cboZipOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboZipOrderBy.TabIndex = 75
        '
        'cboZipSearch
        '
        Me.cboZipSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZipSearch.FormattingEnabled = True
        Me.cboZipSearch.Location = New System.Drawing.Point(362, 270)
        Me.cboZipSearch.Name = "cboZipSearch"
        Me.cboZipSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboZipSearch.TabIndex = 74
        '
        'cboStateOrderBy
        '
        Me.cboStateOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateOrderBy.FormattingEnabled = True
        Me.cboStateOrderBy.Location = New System.Drawing.Point(571, 235)
        Me.cboStateOrderBy.Name = "cboStateOrderBy"
        Me.cboStateOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboStateOrderBy.TabIndex = 73
        '
        'cboStateBool
        '
        Me.cboStateBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateBool.FormattingEnabled = True
        Me.cboStateBool.Location = New System.Drawing.Point(489, 235)
        Me.cboStateBool.Name = "cboStateBool"
        Me.cboStateBool.Size = New System.Drawing.Size(76, 21)
        Me.cboStateBool.TabIndex = 72
        '
        'cboStateSearch
        '
        Me.cboStateSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateSearch.FormattingEnabled = True
        Me.cboStateSearch.Location = New System.Drawing.Point(362, 235)
        Me.cboStateSearch.Name = "cboStateSearch"
        Me.cboStateSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboStateSearch.TabIndex = 71
        '
        'cboCityOrderBy
        '
        Me.cboCityOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCityOrderBy.FormattingEnabled = True
        Me.cboCityOrderBy.Location = New System.Drawing.Point(571, 202)
        Me.cboCityOrderBy.Name = "cboCityOrderBy"
        Me.cboCityOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboCityOrderBy.TabIndex = 70
        '
        'cboCityBool
        '
        Me.cboCityBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCityBool.FormattingEnabled = True
        Me.cboCityBool.Location = New System.Drawing.Point(489, 203)
        Me.cboCityBool.Name = "cboCityBool"
        Me.cboCityBool.Size = New System.Drawing.Size(76, 21)
        Me.cboCityBool.TabIndex = 69
        '
        'cboCitySearch
        '
        Me.cboCitySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCitySearch.FormattingEnabled = True
        Me.cboCitySearch.Location = New System.Drawing.Point(362, 202)
        Me.cboCitySearch.Name = "cboCitySearch"
        Me.cboCitySearch.Size = New System.Drawing.Size(121, 21)
        Me.cboCitySearch.TabIndex = 68
        '
        'cboAddressOrderBy
        '
        Me.cboAddressOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressOrderBy.FormattingEnabled = True
        Me.cboAddressOrderBy.Location = New System.Drawing.Point(571, 170)
        Me.cboAddressOrderBy.Name = "cboAddressOrderBy"
        Me.cboAddressOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboAddressOrderBy.TabIndex = 67
        '
        'cboAddressBool
        '
        Me.cboAddressBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressBool.FormattingEnabled = True
        Me.cboAddressBool.Location = New System.Drawing.Point(489, 170)
        Me.cboAddressBool.Name = "cboAddressBool"
        Me.cboAddressBool.Size = New System.Drawing.Size(76, 21)
        Me.cboAddressBool.TabIndex = 66
        '
        'cboAddressSearch
        '
        Me.cboAddressSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressSearch.FormattingEnabled = True
        Me.cboAddressSearch.Location = New System.Drawing.Point(362, 170)
        Me.cboAddressSearch.Name = "cboAddressSearch"
        Me.cboAddressSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboAddressSearch.TabIndex = 65
        '
        'cboNameOrderBy
        '
        Me.cboNameOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNameOrderBy.FormattingEnabled = True
        Me.cboNameOrderBy.Location = New System.Drawing.Point(571, 75)
        Me.cboNameOrderBy.Name = "cboNameOrderBy"
        Me.cboNameOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboNameOrderBy.TabIndex = 62
        '
        'cboNameSearch
        '
        Me.cboNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNameSearch.FormattingEnabled = True
        Me.cboNameSearch.Location = New System.Drawing.Point(362, 75)
        Me.cboNameSearch.Name = "cboNameSearch"
        Me.cboNameSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboNameSearch.TabIndex = 60
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(214, 399)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 59
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(214, 343)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(142, 20)
        Me.txtPhone.TabIndex = 58
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(215, 271)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(142, 20)
        Me.txtZip.TabIndex = 57
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(214, 236)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(142, 20)
        Me.txtState.TabIndex = 56
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(214, 203)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(142, 20)
        Me.txtCity.TabIndex = 55
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(214, 171)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtAddress.TabIndex = 54
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(215, 75)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 20)
        Me.txtName.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(170, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Email :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Phone :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Zip :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "State :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "City :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Address :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Customer Name :"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.Controls.Add(Me.dgvWorkorderComment)
        Me.TabPage3.Controls.Add(Me.dgvWorkorderLabor)
        Me.TabPage3.Controls.Add(Me.dgvWorkorderPart)
        Me.TabPage3.Controls.Add(Me.dgvWorkorder)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(913, 532)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Workorder Info"
        '
        'dgvWorkorderComment
        '
        Me.dgvWorkorderComment.AllowUserToDeleteRows = False
        Me.dgvWorkorderComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkorderComment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorkorderCommentID, Me.WorkorderCommentVersion, Me.WorkorderCommentLastUpdated, Me.WorkorderCommentDeleted, Me.WorkorderCommentWorkorderID, Me.Comment})
        Me.dgvWorkorderComment.Location = New System.Drawing.Point(121, 398)
        Me.dgvWorkorderComment.Name = "dgvWorkorderComment"
        Me.dgvWorkorderComment.Size = New System.Drawing.Size(677, 110)
        Me.dgvWorkorderComment.TabIndex = 11
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
        Me.dgvWorkorderLabor.Location = New System.Drawing.Point(266, 282)
        Me.dgvWorkorderLabor.Name = "dgvWorkorderLabor"
        Me.dgvWorkorderLabor.Size = New System.Drawing.Size(385, 110)
        Me.dgvWorkorderLabor.TabIndex = 10
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
        Me.dgvWorkorderPart.Location = New System.Drawing.Point(266, 166)
        Me.dgvWorkorderPart.Name = "dgvWorkorderPart"
        Me.dgvWorkorderPart.Size = New System.Drawing.Size(385, 110)
        Me.dgvWorkorderPart.TabIndex = 9
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
        'dgvWorkorder
        '
        Me.dgvWorkorder.AllowUserToDeleteRows = False
        Me.dgvWorkorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkorder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.CustomerID, Me.MakeModelID, Me.Serial, Me.DateOpened, Me.DateClosed, Me.LaborRate, Me.Cost, Me.TaxID, Me.TotalCost})
        Me.dgvWorkorder.Location = New System.Drawing.Point(34, 25)
        Me.dgvWorkorder.Name = "dgvWorkorder"
        Me.dgvWorkorder.Size = New System.Drawing.Size(862, 135)
        Me.dgvWorkorder.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Version"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Version"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastUpdated"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Updated"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Deleted"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Deleted"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'CustomerID
        '
        Me.CustomerID.DataPropertyName = "CustomerID"
        Me.CustomerID.HeaderText = "Customer ID"
        Me.CustomerID.Name = "CustomerID"
        '
        'MakeModelID
        '
        Me.MakeModelID.DataPropertyName = "MakeModelID"
        Me.MakeModelID.HeaderText = "Make Model ID"
        Me.MakeModelID.Name = "MakeModelID"
        '
        'Serial
        '
        Me.Serial.DataPropertyName = "Serial"
        Me.Serial.HeaderText = "Serial"
        Me.Serial.Name = "Serial"
        '
        'DateOpened
        '
        Me.DateOpened.DataPropertyName = "DateOpened"
        Me.DateOpened.HeaderText = "Date Opened"
        Me.DateOpened.Name = "DateOpened"
        Me.DateOpened.Width = 75
        '
        'DateClosed
        '
        Me.DateClosed.DataPropertyName = "DateClosed"
        Me.DateClosed.HeaderText = "Date Closed"
        Me.DateClosed.Name = "DateClosed"
        Me.DateClosed.Width = 75
        '
        'LaborRate
        '
        Me.LaborRate.DataPropertyName = "LaborRate"
        Me.LaborRate.HeaderText = "Labor Rate"
        Me.LaborRate.Name = "LaborRate"
        Me.LaborRate.Width = 75
        '
        'Cost
        '
        Me.Cost.DataPropertyName = "Cost"
        Me.Cost.HeaderText = "Cost"
        Me.Cost.Name = "Cost"
        '
        'TaxID
        '
        Me.TaxID.DataPropertyName = "TaxID"
        Me.TaxID.HeaderText = "Tax ID"
        Me.TaxID.Name = "TaxID"
        '
        'TotalCost
        '
        Me.TotalCost.DataPropertyName = "TotalCost"
        Me.TotalCost.HeaderText = "Total Cost"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Width = 75
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 610)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvCustomerEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvWorkorderComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWorkorderLabor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWorkorderPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWorkorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvCustomerEmail As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerEmailID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EmailType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCustomerPhone As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerPhoneID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PhoneType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCustomerAddress As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerAddressID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AddressType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Zip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Version As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearchEmail As System.Windows.Forms.Button
    Friend WithEvents btnSearchPhone As System.Windows.Forms.Button
    Friend WithEvents btnSearchAddress As System.Windows.Forms.Button
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents cboEmailOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmailSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cboPhoneOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboPhoneSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cboZipOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboZipSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cboStateOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboStateBool As System.Windows.Forms.ComboBox
    Friend WithEvents cboStateSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cboCityOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboCityBool As System.Windows.Forms.ComboBox
    Friend WithEvents cboCitySearch As System.Windows.Forms.ComboBox
    Friend WithEvents cboAddressOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboAddressBool As System.Windows.Forms.ComboBox
    Friend WithEvents cboAddressSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cboNameOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboNameSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvWorkorderComment As System.Windows.Forms.DataGridView
    Friend WithEvents dgvWorkorderLabor As System.Windows.Forms.DataGridView
    Friend WithEvents dgvWorkorderPart As System.Windows.Forms.DataGridView
    Friend WithEvents dgvWorkorder As System.Windows.Forms.DataGridView
    Friend WithEvents WorkorderCommentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderCommentVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderCommentLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderCommentDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WorkorderCommentWorkorderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderLaborID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderLaborVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderLaborLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderLaborDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WorkorderLaborWorkorderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaborDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaborHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderPartID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderPartVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderPartLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkorderPartDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WorkorderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MakeModelID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOpened As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateClosed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaborRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
