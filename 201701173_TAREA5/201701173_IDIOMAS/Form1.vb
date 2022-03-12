Public Class Form1
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)
        Carnet = Val(TxtCarnet.Text)
        Nombre = TxtNombre.Text
        Horas = Val(InputBox("Ingrese cantidad horas a estudiar:"))
        Inscripciones(fila, 0) = Carnet
        Inscripciones(fila, 1) = Nombre
        Inscripciones(fila, 4) = Horas

        Pago = 0

        If fila <= 7 Then

            Inscripciones(fila, 2) = CBxIdioma.Text

            If CBxIdioma.SelectedIndex = 0 Then
                Pago = Val(Val(Horas) * Ingles)
                Inscripciones(fila, 6) = Pago
            ElseIf CBxIdioma.SelectedIndex = 1 Then
                Pago = Val(Val(Horas) * Portugues)
                Inscripciones(fila, 6) = Pago
            ElseIf CBxIdioma.SelectedIndex = 2 Then
                Pago = Val(Val(Horas) * Frances)
                Inscripciones(fila, 6) = Pago
            Else
                MsgBox("Error, no seleccionó idioma")
                Exit Sub
            End If
            If (ChBxViernes.Checked) And (ChBxSabado.Checked) Then
                Inscripciones(fila, 3) = "V & S"
                Descuento2 = Val(Pago * AmbosDias)
                Inscripciones(fila, 8) = Descuento2
            ElseIf (ChBxViernes.Checked) Then
                Inscripciones(fila, 3) = "VIERNES"
            ElseIf (ChBxSabado.Checked) Then
                Inscripciones(fila, 3) = "SABADO"
            Else
                MsgBox("No seleccionó ningun dia")
                Exit Sub
            End If
            If (RbEfectivo.Checked) Then
                Inscripciones(fila, 5) = RbEfectivo.Text
                Descuento1 = Val(Pago * Efectivo)
                Inscripciones(fila, 7) = Descuento1
            ElseIf (RbCheque.Checked) Then
                Inscripciones(fila, 5) = RbCheque.Text
                Descuento1 = Val(Pago * Efectivo)
                Inscripciones(fila, 7) = Descuento1
            Else
                MsgBox("Error, no seleccionó tipo de pago")
                Exit Sub
            End If
            TotalFinal = Val(Pago - Descuento1 - Descuento2)
            Inscripciones(fila, 9) = TotalFinal
            fila = fila + 1
        End If
        If (fila = 8) Then
            MsgBox("Matriz llena")
        End If
        LimpiarEntradas()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ToolStripMostrar_Click(sender As Object, e As EventArgs)

        MostrarDatos()

    End Sub

    Private Sub ToolStripLimpiarEntradas_Click(sender As Object, e As EventArgs)

        LimpiarEntradas()

    End Sub

    Private Sub ToolStripLimpiarMatriz_Click(sender As Object, e As EventArgs)

        LimpiarMatriz()

    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs)

        Salir()

    End Sub

    Private Sub TxtCarnet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCarnet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
