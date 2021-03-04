Public Class frm_mainmenu_a166601
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_process_Click(sender As Object, e As EventArgs) Handles btn_process.Click
        frm_process_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        makeorder.Show()
        Me.Hide()
    End Sub
End Class
