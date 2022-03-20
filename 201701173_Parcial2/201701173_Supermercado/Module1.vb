Module Module1
    Public NombrePack(6) As String
    Public CantidadInventario(6) As Double
    Public CantidadDeseada(6) As Double
    Public CantidadPacks(6) As Double
    Public PrecioUnitario(6) As Double
    Public Descuento(6) As Double
    Public TipoProducto(6) As String
    Public IngresosSobrante(6) As Double
    Public TOTAL(6) As Double
    Public Const Inventario = 100
    Public Const Jugos = 8.5
    Public Const Frituras = 11.2
    Public Const Galletas = 4.25
    Public Const Baterias = 15
    Public PrecioVenta(6) As Double
    Public Indice As Byte = 0

    Sub LimpiarEntradas()
        Form1.RbJugos.Checked = False
        Form1.RbFrituras.Checked = False
        Form1.RbGalletas.Checked = False
        Form1.RbBaterias.Checked = False

    End Sub

    Sub LimpiarVectores()
        Indice = 0
        Form1.DataGridView1.Rows.Clear()
    End Sub
End Module
