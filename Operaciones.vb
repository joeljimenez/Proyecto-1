Public Class Operaciones
    Dim operador As Char
    Dim indice As Integer
    Dim cadena As String
    Dim resultado As String
    Dim vector(3) As Integer
    Dim respuesta(6) As String
    Public Function operacion(ByVal numero As Integer, ByVal indi As Integer, ByVal resultado As Integer)

        indice = indi
        If indice = 1 Then

            resultado = resultado + numero
        ElseIf indice > 1 Then
            If operador = "+" Then
                resultado = resultado + numero
            ElseIf operador = "-" Then
                resultado = resultado - numero
            ElseIf operador = "*" Then
                resultado = resultado * numero
            ElseIf operador = "/" Then
                If numero = 0 Then
                    MsgBox("No se puede Dividir entre 0 ")
                Else
                    resultado = resultado / numero
                End If


            End If
        End If


        Return resultado
    End Function
    Public Sub AlmacenarOperador(ByVal Signo As Char)
        operador = Signo
    End Sub

    Public Function Borrar(ByVal indi As Integer, ByVal resultado As Double, ByVal numero As Integer)
        indice = indi
        If indice Mod 2 = 0 Then
            If indice = 0 Then
                resultado = 0
            Else

                If operador = "+" Then

                    resultado = resultado - numero

                ElseIf operador = "-" Then

                    resultado = resultado + numero

                ElseIf operador = "*" Then

                    resultado = resultado / numero

                ElseIf operador = "/" Then
                    resultado = resultado * numero
                End If
            End If

        End If
        Return resultado
    End Function

    Public Function Aleatorio(ByVal num1() As Button)
        Dim resultado As Integer
        Dim rdm As Random = New Random()
        Dim a As Integer
        Dim numero As Integer
        Dim conta As Integer
        'Dim contador As Integer


        For a = 0 To num1.Length - 1
            vector(a) = Val(num1(a).Text)
        Next
        cadena = vector(0).ToString
        resultado = vector(0)
        For b = 0 To 2
            numero = rdm.Next(1, 4)
            If numero = 1 Then
                If resultado = vector(0) Then
                    respuesta(conta) = resultado.ToString
                End If

                resultado = resultado + vector(b + 1)
                cadena = cadena + "+" + vector(b + 1).ToString

                conta = conta + 1
                respuesta(conta) = "+"
                conta = conta + 1
                respuesta(conta) = vector(b + 1).ToString


            ElseIf numero = 2 Then
                If resultado = vector(0) Then
                    respuesta(conta) = resultado.ToString
                End If
                resultado = resultado - vector(b + 1)
                cadena = cadena + "-" + vector(b + 1).ToString

                conta = conta + 1
                respuesta(conta) = "-"
                conta = conta + 1
                respuesta(conta) = vector(b + 1).ToString


            ElseIf numero = 3 Then
                If resultado = vector(0) Then
                    respuesta(conta) = resultado.ToString
                End If
                resultado = resultado * vector(b + 1)
                cadena = cadena + "*" + vector(b + 1).ToString

                conta = conta + 1
                respuesta(conta) = "*"
                conta = conta + 1
                respuesta(conta) = vector(b + 1).ToString


            ElseIf numero = 4 Then
                If resultado = vector(0) Then
                    respuesta(conta) = resultado.ToString
                End If
                resultado = resultado / vector(b + 1)
                cadena = cadena + "/" + vector(b + 1).ToString
                conta = conta + 1
                respuesta(conta) = "/"

                conta = conta + 1
                respuesta(conta) = vector(b + 1).ToString


            End If



        Next

        Return resultado
    End Function

    Public Function Resolver()
        Return respuesta
    End Function


End Class
