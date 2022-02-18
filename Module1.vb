Module Module1

    Sub Main()
        Dim i, j, n As Integer
        Dim esperar As Char

        While esperar <> "z" And esperar <> "z"

            Try

                j = 1
                Console.Clear()
                Console.Write("Ingresar un número entero positivo para calcular el factorial ")
                n = Console.ReadLine()
                For i = 1 To n Step 1
                    j = j * i

                Next
                Console.Write("El factorial del número ingresado es ")
                Console.WriteLine(j)






            Catch ex As Exception
                Console.WriteLine(ex.Message)


            End Try

            Console.Write("Presione la letra z para salir del programa")
            esperar = Console.ReadKey.KeyChar


        End While

    End Sub

End Module
