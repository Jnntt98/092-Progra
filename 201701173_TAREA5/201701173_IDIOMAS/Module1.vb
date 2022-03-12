Module Module1
    Public Inscripciones(8, 9) As String

    Public Nombre As String
    Public Carnet As Integer
    Public Idioma As String
    Public Dias As String
    Public Horas As Integer
    Public Pago As String
    Public Total As Double
    Public Descuento1 As Double
    Public Descuento2 As Double
    Public TotalFinal As Double

    Public Const Efectivo = 0.02
    Public Const Cheque = 0.015
    Public Const AmbosDias = 0.05


    Public Const Ingles = 150
    Public Const Portugues = 80
    Public Const Frances = 125

    Public fila As Byte = 0

    Sub LimpiarMatriz()

        Dim i As Byte, j As Byte

        For i = 0 To 7
            For j = 0 To 9
                Inscripciones(i, j) = Nothing
            Next j
        Next i

        Form1.DataGridView1.Rows.Clear()

        fila = 0

    End Sub
    Sub LimpiarEntradas()
        Form1.TxtCarnet.Text = ""
        Form1.TxtNombre.Text = ""

        Form1.ChBxViernes.Checked = False
        Form1.ChBxSabado.Checked = False

        Form1.CBxIdioma.Text = "Idioma"

        Form1.RbEfectivo.Checked = False
        Form1.RbCheque.Checked = False

    End Sub
    Sub MostrarDatos()
        Dim i As Byte

        For i = 0 To 7
            If Inscripciones(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Inscripciones(i, 0), Inscripciones(i, 1), Inscripciones(i, 2), Inscripciones(i, 3), Inscripciones(i, 4), Inscripciones(i, 5), Inscripciones(i, 6), Inscripciones(i, 7), Inscripciones(i, 8), Inscripciones(i, 9))
            Else

                Exit For
            End If
        Next i
    End Sub

    Sub Salir()

        If (MsgBox("¿Seguro que desea salir?", vbQuestion + vbYesNo, "Salida") = vbYes) Then
            End
        Else
            LimpiarEntradas()
        End If

    End Sub
End Module
