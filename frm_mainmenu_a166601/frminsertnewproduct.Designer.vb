<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminsertnewproduct
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grd_newproduct = New System.Windows.Forms.DataGridView()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.txt_newreleased = New System.Windows.Forms.TextBox()
        Me.txt_newplayable = New System.Windows.Forms.TextBox()
        Me.txt_newgenre = New System.Windows.Forms.TextBox()
        Me.txt_newprice = New System.Windows.Forms.TextBox()
        Me.txt_newproductname = New System.Windows.Forms.TextBox()
        Me.Txt_newproductid = New System.Windows.Forms.TextBox()
        Me.txt_newtype = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.grd_newproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Hobo Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(206, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "INSERT NEW PRODUCTS"
        '
        'grd_newproduct
        '
        Me.grd_newproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_newproduct.Location = New System.Drawing.Point(13, 37)
        Me.grd_newproduct.Name = "grd_newproduct"
        Me.grd_newproduct.Size = New System.Drawing.Size(763, 339)
        Me.grd_newproduct.TabIndex = 28
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(971, 35)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(100, 97)
        Me.pic_product.TabIndex = 40
        Me.pic_product.TabStop = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(971, 136)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(100, 20)
        Me.txt_picture.TabIndex = 41
        '
        'txt_newreleased
        '
        Me.txt_newreleased.Location = New System.Drawing.Point(971, 294)
        Me.txt_newreleased.Name = "txt_newreleased"
        Me.txt_newreleased.Size = New System.Drawing.Size(100, 20)
        Me.txt_newreleased.TabIndex = 42
        '
        'txt_newplayable
        '
        Me.txt_newplayable.Location = New System.Drawing.Point(971, 268)
        Me.txt_newplayable.Name = "txt_newplayable"
        Me.txt_newplayable.Size = New System.Drawing.Size(100, 20)
        Me.txt_newplayable.TabIndex = 43
        '
        'txt_newgenre
        '
        Me.txt_newgenre.Location = New System.Drawing.Point(971, 242)
        Me.txt_newgenre.Name = "txt_newgenre"
        Me.txt_newgenre.Size = New System.Drawing.Size(100, 20)
        Me.txt_newgenre.TabIndex = 44
        '
        'txt_newprice
        '
        Me.txt_newprice.Location = New System.Drawing.Point(971, 216)
        Me.txt_newprice.Name = "txt_newprice"
        Me.txt_newprice.Size = New System.Drawing.Size(100, 20)
        Me.txt_newprice.TabIndex = 45
        '
        'txt_newproductname
        '
        Me.txt_newproductname.Location = New System.Drawing.Point(971, 190)
        Me.txt_newproductname.Name = "txt_newproductname"
        Me.txt_newproductname.Size = New System.Drawing.Size(100, 20)
        Me.txt_newproductname.TabIndex = 46
        '
        'Txt_newproductid
        '
        Me.Txt_newproductid.Location = New System.Drawing.Point(971, 164)
        Me.Txt_newproductid.Name = "Txt_newproductid"
        Me.Txt_newproductid.Size = New System.Drawing.Size(100, 20)
        Me.Txt_newproductid.TabIndex = 47
        '
        'txt_newtype
        '
        Me.txt_newtype.Location = New System.Drawing.Point(971, 320)
        Me.txt_newtype.Name = "txt_newtype"
        Me.txt_newtype.Size = New System.Drawing.Size(100, 20)
        Me.txt_newtype.TabIndex = 48
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_picture.Location = New System.Drawing.Point(851, 136)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(90, 23)
        Me.btn_picture.TabIndex = 49
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_insert.Location = New System.Drawing.Point(996, 353)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 50
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(849, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "New Product Name  : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(849, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "New Product ID : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(849, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Released : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(849, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Playable : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(849, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Genre : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(849, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Price : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(849, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Type : "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(996, 413)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 23)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(898, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frminsertnewproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.frm_mainmenu_a166601.My.Resources.Resources.psvr_worlds
        Me.ClientSize = New System.Drawing.Size(1097, 448)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_newtype)
        Me.Controls.Add(Me.Txt_newproductid)
        Me.Controls.Add(Me.txt_newproductname)
        Me.Controls.Add(Me.txt_newprice)
        Me.Controls.Add(Me.txt_newgenre)
        Me.Controls.Add(Me.txt_newplayable)
        Me.Controls.Add(Me.txt_newreleased)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_newproduct)
        Me.Controls.Add(Me.Label8)
        Me.DoubleBuffered = True
        Me.Name = "frminsertnewproduct"
        Me.Text = "frminsertnewproduct"
        CType(Me.grd_newproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents grd_newproduct As DataGridView
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents txt_newreleased As TextBox
    Friend WithEvents txt_newplayable As TextBox
    Friend WithEvents txt_newgenre As TextBox
    Friend WithEvents txt_newprice As TextBox
    Friend WithEvents txt_newproductname As TextBox
    Friend WithEvents Txt_newproductid As TextBox
    Friend WithEvents txt_newtype As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
