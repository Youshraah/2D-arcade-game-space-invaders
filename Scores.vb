Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class Scores
    Dim con As New SqlConnection
    Dim index As Integer

    Dim resourcePath As String = My.Application.Info.DirectoryPath.ToString
    Dim data As String = resourcePath.Replace("bin\Debug", "score.mdf")
    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + data + ";Integrated Security=True"
        con.Open()
        loadScore()
        con.Close()
    End Sub

    Sub loadScore()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from Table1 order by score desc"
        cmd.Connection = con
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = DataGridView1.SelectedCells.Item(0).Value

        txtName.Text = DataGridView1.SelectedCells.Item(1).Value.ToString

        txtScore.Text = DataGridView1.SelectedCells.Item(2).Value.ToString
        txtScore.ReadOnly = True

        txtDate.Text = DataGridView1.SelectedCells.Item(3).Value.ToString
        txtDate.ReadOnly = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Table1 set Player=@pl where Id=@x"
        cmd.Parameters.AddWithValue("@pl", txtName.Text)

        cmd.Parameters.AddWithValue("@x", index)
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        loadScore()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Table1  where Id=@x"
        cmd.Parameters.AddWithValue("@x", index)
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        loadScore()
    End Sub

    Private Sub r()
        txtName.Text = ""
        txtScore.Text = ""
        txtDate.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles sname.TextChanged
        r()

        Dim sfname As String = sname.Text.Trim()
        Dim sql1 As String = ""

        If (Not IsNothing(sfname)) Then
            sql1 = " where Player LIKE + @tname + '%'"
        End If


        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select * from Table1 " + sql1


        cmd.Parameters.AddWithValue("@tname", sfname)
        Dim dr As SqlDataReader
        con.Open()

        dr = cmd.ExecuteReader()

        While (dr.Read())
            txtName.Text = dr("Player").ToString()
            txtScore.Text = dr("Score").ToString()
            txtDate.Text = dr("dat").ToString()
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        TryCast(DataGridView1.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("Player LIKE '%" & sname.Text & "%'")


    End Sub

    Private Sub playagainbutton_Click(sender As Object, e As EventArgs) Handles playagainbutton.Click


        With Form1
            .Show()
            .Focus()
            Me.Hide()
        End With
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class