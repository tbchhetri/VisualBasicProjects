'By: TBC 

Imports System.Data 'so we won't have to say System.Data.DataSet everytime
Imports System.Data.OleDb '
Public Class _Default
    Inherits System.Web.UI.Page

    'maintain the sort order
    Property SortOrder As String
        Get
            Return hfSortOrder.Value
        End Get
        Set(value As String)
            hfSortOrder.Value = value
        End Set
    End Property

    'maintain the sort column
    Property SortColumn As String
        Get
            Return hfSortColumn.Value
        End Get
        Set(value As String)
            hfSortColumn.Value = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'every time the page is viewed this happens

        'If IsPostBack Then
        '    'this is second/+ time visit to the page
        'Else
        '    'initial page load
        '    'populate the grid with data
        'End If

        If Not IsPostBack Then
            'on our initial page load
            BindData(0) 'sub
        End If
    End Sub

    Sub BindData(IndexInteger As Integer)
        Dim objDataSet As System.Data.DataSet ' dataset=where we goin to place our data

        'call a method to pull the data
        objDataSet = GetData()

        'take that data in the dataset and bind it to the gridview
        BooksGridView.DataSource = objDataSet 'set
        'set the page index
        BooksGridView.PageIndex = IndexInteger 'now the page the user selected wil be displayed
        'bind the data
        BooksGridView.DataBind() 'it gets turn into into HTML
    End Sub

    Function GetData() As DataSet
        'open data set, tell what we want and return the results

        'for connecting to the database
        Dim objConnection As OleDb.OleDbConnection
        'temp dataset to store results
        Dim objDataSet As New DataSet
        'create a variable for connection string
        Dim ConnectionString As String

        Dim SqlString As String

        'define a connection string
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=|DataDirectory|\rnrbooks.mdb" '|DataDirectory|=substitutes the forward path 

        'def the sql command
        SqlString = "SELECT * FROM Books ORDER BY "
        SqlString &= SortColumn & " " & SortOrder
        Try
            'define a connection, 
            objConnection = New OleDbConnection(ConnectionString)

            'open connection, 
            objConnection.Open()

            'read our data
            ''using data adapter
            Using objDataAdapter = New OleDbDataAdapter(SqlString, objConnection) 'only be alive inside this using block
                'run that command against connection
                objDataAdapter.Fill(objDataSet)
            End Using

            'Close connection
            objConnection.Close()
        Catch ex As OleDbException
            'database connection, read, and write problems
        End Try

        Return objDataSet
    End Function

    Private Sub BooksGridView_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles BooksGridView.PageIndexChanging
        'reload our data, and display the page that was selected 
        BindData(e.NewPageIndex)
    End Sub

    Private Sub BooksGridView_Sorting(sender As Object, e As GridViewSortEventArgs) Handles BooksGridView.Sorting
        'before the sorting is done
        'set the sort column to the current column seleted
        SortColumn = e.SortExpression

        'update the sort order
        If SortOrder = "ASC" Then
            SortOrder = "DESC" 'assending and decending

        Else
            SortOrder = "ASC"
        End If

        BindData(0)
    End Sub
End Class