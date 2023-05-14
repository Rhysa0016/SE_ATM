<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIN
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
        PIN_lbl1 = New Label()
        PINTextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' PIN_lbl1
        ' 
        PIN_lbl1.AutoSize = True
        PIN_lbl1.Font = New Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PIN_lbl1.ForeColor = Color.Yellow
        PIN_lbl1.Location = New Point(127, 72)
        PIN_lbl1.Name = "PIN_lbl1"
        PIN_lbl1.Size = New Size(145, 21)
        PIN_lbl1.TabIndex = 4
        PIN_lbl1.Text = "Enter Your PIN:"' 
        ' PINTextBox1
        ' 
        PINTextBox1.BackColor = Color.SteelBlue
        PINTextBox1.Location = New Point(129, 107)
        PINTextBox1.Name = "PINTextBox1"
        PINTextBox1.Size = New Size(131, 29)
        PINTextBox1.TabIndex = 6
        ' 
        ' PIN
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(383, 235)
        Controls.Add(PINTextBox1)
        Controls.Add(PIN_lbl1)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.Yellow
        Margin = New Padding(4, 4, 4, 4)
        Name = "PIN"
        Text = "PIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PIN_lbl1 As Label
    Friend WithEvents PINTextBox1 As TextBox
End Class
