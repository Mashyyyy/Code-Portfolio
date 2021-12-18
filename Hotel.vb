Public Class frmHotel

    Public days As Long
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        days = 1 + DateDiff("d", dpCheckIn.Value, dpCheckOut.Value)
        If rdDeluxe.Checked = True Then
            If cbType.SelectedIndex >= 0 Then
                addToCart("Deluxe Bedroom | Single", (300 * days), 1)
            ElseIf cbType.SelectedIndex = 1 Then
                addToCart("Deluxe Bedroom | Double", (500 * days), 1)
            ElseIf cbType.SelectedIndex = 2 Then
                addToCart("Deluxe Bedroom | Family", (750 * days), 1)
            Else
                MsgBox("Please Select Room Size!", MsgBoxStyle.Information, "MiHoyo Festival")
            End If
        ElseIf rdRegular.Checked = True Then
            If cbType.SelectedIndex >= 0 Then
                addToCart("Regular Bedroom | Single", (100 * days), 1)
            ElseIf cbType.SelectedIndex = 1 Then
                addToCart("Regular Bedroom | Double", (200 * days), 1)
            ElseIf cbType.SelectedIndex = 2 Then
                addToCart("Regular Bedroom | Family", (500 * days), 1)
            Else
                MsgBox("Please Select Room Size!", MsgBoxStyle.Information, "MiHoyo Festival")
            End If
        ElseIf rdSuite.Checked = True Then
            If cbType.SelectedIndex >= 0 Then
                addToCart("Suite Bedroom | Single", (500 * days), 1)
            ElseIf cbType.SelectedIndex = 1 Then
                addToCart("Suite Bedroom | Double", (800 * days), 1)
            ElseIf cbType.SelectedIndex = 2 Then
                addToCart("Suite Bedroom | Family", (1000 * days), 1)
            Else
                MsgBox("Please Select Room Size!", MsgBoxStyle.Information, "MiHoyo Festival")
            End If
        Else
            MsgBox("Please Select Room Type!", MsgBoxStyle.Information, "MiHoyo Festival")
        End If
    End Sub

    Private Sub dpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dpCheckIn.ValueChanged
        days = 1 + DateDiff("d", dpCheckIn.Value, dpCheckOut.Value)
        txtDays.Text = days.ToString()
    End Sub

    Private Sub dpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dpCheckOut.ValueChanged
        Dim days As Long = 1 + DateDiff("d", dpCheckIn.Value, dpCheckOut.Value)
        txtDays.Text = days.ToString()
    End Sub


    Private Sub addToCart(ByVal item As String, ByVal cost As Double, ByVal qty As Double)
        frmCart.addItemToCart(item, cost, qty)
    End Sub
End Class