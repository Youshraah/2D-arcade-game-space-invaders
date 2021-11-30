

Public Class Manual
    Dim resourcePath As String = My.Application.Info.DirectoryPath.ToString
    Private Sounds As New SoundList
    ' Dim soundpath As String = resourcePath.Replace("bin\Debug", "Resources\soundtrack.wav")

    Private Sub Manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sounds.AddSound("music", soundpath)
        'My.Computer.Audio.Play(My.Resources.soundtrack, AudioPlayMode.Background)
    End Sub

    Private Sub Buttonopen_Click(sender As Object, e As EventArgs) Handles Buttonopen.Click
        With Form1
            .Show()
            .Focus()
            Me.Hide()
        End With
    End Sub
End Class