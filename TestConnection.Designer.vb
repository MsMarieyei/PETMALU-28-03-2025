<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestConnection
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
        BtnTest = New Button()
        SuspendLayout()
        ' 
        ' BtnTest
        ' 
        BtnTest.Location = New Point(250, 173)
        BtnTest.Name = "BtnTest"
        BtnTest.Size = New Size(109, 44)
        BtnTest.TabIndex = 0
        BtnTest.Text = "test"
        BtnTest.UseVisualStyleBackColor = True
        ' 
        ' TestConnection
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnTest)
        Name = "TestConnection"
        Text = "TestConnection"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnTest As Button
End Class
