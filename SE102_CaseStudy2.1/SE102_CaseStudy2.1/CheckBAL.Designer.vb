<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBAL
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(12, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 0
        Label1.Text = "Balance:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(12, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(217, 21)
        Label2.TabIndex = 1
        Label2.Text = "Acct Number Ending in: "' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(324, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 21)
        Label3.TabIndex = 2
        Label3.Text = "Back"' 
        ' CheckBAL
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(382, 240)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "CheckBAL"
        Text = "CheckBAL"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
