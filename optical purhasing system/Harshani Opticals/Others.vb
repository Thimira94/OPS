Public Class frmOthers

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        frmEmployee.Show()
    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        frmStock.Show()
    End Sub

    Private Sub btnVedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVedor.Click
        frmVendor.Show()
    End Sub

   Private Sub frmOthers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmEmployee.Close()
        frmChangePassword.Close()
        frmMainMenu.Close()
    End Sub

    Private Sub btnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click
        frmChangePassword.Show()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
    End Sub
End Class