'By: TBC
'CalculationsClass
'What: properties to validate inputted Fat, Carbs and Protein, prob gonna have to modify constructors as well 
''''''''yes, one constructor to initialize the properties. 
''''''''Conversion between fats and calories, just do this directly inside the function of the class 

Public Class CalculationsClass
    '''''''''''''''''''''''''''''''''''''''''''''''DECLERATIONS'''''''''''''''''''''''''''''''''''''''''''''''
    Private FatsDecimal, CarbsDecimal, ProteinDecimal, ItemCaloriesDecimal As Decimal

    '''''''''''''''''''''''''''''''''''''''''''''''CONSTRUCTORS'''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub New(inFats As Decimal, inCarbs As Decimal, inProtein As Decimal)
        FatsProperty = inFats
        CarbsProperty = inCarbs
        ProteinProperty = inProtein

        ItemCaloriesFunction()
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''PROPERITIES''''''''''''''''''''''''''''''''''''''''''''''''
    Property FatsProperty As Decimal
        Get
            Return FatsDecimal
        End Get
        Set(value As Decimal)
            FatsDecimal = value
        End Set
    End Property

    Property CarbsProperty As Decimal
        Get
            Return CarbsDecimal
        End Get
        Set(value As Decimal)
            CarbsDecimal = value
        End Set
    End Property

    Property ProteinProperty As Decimal
        Get
            Return ProteinDecimal
        End Get
        Set(value As Decimal)
            ProteinDecimal = value
        End Set
    End Property

    '''''''''''''''''''''''''''''''''''''''''''''''METHODS''''''''''''''''''''''''''''''''''''''''''''''''''''
    Function ItemCaloriesFunction() As Decimal
        ItemCaloriesDecimal = FatsProperty * 9 + CarbsProperty * 4 + ProteinProperty * 4 'puttting return in this line doesn't work
        Return ItemCaloriesDecimal
    End Function

End Class
