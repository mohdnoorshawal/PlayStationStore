Public Class frm_insertnewstaff
    Private Sub grd_newstaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_newstaff.CellContentClick

    End Sub

    Dim defaultpicture As String = Application.StartupPath & "/Pictures/nophoto.png"

    Private Sub frm_insertnewstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_staffid.Text = generate_staffid()
        refresh_grid()

        txt_picture.Text = defaultpicture
        pic_staff.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_staffid() As String

        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTMATRIC FROM TBL_STAFF").Rows(0).Item("LASTMATRIC")

        'MsgBox(lastmatric)

        Dim newstaffid As String = "A" & Mid(lastmatric, 2) + 1

        Return newstaffid

    End Function

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        grd_newstaff.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_staffid.Text = ""
        txt_staffname.Text = ""
        txt_picture.Text = defaultpicture
        pic_staff.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF VALUES ('” & txt_staffid.Text & "','" & txt_staffname.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_staffid.Text & ".jpg")

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try


    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs)

        frm_staff_a166601.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_staff.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frm_staff_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class