Public Class frmNewOrder

    Private Sub frmNewOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmCustomerDetail.Close()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMainMenu.Show()

    End Sub

    Private Sub txtBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBack.Click
        frmCustomerDetail.Show()
    End Sub
End Class