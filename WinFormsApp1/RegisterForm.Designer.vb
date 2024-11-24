<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        backBtn = New Guna.UI2.WinForms.Guna2Button()
        registerBtn = New Guna.UI2.WinForms.Guna2Button()
        passwordtxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        Label1 = New Label()
        usernametxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' backBtn
        ' 
        backBtn.CustomizableEdges = CustomizableEdges1
        backBtn.DisabledState.BorderColor = Color.DarkGray
        backBtn.DisabledState.CustomBorderColor = Color.DarkGray
        backBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        backBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        backBtn.Font = New Font("Segoe UI", 9F)
        backBtn.ForeColor = Color.White
        backBtn.Location = New Point(359, 338)
        backBtn.Name = "backBtn"
        backBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        backBtn.Size = New Size(138, 45)
        backBtn.TabIndex = 18
        backBtn.Text = "Back"
        ' 
        ' registerBtn
        ' 
        registerBtn.CustomizableEdges = CustomizableEdges3
        registerBtn.DisabledState.BorderColor = Color.DarkGray
        registerBtn.DisabledState.CustomBorderColor = Color.DarkGray
        registerBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        registerBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        registerBtn.Font = New Font("Segoe UI", 9F)
        registerBtn.ForeColor = Color.White
        registerBtn.Location = New Point(205, 338)
        registerBtn.Name = "registerBtn"
        registerBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        registerBtn.Size = New Size(138, 45)
        registerBtn.TabIndex = 17
        registerBtn.Text = "Register"
        ' 
        ' passwordtxtbox
        ' 
        passwordtxtbox.CustomizableEdges = CustomizableEdges5
        passwordtxtbox.DefaultText = ""
        passwordtxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        passwordtxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        passwordtxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passwordtxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passwordtxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passwordtxtbox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordtxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passwordtxtbox.Location = New Point(186, 224)
        passwordtxtbox.Margin = New Padding(4)
        passwordtxtbox.Name = "passwordtxtbox"
        passwordtxtbox.PasswordChar = ChrW(0)
        passwordtxtbox.PlaceholderText = ""
        passwordtxtbox.SelectedText = ""
        passwordtxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        passwordtxtbox.Size = New Size(353, 50)
        passwordtxtbox.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(95, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 21)
        Label2.TabIndex = 15
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(95, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 21)
        Label1.TabIndex = 14
        Label1.Text = "Username:"
        ' 
        ' usernametxtbox
        ' 
        usernametxtbox.CustomizableEdges = CustomizableEdges7
        usernametxtbox.DefaultText = ""
        usernametxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        usernametxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        usernametxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernametxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernametxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernametxtbox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernametxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernametxtbox.Location = New Point(186, 166)
        usernametxtbox.Margin = New Padding(4)
        usernametxtbox.Name = "usernametxtbox"
        usernametxtbox.PasswordChar = ChrW(0)
        usernametxtbox.PlaceholderText = ""
        usernametxtbox.SelectedText = ""
        usernametxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        usernametxtbox.Size = New Size(353, 50)
        usernametxtbox.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(186, 281)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(128, 29)
        ComboBox1.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(273, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 50)
        Label3.TabIndex = 21
        Label3.Text = "Register"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(658, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(25, 23)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 43)
        Panel1.TabIndex = 31
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(693, 490)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(backBtn)
        Controls.Add(registerBtn)
        Controls.Add(passwordtxtbox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(usernametxtbox)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterForm"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents registerBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passwordtxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents usernametxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
