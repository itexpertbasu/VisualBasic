Public Class Rectangle

    'member variables
    Private dblWidth As Double
    Private dblLength As Double
    'Private dblArea As Double

    'constructors
    Public Sub New()
        Debug.WriteLine("Rectangle Object created")
        dblWidth = 0.0
        dblLength = 0.0
        ' dblArea = 0.0
    End Sub

    'Width Property procedure
    Public Property Width() As Double
        Get
            Return dblWidth
        End Get
        Set(ByVal value As Double)
            dblWidth = value
        End Set
    End Property

    'Length Property procedure
    Public Property Length() As Double
        Get
            Return dblLength
        End Get
        Set(ByVal value As Double)
            dblLength = value
        End Set
    End Property

    'Area Property procedure
    Public ReadOnly Property Area() As Double
        Get
            Dim dblArea As Double       'to hold the area

            'determine the area
            dblArea = dblWidth * dblLength

            'return the area
            Return dblArea
        End Get
    End Property

End Class
