<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePIN
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
        CPLabel1 = New Label()
        CPLabel2 = New Label()
        CPTextBox1 = New TextBox()
        CPTextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' CPLabel1
        ' 
        CPLabel1.AutoSize = True
        CPLabel1.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CPLabel1.ForeColor = Color.Yellow
        CPLabel1.Location = New Point(106, 47)
        CPLabel1.Name = "CPLabel1"
        CPLabel1.Size = New Size(181, 21)
        CPLabel1.TabIndex = 2
        CPLabel1.Text = "Enter Your Old PIN:"' 
        ' CPLabel2
        ' 
        CPLabel2.AutoSize = True
        CPLabel2.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CPLabel2.ForeColor = Color.Yellow
        CPLabel2.Location = New Point(106, 126)
        CPLabel2.Name = "CPLabel2"
        CPLabel2.Size = New Size(181, 21)
        CPLabel2.TabIndex = 3
        CPLabel2.Text = "Enter Your New PIN:"' 
        ' CPTextBox1
        ' 
        CPTextBox1.BackColor = Color.SteelBlue
        CPTextBox1.Location = New Point(130, 71)
        CPTextBox1.Name = "CPTextBox1"
        CPTextBox1.Size = New Size(127, 23)
        CPTextBox1.TabIndex = 4
        ' 
        ' CPTextBox2
        ' 
        CPTextBox2.BackColor = Color.SteelBlue
        CPTextBox2.Location = New Point(130, 150)
        CPTextBox2.Name = "CPTextBox2"
        CPTextBox2.Size = New Size(131, 23)
        CPTextBox2.TabIndex = 5
        ' 
        ' ChangePIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(381, 232)
        Controls.Add(CPTextBox2)
        Controls.Add(CPTextBox1)
        Controls.Add(CPLabel2)
        Controls.Add(CPLabel1)
        Name = "ChangePIN"
        Text = "OtherS"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CPLabel1 As Label
    Friend WithEvents CPLabel2 As Label
    Friend WithEvents CPTextBox1 As TextBox
    Friend WithEvents CPTextBox2 As TextBox
End Class
