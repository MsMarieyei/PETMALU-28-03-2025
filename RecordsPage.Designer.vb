<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordsPage
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
        DataGridView1 = New DataGridView()
        BtnBack = New Button()
        BtnPrint = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(25, 73)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1869, 565)
        DataGridView1.TabIndex = 0
        ' 
        ' BtnBack
        ' 
        BtnBack.Location = New Point(1694, 949)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(94, 29)
        BtnBack.TabIndex = 1
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnPrint
        ' 
        BtnPrint.Location = New Point(1552, 949)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(94, 29)
        BtnPrint.TabIndex = 2
        BtnPrint.Text = "PRINT"
        BtnPrint.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(1380, 949)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(1213, 949)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 4
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' RecordsPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1033)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnPrint)
        Controls.Add(BtnBack)
        Controls.Add(DataGridView1)
        Name = "RecordsPage"
        Text = "RecordsPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
End Class
