Imports MySql.Data.MySqlClient

Public Class ViewrentalsForm
    Private Sub ViewrentalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView when the form loads
        LoadBikeDetails()
    End Sub

    Private Sub LoadBikeDetails()
        Try
            ' Ensure connection is established
            Connect()

            ' Define query to fetch data, including return_date_time
            query = "SELECT name, rfid, rent_date_time, return_date_time FROM bike_details"

            ' Create a MySqlCommand
            Dim cmd As New MySqlCommand(query, conn)

            ' Execute the query and read the results
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in the DataGridView
            Guna2DataGridView1.Rows.Clear()

            ' Populate the DataGridView with the fetched data
            While reader.Read()
                ' Determine the status based on return_date_time
                Dim status As String = If(IsDBNull(reader("return_date_time")), "Pending", "Complete")

                ' Add data to the DataGridView
                Guna2DataGridView1.Rows.Add(
                    reader("name").ToString(),
                    reader("rfid").ToString(),
                    reader("rent_date_time").ToString(),
                    If(IsDBNull(reader("return_date_time")), "", reader("return_date_time").ToString()),
                    status
                )
            End While

            ' Close the reader and connection
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        ' Refresh the DataGridView
        LoadBikeDetails()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Try
            ' Check if a row is selected
            If Guna2DataGridView1.SelectedRows.Count > 0 Then
                ' Get the RFID of the selected row (assumes RFID is in the second column)
                Dim selectedRow As DataGridViewRow = Guna2DataGridView1.SelectedRows(0)
                Dim rfid As String = selectedRow.Cells("rfidcolumn").Value.ToString()

                ' Confirm deletion
                Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirmResult = DialogResult.Yes Then
                    ' Ensure connection is established
                    Connect()

                    ' Define delete query using the RFID
                    Dim deleteQuery As String = "DELETE FROM bike_details WHERE rfid = @rfid"

                    ' Create a MySqlCommand for deletion
                    Dim cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@rfid", rfid)

                    ' Execute the query to delete the record
                    cmd.ExecuteNonQuery()

                    ' Close the connection
                    conn.Close()

                    ' Reload the DataGridView to reflect the changes
                    LoadBikeDetails()

                    ' Notify the user
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
