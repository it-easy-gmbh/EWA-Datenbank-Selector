Imports System.IO
Imports System.Xml.Serialization

Public Class SettingsForm

    Private Settings As ConfigSetting
    Private SettingsXmlPath As String


    Public Sub New(Settings As ConfigSetting, SettingsXmlPath As String)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.Settings = Settings
        Me.SettingsXmlPath = SettingsXmlPath
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBoxApplication.Text = Settings.ApplicationPath
        Me.TextBoxLokal.Text = Settings.ConfigPathLokal
        Me.TextBoxEntwicklung.Text = Settings.ConfigPathEntwicklung
        Me.TextBoxProduktion.Text = Settings.ConfigPathProduktion
    End Sub

    Private Sub ButtonApplication_Click(sender As Object, e As EventArgs) Handles ButtonApplication.Click
        Dim odd As New FolderBrowserDialog
        If odd.ShowDialog = DialogResult.OK Then
            Me.TextBoxApplication.Text = odd.SelectedPath
        End If
    End Sub

    Private Sub ButtonLokal_Click(sender As Object, e As EventArgs) Handles ButtonLokal.Click
        BrowseFile(Me.TextBoxLokal)
    End Sub

    Private Sub ButtonEntwicklung_Click(sender As Object, e As EventArgs) Handles ButtonEntwicklung.Click
        BrowseFile(Me.TextBoxEntwicklung)
    End Sub

    Private Sub ButtonProduktion_Click(sender As Object, e As EventArgs) Handles ButtonProduktion.Click
        BrowseFile(Me.TextBoxProduktion)
    End Sub

    Private Sub BrowseFile(ZielTextbox As TextBox)
        Dim ofd As New OpenFileDialog With {.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"}
        If Directory.Exists(Me.TextBoxApplication.Text) Then
            ofd.InitialDirectory = Me.TextBoxApplication.Text
        End If
        If ofd.ShowDialog = DialogResult.OK Then
            ZielTextbox.Text = ofd.FileName
        End If
    End Sub

    Private Sub ButtonSpeichern_Click(sender As Object, e As EventArgs) Handles ButtonSpeichern.Click
        Settings.ApplicationPath = Me.TextBoxApplication.Text
        Settings.ConfigPathLokal = Me.TextBoxLokal.Text
        Settings.ConfigPathEntwicklung = Me.TextBoxEntwicklung.Text
        Settings.ConfigPathProduktion = Me.TextBoxProduktion.Text
        Dim serializer As New XmlSerializer(GetType(ConfigSetting))
        Using writer As New StreamWriter(Me.SettingsXmlPath)
            serializer.Serialize(writer, Settings)
        End Using
        Me.DialogResult = DialogResult.OK
    End Sub


End Class