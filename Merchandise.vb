Public Class frmMerch
#Region "All Merchandise"
    Private Sub merchItem1_Click(sender As Object, e As EventArgs) Handles merchItem1.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?" + vbNewLine + "HoYoFest Official Event Picture", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("HoYoFest Official Event Picture", (150 * qty), qty)
        End If
    End Sub

    Private Sub merchItem2_Click(sender As Object, e As EventArgs) Handles merchItem2.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?" + vbNewLine + "Fu Hua Nendoroid", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Fua Hua Nendoroid", (350 * qty), qty)
        End If
    End Sub

    Private Sub merchItem3_Click(sender As Object, e As EventArgs) Handles merchItem3.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?" + vbNewLine + "Bronya Nendoroid", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Bronya Nendoroid", (350 * qty), qty)
        End If
    End Sub

    Private Sub merchItem4_Click(sender As Object, e As EventArgs) Handles merchItem4.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?" + vbNewLine + "Genshin Impact Character Pin", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Genshin Impact Character Pin", (100 * qty), qty)
        End If
    End Sub

    Private Sub merchItem5_Click(sender As Object, e As EventArgs) Handles merchItem5.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?" + vbNewLine + "Honkai Special Acrylic Models", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Honkai Special Acrylic Models", (600 * qty), qty)
        End If
    End Sub

    Private Sub merchItem6_Click(sender As Object, e As EventArgs) Handles merchItem6.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?" + vbNewLine + "Honkai Featured Acrylic Models", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Honkai Featured Acrylic Models", (450 * qty), qty)
        End If
    End Sub
#End Region
    Private Sub calculateCost(ByVal menuName As String, ByVal menuCost As Double, ByVal menuQty As Double)
        frmCart.addItemToCart(menuName, menuCost, menuQty)
    End Sub
End Class