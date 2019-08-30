<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelApplication = New System.Windows.Forms.Label()
        Me.TextBoxApplication = New System.Windows.Forms.TextBox()
        Me.ButtonApplication = New System.Windows.Forms.Button()
        Me.ButtonSpeichern = New System.Windows.Forms.Button()
        Me.LabelHeadline = New System.Windows.Forms.Label()
        Me.LabelLokal = New System.Windows.Forms.Label()
        Me.TextBoxLokal = New System.Windows.Forms.TextBox()
        Me.ButtonLokal = New System.Windows.Forms.Button()
        Me.LabelEntwicklung = New System.Windows.Forms.Label()
        Me.TextBoxEntwicklung = New System.Windows.Forms.TextBox()
        Me.ButtonEntwicklung = New System.Windows.Forms.Button()
        Me.LabelProduktion = New System.Windows.Forms.Label()
        Me.TextBoxProduktion = New System.Windows.Forms.TextBox()
        Me.ButtonProduktion = New System.Windows.Forms.Button()
        Me.ButtonAbbrechen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelApplication
        '
        Me.LabelApplication.AutoSize = True
        Me.LabelApplication.Location = New System.Drawing.Point(24, 53)
        Me.LabelApplication.Name = "LabelApplication"
        Me.LabelApplication.Size = New System.Drawing.Size(119, 13)
        Me.LabelApplication.TabIndex = 0
        Me.LabelApplication.Text = "Pfad Application-Ordner"
        '
        'TextBoxApplication
        '
        Me.TextBoxApplication.Location = New System.Drawing.Point(193, 50)
        Me.TextBoxApplication.Name = "TextBoxApplication"
        Me.TextBoxApplication.ReadOnly = True
        Me.TextBoxApplication.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxApplication.TabIndex = 1
        '
        'ButtonApplication
        '
        Me.ButtonApplication.Location = New System.Drawing.Point(434, 50)
        Me.ButtonApplication.Name = "ButtonApplication"
        Me.ButtonApplication.Size = New System.Drawing.Size(31, 20)
        Me.ButtonApplication.TabIndex = 2
        Me.ButtonApplication.Text = "..."
        Me.ButtonApplication.UseVisualStyleBackColor = True
        '
        'ButtonSpeichern
        '
        Me.ButtonSpeichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSpeichern.Location = New System.Drawing.Point(389, 162)
        Me.ButtonSpeichern.Name = "ButtonSpeichern"
        Me.ButtonSpeichern.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSpeichern.TabIndex = 2
        Me.ButtonSpeichern.Text = "Speichern"
        Me.ButtonSpeichern.UseVisualStyleBackColor = True
        '
        'LabelHeadline
        '
        Me.LabelHeadline.AutoSize = True
        Me.LabelHeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeadline.ForeColor = System.Drawing.Color.Gray
        Me.LabelHeadline.Location = New System.Drawing.Point(23, 9)
        Me.LabelHeadline.Name = "LabelHeadline"
        Me.LabelHeadline.Size = New System.Drawing.Size(324, 24)
        Me.LabelHeadline.TabIndex = 3
        Me.LabelHeadline.Text = "Auswahl des easyWinArt Ziel-Servers"
        '
        'LabelLokal
        '
        Me.LabelLokal.AutoSize = True
        Me.LabelLokal.Location = New System.Drawing.Point(24, 79)
        Me.LabelLokal.Name = "LabelLokal"
        Me.LabelLokal.Size = New System.Drawing.Size(91, 13)
        Me.LabelLokal.TabIndex = 0
        Me.LabelLokal.Text = "Pfad Config Lokal"
        '
        'TextBoxLokal
        '
        Me.TextBoxLokal.Location = New System.Drawing.Point(193, 76)
        Me.TextBoxLokal.Name = "TextBoxLokal"
        Me.TextBoxLokal.ReadOnly = True
        Me.TextBoxLokal.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxLokal.TabIndex = 1
        '
        'ButtonLokal
        '
        Me.ButtonLokal.Location = New System.Drawing.Point(434, 76)
        Me.ButtonLokal.Name = "ButtonLokal"
        Me.ButtonLokal.Size = New System.Drawing.Size(31, 20)
        Me.ButtonLokal.TabIndex = 2
        Me.ButtonLokal.Text = "..."
        Me.ButtonLokal.UseVisualStyleBackColor = True
        '
        'LabelEntwicklung
        '
        Me.LabelEntwicklung.AutoSize = True
        Me.LabelEntwicklung.Location = New System.Drawing.Point(24, 105)
        Me.LabelEntwicklung.Name = "LabelEntwicklung"
        Me.LabelEntwicklung.Size = New System.Drawing.Size(123, 13)
        Me.LabelEntwicklung.TabIndex = 0
        Me.LabelEntwicklung.Text = "Pfad Config-Entwicklung"
        '
        'TextBoxEntwicklung
        '
        Me.TextBoxEntwicklung.Location = New System.Drawing.Point(193, 102)
        Me.TextBoxEntwicklung.Name = "TextBoxEntwicklung"
        Me.TextBoxEntwicklung.ReadOnly = True
        Me.TextBoxEntwicklung.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxEntwicklung.TabIndex = 1
        '
        'ButtonEntwicklung
        '
        Me.ButtonEntwicklung.Location = New System.Drawing.Point(434, 102)
        Me.ButtonEntwicklung.Name = "ButtonEntwicklung"
        Me.ButtonEntwicklung.Size = New System.Drawing.Size(31, 20)
        Me.ButtonEntwicklung.TabIndex = 2
        Me.ButtonEntwicklung.Text = "..."
        Me.ButtonEntwicklung.UseVisualStyleBackColor = True
        '
        'LabelProduktion
        '
        Me.LabelProduktion.AutoSize = True
        Me.LabelProduktion.Location = New System.Drawing.Point(24, 131)
        Me.LabelProduktion.Name = "LabelProduktion"
        Me.LabelProduktion.Size = New System.Drawing.Size(116, 13)
        Me.LabelProduktion.TabIndex = 0
        Me.LabelProduktion.Text = "Pfad Config-Produktion"
        '
        'TextBoxProduktion
        '
        Me.TextBoxProduktion.Location = New System.Drawing.Point(193, 128)
        Me.TextBoxProduktion.Name = "TextBoxProduktion"
        Me.TextBoxProduktion.ReadOnly = True
        Me.TextBoxProduktion.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxProduktion.TabIndex = 1
        '
        'ButtonProduktion
        '
        Me.ButtonProduktion.Location = New System.Drawing.Point(434, 128)
        Me.ButtonProduktion.Name = "ButtonProduktion"
        Me.ButtonProduktion.Size = New System.Drawing.Size(31, 20)
        Me.ButtonProduktion.TabIndex = 2
        Me.ButtonProduktion.Text = "..."
        Me.ButtonProduktion.UseVisualStyleBackColor = True
        '
        'ButtonAbbrechen
        '
        Me.ButtonAbbrechen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAbbrechen.Location = New System.Drawing.Point(308, 162)
        Me.ButtonAbbrechen.Name = "ButtonAbbrechen"
        Me.ButtonAbbrechen.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAbbrechen.TabIndex = 2
        Me.ButtonAbbrechen.Text = "Abbrechen"
        Me.ButtonAbbrechen.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AcceptButton = Me.ButtonSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonAbbrechen
        Me.ClientSize = New System.Drawing.Size(476, 197)
        Me.Controls.Add(Me.LabelHeadline)
        Me.Controls.Add(Me.ButtonAbbrechen)
        Me.Controls.Add(Me.ButtonSpeichern)
        Me.Controls.Add(Me.ButtonProduktion)
        Me.Controls.Add(Me.TextBoxProduktion)
        Me.Controls.Add(Me.ButtonEntwicklung)
        Me.Controls.Add(Me.TextBoxEntwicklung)
        Me.Controls.Add(Me.ButtonLokal)
        Me.Controls.Add(Me.LabelProduktion)
        Me.Controls.Add(Me.TextBoxLokal)
        Me.Controls.Add(Me.LabelEntwicklung)
        Me.Controls.Add(Me.ButtonApplication)
        Me.Controls.Add(Me.LabelLokal)
        Me.Controls.Add(Me.TextBoxApplication)
        Me.Controls.Add(Me.LabelApplication)
        Me.MaximumSize = New System.Drawing.Size(492, 236)
        Me.MinimumSize = New System.Drawing.Size(492, 236)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelApplication As Label
    Friend WithEvents TextBoxApplication As TextBox
    Friend WithEvents ButtonApplication As Button
    Friend WithEvents ButtonSpeichern As Button
    Friend WithEvents LabelHeadline As Label
    Friend WithEvents LabelLokal As Label
    Friend WithEvents TextBoxLokal As TextBox
    Friend WithEvents ButtonLokal As Button
    Friend WithEvents LabelEntwicklung As Label
    Friend WithEvents TextBoxEntwicklung As TextBox
    Friend WithEvents ButtonEntwicklung As Button
    Friend WithEvents LabelProduktion As Label
    Friend WithEvents TextBoxProduktion As TextBox
    Friend WithEvents ButtonProduktion As Button
    Friend WithEvents ButtonAbbrechen As Button
End Class
