Public Class frmVendorsDetails

    Private Sub frmVendorsDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmVendor.Close()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmMainMenu.Show()
    End Sub
End Class