'By:          Tek Chhetri
'Project:     Homework 4
'Date:        3/30/2021
'Discription: Calculate the commission, validate the inputs, overload the constructors
Public Class CommissionClass
    'DECLERATIONS
    Private SalesPersonString As String
    Private SalesDecimal As Decimal
    'Public CommissionDecimal As Decimal

    Private Const QUOTA_INTEGER As Integer = 400
    Private Const COMMISSION_RATE_DECIMAL As Decimal = 0.1D

    Private CommissionDecimal As Decimal ' the salesPerson's commission
    Private PayDecimal As Decimal

    Private Const BASE_SALARY_DECIMAL As Decimal = 500

    Private Shared PayAccumulatorDecimal As Decimal
    Private Shared CommissionAccumulatorDecimal As Decimal
    Private Shared SalesAccumulatorInteger As Integer

    'PROPERTIES
    'think of all properties like variable initialization
    Property NameValidations() As String
        Get
            Return SalesPersonString
        End Get
        Set(value As String)
            If value <> "" Then
                SalesPersonString = value.Trim
            Else
                Throw New ArgumentOutOfRangeException(" Don't forget to add that name: ")
            End If
        End Set
    End Property

    Property SalesValidation() As Decimal
        Get
            Return SalesDecimal
        End Get
        Set(value As Decimal)
            If value > 0 Then
                SalesDecimal = value
            Else
                Throw New ArgumentOutOfRangeException("There's no way we have that much sales!!")
            End If
        End Set
    End Property

    Public Shared ReadOnly Property Commission As Decimal
        Get
            Return Commission
        End Get
    End Property

    Public Shared ReadOnly Property Pay As Decimal
        Get
            Return Pay
        End Get
    End Property

    Shared ReadOnly Property TotalSales() As Integer
        Get
            Return SalesAccumulatorInteger 'this variable has to be privately shared as well
        End Get
    End Property

    Public Shared ReadOnly Property TotalCommission As Decimal
        Get
            Return CommissionAccumulatorDecimal
        End Get
    End Property

    Public Shared ReadOnly Property TotalPay() As Decimal
        Get
            Return PayAccumulatorDecimal
        End Get
    End Property

    ''COMMISSION CALCULATOR
    'Property PayCalculator As Decimal
    '    Get
    '        Return PayDecimal + BASE_SALARY_DECIMAL
    '    End Get
    '    Set()
    '        If SalesValidation > QUOTA_INTEGER Then
    '            CommissionDecimal = SalesValidation * COMMISSION_RATE_DECIMAL
    '        Else
    '            CommissionDecimal = 0
    '        End If

    '    End Set
    'End Property

    'METHODS
    Function FindPay(SalesValidation As Decimal) As Decimal
        PayDecimal = BASE_SALARY_DECIMAL + FindCommission(SalesValidation)
        Return PayDecimal
    End Function

    Function FindCommission(SalesDecimal As Decimal) As Decimal
        If SalesDecimal > QUOTA_INTEGER Then
            CommissionDecimal = SalesDecimal * COMMISSION_RATE_DECIMAL
        Else
            CommissionDecimal = 0
        End If
        Return CommissionDecimal
    End Function

    Private Sub AddToTotals()
        SalesAccumulatorInteger += SalesValidation
        PayAccumulatorDecimal += FindPay(SalesValidation)
        CommissionAccumulatorDecimal += FindCommission(SalesValidation)
    End Sub

    'CONSTRUCTORS
    Public Sub New(inName As String, inSales As Decimal)
        NameValidations = inName
        SalesValidation = inSales

        FindCommission(SalesValidation)
        FindPay(SalesValidation)
        AddToTotals()
    End Sub
End Class
