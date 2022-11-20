Public Class Login_Form

    Dim Login_Attempts As Integer = 0



    Private Sub Username_Textbox_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Password_Textbox_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click

        Dim Correct_Username As String = "Admin" 'LOGIN HERE IF U CANT FIND
        Dim Correct_Password As String = "Admin" 'LOGIN HERE IF U CANT FIND

        If Username_Textbox.Text = Correct_Username And Password_Textbox.Text = Correct_Password Then ' If Login Correct

            MsgBox("Login Successful")
            Customer_Bookings_Form.Show()
            Me.Hide()

        ElseIf Login_Attempts = 2 Then ' If too many logins
            Login_Attempts = Login_Attempts + 1
            Login_Attempts_Changing.Text = Login_Attempts

            MsgBox("You have attempted to login too many times, the application will now close")
            Me.Close()

        Else 'fail attempt
            Login_Attempts = Login_Attempts + 1
            Login_Attempts_Changing.Text = Login_Attempts
            MsgBox("The username or password entered is incorrect")

        End If


    End Sub

    Private Sub Login_Attempts_Changing_Click(sender As Object, e As EventArgs) Handles Login_Attempts_Changing.Click






    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
