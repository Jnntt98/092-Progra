Public Class FormFabricadeChumpas
    Private Sub RbLarge_CheckedChanged(sender As Object, e As EventArgs) Handles RbLarge.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RbSeda.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        If MsgBox("¿Está seguro que desea salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            Limpiar()
        End If
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BCalcular_Click(sender As Object, e As EventArgs) Handles BCalcular.Click
        TotalChumpas = Val(TxtCantidadChumpas.Text)
        'Calculo de chumpas talla small
        If RbSmall.Checked Then
            If RbAlgodón.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoSmall + 1 * YardaSmall * Algodon
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If
            ElseIf RbSeda.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoSmall + 1 * YardaSmall * Seda
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If

            ElseIf RbLona.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoSmall + 1 * YardaSmall * Lona
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If
            Else
                ErrorDatos()
            End If
            'Finaliza chumpas small

            'calculo de chumpas talla medium
        ElseIf RbMedium.Checked Then

            If RbAlgodón.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoMedium + 1 * YardaMedium * Algodon
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If
            ElseIf RbSeda.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoMedium + 1 * YardaMedium * Seda
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If

            ElseIf RbLona.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoMedium + 1 * YardaMedium * Lona
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If
            Else
                ErrorDatos()
            End If

            'Finaliza chumpas Medium

            'calculo de chumpas talla Large
        ElseIf RbLarge.Checked Then

            If RbAlgodón.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoLarge + 1 * YardaLarge * Algodon
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If
            ElseIf RbSeda.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoLarge + 1 * YardaLarge * Seda
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If

            ElseIf RbLona.Checked Then
                If TxtCantidadChumpas.Text = "" Then
                    CantidadInsuficientes()
                ElseIf TotalChumpas > 0 Then
                    PrecioCosto = 1 * MoLarge + 1 * YardaLarge * Lona
                    LblPrecioCosto.Text = PrecioCosto
                    LblPrecioVenta.Text = PrecioCosto + PrecioCosto * 0.65
                    LblTotalCosto.Text = TotalChumpas * PrecioCosto
                Else
                    CantidadInsuficientes()
                End If
            Else
                ErrorDatos()
            End If
            'Finaliza chumpas Large
        Else
            ErrorDatos()
        End If

    End Sub

    Private Sub TxtCantidadYardas_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidadChumpas.TextChanged

    End Sub

    Private Sub TxtCantidadYardas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidadChumpas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RbSmall_CheckedChanged(sender As Object, e As EventArgs) Handles RbSmall.CheckedChanged

    End Sub
End Class
