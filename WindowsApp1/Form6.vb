Imports System.Math
Public Class Form6
    Dim Num1 As Integer
    Dim XY_arr1 As Double(,)
    Dim xar1(6) As Double
    Dim yar1(6) As Double
    Dim txtl1 As String = ""
    Dim sx1() As Double
    '///Загрузка данных в поля
    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '/// Загрузка данных
        TextBox2.Text = "1" 'x
        TextBox3.Text = "5" 'b
        TextBox10.Text = "0,1" 'h
        TextBox11.Text = "0,001" 'e
        TextBox12.Text = "1" '1 произв
        TextBox13.Text = "0.5" '2 произв
        Label17.Text = ""
        Label18.Text = ""
        Label2.Text = ""
        Label4.Text = ""
        TextBox1.Text = ""
        TextBox9.Text = "0,0001" 'точность для метода половинного деления
        TextBox7.Text = "0,0001" 'точность для метода Ньютона
    End Sub
    '/// Решение ОДУ методом Рунге-Кутты 4 порядка
    Private Sub RK_41(ByVal x0 As Double, ByVal y0 As Double, ByVal z0 As Double, ByVal h0 As Double, ByVal b As Double, ByVal e As Double, ByRef txt As String)
        Dim y, z, y1, h As Double 'РК4 ОДУ вывод в текст
        Dim n, i, m As Integer
        n = (b - x0) / h0
        Num1 = n + 1
        ReDim XY_arr1(Num1, 2)
        XY_arr1(0, 0) = x0
        XY_arr1(0, 1) = y0
        XY_arr1(0, 2) = z0
        txt = "i" + Space(12) + "x" + Space(17) + "y" + Space(17) + "y'" + Space(17) + vbNewLine
        txt += Format(0, "00") + Space(6) + Format(x0, "0.0000") + Space(6) + Format(y0, "0.0000") + Space(6) + Format(z0, "0.0000") + vbNewLine
        For i = 1 To n
            m = 1
            h = h0
            RK_Calc1(x0, y0, z0, h, m, y, z)
            Do
                y1 = y
                h /= 2
                m *= 2
                RK_Calc1(x0, y0, z0, h, m, y, z)
            Loop Until Math.Abs(y - y1) < e
            x0 += h0
            y0 = y
            z0 = z
            XY_arr1(i, 0) = x0
            XY_arr1(i, 1) = y0
            XY_arr1(i, 2) = z0
            txt += Format(i, "00") + Space(6) + Format(x0, "0.0000") + Space(6) + Format(y0, "0.0000") + Space(6) + Format(z0, "0.0000") + vbNewLine
        Next
    End Sub
    Private Sub RK_Calc1(ByVal _x As Double, ByVal _y As Double, ByVal _z As Double, ByVal h As Double, ByVal m As Integer, ByRef y As Double, ByRef z As Double)
        Dim k1, k2, k3, k4 As Double 'метод РК4 ОДУ
        Dim l1, l2, l3, l4 As Double
        y = _y
        z = _z
        Dim i As Integer
        For i = 0 To m - 1
            k1 = Fdf(_x, y, z)
            l1 = Fdg(_x, y, z)
            k2 = Fdf(_x + h / 2, y + h * k1 / 2, z + h * l1 / 2)
            l2 = Fdg(_x + h / 2, y + h * k1 / 2, z + h * l1 / 2)
            k3 = Fdf(_x + h / 2, y + h * k2 / 2, z + h * l2 / 2)
            l3 = Fdg(_x + h / 2, y + h * k2 / 2, z + h * l2 / 2)
            k4 = Fdf(_x + h, y + h * k3, z + h * l3)
            l4 = Fdg(_x + h, y + h * k3, z + h * l3)
            y += (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4)
            z += (h / 6) * (l1 + 2 * l2 + 2 * l3 + l4)
            _x += h
        Next i
    End Sub
    Private Function Fdf(ByVal x As Double, ByVal y As Double, ByVal z As Double) As Double 'производная 1 для метода РК4
        Return z
    End Function
    Private Function Fdg(ByVal x As Double, ByVal y As Double, ByVal z As Double) As Double 'производная 2 для метода РК4
        Return ((-1 / x) * y)
    End Function
    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click 'Кнопка решения ОДУ
        Dim x0, y0, z0, h, b, ee As Double
        Dim txt As String
        x0 = CDbl(TextBox2.Text)
        y0 = CDbl(TextBox12.Text)
        z0 = CDbl(TextBox13.Text)
        h = CDbl(TextBox10.Text)
        b = CDbl(TextBox3.Text)
        ee = CDbl(TextBox11.Text)
        RK_41(x0, y0, z0, h, b, ee, txt)
        TextBox6.Text = CStr(txt)
    End Sub
    '///Аппроксимация Лагранжем
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click 'Кнопка решения апроксимации
        TextBox1.Clear()
        Dim z3, z2, r As Double
        Dim txtc1 As String
        VvodLAG(xar1, yar1) 'выбор точек из таблиы решения ОДУ
        Lag2(z2, txtl1, xar1, yar1) 'интерполяция полиномом L2
        TextBox1.Text = txtl1
        Lag3(z3, txtl1, xar1, yar1) 'интерполяция полиномом L2
        TextBox1.Text = txtl1
        Pog(z3, z2, r, txtl1)
        TextBox1.Text = txtl1
        GetCf(txtc1) 'получение полинома в явном виде
        Label2.Text = txtc1
    End Sub
    Private Sub VvodLAG(ByRef xar1() As Double, ByRef yar1() As Double) 'Выбираем точки из таблицы решения ОДУ
        xar1(0) = (CDbl(XY_arr1(1, 0)))
        yar1(0) = (CDbl(XY_arr1(1, 1)))
        Dim j As Integer = 1
        For i = 6 To 36 Step 6
            xar1(j) = (CDbl(XY_arr1(i, 0)))
            yar1(j) = (CDbl(XY_arr1(i, 1)))
            j += 1
        Next
    End Sub
    Private Sub Lag2(ByRef z2 As Double, ByRef txtl As String, ByVal xar1() As Double, ByVal yar1() As Double) 'Вычисление L 2
        Dim xl() As Double = {xar1(2), xar1(3), xar1(4)}
        Dim y() As Double = {yar1(2), yar1(3), yar1(4)}
        Dim p As Double
        Dim x As Double = 2.5
        txtl1 = "Проведем квадратичную интеполяцию:" + vbNewLine
        For i = 0 To 2
            p = y(i)
            For j = 0 To 2
                If j <> i Then
                    p = p * (x - xl(j)) / (xl(i) - xl(j))
                End If
            Next j
            z2 = z2 + p
        Next i
        txtl1 &= "Значение интерполяции полиномом Лагранжа L2=" + CStr(z2) + vbNewLine
    End Sub
    Private Sub Lag3(ByRef z3 As Double, ByRef txtl As String, ByVal xar1() As Double, ByVal yar1() As Double) 'Вычисление L 3
        Dim xl() As Double = {xar1(2), xar1(3), xar1(4), xar1(5)}
        Dim y() As Double = {yar1(2), yar1(3), yar1(4), yar1(5)}
        Dim p As Double
        Dim x As Double = 2.5
        txtl1 &= "Проведем кубическую интерполяцию:" + vbNewLine
        For i = 0 To 3
            p = y(i)
            For j = 0 To 3
                If j <> i Then
                    p = p * (x - xl(j)) / (xl(i) - xl(j))
                End If
            Next j
            z3 = z3 + p
        Next i
        txtl1 &= "Значение интерполяции полиномом Лагранжа L3=" + CStr(z3) + vbNewLine
    End Sub
    Private Sub Pog(ByVal a As Double, ByVal b As Double, ByRef r As Double, ByRef txtl As String)
        r = Abs(a - b)
        txtl1 &= "Вычислим погрешность R=" + CStr(r) + vbNewLine
        If r < 0.01 Then
            txtl1 &= "Полином данной степени удовлетворяет заданной точности E=0.01" + vbNewLine
        End If
    End Sub
    Private Function ByGaussMethod(ByVal a(,) As Double, ByVal b() As Double) As Double() 'поиск коэффициентов 
        Dim n As Integer = b.Length
        Dim C(n - 1, n - 1), G(n - 1), X(n - 1), v, s As Double
        Dim n1 As Integer = n - 2, k1, m1, j As Integer
        For k = 0 To n1
            If Math.Abs(a(k, k)) <= 0 Then
                k1 = k + 1
                For m = k1 To n - 1
                    m1 = m
                    If Math.Abs(a(m, k)) > 0 Then
                        For l = 0 To n - 1
                            v = a(k, l)
                            a(k, l) = a(m, l)
                            a(m, l) = v
                        Next l
                    End If
                Next m
                v = b(k)
                b(k) = b(m1)
                b(m1) = v
            End If
            G(k) = b(k) / a(k, k)
            k1 = k + 1
            For i = k1 To n - 1
                b(i) -= a(i, k) * G(k)
                For j1 = k To n - 1
                    j = n - 1 - j1 + k
                    C(k, j) = a(k, j) / a(k, k)
                    a(i, j) -= a(i, k) * C(k, j)
                Next j1
            Next i
        Next k
        m1 = n - 1
        X(m1) = b(m1) / a(m1, m1)
        Do While m1 > 0
            m1 -= 1
            s = 0
            For l = m1 To n1
                s += C(m1, l + 1) * X(l + 1)
            Next l
            X(m1) = G(m1) - s
        Loop
        Return X
    End Function
    Private Sub GetCf(ByRef txtc1 As String) 'получение полинома в явном виде
        Dim aa(,) As Double = {{1, xar1(2), Pow(xar1(2), 2), Pow(xar1(2), 3)}, {1, xar1(3), Pow(xar1(3), 2), Pow(xar1(3), 3)}, {1, xar1(4), Pow(xar1(4), 2), Pow(xar1(4), 3)}, {1, xar1(5), Pow(xar1(5), 2), Pow(xar1(5), 3)}}
        Dim bb() As Double = {yar1(2), yar1(3), yar1(4), yar1(5)}
        Dim xx1() As Double = ByGaussMethod(aa, bb)
        sx1 = xx1.ToArray
        txtc1 = "f(x)=(" & CStr(sx1(0)) + ")+(" + CStr(sx1(1)) + "x)+(" + CStr(sx1(2)) + "x^2)+(" + CStr(sx1(3)) & "x^3)" + vbNewLine
    End Sub
    '///Тестирование метода Ньютона и Дихотомии
    Function func1(ByVal x) As Double 'функция для решения ур-я НЬЮТОН / ДИХОТОМИЯ
        func1 = (x ^ 3) - (4 * x ^ 2) - (7 * x) + 10
    End Function
    Function proizv1(ByVal x) As Double 'производная для решения ур-я
        proizv1 = (3 * x ^ 2) - (8 * x) - 7
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'метод Ньютона
        Dim x1 As Double, x2 As Double, eps As Double, f1 As Double
        eps = TextBox9.Text
        x2 = TextBox8.Text
        Do
            x1 = x2
            x2 = x1 - func1(x1) / proizv1(x1)
        Loop Until Abs(x2 - x1) < eps
        f1 = func1(x2)
        Label18.Text = "Результаты вычисления методом Ньютона" + vbNewLine + "Корень уравнения x = " + CStr(Format(x2, "0.0000")) + ". Значение f(x) = " + CStr(Format(f1, "0.00000")) + vbNewLine + "Заданная точность - " + CStr(eps)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'метод бисекции
        Dim a, b, ee, p, f2, ff As Double
        a = TextBox4.Text
        b = TextBox5.Text
        ee = TextBox7.Text
        p = (a + b) / 2
        Do Until (b - a) < ee
            p = (a + b) / 2
            ff = func1(p)
            If ff > 0 Then
                a = p
            Else
                b = p
            End If
        Loop
        f2 = func1((a + b) / 2)
        Label17.Text = "Результаты вычисления методом Дихотомии" + vbNewLine + "Корень уравнения x = " + CStr(Format(p, "0.0000")) + ". Значение f(x) = " + CStr(Format(f2, "0.00000")) + vbNewLine + "Заданная точность - " + CStr(ee)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
