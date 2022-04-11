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
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVERCTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADISTICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbTransporte = New System.Windows.Forms.ComboBox()
        Me.CbTipos = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalPaquetesEnviadosRopa = New System.Windows.Forms.TextBox()
        Me.txtTotalEnviosDocumentos = New System.Windows.Forms.TextBox()
        Me.txtTotalEnviosPlastico = New System.Windows.Forms.TextBox()
        Me.txtTotalEnviosLociones = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVERCTORESToolStripMenuItem
        '
        Me.LIMPIARVERCTORESToolStripMenuItem.Name = "LIMPIARVERCTORESToolStripMenuItem"
        Me.LIMPIARVERCTORESToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.LIMPIARVERCTORESToolStripMenuItem.Text = "LIMPIAR VERCTORES"
        '
        'ESTADISTICAToolStripMenuItem
        '
        Me.ESTADISTICAToolStripMenuItem.Name = "ESTADISTICAToolStripMenuItem"
        Me.ESTADISTICAToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.ESTADISTICAToolStripMenuItem.Text = "ESTADISTICA"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.LIMPIARVERCTORESToolStripMenuItem, Me.ESTADISTICAToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(695, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbTransporte)
        Me.GroupBox1.Controls.Add(Me.CbTipos)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(30, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 122)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'CbTransporte
        '
        Me.CbTransporte.FormattingEnabled = True
        Me.CbTransporte.Items.AddRange(New Object() {"Camión", "Motocicleta"})
        Me.CbTransporte.Location = New System.Drawing.Point(403, 83)
        Me.CbTransporte.Name = "CbTransporte"
        Me.CbTransporte.Size = New System.Drawing.Size(175, 24)
        Me.CbTransporte.TabIndex = 7
        '
        'CbTipos
        '
        Me.CbTipos.FormattingEnabled = True
        Me.CbTipos.Items.AddRange(New Object() {"Doscumentos", "Ropa", "Artículos Perecederos", "Artículos Plásticos", "Lociones"})
        Me.CbTipos.Location = New System.Drawing.Point(97, 82)
        Me.CbTipos.Name = "CbTipos"
        Me.CbTipos.Size = New System.Drawing.Size(175, 24)
        Me.CbTipos.TabIndex = 6
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(416, 35)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(97, 22)
        Me.txtValor.TabIndex = 5
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(94, 35)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(239, 22)
        Me.txtCliente.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TRANSPORTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VALOR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TIPOS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTE:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ListBox6)
        Me.GroupBox2.Controls.Add(Me.ListBox5)
        Me.GroupBox2.Controls.Add(Me.ListBox4)
        Me.GroupBox2.Controls.Add(Me.ListBox3)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 370)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Yellow
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(566, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(431, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "PAGO PARCIAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Yellow
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(367, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "TIPO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(255, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "IMPUESTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(180, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "VALOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CLIENTE"
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 16
        Me.ListBox6.Location = New System.Drawing.Point(546, 64)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(108, 276)
        Me.ListBox6.TabIndex = 5
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 16
        Me.ListBox5.Location = New System.Drawing.Point(432, 64)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(108, 276)
        Me.ListBox5.TabIndex = 4
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 16
        Me.ListBox4.Location = New System.Drawing.Point(347, 64)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(79, 276)
        Me.ListBox4.TabIndex = 3
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(252, 64)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(89, 276)
        Me.ListBox3.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(169, 64)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(77, 276)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(17, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(146, 276)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtTotalPaquetesEnviadosRopa)
        Me.GroupBox3.Controls.Add(Me.txtTotalEnviosDocumentos)
        Me.GroupBox3.Controls.Add(Me.txtTotalEnviosPlastico)
        Me.GroupBox3.Controls.Add(Me.txtTotalEnviosLociones)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(58, 564)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(581, 148)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ESTADISTICAS"
        '
        'txtTotalPaquetesEnviadosRopa
        '
        Me.txtTotalPaquetesEnviadosRopa.Enabled = False
        Me.txtTotalPaquetesEnviadosRopa.Location = New System.Drawing.Point(418, 115)
        Me.txtTotalPaquetesEnviadosRopa.Name = "txtTotalPaquetesEnviadosRopa"
        Me.txtTotalPaquetesEnviadosRopa.Size = New System.Drawing.Size(151, 22)
        Me.txtTotalPaquetesEnviadosRopa.TabIndex = 7
        '
        'txtTotalEnviosDocumentos
        '
        Me.txtTotalEnviosDocumentos.Enabled = False
        Me.txtTotalEnviosDocumentos.Location = New System.Drawing.Point(418, 87)
        Me.txtTotalEnviosDocumentos.Name = "txtTotalEnviosDocumentos"
        Me.txtTotalEnviosDocumentos.Size = New System.Drawing.Size(151, 22)
        Me.txtTotalEnviosDocumentos.TabIndex = 6
        '
        'txtTotalEnviosPlastico
        '
        Me.txtTotalEnviosPlastico.Enabled = False
        Me.txtTotalEnviosPlastico.Location = New System.Drawing.Point(418, 58)
        Me.txtTotalEnviosPlastico.Name = "txtTotalEnviosPlastico"
        Me.txtTotalEnviosPlastico.Size = New System.Drawing.Size(151, 22)
        Me.txtTotalEnviosPlastico.TabIndex = 5
        '
        'txtTotalEnviosLociones
        '
        Me.txtTotalEnviosLociones.Enabled = False
        Me.txtTotalEnviosLociones.Location = New System.Drawing.Point(418, 27)
        Me.txtTotalEnviosLociones.Name = "txtTotalEnviosLociones"
        Me.txtTotalEnviosLociones.Size = New System.Drawing.Size(151, 22)
        Me.txtTotalEnviosLociones.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Yellow
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(15, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(282, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Total de paquetes de ropa que se enviaron"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Yellow
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(15, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(365, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Total(Q) de lo que se envió de paquetes en documentos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Yellow
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(15, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(350, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Cuantos paquetes de artículos de plastico se enviaron"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Yellow
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(340, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Total(Q) de lo que se envió de paquetes en lociones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(695, 724)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.OliveDrab
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENVIOS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVERCTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESTADISTICAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbTransporte As ComboBox
    Friend WithEvents CbTipos As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalPaquetesEnviadosRopa As TextBox
    Friend WithEvents txtTotalEnviosDocumentos As TextBox
    Friend WithEvents txtTotalEnviosPlastico As TextBox
    Friend WithEvents txtTotalEnviosLociones As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
