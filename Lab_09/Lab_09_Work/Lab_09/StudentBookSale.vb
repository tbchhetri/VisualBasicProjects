'Class Name:		StudentBookSale
'Programmer:		Tek Chhetri
'Date:				3/24/2021
'Description:		Handles student book sale information.
'Project:			Lab 9

Public Class StudentBookSale
    'the student book sale class
    'all classes have default new

    Inherits BookSale
    Const DISCOUNT_RATE_DECIMAL As Decimal = 0.15D
    'by doing so all public properties and methods are brought over
    'didn't bring over anything private and overloaded constructor

    'constructors
    Public Sub New(inTitle As String, inQuantity As Integer, inPrice As Decimal)
        'i have a constructor that matches the base class constructor
        'we have to call the base class constructor, must be the first thing to do
        'ALSO have access to PROTECTED in the base class
        MyBase.New(inTitle, inQuantity, inPrice)
        'now we can do what ever initialization we want for this child class
        DiscountTotal += DiscountAmount
    End Sub

    'properties
    Public Property DiscountAmount As Decimal
    Public Shared Property DiscountTotal As Decimal

    'methods
    Protected Overrides Sub CalculateExtendedPrice() 'OVERRIDING ALERT!!!!!
        'the scope, method type and name, the arguments
        Dim DiscountDecimal As Decimal
        'compute the discount
        DiscountAmount = Quantity * Price * DISCOUNT_RATE_DECIMAL
        ExtendedPrice = Quantity * Price - DiscountAmount

    End Sub

End Class
