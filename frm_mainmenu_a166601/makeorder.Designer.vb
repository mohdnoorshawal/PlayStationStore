<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class makeorder
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
        Me.grp_id_staff = New System.Windows.Forms.GroupBox()
        Me.cmb_staffid = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grp_customer = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_date = New System.Windows.Forms.TextBox()
        Me.btn_neworder = New System.Windows.Forms.Button()
        Me.tb_id_customer = New System.Windows.Forms.Label()
        Me.tb_custname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.grd_orderlist = New System.Windows.Forms.DataGridView()
        Me.FLD_PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRODUCT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.grp_chooseitems = New System.Windows.Forms.GroupBox()
        Me.btn_addcart = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_id = New System.Windows.Forms.Label()
        Me.tb_material = New System.Windows.Forms.TextBox()
        Me.tb_dimension = New System.Windows.Forms.TextBox()
        Me.tb_colour = New System.Windows.Forms.TextBox()
        Me.tb_brand = New System.Windows.Forms.TextBox()
        Me.tb_price = New System.Windows.Forms.TextBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grp_id_staff.SuspendLayout()
        Me.grp_customer.SuspendLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_orderlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_chooseitems.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_id_staff
        '
        Me.grp_id_staff.BackColor = System.Drawing.Color.White
        Me.grp_id_staff.Controls.Add(Me.cmb_staffid)
        Me.grp_id_staff.Controls.Add(Me.Label15)
        Me.grp_id_staff.Controls.Add(Me.lbl_orderid)
        Me.grp_id_staff.Controls.Add(Me.Label14)
        Me.grp_id_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_id_staff.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grp_id_staff.Location = New System.Drawing.Point(11, 47)
        Me.grp_id_staff.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_id_staff.Name = "grp_id_staff"
        Me.grp_id_staff.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_id_staff.Size = New System.Drawing.Size(513, 64)
        Me.grp_id_staff.TabIndex = 6
        Me.grp_id_staff.TabStop = False
        Me.grp_id_staff.Text = "Basic Informations"
        '
        'cmb_staffid
        '
        Me.cmb_staffid.FormattingEnabled = True
        Me.cmb_staffid.Location = New System.Drawing.Point(65, 31)
        Me.cmb_staffid.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_staffid.Name = "cmb_staffid"
        Me.cmb_staffid.Size = New System.Drawing.Size(82, 23)
        Me.cmb_staffid.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 17)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Staff ID:"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(164, 31)
        Me.lbl_orderid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(29, 24)
        Me.lbl_orderid.TabIndex = 34
        Me.lbl_orderid.Text = "ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(165, 16)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Order ID:"
        '
        'grp_customer
        '
        Me.grp_customer.BackColor = System.Drawing.Color.White
        Me.grp_customer.Controls.Add(Me.Label13)
        Me.grp_customer.Controls.Add(Me.tb_date)
        Me.grp_customer.Controls.Add(Me.btn_neworder)
        Me.grp_customer.Controls.Add(Me.tb_id_customer)
        Me.grp_customer.Controls.Add(Me.tb_custname)
        Me.grp_customer.Controls.Add(Me.Label11)
        Me.grp_customer.Controls.Add(Me.Label12)
        Me.grp_customer.Controls.Add(Me.grd_customer)
        Me.grp_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_customer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grp_customer.Location = New System.Drawing.Point(11, 125)
        Me.grp_customer.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_customer.Name = "grp_customer"
        Me.grp_customer.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_customer.Size = New System.Drawing.Size(522, 211)
        Me.grp_customer.TabIndex = 7
        Me.grp_customer.TabStop = False
        Me.grp_customer.Text = "Customer Informations"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 188)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 17)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Order Date:"
        '
        'tb_date
        '
        Me.tb_date.BackColor = System.Drawing.Color.White
        Me.tb_date.Location = New System.Drawing.Point(77, 186)
        Me.tb_date.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.ReadOnly = True
        Me.tb_date.Size = New System.Drawing.Size(179, 21)
        Me.tb_date.TabIndex = 42
        '
        'btn_neworder
        '
        Me.btn_neworder.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_neworder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_neworder.ForeColor = System.Drawing.Color.Black
        Me.btn_neworder.Location = New System.Drawing.Point(397, 161)
        Me.btn_neworder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_neworder.Name = "btn_neworder"
        Me.btn_neworder.Size = New System.Drawing.Size(109, 31)
        Me.btn_neworder.TabIndex = 41
        Me.btn_neworder.Text = "NEW ORDER"
        Me.btn_neworder.UseVisualStyleBackColor = False
        '
        'tb_id_customer
        '
        Me.tb_id_customer.AutoSize = True
        Me.tb_id_customer.Location = New System.Drawing.Point(74, 142)
        Me.tb_id_customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tb_id_customer.Name = "tb_id_customer"
        Me.tb_id_customer.Size = New System.Drawing.Size(19, 15)
        Me.tb_id_customer.TabIndex = 34
        Me.tb_id_customer.Text = "ID"
        '
        'tb_custname
        '
        Me.tb_custname.BackColor = System.Drawing.Color.White
        Me.tb_custname.Location = New System.Drawing.Point(77, 161)
        Me.tb_custname.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_custname.Name = "tb_custname"
        Me.tb_custname.ReadOnly = True
        Me.tb_custname.Size = New System.Drawing.Size(179, 21)
        Me.tb_custname.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 162)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 141)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "ID:"
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_customer.Location = New System.Drawing.Point(5, 18)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowTemplate.Height = 28
        Me.grd_customer.Size = New System.Drawing.Size(513, 121)
        Me.grd_customer.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btn_invoice)
        Me.GroupBox1.Controls.Add(Me.btn_confirm)
        Me.GroupBox1.Controls.Add(Me.btn_remove)
        Me.GroupBox1.Controls.Add(Me.grd_orderlist)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(11, 350)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(522, 172)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item(s) On Cart"
        '
        'btn_invoice
        '
        Me.btn_invoice.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_invoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.ForeColor = System.Drawing.Color.Black
        Me.btn_invoice.Location = New System.Drawing.Point(302, 131)
        Me.btn_invoice.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(93, 31)
        Me.btn_invoice.TabIndex = 42
        Me.btn_invoice.Text = "INVOICE"
        Me.btn_invoice.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.Black
        Me.btn_confirm.Location = New System.Drawing.Point(107, 131)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(93, 31)
        Me.btn_confirm.TabIndex = 41
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.ForeColor = System.Drawing.Color.Black
        Me.btn_remove.Location = New System.Drawing.Point(205, 131)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(93, 31)
        Me.btn_remove.TabIndex = 40
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'grd_orderlist
        '
        Me.grd_orderlist.AllowUserToAddRows = False
        Me.grd_orderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_orderlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_orderlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FLD_PRODUCT_ID, Me.FLD_PRODUCT_NAME, Me.FLD_QUANTITY, Me.FLD_PRICE})
        Me.grd_orderlist.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_orderlist.Location = New System.Drawing.Point(4, 22)
        Me.grd_orderlist.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_orderlist.Name = "grd_orderlist"
        Me.grd_orderlist.RowTemplate.Height = 28
        Me.grd_orderlist.Size = New System.Drawing.Size(514, 99)
        Me.grd_orderlist.TabIndex = 1
        '
        'FLD_PRODUCT_ID
        '
        Me.FLD_PRODUCT_ID.HeaderText = "PRODUCT ID"
        Me.FLD_PRODUCT_ID.Name = "FLD_PRODUCT_ID"
        Me.FLD_PRODUCT_ID.ReadOnly = True
        Me.FLD_PRODUCT_ID.Width = 97
        '
        'FLD_PRODUCT_NAME
        '
        Me.FLD_PRODUCT_NAME.HeaderText = "PRODUCT NAME"
        Me.FLD_PRODUCT_NAME.Name = "FLD_PRODUCT_NAME"
        Me.FLD_PRODUCT_NAME.ReadOnly = True
        Me.FLD_PRODUCT_NAME.Width = 118
        '
        'FLD_QUANTITY
        '
        Me.FLD_QUANTITY.HeaderText = "QUANTITY"
        Me.FLD_QUANTITY.Name = "FLD_QUANTITY"
        Me.FLD_QUANTITY.ReadOnly = True
        Me.FLD_QUANTITY.Width = 90
        '
        'FLD_PRICE
        '
        Me.FLD_PRICE.HeaderText = "PRICE"
        Me.FLD_PRICE.Name = "FLD_PRICE"
        Me.FLD_PRICE.ReadOnly = True
        Me.FLD_PRICE.Width = 68
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(548, 178)
        Me.lst_product.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(120, 212)
        Me.lst_product.TabIndex = 44
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.White
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(548, 27)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(119, 146)
        Me.pic_product.TabIndex = 43
        Me.pic_product.TabStop = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(544, 432)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(77, 24)
        Me.lbl_total.TabIndex = 46
        Me.lbl_total.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(545, 414)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 17)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "TOTAL:"
        '
        'grp_chooseitems
        '
        Me.grp_chooseitems.BackColor = System.Drawing.Color.White
        Me.grp_chooseitems.Controls.Add(Me.btn_addcart)
        Me.grp_chooseitems.Controls.Add(Me.Label10)
        Me.grp_chooseitems.Controls.Add(Me.NumericUpDown1)
        Me.grp_chooseitems.Controls.Add(Me.tb_total)
        Me.grp_chooseitems.Controls.Add(Me.Label9)
        Me.grp_chooseitems.Controls.Add(Me.Label1)
        Me.grp_chooseitems.Controls.Add(Me.tb_id)
        Me.grp_chooseitems.Controls.Add(Me.tb_material)
        Me.grp_chooseitems.Controls.Add(Me.tb_dimension)
        Me.grp_chooseitems.Controls.Add(Me.tb_colour)
        Me.grp_chooseitems.Controls.Add(Me.tb_brand)
        Me.grp_chooseitems.Controls.Add(Me.tb_price)
        Me.grp_chooseitems.Controls.Add(Me.tb_name)
        Me.grp_chooseitems.Controls.Add(Me.Label8)
        Me.grp_chooseitems.Controls.Add(Me.Label7)
        Me.grp_chooseitems.Controls.Add(Me.Label6)
        Me.grp_chooseitems.Controls.Add(Me.Label5)
        Me.grp_chooseitems.Controls.Add(Me.Label4)
        Me.grp_chooseitems.Controls.Add(Me.Label3)
        Me.grp_chooseitems.Controls.Add(Me.Label2)
        Me.grp_chooseitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_chooseitems.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grp_chooseitems.Location = New System.Drawing.Point(672, 89)
        Me.grp_chooseitems.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_chooseitems.Name = "grp_chooseitems"
        Me.grp_chooseitems.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_chooseitems.Size = New System.Drawing.Size(260, 287)
        Me.grp_chooseitems.TabIndex = 49
        Me.grp_chooseitems.TabStop = False
        Me.grp_chooseitems.Text = "Choose Item(s)"
        '
        'btn_addcart
        '
        Me.btn_addcart.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_addcart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addcart.ForeColor = System.Drawing.Color.Black
        Me.btn_addcart.Location = New System.Drawing.Point(56, 252)
        Me.btn_addcart.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_addcart.Name = "btn_addcart"
        Me.btn_addcart.Size = New System.Drawing.Size(134, 31)
        Me.btn_addcart.TabIndex = 39
        Me.btn_addcart.Text = "ADD TO CART"
        Me.btn_addcart.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(63, 223)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 17)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "RM"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(78, 188)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(178, 21)
        Me.NumericUpDown1.TabIndex = 37
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.Color.White
        Me.tb_total.Location = New System.Drawing.Point(100, 222)
        Me.tb_total.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(157, 21)
        Me.tb_total.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 224)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Quantity:"
        '
        'tb_id
        '
        Me.tb_id.AutoSize = True
        Me.tb_id.Location = New System.Drawing.Point(76, 27)
        Me.tb_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(19, 15)
        Me.tb_id.TabIndex = 33
        Me.tb_id.Text = "ID"
        '
        'tb_material
        '
        Me.tb_material.BackColor = System.Drawing.Color.White
        Me.tb_material.Location = New System.Drawing.Point(78, 153)
        Me.tb_material.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_material.Name = "tb_material"
        Me.tb_material.ReadOnly = True
        Me.tb_material.Size = New System.Drawing.Size(179, 21)
        Me.tb_material.TabIndex = 32
        '
        'tb_dimension
        '
        Me.tb_dimension.BackColor = System.Drawing.Color.White
        Me.tb_dimension.Location = New System.Drawing.Point(79, 131)
        Me.tb_dimension.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_dimension.Name = "tb_dimension"
        Me.tb_dimension.ReadOnly = True
        Me.tb_dimension.Size = New System.Drawing.Size(179, 21)
        Me.tb_dimension.TabIndex = 31
        '
        'tb_colour
        '
        Me.tb_colour.BackColor = System.Drawing.Color.White
        Me.tb_colour.Location = New System.Drawing.Point(79, 109)
        Me.tb_colour.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_colour.Name = "tb_colour"
        Me.tb_colour.ReadOnly = True
        Me.tb_colour.Size = New System.Drawing.Size(179, 21)
        Me.tb_colour.TabIndex = 30
        '
        'tb_brand
        '
        Me.tb_brand.BackColor = System.Drawing.Color.White
        Me.tb_brand.Location = New System.Drawing.Point(79, 87)
        Me.tb_brand.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_brand.Name = "tb_brand"
        Me.tb_brand.ReadOnly = True
        Me.tb_brand.Size = New System.Drawing.Size(179, 21)
        Me.tb_brand.TabIndex = 29
        '
        'tb_price
        '
        Me.tb_price.BackColor = System.Drawing.Color.White
        Me.tb_price.Location = New System.Drawing.Point(79, 65)
        Me.tb_price.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_price.Name = "tb_price"
        Me.tb_price.ReadOnly = True
        Me.tb_price.Size = New System.Drawing.Size(179, 21)
        Me.tb_price.TabIndex = 28
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.White
        Me.tb_name.Location = New System.Drawing.Point(79, 43)
        Me.tb_name.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.ReadOnly = True
        Me.tb_name.Size = New System.Drawing.Size(179, 21)
        Me.tb_name.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Product ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Material:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Dimension:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Colour:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Brand:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Price in RM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Hobo Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(12, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 25)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "MAKE NEW ORDER"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(840, 493)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(738, 493)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'makeorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.frm_mainmenu_a166601.My.Resources.Resources.psvr_worlds
        Me.ClientSize = New System.Drawing.Size(943, 528)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grp_chooseitems)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_customer)
        Me.Controls.Add(Me.grp_id_staff)
        Me.Name = "makeorder"
        Me.Text = "makeorder"
        Me.grp_id_staff.ResumeLayout(False)
        Me.grp_id_staff.PerformLayout()
        Me.grp_customer.ResumeLayout(False)
        Me.grp_customer.PerformLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grd_orderlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_chooseitems.ResumeLayout(False)
        Me.grp_chooseitems.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_id_staff As GroupBox
    Friend WithEvents cmb_staffid As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents grp_customer As GroupBox
    Friend WithEvents btn_neworder As Button
    Friend WithEvents tb_id_customer As Label
    Friend WithEvents tb_custname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents grd_orderlist As DataGridView
    Friend WithEvents FLD_PRODUCT_ID As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRODUCT_NAME As DataGridViewTextBoxColumn
    Friend WithEvents FLD_QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRICE As DataGridViewTextBoxColumn
    Friend WithEvents lst_product As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents grp_chooseitems As GroupBox
    Friend WithEvents btn_addcart As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents tb_total As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_id As Label
    Friend WithEvents tb_material As TextBox
    Friend WithEvents tb_dimension As TextBox
    Friend WithEvents tb_colour As TextBox
    Friend WithEvents tb_brand As TextBox
    Friend WithEvents tb_price As TextBox
    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_date As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
