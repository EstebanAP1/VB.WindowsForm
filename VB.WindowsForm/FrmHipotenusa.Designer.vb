<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHipotenusa
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
        Me.LblVal2 = New System.Windows.Forms.Label()
        Me.TxtVal1 = New System.Windows.Forms.TextBox()
        Me.TxtVal2 = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.LblVal1 = New System.Windows.Forms.Label()
        Me.TlpContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlpContainer
        '
        Me.TlpContainer.ColumnCount = 2
        Me.TlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpContainer.Controls.Add(Me.LblVal2, 0, 1)
        Me.TlpContainer.Controls.Add(Me.TxtVal1, 1, 0)
        Me.TlpContainer.Controls.Add(Me.TxtVal2, 1, 1)
        Me.TlpContainer.Controls.Add(Me.BtnCalc, 0, 2)
        Me.TlpContainer.Controls.Add(Me.BtnClose, 1, 2)
        Me.TlpContainer.Controls.Add(Me.LblResult, 0, 3)
        Me.TlpContainer.Controls.Add(Me.TxtResult, 1, 3)
        Me.TlpContainer.Controls.Add(Me.LblVal1, 0, 0)
        Me.TlpContainer.Location = New System.Drawing.Point(39, 32)
        Me.TlpContainer.Name = "TlpContainer"
        Me.TlpContainer.RowCount = 4
        Me.TlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpContainer.Size = New System.Drawing.Size(434, 173)
        Me.TlpContainer.TabIndex = 0
        '
        'LblVal2
        '
        Me.LblVal2.AutoSize = True
        Me.LblVal2.Location = New System.Drawing.Point(3, 43)
        Me.LblVal2.Name = "LblVal2"
        Me.LblVal2.Size = New System.Drawing.Size(48, 13)
        Me.LblVal2.TabIndex = 1
        Me.LblVal2.Text = "Cateto B"
        '
        'TxtVal1
        '
        Me.TxtVal1.Location = New System.Drawing.Point(220, 3)
        Me.TxtVal1.Name = "TxtVal1"
        Me.TxtVal1.Size = New System.Drawing.Size(100, 20)
        Me.TxtVal1.TabIndex = 2
        '
        'TxtVal2
        '
        Me.TxtVal2.Location = New System.Drawing.Point(220, 46)
        Me.TxtVal2.Name = "TxtVal2"
        Me.TxtVal2.Size = New System.Drawing.Size(100, 20)
        Me.TxtVal2.TabIndex = 3
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(3, 89)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalc.TabIndex = 4
        Me.BtnCalc.Text = "C&alcular"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(220, 89)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "&Cerrar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Location = New System.Drawing.Point(3, 129)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(55, 13)
        Me.LblResult.TabIndex = 6
        Me.LblResult.Text = "Resultado"
        '
        'TxtResult
        '
        Me.TxtResult.Location = New System.Drawing.Point(220, 132)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(100, 20)
        Me.TxtResult.TabIndex = 7
        '
        'LblVal1
        '
        Me.LblVal1.AutoSize = True
        Me.LblVal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVal1.Location = New System.Drawing.Point(3, 0)
        Me.LblVal1.Name = "LblVal1"
        Me.LblVal1.Size = New System.Drawing.Size(50, 15)
        Me.LblVal1.TabIndex = 0
        Me.LblVal1.Text = "Cateto A"
        '
        'FrmHipotenusa
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(508, 243)
        Me.Controls.Add(Me.TlpContainer)
        Me.Name = "FrmHipotenusa"
        Me.Text = "FrmHipotenusa"
        Me.TlpContainer.ResumeLayout(False)
        Me.TlpContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TlpContainer As TableLayoutPanel
    Friend WithEvents LblVal1 As Label
    Friend WithEvents LblVal2 As Label
    Friend WithEvents TxtVal1 As TextBox
    Friend WithEvents TxtVal2 As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblResult As Label
    Friend WithEvents TxtResult As TextBox
End Class
