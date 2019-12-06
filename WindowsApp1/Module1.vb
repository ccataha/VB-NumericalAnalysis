Imports System.Math
Module Module1
    Dim num As Integer
    Dim XY_arr As Double(,)
    Public xar(6) As Double
    Public yar(6) As Double
    Dim txtl As String = ""
    Public sx() As Double
    '///Решение ОДУ методом Рунге-Кутты 4 порядка
    Public Function Fdf(ByVal x As Double, ByVal y As Double, ByVal z As Double) As Double 'производная 1 для метода РК4
        Return z
    End Function
    Public Function Fdg(ByVal x As Double, ByVal y As Double, ByVal z As Double) As Double 'производная 2 для метода РК4
        Return ((-1 / x) * y) - (1 / x)
    End Function
    Public Sub RK_Calc2(ByVal _x As Double, ByVal _y As Double, ByVal _z As Double, ByVal h As Double, ByVal m As Integer, ByRef y As Double, ByRef z As Double)
        Dim k1, k2, k3, k4 As Double 'метод РК4
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
    Public Sub RK_42(ByVal x0 As Double, ByVal y0 As Double, ByVal z0 As Double, ByVal h0 As Double, ByVal b As Double, ByVal e As Double, ByRef txt As String)
        Dim y, z, y1, h As Double 'РК4 вывод в текст
        Dim n, i, m As Integer
        n = (b - x0) / h0
        Num = n + 1
        ReDim XY_arr(Num, 2)
        XY_arr(0, 0) = x0
        XY_arr(0, 1) = y0
        XY_arr(0, 2) = z0
        txt = "i" + Space(12) + "x" + Space(17) + "y" + Space(17) + "y'" + Space(17) + vbNewLine
        txt += Format(0, "00") + Space(6) + Format(x0, "0.0000") + Space(6) + Format(y0, "0.0000") + Space(6) + Format(z0, "0.0000") + vbNewLine
        For i = 1 To n
            m = 1
            h = h0
            RK_Calc2(x0, y0, z0, h, m, y, z)
            Do
                y1 = y
                h /= 2
                m *= 2
                RK_Calc2(x0, y0, z0, h, m, y, z)
            Loop Until Math.Abs(y - y1) < e
            x0 += h0
            y0 = y
            z0 = z
            XY_arr(i, 0) = x0
            XY_arr(i, 1) = y0
            XY_arr(i, 2) = z0
            txt += Format(i, "00") + Space(6) + Format(x0, "0.0000") + Space(6) + Format(y0, "0.0000") + Space(6) + Format(z0, "0.0000") + vbNewLine
        Next
    End Sub
    '///Аппроксимация методом Лагранжа
    Public Sub VvodLAG(ByRef xar() As Double, ByRef yar() As Double) 'Выбираем точки из таблицы решения ОДУ
        xar(0) = (CDbl(XY_arr(1, 0)))
        yar(0) = (CDbl(XY_arr(1, 1)))
        Dim j As Integer = 1
        For i = 6 To 36 Step 6
            xar(j) = (CDbl(XY_arr(i, 0)))
            yar(j) = (CDbl(XY_arr(i, 1)))
            j += 1
        Next
    End Sub
    Public Sub Lag2(ByRef z2 As Double, ByRef txtl As String, ByVal xar() As Double, ByVal yar() As Double) 'Вычисление L 2
        Dim xl() As Double = {xar(2), xar(3), xar(4)}
        Dim y() As Double = {yar(2), yar(3), yar(4)}
        Dim p As Double
        Dim x As Double = 2.5
        txtl = "Проведем квадратичную интеполяцию:" + vbNewLine
        For i = 0 To 2
            p = y(i)
            For j = 0 To 2
                If j <> i Then
                    p = p * (x - xl(j)) / (xl(i) - xl(j))
                End If
            Next j
            z2 = z2 + p
        Next i
        txtl &= "Значение интерполяции полиномом Лагранжа L2=" + CStr(z2) + vbNewLine
    End Sub
    Public Sub Lag3(ByRef z3 As Double, ByRef txtl As String, ByVal xar() As Double, ByVal yar() As Double) 'Вычисление L 3
        Dim xl() As Double = {xar(2), xar(3), xar(4), xar(5)}
        Dim y() As Double = {yar(2), yar(3), yar(4), yar(5)}
        Dim p As Double
        Dim x As Double = 2.5
        txtl &= "Проведем кубическую интерполяцию:" + vbNewLine
        For i = 0 To 3
            p = y(i)
            For j = 0 To 3
                If j <> i Then
                    p = p * (x - xl(j)) / (xl(i) - xl(j))
                End If
            Next j
            z3 = z3 + p
        Next i
        txtl &= "Значение интерполяции полиномом Лагранжа L3=" + CStr(z3) + vbNewLine
    End Sub
    Public Sub Pog(ByVal a As Double, ByVal b As Double, ByRef r As Double, ByRef txtl As String)
        r = Abs(a - b)
        txtl &= "Вычислим погрешность R=" + CStr(r) + vbNewLine
        If r < 0.01 Then
            txtl &= "Полином данной степени удовлетворяет заданной точности E=0.01" + vbNewLine
        End If
    End Sub
    Public Function ByGaussMethod(ByVal a(,) As Double, ByVal b() As Double) As Double() 'поиск коэффициентов 
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
    Public Sub GetCf(ByRef txtc As String) 'получение полинома в явном виде
        Dim aa(,) As Double = {{1, xar(2), Pow(xar(2), 2), Pow(xar(2), 3)}, {1, xar(3), Pow(xar(3), 2), Pow(xar(3), 3)}, {1, xar(4), Pow(xar(4), 2), Pow(xar(4), 3)}, {1, xar(5), Pow(xar(5), 2), Pow(xar(5), 3)}}
        Dim bb() As Double = {yar(2), yar(3), yar(4), yar(5)}
        Dim xx() As Double = ByGaussMethod(aa, bb)
        sx = xx.ToArray
        txtc = "f(x)=(" & CStr(sx(0)) + ")+(" + CStr(sx(1)) + "x)+(" + CStr(sx(2)) + "x^2)+(" + CStr(sx(3)) & "x^3)" + vbNewLine
    End Sub
    '///Решение уравнения f(x)=0
    Public fun As Func(Of Double, Double) = Function(x) sx(0) + sx(1) * x + sx(2) * x ^ 2 + sx(3) * x ^ 3 'апроксимирующий многочлен 3 степени
    Public fund As Func(Of Double, Double) = Function(x) sx(1) + (2 * sx(2) * x) + (3 * sx(3) * x ^ 2) 'производная многочлена
    Public Function Half(ByVal a As Double, ByVal b As Double, ByVal eps As Double) As String 'Метод половинного деления
        Dim n As Integer
        Dim p, res As Double
        Do Until Abs(b - a) < eps
            p = (a + b) / 2
            If fun(a) * fun(p) > 0 Then
                a = p
            Else
                b = p
            End If
            n += 1
        Loop
        res = (a + b) / 2
        Return "Результаты вычисления методом половинного деления" + vbNewLine + "Корень уравнения x = " + CStr(Format(res, "0.0000")) + vbNewLine + "Значение f(x) = " + CStr(Format(fun(res), "0.00000")) + vbNewLine + "Заданная точность - " + CStr(eps) + vbNewLine + "Кол-во итераций: " + CStr(n)
    End Function
    Public Function Newton(ByVal x0 As Double, ByVal eps As Double) As String 'метод Ньютона
        Dim x1 As Double, n As Integer
        Do
            x1 = x0
            x0 = x1 - fun(x1) / fund(x1)
            n += 1
        Loop Until Abs(x0 - x1) < eps
        Return "Результаты вычисления методом Ньютона" + vbNewLine + "Корень уравнения x = " + CStr(Format(x0, "0.0000")) + vbNewLine + "Значение f(x) = " + CStr(Format(fun(x0), "0.00000")) + vbNewLine + "Заданная точность - " + CStr(eps) + vbNewLine + "Количество итераций - " + CStr(n)
    End Function
End Module
