<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TIENDA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TIENDA))
        Me.LblArroz = New System.Windows.Forms.Label()
        Me.LblFrijol = New System.Windows.Forms.Label()
        Me.TxtArroz = New System.Windows.Forms.TextBox()
        Me.TxtFrijol = New System.Windows.Forms.TextBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtLimpiar = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.LblAzucar = New System.Windows.Forms.Label()
        Me.TxtAzucar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtsinIVA = New System.Windows.Forms.TextBox()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.TxtconIVA = New System.Windows.Forms.TextBox()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblArroz
        '
        Me.LblArroz.AutoSize = True
        Me.LblArroz.BackColor = System.Drawing.Color.YellowGreen
        Me.LblArroz.Location = New System.Drawing.Point(14, 21)
        Me.LblArroz.Name = "LblArroz"
        Me.LblArroz.Size = New System.Drawing.Size(73, 17)
        Me.LblArroz.TabIndex = 0
        Me.LblArroz.Text = "Lbs. Arroz"
        '
        'LblFrijol
        '
        Me.LblFrijol.AutoSize = True
        Me.LblFrijol.BackColor = System.Drawing.Color.YellowGreen
        Me.LblFrijol.Location = New System.Drawing.Point(251, 21)
        Me.LblFrijol.Name = "LblFrijol"
        Me.LblFrijol.Size = New System.Drawing.Size(69, 17)
        Me.LblFrijol.TabIndex = 1
        Me.LblFrijol.Text = "Lbs. Frijol"
        '
        'TxtArroz
        '
        Me.TxtArroz.Location = New System.Drawing.Point(119, 21)
        Me.TxtArroz.Name = "TxtArroz"
        Me.TxtArroz.Size = New System.Drawing.Size(76, 22)
        Me.TxtArroz.TabIndex = 6
        '
        'TxtFrijol
        '
        Me.TxtFrijol.Location = New System.Drawing.Point(361, 21)
        Me.TxtFrijol.Name = "TxtFrijol"
        Me.TxtFrijol.Size = New System.Drawing.Size(76, 22)
        Me.TxtFrijol.TabIndex = 7
        '
        'BtAceptar
        '
        Me.BtAceptar.BackColor = System.Drawing.Color.SandyBrown
        Me.BtAceptar.Location = New System.Drawing.Point(119, 323)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(110, 32)
        Me.BtAceptar.TabIndex = 15
        Me.BtAceptar.Text = "Calcular"
        Me.BtAceptar.UseVisualStyleBackColor = False
        '
        'BtLimpiar
        '
        Me.BtLimpiar.BackColor = System.Drawing.Color.SandyBrown
        Me.BtLimpiar.Location = New System.Drawing.Point(296, 323)
        Me.BtLimpiar.Name = "BtLimpiar"
        Me.BtLimpiar.Size = New System.Drawing.Size(110, 32)
        Me.BtLimpiar.TabIndex = 16
        Me.BtLimpiar.Text = "Limpiar"
        Me.BtLimpiar.UseVisualStyleBackColor = False
        '
        'BtSalir
        '
        Me.BtSalir.BackColor = System.Drawing.Color.SandyBrown
        Me.BtSalir.Location = New System.Drawing.Point(472, 323)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(110, 32)
        Me.BtSalir.TabIndex = 17
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = False
        '
        'LblAzucar
        '
        Me.LblAzucar.AutoSize = True
        Me.LblAzucar.BackColor = System.Drawing.Color.YellowGreen
        Me.LblAzucar.Location = New System.Drawing.Point(497, 24)
        Me.LblAzucar.Name = "LblAzucar"
        Me.LblAzucar.Size = New System.Drawing.Size(83, 17)
        Me.LblAzucar.TabIndex = 18
        Me.LblAzucar.Text = "Lbs. Azucar"
        '
        'TxtAzucar
        '
        Me.TxtAzucar.Location = New System.Drawing.Point(608, 21)
        Me.TxtAzucar.Name = "TxtAzucar"
        Me.TxtAzucar.Size = New System.Drawing.Size(76, 22)
        Me.TxtAzucar.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(24, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Pago sin IVA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Location = New System.Drawing.Point(24, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.YellowGreen
        Me.Label3.Location = New System.Drawing.Point(24, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Pago con IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.YellowGreen
        Me.Label4.Location = New System.Drawing.Point(328, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Descuento 2.5%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Location = New System.Drawing.Point(328, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Total"
        '
        'TxtsinIVA
        '
        Me.TxtsinIVA.Enabled = False
        Me.TxtsinIVA.Location = New System.Drawing.Point(158, 31)
        Me.TxtsinIVA.Name = "TxtsinIVA"
        Me.TxtsinIVA.Size = New System.Drawing.Size(76, 22)
        Me.TxtsinIVA.TabIndex = 25
        '
        'TxtIVA
        '
        Me.TxtIVA.Enabled = False
        Me.TxtIVA.Location = New System.Drawing.Point(158, 94)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(76, 22)
        Me.TxtIVA.TabIndex = 26
        '
        'TxtconIVA
        '
        Me.TxtconIVA.Enabled = False
        Me.TxtconIVA.Location = New System.Drawing.Point(158, 162)
        Me.TxtconIVA.Name = "TxtconIVA"
        Me.TxtconIVA.Size = New System.Drawing.Size(76, 22)
        Me.TxtconIVA.TabIndex = 27
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Enabled = False
        Me.TxtDescuento.Location = New System.Drawing.Point(453, 28)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(76, 22)
        Me.TxtDescuento.TabIndex = 28
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(453, 122)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(76, 22)
        Me.TxtTotal.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.TxtAzucar)
        Me.GroupBox1.Controls.Add(Me.LblAzucar)
        Me.GroupBox1.Controls.Add(Me.TxtFrijol)
        Me.GroupBox1.Controls.Add(Me.TxtArroz)
        Me.GroupBox1.Controls.Add(Me.LblFrijol)
        Me.GroupBox1.Controls.Add(Me.LblArroz)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 63)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TxtDescuento)
        Me.GroupBox2.Controls.Add(Me.TxtconIVA)
        Me.GroupBox2.Controls.Add(Me.TxtIVA)
        Me.GroupBox2.Controls.Add(Me.TxtsinIVA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(75, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 202)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'TIENDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 367)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtLimpiar)
        Me.Controls.Add(Me.BtAceptar)
        Me.MaximizeBox = False
        Me.Name = "TIENDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIENDA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblArroz As Label
    Friend WithEvents LblFrijol As Label
    Friend WithEvents TxtArroz As TextBox
    Friend WithEvents TxtFrijol As TextBox
    Friend WithEvents BtAceptar As Button
    Friend WithEvents BtLimpiar As Button
    Friend WithEvents BtSalir As Button
    Friend WithEvents LblAzucar As Label
    Friend WithEvents TxtAzucar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtsinIVA As TextBox
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents TxtconIVA As TextBox
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
