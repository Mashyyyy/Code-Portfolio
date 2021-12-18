Public Class frmLandingPage
    Private Sub frmLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCart.TopLevel = False
        frmCart.TopMost = True
        Me.pnCart.Controls.Add(frmCart)
        frmCart.Show()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblDateTime.Text = Format(Now, "General Date")
    End Sub

    Private Sub lblCafe_Click(sender As Object, e As EventArgs) Handles lblCafe.Click
        frmCafe.Show()
    End Sub

    Private Sub lblMerch_Click(sender As Object, e As EventArgs) Handles lblMerch.Click
        frmMerch.Show()
    End Sub

    Private Sub lblHotel_Click(sender As Object, e As EventArgs) Handles lblHotel.Click
        frmHotel.Show()
    End Sub
End Class
