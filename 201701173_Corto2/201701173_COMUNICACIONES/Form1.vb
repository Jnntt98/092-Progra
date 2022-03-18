Public Class Form1

    Function CalculoComision()
        CalculoComision = Val(TxtCantidad.Text) * 5%
        Return CalculoComision
    End Function

    Function CalculoBonoIncentivo()
        Sueldo(INDICE) = Val(TxtSalario.Text)
        CalculoBonoIncentivo =
            If Sueldo <= 2000 then
            
    End Function

    Function CalculoSueldoFinal()

    End Function
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RbTelevisor.CheckedChanged

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LimpiarEntradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiarVectores()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            LimpiarEntradas()
        End If
    End Sub

    Private Sub TxtSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalario.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If INDICE < 7 Then
            Nombre(INDICE) = TxtNombre.Text
            Sueldo(INDICE) = Val(TxtSalario.Text)

        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
