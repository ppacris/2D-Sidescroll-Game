Imports System.Runtime.InteropServices
Imports WMPLib

Module Collision

    'VARIABLE DECLARATION FOR SOUND
    Public playSound As WindowsMediaPlayer = New WindowsMediaPlayer
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Public Function ImageCollision(Image1 As PictureBox, Image2 As PictureBox) As Boolean

        If Image1.Left + Image1.Width < Image2.Left Or
        Image1.Left > Image2.Left + Image2.Width Or
        Image1.Top + Image1.Height < Image2.Top Or
        Image1.Top > Image2.Top + Image2.Height Then
            ImageCollision = False
        Else
            ImageCollision = True
        End If

    End Function
End Module
