Public Class frmLoadingfirstform

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmLoadingfirstform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        Dim ofd As New OpenFileDialog
        ofd.Filter = "bild offnen (*.png) |*.png |ALL Files |*.*"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            frmLogin.Show()
            Me.Hide()
            Timer1.Stop()

        End If

    End Sub
End Class