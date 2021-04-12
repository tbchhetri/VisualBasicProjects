'Class Name:		BookSale
'Programmer:		Tek Chhetri
'Date:				3/24/2021
'Description:		Handle book sale information.
'Project:			Lab 9

Public Class BookSale
    Private TitleString As String
    Private QuantityInteger As Integer
    Private PriceDecimal, ExtendedPriceDecimal As Decimal

    ' Shared members.
    Private Shared SalesTotalDecimal As Decimal
    Private Shared SalesCountInteger As Integer

    Public Sub New(ByVal TitleIn As String, ByVal QuantityIn As Integer,
      ByVal PriceIn As Decimal)
        ' Assign the property Values.

        Title = TitleIn
        Quantity = QuantityIn
        Price = PriceIn
        CalculateExtendedPrice()
        AddToTotals()
    End Sub

    Property Title() As String
        Get
            Return TitleString
        End Get
        Set(ByVal Value As String)
            TitleString = value
        End Set
    End Property

    Property Quantity() As Integer
        Get
            Return QuantityInteger
        End Get
        Set(ByVal Value As Integer)
            If Value >= 0 Then
                QuantityInteger = Value
            End If
        End Set
    End Property

    Property Price() As Decimal
        Get
            Return PriceDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value >= 0 Then
                PriceDecimal = Value
            End If
        End Set
    End Property

    Property ExtendedPrice() As Decimal
        Get
            Return ExtendedPriceDecimal
        End Get
        Set(value As Decimal)
            ExtendedPriceDecimal = value
        End Set
    End Property

    Shared ReadOnly Property SalesTotal() As Decimal
        Get
            Return SalesTotalDecimal
        End Get
    End Property

    Shared ReadOnly Property SalesCount() As Integer
        Get
            Return SalesCountInteger
        End Get
    End Property

    Protected Overridable Sub CalculateExtendedPrice() 'within this class it can act like private or public, 
        ' Calculate the extended price.

        ExtendedPriceDecimal = QuantityInteger * PriceDecimal
    End Sub

    Private Sub AddToTotals()
        ' Add to summary information.

        SalesTotalDecimal += ExtendedPrice
        SalesCountInteger += 1
    End Sub

End Class
