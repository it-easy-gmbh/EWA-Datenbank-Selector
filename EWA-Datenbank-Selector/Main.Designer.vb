<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.ButtonEntwicklung = New System.Windows.Forms.Button()
        Me.ButtonLokal = New System.Windows.Forms.Button()
        Me.ButtonProduktion = New System.Windows.Forms.Button()
        Me.LabelAktuelleConfig = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelHeadline = New System.Windows.Forms.Label()
        Me.GroupBoxWechsel = New System.Windows.Forms.GroupBox()
        Me.ButtonEinstellungen = New System.Windows.Forms.Button()
        Me.ButtonBeenden = New System.Windows.Forms.Button()
        Me.GroupBoxWechsel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonEntwicklung
        '
        Me.ButtonEntwicklung.Location = New System.Drawing.Point(6, 19)
        Me.ButtonEntwicklung.Name = "ButtonEntwicklung"
        Me.ButtonEntwicklung.Size = New System.Drawing.Size(338, 23)
        Me.ButtonEntwicklung.TabIndex = 0
        Me.ButtonEntwicklung.Text = "Entwicklung"
        Me.ButtonEntwicklung.UseVisualStyleBackColor = True
        '
        'ButtonLokal
        '
        Me.ButtonLokal.Location = New System.Drawing.Point(6, 48)
        Me.ButtonLokal.Name = "ButtonLokal"
        Me.ButtonLokal.Size = New System.Drawing.Size(338, 23)
        Me.ButtonLokal.TabIndex = 0
        Me.ButtonLokal.Text = "Lokal"
        Me.ButtonLokal.UseVisualStyleBackColor = True
        '
        'ButtonProduktion
        '
        Me.ButtonProduktion.Location = New System.Drawing.Point(6, 77)
        Me.ButtonProduktion.Name = "ButtonProduktion"
        Me.ButtonProduktion.Size = New System.Drawing.Size(338, 23)
        Me.ButtonProduktion.TabIndex = 0
        Me.ButtonProduktion.Text = "Produktion"
        Me.ButtonProduktion.UseVisualStyleBackColor = True
        '
        'LabelAktuelleConfig
        '
        Me.LabelAktuelleConfig.AutoSize = True
        Me.LabelAktuelleConfig.Location = New System.Drawing.Point(21, 57)
        Me.LabelAktuelleConfig.Name = "LabelAktuelleConfig"
        Me.LabelAktuelleConfig.Size = New System.Drawing.Size(106, 13)
        Me.LabelAktuelleConfig.TabIndex = 1
        Me.LabelAktuelleConfig.Text = "Aktuelle Config-Datei"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 2
        '
        'LabelHeadline
        '
        Me.LabelHeadline.AutoSize = True
        Me.LabelHeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeadline.ForeColor = System.Drawing.Color.Gray
        Me.LabelHeadline.Location = New System.Drawing.Point(20, 9)
        Me.LabelHeadline.Name = "LabelHeadline"
        Me.LabelHeadline.Size = New System.Drawing.Size(324, 24)
        Me.LabelHeadline.TabIndex = 1
        Me.LabelHeadline.Text = "Auswahl des easyWinArt Ziel-Servers"
        '
        'GroupBoxWechsel
        '
        Me.GroupBoxWechsel.Controls.Add(Me.ButtonEntwicklung)
        Me.GroupBoxWechsel.Controls.Add(Me.ButtonLokal)
        Me.GroupBoxWechsel.Controls.Add(Me.ButtonProduktion)
        Me.GroupBoxWechsel.Location = New System.Drawing.Point(24, 80)
        Me.GroupBoxWechsel.Name = "GroupBoxWechsel"
        Me.GroupBoxWechsel.Size = New System.Drawing.Size(350, 111)
        Me.GroupBoxWechsel.TabIndex = 3
        Me.GroupBoxWechsel.TabStop = False
        Me.GroupBoxWechsel.Text = "Wechsel zu:"
        '
        'ButtonEinstellungen
        '
        Me.ButtonEinstellungen.Location = New System.Drawing.Point(24, 210)
        Me.ButtonEinstellungen.Name = "ButtonEinstellungen"
        Me.ButtonEinstellungen.Size = New System.Drawing.Size(350, 23)
        Me.ButtonEinstellungen.TabIndex = 0
        Me.ButtonEinstellungen.Text = "Einstellungen"
        Me.ButtonEinstellungen.UseVisualStyleBackColor = True
        '
        'ButtonBeenden
        '
        Me.ButtonBeenden.Location = New System.Drawing.Point(24, 255)
        Me.ButtonBeenden.Name = "ButtonBeenden"
        Me.ButtonBeenden.Size = New System.Drawing.Size(350, 23)
        Me.ButtonBeenden.TabIndex = 0
        Me.ButtonBeenden.Text = "Schließen"
        Me.ButtonBeenden.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 294)
        Me.Controls.Add(Me.GroupBoxWechsel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonBeenden)
        Me.Controls.Add(Me.ButtonEinstellungen)
        Me.Controls.Add(Me.LabelHeadline)
        Me.Controls.Add(Me.LabelAktuelleConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(402, 333)
        Me.MinimumSize = New System.Drawing.Size(402, 333)
        Me.Name = "Main"
        Me.Text = "Config-Selector"
        Me.GroupBoxWechsel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEntwicklung As Button
    Friend WithEvents ButtonLokal As Button
    Friend WithEvents ButtonProduktion As Button
    Friend WithEvents LabelAktuelleConfig As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelHeadline As Label
    Friend WithEvents GroupBoxWechsel As GroupBox
    Friend WithEvents ButtonEinstellungen As Button
    Friend WithEvents ButtonBeenden As Button
End Class
