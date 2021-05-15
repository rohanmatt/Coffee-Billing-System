Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B As Double
        If RadioButton1.Checked = True Then
            RadioButton2.Visible = False
            TextBox4.Visible = False
            Label4.Visible = False
            Button3.Visible = False
        ElseIf RadioButton2.Checked = True Then
            TextBox4.Visible = True
        End If
        If CheckBox1.Checked = True Or CheckBox2.Checked = True Then
            A = Val(TextBox1.Text) * 2
            B = Val(TextBox2.Text) * 5
            TextBox3.Text = A + B
        Else
            A = Val(TextBox1.Text) * 3
            B = Val(TextBox2.Text) * 4
            TextBox3.Text = A + B
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox4.Visible = False
        Label4.Visible = False
        Button3.Visible = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Visible = False
        Label4.Visible = False
        Button3.Visible = False
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim A, B As Double
        Button3.Visible = True
        Label4.Visible = True
        TextBox4.Visible = True
        If CheckBox1.Checked = True Or CheckBox2.Checked = True Then
            A = Val(TextBox1.Text) * 2
            B = Val(TextBox2.Text) * 5
            TextBox3.Text = A + B
        Else
            A = Val(TextBox1.Text) * 3
            B = Val(TextBox2.Text) * 4
            TextBox3.Text = A + B
        End If
        MessageBox.Show("Enter your card number")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text = Nothing Then
            MessageBox.Show("Enter your card number please")
        Else
            MessageBox.Show(" Payment Recieved")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class