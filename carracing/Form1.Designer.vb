<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.leftside = New System.Windows.Forms.Timer(Me.components)
        Me.rightside = New System.Windows.Forms.Timer(Me.components)
        Me.racer1move = New System.Windows.Forms.Timer(Me.components)
        Me.racer2move = New System.Windows.Forms.Timer(Me.components)
        Me.racer3move = New System.Windows.Forms.Timer(Me.components)
        Me.scoretext = New System.Windows.Forms.Label()
        Me.replaybutton = New System.Windows.Forms.Button()
        Me.gameover_text = New System.Windows.Forms.Label()
        Me.speedtext = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.racer4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.racer3 = New System.Windows.Forms.PictureBox()
        Me.racer2 = New System.Windows.Forms.PictureBox()
        Me.racer1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.racer4move = New System.Windows.Forms.Timer(Me.components)
        Me.car = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.racer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.racer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.racer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.racer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'leftside
        '
        Me.leftside.Interval = 10
        '
        'rightside
        '
        Me.rightside.Interval = 10
        '
        'racer1move
        '
        Me.racer1move.Enabled = True
        Me.racer1move.Interval = 10
        '
        'racer2move
        '
        Me.racer2move.Enabled = True
        Me.racer2move.Interval = 10
        '
        'racer3move
        '
        Me.racer3move.Enabled = True
        Me.racer3move.Interval = 10
        '
        'scoretext
        '
        Me.scoretext.AutoSize = True
        Me.scoretext.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoretext.ForeColor = System.Drawing.Color.Red
        Me.scoretext.Location = New System.Drawing.Point(93, 0)
        Me.scoretext.Name = "scoretext"
        Me.scoretext.Size = New System.Drawing.Size(97, 32)
        Me.scoretext.TabIndex = 0
        Me.scoretext.Text = "score 0"
        '
        'replaybutton
        '
        Me.replaybutton.BackColor = System.Drawing.Color.Red
        Me.replaybutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replaybutton.Location = New System.Drawing.Point(203, 413)
        Me.replaybutton.Name = "replaybutton"
        Me.replaybutton.Size = New System.Drawing.Size(135, 55)
        Me.replaybutton.TabIndex = 14
        Me.replaybutton.Text = "replay"
        Me.replaybutton.UseVisualStyleBackColor = False
        Me.replaybutton.Visible = False
        '
        'gameover_text
        '
        Me.gameover_text.AutoSize = True
        Me.gameover_text.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gameover_text.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameover_text.ForeColor = System.Drawing.Color.OrangeRed
        Me.gameover_text.Location = New System.Drawing.Point(148, 137)
        Me.gameover_text.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.gameover_text.Name = "gameover_text"
        Me.gameover_text.Size = New System.Drawing.Size(277, 54)
        Me.gameover_text.TabIndex = 15
        Me.gameover_text.Text = "gameover"
        Me.gameover_text.Visible = False
        '
        'speedtext
        '
        Me.speedtext.AutoSize = True
        Me.speedtext.Location = New System.Drawing.Point(199, 0)
        Me.speedtext.Name = "speedtext"
        Me.speedtext.Size = New System.Drawing.Size(0, 20)
        Me.speedtext.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(391, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "speed 0"
        '
        'racer4
        '
        Me.racer4.Image = Global.carracing.My.Resources.Resources.racing_car_149034_960_720
        Me.racer4.Location = New System.Drawing.Point(402, 26)
        Me.racer4.Name = "racer4"
        Me.racer4.Size = New System.Drawing.Size(59, 104)
        Me.racer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.racer4.TabIndex = 27
        Me.racer4.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox11.Location = New System.Drawing.Point(-9, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(100, 687)
        Me.PictureBox11.TabIndex = 26
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.YellowGreen
        Me.PictureBox10.Location = New System.Drawing.Point(478, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(100, 687)
        Me.PictureBox10.TabIndex = 25
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox9.Location = New System.Drawing.Point(377, 508)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox9.TabIndex = 24
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox8.Location = New System.Drawing.Point(377, 194)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox8.TabIndex = 23
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox7.Location = New System.Drawing.Point(377, -65)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox7.TabIndex = 22
        Me.PictureBox7.TabStop = False
        '
        'racer3
        '
        Me.racer3.Image = Global.carracing.My.Resources.Resources.images__1_1
        Me.racer3.Location = New System.Drawing.Point(308, 229)
        Me.racer3.Name = "racer3"
        Me.racer3.Size = New System.Drawing.Size(63, 108)
        Me.racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.racer3.TabIndex = 18
        Me.racer3.TabStop = False
        '
        'racer2
        '
        Me.racer2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.racer2.Image = Global.carracing.My.Resources.Resources.images
        Me.racer2.Location = New System.Drawing.Point(196, 31)
        Me.racer2.Name = "racer2"
        Me.racer2.Size = New System.Drawing.Size(60, 107)
        Me.racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.racer2.TabIndex = 13
        Me.racer2.TabStop = False
        '
        'racer1
        '
        Me.racer1.Image = Global.carracing.My.Resources.Resources.images__3_
        Me.racer1.Location = New System.Drawing.Point(106, 230)
        Me.racer1.Name = "racer1"
        Me.racer1.Size = New System.Drawing.Size(60, 107)
        Me.racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.racer1.TabIndex = 10
        Me.racer1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox6.Location = New System.Drawing.Point(277, -65)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox5.Location = New System.Drawing.Point(277, 206)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Location = New System.Drawing.Point(277, 520)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Location = New System.Drawing.Point(171, -65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Location = New System.Drawing.Point(172, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(172, 508)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 179)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'racer4move
        '
        Me.racer4move.Enabled = True
        Me.racer4move.Interval = 10
        '
        'car
        '
        Me.car.Image = CType(resources.GetObject("car.Image"), System.Drawing.Image)
        Me.car.Location = New System.Drawing.Point(211, 551)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(52, 67)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car.TabIndex = 28
        Me.car.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(578, 857)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.racer4)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.racer3)
        Me.Controls.Add(Me.speedtext)
        Me.Controls.Add(Me.gameover_text)
        Me.Controls.Add(Me.replaybutton)
        Me.Controls.Add(Me.scoretext)
        Me.Controls.Add(Me.racer2)
        Me.Controls.Add(Me.racer1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(600, 2000)
        Me.MinimumSize = New System.Drawing.Size(240, 56)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.racer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.racer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.racer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.racer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents leftside As Timer
    Friend WithEvents rightside As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents racer1 As PictureBox
    Friend WithEvents racer2 As PictureBox
    Friend WithEvents racer1move As Timer
    Friend WithEvents racer2move As Timer
    Friend WithEvents racer3move As Timer
    Friend WithEvents scoretext As Label
    Friend WithEvents replaybutton As Button
    Friend WithEvents gameover_text As Label
    Friend WithEvents speedtext As Label
    Friend WithEvents racer3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents racer4 As PictureBox
    Friend WithEvents racer4move As Timer
    Friend WithEvents car As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
