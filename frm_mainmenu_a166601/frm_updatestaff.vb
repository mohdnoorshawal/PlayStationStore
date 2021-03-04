Public Class frm_updatestaff

    Dim current_code As String

    Private Sub frm_updatestaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_staffid.Text = ""
        txt_staffname.Text = ""

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_code = grd_staff(0, current_row).Value

        txt_staffid.Text = current_code
        txt_staffname.Text = grd_staff(1, current_row).Value
    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF SET FLD_STAFF_NAME='" & txt_staffname.Text & "' WHERE FLD_STAFF_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the staff : """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub pic_staff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs) 
        frm_staff_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF WHERE FLD_STAFF_ID='" & current_code & "'")

            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_staff_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class