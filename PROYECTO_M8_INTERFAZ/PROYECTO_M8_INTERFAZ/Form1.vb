Public Class Form1
    Public BrazoPosicion As Integer = 30
    Public BasePosicion As Integer = 90

    'Inicialización del form'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PuertoSerial.Open()
        MostrarGradosBrazo.Text = BrazoPosicion
        MostrarGradosBase.Text = BasePosicion
        MostrarEstadoLuz.Text = "Luces apagadas"
    End Sub
    'Movemos el brazo hacia arriba'
    Private Sub MoverArriba_Click(sender As Object, e As EventArgs) Handles MoverArriba.Click
        PuertoSerial.Write("W")
        BrazoPosicion = BrazoPosicion + 10
        MostrarGradosBrazo.Text = BrazoPosicion
    End Sub
    'Movemos el brazo hacia abajo'
    Private Sub MoverAbajo_Click(sender As Object, e As EventArgs) Handles MoverAbajo.Click
        PuertoSerial.Write("S")
        BrazoPosicion = BrazoPosicion - 10
        MostrarGradosBrazo.Text = BrazoPosicion
    End Sub
    'Movemos la base hacia la izquierda'
    Private Sub MoverIzquierda_Click(sender As Object, e As EventArgs) Handles MoverIzquierda.Click
        PuertoSerial.Write("A")
        BasePosicion = BasePosicion + 10
        MostrarGradosBase.Text = BasePosicion
    End Sub
    'Movemos la base hacia la derecha'
    Private Sub MoverDerecha_Click(sender As Object, e As EventArgs) Handles MoverDerecha.Click
        PuertoSerial.Write("D")
        BasePosicion = BasePosicion - 10
        MostrarGradosBase.Text = BasePosicion
    End Sub
    'Volver a la posición inicial'
    Private Sub ReiniciarPosicion_Click(sender As Object, e As EventArgs) Handles ReiniciarPosicion.Click
        PuertoSerial.Write("R")
        BrazoPosicion = 30
        BasePosicion = 90
        MostrarGradosBrazo.Text = BrazoPosicion
        MostrarGradosBase.Text = BasePosicion
    End Sub
    'Hacer la primer rutina'
    Private Sub PrimerRutina_Click(sender As Object, e As EventArgs) Handles PrimerRutina.Click
        PuertoSerial.Write("P")
    End Sub
    'Hacer la segunda rutina'
    Private Sub SegundaRutina_Click(sender As Object, e As EventArgs) Handles SegundaRutina.Click
        PuertoSerial.Write("O")
    End Sub
    'Se encienden las luces'
    Private Sub EncenderLuces_Click(sender As Object, e As EventArgs) Handles EncenderLuces.Click
        PuertoSerial.Write("Z")
        MostrarEstadoLuz.Text = "Luces endendidas"
    End Sub
    'Se apagan las luces'
    Private Sub ApagarLuces_Click(sender As Object, e As EventArgs) Handles ApagarLuces.Click
        PuertoSerial.Write("X")
        MostrarEstadoLuz.Text = "Luces apagadas"
    End Sub
    'Encender alarma'
    Private Sub EncenderAlarma_Click(sender As Object, e As EventArgs) Handles EncenderAlarma.Click
        PuertoSerial.Write("E")
    End Sub

    Private Sub TimerBoton_Tick(sender As Object, e As EventArgs) Handles TimerBoton.Tick
        If BrazoPosicion = 80 Then
            MoverArriba.Enabled = False
        Else
            MoverArriba.Enabled = True
        End If

        If BrazoPosicion = 10 Then
            MoverAbajo.Enabled = False
        Else
            MoverAbajo.Enabled = True
        End If

        If BasePosicion = 180 Then
            MoverIzquierda.Enabled = False
        Else
            MoverIzquierda.Enabled = True
        End If

        If BasePosicion = 0 Then
            MoverDerecha.Enabled = False
        Else
            MoverDerecha.Enabled = True
        End If
    End Sub
End Class
