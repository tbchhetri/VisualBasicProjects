<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditInquiry
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
        Me.accountsTextBox = New System.Windows.Forms.TextBox()
        Me.ZeroBalanceButton = New System.Windows.Forms.Button()
        Me.PositiveBalanceButton = New System.Windows.Forms.Button()
        Me.NegativeBalanceButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'accountsTextBox
        '
        Me.accountsTextBox.Location = New System.Drawing.Point(12, 27)
        Me.accountsTextBox.Multiline = True
        Me.accountsTextBox.Name = "accountsTextBox"
        Me.accountsTextBox.Size = New System.Drawing.Size(493, 92)
        Me.accountsTextBox.TabIndex = 2
        '
        'ZeroBalanceButton
        '
        Me.ZeroBalanceButton.Enabled = False
        Me.ZeroBalanceButton.Location = New System.Drawing.Point(338, 125)
        Me.ZeroBalanceButton.Name = "ZeroBalanceButton"
        Me.ZeroBalanceButton.Size = New System.Drawing.Size(110, 23)
        Me.ZeroBalanceButton.TabIndex = 6
        Me.ZeroBalanceButton.Text = "Zero Balances"
        Me.ZeroBalanceButton.UseVisualStyleBackColor = True
        '
        'PositiveBalanceButton
        '
        Me.PositiveBalanceButton.Enabled = False
        Me.PositiveBalanceButton.Location = New System.Drawing.Point(78, 125)
        Me.PositiveBalanceButton.Name = "PositiveBalanceButton"
        Me.PositiveBalanceButton.Size = New System.Drawing.Size(110, 23)
        Me.PositiveBalanceButton.TabIndex = 4
        Me.PositiveBalanceButton.Text = "Positive Balances"
        Me.PositiveBalanceButton.UseVisualStyleBackColor = True
        '
        'NegativeBalanceButton
        '
        Me.NegativeBalanceButton.Enabled = False
        Me.NegativeBalanceButton.Location = New System.Drawing.Point(194, 125)
        Me.NegativeBalanceButton.Name = "NegativeBalanceButton"
        Me.NegativeBalanceButton.Size = New System.Drawing.Size(138, 23)
        Me.NegativeBalanceButton.TabIndex = 5
        Me.NegativeBalanceButton.Text = "Negative Balances"
        Me.NegativeBalanceButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(517, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CreditInquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 158)
        Me.Controls.Add(Me.ZeroBalanceButton)
        Me.Controls.Add(Me.PositiveBalanceButton)
        Me.Controls.Add(Me.NegativeBalanceButton)
        Me.Controls.Add(Me.accountsTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CreditInquiry"
        Me.Text = "Credit Inquiry"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents accountsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZeroBalanceButton As Button
    Friend WithEvents PositiveBalanceButton As Button
    Friend WithEvents NegativeBalanceButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
