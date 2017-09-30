Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        login()

    End Sub
    Public Sub display()
        con.Open()

        Dim dt As New DataTable("Login")
        Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM Login", con)
        rs.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        Label3.Text = dt.Rows.Count
        rs.Dispose()
        con.Close()


    End Sub
    Public Sub login()
        con.Open()

        Dim dt As New DataTable("Login")
        Dim rs As New OleDb.OleDbDataAdapter("SELECT * FROM Login WHERE UserName= '" & txtUserName.Text & "' and Password='" & txtPassword.Text & "'", con)
        rs.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        Label3.Text = dt.Rows.Count
        rs.Dispose()
        con.Close()

        If Val(Label3.Text) = 1 Then
            MsgBox("Succesully Logged In")
            frmMainMenu.Show()

        Else
            MsgBox("Username or Password Incorrect")
            txtPassword.Text = ""
            txtUserName.Text = ""
        End If

    End Sub
End Class
