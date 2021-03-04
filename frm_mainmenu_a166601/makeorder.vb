Public Class makeorder

    Dim number As Double
    Dim number1 As Double
    Dim c As String
    Dim duit As Double
    Dim num As Integer
    Dim current_code As String
    Dim current_code1 As String
    Dim current_code2 As String

    Private Sub makeorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_code()
        Dim current_date As String = Date.Now
        tb_date.Text = current_date
        c = 100
        refresh_count()
        refresh_staff()
        btn_addcart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A166601"

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
        tb_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        tb_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        tb_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        tb_brand.Text = mydatatable.Rows(0).Item("FLD_GENRE")
        tb_colour.Text = mydatatable.Rows(0).Item("FLD_PLAYABLE")
        tb_dimension.Text = mydatatable.Rows(0).Item("FLD_RELEASED")
        tb_material.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        tb_total.Text = num * tb_price.Text

        Try

            pic_product.BackgroundImage = Image.FromFile("Pictures/" & tb_id.Text & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("Pictures/nophoto.png")

        End Try
    End Sub

    Private Sub lst_product_MouseCLick(sender As Object, e As EventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        num = NumericUpDown1.Value
        number1 = tb_price.Text()
        tb_total.Text = num * number1
    End Sub

    Private Sub refresh_grid()
        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMER"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        grd_customer.DataSource = mydatatable2
        grd_customer.Columns(0).HeaderText = "ID"
        grd_customer.Columns(1).HeaderText = "NAME"

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_code = grd_customer(0, current_row).Value
        tb_id_customer.Text = current_code
        tb_custname.Text = grd_customer(1, current_row).Value
    End Sub

    Private Sub grd_customer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick
        get_current_code()
    End Sub

    Private Sub refresh_staff()

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_staffid.DataSource = mydatatable
        cmb_staffid.DisplayMember = "FLD_STAFF_ID"

    End Sub

    Private Sub refresh_count()

        Dim count As Integer = 1
        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        count += mydatatable.Rows(0).Item("count_id")
        lbl_orderid.Text = "H" + count.ToString("000")

    End Sub

    Private Sub btn_neworder_Click(sender As System.Object, e As System.EventArgs) Handles btn_neworder.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try

            Dim mysql As String = "INSERT INTO TBL_ORDER (FLD_ORDER_ID,FLD_STAFF_ID,FLD_CUSTOMER_ID) values (""" &
            lbl_orderid.Text & """,""" & cmb_staffid.Text & """,""" & tb_id_customer.Text & """)"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2,
            mytransaction)

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("You can make new order now!")
            refresh_grid()
            grd_orderlist.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addcart.Enabled = True
        btn_confirm.Enabled = True
        btn_remove.Enabled = True
        btn_neworder.Enabled = False

    End Sub

    Private Sub btn_addcart_Click(sender As System.Object, e As System.EventArgs) Handles btn_addcart.Click
        grd_orderlist.Rows.Add(New String() {tb_id.Text, tb_name.Text, NumericUpDown1.Value, tb_total.Text})
        tb_total.Text = ""
        NumericUpDown1.Value = 0
        lbl_total.Text = " "
        refresh_price()
    End Sub

    Private Sub refresh_price()

        If grd_orderlist.RowCount > 0 Then
            duit = 0

            For index As Integer = 0 To grd_orderlist.RowCount - 1
                duit += Convert.ToDouble(grd_orderlist.Rows(index).Cells(3).Value)
            Next

            lbl_total.Text = "RM " & duit
        ElseIf grd_orderlist.RowCount = 1 Then

            lbl_total.Text = "RM 0"

        End If

    End Sub

    Private Sub btn_remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_remove.Click
        Dim delete_order = MsgBox("Confirm to delete this item from list?", MsgBoxStyle.YesNo)

        If delete_order = MsgBoxResult.Yes Then
            grd_orderlist.Rows.Remove(grd_orderlist.CurrentRow)
            refresh_price()
        Else
            refresh_price()
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As System.Object, e As System.EventArgs) Handles btn_confirm.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction
        Try
            For i As Integer = 0 To grd_orderlist.RowCount - 1
                Dim productid As String = grd_orderlist(0, i).Value
                Dim productname As String = grd_orderlist(1, i).Value
                Dim quantity As String = grd_orderlist(2, i).Value
                Dim price As String = grd_orderlist(3, i).Value

                Dim mysql As String = "insert into TBL_PROCESS_ORDERING (FLD_PRODUCT_ID, FLD_ORDER_ID, FLD_QUANTITY_PRODUCT) values (""" & productid & """, """ & lbl_orderid.Text & """, """ & quantity & """)"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)


                mywriter.ExecuteNonQuery()

            Next
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
            refresh_grid()
            grd_orderlist.Rows.Clear()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addcart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        btn_neworder.Enabled = True
        NumericUpDown1.Value = 0
        lbl_total.Text = "0"
        refresh_count()
    End Sub

    Private Sub btn_invoice_Click(sender As System.Object, e As System.EventArgs) Handles btn_invoice.Click
        frm_order_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As System.Object, e As System.EventArgs)
        frm_mainmenu_a166601.Show()
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As System.Object, e As System.EventArgs)
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_mainmenu_a166601.Show()
        Me.Close()
    End Sub
End Class