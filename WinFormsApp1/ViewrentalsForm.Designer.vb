﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewrentalsForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        namecolumn = New DataGridViewTextBoxColumn()
        rfidcolumn = New DataGridViewTextBoxColumn()
        renttimecolumn = New DataGridViewTextBoxColumn()
        returntimecolumn = New DataGridViewTextBoxColumn()
        statuscolumn = New DataGridViewTextBoxColumn()
        deleteBtn = New Guna.UI2.WinForms.Guna2Button()
        refreshBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToAddRows = False
        Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 32
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.Columns.AddRange(New DataGridViewColumn() {namecolumn, rfidcolumn, renttimecolumn, returntimecolumn, statuscolumn})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(0, 0)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.ReadOnly = True
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.Size = New Size(596, 365)
        Guna2DataGridView1.TabIndex = 0
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 32
        Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' namecolumn
        ' 
        namecolumn.HeaderText = "Name"
        namecolumn.Name = "namecolumn"
        namecolumn.ReadOnly = True
        ' 
        ' rfidcolumn
        ' 
        rfidcolumn.HeaderText = "RFID"
        rfidcolumn.Name = "rfidcolumn"
        rfidcolumn.ReadOnly = True
        ' 
        ' renttimecolumn
        ' 
        renttimecolumn.HeaderText = "Rent Time"
        renttimecolumn.Name = "renttimecolumn"
        renttimecolumn.ReadOnly = True
        ' 
        ' returntimecolumn
        ' 
        returntimecolumn.HeaderText = "Return Time"
        returntimecolumn.Name = "returntimecolumn"
        returntimecolumn.ReadOnly = True
        ' 
        ' statuscolumn
        ' 
        statuscolumn.HeaderText = "Status"
        statuscolumn.Name = "statuscolumn"
        statuscolumn.ReadOnly = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.CustomizableEdges = CustomizableEdges1
        deleteBtn.DisabledState.BorderColor = Color.DarkGray
        deleteBtn.DisabledState.CustomBorderColor = Color.DarkGray
        deleteBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        deleteBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        deleteBtn.Font = New Font("Segoe UI", 12F)
        deleteBtn.ForeColor = Color.White
        deleteBtn.Location = New Point(318, 400)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        deleteBtn.Size = New Size(180, 45)
        deleteBtn.TabIndex = 1
        deleteBtn.Text = "Delete"
        ' 
        ' refreshBtn
        ' 
        refreshBtn.CustomizableEdges = CustomizableEdges3
        refreshBtn.DisabledState.BorderColor = Color.DarkGray
        refreshBtn.DisabledState.CustomBorderColor = Color.DarkGray
        refreshBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        refreshBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        refreshBtn.Font = New Font("Segoe UI", 12F)
        refreshBtn.ForeColor = Color.White
        refreshBtn.Location = New Point(112, 400)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        refreshBtn.Size = New Size(180, 45)
        refreshBtn.TabIndex = 2
        refreshBtn.Text = "Refresh"
        ' 
        ' ViewrentalsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(596, 528)
        Controls.Add(refreshBtn)
        Controls.Add(deleteBtn)
        Controls.Add(Guna2DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewrentalsForm"
        Text = "ViewrentalsForm"
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents deleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents refreshBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents namecolumn As DataGridViewTextBoxColumn
    Friend WithEvents rfidcolumn As DataGridViewTextBoxColumn
    Friend WithEvents renttimecolumn As DataGridViewTextBoxColumn
    Friend WithEvents returntimecolumn As DataGridViewTextBoxColumn
    Friend WithEvents statuscolumn As DataGridViewTextBoxColumn
End Class
