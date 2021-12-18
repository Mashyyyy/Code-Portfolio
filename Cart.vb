Public Class frmCart

    Public Sub addItemToCart(ByVal item As String, ByVal cost As Double, ByVal quantity As Double)
        Dim LI As New ListViewItem
        LI.Text = item
        LI.SubItems.Add(Format(cost, "currency"))
        LI.SubItems.Add(quantity)
        lvCart.Items.Add(LI)
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim prompt As Byte
        prompt = MsgBox("Are you sure you want to check-out?", MsgBoxStyle.YesNo, "MiHoyo Festival")

        If prompt = vbYes Then
            frmCheckOut.Show()
            frmCheckOut.setFinalItems(lvCart)
        ElseIf prompt = vbNo Then
            'Do nothing
        End If
    End Sub
End Class