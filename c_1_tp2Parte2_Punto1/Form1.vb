Public Class Form1
    '1. Ingresar números enteros y sumarlos hasta que se ingrese un número cuyo 
    'valor sea igual a -999. El número -999 no debe ser contemplado en la suma. 
    'Determinar el mayor y menor número ingresado. 
    Dim Suma, Numero, MenorNumero, MayorNumero As Integer
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Suma = 0
        MenorNumero = 999
        Do
            Numero = InputBox("ingrese numero enteros", "Ingreso", 0)
            If Numero <> (-999) Then
                Suma = Suma + Numero
                If Numero > MayorNumero Then
                    MayorNumero = Numero
                End If
                If MenorNumero > Numero Then
                    MenorNumero = Numero

                End If
            End If

            lblMayor.Text = "El mayor numero ingresado es: " & MayorNumero
            lblMenor.Text = "El menor numero ingresado es: " & MenorNumero
            lblSuma.Text = "La suma de los numeros ingresados es: " & Suma




        Loop Until Numero = (-999)
    End Sub
End Class
