Imports System

Namespace InstagramFollowers
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            UsernameText = New Windows.Forms.TextBox()
            RunButton = New Windows.Forms.Button()
            PasswordText = New Windows.Forms.TextBox()
            UsernameLabel = New Windows.Forms.Label()
            PasswordLabel = New Windows.Forms.Label()
            WaitTime = New Windows.Forms.Label()
            WaitTimeText = New Windows.Forms.TextBox()
            FriendLabel = New Windows.Forms.Label()
            FriendText = New Windows.Forms.TextBox()
            FollowersOrFollowingCheckBox = New Windows.Forms.CheckBox()
            FollowOrFollowingLabel = New Windows.Forms.Label()
            checkBox1 = New Windows.Forms.CheckBox()
            label1 = New Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' UsernameText
            ' 
            UsernameText.Location = New Drawing.Point(98, 14)
            UsernameText.Name = "UsernameText"
            UsernameText.Size = New Drawing.Size(650, 21)
            UsernameText.TabIndex = 0
            AddHandler UsernameText.TextChanged, New EventHandler(AddressOf TextBox1_TextChanged)
            ' 
            ' RunButton
            ' 
            RunButton.BackColor = Drawing.SystemColors.ControlDarkDark
            RunButton.Location = New Drawing.Point(604, 321)
            RunButton.Margin = New Windows.Forms.Padding(2)
            RunButton.Name = "RunButton"
            RunButton.Size = New Drawing.Size(144, 83)
            RunButton.TabIndex = 5
            RunButton.Text = "Run"
            RunButton.UseVisualStyleBackColor = False
            AddHandler RunButton.Click, New EventHandler(AddressOf Button1_Click)
            ' 
            ' PasswordText
            ' 
            PasswordText.Location = New Drawing.Point(98, 59)
            PasswordText.Name = "PasswordText"
            PasswordText.PasswordChar = "*"c
            PasswordText.Size = New Drawing.Size(650, 21)
            PasswordText.TabIndex = 1
            AddHandler PasswordText.TextChanged, New EventHandler(AddressOf Password_TextChanged)
            ' 
            ' UsernameLabel
            ' 
            UsernameLabel.AutoSize = True
            UsernameLabel.Location = New Drawing.Point(37, 17)
            UsernameLabel.Name = "UsernameLabel"
            UsernameLabel.Size = New Drawing.Size(58, 13)
            UsernameLabel.TabIndex = 3
            UsernameLabel.Text = "Username"
            AddHandler UsernameLabel.Click, New EventHandler(AddressOf Username_Click)
            ' 
            ' PasswordLabel
            ' 
            PasswordLabel.AutoSize = True
            PasswordLabel.Location = New Drawing.Point(37, 62)
            PasswordLabel.Name = "PasswordLabel"
            PasswordLabel.Size = New Drawing.Size(55, 13)
            PasswordLabel.TabIndex = 4
            PasswordLabel.Text = "Password"
            ' 
            ' WaitTime
            ' 
            WaitTime.AutoSize = True
            WaitTime.Location = New Drawing.Point(37, 154)
            WaitTime.Name = "WaitTime"
            WaitTime.Size = New Drawing.Size(108, 13)
            WaitTime.TabIndex = 6
            WaitTime.Text = "Wait time in seconds"
            AddHandler WaitTime.Click, New EventHandler(AddressOf WaitTime_Click)
            ' 
            ' WaitTimeText
            ' 
            WaitTimeText.BackColor = Drawing.SystemColors.Window
            WaitTimeText.Location = New Drawing.Point(151, 151)
            WaitTimeText.Name = "WaitTimeText"
            WaitTimeText.Size = New Drawing.Size(597, 21)
            WaitTimeText.TabIndex = 3
            ' 
            ' FriendLabel
            ' 
            FriendLabel.AutoSize = True
            FriendLabel.Location = New Drawing.Point(37, 110)
            FriendLabel.Name = "FriendLabel"
            FriendLabel.Size = New Drawing.Size(38, 13)
            FriendLabel.TabIndex = 8
            FriendLabel.Text = "Friend"
            ' 
            ' FriendText
            ' 
            FriendText.Location = New Drawing.Point(98, 107)
            FriendText.Name = "FriendText"
            FriendText.Size = New Drawing.Size(650, 21)
            FriendText.TabIndex = 2
            AddHandler FriendText.TextChanged, New EventHandler(AddressOf TextBox1_TextChanged_1)
            ' 
            ' FollowersOrFollowingCheckBox
            ' 
            FollowersOrFollowingCheckBox.AutoSize = True
            FollowersOrFollowingCheckBox.Location = New Drawing.Point(407, 198)
            FollowersOrFollowingCheckBox.Name = "FollowersOrFollowingCheckBox"
            FollowersOrFollowingCheckBox.Size = New Drawing.Size(15, 14)
            FollowersOrFollowingCheckBox.TabIndex = 4
            FollowersOrFollowingCheckBox.UseVisualStyleBackColor = True
            AddHandler FollowersOrFollowingCheckBox.CheckedChanged, New EventHandler(AddressOf CheckBox1_CheckedChanged)
            ' 
            ' FollowOrFollowingLabel
            ' 
            FollowOrFollowingLabel.AutoSize = True
            FollowOrFollowingLabel.Location = New Drawing.Point(37, 198)
            FollowOrFollowingLabel.Name = "FollowOrFollowingLabel"
            FollowOrFollowingLabel.Size = New Drawing.Size(363, 13)
            FollowOrFollowingLabel.TabIndex = 9
            FollowOrFollowingLabel.Text = "Followers or Following? Unchecked for followers, checked for following"
            AddHandler FollowOrFollowingLabel.Click, New EventHandler(AddressOf FollowOrFollowingLabel_Click)
            ' 
            ' checkBox1
            ' 
            checkBox1.AutoSize = True
            checkBox1.Checked = True
            checkBox1.CheckState = Windows.Forms.CheckState.Checked
            checkBox1.Location = New Drawing.Point(407, 223)
            checkBox1.Name = "checkBox1"
            checkBox1.Size = New Drawing.Size(15, 14)
            checkBox1.TabIndex = 10
            checkBox1.UseVisualStyleBackColor = True
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(37, 223)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(200, 13)
            label1.TabIndex = 11
            label1.Text = "Follow or Unfollow? Checked to follow "
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.SystemColors.ActiveCaptionText
            ClientSize = New Drawing.Size(800, 450)
            Controls.Add(checkBox1)
            Controls.Add(label1)
            Controls.Add(FollowersOrFollowingCheckBox)
            Controls.Add(FollowOrFollowingLabel)
            Controls.Add(FriendLabel)
            Controls.Add(FriendText)
            Controls.Add(WaitTime)
            Controls.Add(WaitTimeText)
            Controls.Add(PasswordLabel)
            Controls.Add(UsernameLabel)
            Controls.Add(PasswordText)
            Controls.Add(RunButton)
            Controls.Add(UsernameText)
            Font = New Drawing.Font("Interstate Regular", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            ForeColor = Drawing.SystemColors.ControlLightLight
            Name = "Form1"
            Text = "InstagramFollowers"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private UsernameText As Windows.Forms.TextBox
        Private RunButton As Windows.Forms.Button
        Private PasswordText As Windows.Forms.TextBox
        Private UsernameLabel As Windows.Forms.Label
        Private PasswordLabel As Windows.Forms.Label
        Private WaitTime As Windows.Forms.Label
        Private WaitTimeText As Windows.Forms.TextBox
        Private FriendLabel As Windows.Forms.Label
        Private FriendText As Windows.Forms.TextBox
        Private FollowersOrFollowingCheckBox As Windows.Forms.CheckBox
        Private FollowOrFollowingLabel As Windows.Forms.Label
        Private checkBox1 As Windows.Forms.CheckBox
        Private label1 As Windows.Forms.Label
    End Class
End Namespace
