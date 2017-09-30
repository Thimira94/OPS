Public Class frmVendor

    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmMainMenu.Show()
    End Sub

    Private Sub frmVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmOthers.Close()
    End Sub

    Private Sub btnViewVendors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewVendors.Click
        frmVendorsDetails.Show()
    End Sub

    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        venID.Text = ""
        txtVendorName.Clear()
        txtPhoneNo.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        selCode.Text = ""
        slcitem.Text = ""
        txtPrice.Clear()
    End Sub

    Private Sub btnAddVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddVendor.Click
        Dim id As String = venID.Text
        Dim name As String = txtVendorName.Text
        Dim phone As Integer = Val(txtPhoneNo.Text)
        Dim mail As String = txtEmail.Text
        Dim address As String = txtAddress.Text
        Dim item As String = slcitem.Text
        Dim code As String = selCode.Text
        Dim price As Single = txtPrice.Text
        Dim quantity As Integer = Val(txtQuantity.Text)

        con.Open()
        'cmd.CommandText = "INSERT INTO VendorDetails Values('" & id & "', '" & name & "', " & phone & ", '" & mail & "', '" & address & "', '" & item & "', '" & code & "', '" & price & "', " & quantity & ")"
        cmd.CommandText = "INSERT INTO VendorDetails(VendorID, VendorName, PhoneNo, Email, Address,Item,SelectCode, Price, Quantity) Values('" & id & "', '" & name & "','" & phone & "','" & mail & "','" & address & "','" & item & "','" & code & "','" & price & "'," & quantity & ")"
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()



    End Sub

    Private Sub cboSelectItem_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboVendorID_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class