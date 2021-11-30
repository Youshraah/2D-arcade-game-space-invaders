
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Form1
    'creating instance for dbs connectionF
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim damage As Integer = 0
    Dim loops As Integer = 0
    Dim count As Integer = 0 'count score
    Dim strName As String 'store username
    Dim enemyArray(11) As PictureBox 'level 1
    Dim ammoArray(11) As PictureBox 'level
    Dim meteorArray(13) As PictureBox 'level3
    Dim shot As Integer

    Dim gender As String


    Dim pause As Boolean

    'Dim life As Integer = 3


    Private Sounds As New SoundList
    Dim resourcePath As String = My.Application.Info.DirectoryPath.ToString
    Dim soundpath As String = resourcePath.Replace("bin\Debug", "Resources\soundtrack.wav")
    Dim dbpath As String = resourcePath.Replace("bin\Debug", "score.mdf")

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sounds.AddSound("music", soundpath)
        'database path
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbpath + ";Integrated Security=True"
        Start() 'play with visibility
        labelWelcome.Visible = True
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Text = "Level completed!"
    End Sub


    Sub Start()

        commentText.Visible = False
        btnSubmit.Visible = False
        btnSubmit.Enabled = False
        labelWelcome.Visible = False
        Label1.Visible = False
        Dim obj As Object
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        start_button.Visible = False
        ButtonScores.Visible = False
        ButtonExit.Visible = False
        start_button.Enabled = False
        ButtonScores.Enabled = False
        ButtonExit.Enabled = False
        button_next_level.Enabled = False
        button_next_level.Visible = False
        btnExtractScore.Visible = False
        timelabel.Visible = False
        Timer5.Enabled = False
        btnRate.Visible = False
        btnRate.Enabled = False
        For Each obj In Me.Controls
            If TypeOf obj Is PictureBox AndAlso obj.tag = "enemy" Then
                enemyArray(i) = obj
                enemyArray(i).Visible = False
                enemyArray(i).BackColor = Color.Transparent
                i += 1
            ElseIf TypeOf obj Is PictureBox AndAlso obj.tag = "shot" Then
                ammoArray(j) = obj
                ammoArray(j).Top = -150
                j += 1
            End If
        Next
        spaceship.BackColor = Color.Transparent
        spaceship.Visible = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles start_button.Click 'PLAY BUTTON
        lblScore.Visible = True
        'start button
        'level4
        alienweapon.Top = 700
        Timer4.Start()
        Dim i As Integer = 0
        spaceship.Visible = True
        start_button.Visible = False
        ButtonScores.Visible = False
        ButtonExit.Visible = False
        start_button.Enabled = False
        ButtonScores.Enabled = False
        ButtonExit.Enabled = False
        btnExtractScore.Visible = False
        btnRate.Visible = False
        btnRate.Enabled = False

        For Each obj In Me.Controls
            If TypeOf obj Is PictureBox AndAlso obj.tag = "enemy" Then
                enemyArray(i).Visible = True
                i += 1
            End If
        Next
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonScores.Click
        'score button on start page
        start_button.Visible = False
        ButtonScores.Visible = False
        ButtonExit.Visible = False
        start_button.Enabled = False
        ButtonScores.Enabled = False
        ButtonExit.Enabled = False
        btnRate.Visible = False
        btnRate.Enabled = False
        'EditUserScore.Visible = True
        'EditUserScore.Enabled = True
        openScorefrm.Enabled = False
        openScorefrm.Visible = False
        lblreload.Visible = False
        lblreload.Enabled = False

        loadScore()
    End Sub


    Private Sub savemyscore()
        'Dim cmd1 As New SqlCommand
        'Dim con1 As New SqlConnection
        'If count > 0 Then

        '    cmd1.Connection = con1
        '    cmd1.CommandType = CommandType.Text
        '    cmd1.CommandText = "INSERT INTO Table1(player, score) VALUES(@x, @y)"
        '    cmd1.Parameters.AddWithValue("@x", strName)
        '    cmd1.Parameters.AddWithValue("@y", count)
        '    con1.Open()
        '    cmd1.ExecuteNonQuery()
        '    con.Close()
        'End If


        If count > 0 Then
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            'Dim mydate As String = DateTime.Now.ToString("dd/MM/yyyy")
            Dim regDate As DateTime = DateTime.Now
            Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")

            cmd.CommandText = "INSERT INTO Table1(player, score,dat) VALUES(@uname, @score,@dated)"
            cmd.Parameters.AddWithValue("@uname", strName)
            cmd.Parameters.AddWithValue("@score", count)
            cmd.Parameters.AddWithValue("@dated", strDate)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        'exit button
        'If count > 0 Then
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "INSERT INTO Table1(player, score) VALUES(@x, @y)"
        '    cmd.Parameters.AddWithValue("@x", strName)
        '    cmd.Parameters.AddWithValue("@y", count)
        '    con.Open()
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        'End If
        savemyscore()
        End
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode




            'Case Keys.P
            '    If pause = True Then
            '        Timer1.Enabled = False
            '        Timer2.Enabled = False
            '        Timer3.Enabled = False
            '        Timer4.Enabled = False
            '        Timer5.Enabled = False
            '        level2.Enabled = False
            '        level3.Enabled = False
            '    End If

            'Case Keys.p
            '    If pause = False Then
            '        If Timer1.Enabled = True Then
            '            Timer1.Enabled = False
            '        End If

            '        If Timer2.Enabled = True Then
            '            Timer2.Enabled = False
            '        End If
            '        If Timer3.Enabled = True Then
            '            Timer3.Enabled = False
            '        End If

            '        If Timer4.Enabled = True Then
            '            Timer4.Enabled = False
            '        End If

            '        If Timer5.Enabled = True Then
            '            Timer5.Enabled = False
            '        End If
            '        If level2.Enabled = True Then
            '            level2.Enabled = False
            '        End If
            '        If level3.Enabled = True Then
            '            level3.Enabled = False
            '        End If
            '        pause = True
            '        ' ElseIf pause = False Then
            '    Else
            '        If Timer1.Enabled = False Then
            '            Timer1.Enabled = True
            '        End If

            '        If Timer2.Enabled = False Then
            '            Timer2.Enabled = True
            '        End If

            '        If Timer3.Enabled = False Then
            '            Timer3.Enabled = True
            '        End If

            '        If Timer4.Enabled = False Then
            '            Timer4.Enabled = True
            '        End If

            '        If Timer5.Enabled = False Then
            '            Timer5.Enabled = True
            '        End If
            '        If level2.Enabled = False Then
            '            level2.Enabled = True
            '        End If
            '        If level3.Enabled = False Then
            '            level3.Enabled = True
            '        End If
            '        pause = False
            '    End If


            Case Keys.Left
                If (spaceship.Left > 0) Then
                    spaceship.Left -= 20
                End If
            Case Keys.Right
                If (spaceship.Left < 710) Then
                    spaceship.Left += 20
                End If

            Case Keys.Up
                If (spaceship.Top > 0) Then
                    spaceship.Top -= 10
                End If
            Case Keys.Down
                If (spaceship.Top < 378) Then
                    spaceship.Top += 10
                End If
            Case Keys.Space
                If start_button.Enabled = False Then
                    If shot > 11 Then
                        If ammoArray(11).Top < -100 Then
                            shot = -1
                        Else
                            lblreload.Visible = True
                        End If

                    Else
                        lblreload.Visible = False
                        ammoArray(shot).Left = spaceship.Left + 57
                        ammoArray(shot).Top = spaceship.Top
                        ammoArray(shot).Visible = True
                        My.Computer.Audio.Play(My.Resources.shoot, AudioPlayMode.Background)
                        Timer3.Start()
                    End If
                    shot += 1
                End If
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'move array alien,stop picturebox from moving outside frame
        Dim i As Integer = 0
        For Each picturebox In enemyArray
            enemyArray(i).Left += 1
            enemyArray(i).Top += 2 'down
            i += 1
        Next

        If enemyArray(1).Left >= 600 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'move array alien
        Dim i As Integer = 0
        For Each picturebox In enemyArray
            enemyArray(i).Left -= 1
            enemyArray(i).Top -= 2 'up
            i += 1
        Next
        '562
        If enemyArray(1).Left <= 562 Then
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'spaceship bullet

        Dim i As Integer = 0
        For Each picturebox In ammoArray
            ammoArray(i).Top -= 5
            i += 1
        Next
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'level 1

        lblLevel.Text = "LEVEL 1"
        lblLevel.Visible = True

        commentText.Visible = False
        btnSubmit.Visible = False
        btnSubmit.Enabled = False
        labelWelcome.Visible = False
        Timer5.Enabled = True
        timelabel.Visible = True
        Timer5.Start()
        Dim a As Integer = 0
        While a < 12
            Dim b As Integer = 0
            While b < 12
                If ammoArray(a).Bounds.IntersectsWith(enemyArray(b).Bounds) Then
                    enemyArray(b).Image = My.Resources.explosionspaceship
                    'enemyArray(b).Hide()


                    enemyArray(b).Top = 1000
                    ammoArray(a).Top = -150
                    count += 1
                    My.Computer.Audio.Play(My.Resources.explode, AudioPlayMode.Background)
                End If
                b += 1
            End While
            a += 1
        End While



        If count = 12 Then
            My.Computer.Audio.Play(My.Resources.victory, AudioPlayMode.Background)
            'Me.BackgroundImage = My.Resources.lighting
            Timer5.Stop()
            Label1.Visible = True
            spaceship.Hide()
            ButtonExit.Visible = True
            ButtonExit.Enabled = True
            button_next_level.Enabled = True
            button_next_level.Visible = True
            Timer4.Stop()

            If timelabel.Text < 5.0 Then
                count += 10

            ElseIf timelabel.Text > 5.0 And timelabel.Text < 9.0 Then
                count += 5
                'End If
            End If
        End If


        If timelabel.Text > 9.0 Then

            spaceship.Image = My.Resources.explosionspaceship
            My.Computer.Audio.Play(My.Resources.explode, AudioPlayMode.Background)

            Label1.Text = "Game Over! Ran out of time.."
            Label1.Visible = True




            ''RESTART GAME
            'btnRestart.Visible = True
            'btnRestart.Enabled = True


            My.Computer.Audio.Play(My.Resources.over, AudioPlayMode.Background)
            openScorefrm.Visible = True
            openScorefrm.Enabled = True
            btnRate.Visible = False
            btnRate.Enabled = False
            ButtonExit.Visible = True
            ButtonExit.Enabled = True
            button_next_level.Enabled = False
            button_next_level.Visible = False
            Dim i As Integer = 0
            spaceship.Hide()
            For Each obj In Me.Controls
                If TypeOf obj Is PictureBox AndAlso obj.tag = "enemy" Then
                    enemyArray(i).Visible = False
                    i += 1
                End If
            Next

            Timer4.Stop()
            Timer5.Stop()

        End If


        lblScore.Text = count.ToString
        'create loop for enemy1 interception with spaceship
        Dim x As Integer = 0
        While x < 12
            If enemyArray(x).Bounds.IntersectsWith(spaceship.Bounds) Then
                spaceship.Image = My.Resources.explosionspaceship

                My.Computer.Audio.Play(My.Resources.explode, AudioPlayMode.Background)
                Label1.Text = "Game Over!"
                Label1.Visible = True

                'restart
                'btnRestart.Visible = True
                'btnRestart.Enabled = True

                My.Computer.Audio.Play(My.Resources.over, AudioPlayMode.Background)
                spaceship.Hide()

                openScorefrm.Visible = True
                openScorefrm.Enabled = True

                btnRate.Visible = True
                btnRate.Enabled = True

                ButtonExit.Visible = True
                ButtonExit.Enabled = True

                button_next_level.Enabled = False
                button_next_level.Visible = True

                Timer4.Stop()
                Timer5.Stop()
            End If
            x += 1
        End While
    End Sub

