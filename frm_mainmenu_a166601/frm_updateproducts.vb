Public Class frm_updateproducts

    Dim current_code As String

    Private Sub frm_updateproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_code()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A166601"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_products.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        Txt_newproductid.Text = ""
        txt_newproductname.Text = ""
        txt_newprice.Text = ""
        txt_newgenre.Text = ""
        txt_newplayable.Text = ""
        txt_newreleased.Text = ""
        txt_newtype.Text = ""

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        Txt_newproductid.Text = current_code
        txt_newproductname.Text = grd_products(1, current_row).Value
        txt_newprice.Text = grd_products(2, current_row).Value
        txt_newgenre.Text = grd_products(3, current_row).Value

        txt_newplayable.Text = grd_products(4, current_row).Value
        txt_newreleased.Text = grd_products(5, current_row).Value
        txt_newtype.Text = grd_products(6, current_row).Value


    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A166601 SET FLD_PRODUCT_NAME='" & txt_newproductname.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A166601 SET FLD_PRICE='" & txt_newprice.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A166601 SET FLD_GENRE='" & txt_newgenre.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A166601 SET FLD_PLAYABLE='" & txt_newplayable.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A166601 SET FLD_RELEASED='" & txt_newreleased.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A166601 SET FLD_TYPE='" & txt_newtype.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the product : """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs)
        frm_product_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A166601 WHERE FLD_PRODUCT_ID='" & current_code & "'")

            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_product_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class