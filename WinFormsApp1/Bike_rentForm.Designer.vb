<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bike_rentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        nameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        phoneTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        rfidTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        Label6 = New Label()
        addressTxt = New Guna.UI2.WinForms.Guna2TextBox()
        submitBtn = New Guna.UI2.WinForms.Guna2Button()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' nameTxt
        ' 
        nameTxt.CustomizableEdges = CustomizableEdges1
        nameTxt.DefaultText = ""
        nameTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        nameTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        nameTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        nameTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        nameTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        nameTxt.Font = New Font("Segoe UI", 9.75F)
        nameTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        nameTxt.Location = New Point(142, 80)
        nameTxt.Name = "nameTxt"
        nameTxt.PasswordChar = ChrW(0)
        nameTxt.PlaceholderText = ""
        nameTxt.SelectedText = ""
        nameTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        nameTxt.Size = New Size(381, 45)
        nameTxt.TabIndex = 0
        ' 
        ' phoneTxt
        ' 
        phoneTxt.CustomizableEdges = CustomizableEdges3
        phoneTxt.DefaultText = ""
        phoneTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        phoneTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        phoneTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        phoneTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        phoneTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        phoneTxt.Font = New Font("Segoe UI", 9.75F)
        phoneTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        phoneTxt.Location = New Point(142, 149)
        phoneTxt.Name = "phoneTxt"
        phoneTxt.PasswordChar = ChrW(0)
        phoneTxt.PlaceholderText = ""
        phoneTxt.SelectedText = ""
        phoneTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        phoneTxt.Size = New Size(381, 45)
        phoneTxt.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label1.Location = New Point(57, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 2
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label2.Location = New Point(57, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 3
        Label2.Text = "Phone:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.Location = New Point(57, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 5
        Label3.Text = "RFID:"
        ' 
        ' rfidTxt
        ' 
        rfidTxt.CustomizableEdges = CustomizableEdges5
        rfidTxt.DefaultText = ""
        rfidTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        rfidTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        rfidTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        rfidTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        rfidTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rfidTxt.Font = New Font("Segoe UI", 9.75F)
        rfidTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rfidTxt.Location = New Point(142, 215)
        rfidTxt.Name = "rfidTxt"
        rfidTxt.PasswordChar = ChrW(0)
        rfidTxt.PlaceholderText = ""
        rfidTxt.SelectedText = ""
        rfidTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        rfidTxt.Size = New Size(381, 45)
        rfidTxt.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label4.Location = New Point(57, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 20)
        Label4.TabIndex = 7
        Label4.Text = "Rent date and time:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label6.Location = New Point(57, 358)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 20)
        Label6.TabIndex = 12
        Label6.Text = "Address:"
        ' 
        ' addressTxt
        ' 
        addressTxt.CustomizableEdges = CustomizableEdges7
        addressTxt.DefaultText = ""
        addressTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        addressTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        addressTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        addressTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        addressTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        addressTxt.Font = New Font("Segoe UI", 9.75F)
        addressTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        addressTxt.Location = New Point(149, 348)
        addressTxt.Name = "addressTxt"
        addressTxt.PasswordChar = ChrW(0)
        addressTxt.PlaceholderText = ""
        addressTxt.SelectedText = ""
        addressTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        addressTxt.Size = New Size(374, 45)
        addressTxt.TabIndex = 11
        ' 
        ' submitBtn
        ' 
        submitBtn.CustomizableEdges = CustomizableEdges9
        submitBtn.DisabledState.BorderColor = Color.DarkGray
        submitBtn.DisabledState.CustomBorderColor = Color.DarkGray
        submitBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        submitBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        submitBtn.Font = New Font("Segoe UI", 9F)
        submitBtn.ForeColor = Color.White
        submitBtn.Location = New Point(210, 414)
        submitBtn.Name = "submitBtn"
        submitBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        submitBtn.Size = New Size(182, 45)
        submitBtn.TabIndex = 13
        submitBtn.Text = "Submit"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(245, 295)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(278, 26)
        DateTimePicker1.TabIndex = 14
        ' 
        ' Bike_rentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(596, 528)
        Controls.Add(DateTimePicker1)
        Controls.Add(submitBtn)
        Controls.Add(Label6)
        Controls.Add(addressTxt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(rfidTxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(phoneTxt)
        Controls.Add(nameTxt)
        FormBorderStyle = FormBorderStyle.None
        Name = "Bike_rentForm"
        Text = "Bike_rentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents phoneTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rfidTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents addressTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents submitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
