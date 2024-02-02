Public Class FrmBinarioDecimal
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim n As Integer

        If String.IsNullOrWhiteSpace(TxtVal.Text) Then
            MessageBox.Show("Ingrese un número binario.")
            TxtVal.Focus()
            Return
        End If

        If Not TxtVal.Text.All(Function(c) c = "0"c Or c = "1"c) Then
            MessageBox.Show("Debe ingresar un número binario.")
            Return
        End If

        TxtResult.Text = Convert.ToInt32(TxtVal.Text, 2).ToString()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class