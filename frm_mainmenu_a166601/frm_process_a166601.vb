Public Class frm_process_a166601
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_mainmenu_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_process_a166601_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PROCESS_ORDERING"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_currentorder.DataSource = mydatatable
        lst_currentorder.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_currentorder.Text)
    End Sub

    Private Sub refresh_text(process As String)

        Dim mysql As String = "SELECT * FROM TBL_PROCESS_ORDERING WHERE FLD_PRODUCT_ID='" & process & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_productid.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_orderid.Text = mydatatable.Rows(0).Item("FLD_ORDER_ID")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY_PRODUCT")

    End Sub

    Private Sub lst_currentorder_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_currentorder.MouseClick

        refresh_text(lst_currentorder.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_mainmenu_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class