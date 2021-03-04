<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproducts
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
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_newtype = New System.Windows.Forms.TextBox()
        Me.Txt_newproductid = New System.Windows.Forms.TextBox()
        Me.txt_newproductname = New System.Windows.Forms.TextBox()
        Me.txt_newprice = New System.Windows.Forms.TextBox()
        Me.txt_newgenre = New System.Windows.Forms.TextBox()
        Me.txt_newplayable = New System.Windows.Forms.TextBox()
        Me.txt_newreleased = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label8.Size = New System.Drawing.Size(237, 25)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "UPDATE/DELETE PRODUCTS"
        '
        'grd_products
        '
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(9, 37)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.Size = New System.Drawing.Size(763, 361)
        Me.grd_products.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(849, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Type : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(849, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Genre : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(849, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Price : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(849, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Released : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(849, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Playable : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(849, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Product Name  : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(849, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Product ID : "
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_update.Location = New System.Drawing.Point(996, 256)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 69
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_newtype
        '
        Me.txt_newtype.Location = New System.Drawing.Point(971, 215)
        Me.txt_newtype.Name = "txt_newtype"
        Me.txt_newtype.Size = New System.Drawing.Size(100, 20)
        Me.txt_newtype.TabIndex = 67
        '
        'Txt_newproductid
        '
        Me.Txt_newproductid.Location = New System.Drawing.Point(971, 59)
        Me.Txt_newproductid.Name = "Txt_newproductid"
        Me.Txt_newproductid.Size = New System.Drawing.Size(100, 20)
        Me.Txt_newproductid.TabIndex = 66
        '
        'txt_newproductname
        '
        Me.txt_newproductname.Location = New System.Drawing.Point(971, 85)
        Me.txt_newproductname.Name = "txt_newproductname"
        Me.txt_newproductname.Size = New System.Drawing.Size(100, 20)
        Me.txt_newproductname.TabIndex = 65
        '
        'txt_newprice
        '
        Me.txt_newprice.Location = New System.Drawing.Point(971, 111)
        Me.txt_newprice.Name = "txt_newprice"
        Me.txt_newprice.Size = New System.Drawing.Size(100, 20)
        Me.txt_newprice.TabIndex = 64
        '
        'txt_newgenre
        '
        Me.txt_newgenre.Location = New System.Drawing.Point(971, 137)
        Me.txt_newgenre.Name = "txt_newgenre"
        Me.txt_newgenre.Size = New System.Drawing.Size(100, 20)
        Me.txt_newgenre.TabIndex = 63
        '
        'txt_newplayable
        '
        Me.txt_newplayable.Location = New System.Drawing.Point(971, 163)
        Me.txt_newplayable.Name = "txt_newplayable"
        Me.txt_newplayable.Size = New System.Drawing.Size(100, 20)
        Me.txt_newplayable.TabIndex = 62
        '
        'txt_newreleased
        '
        Me.txt_newreleased.Location = New System.Drawing.Point(971, 189)
        Me.txt_newreleased.Name = "txt_newreleased"
        Me.txt_newreleased.Size = New System.Drawing.Size(100, 20)
        Me.txt_newreleased.TabIndex = 61
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_delete.Location = New System.Drawing.Point(996, 285)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 77
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(996, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 23)
        Me.Button3.TabIndex = 79
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(898, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_updateproducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.frm_mainmenu_a166601.My.Resources.Resources.psvr_worlds
        Me.ClientSize = New System.Drawing.Size(1100, 410)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_newtype)
        Me.Controls.Add(Me.Txt_newproductid)
        Me.Controls.Add(Me.txt_newproductname)
        Me.Controls.Add(Me.txt_newprice)
        Me.Controls.Add(Me.txt_newgenre)
        Me.Controls.Add(Me.txt_newplayable)
        Me.Controls.Add(Me.txt_newreleased)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.Label8)
        Me.DoubleBuffered = True
        Me.Name = "frm_updateproducts"
        Me.Text = "frm_updateproducts"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_newtype As TextBox
    Friend WithEvents Txt_newproductid As TextBox
    Friend WithEvents txt_newproductname As TextBox
    Friend WithEvents txt_newprice As TextBox
    Friend WithEvents txt_newgenre As TextBox
    Friend WithEvents txt_newplayable As TextBox
    Friend WithEvents txt_newreleased As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
