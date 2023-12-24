Public Class GPTcounter1

    ' ... VARIABLES ...

    ' Variables para el contador y el archivo
    Private count As Integer = 0
    Private filePath As String = "contador.txt"

    ' Variables para el cronómetro
    Private stopwatch As New Stopwatch()
    Private MaxTime As TimeSpan = TimeSpan.FromHours(3)
    Private mensajeMostrado As Boolean = False

    ' Variables para el sonido
    Private soundEnabled As Boolean = True


    ' Variables para el la ventana
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, 0)

    End Sub

    ' Definir SoundPlayer a nivel de clase
    Private soundPlayer As New System.Media.SoundPlayer()


    ' ... MÉTODOS ...

    ' Método para actualizar el CONTADOR con color de digito individual

    Private Sub UpdateCount()

        ' Descomponer el contador en dígitos individuales
        Dim digits = count.ToString("D3").ToCharArray()

        ' Actualizar cada etiqueta con el dígito correspondiente
        UpdateDigitLabel(LabelDigit1, digits(0), count >= 40)
        UpdateDigitLabel(LabelDigit2, digits(1), count >= 15)
        UpdateDigitLabel(LabelDigit2, digits(1), count >= 10)
        UpdateDigitLabel(LabelDigit3, digits(2), count >= 1)

        ' Verificar si el contador ha llegado a 30
        If count = 30 Then
            ' Crear y mostrar el formulario de diálogo
            If count = 30 Then
                MessageBox.Show("Te quedan 10 interacciones.", "Interacciones disponibles")
            End If
        End If

        ' Verificar si el contador ha llegado a 40
        If count = 40 Then
            ' Crear y mostrar el formulario de diálogo
            Dim dialog As New CustomMessageBox()
            dialog.ShowDialog()
        End If

    End Sub

    ' ... PERSONALIZACIÓN ...

    Private Sub UpdateDigitLabel(label As Label, digit As Char, specialColor As Boolean)
        label.Text = digit.ToString()

        ' Establecer los colores
        If specialColor Then
            If count >= 40 Then
                ' Fondo rojo y texto blanco para todos los dígitos
                label.BackColor = Color.Red
                label.ForeColor = Color.Black
            ElseIf count >= 30 Then
                ' Fondo negro y texto naranja
                label.BackColor = Color.Black
                label.ForeColor = Color.Red
            ElseIf count >= 15 Then
                ' Fondo negro y texto naranja
                label.BackColor = Color.Black
                label.ForeColor = Color.Orange
            Else
                ' Fondo negro y texto blanco
                label.BackColor = Color.Black
                label.ForeColor = Color.White
            End If
        Else
            ' Colores por defecto
            label.BackColor = Color.Black
            label.ForeColor = Color.Lime
        End If

    End Sub


    ' ... ... ... ... LOAD ... ... ... ...

    ' Evento Load del formulario
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Stopwatch.Start()

    End Sub

    Private Sub MainForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Iniciar el cronómetro
        stopwatch.Start()

        ' Iniciar el temporizador para actualizar la interfaz de usuario
        Timer2.Start()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar el sonido desde los recursos
        soundPlayer.Stream = My.Resources.beepi
    End Sub


    ' ... ... ... ... EVENTOS ... ... ... ...

    ' Evento Tick del RELOJ
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Actualizar RELOJ
        lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub

    ' Evento Tick del Timer para el cronómetro
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Actualizar el cronómetro en la interfaz de usuario
        If stopwatch.Elapsed <= MaxTime Then
            lblTimer.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        Else
            If Not mensajeMostrado Then
                ' Detener el cronómetro y el Timer
                stopwatch.Stop()
                Timer2.Stop()

                lblTimer.Text = "03:00:00" ' Ajustar según el formato que prefieras

                ' Mostrar el mensaje
                MessageBox.Show("Sesión de 3 horas completada, restablece el cronómetro", "Tiempo límite de Sesión alcanzado")
                mensajeMostrado = True
            End If
        End If
    End Sub


    ' ... ... ... ... BOTONES ... ... ... ...

    ' Button 1 Aumentar CONTADOR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Sumar uno contador
        count += 1
        UpdateCount()

        ' Hacer sonar (sonido DINERO)
        If soundEnabled Then
            Dim sound As New System.Media.SoundPlayer(My.Resources.caja_registradora_dinero)
            sound.Play()
        End If

    End Sub

    ' Button 2 disminuir CONTADOR
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Hacer sonar (sonido BOCINA)
        If soundEnabled Then
            Dim sound As New System.Media.SoundPlayer(My.Resources.dun_dun_dun)
            sound.Play()
        End If

        ' Mostrar un cuadro de diálogo de mensaje para confirmar la acción
        Dim result As DialogResult = MessageBox.Show("Vas a restar 1 Interacción", "Confirma restar", MessageBoxButtons.YesNo)

        ' Verificar si el usuario presionó el botón 'Sí'
        If result = DialogResult.Yes Then
            ' Restar uno al contador
            If count > 0 Then
                count -= 1

                UpdateCount()
            End If
        End If

    End Sub

    ' Button 3 Restablecer CONTADOR

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Hacer sonar (sonido BOCINA INCORRECTO)
        If soundEnabled Then
            Dim sound As New System.Media.SoundPlayer(My.Resources.incorrecto_bocina_)
            sound.Play()
        End If

        ' Mostrar un cuadro de diálogo de mensaje para confirmar la acción
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que quieres restablecer el Contador de Interacciones?", "Confirmar Restablecimiento de Contador", MessageBoxButtons.YesNo)

        ' Verificar si el usuario presionó el botón 'Sí'
        If result = DialogResult.Yes Then
            ' Restablecer el contador y actualizar la interfaz
            count = 0
            UpdateCount()
        End If

    End Sub

    ' Button 4 Restablecer CRONÓMETRO
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Hacer sonar (sonido MARCADOR)
        If soundEnabled Then
            Dim sound As New System.Media.SoundPlayer(My.Resources.trompeta_baseball_)
            sound.Play()
        End If

        ' Mostrar un cuadro de diálogo de mensaje para confirmar la acción
        Dim result As DialogResult = MessageBox.Show("Vas a restablecer el crónometro de la Sesión", "Confirmar Restablecimiento de Sesión", MessageBoxButtons.YesNo)

        ' Verificar si el usuario presionó el botón 'Sí'
        If result = DialogResult.Yes Then
            ' Restablecer el CRONÓMETRO
            stopwatch.Reset()
            lblTimer.Text = "00:00:00"
            ' Reiniciar el mensaje mostrado
            mensajeMostrado = False

            ' Reiniciar y empezar el Timer2
            Timer2.Start()
            stopwatch.Start()
        End If

    End Sub

    ' Button 5 Redes Sociales
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Hacer sonar (sonido DISPARO)
        If soundEnabled Then
            Dim sound As New System.Media.SoundPlayer(My.Resources.bang)
            sound.Play()
        End If

        ' Mostrar un cuadro de diálogo de mensaje para confirmar la acción
        Dim result As DialogResult = MessageBox.Show("Vas a abrir mi Red Social", "Confirmar Restablecimiento", MessageBoxButtons.OK)
        ' Verificar si el usuario presionó el botón 'Sí'
        If result = DialogResult.OK Then
        End If
        Process.Start("https://twitter.com/senecadpj")

    End Sub

    ' Button 6 My WEB
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Hacer sonar (sonido DISPARO)
        If soundEnabled Then
            Dim sound As New System.Media.SoundPlayer(My.Resources.bang)
            sound.Play()
        End If

        ' Mostrar un cuadro de diálogo de mensaje para confirmar la acción
        Dim result As DialogResult = MessageBox.Show("Vas a abrir mi Wordpress", "Confirmar Restablecimiento", MessageBoxButtons.OK)
        ' Verificar si el usuario presionó el botón 'Sí'
        If result = DialogResult.OK Then
        End If
        Process.Start("https://senecadpj.wordpress.com")

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Alternar el estado del sonido
        soundEnabled = Not soundEnabled

        If soundEnabled Then
            Button7.Image = My.Resources.ON_vol1
            soundPlayer.Play() ' Reproducir el sonido en bucle
        Else
            Button7.Image = My.Resources.OFF_vol1
            soundPlayer.Stop() ' Detener la reproducción del sonido
        End If

    End Sub

End Class
