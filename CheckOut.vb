Public Class frmCheckOut

    Dim totCost As Double
    Public Sub setFinalItems(ByVal items As ListView)
        For Each item As ListViewItem In items.Items
            lvFinalItems.Items.Add(item.Clone())
        Next

        Dim LI As New ListViewItem
        LI.Text = "MiHoyo Festival Admission Fee"
        LI.SubItems.Add(Format(150, "currency"))
        LI.SubItems.Add(1)
        lvFinalItems.Items.Add(LI)


        For Each item As ListViewItem In lvFinalItems.Items
            totCost += item.SubItems(1).Text
        Next

        txtTotCost.Text = Format(totCost, "currency")
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrEmpty(txtPayment.Text) Then
            MsgBox("Please enter your payment!", MsgBoxStyle.Information, "MiHoyo Festival")
        Else
            Dim payment, finalCost As Double
            payment = Convert.ToInt32(txtPayment.Text)
            If rdCash.Checked = True Then
                finalCost = payment - totCost
            ElseIf rdCard.Checked = True Then
                Dim discountedCost As Double
                discountedCost = (payment - totCost) * 0.05
                finalCost = (payment - totCost) + discountedCost
            End If

            txtChange.Text = Format(finalCost, "currency")
            txtPayment.Text = Format(txtPayment.Text, "currency")
        End If
    End Sub
End Class