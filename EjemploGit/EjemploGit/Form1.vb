Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("hola")
        Dim x As Integer
        For x = 0 To 100
            MsgBox("Hola" + x)

        Next
    End Sub
End Class
