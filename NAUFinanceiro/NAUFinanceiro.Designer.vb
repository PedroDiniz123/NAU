<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NAUFinanceiro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataPicker = New System.Windows.Forms.DateTimePicker()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblRazao = New System.Windows.Forms.Label()
        Me.lblSetor = New System.Windows.Forms.Label()
        Me.txtRazao = New System.Windows.Forms.TextBox()
        Me.lblSaida = New System.Windows.Forms.Label()
        Me.txtSaida = New System.Windows.Forms.TextBox()
        Me.boxSetor = New System.Windows.Forms.ComboBox()
        Me.btnPronto = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAU"
        '
        'dataPicker
        '
        Me.dataPicker.Location = New System.Drawing.Point(155, 100)
        Me.dataPicker.Name = "dataPicker"
        Me.dataPicker.Size = New System.Drawing.Size(300, 20)
        Me.dataPicker.TabIndex = 1
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(41, 100)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(48, 20)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data:"
        '
        'lblRazao
        '
        Me.lblRazao.AutoSize = True
        Me.lblRazao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazao.Location = New System.Drawing.Point(41, 134)
        Me.lblRazao.Name = "lblRazao"
        Me.lblRazao.Size = New System.Drawing.Size(107, 20)
        Me.lblRazao.TabIndex = 2
        Me.lblRazao.Text = "Razão Social:"
        '
        'lblSetor
        '
        Me.lblSetor.AutoSize = True
        Me.lblSetor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetor.Location = New System.Drawing.Point(41, 169)
        Me.lblSetor.Name = "lblSetor"
        Me.lblSetor.Size = New System.Drawing.Size(52, 20)
        Me.lblSetor.TabIndex = 2
        Me.lblSetor.Text = "Setor:"
        '
        'txtRazao
        '
        Me.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazao.Location = New System.Drawing.Point(155, 133)
        Me.txtRazao.Name = "txtRazao"
        Me.txtRazao.Size = New System.Drawing.Size(300, 20)
        Me.txtRazao.TabIndex = 3
        '
        'lblSaida
        '
        Me.lblSaida.AutoSize = True
        Me.lblSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida.Location = New System.Drawing.Point(41, 208)
        Me.lblSaida.Name = "lblSaida"
        Me.lblSaida.Size = New System.Drawing.Size(95, 20)
        Me.lblSaida.TabIndex = 2
        Me.lblSaida.Text = "Valor Saída:"
        '
        'txtSaida
        '
        Me.txtSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaida.Location = New System.Drawing.Point(155, 210)
        Me.txtSaida.Name = "txtSaida"
        Me.txtSaida.Size = New System.Drawing.Size(300, 20)
        Me.txtSaida.TabIndex = 3
        '
        'boxSetor
        '
        Me.boxSetor.FormattingEnabled = True
        Me.boxSetor.Items.AddRange(New Object() {"Teste 1", "Teste 2"})
        Me.boxSetor.Location = New System.Drawing.Point(155, 171)
        Me.boxSetor.Name = "boxSetor"
        Me.boxSetor.Size = New System.Drawing.Size(300, 21)
        Me.boxSetor.TabIndex = 4
        '
        'btnPronto
        '
        Me.btnPronto.Location = New System.Drawing.Point(325, 378)
        Me.btnPronto.Name = "btnPronto"
        Me.btnPronto.Size = New System.Drawing.Size(130, 35)
        Me.btnPronto.TabIndex = 5
        Me.btnPronto.Text = "Pronto"
        Me.btnPronto.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(480, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(308, 280)
        Me.DataGridView1.TabIndex = 6
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(476, 100)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(63, 20)
        Me.lblBuscar.TabIndex = 2
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Location = New System.Drawing.Point(545, 100)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(243, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'NAUFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPronto)
        Me.Controls.Add(Me.boxSetor)
        Me.Controls.Add(Me.txtSaida)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtRazao)
        Me.Controls.Add(Me.lblSaida)
        Me.Controls.Add(Me.lblSetor)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblRazao)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.dataPicker)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NAUFinanceiro"
        Me.Text = "NAU Financeiro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dataPicker As DateTimePicker
    Friend WithEvents lblData As Label
    Friend WithEvents lblRazao As Label
    Friend WithEvents lblSetor As Label
    Friend WithEvents txtRazao As TextBox
    Friend WithEvents lblSaida As Label
    Friend WithEvents txtSaida As TextBox
    Friend WithEvents boxSetor As ComboBox
    Friend WithEvents btnPronto As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
End Class
