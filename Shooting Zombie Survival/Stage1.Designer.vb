<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stage1
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
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Ammo = New System.Windows.Forms.Label()
        Me.Lbl_Kill = New System.Windows.Forms.Label()
        Me.Lbl_Health = New System.Windows.Forms.Label()
        Me.Bar_Health = New System.Windows.Forms.ProgressBar()
        Me.Lbl_AmmoCount = New System.Windows.Forms.Label()
        Me.Lbl_KillsCount = New System.Windows.Forms.Label()
        Me.PBox_Explosion = New System.Windows.Forms.PictureBox()
        Me.PBox_Player = New System.Windows.Forms.PictureBox()
        Me.ExplosionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExplosionSoundTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PBox_Explosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBox_Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameTimer
        '
        Me.GameTimer.Enabled = True
        Me.GameTimer.Interval = 20
        '
        'Lbl_Ammo
        '
        Me.Lbl_Ammo.AutoSize = True
        Me.Lbl_Ammo.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ammo.ForeColor = System.Drawing.Color.White
        Me.Lbl_Ammo.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Ammo.Name = "Lbl_Ammo"
        Me.Lbl_Ammo.Size = New System.Drawing.Size(81, 25)
        Me.Lbl_Ammo.TabIndex = 1
        Me.Lbl_Ammo.Text = "Ammo: "
        '
        'Lbl_Kill
        '
        Me.Lbl_Kill.AutoSize = True
        Me.Lbl_Kill.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Kill.ForeColor = System.Drawing.Color.White
        Me.Lbl_Kill.Location = New System.Drawing.Point(333, 9)
        Me.Lbl_Kill.Name = "Lbl_Kill"
        Me.Lbl_Kill.Size = New System.Drawing.Size(57, 25)
        Me.Lbl_Kill.TabIndex = 2
        Me.Lbl_Kill.Text = "Kills: "
        '
        'Lbl_Health
        '
        Me.Lbl_Health.AutoSize = True
        Me.Lbl_Health.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Health.ForeColor = System.Drawing.Color.White
        Me.Lbl_Health.Location = New System.Drawing.Point(643, 9)
        Me.Lbl_Health.Name = "Lbl_Health"
        Me.Lbl_Health.Size = New System.Drawing.Size(80, 25)
        Me.Lbl_Health.TabIndex = 3
        Me.Lbl_Health.Text = "Health: "
        '
        'Bar_Health
        '
        Me.Bar_Health.BackColor = System.Drawing.Color.White
        Me.Bar_Health.ForeColor = System.Drawing.Color.White
        Me.Bar_Health.Location = New System.Drawing.Point(716, 11)
        Me.Bar_Health.Name = "Bar_Health"
        Me.Bar_Health.Size = New System.Drawing.Size(196, 23)
        Me.Bar_Health.TabIndex = 4
        Me.Bar_Health.Value = 100
        '
        'Lbl_AmmoCount
        '
        Me.Lbl_AmmoCount.AutoSize = True
        Me.Lbl_AmmoCount.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AmmoCount.ForeColor = System.Drawing.Color.White
        Me.Lbl_AmmoCount.Location = New System.Drawing.Point(84, 8)
        Me.Lbl_AmmoCount.Name = "Lbl_AmmoCount"
        Me.Lbl_AmmoCount.Size = New System.Drawing.Size(18, 31)
        Me.Lbl_AmmoCount.TabIndex = 6
        Me.Lbl_AmmoCount.Text = "0"
        Me.Lbl_AmmoCount.UseCompatibleTextRendering = True
        '
        'Lbl_KillsCount
        '
        Me.Lbl_KillsCount.AutoSize = True
        Me.Lbl_KillsCount.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_KillsCount.ForeColor = System.Drawing.Color.White
        Me.Lbl_KillsCount.Location = New System.Drawing.Point(381, 8)
        Me.Lbl_KillsCount.Name = "Lbl_KillsCount"
        Me.Lbl_KillsCount.Size = New System.Drawing.Size(18, 31)
        Me.Lbl_KillsCount.TabIndex = 7
        Me.Lbl_KillsCount.Text = "0"
        Me.Lbl_KillsCount.UseCompatibleTextRendering = True
        '
        'PBox_Explosion
        '
        Me.PBox_Explosion.Image = Global.Shooting_Zombie_Survival.My.Resources.Resources.Explode0
        Me.PBox_Explosion.Location = New System.Drawing.Point(1100, 320)
        Me.PBox_Explosion.Name = "PBox_Explosion"
        Me.PBox_Explosion.Size = New System.Drawing.Size(55, 57)
        Me.PBox_Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBox_Explosion.TabIndex = 8
        Me.PBox_Explosion.TabStop = False
        '
        'PBox_Player
        '
        Me.PBox_Player.Image = Global.Shooting_Zombie_Survival.My.Resources.Resources.up
        Me.PBox_Player.Location = New System.Drawing.Point(402, 320)
        Me.PBox_Player.Name = "PBox_Player"
        Me.PBox_Player.Size = New System.Drawing.Size(71, 100)
        Me.PBox_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBox_Player.TabIndex = 0
        Me.PBox_Player.TabStop = False
        '
        'ExplosionTimer
        '
        '
        'ExplosionSoundTimer
        '
        Me.ExplosionSoundTimer.Interval = 20
        '
        'Stage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 661)
        Me.Controls.Add(Me.PBox_Explosion)
        Me.Controls.Add(Me.Lbl_KillsCount)
        Me.Controls.Add(Me.Lbl_AmmoCount)
        Me.Controls.Add(Me.Bar_Health)
        Me.Controls.Add(Me.Lbl_Health)
        Me.Controls.Add(Me.Lbl_Kill)
        Me.Controls.Add(Me.Lbl_Ammo)
        Me.Controls.Add(Me.PBox_Player)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Stage1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stage1"
        CType(Me.PBox_Explosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBox_Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBox_Player As PictureBox
    Friend WithEvents GameTimer As Timer
    Friend WithEvents Lbl_Ammo As Label
    Friend WithEvents Lbl_Kill As Label
    Friend WithEvents Lbl_Health As Label
    Friend WithEvents Bar_Health As ProgressBar
    Friend WithEvents Lbl_AmmoCount As Label
    Friend WithEvents Lbl_KillsCount As Label
    Friend WithEvents PBox_Explosion As PictureBox
    Friend WithEvents ExplosionTimer As Timer
    Friend WithEvents ExplosionSoundTimer As Timer
End Class
