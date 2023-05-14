<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPTIONS
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
        Label4 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(12, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 21)
        Label1.TabIndex = 0
        Label1.Text = "Check Balance"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(12, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 21)
        Label2.TabIndex = 1
        Label2.Text = "Withdraw Cash"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(227, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 21)
        Label4.TabIndex = 3
        Label4.Text = "Transfer Money"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Yellow
        Label6.Location = New Point(263, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 21)
        Label6.TabIndex = 5
        Label6.Text = "Change PIN"' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(380, 230)
        Panel1.TabIndex = 6
        ' 
        ' OPTIONS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(380, 230)
        Controls.Add(Panel1)
        Name = "OPTIONS"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
