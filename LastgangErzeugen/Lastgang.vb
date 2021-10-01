Public Class Lastgang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Jahr As Integer

        If FehlendeEingabe() Then
            MsgBox("Fehlende Eingabe!")
            Exit Sub
        End If
        Jahr = TextBoxJahr.Text
        Dim DatumArray() As Date = ErstelleDatumArray(Jahr)

        Dim LastArray(BestimmeViertelImJahr(Jahr)) As Double

        For i = 0 To LastArray.GetUpperBound(0)
            If PrüfeWochentag(DatumArray(i)) And ZeitIstInIntervall(DatumArray(i)) Then
                LastArray(i) = TextBoxLeistung.Text
            Else
                LastArray(i) = 0
            End If
            Console.WriteLine(LastArray(i))
        Next
    End Sub

    Sub GibDatumArrayAus()
        Dim Datumarray() As Date
        Datumarray = ErstelleDatumArray(TextBoxJahr.Text)

        For i = 0 To Datumarray.GetUpperBound(0)
            Console.WriteLine(Datumarray(i))
        Next
    End Sub

    Sub GibWochentagAus()
        Dim Datumarray() As Date
        Datumarray = ErstelleDatumArray(TextBoxJahr.Text)

        For i = 0 To Datumarray.GetUpperBound(0)
            If Weekday(Datumarray(i)) = 1 Then      'Sonntag
                Console.WriteLine("So")
            ElseIf Weekday(Datumarray(i)) = 7 Then  'Samstag
                Console.WriteLine("Sa")
            Else                                    'Werktag
                Console.WriteLine("Werk")
            End If
        Next
    End Sub

    Function FehlendeEingabe()
        Dim EingabeLeer As Boolean
        EingabeLeer = TextBoxJahr.Text = "" Or TextBoxZeitBis.Text = "" Or TextBoxZeitVon.Text = "" Or TextBoxLeistung.Text = ""
        If EingabeLeer Then
            Return True
        Else
            Return False
        End If
    End Function

    Function ZeitIstInIntervall(Datum As Date)
        Dim Startzeit As Integer = TextBoxZeitVon.Text
        Dim Endzeit As Integer = TextBoxZeitBis.Text
        Endzeit -= 1                                    '
        Dim Stunde As Integer = Hour(Datum)

        If Startzeit <= Stunde And Stunde <= Endzeit Then
            Return True
        Else
            Return False
        End If
    End Function

    Function PrüfeWochentag(datum As Date)
        Dim wochentag As Integer
        wochentag = Weekday(datum)

        If wochentag = 1 Then       'Sonntag
            If CheckBoxSo.Checked Then
                Return True
            Else
                Return False
            End If
        ElseIf wochentag = 7 Then   'Samstag
            If CheckBoxSa.Checked Then
                Return True
            Else
                Return False
            End If
        Else                        'Werktag
            If CheckBoxMoFr.Checked Then
                Return True
            Else
                Return False
            End If
        End If

        'Return WochentagArray
    End Function

    Function ErstelleDatumArray(Jahr)
        Dim DatumArray(BestimmeViertelImJahr(Jahr)) As Date
        DatumArray(0) = DatumArray(0).AddYears(Jahr - 1)
        For i = 1 To DatumArray.GetUpperBound(0)
            DatumArray(i) = DatumArray(i - 1).AddMinutes(15)
        Next
        Return DatumArray
    End Function

    Function BestimmeViertelImJahr(Jahr)
        If (Jahr Mod 4) = 0 Then
            Return 366 * 24 * 4 - 1
        Else
            Return 365 * 24 * 4 - 1
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GibDatumArrayAus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GibWochentagAus()
    End Sub
End Class