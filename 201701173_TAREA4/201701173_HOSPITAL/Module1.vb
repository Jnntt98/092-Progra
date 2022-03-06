Module Module1
    Public Indice As Byte = 0

    Public HABITACION(6) As String
    Public SERVICIO(6) As String
    Public TIPOPAGO(6) As String
    Public dias(6) As Integer
    Public Subtotal(6) As Double
    Public Descuento(6) As Double
    Public Recargo(6) As Double
    Public PagoTotal(6) As Double

    Sub Limpiar_Entradas()
        Form1.TxtNombre.Clear()
        Form1.CBxHabitación.SelectedIndex = -1
        Form1.CBxServicio.SelectedIndex = -1
        Form1.CbxTipoPago.SelectedIndex = -1
        Form1.LBxHabitacion.Items.Clear()
        Form1.LBxServicio.Items.Clear()
        Form1.LBxTipoPago.Items.Clear()
        Form1.LBxDias.Items.Clear()
        Form1.LBxSubtotal.Items.Clear()
        Form1.LBxDescuento.Items.Clear()
        Form1.LBxRecargo.Items.Clear()
        Form1.LBxTotal.Items.Clear()
        Form1.TxtNombre.Focus()

    End Sub

    Sub Limpiar_vectores()
        Indice = 0

        Form1.TxtNombre.Clear()
        Form1.TxtNit.Clear()
        Form1.TxtDias.Clear()
        Form1.CBxHabitación.SelectedIndex = -1
        Form1.CBxServicio.SelectedIndex = -1
        Form1.CbxTipoPago.SelectedIndex = -1
        Form1.LBxHabitacion.Items.Clear()
        Form1.LBxServicio.Items.Clear()
        Form1.LBxTipoPago.Items.Clear()
        Form1.LBxDias.Items.Clear()
        Form1.LBxSubtotal.Items.Clear()
        Form1.LBxDescuento.Items.Clear()
        Form1.LBxRecargo.Items.Clear()
        Form1.LBxTotal.Items.Clear()
        Form1.TxtNombre.Focus()

    End Sub
    Sub Mostrar()
        Form1.LBxHabitacion.Items.Add(HABITACION(Indice))
        Form1.LBxServicio.Items.Add(SERVICIO(Indice))
        Form1.LBxTipoPago.Items.Add(PAGO(Indice))
        Form1.LBxDias.Items.Add(dias(Indice))
        Form1.LBxSubtotal.Items.Add(Subtotal(Indice))
        Form1.LBxDescuento.Items.Add(Descuento(Indice))
        Form1.LBxRecargo.Items.Add(Recargo(Indice))
        Form1.LBxTotal.Items.Add(PagoTotal(Indice))
        Form1.TxtNombre.Clear()
        Form1.TxtNit.Clear()
        Form1.TxtDias.Clear()
        Form1.CBxHabitación.SelectedIndex = -1
        Form1.CBxServicio.SelectedIndex = -1
        Form1.CbxTipoPago.SelectedIndex = -1
    End Sub
End Module
