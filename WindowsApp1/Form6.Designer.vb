﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(45, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 20)
        Me.Label12.TabIndex = 180
        Me.Label12.Text = "E="
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 746)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 84)
        Me.Button1.TabIndex = 179
        Me.Button1.Text = "Решить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 603)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 24)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Аппроксимирующая функция:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 20)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "x="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(349, 40)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Исходное ДУ: y''=-(1/x)*y'  y(1)=1 y'(1)=0.5 h=0.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(17, 220)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(171, 84)
        Me.b1.TabIndex = 164
        Me.b1.Text = "Решить"
        Me.b1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "y0="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 20)
        Me.Label7.TabIndex = 160
        Me.Label7.Text = "h="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 20)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "b="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(437, 20)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Тестирование процедуры аппроксимации решения ОДУ "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 20)
        Me.Label10.TabIndex = 156
        Me.Label10.Text = "Тест решения ОДУ"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(575, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(635, 40)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "Тестирование процедуры поиска корня уравнения методом половинного деления" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "На при" &
    "мере уравнения (x^3)-(4*x^2)-(7*x)+10 , где заранее известны корни x=1: 5: -2"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(589, 135)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 185
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(550, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 20)
        Me.Label14.TabIndex = 186
        Me.Label14.Text = "a ="
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(550, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 20)
        Me.Label15.TabIndex = 187
        Me.Label15.Text = "b ="
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(550, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 20)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "e ="
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(585, 195)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 20)
        Me.Label17.TabIndex = 189
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.Location = New System.Drawing.Point(583, 490)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 20)
        Me.Label18.TabIndex = 197
        Me.Label18.Text = "Label18"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.Location = New System.Drawing.Point(580, 436)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 20)
        Me.Label20.TabIndex = 195
        Me.Label20.Text = "Е ="
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.Location = New System.Drawing.Point(514, 402)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(130, 20)
        Me.Label21.TabIndex = 194
        Me.Label21.Text = "Нач. приближ. ="
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(650, 434)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 192
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.Location = New System.Drawing.Point(605, 353)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(633, 40)
        Me.Label22.TabIndex = 190
        Me.Label22.Text = "Тестирование процедуры поиска корня уравнения методом Ньютона" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "На примере уравнен" &
    "ия (x^3)-(4*x^2)-(7*x)+10 , где заранее известны корни x=1: 5: -2"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(707, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 93)
        Me.Button4.TabIndex = 198
        Me.Button4.Text = "Решить"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(770, 404)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 50)
        Me.Button3.TabIndex = 199
        Me.Button3.Text = "Решить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(589, 65)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(102, 20)
        Me.TextBox4.TabIndex = 200
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(589, 100)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 20)
        Me.TextBox5.TabIndex = 201
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(650, 404)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(102, 20)
        Me.TextBox8.TabIndex = 202
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(203, 47)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(305, 257)
        Me.TextBox6.TabIndex = 203
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.Location = New System.Drawing.Point(38, 194)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 20)
        Me.Label19.TabIndex = 204
        Me.Label19.Text = "y'0="
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(20, 354)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(488, 229)
        Me.TextBox1.TabIndex = 206
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(90, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(97, 20)
        Me.TextBox2.TabIndex = 207
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(91, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(97, 20)
        Me.TextBox3.TabIndex = 208
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(91, 112)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(97, 20)
        Me.TextBox10.TabIndex = 209
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(90, 140)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(97, 20)
        Me.TextBox11.TabIndex = 210
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(90, 164)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(97, 20)
        Me.TextBox12.TabIndex = 211
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(91, 190)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(97, 20)
        Me.TextBox13.TabIndex = 212
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 644)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Label2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1067, 767)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 84)
        Me.Button2.TabIndex = 214
        Me.Button2.Text = "Выход"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 915)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Form6"
        Me.Text = "Тестирование методов"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents b1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
