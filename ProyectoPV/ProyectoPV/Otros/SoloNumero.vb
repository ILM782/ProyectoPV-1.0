Module SoloNumero
    Function solonumeros(ByVal tecla As System.Windows.Forms.KeyPressEventArgs)
        Dim teclapresionada As Integer
        teclapresionada = AscW(tecla.KeyChar)
        If teclapresionada > 48 And teclapresionada <= 57 Or teclapresionada = 8 Or teclapresionada = 13 Then
            solonumeros = AscW(tecla.KeyChar)
        Else
            solonumeros = 0

        End If
    End Function
    Function Coma(ByVal tecla As System.Windows.Forms.KeyPressEventArgs)
        Dim teclapresionada2 As Integer
        teclapresionada2 = AscW(tecla.KeyChar)
        If teclapresionada2 > 48 And teclapresionada2 <= 57 Or teclapresionada2 = 8 Or teclapresionada2 = 44 Or teclapresionada2 = 46 Or teclapresionada2 = 13 Then
            Coma = AscW(tecla.KeyChar)
        Else
            Coma = 0

        End If
    End Function
End Module
