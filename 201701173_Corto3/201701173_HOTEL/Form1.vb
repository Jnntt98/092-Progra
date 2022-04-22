Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("Está seguro que desea salir", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            End
        Else
            LimpiarEntradas()
        End If
    End Sub

    Private Sub TxtNit_TextChanged(sender As Object, e As EventArgs) Handles TxtNit.TextChanged
        If TxtNit.Text = "" Then
            MsgBox("El usuario no existe")
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
