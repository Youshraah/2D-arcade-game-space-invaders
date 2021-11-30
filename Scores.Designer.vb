<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scores
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sname = New System.Windows.Forms.TextBox()
        Me.playagainbutton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(24, 277)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 32)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(127, 277)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 32)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 168)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(11, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Score"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtName.Location = New System.Drawing.Point(93, 165)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 26)
        Me.txtName.TabIndex = 4
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtScore.Location = New System.Drawing.Point(93, 194)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(180, 26)
        Me.txtScore.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Indigo
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.Location = New System.Drawing.Point(285, 48)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(503, 219)
        Me.DataGridView1.TabIndex = 6
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtDate.Location = New System.Drawing.Point(93, 228)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(180, 26)
        Me.txtDate.TabIndex = 8
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblDate.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDate.Location = New System.Drawing.Point(11, 231)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 18)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(52, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 27)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Search Player"
        '
        'sname
        '
        Me.sname.BackColor = System.Drawing.SystemColors.HotTrack
        Me.sname.Location = New System.Drawing.Point(57, 79)
        Me.sname.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(180, 26)
        Me.sname.TabIndex = 11
        '
        'playagainbutton
        '
        Me.playagainbutton.BackColor = System.Drawing.Color.RoyalBlue
        Me.playagainbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.playagainbutton.Location = New System.Drawing.Point(317, 342)
        Me.playagainbutton.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.playagainbutton.Name = "playagainbutton"
        Me.playagainbutton.Size = New System.Drawing.Size(128, 32)
        Me.playagainbutton.TabIndex = 12
        Me.playagainbutton.Text = "PLAY AGAIN"
        Me.playagainbutton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.exitButton.Location = New System.Drawing.Point(457, 342)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(128, 32)
        Me.exitButton.TabIndex = 13
        Me.exitButton.Text = "EXIT"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.VP_Assignment.My.Resources.Resources.score_menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 450)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.playagainbutton)
        Me.Controls.Add(Me.sname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sname As TextBox
    Friend WithEvents playagainbutton As Button
    Friend WithEvents exitButton As Button
End Class
