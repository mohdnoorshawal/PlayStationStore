Public Class frm_insertnewcustomer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub frm_insertnewcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_customerid.Text = generate_customerid()
        refresh_grid()

    End Sub

    Private Function generate_customerid() As String

        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTMATRIC FROM TBL_CUSTOMER").Rows(0).Item("LASTMATRIC")

        'MsgBox(lastmatric)

        Dim newcustomerid As String = "C" & Mid(lastmatric, 2) + 1

        Return newcustomerid

    End Function

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        grd_newcustomer.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_customerid.Text = ""
        txt_customername.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER VALUES ('” & txt_customerid.Text & "','" & txt_customername.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try


    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs)

        frm_customer_a166601.Show()
        Me.Hide()

    End Sub

    Private Sub grd_newcustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_newcustomer.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_customer_a166601.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class