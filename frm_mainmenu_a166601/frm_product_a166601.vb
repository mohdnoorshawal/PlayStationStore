Public Class frm_product_a166601
    Private Sub frm_product_a166601_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A166601"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_product.Text)
    End Sub

    Private Sub refresh_text(product As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A166601 WHERE FLD_PRODUCT_ID='" & product & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_productid.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_productname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_productgenre.Text = mydatatable.Rows(0).Item("FLD_GENRE")
        txt_productplayable.Text = mydatatable.Rows(0).Item("FLD_PLAYABLE")
        txt_productprice.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_productreleased.Text = mydatatable.Rows(0).Item("FLD_RELEASED")
        txt_producttype.Text = mydatatable.Rows(0).Item("FLD_TYPE")

        pic_products.BackgroundImage = Image.FromFile("Pictures/" & txt_productid.Text & ".jpg")
    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_product.MouseClick

        refresh_text(lst_product.Text)
    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        frm_mainmenu_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frminsertnewproduct.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproducts.Show()
        Me.Hide()
    End Sub
End Class