#Region "ENTER "
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnEnterGame.Click
        'My.Computer.Audio.Play(My.Resources., AudioPlayMode.Background)
        'My.Computer.Audio.Play(My.Resources.soundtrack, AudioPlayMode.Background)

        Sounds.Play("music")
        'My.Computer.Audio.Play(My.Resources.soundtrack, AudioPlayMode.Background)
        lblScore.Visible = True
        If txtEnterName.TextLength = 0 Then
            lblScore.Text = "Enter Username to Play"
            lblScore.ForeColor = System.Drawing.Color.Pink

        Else


            lblScore.Text = "Score"
            start_button.Visible = True
            ButtonScores.Visible = True
            ButtonExit.Visible = True
            start_button.Enabled = True
            ButtonScores.Enabled = True
            ButtonExit.Enabled = True
            btnRate.Visible = False
            btnRate.Enabled = False
            btnEnterGame.Enabled = False
            btnEnterGame.Visible = False
            lblEntrName.Visible = False
            txtEnterName.Visible = False
            txtEnterName.Enabled = False
            strName = txtEnterName.Text
            lbl1leveleasy.Hide()
            lbl3lvlmedium.Hide()
            lbllvlhard.Hide()
        End If
    End Sub
#End Region

#Region "button continue level"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles button_next_level.Click
        'continue



        button_next_level.Enabled = False
        button_next_level.Visible = False
        Label1.Visible = False
        spaceship.Visible = True
        ButtonExit.Enabled = False
        ButtonExit.Visible = False
        If count = 12 Or count = 22 Or count = 17 Then
            Dim obj As Object
            Dim i As Integer = 0
            'level2
            For Each obj In Me.Controls
                If TypeOf obj Is PictureBox AndAlso obj.tag = "meteor" Then
                    meteorArray(i) = obj
                    meteorArray(i).Visible = True
                    meteorArray(i).Top -= 450
                    meteorArray(i).BackColor = Color.Transparent
                    i += 1
                End If
            Next
            level2.Start()
        Else
            level2.Stop()
            bigAlien.Visible = True


            level3.Start()
        End If

    End Sub
