Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Bike_rentForm
    Private Sub Bike_rentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom ' Set the format to Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt" ' Set the custom format for date and time
        DateTimePicker1.ShowUpDown = True ' Show the up-down control for time selection

        LoadRFIDTag()
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
            ' Connect to the database
            Connector.Connect()

            ' Insert data into bike_details
            Connector.query = "INSERT INTO bike_details (name, phone, rfid, rent_date_time, address) " &
                          "VALUES (@name, @phone, @rfid, @rentDateTime, @address)"
            Connector.command = New MySqlCommand(Connector.query, Connector.conn)

            ' Add parameters to prevent SQL injection
            Connector.command.Parameters.AddWithValue("@name", name)
            Connector.command.Parameters.AddWithValue("@phone", phone)
            Connector.command.Parameters.AddWithValue("@rfid", rfid)
            Connector.command.Parameters.AddWithValue("@rentDateTime", rentDateTime)
            Connector.command.Parameters.AddWithValue("@address", address)

            ' Execute the insert query
            Connector.command.ExecuteNonQuery()

            ' Delete the RFID tag from rfid_table
            Connector.query = "DELETE FROM rfid_table WHERE uidtag = @rfid"
            Connector.command = New MySqlCommand(Connector.query, Connector.conn)
            Connector.command.Parameters.AddWithValue("@rfid", rfid)
            Connector.command.ExecuteNonQuery()

            MessageBox.Show("Data saved and RFID tag deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub LoadRFIDTag()
        Try
            ' Open the database connection
            Connector.Connect()

            ' Define the SQL query to retrieve the first uidtag
            Connector.query = "SELECT uidtag FROM rfid_table LIMIT 1"
            Connector.command = New MySqlCommand(Connector.query, Connector.conn)

            ' Execute the query
            Dim reader As MySqlDataReader = Connector.command.ExecuteReader()

            If reader.Read() Then
                ' Display the retrieved uidtag in the rfidTxt TextBox
                rfidTxt.Text = reader("uidtag").ToString()
            Else
                MessageBox.Show("No RFID tag found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Close the reader
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading RFID tag: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            Connector.conn.Close()
        End Try
    End Sub

    Private Sub rfidTxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class