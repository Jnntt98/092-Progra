<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFabricadeChumpas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFabricadeChumpas))
        Me.RbSmall = New System.Windows.Forms.RadioButton()
        Me.RbMedium = New System.Windows.Forms.RadioButton()
        Me.RbLarge = New System.Windows.Forms.RadioButton()
        Me.RbAlgodón = New System.Windows.Forms.RadioButton()
        Me.RbSeda = New System.Windows.Forms.RadioButton()
        Me.RbLona = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCantidadChumpas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCalcular = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblPrecioCosto = New System.Windows.Forms.Label()
        Me.LblPrecioVenta = New System.Windows.Forms.Label()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.LblTotalCosto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RbSmall
        '
        Me.RbSmall.AutoSize = True
        Me.RbSmall.Location = New System.Drawing.Point(28, 30)
        Me.RbSmall.Name = "RbSmall"
        Me.RbSmall.Size = New System.Drawing.Size(63, 21)
        Me.RbSmall.TabIndex = 0
        Me.RbSmall.TabStop = True
        Me.RbSmall.Text = "Small"
        Me.RbSmall.UseVisualStyleBackColor = True
        '
        'RbMedium
        '
        Me.RbMedium.AutoSize = True
        Me.RbMedium.Location = New System.Drawing.Point(28, 72)
        Me.RbMedium.Name = "RbMedium"
        Me.RbMedium.Size = New System.Drawing.Size(78, 21)
        Me.RbMedium.TabIndex = 1
        Me.RbMedium.TabStop = True
        Me.RbMedium.Text = "Medium"
        Me.RbMedium.UseVisualStyleBackColor = True
        '
        'RbLarge
        '
        Me.RbLarge.AutoSize = True
        Me.RbLarge.Location = New System.Drawing.Point(28, 114)
        Me.RbLarge.Name = "RbLarge"
        Me.RbLarge.Size = New System.Drawing.Size(66, 21)
        Me.RbLarge.TabIndex = 2
        Me.RbLarge.TabStop = True
        Me.RbLarge.Text = "Large"
        Me.RbLarge.UseVisualStyleBackColor = True
        '
        'RbAlgodón
        '
        Me.RbAlgodón.AutoSize = True
        Me.RbAlgodón.Location = New System.Drawing.Point(23, 32)
        Me.RbAlgodón.Name = "RbAlgodón"
        Me.RbAlgodón.Size = New System.Drawing.Size(81, 21)
        Me.RbAlgodón.TabIndex = 3
        Me.RbAlgodón.TabStop = True
        Me.RbAlgodón.Text = "Algodón"
        Me.RbAlgodón.UseVisualStyleBackColor = True
        '
        'RbSeda
        '
        Me.RbSeda.AutoSize = True
        Me.RbSeda.Location = New System.Drawing.Point(23, 72)
        Me.RbSeda.Name = "RbSeda"
        Me.RbSeda.Size = New System.Drawing.Size(62, 21)
        Me.RbSeda.TabIndex = 4
        Me.RbSeda.TabStop = True
        Me.RbSeda.Text = "Seda"
        Me.RbSeda.UseVisualStyleBackColor = True
        '
        'RbLona
        '
        Me.RbLona.AutoSize = True
        Me.RbLona.Location = New System.Drawing.Point(23, 114)
        Me.RbLona.Name = "RbLona"
        Me.RbLona.Size = New System.Drawing.Size(61, 21)
        Me.RbLona.TabIndex = 5
        Me.RbLona.TabStop = True
        Me.RbLona.Text = "Lona"
        Me.RbLona.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RbLarge)
        Me.GroupBox1.Controls.Add(Me.RbMedium)
        Me.GroupBox1.Controls.Add(Me.RbSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 156)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Tamaño"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.RbLona)
        Me.GroupBox2.Controls.Add(Me.RbSeda)
        Me.GroupBox2.Controls.Add(Me.RbAlgodón)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 156)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Material"
        '
        'TxtCantidadChumpas
        '
        Me.TxtCantidadChumpas.Location = New System.Drawing.Point(476, 70)
        Me.TxtCantidadChumpas.Name = "TxtCantidadChumpas"
        Me.TxtCantidadChumpas.Size = New System.Drawing.Size(105, 22)
        Me.TxtCantidadChumpas.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(443, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese cantidad de Chumpas"
        '
        'BCalcular
        '
        Me.BCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BCalcular.Location = New System.Drawing.Point(42, 215)
        Me.BCalcular.Name = "BCalcular"
        Me.BCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BCalcular.TabIndex = 10
        Me.BCalcular.Text = "Calcular"
        Me.BCalcular.UseVisualStyleBackColor = False
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BLimpiar.Location = New System.Drawing.Point(176, 215)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BLimpiar.TabIndex = 11
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSalir.Location = New System.Drawing.Point(313, 215)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 12
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(408, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Costo Individual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(408, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Venta Individual"
        '
        'LblPrecioCosto
        '
        Me.LblPrecioCosto.AutoSize = True
        Me.LblPrecioCosto.BackColor = System.Drawing.Color.White
        Me.LblPrecioCosto.Location = New System.Drawing.Point(563, 114)
        Me.LblPrecioCosto.Name = "LblPrecioCosto"
        Me.LblPrecioCosto.Size = New System.Drawing.Size(13, 17)
        Me.LblPrecioCosto.TabIndex = 20
        Me.LblPrecioCosto.Text = "-"
        '
        'LblPrecioVenta
        '
        Me.LblPrecioVenta.AutoSize = True
        Me.LblPrecioVenta.BackColor = System.Drawing.Color.White
        Me.LblPrecioVenta.Location = New System.Drawing.Point(563, 151)
        Me.LblPrecioVenta.Name = "LblPrecioVenta"
        Me.LblPrecioVenta.Size = New System.Drawing.Size(13, 17)
        Me.LblPrecioVenta.TabIndex = 21
        Me.LblPrecioVenta.Text = "-"
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lbltotal.Location = New System.Drawing.Point(408, 185)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(107, 17)
        Me.Lbltotal.TabIndex = 22
        Me.Lbltotal.Text = "TOTAL COSTO"
        '
        'LblTotalCosto
        '
        Me.LblTotalCosto.AutoSize = True
        Me.LblTotalCosto.BackColor = System.Drawing.Color.White
        Me.LblTotalCosto.Location = New System.Drawing.Point(563, 185)
        Me.LblTotalCosto.Name = "LblTotalCosto"
        Me.LblTotalCosto.Size = New System.Drawing.Size(13, 17)
        Me.LblTotalCosto.TabIndex = 23
        Me.LblTotalCosto.Text = "-"
        '
        'FormFabricadeChumpas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(661, 261)
        Me.Controls.Add(Me.LblTotalCosto)
        Me.Controls.Add(Me.Lbltotal)
        Me.Controls.Add(Me.LblPrecioVenta)
        Me.Controls.Add(Me.LblPrecioCosto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.BCalcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCantidadChumpas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormFabricadeChumpas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fabrica de Chumpas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RbSmall As RadioButton
    Friend WithEvents RbMedium As RadioButton
    Friend WithEvents RbLarge As RadioButton
    Friend WithEvents RbAlgodón As RadioButton
    Friend WithEvents RbSeda As RadioButton
    Friend WithEvents RbLona As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCantidadChumpas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BCalcular As Button
    Friend WithEvents BLimpiar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblPrecioCosto As Label
    Friend WithEvents LblPrecioVenta As Label
    Friend WithEvents Lbltotal As Label
    Friend WithEvents LblTotalCosto As Label
End Class