#End Region
#Region "level 2"
    Private Sub level2_Tick(sender As Object, e As EventArgs) Handles level2.Tick

        lblLevel.Text = "LEVEL 2"
        lblLevel.Visible = True
        'level 2
        commentText.Visible = False
        btnSubmit.Visible = False
        btnSubmit.Enabled = False
        labelWelcome.Visible = False
        timelabel.Visible = False

        Dim i As Integer = 0
        For Each picturebox In meteorArray

            meteorArray(i).Top += 10
            lblScore.Text = count.ToString
            If meteorArray(i).Top > 550 AndAlso loops < 5000 Then
                meteorArray(i).Top -= 750
                meteorArray(i).Left = CInt(Math.Ceiling(Rnd() * 700)) + 1
                loops += 1
            End If
            loops += 1
            i += 1
        Next

        Dim a As Integer = 0
        While a < 12
            Dim b As Integer = 0
            While b < 14
                If ammoArray(a).Bounds.IntersectsWith(meteorArray(b).Bounds) Then
                    meteorArray(b).Top = 600
                    ammoArray(a).Top = -150
                    count += 1
                    My.Computer.Audio.Play(My.Resources.explode, AudioPlayMode.Background)
                End If
                b += 1
            End While
            a += 1
        End While

        If loops > 5900 Then
            spaceship.Hide()
            Label1.Visible = True
            ButtonExit.Visible = True
            ButtonExit.Enabled = True
            My.Computer.Audio.Play(My.Resources.victory, AudioPlayMode.Background)
            button_next_level.Visible = True
            button_next_level.Enabled = True
        End If

        Dim x As Integer = 0
        While x < 14
            If meteorArray(x).Bounds.IntersectsWith(spaceship.Bounds) Then

                My.Computer.Audio.Play(My.Resources.explode, AudioPlayMode.Background)
                Label1.Text = "Game Over!!"
                Label1.Visible = True



                My.Computer.Audio.Play(My.Resources.over, AudioPlayMode.Background)
                spaceship.Hide()
                openScorefrm.Visible = True
                openScorefrm.Enabled = True
                ButtonExit.Visible = True
                ButtonExit.Enabled = True
                button_next_level.Enabled = False
                button_next_level.Visible = False

                btnRate.Visible = True
                btnRate.Enabled = True

                level2.Stop()
                Dim z As Integer = 0
                For Each picturebox In meteorArray

                    meteorArray(z).Visible = False
                    z += 1
                Next

            End If
            x += 1
        End While
    End Sub
