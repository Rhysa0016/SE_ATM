<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
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
        Label2 = New Label()
        WdTextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(60, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(262, 21)
        Label2.TabIndex = 2
        Label2.Text = "Enter an amount to withdraw:"' 
        ' WdTextBox1
        ' 
        WdTextBox1.BackColor = Color.SteelBlue
        WdTextBox1.Location = New Point(118, 103)
        WdTextBox1.Name = "WdTextBox1"
        WdTextBox1.Size = New Size(127, 23)
        WdTextBox1.TabIndex = 5
        ' 
        ' Withdraw
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(376, 230)
        Controls.Add(WdTextBox1)
        Controls.Add(Label2)
        Name = "Withdraw"
        Text = "Withdraw"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents WdTextBox1 As TextBox
End Class
