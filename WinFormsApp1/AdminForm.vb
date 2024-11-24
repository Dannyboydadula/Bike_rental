Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


            LoginForm.Show()


            Me.Close()
        End If
    End Sub

    Private Sub bikerentBtn_Click(sender As Object, e As EventArgs) Handles bikerentBtn.Click
        ' Clear any existing controls in the panel
        adminlogo_panel.Controls.Clear()

        ' Set the TopLevel property to False to allow the form to be displayed within a panel
        Bike_rentForm.TopLevel = False

        ' Add the form to the panel
        adminlogo_panel.Controls.Add(Bike_rentForm)

        ' Display the form
        Bike_rentForm.Show()
    End Sub

    Private Sub returnbikeBtn_Click(sender As Object, e As EventArgs) Handles returnbikeBtn.Click
        ' Clear any existing controls in the panel
        adminlogo_panel.Controls.Clear()

        ' Set the TopLevel property to False to allow the form to be displayed within a panel
        Return_bikeForm.TopLevel = False

        ' Add the form to the panel
        adminlogo_panel.Controls.Add(Return_bikeForm)

        ' Display the form
        Return_bikeForm.Show()
    End Sub

    Private Sub viewrentalsBtn_Click(sender As Object, e As EventArgs) Handles viewrentalsBtn.Click
        ' Clear any existing controls in the panel
        adminlogo_panel.Controls.Clear()

        ' Set the TopLevel property to False to allow the form to be displayed within a panel
        ViewrentalsForm.TopLevel = False

        ' Add the form to the panel
        adminlogo_panel.Controls.Add(ViewrentalsForm)

        ' Display the form
        ViewrentalsForm.Show()
    End Sub

End Class