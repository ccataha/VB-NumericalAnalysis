Option Strict On
Option Explicit On
'/// Аппроксимация многочленом Лагранжа
Public Class Form4
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = ""
        TextBox4.Clear()
    End Sub
    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim z3, z2, r As Double
        Dim txtl, txtc As String
        vvodLAG(xar, yar) 'выбор точек из таблиы решения ОДУ
        Lag2(z2, txtl, xar, yar) 'интерполяция полиномом L2
        TextBox4.Text = txtl
        Lag3(z3, txtl, xar, yar) 'интерполяция полиномом L2
        TextBox4.Text = txtl
        Pog(z3, z2, r, txtl)
        TextBox4.Text = txtl
        GetCf(txtc) 'получение полинома в явном виде
        Label5.Text = txtc
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
