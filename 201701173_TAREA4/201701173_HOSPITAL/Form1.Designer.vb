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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDias = New System.Windows.Forms.TextBox()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.CBxHabitación = New System.Windows.Forms.ComboBox()
        Me.CBxServicio = New System.Windows.Forms.ComboBox()
        Me.CbxTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBxTotal = New System.Windows.Forms.ListBox()
        Me.LBxRecargo = New System.Windows.Forms.ListBox()
        Me.LBxDescuento = New System.Windows.Forms.ListBox()
        Me.LBxSubtotal = New System.Windows.Forms.ListBox()
        Me.LBxDias = New System.Windows.Forms.ListBox()
        Me.LBxTipoPago = New System.Windows.Forms.ListBox()
        Me.LBxServicio = New System.Windows.Forms.ListBox()
        Me.LBxHabitacion = New System.Windows.Forms.ListBox()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.LimpiarEntradaToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(797, 28)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'LimpiarEntradaToolStripMenuItem
        '
        Me.LimpiarEntradaToolStripMenuItem.Name = "LimpiarEntradaToolStripMenuItem"
        Me.LimpiarEntradaToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.LimpiarEntradaToolStripMenuItem.Text = "Limpiar Entrada"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtDias)
        Me.GroupBox1.Controls.Add(Me.TxtNit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 170)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Paciente"
        '
        'TxtDias
        '
        Me.TxtDias.Location = New System.Drawing.Point(90, 135)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.Size = New System.Drawing.Size(49, 22)
        Me.TxtDias.TabIndex = 5
        '
        'TxtNit
        '
        Me.TxtNit.Location = New System.Drawing.Point(90, 92)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(134, 22)
        Me.TxtNit.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(90, 43)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(205, 22)
        Me.TxtNombre.TabIndex = 0
        '
        'CBxHabitación
        '
        Me.CBxHabitación.FormattingEnabled = True
        Me.CBxHabitación.Items.AddRange(New Object() {"Privada", "Semi Privada", "No Privada"})
        Me.CBxHabitación.Location = New System.Drawing.Point(524, 83)
        Me.CBxHabitación.Name = "CBxHabitación"
        Me.CBxHabitación.Size = New System.Drawing.Size(132, 24)
        Me.CBxHabitación.TabIndex = 3
        '
        'CBxServicio
        '
        Me.CBxServicio.FormattingEnabled = True
        Me.CBxServicio.Items.AddRange(New Object() {"Encamamiento", "Operación", "Maternidad"})
        Me.CBxServicio.Location = New System.Drawing.Point(524, 132)
        Me.CBxServicio.Name = "CBxServicio"
        Me.CBxServicio.Size = New System.Drawing.Size(132, 24)
        Me.CBxServicio.TabIndex = 4
        '
        'CbxTipoPago
        '
        Me.CbxTipoPago.FormattingEnabled = True
        Me.CbxTipoPago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Tarjeta Crédito", "Tarjeta Débito"})
        Me.CbxTipoPago.Location = New System.Drawing.Point(524, 190)
        Me.CbxTipoPago.Name = "CbxTipoPago"
        Me.CbxTipoPago.Size = New System.Drawing.Size(132, 24)
        Me.CbxTipoPago.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(397, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Habitación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(397, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Servicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(397, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo de Pago"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LBxTotal)
        Me.GroupBox2.Controls.Add(Me.LBxRecargo)
        Me.GroupBox2.Controls.Add(Me.LBxDescuento)
        Me.GroupBox2.Controls.Add(Me.LBxSubtotal)
        Me.GroupBox2.Controls.Add(Me.LBxDias)
        Me.GroupBox2.Controls.Add(Me.LBxTipoPago)
        Me.GroupBox2.Controls.Add(Me.LBxServicio)
        Me.GroupBox2.Controls.Add(Me.LBxHabitacion)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(780, 201)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'LBxTotal
        '
        Me.LBxTotal.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxTotal.FormattingEnabled = True
        Me.LBxTotal.ItemHeight = 16
        Me.LBxTotal.Location = New System.Drawing.Point(666, 21)
        Me.LBxTotal.Name = "LBxTotal"
        Me.LBxTotal.Size = New System.Drawing.Size(104, 164)
        Me.LBxTotal.TabIndex = 7
        '
        'LBxRecargo
        '
        Me.LBxRecargo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxRecargo.FormattingEnabled = True
        Me.LBxRecargo.ItemHeight = 16
        Me.LBxRecargo.Location = New System.Drawing.Point(556, 21)
        Me.LBxRecargo.Name = "LBxRecargo"
        Me.LBxRecargo.Size = New System.Drawing.Size(104, 164)
        Me.LBxRecargo.TabIndex = 6
        '
        'LBxDescuento
        '
        Me.LBxDescuento.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxDescuento.FormattingEnabled = True
        Me.LBxDescuento.ItemHeight = 16
        Me.LBxDescuento.Location = New System.Drawing.Point(458, 21)
        Me.LBxDescuento.Name = "LBxDescuento"
        Me.LBxDescuento.Size = New System.Drawing.Size(92, 164)
        Me.LBxDescuento.TabIndex = 5
        '
        'LBxSubtotal
        '
        Me.LBxSubtotal.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxSubtotal.FormattingEnabled = True
        Me.LBxSubtotal.ItemHeight = 16
        Me.LBxSubtotal.Location = New System.Drawing.Point(359, 21)
        Me.LBxSubtotal.Name = "LBxSubtotal"
        Me.LBxSubtotal.Size = New System.Drawing.Size(93, 164)
        Me.LBxSubtotal.TabIndex = 4
        '
        'LBxDias
        '
        Me.LBxDias.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxDias.FormattingEnabled = True
        Me.LBxDias.ItemHeight = 16
        Me.LBxDias.Location = New System.Drawing.Point(293, 21)
        Me.LBxDias.Name = "LBxDias"
        Me.LBxDias.Size = New System.Drawing.Size(60, 164)
        Me.LBxDias.TabIndex = 3
        '
        'LBxTipoPago
        '
        Me.LBxTipoPago.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxTipoPago.FormattingEnabled = True
        Me.LBxTipoPago.ItemHeight = 16
        Me.LBxTipoPago.Location = New System.Drawing.Point(198, 21)
        Me.LBxTipoPago.Name = "LBxTipoPago"
        Me.LBxTipoPago.Size = New System.Drawing.Size(89, 164)
        Me.LBxTipoPago.TabIndex = 2
        '
        'LBxServicio
        '
        Me.LBxServicio.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxServicio.FormattingEnabled = True
        Me.LBxServicio.ItemHeight = 16
        Me.LBxServicio.Location = New System.Drawing.Point(110, 22)
        Me.LBxServicio.Name = "LBxServicio"
        Me.LBxServicio.Size = New System.Drawing.Size(82, 164)
        Me.LBxServicio.TabIndex = 1
        '
        'LBxHabitacion
        '
        Me.LBxHabitacion.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBxHabitacion.FormattingEnabled = True
        Me.LBxHabitacion.ItemHeight = 16
        Me.LBxHabitacion.Location = New System.Drawing.Point(14, 22)
        Me.LBxHabitacion.Name = "LBxHabitacion"
        Me.LBxHabitacion.Size = New System.Drawing.Size(90, 164)
        Me.LBxHabitacion.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(797, 490)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxTipoPago)
        Me.Controls.Add(Me.CBxServicio)
        Me.Controls.Add(Me.CBxHabitación)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOSPITAL"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtDias As TextBox
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents CBxHabitación As ComboBox
    Friend WithEvents CBxServicio As ComboBox
    Friend WithEvents CbxTipoPago As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBxHabitacion As ListBox
    Friend WithEvents LBxRecargo As ListBox
    Friend WithEvents LBxDescuento As ListBox
    Friend WithEvents LBxSubtotal As ListBox
    Friend WithEvents LBxDias As ListBox
    Friend WithEvents LBxTipoPago As ListBox
    Friend WithEvents LBxServicio As ListBox
    Friend WithEvents LBxTotal As ListBox
End Class
