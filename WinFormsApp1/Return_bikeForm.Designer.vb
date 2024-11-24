<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_bikeForm
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
        submitBtn = New Guna.UI2.WinForms.Guna2Button()
        Label6 = New Label()
        Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' submitBtn
        ' 
        submitBtn.CustomizableEdges = CustomizableEdges1
        submitBtn.DisabledState.BorderColor = Color.DarkGray
        submitBtn.DisabledState.CustomBorderColor = Color.DarkGray
        submitBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        submitBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        submitBtn.Font = New Font("Segoe UI", 9F)
        submitBtn.ForeColor = Color.White
        submitBtn.Location = New Point(145, 380)
        submitBtn.Name = "submitBtn"
        submitBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        submitBtn.Size = New Size(180, 45)
        submitBtn.TabIndex = 24
        submitBtn.Text = "Submit"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(52, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 17)
        Label6.TabIndex = 23
        Label6.Text = "Feedback:"
        ' 
        ' Guna2TextBox4
        ' 
        Guna2TextBox4.CustomizableEdges = CustomizableEdges3
        Guna2TextBox4.DefaultText = ""
        Guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox4.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Font = New Font("Segoe UI", 9.75F)
        Guna2TextBox4.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Location = New Point(126, 256)
        Guna2TextBox4.Name = "Guna2TextBox4"
        Guna2TextBox4.PasswordChar = ChrW(0)
        Guna2TextBox4.PlaceholderText = ""
        Guna2TextBox4.SelectedText = ""
        Guna2TextBox4.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox4.Size = New Size(275, 107)
        Guna2TextBox4.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(52, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 17)
        Label4.TabIndex = 20
        Label4.Text = "Return date and time:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(52, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 17)
        Label3.TabIndex = 19
        Label3.Text = "RFID:"
        ' 
        ' Guna2TextBox3
        ' 
        Guna2TextBox3.CustomizableEdges = CustomizableEdges5
        Guna2TextBox3.DefaultText = ""
        Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Font = New Font("Segoe UI", 9.75F)
        Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Location = New Point(119, 121)
        Guna2TextBox3.Name = "Guna2TextBox3"
        Guna2TextBox3.PasswordChar = ChrW(0)
        Guna2TextBox3.PlaceholderText = ""
        Guna2TextBox3.SelectedText = ""
        Guna2TextBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TextBox3.Size = New Size(282, 40)
        Guna2TextBox3.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 17)
        Label1.TabIndex = 16
        Label1.Text = "Name:"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.CustomizableEdges = CustomizableEdges7
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9.75F)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(119, 50)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2TextBox1.Size = New Size(282, 40)
        Guna2TextBox1.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(201, 198)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 25
        ' 
        ' Return_bikeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 447)
        Controls.Add(DateTimePicker1)
        Controls.Add(submitBtn)
        Controls.Add(Label6)
        Controls.Add(Guna2TextBox4)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Guna2TextBox3)
        Controls.Add(Label1)
        Controls.Add(Guna2TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Return_bikeForm"
        Text = "Return_bikeForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents submitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
