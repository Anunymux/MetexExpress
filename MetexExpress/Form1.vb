Imports System.IO
Imports System.Threading.Thread
Imports System.Text.RegularExpressions


Public Class Form1
    'Github Verbindung eingebaut
    'Zeit noch einbauen

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

		SerialPort1.Close()

	End Sub

	Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click

        'declare new SaveFileDialog + set it's initial properties
        Dim sfd As New SaveFileDialog With {
                .Title = "Choose file to save to",
                .FileName = "example.csv",
                .Filter = "CSV (*.csv)|*.csv",
                .FilterIndex = 0,
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}

        'show the dialog + display the results in a msgbox unless cancelled

        If sfd.ShowDialog = DialogResult.OK Then
            For Each myItem As ListViewItem In ListView1.Items
                Dim myStr As String = Regex.Replace(myItem.Text, "\s+", ";") 'ersetze whitespaces durch ";"
                myStr = Regex.Replace(myStr, "-", ";-") 'setze ; vor negative Werte
                IO.File.AppendAllText(sfd.FileName, myStr & vbNewLine)
            Next
            IO.File.AppendAllText(sfd.FileName, vbNewLine)
            Process.Start(sfd.FileName)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZufall.Click
        GenerateRandomNumbers()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click

        If txtMessDauer.Text = "" Or txtMessIntervall.Text = "" Then
            MsgBox("Bitte Werte für Messdauer und Messintervall eingeben!")
        Else
            Dim wert As String
            Dim messIntervall As Integer
            Dim messDauer As Integer

            'Messdauer
            If rbSMessDauer.Checked Then
                messDauer = Convert.ToInt32(txtMessDauer.Text) * 1000 'Sekunden
            ElseIf rbMMessdauer.Checked Then
                messDauer = Convert.ToInt32(txtMessDauer.Text) * 1000 * 60 'Minuten
            ElseIf rbHMessdauer.Checked Then
                messDauer = Convert.ToInt32(txtMessDauer.Text) * 1000 * 60 * 60 'Stunden
            End If

            'Messintervall
            If rbSMessInvervall.Checked Then
				messIntervall = Convert.ToInt32(txtMessIntervall.Text) * 1000 'Sekunden
            ElseIf rbMMessIntervall.Checked Then
				messIntervall = Convert.ToInt32(txtMessIntervall.Text) * 1000 * 60 'Minuten
            ElseIf rbHMessIntervall.Checked Then
				messIntervall = Convert.ToInt32(txtMessIntervall.Text) * 1000 * 60 * 60 'Stunden
            End If

            'Timer1.Interval = messIntervall

            'wert = SerialPort1.ReadExisting()
            'lblAnswer.Text = wert
            'ListView1.Items.Add(wert & TimeOfDay)
        End If



    End Sub

	Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toggleAnAus.CheckedChanged
		If toggleAnAus.CheckState = CheckState.Checked Then
			SerialPort1.Open()
			SerialPort1.Write("D")
			Sleep(500)
			toggleAnAus.Text = "Verbindung hergestellt"
		ElseIf toggleAnAus.CheckState = CheckState.Unchecked Then
			SerialPort1.Close()
			toggleAnAus.Text = "Verbinden"
		Else
			MsgBox("Checkstate ist unbestimmt.")
		End If
	End Sub

	Private Sub txtMessIntervall_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtMessIntervall.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            'Damit man Zahlen mit der Rücktaste wieder löschen kann
        ElseIf Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Bitte nur Zahlen eingeben!")
        End If

    End Sub

    Private Sub txtMessDauer_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtMessDauer.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            'Damit man Zahlen mit der Rücktaste wieder löschen kann
        ElseIf Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Bitte nur Zahlen eingeben!")
        End If

    End Sub

    Private Sub GenerateRandomNumbers()
        Dim rand As New Random
        ListView1.Items.Add(rand.Next(1, 50) & "," & rand.Next(1, 30) & "mV")

    End Sub

End Class

