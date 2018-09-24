Public Class Form1
    Dim vector_texto(6) As TextBox
    Dim vector_boton(3) As Button
    Dim indiceB(3) As Integer
    Dim indiceD(3) As Integer
    Dim vector(4) As Integer
    Dim respuesta(7) As String
    Dim total As Double
    Dim obj As Operaciones = New Operaciones()
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim TemporalB(3) As Button

    Public Sub New()

        InitializeComponent()
        r.Text = d
        Dim txt_numero As TextBox
        Dim btn_numero As Button
        Dim x As Integer
        'text_box
        For x = 0 To 6
            txt_numero = New TextBox
            txt_numero.Size = New System.Drawing.Size(50, 30)
            txt_numero.Multiline = True
            txt_numero.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txt_numero.MaxLength = 2
            txt_numero.TextAlign = HorizontalAlignment.Center
            txt_numero.BorderStyle = BorderStyle.FixedSingle
            txt_numero.Enabled = False
            txt_numero.Location = New Point(40 + x * (txt_numero.Width + 10), 78)
            txt_numero.BackColor = Color.White
            vector_texto(x) = txt_numero
            Controls.Add(txt_numero)
        Next
        ' button

        For x = 0 To 3
            btn_numero = New Button
            btn_numero.Size = New System.Drawing.Size(50, 30)
            btn_numero.Font = New System.Drawing.Font("PenultimateLight", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btn_numero.TextAlign = HorizontalAlignment.Center
            btn_numero.Enabled = True
            btn_numero.Location = New Point(160 + x * (btn_numero.Width + 10), 125)
            btn_numero.BackColor = Color.White
            vector_boton(x) = btn_numero
            AddHandler btn_numero.Click, AddressOf btn_numero_Click


            Controls.Add(btn_numero)

        Next
        For Each btn As Button In vector_boton
            btn.Enabled = False

        Next
        ' se deshabilitan todos los botones al inicio del juego
        Button4.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
        Button5.Enabled = False
        DeshabilitarOperadores()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Dim rmd As System.Random = New System.Random()
        Dim x As Integer
        Dim y As Integer
        For Each t As Button In vector_boton
            t.Text = ""
        Next
        Dim numero As String
        resul.Text = 0
        progreso.Text = 60
        For x = 0 To 3
            numero = rmd.Next(1, 20).ToString()

            For y = 0 To 3
                While vector_boton(y).Text = numero
                    numero = rmd.Next(1, 20).ToString
                End While
            Next
            vector_boton(x).Text = numero
        Next
        total = obj.Aleatorio(vector_boton)
        While total < 0
            total = obj.Aleatorio(vector_boton)
        End While
        txtresultado.Text = total
        ' txtresultado.Text = rmd.Next(10, 100).ToString()
        indice.Text = 0
        reloj.Start()

        For Each btn As Button In vector_boton
            btn.Enabled = True
        Next
        For Each t As TextBox In vector_texto
            t.Text = ""
        Next
        'se habilitan los botones


        btn_iniciar.Enabled = False
        conta.Text = 0
        Array.Clear(indiceB, 0, indiceB.Length)
        conta.Text = 0
        c = 0
        d = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles reloj.Tick
        progreso.Text = progreso.Text - 1



        If progreso.Text = 0 Then
            reloj.Stop()
            respuesta = obj.Resolver()
            For con = 0 To 6
                vector_texto(con).Text = respuesta(con)
            Next
            resul.Text = total
            txtcorrecta.Text = 0
            progreso.Text = 60
            btn_iniciar.Enabled = True
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button2.Enabled = False
            MsgBox("Se acabo el tiempo", MsgBoxStyle.Critical, "Finalizo Su Tiempo")
        End If
        If progreso.Text > 60 Then
            progreso.ForeColor = Color.DarkOrchid
        End If
        If progreso.Text <= 60 Then
            progreso.ForeColor = Color.Black
        End If
        If progreso.Text <= 30 Then
            progreso.ForeColor = Color.Blue
        End If
        If progreso.Text <= 10 Then
            progreso.ForeColor = Color.Red
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rmd As System.Random = New System.Random()
        Dim x As Integer
        Dim y As Integer
        indice.Text = 0
        Dim numero As String

        For Each t As Button In vector_boton
            t.Text = ""
        Next
        For x = 0 To 3
            numero = rmd.Next(1, 20).ToString()

            For y = 0 To 3
                While vector_boton(y).Text = numero
                    numero = rmd.Next(1, 20).ToString
                End While
            Next
            vector_boton(x).Text = numero
        Next

        total = obj.Aleatorio(vector_boton)
        While total < 0
            total = obj.Aleatorio(vector_boton)
        End While
        txtresultado.Text = total
        resul.Text = 0
        reloj.Start()
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True
        Button6.Enabled = True
        For Each btn As Button In vector_boton
            btn.Enabled = True
        Next
        For Each t As TextBox In vector_texto
            t.Text = ""
        Next
        If indice.Text = 0 Then
            DeshabilitarOperadores()
        End If
        Array.Clear(indiceB, 0, indiceB.Length)
        conta.Text = 0
        c = 0
    End Sub

    Private Sub btn_numero_Click(sender As Object, e As EventArgs)

        If indice.Text = 7 Then
            For Each btn As Button In vector_boton
                btn.Enabled = True
            Next
        End If

        Dim btn_temp As Button
        btn_temp = CType(sender, Button)
        vector_texto(Val(indice.Text)).Text = btn_temp.Text
        indice.Text = Val(indice.Text) + 1
        tem.Text = btn_temp.Text

        For Each btn As Button In vector_boton
            btn.Enabled = False
        Next
        If indice.Text = 7 Then
            DeshabilitarOperadores()
        Else
            Button1.Enabled = True
            Button8.Enabled = True
            Button7.Enabled = True
            Button6.Enabled = True
        End If

        Button4.Enabled = True
        Button3.Enabled = False
        Button2.Enabled = True
        Button5.Enabled = True
        borrar.Text = Val(indice.Text)
        temporal.Text = btn_temp.Text
        resul.Text = obj.operacion(Val(btn_temp.Text), borrar.Text, Val(resul.Text))
        If indice.Text = 7 Then
            If resul.Text = txtresultado.Text Then
                reloj.Stop()
                MsgBox("LLego a la respuesta")
                Button3.Enabled = True
                Button4.Enabled = False
                Button5.Enabled = False
                Button2.Enabled = False
                progreso.Text = progreso.Text + 40
                progreso.Text = progreso.Text
                txtcorrecta.Text = txtcorrecta.Text + 1

            End If
        End If
        '  b = indice.


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim btn_temp As Button

        btn_temp = CType(sender, Button)
        vector_texto(Val(indice.Text)).Text = Button1.Text


        ' bloquear vector de numero
        bloquear()


        indice.Text = Val(indice.Text) + 1
        If indice.Text = 6 Or indice.Text = 7 Then
            DeshabilitarOperadores()
        End If
        If indice.Text = 7 Then
            For Each btn As Button In vector_boton
                btn.Enabled = False
            Next
        End If
        DeshabilitarOperadores()
        borrar.Text = Val(indice.Text)
        obj.AlmacenarOperador(Button1.Text)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim btn_temp As Button
        btn_temp = CType(sender, Button)
        vector_texto(Val(indice.Text)).Text = Button8.Text

        ' bloquear vector de numero
        bloquear()


        indice.Text = Val(indice.Text) + 1
        If indice.Text = 6 Or indice.Text = 7 Then
            DeshabilitarOperadores()
        End If
        If indice.Text = 7 Then
            For Each btn As Button In vector_boton
                btn.Enabled = False
            Next
        End If
        DeshabilitarOperadores()
        borrar.Text = Val(indice.Text)
        obj.AlmacenarOperador(Button8.Text)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim btn_temp As Button
        btn_temp = CType(sender, Button)
        vector_texto(Val(indice.Text)).Text = Button7.Text

        ' bloquear vector de numero
        bloquear()


        indice.Text = Val(indice.Text) + 1
        If indice.Text = 6 Or indice.Text = 7 Then
            DeshabilitarOperadores()
        End If
        If indice.Text = 7 Then
            For Each btn As Button In vector_boton
                btn.Enabled = False
            Next
        End If
        DeshabilitarOperadores()
        borrar.Text = Val(indice.Text)
        obj.AlmacenarOperador(Button7.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim btn_temp As Button
        btn_temp = CType(sender, Button)
        vector_texto(Val(indice.Text)).Text = Button6.Text

        ' bloquear vector de numero
        bloquear()


        indice.Text = Val(indice.Text) + 1
        If indice.Text = 6 Or indice.Text = 7 Then
            DeshabilitarOperadores()
        End If
        If indice.Text = 7 Then
            For Each btn As Button In vector_boton
                btn.Enabled = False
            Next
        End If

        DeshabilitarOperadores()
        borrar.Text = Val(indice.Text)
        obj.AlmacenarOperador(Button6.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        indice.Text = 0
        For Each t As TextBox In vector_texto
            t.Text = ""
        Next
        For Each btn As Button In vector_boton
            btn.Enabled = True
        Next
        If indice.Text = 0 Then
            DeshabilitarOperadores()
        End If
        Array.Clear(indiceB, 0, indiceB.Length)
        conta.Text = 0
        c = 0
        resul.Text = 0

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As Integer

        respuesta = obj.Resolver()
        For con = 0 To 6
            vector_texto(con).Text = respuesta(con)
        Next
        resul.Text = total

        Button3.Enabled = True
        Button4.Enabled = False
        Button5.Enabled = False
        Button2.Enabled = False
        DeshabilitarOperadores()
        For a = b To vector_boton.Length - 1
            vector_boton(a).Enabled = False
        Next
        Button2.Enabled = False
        reloj.Stop()

    End Sub

    Public Sub DeshabilitarOperadores()
        Button1.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        Button6.Enabled = False
        If Val(indice.Text) > 0 Then
            Button2.Enabled = True
        ElseIf Val(indice.Text) = 0 Then
            Button2.Enabled = False
        End If

    End Sub

    Public Sub bloquear()
        Dim a As Integer
        If conta.Text <= 3 Then
            For a = 0 To vector_boton.Length - 1
                If vector_boton(a).Text = tem.Text Then
                    indiceB(c) = a
                    c = c + 1
                End If
            Next
        End If
        conta.Text = conta.Text + 1
        desN()
    End Sub

    Public Sub desbloquear()
        Dim a As Integer
        If d = 4 Then
            d = 0
        End If
        If conta.Text <= 3 Then
            For a = 0 To vector_boton.Length - 1
                If vector_boton(a).Text = tem.Text Then
                    indiceD(d) = a
                    d = d + 1
                End If
            Next
        End If
        desV()
    End Sub
    Public Sub desN()
        For a = 0 To vector_boton.Length - 1
            vector_boton(a).Enabled = True
        Next
        For a = 0 To c - 1
            vector_boton(indiceB(a)).Enabled = False
        Next
    End Sub

    Public Sub desV()
        For a = 0 To vector_boton.Length - 1
            vector_boton(a).Enabled = False
        Next
        For a = 0 To d - 1
            vector_boton(indiceD(a)).Enabled = True
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        temporal.Text = vector_texto((Val(borrar.Text)) - 1).Text

        borrar.Text = Val(borrar.Text) - 1
        vector_texto((Val(borrar.Text))).Text = ""
        indice.Text = Val(indice.Text) - 1
        If indice.Text = 0 Then

            Button2.Enabled = False
            Button5.Enabled = False

            For Each btn As Button In vector_boton
                btn.Enabled = True
            Next
        End If

        If Val(indice.Text) Mod 2 = 0 Then
            For Each btn As Button In vector_boton
                btn.Enabled = True
            Next
            DeshabilitarOperadores()


        Else
            For Each btn As Button In vector_boton
                btn.Enabled = False
            Next
            Button1.Enabled = True
            Button8.Enabled = True
            Button7.Enabled = True
            Button6.Enabled = True
            'borro cont-1 para poder guar en el arreglo
            conta.Text = conta.Text - 1
            c = c - 1

        End If
        If indice.Text > 1 Then
            obj.AlmacenarOperador(vector_texto(Val(indice.Text) - 1).Text)

        End If
        If Val(indice.Text) Mod 2 = 0 Then
            resul.Text = (obj.Borrar(borrar.Text, resul.Text, temporal.Text))
        End If
        If indice.Text > 0 Then
            tem.Text = temporal.Text
            desbloquear()
            r.Text = d
        End If



    End Sub


End Class
