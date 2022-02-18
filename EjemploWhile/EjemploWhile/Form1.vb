Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyValue As String = ""
        Do
            MyValue = InputBox("Ingrese nombre", "Saludo", "", 2)
        Loop While (MyValue = "")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index As Integer = 0
        Dim resultado As String = ""
        While (index <= 25)
            If Not (index Mod 2 = 0) Then
                index += 1
                Continue While
            End If
            If (index > 20) Then
                Exit While
            End If
            resultado = resultado + index.ToString + ","
            index += 1
        End While
        TextBox1.Text = resultado
    End Sub
End Class
