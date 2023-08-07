Imports System
Imports System.Windows.Forms

Namespace InstagramFollowers
    Public Partial Class Form1
        Inherits Form

        Private run As Selenium = New Selenium()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

            'TextBox1.Text = "";

        End Sub

        Private Sub InitializeMyControl()
            ' Put some text into the control first.  
            ' UsernameText.Text = "Enter username";
            PasswordText.Text = "Enter password"

        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

            run.User = UsernameText.Text

            run.Pass = PasswordText.Text

            run.Friend = FriendText.Text

            run.Time = Convert.ToInt32(WaitTimeText.Text)

            run.FollowOrFollowing = FollowersOrFollowingCheckBox.Checked

            run.FollowOrUnfollow = checkBox1.Checked

            run.RunScript()

        End Sub

        Private Sub Username_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub Password_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub TextBox1_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub FollowOrFollowingLabel_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub WaitTime_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
    End Class

End Namespace
