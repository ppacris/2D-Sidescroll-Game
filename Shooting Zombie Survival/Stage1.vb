Public Class Stage1

    'VARIABLES DECLARATION
    Dim goLeft, goRight, goUp, goDown, gameOver As Boolean
    Dim facing As String = "up"

    Dim playerHealth As Integer = 100
    Dim speed As Integer = 10
    Dim zombiespeed As Integer = 1
    Dim ammoC As Integer = 5
    Dim score As Integer
    Dim apoy As Integer = 0

    Dim randNum As Random = New Random()
    Dim zombielist As List(Of PictureBox) = New List(Of PictureBox)

    'FUCNTION RESPONSIBLE FOR CHANGING COLOR OF PROGRESSBAR (playerHealth)
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    'GAME TIMER EVENT
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        'SETTING "Bar_Health" TO VARIABLE "playerHealth"
        If (playerHealth > 1) Then
            Bar_Health.Value = playerHealth
        Else
            gameOver = True
            PBox_Player.Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\soldier\dead.png")
            GameTimer.Stop()
        End If

        'HP OF PLAYER CHANGING COLOR
        If playerHealth <= 60 And playerHealth >= 30 Then
            SendMessage(Bar_Health.Handle, 1040, 3, 0)
        ElseIf playerHealth < 30 Then
            SendMessage(Bar_Health.Handle, 1040, 2, 0)
        End If

        'AMMO AND KILLS STAT
        Lbl_Ammo.Text = "Ammo: "
        Lbl_AmmoCount.Text = ammoC
        Lbl_Kill.Text = "Kills: "
        Lbl_KillsCount.Text = score

        'LAKAD PAKALIWA
        If ((goLeft = True) And (PBox_Player.Left > 0)) Then
            PBox_Player.Left -= speed
        End If

        'LAKAD PAKANAN
        If ((goRight = True) And (PBox_Player.Left + PBox_Player.Width < 940)) Then
            PBox_Player.Left += speed
        End If

        'LAKAD PATAAS
        If ((goUp = True) And (PBox_Player.Top > 45)) Then
            PBox_Player.Top -= speed
        End If

        'LAKAD PABABA
        If ((goDown = True) And (PBox_Player.Top + PBox_Player.Height < 670)) Then
            PBox_Player.Top += speed
        End If

        'PLAYER LOOTING AMMO DROP
        For Each i As Control In Me.Controls
            If TypeOf i Is PictureBox And (CType(i.Tag, String)) = "ammo" Then
                If PBox_Player.Bounds.IntersectsWith(i.Bounds) Then
                    Me.Controls.Remove(i)
                    CType(i, PictureBox).Dispose()
                    ammoC += 5
                End If
            End If
        Next

        'ZOMBIE WILL FOLLOW THE PLAYER AND EVERY COLLISION -1 HEALTH TO PLAYER
        For Each x As Control In Me.Controls
            If TypeOf x Is PictureBox And (CType(x.Tag, String)) = "zombie" Then

                If x.Left > PBox_Player.Left Then
                    x.Left -= zombiespeed
                    CType(x, PictureBox).Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\zombie\zleft.png")
                    If ImageCollision(x, PBox_Player) = True Then
                        x.Left = x.Left + 10
                        playerHealth -= 1
                    End If
                End If

                If x.Left < PBox_Player.Left Then
                    x.Left += zombiespeed
                    CType(x, PictureBox).Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\zombie\zright.png")
                    If ImageCollision(x, PBox_Player) = True Then
                        x.Left = x.Left - 10
                        playerHealth -= 1
                    End If
                End If

                If x.Top > PBox_Player.Top Then
                    x.Top -= zombiespeed
                    CType(x, PictureBox).Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\zombie\zup.png")
                    If ImageCollision(x, PBox_Player) = True Then
                        x.Top = x.Top + 10
                        playerHealth -= 1
                    End If
                End If

                If x.Top < PBox_Player.Top Then
                    x.Top += zombiespeed
                    CType(x, PictureBox).Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\zombie\zdown.png")
                    If ImageCollision(x, PBox_Player) = True Then
                        x.Top = x.Top - 10
                        playerHealth -= 1
                    End If
                End If
            End If

            For Each j As Control In Me.Controls
                If TypeOf j Is PictureBox And (CType(j.Tag, String)) = "bullet" And
                    TypeOf x Is PictureBox And (CType(x.Tag, String)) = "zombie" Then

                    If x.Bounds.IntersectsWith(j.Bounds) Then
                        ExplosionTimer.Enabled = True
                        PBox_Explosion.Left = x.Left
                        PBox_Explosion.Top = x.Top

                        Me.Controls.Remove(j)
                        CType(j, PictureBox).Dispose()
                        Me.Controls.Remove(x)
                        CType(x, PictureBox).Dispose()
                        zombielist.Remove(CType(x, PictureBox))

                        'AUDIO HIT EXPLOTION
                        If ExplosionSoundTimer.Enabled = False Then
                            ExplosionSoundTimer.Enabled = True
                        Else
                            mciSendString("stop " & "hitexplode", CStr(0), 0, 0)
                            mciSendString("close " & "hitexplode", CStr(0), 0, 0)
                        End If

                        score += 1
                        MakeZombies()
                    End If
                End If
            Next
        Next
    End Sub

    'FOR PRESS DOWN ARROW KEYS EVENT W/ SPRITE MATERIALS
    Private Sub KeyIsDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (gameOver = True) Then
            Return
        End If

        If (e.KeyCode = Keys.Left) Then
            goLeft = True
            facing = "left"
            PBox_Player.Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\soldier\left.png")
            My.Computer.Audio.Play("D:\Download\2d game\Pacris\Sound\player-footstep.wav")
        End If

        If (e.KeyCode = Keys.Right) Then
            goRight = True
            facing = "right"
            PBox_Player.Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\soldier\right.png")
            My.Computer.Audio.Play("D:\Download\2d game\Pacris\Sound\player-footstep.wav")
        End If

        If (e.KeyCode = Keys.Up) Then
            goUp = True
            facing = "up"
            PBox_Player.Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\soldier\up.png")
            My.Computer.Audio.Play("D:\Download\2d game\Pacris\Sound\player-footstep.wav")
        End If

        If (e.KeyCode = Keys.Down) Then
            goDown = True
            facing = "down"
            PBox_Player.Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\soldier\down.png")
            My.Computer.Audio.Play("D:\Download\2d game\Pacris\Sound\player-footstep.wav")
        End If
    End Sub

    'RESTART
    Private Sub Stage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RestartGame()
    End Sub

    'EXPLOSION TIMER
    Private Sub ExplosionTimer_Tick(sender As Object, e As EventArgs) Handles ExplosionTimer.Tick
        apoy += 1
        PBox_Explosion.Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\explotion\Explode" & apoy & ".png")
        If apoy >= 7 Then
            apoy = 0
            ExplosionTimer.Enabled = False
            PBox_Explosion.Left = +1100
            PBox_Explosion.Top = +320
        End If
    End Sub

    'AUDIO HITSOUNDTIMER
    Private Sub HitsoundTimer_Tick(sender As Object, e As EventArgs) Handles ExplosionSoundTimer.Tick
        mciSendString("Open " & Chr(34) & "D:\Download\2d game\Pacris\Sound\game-explosion.wav" & Chr(34) & " alias " & "hitexplode", CStr(0), 0, 0)
        mciSendString("play " & "hitexplode", CStr(0), 0, 0)
    End Sub

    'FOR RELEASE ARROW KEYS EVENT
    Private Sub KeyIsUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.Left) Then
            goLeft = False
        End If

        If (e.KeyCode = Keys.Right) Then
            goRight = False
        End If

        If (e.KeyCode = Keys.Up) Then
            goUp = False
        End If

        If (e.KeyCode = Keys.Down) Then
            goDown = False
        End If

        If (e.KeyCode = Keys.Space And gameOver = False And ammoC > 0) Then
            ammoC -= 1
            ShootBullet(facing)
            If (ammoC < 1) Then
                Dropammo()
            End If
        End If

        If (e.KeyCode = Keys.Enter And gameOver = True) Then
            RestartGame()
        End If
    End Sub

    'SHOOTBULLET
    Private Sub ShootBullet(direction As String)
        Dim shootBullet As Bullet = New Bullet With {
            .direction = direction,
            .bulletLeft = PBox_Player.Left + (PBox_Player.Width / 2),
            .bulletTop = PBox_Player.Top + (PBox_Player.Height / 2)
        }
        shootBullet.MakeBullet(Me)
    End Sub

    'FOR DROPPING AMMO
    Private Sub Dropammo()
        Dim ammo As PictureBox = New PictureBox With {
            .Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\ammo.png"),
            .SizeMode = PictureBoxSizeMode.AutoSize
        }
        ammo.Left = randNum.Next(12, Me.ClientSize.Width - ammo.Width)
        ammo.Top = randNum.Next(55, Me.ClientSize.Height - ammo.Height)
        ammo.Tag = "ammo"
        Me.Controls.Add(ammo)
        ammo.BringToFront()
        PBox_Player.BringToFront()
    End Sub

    'FOR MAKING ZOMBIES
    Private Sub MakeZombies()
        Dim zombie As PictureBox = New PictureBox With {
            .Tag = "zombie",
            .Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\zombie\zdown.png"),
            .SizeMode = PictureBoxSizeMode.AutoSize,
            .Left = randNum.Next(0, 900),
            .Top = randNum.Next(0, 670)
        }
        zombielist.Add(zombie)
        Me.Controls.Add(zombie)
        PBox_Player.BringToFront()
    End Sub

    'FOR RESTARTING OF THE GAME
    Private Sub RestartGame()
        PBox_Player.Image = Image.FromFile("D:\Download\2d game\Pacris\Sprite\soldier\up.png")

        For Each i As PictureBox In zombielist
            Me.Controls.Remove(i)
        Next
        zombielist.Clear()

        'IN THIS FOR LOOP, WE RESPAWN 3 ZOMBIES AT RANDOM LOCATION
        For i As Integer = 1 To 3
            MakeZombies()
        Next

        goUp = False
        goDown = False
        goRight = False
        goLeft = False
        gameOver = False

        playerHealth = 100
        score = 0
        ammoC = 5

        'CHANGE THE COLOR BACK TO GREEN OF PLAYER HP
        If playerHealth = 100 Then
            SendMessage(Bar_Health.Handle, 1040, 1, 0)
        End If

        GameTimer.Start()
    End Sub
End Class