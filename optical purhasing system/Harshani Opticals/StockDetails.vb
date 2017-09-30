Imports System.Data.OleDb

Public Class frmStockDetails

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmMainMenu.Show()
    End Sub

    Private Sub frmStockDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmStock.Close()
        frmOthers.Close()

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