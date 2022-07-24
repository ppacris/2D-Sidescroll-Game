Public Class Bullet
    Public direction As String
    Public bulletLeft As Integer
    Public bulletTop As Integer

    ReadOnly speed As Integer = 20
    Dim bullet As PictureBox = New PictureBox()
    Dim bulletTimer As Timer = New Timer()

    Public Sub MakeBullet(form As Form)
        bullet.BackColor = Color.White
        bullet.Size = New Size(5, 5)
        bullet.Tag = "bullet"
        bullet.Left = bulletLeft
        bullet.Top = bulletTop
        bullet.BringToFront()

        form.Controls.Add(bullet)
        'AUDIO OF GUNSHOT
        playSound.URL = "D:\Download\2d game\Pacris\Sound\gun-shot.wav"
        playSound.controls.play()

        bulletTimer.Interval = speed
        AddHandler bulletTimer.Tick, AddressOf Me.BulletTimerEvent
        bulletTimer.Start()
    End Sub

    Private Sub BulletTimerEvent(sender As Object, e As EventArgs)

        If direction = "left" Then
            bullet.Left -= speed
        End If

        If direction = "right" Then
            bullet.Left += speed
        End If

        If direction = "up" Then
            bullet.Top -= speed
        End If

        If direction = "down" Then
            bullet.Top += speed
        End If

        If bullet.Left < 0 Or bullet.Left > 980 Or bullet.Top < 10 Or bullet.Top > 700 Then
            bulletTimer.Stop()
            bulletTimer.Dispose()
            bullet.Dispose()
            bulletTimer = Nothing
            bullet = Nothing
        End If
    End Sub
End Class
