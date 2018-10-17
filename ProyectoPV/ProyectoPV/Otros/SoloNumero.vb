Module SoloNumero
    Function solonumeros(ByVal tecla As System.Windows.Forms.KeyPressEventArgs)
        Dim teclapresionada As Integer
        teclapresionada = AscW(tecla.KeyChar)
        If teclapresionada >= 48 And teclapresionada <= 57 Or teclapresionada = 8 Or teclapresionada = 13 Then
            solonumeros = AscW(tecla.KeyChar)
        Else
            solonumeros = 0

        End If
    End Function
    Function Coma(ByVal tecla As System.Windows.Forms.KeyPressEventArgs)
        Dim teclapresionada2 As Integer
        teclapresionada2 = AscW(tecla.KeyChar)
        If teclapresionada2 >= 48 And teclapresionada2 <= 57 Or teclapresionada2 = 8 Or teclapresionada2 = 46 Or teclapresionada2 = 13 Then
            Coma = AscW(tecla.KeyChar)
        Else
            Coma = 0

        End If
    End Function
    Function sin_letras(ByVal tecla As System.Windows.Forms.KeyPressEventArgs)
        Dim teclapresionada2 As Integer
        teclapresionada2 = AscW(tecla.KeyChar)
        If teclapresionada2 = 0 Then
            sin_letras = AscW(tecla.KeyChar)
        Else
            sin_letras = 0
        End If
    End Function
    Function solo_letras(ByVal Tecla As System.Windows.Forms.KeyPressEventArgs) 'validacion para solo letras
        Dim tecla_presionada As Integer
        tecla_presionada = AscW(Tecla.KeyChar)
        If tecla_presionada >= 97 And tecla_presionada <= 122 Or tecla_presionada = 8 Or tecla_presionada = 13 Or tecla_presionada = 32 Or tecla_presionada = 46 Then
            solo_letras = AscW(Tecla.KeyChar)
        Else
            solo_letras = 0
        End If
    End Function
End Module
