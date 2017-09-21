Module Module1

    Sub Main()
        Dim bil1, bil2 As Double
        Dim Pil As Integer
        Dim hit As New Hitung

        Console.WriteLine(" Operasi Hitung ")


        Console.WriteLine(" 1. Penambahan ")
        Console.WriteLine(" 2. Pengurangan ")
        Console.WriteLine(" 3. Pembagian ")
        Console.WriteLine(" 4. Pangkat ")
        Console.WriteLine(" 5. Deret ")
        Console.Write(" Pilihan : ")



        Pil = Console.ReadLine
        Console.Clear()
        Console.Write(" Masukkan angka 1 : ")
        bil1 = Console.ReadLine()

        Console.Write(" Masukan angka 2  : ")
        bil2 = Console.ReadLine()

        Console.WriteLine()


        Select Case UCase(Pil)
            Case "1"
                Console.Write(" Hasil Penambahan  : " & hit.tambah(bil1, bil2))
                Console.ReadLine()
            Case "2"
                Console.Write(" Hasil Pengurangan : " & hit.kurang(bil1, bil2))
                Console.ReadLine()
            Case "3"
                Console.Write(" Hasil Pembagian   : " & hit.bagi(bil1, bil2))
                Console.ReadLine()
            Case "4"
                Console.WriteLine(" Hasil Pangkat : " & hit.pangkat(bil1, bil2))
                Console.ReadLine()
            Case "5"
                Console.WriteLine(" Hasil Deret   : " & hit.deret(bil1, bil1))
                Console.WriteLine(" Hasil Deret   : " & hit.deret(bil2, bil2))
                Console.ReadLine()
        End Select

    End Sub

End Module
