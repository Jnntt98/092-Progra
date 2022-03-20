Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        NombrePack(Indice) = Val(InputBox("Ingrese nombre del pack"))
        CantidadDeseada(Indice) = Val(InputBox("Ingrese cantidad de productos"))

        If RbJugos.Checked Then
            TipoProducto(Indice) = "jugos"
            CantidadInventario(Indice) = Val(Inventario - CantidadDeseada(Indice))
            CantidadPacks(Indice) = Val(CantidadDeseada(Indice) / CantidadInventario(Indice))
            If CantidadDeseada(Indice) <= 3 Then
                Descuento(Indice) = Val(Jugos * CantidadDeseada(Indice) * 3%)
                PrecioVenta(Indice) = Val(Jugos * CantidadDeseada(Indice))
                IngresosSobrante(Indice) = Val(Jugos * CantidadInventario(Indice))
                TOTAL(Indice) = Val(PrecioVenta(Indice) - Descuento(Indice))
                DataGridView1.Rows.Add(Str(NombrePack(Indice)), CantidadDeseada(Indice), TipoProducto(Indice), CantidadInventario(Indice), IngresosSobrante(Indice), Descuento(Indice), PrecioVenta(Indice), TOTAL(Indice))
            ElseIf CantidadDeseada(Indice) <= 5 Then
                Descuento(Indice) = Val(Jugos * CantidadDeseada(Indice) * 5%)
                PrecioVenta(Indice) = Val(Jugos * CantidadDeseada(Indice))
                IngresosSobrante(Indice) = Val(Jugos * CantidadInventario(Indice))
                TOTAL(Indice) = Val(PrecioVenta(Indice) - Descuento(Indice))
                DataGridView1.Rows.Add(Str(NombrePack(Indice)), CantidadDeseada(Indice), TipoProducto(Indice), CantidadInventario(Indice), IngresosSobrante(Indice), Descuento(Indice), PrecioVenta(Indice), TOTAL(Indice))
            ElseIf CantidadDeseada(Indice) >= 10 Then
                Descuento(Indice) = Val(Jugos * CantidadDeseada(Indice) * 10%)
                PrecioVenta(Indice) = Val(Jugos * CantidadDeseada(Indice))
                IngresosSobrante(Indice) = Val(Jugos * CantidadInventario(Indice))
                TOTAL(Indice) = Val(PrecioVenta(Indice) - Descuento(Indice))
                DataGridView1.Rows.Add(Str(NombrePack(Indice)), CantidadDeseada(Indice), TipoProducto(Indice), CantidadInventario(Indice), IngresosSobrante(Indice), Descuento(Indice), PrecioVenta(Indice), TOTAL(Indice))

            End If
        ElseIf RbFrituras.Checked Then

        ElseIf RbGalletas.Checked Then

        ElseIf RbBaterias.Checked Then
        End If

        If RbFrituras.Checked Then

        End If

        If RbGalletas.Checked Then

        End If

        If RbBaterias.Checked Then

        End If




    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            LimpiarEntradas()
        End If
    End Sub
End Class
