<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class COVIDTemperatureMonitorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CurrentReadingGroupBox = New System.Windows.Forms.GroupBox()
        Me.CurrentTemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RecordButton = New System.Windows.Forms.Button()
        Me.CurrentTemperatureLabel = New System.Windows.Forms.Label()
        Me.LastReadingGroupBox = New System.Windows.Forms.GroupBox()
        Me.LastDiagnosisTextBox = New System.Windows.Forms.TextBox()
        Me.LastTemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.LastDiagnosisLabel = New System.Windows.Forms.Label()
        Me.LastTemperatureLabel = New System.Windows.Forms.Label()
        Me.AverageGroupBox = New System.Windows.Forms.GroupBox()
        Me.AverageDiagnosisTextBox = New System.Windows.Forms.TextBox()
        Me.AverageTemperatureTextBox = New System.Windows.Forms.TextBox()
        Me.AverageDiagnosisLabel = New System.Windows.Forms.Label()
        Me.AverageTemperatureLabel = New System.Windows.Forms.Label()
        Me.ReadingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReadingsListBox = New System.Windows.Forms.ListBox()
        Me.CurrentReadingGroupBox.SuspendLayout()
        Me.LastReadingGroupBox.SuspendLayout()
        Me.AverageGroupBox.SuspendLayout()
        Me.ReadingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CurrentReadingGroupBox
        '
        Me.CurrentReadingGroupBox.Controls.Add(Me.CurrentTemperatureTextBox)
        Me.CurrentReadingGroupBox.Controls.Add(Me.ClearButton)
        Me.CurrentReadingGroupBox.Controls.Add(Me.RecordButton)
        Me.CurrentReadingGroupBox.Controls.Add(Me.CurrentTemperatureLabel)
        Me.CurrentReadingGroupBox.Location = New System.Drawing.Point(16, 15)
        Me.CurrentReadingGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CurrentReadingGroupBox.Name = "CurrentReadingGroupBox"
        Me.CurrentReadingGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.CurrentReadingGroupBox.Size = New System.Drawing.Size(304, 123)
        Me.CurrentReadingGroupBox.TabIndex = 0
        Me.CurrentReadingGroupBox.TabStop = False
        Me.CurrentReadingGroupBox.Text = "Current Reading"
        '
        'CurrentTemperatureTextBox
        '
        Me.CurrentTemperatureTextBox.AcceptsReturn = True
        Me.CurrentTemperatureTextBox.AcceptsTab = True
        Me.CurrentTemperatureTextBox.Location = New System.Drawing.Point(147, 37)
        Me.CurrentTemperatureTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CurrentTemperatureTextBox.Name = "CurrentTemperatureTextBox"
        Me.CurrentTemperatureTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CurrentTemperatureTextBox.TabIndex = 0
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(156, 76)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(124, 28)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear Readings"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RecordButton
        '
        Me.RecordButton.Location = New System.Drawing.Point(8, 76)
        Me.RecordButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RecordButton.Name = "RecordButton"
        Me.RecordButton.Size = New System.Drawing.Size(140, 28)
        Me.RecordButton.TabIndex = 1
        Me.RecordButton.Text = "Record Reading"
        Me.RecordButton.UseVisualStyleBackColor = True
        '
        'CurrentTemperatureLabel
        '
        Me.CurrentTemperatureLabel.AutoSize = True
        Me.CurrentTemperatureLabel.Location = New System.Drawing.Point(21, 37)
        Me.CurrentTemperatureLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel"
        Me.CurrentTemperatureLabel.Size = New System.Drawing.Size(90, 17)
        Me.CurrentTemperatureLabel.TabIndex = 0
        Me.CurrentTemperatureLabel.Text = "Temperature"
        '
        'LastReadingGroupBox
        '
        Me.LastReadingGroupBox.Controls.Add(Me.LastDiagnosisTextBox)
        Me.LastReadingGroupBox.Controls.Add(Me.LastTemperatureTextBox)
        Me.LastReadingGroupBox.Controls.Add(Me.LastDiagnosisLabel)
        Me.LastReadingGroupBox.Controls.Add(Me.LastTemperatureLabel)
        Me.LastReadingGroupBox.Location = New System.Drawing.Point(16, 156)
        Me.LastReadingGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastReadingGroupBox.Name = "LastReadingGroupBox"
        Me.LastReadingGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.LastReadingGroupBox.Size = New System.Drawing.Size(304, 123)
        Me.LastReadingGroupBox.TabIndex = 1
        Me.LastReadingGroupBox.TabStop = False
        Me.LastReadingGroupBox.Text = "Last Reading"
        '
        'LastDiagnosisTextBox
        '
        Me.LastDiagnosisTextBox.Location = New System.Drawing.Point(147, 75)
        Me.LastDiagnosisTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastDiagnosisTextBox.Name = "LastDiagnosisTextBox"
        Me.LastDiagnosisTextBox.ReadOnly = True
        Me.LastDiagnosisTextBox.Size = New System.Drawing.Size(132, 22)
        Me.LastDiagnosisTextBox.TabIndex = 6
        '
        'LastTemperatureTextBox
        '
        Me.LastTemperatureTextBox.Location = New System.Drawing.Point(147, 31)
        Me.LastTemperatureTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastTemperatureTextBox.Name = "LastTemperatureTextBox"
        Me.LastTemperatureTextBox.ReadOnly = True
        Me.LastTemperatureTextBox.Size = New System.Drawing.Size(132, 22)
        Me.LastTemperatureTextBox.TabIndex = 5
        '
        'LastDiagnosisLabel
        '
        Me.LastDiagnosisLabel.AutoSize = True
        Me.LastDiagnosisLabel.Location = New System.Drawing.Point(21, 84)
        Me.LastDiagnosisLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastDiagnosisLabel.Name = "LastDiagnosisLabel"
        Me.LastDiagnosisLabel.Size = New System.Drawing.Size(70, 17)
        Me.LastDiagnosisLabel.TabIndex = 3
        Me.LastDiagnosisLabel.Text = "Diagnosis"
        '
        'LastTemperatureLabel
        '
        Me.LastTemperatureLabel.AutoSize = True
        Me.LastTemperatureLabel.Location = New System.Drawing.Point(21, 34)
        Me.LastTemperatureLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastTemperatureLabel.Name = "LastTemperatureLabel"
        Me.LastTemperatureLabel.Size = New System.Drawing.Size(90, 17)
        Me.LastTemperatureLabel.TabIndex = 3
        Me.LastTemperatureLabel.Text = "Temperature"
        '
        'AverageGroupBox
        '
        Me.AverageGroupBox.Controls.Add(Me.AverageDiagnosisTextBox)
        Me.AverageGroupBox.Controls.Add(Me.AverageTemperatureTextBox)
        Me.AverageGroupBox.Controls.Add(Me.AverageDiagnosisLabel)
        Me.AverageGroupBox.Controls.Add(Me.AverageTemperatureLabel)
        Me.AverageGroupBox.Location = New System.Drawing.Point(16, 304)
        Me.AverageGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AverageGroupBox.Name = "AverageGroupBox"
        Me.AverageGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.AverageGroupBox.Size = New System.Drawing.Size(304, 123)
        Me.AverageGroupBox.TabIndex = 2
        Me.AverageGroupBox.TabStop = False
        Me.AverageGroupBox.Text = "14 Day Average"
        '
        'AverageDiagnosisTextBox
        '
        Me.AverageDiagnosisTextBox.Location = New System.Drawing.Point(147, 78)
        Me.AverageDiagnosisTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AverageDiagnosisTextBox.Name = "AverageDiagnosisTextBox"
        Me.AverageDiagnosisTextBox.ReadOnly = True
        Me.AverageDiagnosisTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AverageDiagnosisTextBox.TabIndex = 6
        '
        'AverageTemperatureTextBox
        '
        Me.AverageTemperatureTextBox.Location = New System.Drawing.Point(147, 37)
        Me.AverageTemperatureTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AverageTemperatureTextBox.Name = "AverageTemperatureTextBox"
        Me.AverageTemperatureTextBox.ReadOnly = True
        Me.AverageTemperatureTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AverageTemperatureTextBox.TabIndex = 5
        '
        'AverageDiagnosisLabel
        '
        Me.AverageDiagnosisLabel.AutoSize = True
        Me.AverageDiagnosisLabel.Location = New System.Drawing.Point(21, 86)
        Me.AverageDiagnosisLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AverageDiagnosisLabel.Name = "AverageDiagnosisLabel"
        Me.AverageDiagnosisLabel.Size = New System.Drawing.Size(70, 17)
        Me.AverageDiagnosisLabel.TabIndex = 3
        Me.AverageDiagnosisLabel.Text = "Diagnosis"
        '
        'AverageTemperatureLabel
        '
        Me.AverageTemperatureLabel.AutoSize = True
        Me.AverageTemperatureLabel.Location = New System.Drawing.Point(21, 46)
        Me.AverageTemperatureLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AverageTemperatureLabel.Name = "AverageTemperatureLabel"
        Me.AverageTemperatureLabel.Size = New System.Drawing.Size(90, 17)
        Me.AverageTemperatureLabel.TabIndex = 3
        Me.AverageTemperatureLabel.Text = "Temperature"
        '
        'ReadingsGroupBox
        '
        Me.ReadingsGroupBox.Controls.Add(Me.ReadingsListBox)
        Me.ReadingsGroupBox.Location = New System.Drawing.Point(344, 22)
        Me.ReadingsGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ReadingsGroupBox.Name = "ReadingsGroupBox"
        Me.ReadingsGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.ReadingsGroupBox.Size = New System.Drawing.Size(267, 405)
        Me.ReadingsGroupBox.TabIndex = 3
        Me.ReadingsGroupBox.TabStop = False
        Me.ReadingsGroupBox.Text = "Readings"
        '
        'ReadingsListBox
        '
        Me.ReadingsListBox.FormattingEnabled = True
        Me.ReadingsListBox.ItemHeight = 16
        Me.ReadingsListBox.Location = New System.Drawing.Point(7, 32)
        Me.ReadingsListBox.Name = "ReadingsListBox"
        Me.ReadingsListBox.Size = New System.Drawing.Size(253, 356)
        Me.ReadingsListBox.TabIndex = 4
        '
        'COVIDTemperatureMonitorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 452)
        Me.Controls.Add(Me.ReadingsGroupBox)
        Me.Controls.Add(Me.AverageGroupBox)
        Me.Controls.Add(Me.LastReadingGroupBox)
        Me.Controls.Add(Me.CurrentReadingGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "COVIDTemperatureMonitorForm"
        Me.Text = "COVID Temperature Monitor"
        Me.CurrentReadingGroupBox.ResumeLayout(False)
        Me.CurrentReadingGroupBox.PerformLayout()
        Me.LastReadingGroupBox.ResumeLayout(False)
        Me.LastReadingGroupBox.PerformLayout()
        Me.AverageGroupBox.ResumeLayout(False)
        Me.AverageGroupBox.PerformLayout()
        Me.ReadingsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CurrentReadingGroupBox As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents RecordButton As Button
    Friend WithEvents CurrentTemperatureLabel As Label
    Friend WithEvents LastReadingGroupBox As GroupBox
    Friend WithEvents LastDiagnosisLabel As Label
    Friend WithEvents LastTemperatureLabel As Label
    Friend WithEvents AverageGroupBox As GroupBox
    Friend WithEvents AverageDiagnosisLabel As Label
    Friend WithEvents AverageTemperatureLabel As Label
    Friend WithEvents ReadingsGroupBox As GroupBox
    Friend WithEvents CurrentTemperatureTextBox As TextBox
    Friend WithEvents LastDiagnosisTextBox As TextBox
    Friend WithEvents LastTemperatureTextBox As TextBox
    Friend WithEvents AverageDiagnosisTextBox As TextBox
    Friend WithEvents AverageTemperatureTextBox As TextBox
    Friend WithEvents ReadingsListBox As ListBox
End Class
