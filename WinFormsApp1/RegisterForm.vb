Imports MySql.Data.MySqlClient

Public Class RegisterForm
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Renter")
        ComboBox1.SelectedIndex = 0 ' Default to the first role
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        ' Retrieve input values
        Dim username As String = usernametxtbox.Text.Trim()
        Dim password As String = passwordtxtbox.Text.Trim()
        Dim role As String = ComboBox1.SelectedItem.ToString()

        ' Input validation
        If username = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Connector.Connect()
            ' Check for duplicate username
            Dim duplicateUserQuery As String = "SELECT COUNT(*) FROM bike_rental_table WHERE username = @username"
            Using checkUserCmd As New MySqlCommand(duplicateUserQuery, Connector.conn)
                checkUserCmd.Parameters.AddWithValue("@username", username)
                Dim userCount As Integer = Convert.ToInt32(checkUserCmd.ExecuteScalar())
                If userCount > 0 Then
                    MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using

            ' Check for duplicate password
            Dim duplicatePasswordQuery As String = "SELECT COUNT(*) FROM bike_rental_table WHERE password = @password"
            Using checkPasswordCmd As New MySqlCommand(duplicatePasswordQuery, Connector.conn)
                checkPasswordCmd.Parameters.AddWithValue("@password", password)
                Dim passwordCount As Integer = Convert.ToInt32(checkPasswordCmd.ExecuteScalar())
                If passwordCount > 0 Then
                    MessageBox.Show("Password already exists. Please choose a different password.", "Duplicate Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using

            ' Insert new user
            Dim insertQuery As String = "INSERT INTO bike_rental_table (username, password, role) VALUES (@username, @password, @role)"
            Using insertCmd As New MySqlCommand(insertQuery, Connector.conn)
                insertCmd.Parameters.AddWithValue("@username", username)
                insertCmd.Parameters.AddWithValue("@password", password)
                insertCmd.Parameters.AddWithValue("@role", role)
                insertCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            usernametxtbox.Clear()
            passwordtxtbox.Clear()
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connector.conn.Close()
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub


    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        LoginForm.Show()

        ' Close the current RegisterForm
        Me.Close()
    End Sub
End Class