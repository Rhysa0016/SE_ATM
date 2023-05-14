<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfer
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
        Label1 = New Label()
        WdTextBox1 = New TextBox()
        WdTextBox2 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(99, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 3
        Label2.Text = "Amount:"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(27, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 21)
        Label1.TabIndex = 4
        Label1.Text = "Account Number:"' 
        ' WdTextBox1
        ' 
        WdTextBox1.BackColor = Color.SteelBlue
        WdTextBox1.Location = New Point(200, 81)
        WdTextBox1.Name = "WdTextBox1"
        WdTextBox1.Size = New Size(127, 23)
        WdTextBox1.TabIndex = 6
        ' 
        ' WdTextBox2
        ' 
        WdTextBox2.BackColor = Color.SteelBlue
        WdTextBox2.Location = New Point(200, 135)
        WdTextBox2.Name = "WdTextBox2"
        WdTextBox2.Size = New Size(127, 23)
        WdTextBox2.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(112, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 21)
        Label3.TabIndex = 8
        Label3.Text = "Transfer Money"' 
        ' Transfer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(370, 241)
        Controls.Add(Label3)
        Controls.Add(WdTextBox2)
        Controls.Add(WdTextBox1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "Transfer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WdTextBox1 As TextBox
    Friend WithEvents WdTextBox2 As TextBox
    Friend WithEvents Label3 As Label
End Class
