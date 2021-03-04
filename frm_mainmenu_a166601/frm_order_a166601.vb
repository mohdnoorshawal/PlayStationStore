Public Class frm_order_a166601
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_mainmenu_a166601.Show()
        Me.Hide()
    End Sub


    Private Sub frm_order_a166601_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_order.DataSource = mydatatable
        lst_order.DisplayMember = "FLD_ORDER_ID"

        refresh_text(lst_order.Text)
    End Sub

    Private Sub refresh_text(order As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER WHERE FLD_ORDER_ID='" & order & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_orderid.Text = mydatatable.Rows(0).Item("FLD_ORDER_ID")
        txt_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        txt_customerid.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")

    End Sub

    Private Sub lst_order_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_order.MouseClick

        refresh_text(lst_order.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_mainmenu_a166601.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class