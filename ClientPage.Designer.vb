﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientPage))
        Label1 = New Label()
        Label2 = New Label()
        TxtSearch = New TextBox()
        BtnEnter = New Button()
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(688, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(522, 149)
        Label1.TabIndex = 0
        Label1.Text = "CLIENTS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label2.Location = New Point(604, 493)
        Label2.Name = "Label2"
        Label2.Size = New Size(508, 52)
        Label2.TabIndex = 1
        Label2.Text = "Enter your client name:"
        ' 
        ' TxtSearch
        ' 
        TxtSearch.BackColor = Color.YellowGreen
        TxtSearch.BorderStyle = BorderStyle.FixedSingle
        TxtSearch.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtSearch.Location = New Point(613, 548)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(677, 54)
        TxtSearch.TabIndex = 2
        ' 
        ' BtnEnter
        ' 
        BtnEnter.BackColor = Color.DarkOliveGreen
        BtnEnter.FlatStyle = FlatStyle.Popup
        BtnEnter.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEnter.ForeColor = Color.White
        BtnEnter.Location = New Point(859, 704)
        BtnEnter.Name = "BtnEnter"
        BtnEnter.Size = New Size(162, 45)
        BtnEnter.TabIndex = 3
        BtnEnter.Text = "Enter"
        BtnEnter.UseVisualStyleBackColor = False
        ' 
        ' BtnBack
        ' 
        BtnBack.Location = New Point(1669, 934)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(94, 29)
        BtnBack.TabIndex = 4
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' ClientPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(BtnBack)
        Controls.Add(BtnEnter)
        Controls.Add(TxtSearch)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ClientPage"
        Text = "ClientPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BtnBack As Button
End Class
