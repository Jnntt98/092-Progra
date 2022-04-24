Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChBNormal.CheckedChanged
        If ChBNormal.Checked = True Then
            BoletosNormal = Val(InputBox("Ingrese cantidad boletos Normal"))

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        LimpiarEntradas()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click

        If (MsgBox("¿Seguro que desea salir?", vbQuestion + vbYesNo, "Salida") = vbYes) Then
            End
        Else
            LimpiarEntradas()
        End If

    End Sub

    Private Sub ChB3D_CheckedChanged(sender As Object, e As EventArgs) Handles ChB3D.CheckedChanged
        If ChBNormal.Checked = True Then
            BoletosTresD = Val(InputBox("Ingrese cantidad boletos 3D"))
        End If
    End Sub

    Private Sub ChB4DX_CheckedChanged(sender As Object, e As EventArgs) Handles ChB4DX.CheckedChanged
        If ChBNormal.Checked = True Then
            BoletosCuatroDX = Val(InputBox("Ingrese cantidad boletos 4DX"))
        End If
    End Sub
End Class
