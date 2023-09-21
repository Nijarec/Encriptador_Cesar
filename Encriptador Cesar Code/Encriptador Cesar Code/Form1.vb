Public Class Form1
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Select()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""

        Dim cad As String 'Cadena de texto
        Dim p As Integer 'posicion
        Dim mov As Integer 'Aumento o Decremento
        mov = Val(TextBox4.Text.ToString)
        For p = 1 To Len(TextBox1.Text)
            cad = Mid(TextBox1.Text, p, 1)

            cad = Asc(cad) + mov
            If cad >= 90 And cad <= 97 Then
                cad = cad - 26
            ElseIf cad >= 122 Then
                cad = cad - 26
            ElseIf cad = 35 Then
                cad = cad - 3

            End If

            TextBox2.Text = TextBox2.Text & Chr(cad) 'revelando encriptadoe
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        Dim cad As String 'Cadena de texto
        Dim p As Integer 'posicion
        Dim mov As Integer 'Aumento o Decremento
        mov = Val(TextBox4.Text.ToString)
        For p = 1 To Len(TextBox1.Text)
            cad = Mid(TextBox1.Text, p, 1)
            cad = Asc(cad) - mov
            If cad = 29 Then
                cad = cad + 3
            ElseIf cad < 65 And cad > 35 Then
                cad = cad + 26
            ElseIf cad < 97 And cad > 90 Then
            End If

            TextBox3.Text = TextBox3.Text & Chr(cad) 'revelando encriptadoe
        Next
    End Sub
End Class
