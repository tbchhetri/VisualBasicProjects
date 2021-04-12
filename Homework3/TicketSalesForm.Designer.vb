<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketSalesForm
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
        Me.HeadingRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.SeatListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumberOfTicketsTextBox = New System.Windows.Forms.TextBox()
        Me.SectionLabel = New System.Windows.Forms.Label()
        Me.PurchaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.SaleDisplayRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalSoldRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TicketsSaleRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InputGroupBox.SuspendLayout()
        Me.PurchaseGroupBox.SuspendLayout()
        Me.SummaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeadingRichTextBox
        '
        Me.HeadingRichTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadingRichTextBox.Location = New System.Drawing.Point(284, 35)
        Me.HeadingRichTextBox.Multiline = False
        Me.HeadingRichTextBox.Name = "HeadingRichTextBox"
        Me.HeadingRichTextBox.ReadOnly = True
        Me.HeadingRichTextBox.Size = New System.Drawing.Size(248, 41)
        Me.HeadingRichTextBox.TabIndex = 1
        Me.HeadingRichTextBox.Text = "Concert Ticket Sales"
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.PurchaseButton)
        Me.InputGroupBox.Controls.Add(Me.SeatListBox)
        Me.InputGroupBox.Controls.Add(Me.Label1)
        Me.InputGroupBox.Controls.Add(Me.NumberOfTicketsTextBox)
        Me.InputGroupBox.Controls.Add(Me.SectionLabel)
        Me.InputGroupBox.Location = New System.Drawing.Point(25, 82)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(546, 173)
        Me.InputGroupBox.TabIndex = 2
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Select Section and Number of Tickets"
        '
        'PurchaseButton
        '
        Me.PurchaseButton.Location = New System.Drawing.Point(259, 113)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(100, 23)
        Me.PurchaseButton.TabIndex = 9
        Me.PurchaseButton.Text = "Purchase Tickets"
        Me.PurchaseButton.UseVisualStyleBackColor = True
        '
        'SeatListBox
        '
        Me.SeatListBox.FormattingEnabled = True
        Me.SeatListBox.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.SeatListBox.Location = New System.Drawing.Point(20, 63)
        Me.SeatListBox.Name = "SeatListBox"
        Me.SeatListBox.Size = New System.Drawing.Size(120, 95)
        Me.SeatListBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Number"
        '
        'NumberOfTicketsTextBox
        '
        Me.NumberOfTicketsTextBox.Location = New System.Drawing.Point(259, 63)
        Me.NumberOfTicketsTextBox.Name = "NumberOfTicketsTextBox"
        Me.NumberOfTicketsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberOfTicketsTextBox.TabIndex = 7
        '
        'SectionLabel
        '
        Me.SectionLabel.AutoSize = True
        Me.SectionLabel.Location = New System.Drawing.Point(34, 38)
        Me.SectionLabel.Name = "SectionLabel"
        Me.SectionLabel.Size = New System.Drawing.Size(43, 13)
        Me.SectionLabel.TabIndex = 5
        Me.SectionLabel.Text = "Section"
        '
        'PurchaseGroupBox
        '
        Me.PurchaseGroupBox.Controls.Add(Me.AmountDueTextBox)
        Me.PurchaseGroupBox.Controls.Add(Me.SaleDisplayRichTextBox)
        Me.PurchaseGroupBox.Controls.Add(Me.Label3)
        Me.PurchaseGroupBox.Location = New System.Drawing.Point(577, 82)
        Me.PurchaseGroupBox.Name = "PurchaseGroupBox"
        Me.PurchaseGroupBox.Size = New System.Drawing.Size(214, 173)
        Me.PurchaseGroupBox.TabIndex = 3
        Me.PurchaseGroupBox.TabStop = False
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountDueTextBox.ForeColor = System.Drawing.Color.Lime
        Me.AmountDueTextBox.Location = New System.Drawing.Point(83, 138)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.Size = New System.Drawing.Size(125, 22)
        Me.AmountDueTextBox.TabIndex = 9
        '
        'SaleDisplayRichTextBox
        '
        Me.SaleDisplayRichTextBox.BackColor = System.Drawing.SystemColors.Menu
        Me.SaleDisplayRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SaleDisplayRichTextBox.Location = New System.Drawing.Point(18, 19)
        Me.SaleDisplayRichTextBox.Name = "SaleDisplayRichTextBox"
        Me.SaleDisplayRichTextBox.Size = New System.Drawing.Size(190, 96)
        Me.SaleDisplayRichTextBox.TabIndex = 8
        Me.SaleDisplayRichTextBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount Due:"
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.TotalSoldRichTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TicketsSaleRichTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.Label10)
        Me.SummaryGroupBox.Controls.Add(Me.Label9)
        Me.SummaryGroupBox.Controls.Add(Me.Label8)
        Me.SummaryGroupBox.Controls.Add(Me.Label7)
        Me.SummaryGroupBox.Controls.Add(Me.Label6)
        Me.SummaryGroupBox.Controls.Add(Me.Label5)
        Me.SummaryGroupBox.Controls.Add(Me.Label4)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(25, 261)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(766, 167)
        Me.SummaryGroupBox.TabIndex = 4
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Summary"
        '
        'TotalSoldRichTextBox
        '
        Me.TotalSoldRichTextBox.BackColor = System.Drawing.SystemColors.Menu
        Me.TotalSoldRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalSoldRichTextBox.Location = New System.Drawing.Point(563, 49)
        Me.TotalSoldRichTextBox.Name = "TotalSoldRichTextBox"
        Me.TotalSoldRichTextBox.Size = New System.Drawing.Size(129, 98)
        Me.TotalSoldRichTextBox.TabIndex = 14
        Me.TotalSoldRichTextBox.Text = ""
        '
        'TicketsSaleRichTextBox
        '
        Me.TicketsSaleRichTextBox.BackColor = System.Drawing.SystemColors.Menu
        Me.TicketsSaleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TicketsSaleRichTextBox.Location = New System.Drawing.Point(259, 49)
        Me.TicketsSaleRichTextBox.Name = "TicketsSaleRichTextBox"
        Me.TicketsSaleRichTextBox.Size = New System.Drawing.Size(129, 98)
        Me.TicketsSaleRichTextBox.TabIndex = 13
        Me.TicketsSaleRichTextBox.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Section"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Section"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Section"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(586, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Sold"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "# Tickets"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Section"
        '
        'TicketSalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 440)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Controls.Add(Me.PurchaseGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.HeadingRichTextBox)
        Me.Name = "TicketSalesForm"
        Me.Text = "Ticket Sales"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.PurchaseGroupBox.ResumeLayout(False)
        Me.PurchaseGroupBox.PerformLayout()
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeadingRichTextBox As RichTextBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents SeatListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SectionLabel As Label
    Friend WithEvents PurchaseGroupBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SummaryGroupBox As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumberOfTicketsTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents AmountDueTextBox As TextBox
    Friend WithEvents SaleDisplayRichTextBox As RichTextBox
    Friend WithEvents TotalSoldRichTextBox As RichTextBox
    Friend WithEvents TicketsSaleRichTextBox As RichTextBox
End Class
