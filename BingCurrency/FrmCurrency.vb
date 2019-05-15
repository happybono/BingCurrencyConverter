Imports System.Text.RegularExpressions

Public Class FrmCurrency
    ReadOnly currencyDataUrl As String = "https://finance.services.appex.bing.com/market.svc/CurrencyConvertorData?localCurrency="
    ReadOnly countryDataUrl As String = "https://finance.services.appex.bing.com/market.svc/CurrenciesStaticData?localizeFor=en-au"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCountries()
    End Sub

    Private parsedRates As New Dictionary(Of String, String)        ' currencyCode > rate
    Private parsedCountryData As New Dictionary(Of String, CountryData) ' countryName > CountryData

    Private Class CountryData
        '{"CountryCode":"USA",
        ' "CountryName":"United States",
        ' "CurrencyCode":"USD",
        ' "CurrencyName":"Dollar",
        ' "CurrencySymbol":"$"}

        Public countryCode As String
        Public countryName As String
        Public currencyCode As String
        Public currencyName As String
        Public currencySymbol As String

        Public Sub New(ByVal nCountryCode As String, ByVal nCountryName As String, ByVal nCurrencyCode As String, ByVal nCurrencyName As String, ByVal nCurrencySymbol As String)
            countryCode = nCountryCode
            countryName = nCountryName
            currencyCode = nCurrencyCode
            currencyName = nCurrencyName
            currencySymbol = nCurrencySymbol
        End Sub

        Public Overrides Function ToString() As String
            Return countryName
        End Function
    End Class

    Private Sub LoadCountries()
        Dim jsonString As String
        If Not My.Computer.FileSystem.FileExists($"{CurDir()}\jsonCountries.txt") Then
            Dim webClient As New Net.WebClient
            webClient.Encoding = System.Text.Encoding.UTF8
            jsonString = webClient.DownloadString(countryDataUrl)
            My.Computer.FileSystem.WriteAllText($"{CurDir()}\jsonCountries.txt", jsonString, False)
        Else
            jsonString = My.Computer.FileSystem.ReadAllText($"{CurDir()}\jsonCountries.txt")
        End If


        Dim jsonMatches As MatchCollection
        jsonMatches = Regex.Matches(jsonString, "(?<=:\u0022).+?(?=\u0022)")
        For i As Integer = 0 To jsonMatches.Count - 1 Step 5
            parsedCountryData(jsonMatches.Item(i + 1).Value) = New CountryData(jsonMatches.Item(i).Value, jsonMatches.Item(i + 1).Value, jsonMatches.Item(i + 2).Value, jsonMatches.Item(i + 3).Value, jsonMatches.Item(i + 4).Value)
        Next

        cbxA.Items.AddRange(parsedCountryData.Keys.ToArray)
        cbxB.Items.AddRange(parsedCountryData.Keys.ToArray)
    End Sub

    Private Sub LoadRates(ByVal currencyCode As String)
        Dim jsonString As String
        Dim fileInfo As New IO.FileInfo($"{CurDir()}\json{currencyCode}.txt")

        If DateDiff(DateInterval.Hour, fileInfo.LastWriteTime, Now) > 1 Then
            Dim webClient As New Net.WebClient
            jsonString = webClient.DownloadString(currencyDataUrl & currencyCode)
            My.Computer.FileSystem.WriteAllText($"{CurDir()}\json{currencyCode}.txt", jsonString, False)
        Else
            jsonString = My.Computer.FileSystem.ReadAllText($"{CurDir()}\json{currencyCode}.txt")
        End If

        parsedRates.Clear()

        Dim jsonMatches As MatchCollection
        jsonMatches = Regex.Matches(jsonString, "([A-Z]{3}|(?<=Rt\u0022:)[\d.]+)")
        For i As Integer = 0 To jsonMatches.Count - 1 Step 2
            parsedRates.Add(jsonMatches.Item(i).Value, jsonMatches.Item(i + 1).Value)
        Next
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        ConvertCurrency()
    End Sub

    Private Sub ConvertCurrency()
        If Not txtA.Text = String.Empty And cbxB.SelectedIndex >= 0 Then
            Dim valA As Double = Convert.ToDouble(txtA.Text)
            Dim valB As Double = Convert.ToDouble(parsedRates(parsedCountryData(cbxB.Text).currencyCode))

            txtB.Text = (valA * valB).ToString("F2")
        End If
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        Dim fromIndex As Integer
        Dim fromValue As String

        fromIndex = cbxA.SelectedIndex
        cbxA.SelectedIndex = cbxB.SelectedIndex
        cbxB.SelectedIndex = fromIndex

        fromValue = txtA.Text
        txtA.Text = txtB.Text
        txtB.Text = fromValue
    End Sub

    Private Sub cbxA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxA.SelectedIndexChanged
        lblA.Text = parsedCountryData(cbxA.Text).currencySymbol
        LoadRates(parsedCountryData(cbxA.Text).currencyCode)
        UpadateRateLabel()
    End Sub

    Private Sub cbxB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxB.SelectedIndexChanged
        lblB.Text = parsedCountryData(cbxB.Text).currencySymbol
        UpadateRateLabel()
        If cbxA.SelectedIndex >= 0 Then
            ConvertCurrency()
        End If
    End Sub

    Private Sub UpadateRateLabel()
        'ABC 1 = DEF 2
        If cbxA.SelectedIndex >= 0 And cbxB.SelectedIndex >= 0 Then
            lblCurrentRate.Text = $"{parsedCountryData(cbxA.Text).currencyCode} 1 = {parsedCountryData(cbxB.Text).currencyCode} {parsedRates(parsedCountryData(cbxB.Text).currencyCode)}"
        End If
    End Sub
End Class
