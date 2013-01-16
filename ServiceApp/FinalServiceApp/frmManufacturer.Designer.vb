<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManufacturer
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvManufacturerEmail = New System.Windows.Forms.DataGridView()
        Me.ManufacturerEmailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerEmailVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerEmailLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerEmailDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmailType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvManufacturerPhone = New System.Windows.Forms.DataGridView()
        Me.ManufacturerPhoneID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerPhoneVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerPhoneLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerPhoneDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PhoneType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvManufacturerAddress = New System.Windows.Forms.DataGridView()
        Me.ManufacturerAddressID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerAddressVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerAddressLastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerAddressDeleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddressType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvManufacturer = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ManufacturerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSearchEmail = New System.Windows.Forms.Button()
        Me.btnSearchPhone = New System.Windows.Forms.Button()
        Me.btnSearchAddress = New System.Windows.Forms.Button()
        Me.btnSearchManufacturer = New System.Windows.Forms.Button()
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
        Me.cboContactOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboContactSearch = New System.Windows.Forms.ComboBox()
        Me.cboNameOrderBy = New System.Windows.Forms.ComboBox()
        Me.cboNameBool = New System.Windows.Forms.ComboBox()
        Me.cboNameSearch = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblManufacturerID = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboAddressType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboEmailType = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboPhoneType = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtNameAdd = New System.Windows.Forms.TextBox()
        Me.txtContactAdd = New System.Windows.Forms.TextBox()
        Me.txtAddressAdd = New System.Windows.Forms.TextBox()
        Me.txtCityAdd = New System.Windows.Forms.TextBox()
        Me.txtStateAdd = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtZipAdd = New System.Windows.Forms.TextBox()
        Me.txtEmailAdd = New System.Windows.Forms.TextBox()
        Me.txtPhoneAdd = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvManufacturerEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvManufacturerPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvManufacturerAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvManufacturer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(52, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 537)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.dgvManufacturerEmail)
        Me.TabPage1.Controls.Add(Me.dgvManufacturerPhone)
        Me.TabPage1.Controls.Add(Me.dgvManufacturerAddress)
        Me.TabPage1.Controls.Add(Me.dgvManufacturer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(753, 511)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Current / Edit"
        '
        'dgvManufacturerEmail
        '
        Me.dgvManufacturerEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManufacturerEmail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ManufacturerEmailID, Me.ManufacturerEmailVersion, Me.ManufacturerEmailLastUpdated, Me.ManufacturerEmailDeleted, Me.EmailType, Me.Email})
        Me.dgvManufacturerEmail.Location = New System.Drawing.Point(166, 388)
        Me.dgvManufacturerEmail.Name = "dgvManufacturerEmail"
        Me.dgvManufacturerEmail.Size = New System.Drawing.Size(421, 115)
        Me.dgvManufacturerEmail.TabIndex = 3
        '
        'ManufacturerEmailID
        '
        Me.ManufacturerEmailID.DataPropertyName = "ID"
        Me.ManufacturerEmailID.HeaderText = "ID"
        Me.ManufacturerEmailID.Name = "ManufacturerEmailID"
        Me.ManufacturerEmailID.Visible = False
        '
        'ManufacturerEmailVersion
        '
        Me.ManufacturerEmailVersion.DataPropertyName = "Version"
        Me.ManufacturerEmailVersion.HeaderText = "Version"
        Me.ManufacturerEmailVersion.Name = "ManufacturerEmailVersion"
        Me.ManufacturerEmailVersion.Visible = False
        '
        'ManufacturerEmailLastUpdated
        '
        Me.ManufacturerEmailLastUpdated.DataPropertyName = "LastUpdated"
        Me.ManufacturerEmailLastUpdated.HeaderText = "Last Updated"
        Me.ManufacturerEmailLastUpdated.Name = "ManufacturerEmailLastUpdated"
        Me.ManufacturerEmailLastUpdated.Visible = False
        '
        'ManufacturerEmailDeleted
        '
        Me.ManufacturerEmailDeleted.DataPropertyName = "Deleted"
        Me.ManufacturerEmailDeleted.HeaderText = "Deleted"
        Me.ManufacturerEmailDeleted.Name = "ManufacturerEmailDeleted"
        Me.ManufacturerEmailDeleted.Visible = False
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
        'dgvManufacturerPhone
        '
        Me.dgvManufacturerPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManufacturerPhone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ManufacturerPhoneID, Me.ManufacturerPhoneVersion, Me.ManufacturerPhoneLastUpdated, Me.ManufacturerPhoneDeleted, Me.PhoneType, Me.Phone})
        Me.dgvManufacturerPhone.Location = New System.Drawing.Point(166, 267)
        Me.dgvManufacturerPhone.Name = "dgvManufacturerPhone"
        Me.dgvManufacturerPhone.Size = New System.Drawing.Size(421, 115)
        Me.dgvManufacturerPhone.TabIndex = 2
        '
        'ManufacturerPhoneID
        '
        Me.ManufacturerPhoneID.DataPropertyName = "ID"
        Me.ManufacturerPhoneID.HeaderText = "ID"
        Me.ManufacturerPhoneID.Name = "ManufacturerPhoneID"
        Me.ManufacturerPhoneID.Visible = False
        '
        'ManufacturerPhoneVersion
        '
        Me.ManufacturerPhoneVersion.DataPropertyName = "Version"
        Me.ManufacturerPhoneVersion.HeaderText = "Version"
        Me.ManufacturerPhoneVersion.Name = "ManufacturerPhoneVersion"
        Me.ManufacturerPhoneVersion.Visible = False
        '
        'ManufacturerPhoneLastUpdated
        '
        Me.ManufacturerPhoneLastUpdated.DataPropertyName = "LastUpdated"
        Me.ManufacturerPhoneLastUpdated.HeaderText = "Last Updated"
        Me.ManufacturerPhoneLastUpdated.Name = "ManufacturerPhoneLastUpdated"
        Me.ManufacturerPhoneLastUpdated.Visible = False
        '
        'ManufacturerPhoneDeleted
        '
        Me.ManufacturerPhoneDeleted.DataPropertyName = "Deleted"
        Me.ManufacturerPhoneDeleted.HeaderText = "Deleted"
        Me.ManufacturerPhoneDeleted.Name = "ManufacturerPhoneDeleted"
        Me.ManufacturerPhoneDeleted.Visible = False
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
        'dgvManufacturerAddress
        '
        Me.dgvManufacturerAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManufacturerAddress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ManufacturerAddressID, Me.ManufacturerAddressVersion, Me.ManufacturerAddressLastUpdated, Me.ManufacturerAddressDeleted, Me.AddressType, Me.Address, Me.City, Me.State, Me.Zip})
        Me.dgvManufacturerAddress.Location = New System.Drawing.Point(93, 146)
        Me.dgvManufacturerAddress.Name = "dgvManufacturerAddress"
        Me.dgvManufacturerAddress.Size = New System.Drawing.Size(577, 115)
        Me.dgvManufacturerAddress.TabIndex = 1
        '
        'ManufacturerAddressID
        '
        Me.ManufacturerAddressID.DataPropertyName = "ID"
        Me.ManufacturerAddressID.HeaderText = "ID"
        Me.ManufacturerAddressID.Name = "ManufacturerAddressID"
        Me.ManufacturerAddressID.Visible = False
        '
        'ManufacturerAddressVersion
        '
        Me.ManufacturerAddressVersion.DataPropertyName = "Version"
        Me.ManufacturerAddressVersion.HeaderText = "Version"
        Me.ManufacturerAddressVersion.Name = "ManufacturerAddressVersion"
        Me.ManufacturerAddressVersion.Visible = False
        '
        'ManufacturerAddressLastUpdated
        '
        Me.ManufacturerAddressLastUpdated.DataPropertyName = "LastUpdated"
        Me.ManufacturerAddressLastUpdated.HeaderText = "Last Updated"
        Me.ManufacturerAddressLastUpdated.Name = "ManufacturerAddressLastUpdated"
        Me.ManufacturerAddressLastUpdated.Visible = False
        '
        'ManufacturerAddressDeleted
        '
        Me.ManufacturerAddressDeleted.DataPropertyName = "Deleted"
        Me.ManufacturerAddressDeleted.HeaderText = "Deleted"
        Me.ManufacturerAddressDeleted.Name = "ManufacturerAddressDeleted"
        Me.ManufacturerAddressDeleted.Visible = False
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
        'dgvManufacturer
        '
        Me.dgvManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManufacturer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Version, Me.LastUpdated, Me.Deleted, Me.ManufacturerName, Me.Contact})
        Me.dgvManufacturer.Location = New System.Drawing.Point(166, 25)
        Me.dgvManufacturer.Name = "dgvManufacturer"
        Me.dgvManufacturer.Size = New System.Drawing.Size(421, 115)
        Me.dgvManufacturer.TabIndex = 0
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
        'ManufacturerName
        '
        Me.ManufacturerName.DataPropertyName = "Name"
        Me.ManufacturerName.HeaderText = "Name"
        Me.ManufacturerName.Name = "ManufacturerName"
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "Contact"
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.btnSearchEmail)
        Me.TabPage2.Controls.Add(Me.btnSearchPhone)
        Me.TabPage2.Controls.Add(Me.btnSearchAddress)
        Me.TabPage2.Controls.Add(Me.btnSearchManufacturer)
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
        Me.TabPage2.Controls.Add(Me.cboContactOrderBy)
        Me.TabPage2.Controls.Add(Me.cboContactSearch)
        Me.TabPage2.Controls.Add(Me.cboNameOrderBy)
        Me.TabPage2.Controls.Add(Me.cboNameBool)
        Me.TabPage2.Controls.Add(Me.cboNameSearch)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.txtPhone)
        Me.TabPage2.Controls.Add(Me.txtZip)
        Me.TabPage2.Controls.Add(Me.txtState)
        Me.TabPage2.Controls.Add(Me.txtCity)
        Me.TabPage2.Controls.Add(Me.txtAddress)
        Me.TabPage2.Controls.Add(Me.txtContact)
        Me.TabPage2.Controls.Add(Me.txtName)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(753, 511)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        '
        'btnSearchEmail
        '
        Me.btnSearchEmail.Location = New System.Drawing.Point(605, 373)
        Me.btnSearchEmail.Name = "btnSearchEmail"
        Me.btnSearchEmail.Size = New System.Drawing.Size(97, 26)
        Me.btnSearchEmail.TabIndex = 43
        Me.btnSearchEmail.Text = "Search Email"
        Me.btnSearchEmail.UseVisualStyleBackColor = True
        '
        'btnSearchPhone
        '
        Me.btnSearchPhone.Location = New System.Drawing.Point(605, 317)
        Me.btnSearchPhone.Name = "btnSearchPhone"
        Me.btnSearchPhone.Size = New System.Drawing.Size(97, 27)
        Me.btnSearchPhone.TabIndex = 42
        Me.btnSearchPhone.Text = "Search Phone"
        Me.btnSearchPhone.UseVisualStyleBackColor = True
        '
        'btnSearchAddress
        '
        Me.btnSearchAddress.Location = New System.Drawing.Point(605, 184)
        Me.btnSearchAddress.Name = "btnSearchAddress"
        Me.btnSearchAddress.Size = New System.Drawing.Size(97, 34)
        Me.btnSearchAddress.TabIndex = 41
        Me.btnSearchAddress.Text = "Search Address"
        Me.btnSearchAddress.UseVisualStyleBackColor = True
        '
        'btnSearchManufacturer
        '
        Me.btnSearchManufacturer.Location = New System.Drawing.Point(605, 63)
        Me.btnSearchManufacturer.Name = "btnSearchManufacturer"
        Me.btnSearchManufacturer.Size = New System.Drawing.Size(97, 37)
        Me.btnSearchManufacturer.TabIndex = 40
        Me.btnSearchManufacturer.Text = "Search Manufacturer"
        Me.btnSearchManufacturer.UseVisualStyleBackColor = True
        '
        'cboEmailOrderBy
        '
        Me.cboEmailOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailOrderBy.FormattingEnabled = True
        Me.cboEmailOrderBy.Location = New System.Drawing.Point(499, 376)
        Me.cboEmailOrderBy.Name = "cboEmailOrderBy"
        Me.cboEmailOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboEmailOrderBy.TabIndex = 39
        '
        'cboEmailSearch
        '
        Me.cboEmailSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailSearch.FormattingEnabled = True
        Me.cboEmailSearch.Location = New System.Drawing.Point(290, 377)
        Me.cboEmailSearch.Name = "cboEmailSearch"
        Me.cboEmailSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboEmailSearch.TabIndex = 37
        '
        'cboPhoneOrderBy
        '
        Me.cboPhoneOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhoneOrderBy.FormattingEnabled = True
        Me.cboPhoneOrderBy.Location = New System.Drawing.Point(499, 321)
        Me.cboPhoneOrderBy.Name = "cboPhoneOrderBy"
        Me.cboPhoneOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboPhoneOrderBy.TabIndex = 36
        '
        'cboPhoneSearch
        '
        Me.cboPhoneSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhoneSearch.FormattingEnabled = True
        Me.cboPhoneSearch.Location = New System.Drawing.Point(290, 321)
        Me.cboPhoneSearch.Name = "cboPhoneSearch"
        Me.cboPhoneSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboPhoneSearch.TabIndex = 34
        '
        'cboZipOrderBy
        '
        Me.cboZipOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZipOrderBy.FormattingEnabled = True
        Me.cboZipOrderBy.Location = New System.Drawing.Point(499, 249)
        Me.cboZipOrderBy.Name = "cboZipOrderBy"
        Me.cboZipOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboZipOrderBy.TabIndex = 33
        '
        'cboZipSearch
        '
        Me.cboZipSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZipSearch.FormattingEnabled = True
        Me.cboZipSearch.Location = New System.Drawing.Point(290, 248)
        Me.cboZipSearch.Name = "cboZipSearch"
        Me.cboZipSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboZipSearch.TabIndex = 31
        '
        'cboStateOrderBy
        '
        Me.cboStateOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateOrderBy.FormattingEnabled = True
        Me.cboStateOrderBy.Location = New System.Drawing.Point(499, 213)
        Me.cboStateOrderBy.Name = "cboStateOrderBy"
        Me.cboStateOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboStateOrderBy.TabIndex = 30
        '
        'cboStateBool
        '
        Me.cboStateBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateBool.FormattingEnabled = True
        Me.cboStateBool.Location = New System.Drawing.Point(417, 213)
        Me.cboStateBool.Name = "cboStateBool"
        Me.cboStateBool.Size = New System.Drawing.Size(76, 21)
        Me.cboStateBool.TabIndex = 29
        '
        'cboStateSearch
        '
        Me.cboStateSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateSearch.FormattingEnabled = True
        Me.cboStateSearch.Location = New System.Drawing.Point(290, 213)
        Me.cboStateSearch.Name = "cboStateSearch"
        Me.cboStateSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboStateSearch.TabIndex = 28
        '
        'cboCityOrderBy
        '
        Me.cboCityOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCityOrderBy.FormattingEnabled = True
        Me.cboCityOrderBy.Location = New System.Drawing.Point(499, 180)
        Me.cboCityOrderBy.Name = "cboCityOrderBy"
        Me.cboCityOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboCityOrderBy.TabIndex = 27
        '
        'cboCityBool
        '
        Me.cboCityBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCityBool.FormattingEnabled = True
        Me.cboCityBool.Location = New System.Drawing.Point(417, 181)
        Me.cboCityBool.Name = "cboCityBool"
        Me.cboCityBool.Size = New System.Drawing.Size(76, 21)
        Me.cboCityBool.TabIndex = 26
        '
        'cboCitySearch
        '
        Me.cboCitySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCitySearch.FormattingEnabled = True
        Me.cboCitySearch.Location = New System.Drawing.Point(290, 180)
        Me.cboCitySearch.Name = "cboCitySearch"
        Me.cboCitySearch.Size = New System.Drawing.Size(121, 21)
        Me.cboCitySearch.TabIndex = 25
        '
        'cboAddressOrderBy
        '
        Me.cboAddressOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressOrderBy.FormattingEnabled = True
        Me.cboAddressOrderBy.Location = New System.Drawing.Point(499, 148)
        Me.cboAddressOrderBy.Name = "cboAddressOrderBy"
        Me.cboAddressOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboAddressOrderBy.TabIndex = 24
        '
        'cboAddressBool
        '
        Me.cboAddressBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressBool.FormattingEnabled = True
        Me.cboAddressBool.Location = New System.Drawing.Point(417, 148)
        Me.cboAddressBool.Name = "cboAddressBool"
        Me.cboAddressBool.Size = New System.Drawing.Size(76, 21)
        Me.cboAddressBool.TabIndex = 23
        '
        'cboAddressSearch
        '
        Me.cboAddressSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressSearch.FormattingEnabled = True
        Me.cboAddressSearch.Location = New System.Drawing.Point(290, 148)
        Me.cboAddressSearch.Name = "cboAddressSearch"
        Me.cboAddressSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboAddressSearch.TabIndex = 22
        '
        'cboContactOrderBy
        '
        Me.cboContactOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContactOrderBy.FormattingEnabled = True
        Me.cboContactOrderBy.Location = New System.Drawing.Point(499, 83)
        Me.cboContactOrderBy.Name = "cboContactOrderBy"
        Me.cboContactOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboContactOrderBy.TabIndex = 21
        '
        'cboContactSearch
        '
        Me.cboContactSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContactSearch.FormattingEnabled = True
        Me.cboContactSearch.Location = New System.Drawing.Point(290, 83)
        Me.cboContactSearch.Name = "cboContactSearch"
        Me.cboContactSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboContactSearch.TabIndex = 19
        '
        'cboNameOrderBy
        '
        Me.cboNameOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNameOrderBy.FormattingEnabled = True
        Me.cboNameOrderBy.Location = New System.Drawing.Point(499, 53)
        Me.cboNameOrderBy.Name = "cboNameOrderBy"
        Me.cboNameOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboNameOrderBy.TabIndex = 18
        '
        'cboNameBool
        '
        Me.cboNameBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNameBool.FormattingEnabled = True
        Me.cboNameBool.Location = New System.Drawing.Point(417, 53)
        Me.cboNameBool.Name = "cboNameBool"
        Me.cboNameBool.Size = New System.Drawing.Size(76, 21)
        Me.cboNameBool.TabIndex = 17
        '
        'cboNameSearch
        '
        Me.cboNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNameSearch.FormattingEnabled = True
        Me.cboNameSearch.Location = New System.Drawing.Point(290, 53)
        Me.cboNameSearch.Name = "cboNameSearch"
        Me.cboNameSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboNameSearch.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(142, 377)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(142, 321)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(142, 20)
        Me.txtPhone.TabIndex = 14
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(143, 249)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(142, 20)
        Me.txtZip.TabIndex = 13
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(142, 214)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(142, 20)
        Me.txtState.TabIndex = 12
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(142, 181)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(142, 20)
        Me.txtCity.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(142, 149)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtAddress.TabIndex = 10
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(143, 84)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(141, 20)
        Me.txtContact.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(143, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 20)
        Me.txtName.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Email :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Phone :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Zip :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "State :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contact :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer Name :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(882, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave})
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
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.Location = New System.Drawing.Point(43, 29)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(110, 16)
        Me.lblManufacturer.TabIndex = 0
        Me.lblManufacturer.Text = "Manufacturer ID : "
        '
        'lblManufacturerID
        '
        Me.lblManufacturerID.AutoSize = True
        Me.lblManufacturerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturerID.Location = New System.Drawing.Point(157, 29)
        Me.lblManufacturerID.Name = "lblManufacturerID"
        Me.lblManufacturerID.Size = New System.Drawing.Size(56, 16)
        Me.lblManufacturerID.TabIndex = 1
        Me.lblManufacturerID.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Manufacturer Name : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(393, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Contact : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(77, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Address : "
        '
        'cboAddressType
        '
        Me.cboAddressType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAddressType.FormattingEnabled = True
        Me.cboAddressType.Location = New System.Drawing.Point(381, 264)
        Me.cboAddressType.Name = "cboAddressType"
        Me.cboAddressType.Size = New System.Drawing.Size(141, 24)
        Me.cboAddressType.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(106, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "City : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(97, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 16)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "State : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(77, 264)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Zip Code : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(94, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Email : "
        '
        'cboEmailType
        '
        Me.cboEmailType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmailType.FormattingEnabled = True
        Me.cboEmailType.Location = New System.Drawing.Point(381, 341)
        Me.cboEmailType.Name = "cboEmailType"
        Me.cboEmailType.Size = New System.Drawing.Size(141, 24)
        Me.cboEmailType.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(89, 393)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Phone : "
        '
        'cboPhoneType
        '
        Me.cboPhoneType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhoneType.FormattingEnabled = True
        Me.cboPhoneType.Location = New System.Drawing.Point(381, 390)
        Me.cboPhoneType.Name = "cboPhoneType"
        Me.cboPhoneType.Size = New System.Drawing.Size(141, 24)
        Me.cboPhoneType.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(477, 29)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 16)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status"
        '
        'txtNameAdd
        '
        Me.txtNameAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameAdd.Location = New System.Drawing.Point(159, 88)
        Me.txtNameAdd.Name = "txtNameAdd"
        Me.txtNameAdd.Size = New System.Drawing.Size(214, 22)
        Me.txtNameAdd.TabIndex = 14
        '
        'txtContactAdd
        '
        Me.txtContactAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactAdd.Location = New System.Drawing.Point(461, 88)
        Me.txtContactAdd.Name = "txtContactAdd"
        Me.txtContactAdd.Size = New System.Drawing.Size(199, 22)
        Me.txtContactAdd.TabIndex = 15
        '
        'txtAddressAdd
        '
        Me.txtAddressAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressAdd.Location = New System.Drawing.Point(160, 167)
        Me.txtAddressAdd.Name = "txtAddressAdd"
        Me.txtAddressAdd.Size = New System.Drawing.Size(213, 22)
        Me.txtAddressAdd.TabIndex = 16
        '
        'txtCityAdd
        '
        Me.txtCityAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCityAdd.Location = New System.Drawing.Point(160, 200)
        Me.txtCityAdd.Name = "txtCityAdd"
        Me.txtCityAdd.Size = New System.Drawing.Size(213, 22)
        Me.txtCityAdd.TabIndex = 17
        '
        'txtStateAdd
        '
        Me.txtStateAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateAdd.Location = New System.Drawing.Point(160, 232)
        Me.txtStateAdd.Name = "txtStateAdd"
        Me.txtStateAdd.Size = New System.Drawing.Size(109, 22)
        Me.txtStateAdd.TabIndex = 18
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.btnAdd)
        Me.TabPage3.Controls.Add(Me.txtPhoneAdd)
        Me.TabPage3.Controls.Add(Me.txtEmailAdd)
        Me.TabPage3.Controls.Add(Me.txtZipAdd)
        Me.TabPage3.Controls.Add(Me.txtStateAdd)
        Me.TabPage3.Controls.Add(Me.txtCityAdd)
        Me.TabPage3.Controls.Add(Me.txtAddressAdd)
        Me.TabPage3.Controls.Add(Me.txtContactAdd)
        Me.TabPage3.Controls.Add(Me.txtNameAdd)
        Me.TabPage3.Controls.Add(Me.lblStatus)
        Me.TabPage3.Controls.Add(Me.cboPhoneType)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.cboEmailType)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.cboAddressType)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.lblManufacturerID)
        Me.TabPage3.Controls.Add(Me.lblManufacturer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(753, 511)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Add New"
        '
        'txtZipAdd
        '
        Me.txtZipAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipAdd.Location = New System.Drawing.Point(160, 264)
        Me.txtZipAdd.Name = "txtZipAdd"
        Me.txtZipAdd.Size = New System.Drawing.Size(109, 22)
        Me.txtZipAdd.TabIndex = 19
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAdd.Location = New System.Drawing.Point(160, 341)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(199, 22)
        Me.txtEmailAdd.TabIndex = 20
        '
        'txtPhoneAdd
        '
        Me.txtPhoneAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneAdd.Location = New System.Drawing.Point(160, 392)
        Me.txtPhoneAdd.Name = "txtPhoneAdd"
        Me.txtPhoneAdd.Size = New System.Drawing.Size(199, 22)
        Me.txtPhoneAdd.TabIndex = 21
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(595, 368)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 46)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Add Manufacturer"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(435, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Type"
        '
        'frmManufacturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(882, 599)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmManufacturer"
        Me.Text = "Manufacturer Info"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvManufacturerEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvManufacturerPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvManufacturerAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvManufacturer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvManufacturerEmail As System.Windows.Forms.DataGridView
    Friend WithEvents ManufacturerEmailID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerEmailVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerEmailLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerEmailDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EmailType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvManufacturerPhone As System.Windows.Forms.DataGridView
    Friend WithEvents ManufacturerPhoneID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerPhoneVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerPhoneLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerPhoneDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PhoneType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvManufacturerAddress As System.Windows.Forms.DataGridView
    Friend WithEvents ManufacturerAddressID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerAddressVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerAddressLastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerAddressDeleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AddressType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Zip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvManufacturer As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Version As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ManufacturerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnSearchEmail As System.Windows.Forms.Button
    Friend WithEvents btnSearchPhone As System.Windows.Forms.Button
    Friend WithEvents btnSearchAddress As System.Windows.Forms.Button
    Friend WithEvents btnSearchManufacturer As System.Windows.Forms.Button
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
    Friend WithEvents cboContactOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboContactSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cboNameOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents cboNameBool As System.Windows.Forms.ComboBox
    Friend WithEvents cboNameSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtPhoneAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtZipAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtStateAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtCityAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtContactAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtNameAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboPhoneType As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboEmailType As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboAddressType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblManufacturerID As System.Windows.Forms.Label
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
End Class
