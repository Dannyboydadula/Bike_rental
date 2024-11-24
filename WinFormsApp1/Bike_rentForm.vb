Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Bike_rentForm
    Private Sub Bike_rentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom ' Set the format to Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt" ' Set the custom format for date and time
        DateTimePicker1.ShowUpDown = True ' Show the up-down control for time selection
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' You can handle the selected date and time here
        Dim selectedDateTime As DateTime = DateTimePicker1.Value
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        ' Collect data from the form
        Dim name As String = nameTxt.Text
        Dim phone As String = phoneTxt.Text
        Dim rfid As String = rfidTxt.Text
        Dim rentDateTime As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim address As String = addressTxt.Text

        ' Validate fields
        If String.IsNullOrWhiteSpace(name) Or String.IsNullOrWhiteSpace(phone) Or
           String.IsNullOrWhiteSpace(rfid) Or String.IsNullOrWhiteSpace(address) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Save data to the database
        Try
            Connector.Connect()

            Connector.query = "INSERT INTO bike_details (name, phone, rfid, rent_date_time, address) " &
                              "VALUES (@name, @phone, @rfid, @rentDateTime, @address)"
            Connector.command = New MySqlCommand(Connector.query, Connector.conn)

            ' Add parameters to prevent SQL injection
            Connector.command.Parameters.AddWithValue("@name", name)
            Connector.command.Parameters.AddWithValue("@phone", phone)
            Connector.command.Parameters.AddWithValue("@rfid", rfid)
            Connector.command.Parameters.AddWithValue("@rentDateTime", rentDateTime)
            Connector.command.Parameters.AddWithValue("@address", address)

            Connector.command.ExecuteNonQuery()

            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form fields after saving
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connector.conn.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        nameTxt.Clear()
        phoneTxt.Clear()
        rfidTxt.Clear()
        addressTxt.Clear()
        DateTimePicker1.Value = DateTime.Now
    End Sub
End Class