Public Class frmStock
    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand


    Private Sub btnAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStock.Click
        Dim price As Single = txtItemPrice.Text
        Dim Quantity As Integer = txtItemQuantity.Text
        Dim code As String = cboItemCode.Text
        Dim brand As String = txtItemBrand.Text
        Dim item As String = cboSelectItem.Text

        con.Open()
        cmd.CommandText = ("INSERT INTO StockDetails Values('" & code & "', '" & price & "', '" & brand & "', '" & item & "', '" & Quantity & "')")
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub btnDeleteStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteStock.Click
        con.Open()
        Dim coda As String = cboItemCode.Text

        cmd.CommandText = ("DELETE FROM StockDetails WHERE ItemCode='" & coda & "'")
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub btnUpdateDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDetails.Click
        Dim price As Single = txtItemPrice.Text
        Dim Quantity As Integer = txtItemQuantity.Text
        Dim code As String = cboItemCode.Text
        Dim brand As String = txtItemBrand.Text
        Dim item As String = cboSelectItem.Text

        con.Open()

        cmd.CommandText = ("UPDATE StockDetails SET ItemPrice='" & price & "', ItemBrand='" & brand & "', SelectItem='" & item & "', ItemQuantity='" & Quantity & "' WHERE ItemCode='" & code & "'")
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        cboItemCode.Text = ""
        txtItemPrice.Clear()
        txtItemBrand.Clear()
        cboSelectItem.Text = ""
        txtItemQuantity.Clear()
    End Sub

    Private Sub btnViewAllData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAllData.Click
        frmStockDetails.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMainMenu.Show()
    End Sub

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmOthers.Close()
    End Sub
End Class