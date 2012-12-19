<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.tabCurrent = New System.Windows.Forms.TabPage()
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
        Me.tabAdd = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.tabCurrent.SuspendLayout()
        CType(Me.dgvCustomerEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabSearch)
        Me.TabControl1.Controls.Add(Me.tabCurrent)
        Me.TabControl1.Controls.Add(Me.tabAdd)
        Me.TabControl1.Location = New System.Drawing.Point(24, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(831, 494)
        Me.TabControl1.TabIndex = 0
        '
        'tabSearch
        '
        Me.tabSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.tabSearch.Controls.Add(Me.btnSearchEmail)
        Me.tabSearch.Controls.Add(Me.btnSearchPhone)
        Me.tabSearch.Controls.Add(Me.btnSearchAddress)
        Me.tabSearch.Controls.Add(Me.btnSearchCustomer)
        Me.tabSearch.Controls.Add(Me.cboEmailOrderBy)
        Me.tabSearch.Controls.Add(Me.cboEmailSearch)
        Me.tabSearch.Controls.Add(Me.cboPhoneOrderBy)
        Me.tabSearch.Controls.Add(Me.cboPhoneSearch)
        Me.tabSearch.Controls.Add(Me.cboZipOrderBy)
        Me.tabSearch.Controls.Add(Me.cboZipSearch)
        Me.tabSearch.Controls.Add(Me.cboStateOrderBy)
        Me.tabSearch.Controls.Add(Me.cboStateBool)
        Me.tabSearch.Controls.Add(Me.cboStateSearch)
        Me.tabSearch.Controls.Add(Me.cboCityOrderBy)
        Me.tabSearch.Controls.Add(Me.cboCityBool)
        Me.tabSearch.Controls.Add(Me.cboCitySearch)
        Me.tabSearch.Controls.Add(Me.cboAddressOrderBy)
        Me.tabSearch.Controls.Add(Me.cboAddressBool)
        Me.tabSearch.Controls.Add(Me.cboAddressSearch)
        Me.tabSearch.Controls.Add(Me.cboNameOrderBy)
        Me.tabSearch.Controls.Add(Me.cboNameSearch)
        Me.tabSearch.Controls.Add(Me.txtEmail)
        Me.tabSearch.Controls.Add(Me.txtPhone)
        Me.tabSearch.Controls.Add(Me.txtZip)
        Me.tabSearch.Controls.Add(Me.txtState)
        Me.tabSearch.Controls.Add(Me.txtCity)
        Me.tabSearch.Controls.Add(Me.txtAddress)
        Me.tabSearch.Controls.Add(Me.txtName)
        Me.tabSearch.Controls.Add(Me.Label8)
        Me.tabSearch.Controls.Add(Me.Label7)
        Me.tabSearch.Controls.Add(Me.Label6)
        Me.tabSearch.Controls.Add(Me.Label5)
        Me.tabSearch.Controls.Add(Me.Label4)
        Me.tabSearch.Controls.Add(Me.Label3)
        Me.tabSearch.Controls.Add(Me.Label1)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(823, 468)
        Me.tabSearch.TabIndex = 0
        Me.tabSearch.Text = "Search"
        '
        'tabCurrent
        '
        Me.tabCurrent.BackColor = System.Drawing.Color.Gainsboro
        Me.tabCurrent.Controls.Add(Me.dgvCustomerEmail)
        Me.tabCurrent.Controls.Add(Me.dgvCustomerPhone)
        Me.tabCurrent.Controls.Add(Me.dgvCustomerAddress)
        Me.tabCurrent.Controls.Add(Me.dgvCustomer)
        Me.tabCurrent.Location = New System.Drawing.Point(4, 22)
        Me.tabCurrent.Name = "tabCurrent"
        Me.tabCurrent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCurrent.Size = New System.Drawing.Size(823, 468)
        Me.tabCurrent.TabIndex = 1
        Me.tabCurrent.Text = "Current"
        '
        'btnSearchEmail
        '
        Me.btnSearchEmail.Location = New System.Drawing.Point(626, 366)
        Me.btnSearchEmail.Name = "btnSearchEmail"
        Me.btnSearchEmail.Size = New System.Drawing.Size(97, 26)
        Me.btnSearchEmail.TabIndex = 118
        Me.btnSearchEmail.Text = "Search Email"
        Me.btnSearchEmail.UseVisualStyleBackColor = True
        '
        'btnSearchPhone
        '
        Me.btnSearchPhone.Location = New System.Drawing.Point(626, 310)
        Me.btnSearchPhone.Name = "btnSearchPhone"
        Me.btnSearchPhone.Size = New System.Drawing.Size(97, 27)
        Me.btnSearchPhone.TabIndex = 117
        Me.btnSearchPhone.Text = "Search Phone"
        Me.btnSearchPhone.UseVisualStyleBackColor = True
        '
        'btnSearchAddress
        '
        Me.btnSearchAddress.Location = New System.Drawing.Point(626, 177)
        Me.btnSearchAddress.Name = "btnSearchAddress"
        Me.btnSearchAddress.Size = New System.Drawing.Size(97, 34)
        Me.btnSearchAddress.TabIndex = 116
        Me.btnSearchAddress.Text = "Search Address"
        Me.btnSearchAddress.UseVisualStyleBackColor = True
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(626, 37)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(97, 37)
        Me.btnSearchCustomer.TabIndex = 115
        Me.btnSearchCustomer.Text = "Search Customer"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'cboEmailOrderBy
        '
        Me.cboEmailOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailOrderBy.FormattingEnabled = True
        Me.cboEmailOrderBy.Location = New System.Drawing.Point(520, 369)
        Me.cboEmailOrderBy.Name = "cboEmailOrderBy"
        Me.cboEmailOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboEmailOrderBy.TabIndex = 114
        '
        'cboEmailSearch
        '
        Me.cboEmailSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailSearch.FormattingEnabled = True
        Me.cboEmailSearch.Location = New System.Drawing.Point(311, 370)
        Me.cboEmailSearch.Name = "cboEmailSearch"
        Me.cboEmailSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboEmailSearch.TabIndex = 113
        '
        'cboPhoneOrderBy
        '
        Me.cboPhoneOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhoneOrderBy.FormattingEnabled = True
        Me.cboPhoneOrderBy.Location = New System.Drawing.Point(520, 314)
        Me.cboPhoneOrderBy.Name = "cboPhoneOrderBy"
        Me.cboPhoneOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboPhoneOrderBy.TabIndex = 112
        '
        'cboPhoneSearch
        '
        Me.cboPhoneSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhoneSearch.FormattingEnabled = True
        Me.cboPhoneSearch.Location = New System.Drawing.Point(311, 314)
        Me.cboPhoneSearch.Name = "cboPhoneSearch"
        Me.cboPhoneSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboPhoneSearch.TabIndex = 111
        '
        'cboZipOrderBy
        '
        Me.cboZipOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZipOrderBy.FormattingEnabled = True
        Me.cboZipOrderBy.Location = New System.Drawing.Point(520, 242)
        Me.cboZipOrderBy.Name = "cboZipOrderBy"
        Me.cboZipOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboZipOrderBy.TabIndex = 110
        '
        'cboZipSearch
        '
        Me.cboZipSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZipSearch.FormattingEnabled = True
        Me.cboZipSearch.Location = New System.Drawing.Point(311, 241)
        Me.cboZipSearch.Name = "cboZipSearch"
        Me.cboZipSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboZipSearch.TabIndex = 109
        '
        'cboStateOrderBy
        '
        Me.cboStateOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateOrderBy.FormattingEnabled = True
        Me.cboStateOrderBy.Location = New System.Drawing.Point(520, 206)
        Me.cboStateOrderBy.Name = "cboStateOrderBy"
        Me.cboStateOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboStateOrderBy.TabIndex = 108
        '
        'cboStateBool
        '
        Me.cboStateBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateBool.FormattingEnabled = True
        Me.cboStateBool.Location = New System.Drawing.Point(438, 206)
        Me.cboStateBool.Name = "cboStateBool"
        Me.cboStateBool.Size = New System.Drawing.Size(76, 21)
        Me.cboStateBool.TabIndex = 107
        '
        'cboStateSearch
        '
        Me.cboStateSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStateSearch.FormattingEnabled = True
        Me.cboStateSearch.Location = New System.Drawing.Point(311, 206)
        Me.cboStateSearch.Name = "cboStateSearch"
        Me.cboStateSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboStateSearch.TabIndex = 106
        '
        'cboCityOrderBy
        '
        Me.cboCityOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCityOrderBy.FormattingEnabled = True
        Me.cboCityOrderBy.Location = New System.Drawing.Point(520, 173)
        Me.cboCityOrderBy.Name = "cboCityOrderBy"
        Me.cboCityOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboCityOrderBy.TabIndex = 105
        '
        'cboCityBool
        '
        Me.cboCityBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCityBool.FormattingEnabled = True
        Me.cboCityBool.Location = New System.Drawing.Point(438, 174)
        Me.cboCityBool.Name = "cboCityBool"
        Me.cboCityBool.Size = New System.Drawing.Size(76, 21)
        Me.cboCityBool.TabIndex = 104
        '
        'cboCitySearch
        '
        Me.cboCitySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCitySearch.FormattingEnabled = True
        Me.cboCitySearch.Location = New System.Drawing.Point(311, 173)
        Me.cboCitySearch.Name = "cboCitySearch"
        Me.cboCitySearch.Size = New System.Drawing.Size(121, 21)
        Me.cboCitySearch.TabIndex = 103
        '
        'cboAddressOrderBy
        '
        Me.cboAddressOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressOrderBy.FormattingEnabled = True
        Me.cboAddressOrderBy.Location = New System.Drawing.Point(520, 141)
        Me.cboAddressOrderBy.Name = "cboAddressOrderBy"
        Me.cboAddressOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboAddressOrderBy.TabIndex = 102
        '
        'cboAddressBool
        '
        Me.cboAddressBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressBool.FormattingEnabled = True
        Me.cboAddressBool.Location = New System.Drawing.Point(438, 141)
        Me.cboAddressBool.Name = "cboAddressBool"
        Me.cboAddressBool.Size = New System.Drawing.Size(76, 21)
        Me.cboAddressBool.TabIndex = 101
        '
        'cboAddressSearch
        '
        Me.cboAddressSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressSearch.FormattingEnabled = True
        Me.cboAddressSearch.Location = New System.Drawing.Point(311, 141)
        Me.cboAddressSearch.Name = "cboAddressSearch"
        Me.cboAddressSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboAddressSearch.TabIndex = 100
        '
        'cboNameOrderBy
        '
        Me.cboNameOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNameOrderBy.FormattingEnabled = True
        Me.cboNameOrderBy.Location = New System.Drawing.Point(520, 46)
        Me.cboNameOrderBy.Name = "cboNameOrderBy"
        Me.cboNameOrderBy.Size = New System.Drawing.Size(81, 21)
        Me.cboNameOrderBy.TabIndex = 99
        '
        'cboNameSearch
        '
        Me.cboNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNameSearch.FormattingEnabled = True
        Me.cboNameSearch.Location = New System.Drawing.Point(311, 46)
        Me.cboNameSearch.Name = "cboNameSearch"
        Me.cboNameSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboNameSearch.TabIndex = 98
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(163, 370)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 97
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(163, 314)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(142, 20)
        Me.txtPhone.TabIndex = 96
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(164, 242)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(142, 20)
        Me.txtZip.TabIndex = 95
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(163, 207)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(142, 20)
        Me.txtState.TabIndex = 94
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(163, 174)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(142, 20)
        Me.txtCity.TabIndex = 93
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(163, 142)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtAddress.TabIndex = 92
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 20)
        Me.txtName.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Email :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Phone :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Zip :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "State :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "City :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Address :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Customer Name :"
        '
        'dgvCustomerEmail
        '
        Me.dgvCustomerEmail.AllowUserToDeleteRows = False
        Me.dgvCustomerEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerEmail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerEmailID, Me.CustomerEmailVersion, Me.CustomerEmailLastUpdated, Me.CustomerEmailDeleted, Me.EmailType, Me.Email})
        Me.dgvCustomerEmail.Location = New System.Drawing.Point(178, 362)
        Me.dgvCustomerEmail.Name = "dgvCustomerEmail"
        Me.dgvCustomerEmail.Size = New System.Drawing.Size(421, 100)
        Me.dgvCustomerEmail.TabIndex = 11
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
        Me.dgvCustomerPhone.Location = New System.Drawing.Point(178, 256)
        Me.dgvCustomerPhone.Name = "dgvCustomerPhone"
        Me.dgvCustomerPhone.Size = New System.Drawing.Size(421, 100)
        Me.dgvCustomerPhone.TabIndex = 10
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
        Me.dgvCustomerAddress.Location = New System.Drawing.Point(101, 150)
        Me.dgvCustomerAddress.Name = "dgvCustomerAddress"
        Me.dgvCustomerAddress.Size = New System.Drawing.Size(577, 100)
        Me.dgvCustomerAddress.TabIndex = 9
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
        Me.dgvCustomer.Location = New System.Drawing.Point(178, 29)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(421, 115)
        Me.dgvCustomer.TabIndex = 8
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
        'tabAdd
        '
        Me.tabAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.tabAdd.Location = New System.Drawing.Point(4, 22)
        Me.tabAdd.Name = "tabAdd"
        Me.tabAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdd.Size = New System.Drawing.Size(823, 468)
        Me.tabAdd.TabIndex = 2
        Me.tabAdd.Text = "Add New"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(895, 549)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmCustomer"
        Me.Text = "Customer Account"
        Me.TabControl1.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        Me.tabSearch.PerformLayout()
        Me.tabCurrent.ResumeLayout(False)
        CType(Me.dgvCustomerEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabSearch As System.Windows.Forms.TabPage
    Friend WithEvents tabCurrent As System.Windows.Forms.TabPage
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
    Friend WithEvents tabAdd As System.Windows.Forms.TabPage
End Class
