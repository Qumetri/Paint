Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim FlagMouseClicked As Boolean
    Dim w As Integer
    Dim r As Integer
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If FlagMouseClicked Then
            w = (w + 1) Mod 20
            Dim G As Graphics
            Dim P As Pen
            Dim clr As Color
            G = CreateGraphics()

            r = (r + 10) Mod 255
            clr = Color.FromArgb(r, 0, 0)
            P = New Pen(clr, w)
            G.DrawEllipse(P, e.X, e.Y, w, w)
            G.DrawEllipse(P, Me.Width - e.X, e.Y, w, w)
        End If
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        FlagMouseClicked = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        FlagMouseClicked = False
    End Sub



    '    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
    '        Dim G As Graphics
    '        Dim P As Pen
    '        Dim clr As Color
    '        G = CreateGraphics()
    '        For i = 1 To 100000
    '            clr = Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255)
    '            P = New Pen(clr, 1 + Rnd() * 10)
    '            G.DrawLine(P, Me.Width \ 2, Me.Height \ 2, Rnd() * Me.Width, Rnd() * Me.Height)
    '        Next
    '    End Sub
End Class
