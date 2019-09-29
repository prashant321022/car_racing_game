Public Class Form1
    Dim speed As Integer
    Dim road(8) As PictureBox
    Dim score As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        road(8) = PictureBox9






    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For x As Integer = 0 To 8
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If score >= 0 And score < 8 Then
            speed = 3

        End If
        If score > 8 And score < 13 Then
            speed = 5


        End If
        If score > 10 And score < 20 Then
            speed = 7


        End If
        If score > 20 And score < 25 Then
            speed = 10
        End If
        If score > 25 And score < 30 Then
            speed = 12
        End If
        If score > 30 And score < 35 Then
            speed = 15

        End If
        If score > 35 And score < 40 Then
            speed = 18
        End If
        If score > 40 And score < 45 Then
            speed = 20
        End If
        If score > 45 And score < 50 Then
            speed = 23
        End If
        If score > 50 And score < 55 Then
            speed = 25
        End If
        If score > 55 And score < 60 Then
            speed = 28
        End If
        If score > 60 And score < 65 Then
            speed = 30
        End If
        If score > 65 And score < 70 Then
            speed = 33
        End If

        Label1.Text = "speed" & speed
        If (car.Bounds.IntersectsWith(racer1.Bounds)) Then
            endgame()

        End If
        If (car.Bounds.IntersectsWith(racer2.Bounds)) Then
            endgame()

        End If
        If (car.Bounds.IntersectsWith(racer3.Bounds)) Then
            endgame()

        End If
        If (car.Bounds.IntersectsWith(racer4.Bounds)) Then
            endgame()

        End If



    End Sub

    Private Sub endgame()
        replaybutton.Visible = True
        gameover_text.Visible = True
        Timer1.Stop()
        racer1move.Stop()
        racer2move.Stop()
        racer3move.Stop()
        racer4move.Stop()

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            rightside.Start()

        End If
        If e.KeyCode = Keys.Left Then
            leftside.Start()

        End If
        If e.KeyCode = Keys.Up Then
            upside.Start()

        End If
        If e.KeyCode = Keys.Down Then
            downside.Start()

        End If

    End Sub

    Private Sub leftside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftside.Tick
        If (car.Location.X > 65) Then
            car.Left -= 5
        End If
    End Sub

    Private Sub rightside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightside.Tick
        If (car.Location.X < 270) Then
            car.Left += 5
        End If
    End Sub
    Private Sub downside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downside.Tick
        If (car.Location.Y < 600) Then
            car.Top += 5
        End If
    End Sub
    Private Sub upside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upside.Tick
        If (car.Location.Y > 0) Then
            car.Top -= 5
        End If
    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        rightside.Stop()
        leftside.Stop()
        upside.Stop()
        downside.Stop()

    End Sub



    Private Sub racer1move_Tick(sender As Object, e As EventArgs) Handles racer1move.Tick
        racer1.Top += speed / 2
        If racer1.Top >= Me.Height Then
            score += 1

            scoretext.Text = "score" & score
            racer1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + racer1.Height)
            racer1.Left = CInt(Math.Ceiling(Rnd() * 30)) + 65

        End If
    End Sub

    Private Sub racer2move_Tick(sender As Object, e As EventArgs) Handles racer2move.Tick
        racer2.Top += speed / 4
        If racer2.Top >= Me.Height Then
            score += 1
            scoretext.Text = "score" & score
            racer2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + racer2.Height)
            racer2.Left = CInt(Math.Ceiling(Rnd() * 51)) + 112

        End If
    End Sub

    Private Sub racer3move_Tick(sender As Object, e As EventArgs) Handles racer3move.Tick
        racer3.Top += speed / 2
        If racer3.Top >= Me.Height Then
            score += 1
            scoretext.Text = "score" & score
            racer3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + racer3.Height)
            racer3.Left = CInt(Math.Ceiling(Rnd() * 51)) + 165

        End If
    End Sub
    Private Sub racer4move_Tick(sender As Object, e As EventArgs) Handles racer4move.Tick
        racer4.Top += speed / 4
        If racer4.Top >= Me.Height Then
            score += 1
            scoretext.Text = "score" & score
            racer4.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + racer4.Height)
            racer4.Left = CInt(Math.Ceiling(Rnd() * 51)) + 215

        End If
    End Sub

    Private Sub replaybutton_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles replaybutton.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)

    End Sub
End Class