#End Region
    Private Sub level3_Tick(sender As Object, e As EventArgs) Handles level3.Tick

        lblLevel.Text = "LEVEL 3"
        lblLevel.Visible = True
        'level 3
        commentText.Visible = False
        btnSubmit.Visible = False
        btnSubmit.Enabled = False
        labelWelcome.Visible = False
        timelabel.Visible = False
        lblScore.Text = count.ToString

        'align alien with spaceship
        If bigAlien.Left - spaceship.Left > -25 Then
            bigAlien.Left -= 1
        ElseIf bigAlien.Left - spaceship.Left < -25 Then
            bigAlien.Left += 1
        ElseIf alienweapon.Top > 450 Then
            bigAlien.SendToBack()
            alienweapon.Visible = True
            alienweapon.Left = bigAlien.Left + 85
            alienweapon.Top = bigAlien.Top + 135
        End If

        alienweapon.Top += 1 'speed of big alien
        If alienweapon.Bounds.IntersectsWith(spaceship.Bounds) Then
            spaceship.Image = My.Resources.explosionspaceship
            My.Computer.Audio.Play(My.Resources.explode, AudioPlayMode.Background)
            Label1.Text = "Game Over!"
            Label1.Visible = True
            My.Computer.Audio.Play(My.Resources.over, AudioPlayMode.Background)
            spaceship.Hide()
            bigAlien.Hide()
            alienweapon.Visible = False

            ButtonExit.Visible = True
            ButtonExit.Enabled = True

            button_next_level.Enabled = False
            button_next_level.Visible = False

            openScorefrm.Visible = True
            openScorefrm.Enabled = True

            btnRate.Visible = True
            btnRate.Enabled = True

            level3.Stop()
        End If

        Dim a As Integer = 0



        While a < 12
            If ammoArray(a).Bounds.IntersectsWith(bigAlien.Bounds) Then
                ammoArray(a).Top = -150
                damage += 1
                count += 2 'additional 2
            End If
            a += 1
        End While
        'shot more than 30 then..
        If damage > 30 Then
            My.Computer.Audio.Play(My.Resources.explode, AudioPlayMode.Background)
            bigAlien.Image = My.Resources.explosionspaceship
            'bigAlien.Visible = False
            alienweapon.Visible = False
            Label1.Visible = True
            ButtonExit.Enabled = True
            ButtonExit.Visible = True
            btnRate.Enabled = True
            btnRate.Visible = True
            openScorefrm.Enabled = True
            openScorefrm.Visible = True
            My.Computer.Audio.Play(My.Resources.victory, AudioPlayMode.Background)
            level3.Stop()
        End If
    End Sub

    Sub loadScore()
        labelWelcome.Visible = False
        scoreGVS.Visible = True
        back.Visible = True
        btnExtractScore.Visible = True
        start_button.Visible = False
        ButtonScores.Visible = False
        ButtonExit.Visible = False
        btnRate.Visible = False
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Player, Score, dat from Table1 order by score desc"
        cmd.Connection = con
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        scoreGVS.DataSource = dt
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        scoreGVS.Visible = False
        back.Visible = False
        btnExtractScore.Visible = False
        'start_button.Visible = True
        ButtonScores.Visible = True
        ButtonExit.Visible = True
        'start_button.Enabled = True
        ButtonScores.Enabled = True
        ButtonExit.Enabled = True
        labelWelcome.Visible = True
        btnRate.Visible = True
        btnRate.Enabled = True
        commentText.Visible = False
        btnSubmit.Visible = False
        'EditUserScore.Visible = False
        'EditUserScore.Enabled = False
    End Sub



    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        'level 1, increment time
        timelabel.Text = timelabel.Text + 0.01
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnRate.Click
        commentText.Visible = True
        btnSubmit.Visible = True
        btnSubmit.Enabled = True
        labelWelcome.Visible = False
        start_button.Visible = False
        ButtonScores.Visible = False
        ButtonExit.Visible = False
        btnRate.Visible = False
        back.Visible = True
        back.Enabled = True
        openScorefrm.Visible = False
        openScorefrm.Enabled = False
        Label1.Visible = False
        lblScore.Visible = False
        lblreload.Visible = False
        lblreload.Enabled = False


    End Sub


    'SUBMIT RATING
    Private Sub RateUsButton_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim text As New StringBuilder
        text.AppendLine(commentText.Text)

        Dim filepath As String = "C:\Users\23058\Desktop\VP_Assignment\UserComments" + txtEnterName.Text
        File.AppendAllText(filepath, text.ToString())
        MsgBox("Thank you for your comment!")
    End Sub

    'save in excel file
    Private Sub btnsaveExcel_Click(sender As Object, e As EventArgs) Handles btnExtractScore.Click
        Try
            btnExtractScore.Text = "Processing..."
            btnExtractScore.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'executed once user press ok..
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For i = 0 To scoreGVS.RowCount - 2
                    For j = 0 To scoreGVS.ColumnCount - 1
                        For k As Integer = 1 To scoreGVS.Columns.Count
                            xlWorkSheet.Cells(1, k) = scoreGVS.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = scoreGVS(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MsgBox("Successfully Extracted" & vbCrLf & "File extracted to : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

                btnExtractScore.Text = "Save As Excel File"
                btnExtractScore.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub ammendScoreButton_Click(sender As Object, e As EventArgs)
        Scores.Visible = True
        Me.Hide()

    End Sub

    Private Sub openScorefrm_Click(sender As Object, e As EventArgs) Handles openScorefrm.Click

        'openn score.mfS
        savemyscore()

        With Scores
            .Show()
            .Focus()
            Me.Close()
        End With
    End Sub

End Class
