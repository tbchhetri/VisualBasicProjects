<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SalesCountTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTotalTextBox = New System.Windows.Forms.TextBox()
        Me.SalesDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SalesCount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SalesTotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DiscountTotal"
        '
        'SalesCountTextBox
        '
        Me.SalesCountTextBox.Location = New System.Drawing.Point(98, 31)
        Me.SalesCountTextBox.Name = "SalesCountTextBox"
        Me.SalesCountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalesCountTextBox.TabIndex = 3
        '
        'SalesTotalTextBox
        '
        Me.SalesTotalTextBox.Location = New System.Drawing.Point(98, 74)
        Me.SalesTotalTextBox.Name = "SalesTotalTextBox"
        Me.SalesTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalesTotalTextBox.TabIndex = 4
        '
        'SalesDiscountTextBox
        '
        Me.SalesDiscountTextBox.Location = New System.Drawing.Point(98, 121)
        Me.SalesDiscountTextBox.Name = "SalesDiscountTextBox"
        Me.SalesDiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalesDiscountTextBox.TabIndex = 5
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(107, 173)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(91, 23)
        Me.Button.TabIndex = 6
        Me.Button.Text = "------> OK <------"
        Me.Button.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 206)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.SalesDiscountTextBox)
        Me.Controls.Add(Me.SalesTotalTextBox)
        Me.Controls.Add(Me.SalesCountTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SalesCountTextBox As TextBox
    Friend WithEvents SalesTotalTextBox As TextBox
    Friend WithEvents SalesDiscountTextBox As TextBox
    Friend WithEvents Button As Button
End Class
