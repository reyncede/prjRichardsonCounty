Public Class frmMain

    'TAX value $1.50
    Private ReadOnly TAX As Double = 1.5

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Get Value of Assessed Value Input
        Dim assessedValue As Double = Val(txtAssessedValue.Text)
        'Count how many $100 in the Value
        Dim numTax As Integer = assessedValue \ 100
        'Get the tax for each $100 in the value
        Dim propertyTax As Double = TAX * numTax
        txtPropertyTax.Text = Format(propertyTax, "$#,##0.00")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        toggleUI(False)
        PrintForm1.Print()
        toggleUI(True)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAssessedValue.Clear()
        txtPropertyTax.Clear()
        txtAssessedValue.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub toggleUI(b As Boolean)
        btnCalculate.Visible = b
        btnPrint.Visible = b
        btnClear.Visible = b
        btnExit.Visible = b
    End Sub

End Class





'CTTO Rey Nuel G. Recede