Public Class frm_staff_a166601
    Private Sub frm_staff_a166601_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_staff.DataSource = mydatatable
        lst_staff.DisplayMember = "FLD_STAFF_ID"

        refresh_text(lst_staff.Text)
    End Sub

    Private Sub refresh_text(staff As String)

        Dim mysql As String = "SELECT * FROM TBL_STAFF WHERE FLD_STAFF_ID='" & staff & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        txt_staffname.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")

        Try
            pic_staff.BackgroundImage = Image.FromFile("Pictures/" & txt_staffid.Text & ".jpg")
        Catch ex As Exception
            pic_staff.BackgroundImage = Image.FromFile("Pictures/nophoto.png")
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_mainmenu_a166601.Show()
        Me.Hide()
    End Sub



    Private Sub lbl_title_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lst_staff_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_staff.MouseClick

        refresh_text(lst_staff.Text)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertnewstaff.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updatestaff.Show()
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