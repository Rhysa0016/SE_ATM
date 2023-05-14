
Imports System.Runtime.CompilerServices

Public Class frmMAIN

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(panel)

        panel.Show()


    End Sub
    Private Sub enterkey_Click(sender As Object, e As EventArgs)
        switchPanel(OPTIONS)

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        switchPanel(ChangePIN)

    End Sub

    Private Sub MainBtn1_Click(sender As Object, e As EventArgs) Handles MainBtn1.Click
        switchPanel(CheckBAL)

    End Sub

    Private Sub MainBtn2_Click(sender As Object, e As EventArgs) Handles MainBtn2.Click
        switchPanel(Withdraw)
    End Sub

    Private Sub MainBtn4_Click(sender As Object, e As EventArgs) Handles MainBtn4.Click
        switchPanel(Transfer)
    End Sub

    Private Sub MainBtn5_Click(sender As Object, e As EventArgs) Handles MainBtn5.Click
        switchPanel(ChangePIN)

    End Sub

    Private Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        switchPanel(PIN)
    End Sub

    Private Sub key1_Click(sender As Object, e As EventArgs) Handles key1.Click

        PIN.PINTextBox1.Text += "1"


    End Sub
    Private Sub key2_Click(sender As Object, e As EventArgs) Handles key2.Click
        PIN.PINTextBox1.Text += "2"

    End Sub

    Private Sub key3_Click(sender As Object, e As EventArgs) Handles key3.Click
        PIN.PINTextBox1.Text += "3"

    End Sub

    Private Sub key4_Click(sender As Object, e As EventArgs) Handles key4.Click
        PIN.PINTextBox1.Text += "4"

    End Sub

    Private Sub key5_Click(sender As Object, e As EventArgs) Handles key5.Click
        PIN.PINTextBox1.Text += "5"

    End Sub

    Private Sub key6_Click(sender As Object, e As EventArgs) Handles key6.Click
        PIN.PINTextBox1.Text += "6"

    End Sub

    Private Sub key7_Click(sender As Object, e As EventArgs) Handles key7.Click
        PIN.PINTextBox1.Text += "7"

    End Sub

    Private Sub key8_Click(sender As Object, e As EventArgs) Handles key8.Click
        PIN.PINTextBox1.Text += "8"

    End Sub

    Private Sub key9_Click(sender As Object, e As EventArgs) Handles key9.Click
        PIN.PINTextBox1.Text += "9"

    End Sub

    Private Sub key0_Click(sender As Object, e As EventArgs) Handles key0.Click
        PIN.PINTextBox1.Text += "0"

    End Sub

    Private Sub clearkey_Click(sender As Object, e As EventArgs) Handles clearkey.Click
        PIN.PINTextBox1.Clear()
        Transfer.WdTextBox1.Clear()
        Transfer.WdTextBox2.Clear()
        Withdraw.WdTextBox1.Clear()
        ChangePIN.CPTextBox1.Clear()
        ChangePIN.CPTextBox2.Clear()
    End Sub

    Private Sub enterkey_Click_1(sender As Object, e As EventArgs) Handles enterkey.Click
        switchPanel(OPTIONS)
    End Sub

    Private Sub MainBtn6_Click(sender As Object, e As EventArgs) Handles MainBtn6.Click

        switchPanel(OPTIONS)



    End Sub
End Class