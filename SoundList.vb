﻿Imports System.Runtime.InteropServices

Public Class SoundList
    Private sounds As New Dictionary(Of String, String)
    Private sndcnt As Integer = 0

    <DllImport("winmm.dll", EntryPoint:="mciSendStringW")>
    Private Shared Function mciSendStringW(<MarshalAs(UnmanagedType.LPTStr)> ByVal lpszCommand As String, <MarshalAs(UnmanagedType.LPWStr)> ByVal lpszReturnString As System.Text.StringBuilder, ByVal cchReturn As UInteger, ByVal hwndCallback As IntPtr) As Integer
    End Function

    Public Function AddSound(ByVal SoundName As String, ByVal SndFilePath As String) As Boolean
        If SoundName.Trim = "" Or Not IO.File.Exists(SndFilePath) Then Return False
        'file name exist
        If mciSendStringW("open " & Chr(34) & SndFilePath & Chr(34) & " alias " & "Snd_" & sndcnt.ToString, Nothing, 0, IntPtr.Zero) <> 0 Then Return False
        sounds.Add(SoundName, "Snd_" & sndcnt.ToString)
        sndcnt += 1
        Return True
    End Function

    Public Function Play(ByVal SoundName As String) As Boolean
        If Not sounds.ContainsKey(SoundName) Then Return False
        mciSendStringW("seek " & sounds.Item(SoundName) & " to start", Nothing, 0, IntPtr.Zero)
        If mciSendStringW("play " & sounds.Item(SoundName), Nothing, 0, IntPtr.Zero) <> 0 Then Return False
        Return True
    End Function
End Class
