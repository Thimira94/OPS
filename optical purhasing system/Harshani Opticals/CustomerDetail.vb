Imports System.Data.OleDb

Public Class frmCustomerDetail
    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmNewOrder.Close()
        frmMainMenu.Close()
    End Sub

    Private Sub btnNewOrderEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewOrderEntry.Click
        GroupBox1.Enabled = True
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tot As Double
        Dim adv As Double
        Dim bal As Double

        bal = Val(txtTotal.Text) - Val(txtAdvance.Text)

        txtBalance.Text = bal
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            Dim id As String = txtCustomerID.Text
            Dim tlt As String = tltcombo.Text
            Dim name As String = txtName.Text
            Dim address As String = txtAddress.Text
            Dim phone As Integer = txtPhoneNo.Text

            con.Open()
            cmd.CommandText = ("INSERT INTO CustomerDetails Values('" & id & "', '" & tlt & "', '" & name & "', " & phone & ", '" & address & "')")
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            txtCustomerID.Enabled = False
            tltcombo.Text = ""
            txtName.Text = ""
            txtAddress.Text = ""
            txtPhoneNo.Text = ""


        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim id As String = txtCustomerID.Text


            Dim Order_Date As String = DateT1.Text
            Dim Dilivery_Date As String = DateT2.Text
            Dim Examiner As String = txtExaminer.Text
            Dim Left_eye As Double = txtLeftEye.Text
            Dim Right_eye As Double = txtRightEye.Text
            Dim Remark As String = txtRemark.Text
            Dim Total As Double = txtTotal.Text
            Dim Advance As Double = txtAdvance.Text
            Dim Balance As Double = txtBalance.Text
            Dim Frame As String = cboFrame.Text
            Dim Lence As String = cboLense.Text

            txtCustomerID.Text = ""
            DateT1.Text = ""
            DateT2.Text = ""
            txtExaminer.Text = ""
            txtLeftEye.Text = ""
            txtRightEye.Text = ""
            txtRemark.Text = ""
            txtTotal.Text = ""
            txtAdvance.Text = ""
            txtBalance.Text = ""
            cboFrame.Text = ""
            cboLense.Text = ""

            con.Open()
            cmd.CommandText = ("INSERT INTO OrderDetails Values('" & id & "','" & Frame & "','" & Lence & "','" & Order_Date & "','" & Dilivery_Date & "','" & Examiner & "'," & Left_eye & "," & Right_eye & ",'" & Remark & "'," & Total & "," & Advance & "," & Balance & ")")
            cmd.Connection = con
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            con.Close()

        End Try
    End Sub
End Class