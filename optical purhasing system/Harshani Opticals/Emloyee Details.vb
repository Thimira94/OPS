Public Class frmEmloyeeDetails

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmMainMenu.Show()
    End Sub

    Private Sub frmEmloyeeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmEmployee.Close()

        con.Open()
        view()

    End Sub

    Public Sub view()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDb.OleDbDataAdapter

        da = New OleDb.OleDbDataAdapter("SELECT * FROM EmployeeDetails", con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        con.Close()

    End Sub
End Class