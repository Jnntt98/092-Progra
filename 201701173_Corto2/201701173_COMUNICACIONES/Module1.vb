Module Module1

    Public Nombre(7) As String
    Public Sueldo(7) As String
    Public Comision(7) As String
    Public BonoIncentivo(7) As Integer
    Public SueldoFinal(7) As Double

    Public Const PrecioTablet = 375
    Public Const PrecioDrone = 560
    Public Const PrecioCelular = 1450
    Public Const PrecioTelevisor = 3250
    Public Const cuerina = 45.99

    Public INDICE As Byte = 0

    Sub LimpiarEntradas()
        Form1.TxtNombre.Clear()
        Form1.TxtSalario.Clear()

        Form1.TxtNombre.Focus()
        Form1.RbCelular.Checked = False
        Form1.RbDrone.Checked = False
        Form1.RbTablet.Checked = False
        Form1.RbTelevisor.Checked = False

    End Sub

    Sub LimpiarVectores()
        INDICE = 0
        Form1.LbNombre.Items.Clear()
        Form1.LbSueldo.Items.Clear()
        Form1.LbBonoIncentivo.Items.Clear()
        Form1.LbComisión.Items.Clear()
        Form1.LbSueldoFinal.Items.Clear()
    End Sub
End Module
