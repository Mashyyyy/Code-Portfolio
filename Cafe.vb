Public Class frmCafe

#Region "ALL CAFE MENU ITEMS"
    Private Sub menuFood1_Click(sender As Object, e As EventArgs) Handles menuFood1.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Chicken Claypot Rice", (450 * qty), qty)
        End If
    End Sub

    Private Sub menuFood2_Click(sender As Object, e As EventArgs) Handles menuFood2.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Sliced Beef + Rice", (450 * qty), qty)
        End If
    End Sub

    Private Sub menuFood3_Click(sender As Object, e As EventArgs) Handles menuFood3.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Orange Spareribs + Rice", (450 * qty), qty)
        End If
    End Sub

#Region "Drinks"
    Private Sub menuDrink1_Click(sender As Object, e As EventArgs) Handles menuDrink1.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Café Latte", (100 * qty), qty)
        End If
    End Sub

    Private Sub menuDrink2_Click(sender As Object, e As EventArgs) Handles menuDrink2.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Americano", (100 * qty), qty)
        End If
    End Sub

    Private Sub menuDrink3_Click(sender As Object, e As EventArgs) Handles menuDrink3.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Capuccino", (100 * qty), qty)
        End If
    End Sub

    Private Sub menuDrink4_Click(sender As Object, e As EventArgs) Handles menuDrink4.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Espresso", (100 * qty), qty)
        End If
    End Sub

    Private Sub menuDrink5_Click(sender As Object, e As EventArgs) Handles menuDrink5.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Café Mocha", (100 * qty), qty)
        End If
    End Sub

    Private Sub menuDrink6_Click(sender As Object, e As EventArgs) Handles menuDrink6.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Iced Chocolate", (100 * qty), qty)
        End If
    End Sub

    Private Sub menuDrink7_Click(sender As Object, e As EventArgs) Handles menuDrink7.Click
        Dim qty As Double
        Dim prompt As Double
        prompt = InputBox("How many would you like?", "MiHoyo Festival Cafe", vbOKCancel)
        Convert.ToInt32(prompt)
        qty = prompt
        If qty >= 1 Then
            calculateCost("Hazelnut / Caramel Latte", (100 * qty), qty)
        End If
    End Sub
#End Region
#End Region
    Private Sub calculateCost(ByVal menuName As String, ByVal menuCost As Double, ByVal menuQty As Double)
        frmCart.addItemToCart(menuName, menuCost, menuQty)
    End Sub
End Class