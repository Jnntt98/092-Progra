Module Module1
    Public indice As Byte = 0

    Public Nombre(7) As String
    Public Dias(7) As String
    Public TipoHabitacíon(7) As String
    Public TipoPago(7) As Integer
    Public TotalaPagar(7) As Double
    Public DescuentoRecargo(7) As Double
    Public Total(7) As Double
    Public PagoTotal(6) As Double

    Public Const HabSencilla = 250
    Public Const HabDoble = 400
    Public Const HabCabana = 650

    Sub LimpiarVectores()
        indice = 0

        Form1.txtNombre.Clear()
        Form1.TxtNit.Clear()
        Form1.TxtDias.Clear()
        Form1.CbTipoHabitacion.SelectedIndex = -1
        Form1.CbTipoPago.SelectedIndex = -1
        Form1.DataGridView1.Columns.Clear()

        Form1.txtNombre.Focus()

    End Sub
    Sub LimpiarEntradas()
        Form1.txtNombre.Clear()
        Form1.TxtNit.Clear()
        Form1.TxtDias.Clear()
        Form1.CbTipoHabitacion.SelectedIndex = -1
        Form1.CbTipoPago.SelectedIndex = -1
        Form1.DataGridView1.Columns.Clear()

        Form1.txtNombre.Focus()

    End Sub
End Module
