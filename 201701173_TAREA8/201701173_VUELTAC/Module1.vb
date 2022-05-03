Module Module1
    Public indice As Byte = 0


    Public Nombre(11) As String
    Public Etapa(11) As String
    Public Equipo(11) As String
    Public KmRecorridos(11) As Double
    Public Nacionalidad(11) As Double
    Public Penalizacion(11) As Double

    Sub LimpiarVectores()
        indice = 0

        Form1.TxtNombre.Clear()
        Form1.TxtKmRecorridos.Clear()
        Form1.TxtTiempo.Clear()
        Form1.CbEquipo.SelectedIndex = -1
        Form1.CbEquipo.SelectedIndex = -1
        Form1.CbNacionalidad.SelectedIndex = -1
        Form1.DataGridView1.Columns.Clear()

        Form1.txtNombre.Focus()

    End Sub

End Module
