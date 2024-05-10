Public Class MusicalIntrument
    Public instrumentName As String
    Public price As Integer
    Public Function RevisedPrice(discount As Double) As Double
        Dim rp As Double
        rp = price - (price * discount)
        Return rp
    End Function


End Class
