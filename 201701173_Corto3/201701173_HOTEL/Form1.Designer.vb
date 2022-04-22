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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.CbTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CálculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbTipoPago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CbTipoHabitacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtDias)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Location = New System.Drawing.Point(41, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(946, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(179, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 22)
        Me.txtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de huesped"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nit"
        '
        'TxtNit
        '
        Me.TxtNit.Location = New System.Drawing.Point(466, 38)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(143, 22)
        Me.TxtNit.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(629, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dias a hospedarse"
        '
        'TxtDias
        '
        Me.TxtDias.Location = New System.Drawing.Point(762, 38)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.Size = New System.Drawing.Size(89, 22)
        Me.TxtDias.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Seleccione tipo de habitación"
        '
        'CbTipoHabitacion
        '
        Me.CbTipoHabitacion.FormattingEnabled = True
        Me.CbTipoHabitacion.Items.AddRange(New Object() {"1. Sencilla", "2. Doble", "3. Cabaña"})
        Me.CbTipoHabitacion.Location = New System.Drawing.Point(234, 93)
        Me.CbTipoHabitacion.Name = "CbTipoHabitacion"
        Me.CbTipoHabitacion.Size = New System.Drawing.Size(142, 24)
        Me.CbTipoHabitacion.TabIndex = 7
        '
        'CbTipoPago
        '
        Me.CbTipoPago.FormattingEnabled = True
        Me.CbTipoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de crédito/débito", "Transferencia", "Depósito"})
        Me.CbTipoPago.Location = New System.Drawing.Point(514, 90)
        Me.CbTipoPago.Name = "CbTipoPago"
        Me.CbTipoPago.Size = New System.Drawing.Size(142, 24)
        Me.CbTipoPago.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de pago"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(951, 275)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Dias"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipo de Habitación"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo Pago"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total a Pagar"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Descuento/Recargo"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Khaki
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1025, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CálculoToolStripMenuItem
        '
        Me.CálculoToolStripMenuItem.Name = "CálculoToolStripMenuItem"
        Me.CálculoToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.CálculoToolStripMenuItem.Text = "Cálculo"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1025, 583)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLAYA DORADA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents CbTipoPago As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbTipoHabitacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CálculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
