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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTablet = New System.Windows.Forms.RadioButton()
        Me.RbCelular = New System.Windows.Forms.RadioButton()
        Me.RbDrone = New System.Windows.Forms.RadioButton()
        Me.RbTelevisor = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbNombre = New System.Windows.Forms.ListBox()
        Me.LbSueldo = New System.Windows.Forms.ListBox()
        Me.LbComisión = New System.Windows.Forms.ListBox()
        Me.LbBonoIncentivo = New System.Windows.Forms.ListBox()
        Me.LbSueldoFinal = New System.Windows.Forms.ListBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtSalario)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label2.Location = New System.Drawing.Point(23, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salario"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(130, 36)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(214, 22)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtSalario
        '
        Me.TxtSalario.Location = New System.Drawing.Point(130, 75)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(127, 22)
        Me.TxtSalario.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.RbTelevisor)
        Me.GroupBox2.Controls.Add(Me.RbDrone)
        Me.GroupBox2.Controls.Add(Me.RbCelular)
        Me.GroupBox2.Controls.Add(Me.RbTablet)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 169)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Artículo"
        '
        'RbTablet
        '
        Me.RbTablet.AutoSize = True
        Me.RbTablet.BackColor = System.Drawing.Color.MediumTurquoise
        Me.RbTablet.Location = New System.Drawing.Point(19, 31)
        Me.RbTablet.Name = "RbTablet"
        Me.RbTablet.Size = New System.Drawing.Size(69, 21)
        Me.RbTablet.TabIndex = 0
        Me.RbTablet.TabStop = True
        Me.RbTablet.Text = "Tablet"
        Me.RbTablet.UseVisualStyleBackColor = False
        '
        'RbCelular
        '
        Me.RbCelular.AutoSize = True
        Me.RbCelular.BackColor = System.Drawing.Color.MediumTurquoise
        Me.RbCelular.Location = New System.Drawing.Point(19, 76)
        Me.RbCelular.Name = "RbCelular"
        Me.RbCelular.Size = New System.Drawing.Size(73, 21)
        Me.RbCelular.TabIndex = 1
        Me.RbCelular.TabStop = True
        Me.RbCelular.Text = "Celular"
        Me.RbCelular.UseVisualStyleBackColor = False
        '
        'RbDrone
        '
        Me.RbDrone.AutoSize = True
        Me.RbDrone.BackColor = System.Drawing.Color.MediumTurquoise
        Me.RbDrone.Location = New System.Drawing.Point(198, 31)
        Me.RbDrone.Name = "RbDrone"
        Me.RbDrone.Size = New System.Drawing.Size(68, 21)
        Me.RbDrone.TabIndex = 2
        Me.RbDrone.TabStop = True
        Me.RbDrone.Text = "Drone"
        Me.RbDrone.UseVisualStyleBackColor = False
        '
        'RbTelevisor
        '
        Me.RbTelevisor.AutoSize = True
        Me.RbTelevisor.BackColor = System.Drawing.Color.MediumTurquoise
        Me.RbTelevisor.Location = New System.Drawing.Point(198, 76)
        Me.RbTelevisor.Name = "RbTelevisor"
        Me.RbTelevisor.Size = New System.Drawing.Size(87, 21)
        Me.RbTelevisor.TabIndex = 3
        Me.RbTelevisor.TabStop = True
        Me.RbTelevisor.Text = "Televisor"
        Me.RbTelevisor.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
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
        'LbNombre
        '
        Me.LbNombre.FormattingEnabled = True
        Me.LbNombre.ItemHeight = 16
        Me.LbNombre.Location = New System.Drawing.Point(36, 229)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(106, 180)
        Me.LbNombre.TabIndex = 6
        '
        'LbSueldo
        '
        Me.LbSueldo.FormattingEnabled = True
        Me.LbSueldo.ItemHeight = 16
        Me.LbSueldo.Location = New System.Drawing.Point(163, 229)
        Me.LbSueldo.Name = "LbSueldo"
        Me.LbSueldo.Size = New System.Drawing.Size(106, 180)
        Me.LbSueldo.TabIndex = 7
        '
        'LbComisión
        '
        Me.LbComisión.FormattingEnabled = True
        Me.LbComisión.ItemHeight = 16
        Me.LbComisión.Location = New System.Drawing.Point(309, 229)
        Me.LbComisión.Name = "LbComisión"
        Me.LbComisión.Size = New System.Drawing.Size(106, 180)
        Me.LbComisión.TabIndex = 8
        '
        'LbBonoIncentivo
        '
        Me.LbBonoIncentivo.FormattingEnabled = True
        Me.LbBonoIncentivo.ItemHeight = 16
        Me.LbBonoIncentivo.Location = New System.Drawing.Point(444, 229)
        Me.LbBonoIncentivo.Name = "LbBonoIncentivo"
        Me.LbBonoIncentivo.Size = New System.Drawing.Size(106, 180)
        Me.LbBonoIncentivo.TabIndex = 9
        '
        'LbSueldoFinal
        '
        Me.LbSueldoFinal.FormattingEnabled = True
        Me.LbSueldoFinal.ItemHeight = 16
        Me.LbSueldoFinal.Location = New System.Drawing.Point(606, 229)
        Me.LbSueldoFinal.Name = "LbSueldoFinal"
        Me.LbSueldoFinal.Size = New System.Drawing.Size(106, 180)
        Me.LbSueldoFinal.TabIndex = 10
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(130, 125)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(97, 22)
        Me.TxtCantidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(23, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(723, 419)
        Me.Controls.Add(Me.LbSueldoFinal)
        Me.Controls.Add(Me.LbBonoIncentivo)
        Me.Controls.Add(Me.LbComisión)
        Me.Controls.Add(Me.LbSueldo)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Comunicaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbTelevisor As RadioButton
    Friend WithEvents RbDrone As RadioButton
    Friend WithEvents RbCelular As RadioButton
    Friend WithEvents RbTablet As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbNombre As ListBox
    Friend WithEvents LbSueldo As ListBox
    Friend WithEvents LbComisión As ListBox
    Friend WithEvents LbBonoIncentivo As ListBox
    Friend WithEvents LbSueldoFinal As ListBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label3 As Label
End Class
