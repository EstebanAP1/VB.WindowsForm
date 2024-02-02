Imports OperacionVB.Matematica

Public Class FrmHipotenusa
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim ca, cn, h As Double

        If String.IsNullOrWhiteSpace(TxtVal1.Text) Then
            MessageBox.Show("Ingrese el valor del cateto adyacente.")
            TxtVal1.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TxtVal2.Text) Then
            MessageBox.Show("Ingrese el valor del cateto opuesto.")
            TxtVal2.Focus()
            Return
        End If

        If Double.TryParse(TxtVal1.Text, ca) And Double.TryParse(TxtVal2.Text, cn) Then
            h = Hipotenusa(ca, cn)
            TxtResult.Text = h.ToString()
        Else
            MessageBox.Show("Debe ingresar valores numéricos.")
        End If
    End Sub
End Class