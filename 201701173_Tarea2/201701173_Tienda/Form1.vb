Public Class TIENDA
    Const PArroz As Double = 2.0
    Const PFrijol As Double = 1.75
    Const PAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim SinIVA As Double = 0
    Dim ValorIVA As Double = 0
    Dim ConIVA As Double = 0
    Dim Descuento As Double = 0
    Dim PagoFinal As Double = 0
    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtArroz.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        End
    End Sub

    Private Sub TBCantidad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblNombre_Click(sender As Object, e As EventArgs) Handles LblArroz.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub TBArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TBFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TBAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAzucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TIENDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        SinIVA = (Val(TxtArroz.Text) * PArroz) + (Val(TxtFrijol.Text) * PFrijol) + (Val(TxtAzucar.Text) * PAzucar)
        ValorIVA = SinIVA * IVA
        ConIVA = SinIVA + ValorIVA
        Descuento = ConIVA * 0.025
        PagoFinal = ConIVA - Descuento


        TxtsinIVA.Text = SinIVA
        TxtIVA.Text = ValorIVA
        TxtconIVA.Text = ConIVA
        TxtDescuento.Text = Descuento
        TxtTotal.Text = PagoFinal
    End Sub

    Private Sub BtLimpiar_Click(sender As Object, e As EventArgs) Handles BtLimpiar.Click
        TxtArroz.Clear()
        TxtAzucar.Clear()
        TxtFrijol.Clear()
        TxtsinIVA.Clear()
        TxtIVA.Clear()
        TxtconIVA.Clear()
        TxtDescuento.Clear()
        TxtTotal.Clear()

    End Sub
End Class
