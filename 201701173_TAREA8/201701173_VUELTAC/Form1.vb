Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("Está seguro que desea salir", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            End
        Else
            LimpiarVectores()
        End If
    End Sub
End Class
