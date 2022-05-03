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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarAscendenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtKmRecorridos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTiempo = New System.Windows.Forms.TextBox()
        Me.CbEtapa = New System.Windows.Forms.ComboBox()
        Me.CbEquipo = New System.Windows.Forms.ComboBox()
        Me.CbNacionalidad = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.OrdenarAscendenteToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(812, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.GuardarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'OrdenarAscendenteToolStripMenuItem
        '
        Me.OrdenarAscendenteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OrdenarAscendenteToolStripMenuItem.Name = "OrdenarAscendenteToolStripMenuItem"
        Me.OrdenarAscendenteToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.OrdenarAscendenteToolStripMenuItem.Text = "Ordenar Ascendente"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar vectores"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(76, 57)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(157, 22)
        Me.TxtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(261, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Etapa"
        '
        'TxtKmRecorridos
        '
        Me.TxtKmRecorridos.Location = New System.Drawing.Point(165, 119)
        Me.TxtKmRecorridos.Name = "TxtKmRecorridos"
        Me.TxtKmRecorridos.Size = New System.Drawing.Size(77, 22)
        Me.TxtKmRecorridos.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(523, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Equipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kilometros Recorridos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(306, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tiempo (min)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(523, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nacionalidad"
        '
        'TxtTiempo
        '
        Me.TxtTiempo.Location = New System.Drawing.Point(403, 122)
        Me.TxtTiempo.Name = "TxtTiempo"
        Me.TxtTiempo.Size = New System.Drawing.Size(77, 22)
        Me.TxtTiempo.TabIndex = 9
        '
        'CbEtapa
        '
        Me.CbEtapa.FormattingEnabled = True
        Me.CbEtapa.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CbEtapa.Location = New System.Drawing.Point(309, 57)
        Me.CbEtapa.Name = "CbEtapa"
        Me.CbEtapa.Size = New System.Drawing.Size(163, 24)
        Me.CbEtapa.TabIndex = 10
        '
        'CbEquipo
        '
        Me.CbEquipo.FormattingEnabled = True
        Me.CbEquipo.Items.AddRange(New Object() {"Sky", "Movistar", "Pro Cycling", "Pro Team"})
        Me.CbEquipo.Location = New System.Drawing.Point(581, 62)
        Me.CbEquipo.Name = "CbEquipo"
        Me.CbEquipo.Size = New System.Drawing.Size(163, 24)
        Me.CbEquipo.TabIndex = 11
        '
        'CbNacionalidad
        '
        Me.CbNacionalidad.FormattingEnabled = True
        Me.CbNacionalidad.Items.AddRange(New Object() {"Guatemalteco", "Extranjero"})
        Me.CbNacionalidad.Location = New System.Drawing.Point(619, 120)
        Me.CbNacionalidad.Name = "CbNacionalidad"
        Me.CbNacionalidad.Size = New System.Drawing.Size(163, 24)
        Me.CbNacionalidad.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 165)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(787, 252)
        Me.DataGridView1.TabIndex = 13
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
        Me.Column2.HeaderText = "Etapa"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Equipo"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Km Recorridos"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tiempo"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Penalización"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(812, 421)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CbNacionalidad)
        Me.Controls.Add(Me.CbEquipo)
        Me.Controls.Add(Me.CbEtapa)
        Me.Controls.Add(Me.TxtTiempo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtKmRecorridos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Vuelta Ciclistica"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarAscendenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtKmRecorridos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTiempo As TextBox
    Friend WithEvents CbEtapa As ComboBox
    Friend WithEvents CbEquipo As ComboBox
    Friend WithEvents CbNacionalidad As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
