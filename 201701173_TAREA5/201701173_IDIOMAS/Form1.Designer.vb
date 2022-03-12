<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCarnet = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbCheque = New System.Windows.Forms.RadioButton()
        Me.RbEfectivo = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChBxSabado = New System.Windows.Forms.CheckBox()
        Me.ChBxViernes = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBxIdioma = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Carnét = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estudiante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idioma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoParcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaLPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtCarnet)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'TxtCarnet
        '
        Me.TxtCarnet.Location = New System.Drawing.Point(141, 64)
        Me.TxtCarnet.Name = "TxtCarnet"
        Me.TxtCarnet.Size = New System.Drawing.Size(135, 22)
        Me.TxtCarnet.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(141, 25)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(172, 22)
        Me.TxtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Carnet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Estudiante"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RbCheque)
        Me.GroupBox2.Controls.Add(Me.RbEfectivo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ChBxSabado)
        Me.GroupBox2.Controls.Add(Me.ChBxViernes)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CBxIdioma)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(597, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 167)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresos"
        '
        'RbCheque
        '
        Me.RbCheque.AutoSize = True
        Me.RbCheque.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RbCheque.Location = New System.Drawing.Point(213, 142)
        Me.RbCheque.Name = "RbCheque"
        Me.RbCheque.Size = New System.Drawing.Size(78, 21)
        Me.RbCheque.TabIndex = 7
        Me.RbCheque.TabStop = True
        Me.RbCheque.Text = "Cheque"
        Me.RbCheque.UseVisualStyleBackColor = False
        '
        'RbEfectivo
        '
        Me.RbEfectivo.AutoSize = True
        Me.RbEfectivo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RbEfectivo.Location = New System.Drawing.Point(42, 142)
        Me.RbEfectivo.Name = "RbEfectivo"
        Me.RbEfectivo.Size = New System.Drawing.Size(79, 21)
        Me.RbEfectivo.TabIndex = 6
        Me.RbEfectivo.TabStop = True
        Me.RbEfectivo.Text = "Efectivo"
        Me.RbEfectivo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Location = New System.Drawing.Point(6, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Forma de pago"
        '
        'ChBxSabado
        '
        Me.ChBxSabado.AutoSize = True
        Me.ChBxSabado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ChBxSabado.Location = New System.Drawing.Point(213, 88)
        Me.ChBxSabado.Name = "ChBxSabado"
        Me.ChBxSabado.Size = New System.Drawing.Size(79, 21)
        Me.ChBxSabado.TabIndex = 4
        Me.ChBxSabado.Text = "Sábado"
        Me.ChBxSabado.UseVisualStyleBackColor = False
        '
        'ChBxViernes
        '
        Me.ChBxViernes.AutoSize = True
        Me.ChBxViernes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ChBxViernes.Location = New System.Drawing.Point(42, 88)
        Me.ChBxViernes.Name = "ChBxViernes"
        Me.ChBxViernes.Size = New System.Drawing.Size(78, 21)
        Me.ChBxViernes.TabIndex = 3
        Me.ChBxViernes.Text = "Viernes"
        Me.ChBxViernes.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Seleccione dias de clase"
        '
        'CBxIdioma
        '
        Me.CBxIdioma.FormattingEnabled = True
        Me.CBxIdioma.Items.AddRange(New Object() {"Inglés", "Portugués", "Francés"})
        Me.CBxIdioma.Location = New System.Drawing.Point(169, 23)
        Me.CBxIdioma.Name = "CBxIdioma"
        Me.CBxIdioma.Size = New System.Drawing.Size(129, 24)
        Me.CBxIdioma.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seleccione Idioma"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1159, 147)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Ingresados"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Carnét, Me.Estudiante, Me.Idioma, Me.Dias, Me.Horas, Me.PagoTotal, Me.PagoParcial, Me.Descuento, Me.Descuento2, Me.TotaLPagar})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1139, 102)
        Me.DataGridView1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(84, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(319, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Carnét
        '
        Me.Carnét.HeaderText = "Carnét"
        Me.Carnét.MinimumWidth = 6
        Me.Carnét.Name = "Carnét"
        Me.Carnét.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Carnét.Width = 125
        '
        'Estudiante
        '
        Me.Estudiante.HeaderText = "Estudiante"
        Me.Estudiante.MinimumWidth = 6
        Me.Estudiante.Name = "Estudiante"
        Me.Estudiante.Width = 130
        '
        'Idioma
        '
        Me.Idioma.HeaderText = "Idioma"
        Me.Idioma.MinimumWidth = 6
        Me.Idioma.Name = "Idioma"
        Me.Idioma.Width = 90
        '
        'Dias
        '
        Me.Dias.HeaderText = "Dias"
        Me.Dias.MinimumWidth = 6
        Me.Dias.Name = "Dias"
        Me.Dias.Width = 60
        '
        'Horas
        '
        Me.Horas.HeaderText = "Horas"
        Me.Horas.MinimumWidth = 6
        Me.Horas.Name = "Horas"
        Me.Horas.Width = 80
        '
        'PagoTotal
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PagoTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.PagoTotal.HeaderText = "Pago Total"
        Me.PagoTotal.MinimumWidth = 6
        Me.PagoTotal.Name = "PagoTotal"
        Me.PagoTotal.Width = 125
        '
        'PagoParcial
        '
        Me.PagoParcial.HeaderText = "Pago Parcial"
        Me.PagoParcial.MinimumWidth = 6
        Me.PagoParcial.Name = "PagoParcial"
        Me.PagoParcial.Width = 125
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.MinimumWidth = 6
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Width = 125
        '
        'Descuento2
        '
        Me.Descuento2.HeaderText = "Descuento 2"
        Me.Descuento2.MinimumWidth = 6
        Me.Descuento2.Name = "Descuento2"
        Me.Descuento2.Width = 125
        '
        'TotaLPagar
        '
        Me.TotaLPagar.HeaderText = "Total a Pagar"
        Me.TotaLPagar.MinimumWidth = 6
        Me.TotaLPagar.Name = "TotaLPagar"
        Me.TotaLPagar.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1177, 399)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Cursos Libres"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCarnet As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBxIdioma As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RbCheque As RadioButton
    Friend WithEvents RbEfectivo As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ChBxSabado As CheckBox
    Friend WithEvents ChBxViernes As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Carnét As DataGridViewTextBoxColumn
    Friend WithEvents Estudiante As DataGridViewTextBoxColumn
    Friend WithEvents Idioma As DataGridViewTextBoxColumn
    Friend WithEvents Dias As DataGridViewTextBoxColumn
    Friend WithEvents Horas As DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As DataGridViewTextBoxColumn
    Friend WithEvents PagoParcial As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Descuento2 As DataGridViewTextBoxColumn
    Friend WithEvents TotaLPagar As DataGridViewTextBoxColumn
End Class
