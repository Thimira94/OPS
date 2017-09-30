Public Class frmMainMenu

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

    End Sub

    Private Sub btnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrders.Click
        frmCustomerDetail.Show()
    End Sub
    Private Sub btnOthers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOthers.Click
        frmOthers.Show()
    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmStock.Close()
        frmStockDetails.Close()
        frmVendor.Close()
        frmNewOrder.Close()
        frmEmployee.Close()
        frmEmloyeeDetails.Close()
        frmChangePassword.Close()
        frmCustomerDetail.Close()
        frmVendorsDetails.Close()
    End Sub
End Class