Public Class FrmDecimalBinario
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim n As Integer

        If String.IsNullOrWhiteSpace(TxtVal.Text) Then
            MessageBox.Show("Ingrese un número entero.")
            TxtVal.Focus()
            Return
        End If

        If Integer.TryParse(TxtVal.Text, n) Then
            TxtResult.Text = Convert.ToString(n, 2)
        Else
            MessageBox.Show("Debe ingresar un número entero.")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class