Option Strict On
Option Explicit On
'/// Решение ОДУ
Public Class Form3
    'автозаполнение полей
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = CStr(1)
        TextBox2.Text = CStr(5)
        TextBox3.Text = CStr(0.1)
        TextBox7.Text = CStr(0.001)
        TextBox4.Text = CStr(1)
        TextBox6.Text = CStr(0.5)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x0, y0, z0, ee, h, b As Double
        Dim txt As String
        'ввод исходных данных
        x0 = CDbl(TextBox1.Text)
        y0 = CDbl(TextBox4.Text)
        z0 = CDbl(TextBox6.Text)
        h = CDbl(TextBox3.Text)
        b = CDbl(TextBox2.Text)
        ee = CDbl(TextBox7.Text)
        ' решаем оду согласно заданию
        RK_42(x0, y0, z0, h, b, ee, txt)
        'вывод результатов решения оду
        TextBox5.Text = txt
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class