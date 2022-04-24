Module Module1
    Public NitCliente As String
    Public NombrePelicula As Integer
    Public CantBoletos As Double
    Public BoletosNormal As Double
    Public BoletosTresD As Double
    Public BoletosCuatroDX As Double

    Public Const Normal = 44
    Public Const TresD = 62
    Public Const CuatroDX = 104

    Sub LimpiarEntradas()
        Form1.TxtNitCliente.Text = ""
        Form1.TxtNombrePelicula.Text = ""

        Form1.ChBNormal.Checked = False
        Form1.ChB3D.Checked = False
        Form1.ChB4DX.Checked = False
        Form1.DataGridView1.Rows.Clear()
    End Sub
End Module
