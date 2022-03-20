Imports System.Math
Public Class Form1
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Venta(Indice) = Str(TxtNoVenta.Text)
        Yardas(Indice) = Val(Val(TxtCuero.Text) + Val(TxtCuerina.Text))
        If RbSofa.Checked Then
            Tamaño(Indice) = "Sofá"
            If Yardas(Indice) >= 8 Then
                If RbCuero.Checked Then
                    Tela(Indice) = "Cuero"
                    Costo(Indice) = Sofa + Val(TxtCuero.Text) * YardaCuero
                    Total(Indice) = Costo(Indice) + (Val(Sofa + Val(TxtCuero.Text) * YardaCuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(Indice)), Tamaño(Indice), Tela(Indice), Str(Yardas(Indice)), Str(Costo(Indice)), Str(Total(Indice)))
                    Indice = Indice + 1
                ElseIf RbCuerina.Checked Then
                    Tela(Indice) = "Cuerina"
                    Costo(Indice) = Sofa + Val(TxtCuerina.Text) * YardaCuerina
                    Total(Indice) = Costo(Indice) + Round(Val(Sofa + Val(TxtCuerina.Text) * YardaCuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(Indice)), Tamaño(Indice), Tela(Indice), Str(Yardas(Indice)), Str(Costo(Indice)), Str(Total(Indice)))
                    Indice = Indice + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "Datos Insuficientes") = vbInformation Then

                End If
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "Datos Insuficientes") = vbInformation Then
            End If
        End If
        If RbIndividual.Checked Then
            Tamaño(Indice) = "Individual"
            If Yardas(Indice) >= 3.5 Then
                If RbCuero.Checked Then
                    Tela(Indice) = "Cuero"
                    Costo(Indice) = Individual + Val(TxtCuero.Text) * YardaCuero
                    Total(Indice) = Costo(Indice) + (Val(Individual + Val(TxtCuero.Text) * YardaCuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(Indice)), Tamaño(Indice), Tela(Indice), Str(Yardas(Indice)), Str(Costo(Indice)), Str(Total(Indice)))
                    Indice = Indice + 1
                ElseIf RbCuerina.Checked Then
                    Tela(Indice) = "Cuerina"
                    Costo(Indice) = Individual + Val(TxtCuerina.Text) * YardaCuerina
                    Total(Indice) = Costo(Indice) + Round(Val(Individual + Val(TxtCuerina.Text) * YardaCuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(Indice)), Tamaño(Indice), Tela(Indice), Str(Yardas(Indice)), Str(Costo(Indice)), Str(Total(Indice)))
                    Indice = Indice + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "Datos Insuficientes") = vbInformation Then

                End If

            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "Datos Insuficientes") = vbInformation Then
            End If
        End If
        If RbDoble.Checked Then
            Tamaño(Indice) = "Doble"
            If Yardas(Indice) >= 6 Then
                If RbCuero.Checked Then
                    Tela(Indice) = "Cuero"
                    Costo(Indice) = Doble + Val(TxtCuero.Text) * YardaCuero
                    Total(Indice) = Costo(Indice) + (Val(Doble + Val(TxtCuero.Text) * YardaCuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(Indice)), Tamaño(Indice), Tela(Indice), Str(Yardas(Indice)), Str(Costo(Indice)), Str(Total(Indice)))
                    Indice = Indice + 1
                ElseIf RbCuerina.Checked Then
                    Tela(Indice) = "Cuerina"
                    Costo(Indice) = Doble + Val(TxtCuerina.Text) * YardaCuerina
                    Total(Indice) = Costo(Indice) + (Val(Doble + Val(TxtCuerina.Text) * YardaCuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(Indice)), Tamaño(Indice), Tela(Indice), Str(Yardas(Indice)), Str(Costo(Indice)), Str(Total(Indice)))
                    Indice = Indice + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "Datos Insuficientes") = vbInformation Then

                End If

            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "Datos Insuficientes") = vbInformation Then
            End If
        End If
        If (Indice = 8) Then
            MsgBox("Los Vectores están llenos")
        End If
        LimpiarEntradas()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCuero.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCuerina.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RbCuero_CheckedChanged(sender As Object, e As EventArgs) Handles RbCuero.CheckedChanged
        If RbCuero.Checked Then
            TxtCuero.Enabled = True
            TxtCuerina.Enabled = False
        Else
            TxtCuero.Enabled = False
        End If
    End Sub

    Private Sub RbCuerina_CheckedChanged(sender As Object, e As EventArgs) Handles RbCuerina.CheckedChanged
        If RbCuerina.Checked Then
            TxtCuerina.Enabled = True
            TxtCuero.Enabled = False
        Else
            TxtCuerina.Enabled = False
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            LimpiarEntradas()
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDatosToolStripMenuItem.Click
        LimpiarEntradas()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TxtNoVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNoVenta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
