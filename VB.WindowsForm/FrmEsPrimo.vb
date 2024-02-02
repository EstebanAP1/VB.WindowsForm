Imports OperacionVB.Matematica

Public Class FrmEsPrimo
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim n As Integer

        If String.IsNullOrWhiteSpace(TxtVal.Text) Then
            MessageBox.Show("Ingrese un número.")
            TxtVal.Focus()
            Return
        End If

        If Integer.TryParse(TxtVal.Text, n) Then
            If EsPrimo(n) Then
                TxtResult.Text = "Es primo"
            Else
                TxtResult.Text = "No es primo"
            End If
        Else
            MessageBox.Show("Debe ingresar un número entero.")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class