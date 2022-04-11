Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (INDICE <= 10) Then
            CLIENTE(INDICE) = txtCliente.Text
            VALOR(INDICE) = Val(txtValor.Text)
            PESO(INDICE) = Val(InputBox("Ingrese peso del paquete"))
            TIPO(INDICE) = CbTipos.Text
            TRANSPORTE(INDICE) = CbTransporte.Text
            If TRANSPORTE(INDICE) = "Camión" Then
                If TIPO(INDICE) = "Documentos" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * documentos
                ElseIf TIPO(INDICE) = "Ropa" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * ropa
                ElseIf TIPO(INDICE) = "Artículos Perecederos" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * pedecederos
                ElseIf TIPO(INDICE) = "Artículos Plásticos" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * plastico
                ElseIf TIPO(INDICE) = "Lociones" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * lociones
                End If
                PARCIAL(INDICE) = Math.Round(camion + IMPUESTO(INDICE), 2)

            ElseIf TRANSPORTE(INDICE) = "Motocicleta" Then
                If TIPO(INDICE) = "Documentos" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * documentos
                ElseIf TIPO(INDICE) = "Ropa" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * ropa
                ElseIf TIPO(INDICE) = "Artículos Perecederos" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * pedecederos
                ElseIf TIPO(INDICE) = "Artículos Plásticos" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * plastico
                ElseIf TIPO(INDICE) = "Lociones" Then
                    IMPUESTO(INDICE) = VALOR(INDICE) * lociones
                End If
                PARCIAL(INDICE) = Math.Round(moto + IMPUESTO(INDICE), 2)
            End If

            TOTAL(INDICE) = Math.Round(PARCIAL(INDICE) + VALOR(INDICE), 2)

            mostrar_vectores()
            INDICE = INDICE + 1
        End If

        If (INDICE = 10) Then
            MsgBox("Los Vectores están llenos")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVERCTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVERCTORESToolStripMenuItem.Click
        INDICE = 0

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub

    Private Sub ESTADISTICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICAToolStripMenuItem.Click
        Dim i As Byte
        Dim totlociones As Double
        Dim totdocumentos As Double
        Dim totropa As Double
        Dim totplasticos As Double
        totplasticos = 0
        totropa = 0
        totlociones = 0
        totdocumentos = 0
        For i = 0 To 10

            If (ListBox4.Text = "Documentos") Then

                totdocumentos = totdocumentos + VALOR(i)

                If (CbTipos.Text = "Lociones") Then
                    totlociones = totlociones + VALOR(INDICE)
                End If

                If (CbTipos.Text = "Ropa") Then
                    totropa = totropa + 1
                End If
                If (CbTipos.Text = "Artículos Plásticos") Then
                    totplasticos = totplasticos + 1
                End If

            Else
                Exit For
            End If
        Next i
        txtTotalEnviosDocumentos.Text = Str(totdocumentos)
        txtTotalEnviosLociones.Text = Str(totlociones)
        txtTotalEnviosPlastico.Text = Str(totplasticos)
        txtTotalPaquetesEnviadosRopa.Text = Str(totropa)
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Está seguro que desea salir?", vbQuestion + vbYesNo, "SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub txtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliente.KeyPress

    End Sub

    Private Sub txtTotalEnviosLociones_TextChanged(sender As Object, e As EventArgs) Handles txtTotalEnviosLociones.TextChanged
        If (CbTipos.Text = "Lociones") Then
            If CbTransporte.Text = "Camión" Then
                txtTotalEnviosLociones.Text = Str(TOTAL)
            Else
                txtTotalEnviosLociones.Text = Str(TOTAL)
            End If
        End If
    End Sub

    Private Sub txtTotalEnviosPlastico_TextChanged(sender As Object, e As EventArgs) Handles txtTotalEnviosPlastico.TextChanged
        If (CbTipos.Text = "Artículos Plásticos") Then

        Else
            txtTotalEnviosPlastico.Text = "0.00"
        End If
    End Sub

    Private Sub txtTotalEnviosDocumentos_TextChanged(sender As Object, e As EventArgs) Handles txtTotalEnviosDocumentos.TextChanged
        If (CbTipos.Text = "Documentos") Then
            If CbTransporte.Text = "Camión" Then
                txtTotalEnviosDocumentos.Text = Str(TOTAL)
            Else
                txtTotalEnviosDocumentos.Text = Str(TOTAL)
            End If
        End If
    End Sub

    Private Sub txtTotalPaquetesEnviados_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPaquetesEnviadosRopa.TextChanged
        If (CbTipos.Text = "Ropa") Then

        Else
            txtTotalPaquetesEnviadosRopa.Text = "0.00"
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
