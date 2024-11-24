<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label3 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        logoutBtn = New Guna.UI2.WinForms.Guna2Button()
        viewrentalsBtn = New Guna.UI2.WinForms.Guna2Button()
        returnbikeBtn = New Guna.UI2.WinForms.Guna2Button()
        bikerentBtn = New Guna.UI2.WinForms.Guna2Button()
        adminlogo_panel = New Guna.UI2.WinForms.Guna2Panel()
        Panel1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(49, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 50)
        Label3.TabIndex = 22
        Label3.Text = "Admin"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(832, 8)
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
        Panel1.Size = New Size(867, 43)
        Panel1.TabIndex = 31
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = SystemColors.ActiveBorder
        Guna2Panel1.Controls.Add(logoutBtn)
        Guna2Panel1.Controls.Add(viewrentalsBtn)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.Controls.Add(returnbikeBtn)
        Guna2Panel1.Controls.Add(bikerentBtn)
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.Location = New Point(0, 43)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.Size = New Size(272, 528)
        Guna2Panel1.TabIndex = 32
        ' 
        ' logoutBtn
        ' 
        logoutBtn.CustomizableEdges = CustomizableEdges1
        logoutBtn.DisabledState.BorderColor = Color.DarkGray
        logoutBtn.DisabledState.CustomBorderColor = Color.DarkGray
        logoutBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        logoutBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        logoutBtn.Font = New Font("Segoe UI", 9F)
        logoutBtn.ForeColor = Color.White
        logoutBtn.Location = New Point(25, 390)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        logoutBtn.Size = New Size(180, 45)
        logoutBtn.TabIndex = 36
        logoutBtn.Text = "Logout"
        ' 
        ' viewrentalsBtn
        ' 
        viewrentalsBtn.CustomizableEdges = CustomizableEdges3
        viewrentalsBtn.DisabledState.BorderColor = Color.DarkGray
        viewrentalsBtn.DisabledState.CustomBorderColor = Color.DarkGray
        viewrentalsBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        viewrentalsBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        viewrentalsBtn.Font = New Font("Segoe UI", 9F)
        viewrentalsBtn.ForeColor = Color.White
        viewrentalsBtn.Location = New Point(25, 280)
        viewrentalsBtn.Name = "viewrentalsBtn"
        viewrentalsBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        viewrentalsBtn.Size = New Size(180, 45)
        viewrentalsBtn.TabIndex = 35
        viewrentalsBtn.Text = "View rentals"
        ' 
        ' returnbikeBtn
        ' 
        returnbikeBtn.CustomizableEdges = CustomizableEdges5
        returnbikeBtn.DisabledState.BorderColor = Color.DarkGray
        returnbikeBtn.DisabledState.CustomBorderColor = Color.DarkGray
        returnbikeBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        returnbikeBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        returnbikeBtn.Font = New Font("Segoe UI", 9F)
        returnbikeBtn.ForeColor = Color.White
        returnbikeBtn.Location = New Point(25, 218)
        returnbikeBtn.Name = "returnbikeBtn"
        returnbikeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        returnbikeBtn.Size = New Size(180, 45)
        returnbikeBtn.TabIndex = 34
        returnbikeBtn.Text = "Return bike"
        ' 
        ' bikerentBtn
        ' 
        bikerentBtn.CustomizableEdges = CustomizableEdges7
        bikerentBtn.DisabledState.BorderColor = Color.DarkGray
        bikerentBtn.DisabledState.CustomBorderColor = Color.DarkGray
        bikerentBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        bikerentBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        bikerentBtn.Font = New Font("Segoe UI", 9F)
        bikerentBtn.ForeColor = Color.White
        bikerentBtn.Location = New Point(25, 154)
        bikerentBtn.Name = "bikerentBtn"
        bikerentBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        bikerentBtn.Size = New Size(180, 45)
        bikerentBtn.TabIndex = 33
        bikerentBtn.Text = "Bike rent"
        ' 
        ' adminlogo_panel
        ' 
        adminlogo_panel.CustomizableEdges = CustomizableEdges11
        adminlogo_panel.Location = New Point(271, 43)
        adminlogo_panel.Name = "adminlogo_panel"
        adminlogo_panel.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        adminlogo_panel.Size = New Size(596, 528)
        adminlogo_panel.TabIndex = 33
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(867, 571)
        Controls.Add(adminlogo_panel)
        Controls.Add(Guna2Panel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        Panel1.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents logoutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents viewrentalsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents returnbikeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bikerentBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminlogo_panel As Guna.UI2.WinForms.Guna2Panel
End Class
