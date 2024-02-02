Public Class FrmMain
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub HipotenusaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HipotenusaToolStripMenuItem.Click
        Dim form As New FrmHipotenusa With {.MdiParent = Me}
        form.Show()
    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EToolStripMenuItem.Click
        Dim form As New FrmEsPrimo With {.MdiParent = Me}
        form.Show()
    End Sub

    Private Sub DecimalBinarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecimalBinarioToolStripMenuItem.Click
        Dim form As New FrmDecimalBinario With {.MdiParent = Me}
        form.Show()
    End Sub

    Private Sub BinarioDecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinarioDecimalToolStripMenuItem.Click
        Dim form As New FrmBinarioDecimal With {.MdiParent = Me}
        form.Show()
    End Sub

    Private Sub FactorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FactorialToolStripMenuItem.Click
        Dim form As New FrmFactorial With {.MdiParent = Me}
        form.Show()
    End Sub
End Class