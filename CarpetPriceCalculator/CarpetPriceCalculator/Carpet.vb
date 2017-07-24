Public Class Carpet

    'member variables
    Private strColor As String
    Private strStyle As String
    Private dblPrice As Double

    'constructor
    Public Sub New()
        Debug.WriteLine("Carpet object being created")
        strColor = "(unknown)"
        strStyle = "(unknown)"
        dblPrice = 0.0

    End Sub

    'CarpetColor Property procedure
    Public Property CarpetColor() As String
        Get
            Return strColor
        End Get
        Set(ByVal value As String)
            strColor = value
        End Set
    End Property

    'CarpetStyle Property procedure
    Public Property CarpetStyle() As String
        Get
            Return strStyle
        End Get
        Set(ByVal value As String)
            strStyle = value
        End Set
    End Property

    'PricePerFoot property procedure
    Public Property pricePerFoot() As Double
        Get
            Return dblPrice
        End Get
        Set(ByVal value As Double)
            dblPrice = value
        End Set
    End Property

End Class
