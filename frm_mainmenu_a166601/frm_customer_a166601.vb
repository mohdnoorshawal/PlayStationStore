Public Class frm_customer_a166601
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_mainmenu_a166601.Show()
        Me.Hide()
    End Sub



    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub frm_customer_a166601_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_customer.DataSource = mydatatable
        lst_customer.DisplayMember = "FLD_CUSTOMER_ID"

        refresh_text(lst_customer.Text)

    End Sub

    Private Sub refresh_text(customer As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER WHERE FLD_CUSTOMER_ID='" & customer & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_customerid.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_customername.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")

    End Sub

    Private Sub lst_customer_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_customer.MouseClick

        refresh_text(lst_customer.Text)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertnewcustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updatecustomers.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_mainmenu_a166601.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class