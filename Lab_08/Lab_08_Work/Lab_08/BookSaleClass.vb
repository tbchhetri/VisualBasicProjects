Public Class BookSaleClass
    'properties
    Private TitleString As String 'class / instance variable
    Private QuantityInteger As Integer 'no of books
    Private PriceDecimal As Decimal
    'share variables, remains in mem
    Private Shared SalesTotalDecimal As Decimal

    Shared ReadOnly Property SalesTotal As Decimal
        Get
            Return SalesTotalDecimal
        End Get
    End Property

    Public Shared ReadOnly Property SalesCount As Decimal


    'expose/grant access to the private variable via property
    Property Title As String 'all properties are public by default 
        'created another variable called _Title as string
        Get
            'accessor, retrive private variable
            'messagebox.show(TheBookSale.Title)
            Return TitleString
        End Get
        Set(value As String)
            'mutator, change the private variable
            'TheBookSale.Title = "VB.net", this gets passed in as the value
            TitleString = value.Trim
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return QuantityInteger
        End Get
        Set(value As Integer)
            If value >= 0 Then
                QuantityInteger = value
            Else
                Throw New ArgumentOutOfRangeException(" Quantity must be greater than 0! ")
            End If
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return PriceDecimal
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                PriceDecimal = value
            Else
                Throw New ArgumentOutOfRangeException(" Price must be greater than 0! ")
            End If
        End Set
    End Property

    Public ReadOnly Property ExtendedPrice As Decimal 'auto implemented prop
    'Private _ExtendedPrice As Decimal

    'methods
    'all methods are public by default
    Private Sub CalculateExtendedPrice()
        'calculate the extended price of the sale
        _ExtendedPrice = Quantity * Price '_ExtendedPrice = this is only availble for the autoimplemented
    End Sub

    Private Sub AddToTotals()
        'add to summary info
        SalesTotalDecimal = SalesTotal + ExtendedPrice
        _SalesCount += 1
    End Sub

    'constructors
    Public Sub New()
        'default constructor is there automatically
        'has no params or args
    End Sub

    'however we can overload it
    Public Sub New(inTitle As String, inQuantity As Integer, inPrice As Decimal)
        'assign properties 
        'TitleString = inTitle 'accessing the private class variable directly
        'by doin this I bypass business logic, so only use PRIVATE when you HAVE to
        'Hence use this rather
        Title = inTitle
        Quantity = inQuantity
        Price = inPrice
        CalculateExtendedPrice()
        AddToTotals()

    End Sub
End Class
