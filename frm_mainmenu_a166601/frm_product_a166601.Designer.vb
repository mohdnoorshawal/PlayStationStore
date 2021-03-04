<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_a166601
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
        Me.pic_products = New System.Windows.Forms.PictureBox()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.txt_productprice = New System.Windows.Forms.TextBox()
        Me.txt_productgenre = New System.Windows.Forms.TextBox()
        Me.txt_producttype = New System.Windows.Forms.TextBox()
        Me.txt_productreleased = New System.Windows.Forms.TextBox()
        Me.txt_productplayable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_mainmenu = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_products
        '
        Me.pic_products.BackColor = System.Drawing.Color.Transparent
        Me.pic_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_products.Location = New System.Drawing.Point(376, 48)
        Me.pic_products.Name = "pic_products"
        Me.pic_products.Size = New System.Drawing.Size(193, 179)
        Me.pic_products.TabIndex = 1
        Me.pic_products.TabStop = False
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(17, 48)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(133, 186)
        Me.lst_product.TabIndex = 3
        '
        'txt_productid
        '
        Me.txt_productid.Location = New System.Drawing.Point(232, 48)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.Size = New System.Drawing.Size(100, 20)
        Me.txt_productid.TabIndex = 4
        '
        'txt_productname
        '
        Me.txt_productname.Location = New System.Drawing.Point(232, 74)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(100, 20)
        Me.txt_productname.TabIndex = 5
        '
        'txt_productprice
        '
        Me.txt_productprice.Location = New System.Drawing.Point(232, 103)
        Me.txt_productprice.Name = "txt_productprice"
        Me.txt_productprice.Size = New System.Drawing.Size(100, 20)
        Me.txt_productprice.TabIndex = 6
        '
        'txt_productgenre
        '
        Me.txt_productgenre.Location = New System.Drawing.Point(232, 129)
        Me.txt_productgenre.Name = "txt_productgenre"
        Me.txt_productgenre.Size = New System.Drawing.Size(100, 20)
        Me.txt_productgenre.TabIndex = 7
        '
        'txt_producttype
        '
        Me.txt_producttype.Location = New System.Drawing.Point(232, 207)
        Me.txt_producttype.Name = "txt_producttype"
        Me.txt_producttype.Size = New System.Drawing.Size(100, 20)
        Me.txt_producttype.TabIndex = 8
        '
        'txt_productreleased
        '
        Me.txt_productreleased.Location = New System.Drawing.Point(232, 181)
        Me.txt_productreleased.Name = "txt_productreleased"
        Me.txt_productreleased.Size = New System.Drawing.Size(100, 20)
        Me.txt_productreleased.TabIndex = 9
        '
        'txt_productplayable
        '
        Me.txt_productplayable.Location = New System.Drawing.Point(232, 155)
        Me.txt_productplayable.Name = "txt_productplayable"
        Me.txt_productplayable.Size = New System.Drawing.Size(100, 20)
        Me.txt_productplayable.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(159, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Product ID : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(159, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Genre : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(159, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Price : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(159, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Name  : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(159, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Playable : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(159, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Type : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(159, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Released : "
        '
        'btn_mainmenu
        '
        Me.btn_mainmenu.BackColor = System.Drawing.Color.White
        Me.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_mainmenu.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_mainmenu.Location = New System.Drawing.Point(482, 257)
        Me.btn_mainmenu.Name = "btn_mainmenu"
        Me.btn_mainmenu.Size = New System.Drawing.Size(92, 23)
        Me.btn_mainmenu.TabIndex = 18
        Me.btn_mainmenu.Text = "Back to Main Menu"
        Me.btn_mainmenu.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Hobo Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(17, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "PRODUCT DETAILS"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_insert.Location = New System.Drawing.Point(240, 233)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(92, 23)
        Me.btn_insert.TabIndex = 31
        Me.btn_insert.Text = "INSERT NEW"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_update.Location = New System.Drawing.Point(240, 262)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(92, 23)
        Me.btn_update.TabIndex = 32
        Me.btn_update.Text = "UPDATE LIST"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'frm_product_a166601
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.frm_mainmenu_a166601.My.Resources.Resources.psvr_worlds
        Me.ClientSize = New System.Drawing.Size(586, 292)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_mainmenu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_productplayable)
        Me.Controls.Add(Me.txt_productreleased)
        Me.Controls.Add(Me.txt_producttype)
        Me.Controls.Add(Me.txt_productgenre)
        Me.Controls.Add(Me.txt_productprice)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.pic_products)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm_product_a166601"
        Me.Text = "Full Playstation Games List"
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_products As PictureBox
    Friend WithEvents lst_product As ListBox
    Friend WithEvents txt_productid As TextBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents txt_productprice As TextBox
    Friend WithEvents txt_productgenre As TextBox
    Friend WithEvents txt_producttype As TextBox
    Friend WithEvents txt_productreleased As TextBox
    Friend WithEvents txt_productplayable As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_mainmenu As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
End Class
