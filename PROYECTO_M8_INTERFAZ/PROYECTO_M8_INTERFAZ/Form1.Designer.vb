<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MoverArriba = New System.Windows.Forms.Button()
        Me.MoverIzquierda = New System.Windows.Forms.Button()
        Me.MoverAbajo = New System.Windows.Forms.Button()
        Me.MoverDerecha = New System.Windows.Forms.Button()
        Me.PuertoSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.ReiniciarPosicion = New System.Windows.Forms.Button()
        Me.PrimerRutina = New System.Windows.Forms.Button()
        Me.SegundaRutina = New System.Windows.Forms.Button()
        Me.EncenderLuces = New System.Windows.Forms.Button()
        Me.ApagarLuces = New System.Windows.Forms.Button()
        Me.EncenderAlarma = New System.Windows.Forms.Button()
        Me.TituloGradosBase = New System.Windows.Forms.Label()
        Me.TituloGradoBrazo = New System.Windows.Forms.Label()
        Me.TituloEstadoLuz = New System.Windows.Forms.Label()
        Me.MostrarGradosBrazo = New System.Windows.Forms.TextBox()
        Me.MostrarGradosBase = New System.Windows.Forms.TextBox()
        Me.MostrarEstadoLuz = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerBoton = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoverArriba
        '
        Me.MoverArriba.BackgroundImage = CType(resources.GetObject("MoverArriba.BackgroundImage"), System.Drawing.Image)
        Me.MoverArriba.Location = New System.Drawing.Point(80, 237)
        Me.MoverArriba.MaximumSize = New System.Drawing.Size(64, 64)
        Me.MoverArriba.MinimumSize = New System.Drawing.Size(64, 64)
        Me.MoverArriba.Name = "MoverArriba"
        Me.MoverArriba.Size = New System.Drawing.Size(64, 64)
        Me.MoverArriba.TabIndex = 0
        Me.MoverArriba.UseVisualStyleBackColor = True
        '
        'MoverIzquierda
        '
        Me.MoverIzquierda.BackgroundImage = CType(resources.GetObject("MoverIzquierda.BackgroundImage"), System.Drawing.Image)
        Me.MoverIzquierda.Location = New System.Drawing.Point(12, 307)
        Me.MoverIzquierda.MaximumSize = New System.Drawing.Size(64, 64)
        Me.MoverIzquierda.MinimumSize = New System.Drawing.Size(64, 64)
        Me.MoverIzquierda.Name = "MoverIzquierda"
        Me.MoverIzquierda.Size = New System.Drawing.Size(64, 64)
        Me.MoverIzquierda.TabIndex = 1
        Me.MoverIzquierda.UseVisualStyleBackColor = True
        '
        'MoverAbajo
        '
        Me.MoverAbajo.BackgroundImage = CType(resources.GetObject("MoverAbajo.BackgroundImage"), System.Drawing.Image)
        Me.MoverAbajo.Location = New System.Drawing.Point(80, 307)
        Me.MoverAbajo.MaximumSize = New System.Drawing.Size(64, 64)
        Me.MoverAbajo.MinimumSize = New System.Drawing.Size(64, 64)
        Me.MoverAbajo.Name = "MoverAbajo"
        Me.MoverAbajo.Size = New System.Drawing.Size(64, 64)
        Me.MoverAbajo.TabIndex = 2
        Me.MoverAbajo.UseVisualStyleBackColor = True
        '
        'MoverDerecha
        '
        Me.MoverDerecha.BackgroundImage = CType(resources.GetObject("MoverDerecha.BackgroundImage"), System.Drawing.Image)
        Me.MoverDerecha.Location = New System.Drawing.Point(150, 307)
        Me.MoverDerecha.MaximumSize = New System.Drawing.Size(64, 64)
        Me.MoverDerecha.MinimumSize = New System.Drawing.Size(64, 64)
        Me.MoverDerecha.Name = "MoverDerecha"
        Me.MoverDerecha.Size = New System.Drawing.Size(64, 64)
        Me.MoverDerecha.TabIndex = 3
        Me.MoverDerecha.UseVisualStyleBackColor = True
        '
        'PuertoSerial
        '
        Me.PuertoSerial.PortName = "COM3"
        '
        'ReiniciarPosicion
        '
        Me.ReiniciarPosicion.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReiniciarPosicion.Location = New System.Drawing.Point(437, 309)
        Me.ReiniciarPosicion.MaximumSize = New System.Drawing.Size(85, 65)
        Me.ReiniciarPosicion.MinimumSize = New System.Drawing.Size(85, 65)
        Me.ReiniciarPosicion.Name = "ReiniciarPosicion"
        Me.ReiniciarPosicion.Size = New System.Drawing.Size(85, 65)
        Me.ReiniciarPosicion.TabIndex = 4
        Me.ReiniciarPosicion.Text = "Reiniciar"
        Me.ReiniciarPosicion.UseVisualStyleBackColor = True
        '
        'PrimerRutina
        '
        Me.PrimerRutina.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrimerRutina.Location = New System.Drawing.Point(244, 309)
        Me.PrimerRutina.MaximumSize = New System.Drawing.Size(85, 65)
        Me.PrimerRutina.MinimumSize = New System.Drawing.Size(85, 65)
        Me.PrimerRutina.Name = "PrimerRutina"
        Me.PrimerRutina.Size = New System.Drawing.Size(85, 65)
        Me.PrimerRutina.TabIndex = 5
        Me.PrimerRutina.Text = "Rutina 1"
        Me.PrimerRutina.UseVisualStyleBackColor = True
        '
        'SegundaRutina
        '
        Me.SegundaRutina.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SegundaRutina.Location = New System.Drawing.Point(335, 309)
        Me.SegundaRutina.MaximumSize = New System.Drawing.Size(85, 65)
        Me.SegundaRutina.MinimumSize = New System.Drawing.Size(85, 65)
        Me.SegundaRutina.Name = "SegundaRutina"
        Me.SegundaRutina.Size = New System.Drawing.Size(85, 65)
        Me.SegundaRutina.TabIndex = 6
        Me.SegundaRutina.Text = "Rutina 2"
        Me.SegundaRutina.UseVisualStyleBackColor = True
        '
        'EncenderLuces
        '
        Me.EncenderLuces.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncenderLuces.Location = New System.Drawing.Point(437, 12)
        Me.EncenderLuces.MaximumSize = New System.Drawing.Size(85, 65)
        Me.EncenderLuces.MinimumSize = New System.Drawing.Size(85, 65)
        Me.EncenderLuces.Name = "EncenderLuces"
        Me.EncenderLuces.Size = New System.Drawing.Size(85, 65)
        Me.EncenderLuces.TabIndex = 7
        Me.EncenderLuces.Text = "Encender Luces"
        Me.EncenderLuces.UseVisualStyleBackColor = True
        '
        'ApagarLuces
        '
        Me.ApagarLuces.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApagarLuces.Location = New System.Drawing.Point(437, 83)
        Me.ApagarLuces.MaximumSize = New System.Drawing.Size(85, 65)
        Me.ApagarLuces.MinimumSize = New System.Drawing.Size(85, 65)
        Me.ApagarLuces.Name = "ApagarLuces"
        Me.ApagarLuces.Size = New System.Drawing.Size(85, 65)
        Me.ApagarLuces.TabIndex = 8
        Me.ApagarLuces.Text = "Apagar Luces"
        Me.ApagarLuces.UseVisualStyleBackColor = True
        '
        'EncenderAlarma
        '
        Me.EncenderAlarma.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncenderAlarma.Location = New System.Drawing.Point(437, 196)
        Me.EncenderAlarma.MaximumSize = New System.Drawing.Size(85, 65)
        Me.EncenderAlarma.MinimumSize = New System.Drawing.Size(85, 65)
        Me.EncenderAlarma.Name = "EncenderAlarma"
        Me.EncenderAlarma.Size = New System.Drawing.Size(85, 65)
        Me.EncenderAlarma.TabIndex = 9
        Me.EncenderAlarma.Text = "Alarma"
        Me.EncenderAlarma.UseVisualStyleBackColor = True
        '
        'TituloGradosBase
        '
        Me.TituloGradosBase.AutoSize = True
        Me.TituloGradosBase.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TituloGradosBase.Location = New System.Drawing.Point(241, 116)
        Me.TituloGradosBase.Name = "TituloGradosBase"
        Me.TituloGradosBase.Size = New System.Drawing.Size(102, 14)
        Me.TituloGradosBase.TabIndex = 10
        Me.TituloGradosBase.Text = "Grados de la Base:"
        '
        'TituloGradoBrazo
        '
        Me.TituloGradoBrazo.AutoSize = True
        Me.TituloGradoBrazo.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TituloGradoBrazo.Location = New System.Drawing.Point(241, 52)
        Me.TituloGradoBrazo.Name = "TituloGradoBrazo"
        Me.TituloGradoBrazo.Size = New System.Drawing.Size(98, 14)
        Me.TituloGradoBrazo.TabIndex = 11
        Me.TituloGradoBrazo.Text = "Grados del Brazo:"
        '
        'TituloEstadoLuz
        '
        Me.TituloEstadoLuz.AutoSize = True
        Me.TituloEstadoLuz.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TituloEstadoLuz.Location = New System.Drawing.Point(241, 190)
        Me.TituloEstadoLuz.Name = "TituloEstadoLuz"
        Me.TituloEstadoLuz.Size = New System.Drawing.Size(83, 14)
        Me.TituloEstadoLuz.TabIndex = 12
        Me.TituloEstadoLuz.Text = "Estado De Luz:"
        '
        'MostrarGradosBrazo
        '
        Me.MostrarGradosBrazo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MostrarGradosBrazo.Location = New System.Drawing.Point(244, 74)
        Me.MostrarGradosBrazo.Name = "MostrarGradosBrazo"
        Me.MostrarGradosBrazo.Size = New System.Drawing.Size(137, 20)
        Me.MostrarGradosBrazo.TabIndex = 13
        '
        'MostrarGradosBase
        '
        Me.MostrarGradosBase.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MostrarGradosBase.Location = New System.Drawing.Point(244, 135)
        Me.MostrarGradosBase.Name = "MostrarGradosBase"
        Me.MostrarGradosBase.Size = New System.Drawing.Size(137, 20)
        Me.MostrarGradosBase.TabIndex = 14
        '
        'MostrarEstadoLuz
        '
        Me.MostrarEstadoLuz.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MostrarEstadoLuz.Location = New System.Drawing.Point(244, 215)
        Me.MostrarEstadoLuz.Name = "MostrarEstadoLuz"
        Me.MostrarEstadoLuz.Size = New System.Drawing.Size(137, 20)
        Me.MostrarEstadoLuz.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'TimerBoton
        '
        Me.TimerBoton.Enabled = True
        Me.TimerBoton.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MostrarEstadoLuz)
        Me.Controls.Add(Me.MostrarGradosBase)
        Me.Controls.Add(Me.MostrarGradosBrazo)
        Me.Controls.Add(Me.TituloEstadoLuz)
        Me.Controls.Add(Me.TituloGradoBrazo)
        Me.Controls.Add(Me.TituloGradosBase)
        Me.Controls.Add(Me.EncenderAlarma)
        Me.Controls.Add(Me.ApagarLuces)
        Me.Controls.Add(Me.EncenderLuces)
        Me.Controls.Add(Me.SegundaRutina)
        Me.Controls.Add(Me.PrimerRutina)
        Me.Controls.Add(Me.ReiniciarPosicion)
        Me.Controls.Add(Me.MoverDerecha)
        Me.Controls.Add(Me.MoverAbajo)
        Me.Controls.Add(Me.MoverIzquierda)
        Me.Controls.Add(Me.MoverArriba)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 450)
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interfaz"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoverArriba As Button
    Friend WithEvents MoverIzquierda As Button
    Friend WithEvents MoverAbajo As Button
    Friend WithEvents MoverDerecha As Button
    Friend WithEvents PuertoSerial As IO.Ports.SerialPort
    Friend WithEvents ReiniciarPosicion As Button
    Friend WithEvents PrimerRutina As Button
    Friend WithEvents SegundaRutina As Button
    Friend WithEvents EncenderLuces As Button
    Friend WithEvents ApagarLuces As Button
    Friend WithEvents EncenderAlarma As Button
    Friend WithEvents TituloGradosBase As Label
    Friend WithEvents TituloGradoBrazo As Label
    Friend WithEvents TituloEstadoLuz As Label
    Friend WithEvents MostrarGradosBrazo As TextBox
    Friend WithEvents MostrarGradosBase As TextBox
    Friend WithEvents MostrarEstadoLuz As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerBoton As Timer
End Class
