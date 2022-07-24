Public Class Splash
    Dim musicAlias As String = "AudioBGSPLASH"
    Dim musicPath As String = "D:\Download\2d game\Pacris\Sound\space-soundscape.mp3"


    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Dim i As New Stage1
        My.Computer.Audio.Stop()
        mciSendString("stop " & musicAlias, CStr(0), 0, 0)
        i.Show()
        Me.Close()
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mciSendString("Open " & Chr(34) & musicPath & Chr(34) & " alias " & musicAlias, CStr(0), 0, 0)
        mciSendString("play " & musicAlias, CStr(0), 0, 0)
        My.Computer.Audio.Play("D:\Download\2d game\Pacris\Sound\suspense-alien-horns.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class
