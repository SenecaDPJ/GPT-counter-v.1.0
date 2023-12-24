<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GPTcounter1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GPTcounter1))
        Me.LabelDigit3 = New System.Windows.Forms.Label()
        Me.LabelDigit2 = New System.Windows.Forms.Label()
        Me.LabelDigit1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelDigit3
        '
        Me.LabelDigit3.AutoSize = True
        Me.LabelDigit3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDigit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDigit3.ForeColor = System.Drawing.Color.Lime
        Me.LabelDigit3.Location = New System.Drawing.Point(125, 182)
        Me.LabelDigit3.Name = "LabelDigit3"
        Me.LabelDigit3.Size = New System.Drawing.Size(53, 59)
        Me.LabelDigit3.TabIndex = 36
        Me.LabelDigit3.Text = "0"
        '
        'LabelDigit2
        '
        Me.LabelDigit2.AutoSize = True
        Me.LabelDigit2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDigit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDigit2.ForeColor = System.Drawing.Color.Lime
        Me.LabelDigit2.Location = New System.Drawing.Point(65, 182)
        Me.LabelDigit2.Name = "LabelDigit2"
        Me.LabelDigit2.Size = New System.Drawing.Size(53, 59)
        Me.LabelDigit2.TabIndex = 35
        Me.LabelDigit2.Text = "0"
        '
        'LabelDigit1
        '
        Me.LabelDigit1.AutoSize = True
        Me.LabelDigit1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDigit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDigit1.ForeColor = System.Drawing.Color.Lime
        Me.LabelDigit1.Location = New System.Drawing.Point(5, 182)
        Me.LabelDigit1.Name = "LabelDigit1"
        Me.LabelDigit1.Size = New System.Drawing.Size(53, 59)
        Me.LabelDigit1.TabIndex = 34
        Me.LabelDigit1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(198, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "HORA LOCAL"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(184, 249)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 60)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "RESTABLECER"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Lime
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTimer.Location = New System.Drawing.Point(186, 315)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(103, 29)
        Me.lblTimer.TabIndex = 29
        Me.lblTimer.Text = "lblTimer"
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblCurrentTime.Location = New System.Drawing.Point(208, 96)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(100, 17)
        Me.lblCurrentTime.TabIndex = 28
        Me.lblCurrentTime.Text = "lblCurrentTime"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(184, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 60)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "RESTABLECER"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(5, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 92)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "menos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(5, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 99)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "más"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(55, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Interacciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(55, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Interacciones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(217, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Sesión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(38, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 20)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "40 interacciones cada 3 horas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(97, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "© SénecaDPJ 2023"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(58, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 31)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "GPT counter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label10.Location = New System.Drawing.Point(217, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "1.0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label11.Location = New System.Drawing.Point(29, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 15)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Contabiliza tus interacciónes con ChatGPT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(212, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Contador"
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.GPT_counter_v._1._0.My.Resources.Resources.ON_vol
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(211, 118)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(59, 57)
        Me.Button7.TabIndex = 40
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Image = Global.GPT_counter_v._1._0.My.Resources.Resources.MyWordpress_1
        Me.Button6.Location = New System.Drawing.Point(68, 355)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(26, 26)
        Me.Button6.TabIndex = 39
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Image = Global.GPT_counter_v._1._0.My.Resources.Resources.MyTwitter
        Me.Button5.Location = New System.Drawing.Point(201, 355)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 26)
        Me.Button5.TabIndex = 38
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GPTcounter1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(296, 391)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LabelDigit3)
        Me.Controls.Add(Me.LabelDigit2)
        Me.Controls.Add(Me.LabelDigit1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GPTcounter1"
        Me.Text = "GPT counter 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents LabelDigit3 As Label
    Friend WithEvents LabelDigit2 As Label
    Friend WithEvents LabelDigit1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblCurrentTime As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
End Class
