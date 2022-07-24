<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stage2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stage2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_BulletCount = New System.Windows.Forms.Label()
        Me.Lbl_ZombieCount = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(345, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(68, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(401, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "X"
        '
        'Lbl_BulletCount
        '
        Me.Lbl_BulletCount.AutoSize = True
        Me.Lbl_BulletCount.Font = New System.Drawing.Font("Nirmala UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BulletCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_BulletCount.Location = New System.Drawing.Point(93, -1)
        Me.Lbl_BulletCount.Name = "Lbl_BulletCount"
        Me.Lbl_BulletCount.Size = New System.Drawing.Size(56, 65)
        Me.Lbl_BulletCount.TabIndex = 4
        Me.Lbl_BulletCount.Text = "0"
        '
        'Lbl_ZombieCount
        '
        Me.Lbl_ZombieCount.AutoSize = True
        Me.Lbl_ZombieCount.Font = New System.Drawing.Font("Nirmala UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ZombieCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_ZombieCount.Location = New System.Drawing.Point(426, -2)
        Me.Lbl_ZombieCount.Name = "Lbl_ZombieCount"
        Me.Lbl_ZombieCount.Size = New System.Drawing.Size(56, 65)
        Me.Lbl_ZombieCount.TabIndex = 5
        Me.Lbl_ZombieCount.Text = "0"
        '
        'Stage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 661)
        Me.Controls.Add(Me.Lbl_ZombieCount)
        Me.Controls.Add(Me.Lbl_BulletCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Stage2"
        Me.Text = "Stage2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_BulletCount As Label
    Friend WithEvents Lbl_ZombieCount As Label
End Class
