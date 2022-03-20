Module Module1
    Public Total(8) As Double
    Public Costo(8) As Double
    Public Venta(8) As Double
    Public Tamaño(8) As String
    Public Tela(8) As String
    Public Yardas(8) As Double
    Public Const Sofa = 250.99
    Public Const Individual = 150.99
    Public Const Doble = 200.99
    Public Const YardaCuero = 75.0
    Public Const YardaCuerina = 45.99
    Public PrecioVenta As Double
    Public Indice As Byte = 0

    Sub LimpiarEntradas()

        Form1.RbSofa.Checked = False
        Form1.RbIndividual.Checked = False
        Form1.RbDoble.Checked = False
        Form1.RbCuero.Checked = False
        Form1.RbCuerina.Checked = False
        Form1.TxtCuero.Clear()
        Form1.TxtCuerina.Clear()
        Form1.TxtNoVenta.Clear()
    End Sub

    Sub LimpiarVectores()
        Indice = 0
        Form1.DataGridView1.Rows.Clear()
    End Sub
End Module
