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
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtNitCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombrePelicula = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChBNormal = New System.Windows.Forms.CheckBox()
        Me.ChB3D = New System.Windows.Forms.CheckBox()
        Me.ChB4DX = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Khaki
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.SalirToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'TxtNitCliente
        '
        Me.TxtNitCliente.Location = New System.Drawing.Point(145, 18)
        Me.TxtNitCliente.Name = "TxtNitCliente"
        Me.TxtNitCliente.Size = New System.Drawing.Size(159, 22)
        Me.TxtNitCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nit del Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de Película"
        '
        'TxtNombrePelicula
        '
        Me.TxtNombrePelicula.Location = New System.Drawing.Point(484, 18)
        Me.TxtNombrePelicula.Name = "TxtNombrePelicula"
        Me.TxtNombrePelicula.Size = New System.Drawing.Size(268, 22)
        Me.TxtNombrePelicula.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ChB4DX)
        Me.GroupBox1.Controls.Add(Me.ChB3D)
        Me.GroupBox1.Controls.Add(Me.ChBNormal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNombrePelicula)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNitCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 123)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'ChBNormal
        '
        Me.ChBNormal.AutoSize = True
        Me.ChBNormal.Location = New System.Drawing.Point(19, 90)
        Me.ChBNormal.Name = "ChBNormal"
        Me.ChBNormal.Size = New System.Drawing.Size(75, 21)
        Me.ChBNormal.TabIndex = 5
        Me.ChBNormal.Text = "Normal"
        Me.ChBNormal.UseVisualStyleBackColor = True
        '
        'ChB3D
        '
        Me.ChB3D.AutoSize = True
        Me.ChB3D.Location = New System.Drawing.Point(201, 90)
        Me.ChB3D.Name = "ChB3D"
        Me.ChB3D.Size = New System.Drawing.Size(48, 21)
        Me.ChB3D.TabIndex = 6
        Me.ChB3D.Text = "3D"
        Me.ChB3D.UseVisualStyleBackColor = True
        '
        'ChB4DX
        '
        Me.ChB4DX.AutoSize = True
        Me.ChB4DX.Location = New System.Drawing.Point(392, 90)
        Me.ChB4DX.Name = "ChB4DX"
        Me.ChB4DX.Size = New System.Drawing.Size(57, 21)
        Me.ChB4DX.TabIndex = 7
        Me.ChB4DX.Text = "4DX"
        Me.ChB4DX.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Seleccione el tipo de sala"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(765, 284)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nit Cliente"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre Película"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Boletos Normal"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Boletos 3D"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Boletos 4DX"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(797, 531)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CINE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtNitCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombrePelicula As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ChB4DX As CheckBox
    Friend WithEvents ChB3D As CheckBox
    Friend WithEvents ChBNormal As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
End Class
