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
        Me.TotalCommissionTextBox = New System.Windows.Forms.TextBox()
        Me.TotalSalesTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseSummaryButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TotalCommissionTextBox
        '
        Me.TotalCommissionTextBox.Enabled = False
        Me.TotalCommissionTextBox.Location = New System.Drawing.Point(209, 105)
        Me.TotalCommissionTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalCommissionTextBox.Name = "TotalCommissionTextBox"
        Me.TotalCommissionTextBox.Size = New System.Drawing.Size(133, 22)
        Me.TotalCommissionTextBox.TabIndex = 11
        '
        'TotalSalesTextBox
        '
        Me.TotalSalesTextBox.Enabled = False
        Me.TotalSalesTextBox.Location = New System.Drawing.Point(209, 38)
        Me.TotalSalesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
        Me.TotalSalesTextBox.Size = New System.Drawing.Size(133, 22)
        Me.TotalSalesTextBox.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Commissions:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Sales:"
        '
        'TotalPayTextBox
        '
        Me.TotalPayTextBox.Enabled = False
        Me.TotalPayTextBox.Location = New System.Drawing.Point(209, 177)
        Me.TotalPayTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalPayTextBox.Name = "TotalPayTextBox"
        Me.TotalPayTextBox.Size = New System.Drawing.Size(133, 22)
        Me.TotalPayTextBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 177)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total Pay:"
        '
        'CloseSummaryButton
        '
        Me.CloseSummaryButton.Location = New System.Drawing.Point(241, 254)
        Me.CloseSummaryButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CloseSummaryButton.Name = "CloseSummaryButton"
        Me.CloseSummaryButton.Size = New System.Drawing.Size(101, 26)
        Me.CloseSummaryButton.TabIndex = 14
        Me.CloseSummaryButton.Text = "Clo&se"
        Me.CloseSummaryButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 305)
        Me.Controls.Add(Me.CloseSummaryButton)
        Me.Controls.Add(Me.TotalPayTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalCommissionTextBox)
        Me.Controls.Add(Me.TotalSalesTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalCommissionTextBox As TextBox
    Friend WithEvents TotalSalesTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalPayTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseSummaryButton As Button
End Class
