Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        ' Retrieve input values
        Dim username As String = usernametxtbox.Text.Trim()
        Dim password As String = passwordtxtbox.Text.Trim()

        ' Input validation
        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Ensure connection is open
            If Connector.conn IsNot Nothing AndAlso Connector.conn.State = ConnectionState.Open Then
                Connector.conn.Close()
            End If
            Connector.Connect()

            ' Query to authenticate user
            Dim loginQuery As String = "SELECT role FROM bike_rental_table WHERE username = @username AND password = @password"
            Using loginCmd As New MySqlCommand(loginQuery, Connector.conn)
                loginCmd.Parameters.AddWithValue("@username", username)
                loginCmd.Parameters.AddWithValue("@password", password) ' Use hashed password if implemented

                Dim role As Object = loginCmd.ExecuteScalar()
                If role IsNot Nothing Then
                    ' Determine the form to open based on the role
                    If role.ToString() = "Admin" Then
                        Dim adminForm As New AdminForm()
                        adminForm.Show()
                    ElseIf role.ToString() = "Renter" Then
                        Dim renterForm As New RenterForm()
                        renterForm.Show()
                    Else
                        MessageBox.Show("Unknown role. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    ' Close the login form after successful login
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connector.conn.Close()
        End Try
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        ' Open RegisterForm
        Dim registerForm As New RegisterForm()
        registerForm.Show()
        Me.Hide() ' Optional: Hide the MainForm
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub
End Class