Public Class Hitung

    Function tambah(ByVal bil1 As Double, ByVal bil2 As Double) As String
        Return bil1 + bil2
    End Function

    Function kurang(ByVal bil1 As Double, ByVal bil2 As Double) As String
        Return bil1 - bil2
    End Function

    Function bagi(ByVal bil1 As Double, ByVal bil2 As Double) As String
        Return bil1 / bil2
    End Function

    Function pangkat(ByVal bil1 As Double, ByVal bil2 As Double) As String
        Return bil1 ^ bil2
    End Function

    Function deret(ByVal bil1 As Double, ByVal bil2 As Double) As String
        Dim x As Integer
        For bil1 = x To bil2
        Next
        Return 3 * (bil1 * bil1) + (1 * bil1) - 1
    End Function
End Class
