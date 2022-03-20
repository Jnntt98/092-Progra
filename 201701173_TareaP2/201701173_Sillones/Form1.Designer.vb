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
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbDoble = New System.Windows.Forms.RadioButton()
        Me.RbIndividual = New System.Windows.Forms.RadioButton()
        Me.RbSofa = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbCuerina = New System.Windows.Forms.RadioButton()
        Me.RbCuero = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCuerina = New System.Windows.Forms.TextBox()
        Me.TxtCuero = New System.Windows.Forms.TextBox()
        Me.TxtNoVenta = New System.Windows.Forms.TextBox()
        Me.TxtVentarealizada = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Peru
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarDatosToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(847, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 26)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarDatosToolStripMenuItem
        '
        Me.LimpiarDatosToolStripMenuItem.Name = "LimpiarDatosToolStripMenuItem"
        Me.LimpiarDatosToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.LimpiarDatosToolStripMenuItem.Text = "Limpiar Datos"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RbDoble)
        Me.GroupBox1.Controls.Add(Me.RbIndividual)
        Me.GroupBox1.Controls.Add(Me.RbSofa)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 65)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'RbDoble
        '
        Me.RbDoble.AutoSize = True
        Me.RbDoble.BackColor = System.Drawing.Color.SeaShell
        Me.RbDoble.Location = New System.Drawing.Point(201, 30)
        Me.RbDoble.Name = "RbDoble"
        Me.RbDoble.Size = New System.Drawing.Size(66, 21)
        Me.RbDoble.TabIndex = 2
        Me.RbDoble.TabStop = True
        Me.RbDoble.Text = "Doble"
        Me.RbDoble.UseVisualStyleBackColor = False
        '
        'RbIndividual
        '
        Me.RbIndividual.AutoSize = True
        Me.RbIndividual.BackColor = System.Drawing.Color.SeaShell
        Me.RbIndividual.Location = New System.Drawing.Point(80, 30)
        Me.RbIndividual.Name = "RbIndividual"
        Me.RbIndividual.Size = New System.Drawing.Size(88, 21)
        Me.RbIndividual.TabIndex = 1
        Me.RbIndividual.TabStop = True
        Me.RbIndividual.Text = "Individual"
        Me.RbIndividual.UseVisualStyleBackColor = False
        '
        'RbSofa
        '
        Me.RbSofa.AutoSize = True
        Me.RbSofa.BackColor = System.Drawing.Color.SeaShell
        Me.RbSofa.Location = New System.Drawing.Point(6, 30)
        Me.RbSofa.Name = "RbSofa"
        Me.RbSofa.Size = New System.Drawing.Size(58, 21)
        Me.RbSofa.TabIndex = 0
        Me.RbSofa.TabStop = True
        Me.RbSofa.Text = "Sofá"
        Me.RbSofa.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RbCuerina)
        Me.GroupBox2.Controls.Add(Me.RbCuero)
        Me.GroupBox2.Location = New System.Drawing.Point(393, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 107)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de tela"
        '
        'RbCuerina
        '
        Me.RbCuerina.AutoSize = True
        Me.RbCuerina.BackColor = System.Drawing.Color.SeaShell
        Me.RbCuerina.Location = New System.Drawing.Point(6, 69)
        Me.RbCuerina.Name = "RbCuerina"
        Me.RbCuerina.Size = New System.Drawing.Size(78, 21)
        Me.RbCuerina.TabIndex = 1
        Me.RbCuerina.TabStop = True
        Me.RbCuerina.Text = "Cuerina"
        Me.RbCuerina.UseVisualStyleBackColor = False
        '
        'RbCuero
        '
        Me.RbCuero.AutoSize = True
        Me.RbCuero.BackColor = System.Drawing.Color.SeaShell
        Me.RbCuero.Location = New System.Drawing.Point(6, 30)
        Me.RbCuero.Name = "RbCuero"
        Me.RbCuero.Size = New System.Drawing.Size(67, 21)
        Me.RbCuero.TabIndex = 0
        Me.RbCuero.TabStop = True
        Me.RbCuero.Text = "Cuero"
        Me.RbCuero.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtCuerina)
        Me.GroupBox3.Controls.Add(Me.TxtCuero)
        Me.GroupBox3.Location = New System.Drawing.Point(552, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 107)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cantidad de Yardas"
        '
        'TxtCuerina
        '
        Me.TxtCuerina.Location = New System.Drawing.Point(31, 68)
        Me.TxtCuerina.Name = "TxtCuerina"
        Me.TxtCuerina.Size = New System.Drawing.Size(124, 22)
        Me.TxtCuerina.TabIndex = 1
        '
        'TxtCuero
        '
        Me.TxtCuero.Location = New System.Drawing.Point(31, 35)
        Me.TxtCuero.Name = "TxtCuero"
        Me.TxtCuero.Size = New System.Drawing.Size(124, 22)
        Me.TxtCuero.TabIndex = 0
        '
        'TxtNoVenta
        '
        Me.TxtNoVenta.Location = New System.Drawing.Point(178, 145)
        Me.TxtNoVenta.Name = "TxtNoVenta"
        Me.TxtNoVenta.Size = New System.Drawing.Size(163, 22)
        Me.TxtNoVenta.TabIndex = 5
        '
        'TxtVentarealizada
        '
        Me.TxtVentarealizada.AutoSize = True
        Me.TxtVentarealizada.BackColor = System.Drawing.Color.Transparent
        Me.TxtVentarealizada.Location = New System.Drawing.Point(46, 147)
        Me.TxtVentarealizada.Name = "TxtVentarealizada"
        Me.TxtVentarealizada.Size = New System.Drawing.Size(71, 17)
        Me.TxtVentarealizada.TabIndex = 6
        Me.TxtVentarealizada.Text = "No. Venta"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(807, 146)
        Me.DataGridView1.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. Venta"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tamaño"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tela"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Yardas"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Costo"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Venta"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(847, 343)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtVentarealizada)
        Me.Controls.Add(Me.TxtNoVenta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fábrica de Sillones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbDoble As RadioButton
    Friend WithEvents RbIndividual As RadioButton
    Friend WithEvents RbSofa As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbCuerina As RadioButton
    Friend WithEvents RbCuero As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCuerina As TextBox
    Friend WithEvents TxtCuero As TextBox
    Friend WithEvents TxtNoVenta As TextBox
    Friend WithEvents TxtVentarealizada As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
