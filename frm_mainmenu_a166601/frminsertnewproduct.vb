Public Class frminsertnewproduct

    Dim defaultpicture As String = Application.StartupPath & "/Pictures/noimage.png"

    Private Sub frminsertnewproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_newproductid.Text = generate_newproductid()
        txt_newprice.Text = generate_newprice()
        refresh_grid()

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Function generate_newproductid() As String

        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTMATRIC FROM TBL_PRODUCTS_A166601").Rows(0).Item("LASTMATRIC")

        'MsgBox(lastmatric)

        Dim newproductid As String = "10" & Mid(lastmatric, 2) + 1

        Return newproductid

    End Function

    Private Function generate_newprice() As String

        Dim price As String = run_sql_query("SELECT MAX(FLD_PRICE) AS PRICE FROM TBL_PRODUCTS_A166601").Rows(0).Item("PRICE")

        'MsgBox(lastmatric)

        Dim newprice As String = "RM"

        Return newprice

    End Function

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A166601"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        grd_newproduct.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        Txt_newproductid.Text = ""
        txt_newproductname.Text = ""
        txt_newprice.Text = ""
        txt_newgenre.Text = ""
        txt_newplayable.Text = ""
        txt_newreleased.Text = ""
        txt_newtype.Text = ""

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A166601 VALUES (” & Txt_newproductid.Text & ",'" & txt_newproductname.Text & "','" & txt_newprice.Text & "','" & txt_newgenre.Text & "','" & txt_newplayable.Text & "'," & txt_newreleased.Text & ",'" & txt_newtype.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & Txt_newproductid.Text & ".jpg")

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs)
        frm_product_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub pic_product_Click(sender As Object, e As EventArgs) Handles pic_product.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_picture_TextChanged(sender As Object, e As EventArgs) Handles txt_picture.TextChanged

    End Sub

    Private Sub Txt_newproductid_TextChanged(sender As Object, e As EventArgs) Handles Txt_newproductid.TextChanged

    End Sub

    Private Sub txt_newproductname_TextChanged(sender As Object, e As EventArgs) Handles txt_newproductname.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt_newprice_TextChanged(sender As Object, e As EventArgs) Handles txt_newprice.TextChanged

    End Sub

    Private Sub txt_newgenre_TextChanged(sender As Object, e As EventArgs) Handles txt_newgenre.TextChanged

    End Sub

    Private Sub txt_newplayable_TextChanged(sender As Object, e As EventArgs) Handles txt_newplayable.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_newtype_TextChanged(sender As Object, e As EventArgs) Handles txt_newtype.TextChanged

    End Sub

    Private Sub txt_newreleased_TextChanged(sender As Object, e As EventArgs) Handles txt_newreleased.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_product_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class