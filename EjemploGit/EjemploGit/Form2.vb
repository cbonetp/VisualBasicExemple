Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        For x = 0 To 100
            MsgBox("Hola" + x)

        Next
    End Sub
End Class