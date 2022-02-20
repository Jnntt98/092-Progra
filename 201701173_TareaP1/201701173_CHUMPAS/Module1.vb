Module Module1
    Public TOTAL As Double
    Public Const MoSmall = 65.5
    Public Const MoMedium = 85.99
    Public Const MoLarge = 99.99
    Public Const YardaSmall = 2
    Public Const YardaMedium = 2.5
    Public Const YardaLarge = 3
    Public Const Algodon = 15
    Public Const Seda = 23.99
    Public Const Lona = 30.99
    Public TotalChumpas As Double
    Public PrecioVenta As Double
    Public PrecioCosto As Double

    Sub Limpiar()
        FormFabricadeChumpas.RbSmall.Checked = False
        FormFabricadeChumpas.RbMedium.Checked = False
        FormFabricadeChumpas.RbLarge.Checked = False
        FormFabricadeChumpas.RbAlgodón.Checked = False
        FormFabricadeChumpas.RbSeda.Checked = False
        FormFabricadeChumpas.RbLona.Checked = False
        FormFabricadeChumpas.TxtCantidadChumpas.Clear()
        FormFabricadeChumpas.LblPrecioCosto.Text = "-"
        FormFabricadeChumpas.LblPrecioVenta.Text = "-"
    End Sub

    Sub ErrorDatos()
        MsgBox("Verifique el ingreso de datos", +vbYes)
    End Sub
    Sub CantidadInsuficientes()
        MsgBox("Ingrese cantidad de chumpas", +vbYes)
    End Sub

    Sub VerificacionChumpas()
        MsgBox("Ingrese Cantidad de Yardas", +vbYes)
    End Sub


End Module
