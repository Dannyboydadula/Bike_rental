Imports MySql.Data.MySqlClient

Public Class ViewrentalsForm

    Public Function FetchBikeDetails() As DataTable
        Dim dt As New DataTable()

        Try
            Connect() ' Ensure the connection is established
            query = "SELECT Name, RFID, rent_date_time AS 'Rental Date', return_date_time AS 'Return Date', " &
                "CASE WHEN return_date_time IS NULL THEN 'Pending' ELSE 'Completed' END AS 'Status' " &
                "FROM bike_details"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader()

            dt.Load(reader) ' Load the data into DataTable
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return dt
    End Function


    Private Sub LoadData()
        Try
            Dim dt As DataTable = FetchBikeDetails()
            Guna2DataGridView1.DataSource = dt ' Bind the DataTable to DataGridView

            ' Optionally adjust column widths and headers
            With Guna2DataGridView1
                .Columns("Name").HeaderText = "Customer Name"
                .Columns("RFID").HeaderText = "RFID Tag"
                .Columns("Rental Date").HeaderText = "Rental Date"
                .Columns("Return Date").HeaderText = "Return Date"
                .Columns("Status").HeaderText = "Rental Status"
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading data into DataGridView: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewrentalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class