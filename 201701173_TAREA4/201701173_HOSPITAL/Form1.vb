Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        If (Indice < 6) Then
            HABITACION(Indice) = CBxHabitación.Text
            SERVICIO(Indice) = CBxServicio.Text
            TIPOPAGO(Indice) = CbxTipoPago.Text
            If (TxtDias.Text <> "") Then
                dias(Indice) = Val(TxtDias.Text)
            Else
                MsgBox("Error, no ingresó cant. de dias")
                TxtDias.Focus() : Exit Sub
            End If

            Select Case (CBxHabitación.SelectedIndex)
                Case 0
                    Select Case (CBxHabitación.SelectedIndex)
                        Case 0 : Subtotal(Indice) = dias(Indice) * 350
                        Case 1 : Subtotal(Indice) = dias(Indice) * 550
                        Case 2 : Subtotal(Indice) = dias(Indice) * 450
                    End Select
                Case 1
                    Select Case (CBxServicio.SelectedIndex)
                        Case 0 : Subtotal(Indice) = dias(Indice) * 250
                        Case 1 : Subtotal(Indice) = dias(Indice) * 400
                        Case 2 : Subtotal(Indice) = dias(Indice) * 350
                    End Select
                Case 2
                    Select Case (CBxServicio.SelectedIndex)
                        Case 0 : Subtotal(Indice) = dias(Indice) * 150
                        Case 1 : Subtotal(Indice) = dias(Indice) * 300
                        Case 2 : Subtotal(Indice) = dias(Indice) * 250
                    End Select
                Case Else
                    MsgBox("Error, no seleccionó servicio")
                    CBxServicio.Focus() : Exit Sub
            End Select
            If (CbxTipoPago.SelectedIndex = 0 Or CbxTipoPago.SelectedIndex = 1) Then
                Descuento(Indice) = Round(Val(Subtotal(Indice) * 0.15), 2)
            ElseIf CbxTipoPago.SelectedIndex = 3 Then
                Descuento(Indice) = Round(Val(Subtotal(Indice) * 0.08), 2)
            ElseIf CbxTipoPago.SelectedIndex = 2 Then
                Recargo(Indice) = Round(Val(Subtotal(Indice) * 0.05), 2)
            End If

            PagoTotal(Indice) = Val(Subtotal(Indice)) - Val(Descuento(Indice)) + Val(Recargo(Indice))
            Mostrar()

            Indice = Indice + 1
        End If
        If (Indice = 6) Then
            MsgBox("Los Vectores están llenos")
        End If
    End Sub



    Private Sub LimpiarEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradaToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_vectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

    Private Sub TxtDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDias.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
