Imports System.IO
Imports System.Text
Imports System.Xml.Serialization



Public Class Main

    Private Settings As ConfigSetting
    Private SettingsXmlPath As String = "SettingsStore.xml"
    Private Const EwaConfigFile As String = "easyWinArt-Config.txt"

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load

        If File.Exists(Me.SettingsXmlPath) Then
            Dim serializer = New XmlSerializer(GetType(ConfigSetting))
            Using reader As New IO.StreamReader(Me.SettingsXmlPath)
                Settings = serializer.Deserialize(reader)
            End Using
            PrüfeAktuelleConfig()
        Else
            Me.Settings = New ConfigSetting
        End If
    End Sub

    Private Sub PrüfeAktuelleConfig()
        Dim aktuellBytes As Byte() = Encoding.Convert(Encoding.GetEncoding(1252), Encoding.ASCII, Encoding.GetEncoding(1252).GetBytes(File.ReadAllText(Path.Combine(Settings.ApplicationPath, EwaConfigFile))))

        If File.Exists(Settings.ConfigPathEntwicklung) Then
            Dim entwicklungBytes As Byte() = Encoding.Convert(Encoding.GetEncoding(1252), Encoding.ASCII, Encoding.GetEncoding(1252).GetBytes(File.ReadAllText(Settings.ConfigPathEntwicklung)))
            If Encoding.ASCII.GetChars(aktuellBytes).SequenceEqual(Encoding.ASCII.GetChars(entwicklungBytes)) Then
                Me.TextBox1.Text = ConfigTyp.Entwicklung.ToString
            End If
        End If
        If File.Exists(Settings.ConfigPathLokal) Then
            Dim lokalBytes As Byte() = Encoding.Convert(Encoding.GetEncoding(1252), Encoding.ASCII, Encoding.GetEncoding(1252).GetBytes(File.ReadAllText(Settings.ConfigPathLokal)))
            If Encoding.ASCII.GetChars(aktuellBytes).SequenceEqual(Encoding.ASCII.GetChars(lokalBytes)) Then
                Me.TextBox1.Text = ConfigTyp.Lokal.ToString
            End If
        End If
        If File.Exists(Settings.ConfigPathProduktion) Then
            Dim produktionBytes As Byte() = Encoding.Convert(Encoding.GetEncoding(1252), Encoding.ASCII, Encoding.GetEncoding(1252).GetBytes(File.ReadAllText(Settings.ConfigPathProduktion)))
            If Encoding.ASCII.GetChars(aktuellBytes).SequenceEqual(Encoding.ASCII.GetChars(produktionBytes)) Then
                Me.TextBox1.Text = ConfigTyp.Produktion.ToString
            End If
        End If
    End Sub

    Private Sub ButtonEntwicklung_Click(sender As Object, e As EventArgs) Handles ButtonEntwicklung.Click
        TauscheConfig(ConfigTyp.Entwicklung)
    End Sub

    Private Sub ButtonLokal_Click(sender As Object, e As EventArgs) Handles ButtonLokal.Click
        TauscheConfig(ConfigTyp.Lokal)
    End Sub

    Private Sub ButtonProduktion_Click(sender As Object, e As EventArgs) Handles ButtonProduktion.Click
        TauscheConfig(ConfigTyp.Produktion)
    End Sub

    Private Sub TauscheConfig(Typ As ConfigTyp)
        If String.IsNullOrWhiteSpace(Settings.ApplicationPath) Then
            MsgBox("Bitte erst die Einstellungen vornehmen")
            Exit Sub
        End If
        Dim zielDatei = Path.Combine(Settings.ApplicationPath, EwaConfigFile)
        Dim quellDatei As String = ""
        Select Case Typ
            Case ConfigTyp.Entwicklung
                quellDatei = Settings.ConfigPathEntwicklung
            Case ConfigTyp.Lokal
                quellDatei = Settings.ConfigPathLokal
            Case ConfigTyp.Produktion
                quellDatei = Settings.ConfigPathProduktion
        End Select
        If String.IsNullOrWhiteSpace(quellDatei) Then
            MsgBox("Bitte erst die Einstellungen vornehmen")
            Exit Sub
        End If
        File.Copy(quellDatei, zielDatei, True)
        Me.TextBox1.Text = Typ.ToString
        MsgBox("Ok")
    End Sub

    Private Sub ButtonEinstellungen_Click(sender As Object, e As EventArgs) Handles ButtonEinstellungen.Click
        Dim settingsForm As New SettingsForm(Settings, SettingsXmlPath)
        If settingsForm.ShowDialog() = DialogResult.OK Then
            PrüfeAktuelleConfig()
        End If
    End Sub

    Private Sub ButtonBeenden_Click(sender As Object, e As EventArgs) Handles ButtonBeenden.Click
        Me.Close()
    End Sub

    Private Enum ConfigTyp
        Lokal
        Produktion
        Entwicklung
    End Enum


End Class
