<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.Saying1Button = New System.Windows.Forms.Button()
        Me.Saying2Button = New System.Windows.Forms.Button()
        Me.Saying3Button = New System.Windows.Forms.Button()
        Me.Saying4Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ProgrammedByLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(12, 63)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(490, 61)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Saying1Button
        '
        Me.Saying1Button.Location = New System.Drawing.Point(53, 138)
        Me.Saying1Button.Name = "Saying1Button"
        Me.Saying1Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying1Button.TabIndex = 1
        Me.Saying1Button.Text = "Saying#1"
        Me.Saying1Button.UseVisualStyleBackColor = True
        '
        'Saying2Button
        '
        Me.Saying2Button.Location = New System.Drawing.Point(166, 138)
        Me.Saying2Button.Name = "Saying2Button"
        Me.Saying2Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying2Button.TabIndex = 2
        Me.Saying2Button.Text = "Saying#2"
        Me.Saying2Button.UseVisualStyleBackColor = True
        '
        'Saying3Button
        '
        Me.Saying3Button.Location = New System.Drawing.Point(279, 138)
        Me.Saying3Button.Name = "Saying3Button"
        Me.Saying3Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying3Button.TabIndex = 3
        Me.Saying3Button.Text = "Saying#3"
        Me.Saying3Button.UseVisualStyleBackColor = True
        '
        'Saying4Button
        '
        Me.Saying4Button.Location = New System.Drawing.Point(392, 138)
        Me.Saying4Button.Name = "Saying4Button"
        Me.Saying4Button.Size = New System.Drawing.Size(75, 23)
        Me.Saying4Button.TabIndex = 4
        Me.Saying4Button.Text = "Saying#4"
        Me.Saying4Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(220, 211)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ProgrammedByLabel
        '
        Me.ProgrammedByLabel.Location = New System.Drawing.Point(53, 279)
        Me.ProgrammedByLabel.Name = "ProgrammedByLabel"
        Me.ProgrammedByLabel.Size = New System.Drawing.Size(188, 23)
        Me.ProgrammedByLabel.TabIndex = 6
        Me.ProgrammedByLabel.Text = "Programmed By: Tek Chhetri"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 336)
        Me.Controls.Add(Me.ProgrammedByLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Saying4Button)
        Me.Controls.Add(Me.Saying3Button)
        Me.Controls.Add(Me.Saying2Button)
        Me.Controls.Add(Me.Saying1Button)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSIS 3726 - Lab#1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MessageLabel As Label
    Friend WithEvents Saying1Button As Button
    Friend WithEvents Saying2Button As Button
    Friend WithEvents Saying3Button As Button
    Friend WithEvents Saying4Button As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ProgrammedByLabel As Label
End Class
