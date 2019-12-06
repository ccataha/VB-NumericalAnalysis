Option Strict On
Option Explicit On
'/// Решение уравнения f(x)=0
Public Class Form5
    Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = CStr(1) 'a
        TextBox2.Text = CStr(5) 'b
        TextBox3.Text = CStr(0.001) 'e
        Label7.Text = ""
        TextBox4.Text = CStr(2) 'x0
        TextBox5.Text = CStr(0.001) 'e
        Label9.Text = ""
    End Sub
    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'событийная: метод половинного деления
        Dim a, b, ee As Double
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        ee = CDbl(TextBox3.Text)
        Label7.Text = CStr(Half(a, b, ee))
    End Sub
    Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'событийная: метод Ньютона
        Dim x0, ee As Double
        x0 = CDbl(TextBox4.Text)
        ee = CDbl(TextBox5.Text)
        Label9.Text = CStr(Newton(x0, ee))
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class

