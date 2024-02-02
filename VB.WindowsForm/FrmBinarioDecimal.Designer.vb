<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBinarioDecimal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TlpContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtVal = New System.Windows.Forms.TextBox()
        Me.LblVal = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.TlpContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlpContainer
        '
        Me.TlpContainer.ColumnCount = 2
        Me.TlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpContainer.Controls.Add(Me.TxtVal, 1, 0)
        Me.TlpContainer.Controls.Add(Me.LblVal, 0, 0)
        Me.TlpContainer.Controls.Add(Me.BtnCalc, 0, 1)
        Me.TlpContainer.Controls.Add(Me.BtnClose, 1, 1)
        Me.TlpContainer.Controls.Add(Me.LblResult, 0, 2)
        Me.TlpContainer.Controls.Add(Me.TxtResult, 1, 2)
        Me.TlpContainer.Location = New System.Drawing.Point(38, 38)
        Me.TlpContainer.Name = "TlpContainer"
        Me.TlpContainer.RowCount = 3
        Me.TlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpContainer.Size = New System.Drawing.Size(367, 157)
        Me.TlpContainer.TabIndex = 3
        '
        'TxtVal
        '
        Me.TxtVal.Location = New System.Drawing.Point(186, 3)
        Me.TxtVal.Name = "TxtVal"
        Me.TxtVal.Size = New System.Drawing.Size(100, 20)
        Me.TxtVal.TabIndex = 2
        '
        'LblVal
        '
        Me.LblVal.AutoSize = True
        Me.LblVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVal.Location = New System.Drawing.Point(3, 0)
        Me.LblVal.Name = "LblVal"
        Me.LblVal.Size = New System.Drawing.Size(41, 15)
        Me.LblVal.TabIndex = 0
        Me.LblVal.Text = "Binario"
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(3, 55)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalc.TabIndex = 4
        Me.BtnCalc.Text = "C&alcular"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(186, 55)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "&Cerrar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Location = New System.Drawing.Point(3, 104)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(45, 13)
        Me.LblResult.TabIndex = 6
        Me.LblResult.Text = "Decimal"
        '
        'TxtResult
        '
        Me.TxtResult.Location = New System.Drawing.Point(186, 107)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(100, 20)
        Me.TxtResult.TabIndex = 7
        '
        'FrmBinarioDecimal
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(449, 239)
        Me.Controls.Add(Me.TlpContainer)
        Me.Name = "FrmBinarioDecimal"
        Me.Text = "FrmBinarioDecimal"
        Me.TlpContainer.ResumeLayout(False)
        Me.TlpContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TlpContainer As TableLayoutPanel
    Friend WithEvents TxtVal As TextBox
    Friend WithEvents LblVal As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblResult As Label
    Friend WithEvents TxtResult As TextBox
End Class
