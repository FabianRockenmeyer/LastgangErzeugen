﻿Public Class Lastgang
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
            If PrüfeWochentag(DatumArray(i)) And PrüfeZeit(DatumArray(i)) Then
                LastArray(i) = TextBoxLeistung.Text
            Else
                LastArray(i) = 0
            End If
            Console.WriteLine(LastArray(i))
        Next
        Chart1.Series(0).XValueType = DataVisualization.Charting.ChartValueType.DateTime
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "ddd dd.MM.yy  HH:mm"
        Chart1.Series(0).Points.DataBindXY(DatumArray, LastArray)

    End Sub

    Function GibStandardLastgangSamstag(Lastgang As String)

        Dim SamstagslisteG0 As New List(Of Double) From {75.8, 76.7, 77.7, 78.5, 78.5, 77.8, 76.6, 74.7, 72.6, 70.4, 68.5, 67.3, 67.0, 67.5, 68.3, 69.1, 69.7, 70.1, 70.5, 71.0, 71.8, 72.5, 73.0, 72.9, 72.2, 72.2, 74.4, 80.4, 91.0, 105.2, 121.2, 137.4, 152.1, 164.9, 175.1, 182.2, 186.1, 187.5, 187.7, 187.8, 188.7, 190.1, 191.9, 193.4, 194.5, 195.1, 195.3, 195.3, 194.9, 193.9, 191.7, 187.8, 181.9, 174.1, 164.8, 154.2, 142.6, 130.9, 119.8, 110.3, 102.7, 96.9, 92.1, 87.8, 83.6, 79.7, 76.9, 75.7, 76.5, 78.6, 81.1, 83.2, 84.1, 84.3, 84.1, 84.1, 84.7, 85.8, 87.3, 88.8, 90.1, 91.2, 91.7, 91.6, 90.6, 89.0, 87.1, 85.0, 83.1, 81.2, 79.4, 77.6, 75.7, 73.8, 71.9, 70.1}
        Dim SamstagslisteG1 As New List(Of Double) From {20.7, 20.8, 20.9, 20.8, 20.5, 20.0, 19.4, 18.9, 18.6, 18.5, 18.6, 18.9, 19.5, 20.2, 20.7, 20.8, 20.4, 19.6, 19.0, 18.9, 19.6, 20.7, 21.9, 22.7, 22.9, 22.7, 22.5, 22.7, 23.8, 25.9, 29.3, 34.1, 40.3, 47.2, 53.6, 58.7, 61.6, 62.7, 62.8, 62.5, 62.2, 62.2, 62.3, 62.5, 62.6, 62.6, 62.0, 60.6, 58.2, 55.0, 51.3, 47.3, 43.4, 39.8, 36.6, 34.1, 32.4, 31.3, 30.7, 30.3, 29.8, 29.4, 28.9, 28.4, 27.9, 27.5, 27.0, 26.5, 26.0, 25.4, 24.9, 24.6, 24.4, 24.4, 24.5, 24.6, 24.7, 24.8, 24.7, 24.6, 24.3, 24.1, 24.1, 24.6, 25.6, 26.8, 27.9, 28.4, 28.0, 27.0, 25.8, 24.6, 23.8, 23.3, 23.0, 22.7}
        Dim SamstagslisteG2 As New List(Of Double) From {73.1, 67.6, 62.8, 57.7, 51.6, 45.0, 38.9, 34.2, 31.6, 30.6, 30.4, 30.3, 29.8, 29.0, 28.1, 27.4, 27.0, 26.7, 26.3, 25.4, 24.1, 23.4, 24.7, 29.3, 38.0, 48.5, 58.3, 64.6, 65.4, 62.5, 58.1, 54.8, 54.5, 57.3, 63.1, 71.4, 81.9, 93.7, 105.9, 117.4, 127.4, 135.7, 142.2, 146.7, 149.3, 150.3, 150.2, 149.7, 149.0, 148.7, 148.8, 149.7, 151.4, 153.6, 155.5, 156.5, 156.3, 155.1, 153.7, 152.6, 152.3, 152.9, 154.4, 156.5, 159.3, 162.9, 167.1, 172.2, 177.8, 183.6, 188.8, 192.7, 194.9, 195.6, 195.4, 194.7, 193.9, 193.2, 192.5, 191.7, 190.9, 189.7, 187.8, 184.9, 180.5, 174.2, 165.4, 153.6, 138.6, 122.0, 105.8, 91.9, 82.0, 75.4, 70.9, 67.5}
        Dim SamstagslisteG3 As New List(Of Double) From {92.5, 93.0, 93.7, 94.3, 94.5, 94.5, 94.3, 94.3, 94.7, 95.0, 95.0, 94.3, 92.7, 90.6, 88.3, 86.5, 85.4, 85.1, 85.1, 85.3, 85.4, 85.8, 86.9, 88.9, 92.1, 95.7, 99.0, 101.0, 101.3, 101.1, 102.3, 106.4, 114.6, 124.9, 134.7, 141.5, 143.4, 141.8, 138.6, 136.1, 135.7, 137.1, 139.3, 141.5, 143.0, 143.6, 143.7, 143.3, 142.7, 141.8, 140.8, 139.7, 138.4, 136.8, 134.5, 131.2, 126.9, 121.9, 117.1, 113.1, 110.4, 108.6, 107.5, 106.4, 105.2, 104.1, 103.5, 104.0, 105.8, 108.1, 110.2, 111.3, 110.7, 109.0, 107.1, 105.8, 105.9, 107.0, 108.7, 110.7, 112.4, 113.5, 113.9, 113.1, 111.1, 108.3, 105.1, 102.2, 99.9, 98.1, 96.5, 95.0, 93.1, 91.3, 89.6, 88.3}
        Dim SamstagslisteG4 As New List(Of Double) From {67.2, 65.9, 64.8, 63.9, 63.2, 62.7, 62.4, 62.1, 61.8, 61.6, 61.3, 61.2, 61.1, 61.1, 61.1, 61.2, 61.3, 61.4, 61.6, 62.1, 62.7, 63.3, 63.5, 63.0, 61.9, 62.0, 65.2, 73.8, 88.9, 108.6, 129.7, 149.4, 165.2, 177.2, 185.8, 191.7, 195.3, 197.3, 198.3, 198.9, 199.5, 200.2, 200.9, 201.6, 202.1, 202.7, 203.3, 204.3, 205.4, 206.1, 205.4, 202.5, 196.5, 187.7, 176.1, 162.0, 145.8, 129.0, 113.1, 99.9, 90.4, 84.1, 80.1, 77.4, 75.1, 73.3, 72.2, 72.0, 72.8, 74.0, 75.2, 75.6, 74.9, 73.7, 72.7, 72.9, 74.7, 77.6, 80.9, 83.7, 85.5, 86.1, 85.8, 84.6, 82.6, 80.2, 77.4, 74.7, 72.1, 69.9, 68.0, 66.6, 65.6, 65.0, 64.4, 63.9}
        Dim SamstagslisteG5 As New List(Of Double) From {75.6, 97.6, 121.4, 143.1, 159.4, 170.6, 177.6, 181.4, 182.9, 183.1, 182.9, 183.4, 185.2, 188.7, 193.7, 200.5, 208.8, 217.5, 225.2, 230.7, 233.1, 232.9, 231.4, 229.7, 228.7, 228.4, 228.8, 229.7, 230.9, 230.9, 228.0, 220.7, 207.9, 191.8, 175.3, 161.2, 151.7, 145.9, 142.2, 139.0, 135.1, 130.6, 126.0, 121.9, 118.8, 116.9, 116.5, 117.9, 120.8, 123.8, 124.8, 121.9, 113.9, 102.6, 90.3, 79.6, 72.3, 68.1, 66.1, 65.5, 65.5, 65.7, 65.8, 65.5, 64.6, 63.6, 63.0, 63.5, 65.4, 68.2, 71.2, 73.6, 74.8, 74.8, 73.7, 71.5, 68.6, 65.3, 62.0, 59.4, 57.8, 56.9, 56.3, 55.4, 54.1, 52.4, 50.7, 49.4, 48.6, 48.1, 47.8, 47.4, 46.5, 45.5, 44.3, 43.3}
        Dim SamstagslisteG6 As New List(Of Double) From {64.7, 63.4, 63.0, 62.4, 60.4, 57.5, 54.1, 50.8, 48.1, 45.9, 44.1, 42.7, 41.6, 40.6, 39.8, 39.3, 38.8, 38.5, 38.3, 38.1, 37.9, 37.7, 37.4, 37.0, 36.4, 36.3, 37.0, 39.3, 43.3, 48.5, 54.0, 58.9, 62.6, 65.6, 68.7, 72.8, 78.3, 85.5, 94.1, 103.9, 114.8, 126.0, 136.5, 145.5, 152.3, 157.1, 160.1, 161.7, 162.1, 161.8, 161.1, 160.5, 160.3, 160.7, 161.8, 164.0, 167.1, 170.9, 174.7, 177.8, 180.0, 181.2, 181.6, 181.3, 180.7, 180.5, 181.6, 184.8, 190.7, 198.9, 208.8, 219.4, 230.2, 240.7, 250.3, 258.7, 265.2, 269.8, 271.9, 271.4, 268.1, 262.6, 255.8, 248.3, 240.7, 232.6, 223.4, 212.5, 199.4, 184.8, 169.6, 154.7, 141.0, 128.5, 117.3, 107.4}
        Dim SamstagslisteL0 As New List(Of Double) From {71.4, 69.4, 68.0, 66.7, 65.3, 63.9, 62.4, 61.1, 60.0, 59.1, 58.3, 57.4, 56.6, 55.7, 55.1, 54.7, 54.6, 54.7, 55.1, 55.6, 56.1, 56.6, 57.4, 58.4, 59.9, 62.9, 68.8, 78.7, 93.4, 111.6, 131.4, 151.0, 168.6, 183.2, 193.7, 199.2, 198.9, 194.1, 186.2, 176.9, 167.6, 159.6, 154.0, 151.9, 153.9, 157.9, 161.3, 161.2, 155.8, 146.7, 135.9, 126.0, 118.5, 113.1, 108.8, 104.7, 100.0, 95.3, 91.1, 88.0, 86.6, 86.3, 86.7, 87.1, 87.1, 87.3, 88.5, 91.7, 97.4, 105.7, 116.2, 128.8, 142.9, 157.3, 170.7, 181.6, 188.7, 191.7, 190.6, 185.3, 175.8, 163.7, 150.5, 138.0, 127.4, 118.8, 111.6, 105.6, 100.3, 95.5, 90.9, 86.1, 81.1, 76.1, 71.5, 67.6}
        Dim SamstagslisteL1 As New List(Of Double) From {64.9, 63.8, 62.9, 61.9, 60.6, 59.1, 57.9, 57.2, 57.4, 58.0, 58.5, 58.4, 57.5, 55.9, 54.1, 52.6, 51.6, 51.1, 51.1, 51.4, 52.1, 53.1, 54.8, 57.2, 60.8, 67.0, 77.3, 93.5, 116.4, 144.2, 174.4, 204.5, 231.5, 252.2, 262.7, 259.4, 240.3, 210.7, 177.8, 148.4, 128.2, 116.7, 112.0, 112.2, 115.3, 119.2, 122.0, 121.5, 116.4, 108.1, 98.9, 91.1, 86.4, 84.0, 82.9, 81.8, 79.8, 77.4, 75.1, 73.6, 73.4, 74.1, 75.2, 75.9, 76.1, 76.1, 77.0, 79.4, 84.5, 93.6, 108.5, 130.9, 161.0, 194.2, 224.4, 245.3, 252.6, 247.7, 233.7, 213.8, 190.8, 167.0, 144.4, 125.0, 110.4, 99.9, 92.7, 87.6, 83.8, 80.6, 77.8, 74.8, 71.3, 67.8, 64.5, 61.9}
        Dim SamstagslisteL2 As New List(Of Double) From {74.5, 72.3, 70.7, 69.2, 67.8, 66.2, 64.8, 63.5, 62.4, 61.4, 60.4, 59.4, 58.1, 56.9, 55.8, 55.2, 55.2, 55.6, 56.2, 56.9, 57.4, 57.9, 58.5, 59.4, 60.7, 63.2, 67.7, 75.0, 85.7, 98.7, 112.9, 127.0, 139.9, 151.3, 161.4, 169.8, 176.6, 181.3, 183.3, 182.2, 177.9, 172.1, 167.3, 165.7, 168.6, 173.9, 178.4, 178.9, 173.3, 163.2, 151.2, 140.1, 131.9, 125.9, 121.1, 116.2, 110.5, 104.5, 98.9, 94.8, 92.7, 92.0, 92.2, 92.3, 92.0, 91.9, 92.8, 95.6, 100.9, 108.2, 116.6, 125.3, 133.7, 141.6, 149.0, 155.8, 161.9, 166.6, 169.0, 168.2, 163.6, 156.2, 147.4, 138.5, 130.5, 123.4, 117.1, 111.3, 105.8, 100.4, 95.2, 89.9, 84.4, 79.2, 74.3, 70.1}

        Select Case Lastgang
            Case "G0"
                Return SamstagslisteG0
            Case "G1"
                Return SamstagslisteG1
            Case "G2"
                Return SamstagslisteG2
            Case "G3"
                Return SamstagslisteG3
            Case "G4"
                Return SamstagslisteG4
            Case "G5"
                Return SamstagslisteG5
            Case "G6"
                Return SamstagslisteG6
            Case "L0"
                Return SamstagslisteL0
            Case "L1"
                Return SamstagslisteL1
            Case Else
                Return SamstagslisteL2
        End Select
    End Function

    Function GibStandardLastgangSonntag(Lastgang As String)

        Dim SonntagslisteG0 As New List(Of Double) From {68.3, 66.5, 64.6, 62.6, 60.3, 57.9, 55.5, 53.3, 51.2, 49.5, 48.0, 46.7, 45.7, 44.9, 44.3, 43.9, 43.6, 43.5, 43.6, 43.9, 44.5, 45.1, 45.6, 45.8, 45.6, 45.3, 45.2, 45.8, 47.2, 49.1, 51.0, 52.3, 52.8, 52.9, 53.1, 54.2, 56.4, 59.5, 62.7, 65.4, 67.2, 68.5, 69.6, 71.0, 73.1, 75.6, 78.2, 80.4, 81.9, 82.8, 83.2, 83.2, 82.8, 82.1, 80.9, 79.4, 77.5, 75.3, 73.1, 71.0, 69.2, 67.6, 66.1, 64.5, 62.8, 61.5, 61.2, 62.6, 65.9, 70.4, 75.0, 78.5, 80.1, 80.4, 80.2, 80.4, 81.4, 83.1, 85.1, 86.9, 88.1, 88.7, 88.6, 87.8, 86.4, 84.4, 82.0, 79.4, 76.7, 74.1, 71.5, 69.1, 67.0, 65.3, 64.1, 63.5}
        Dim SonntagslisteG1 As New List(Of Double) From {22.4, 21.9, 21.4, 20.8, 20.2, 19.5, 19.1, 18.9, 19.2, 19.7, 20.3, 20.8, 21.2, 21.3, 21.2, 20.8, 20.3, 19.6, 19.1, 18.9, 19.1, 19.6, 20.3, 20.8, 21.1, 21.2, 21.1, 20.8, 20.4, 19.8, 19.3, 18.9, 18.8, 18.7, 18.8, 18.9, 19.0, 19.0, 19.0, 18.9, 18.8, 18.7, 18.8, 18.9, 19.3, 19.8, 20.4, 20.8, 21.1, 21.2, 21.2, 20.8, 20.3, 19.6, 19.1, 18.9, 19.1, 19.7, 20.3, 20.8, 21.1, 21.2, 21.1, 20.8, 20.4, 19.9, 19.4, 18.9, 18.6, 18.4, 18.5, 18.9, 19.8, 20.9, 21.9, 22.7, 23.0, 23.0, 22.9, 22.7, 22.7, 22.8, 22.8, 22.7, 22.3, 21.8, 21.3, 20.8, 20.6, 20.6, 20.7, 20.8, 21.0, 21.1, 21.0, 20.8}
        Dim SonntagslisteG2 As New List(Of Double) From {64.2, 60.7, 56.9, 52.8, 48.3, 43.8, 39.6, 36.2, 33.8, 32.2, 31.1, 30.3, 29.5, 28.7, 27.9, 27.4, 27.1, 26.8, 26.4, 25.4, 24.1, 23.2, 24.3, 28.4, 36.2, 45.7, 54.1, 58.7, 57.7, 52.5, 45.5, 39.1, 35.3, 34.7, 37.5, 44.0, 54.2, 66.8, 80.5, 93.9, 105.7, 115.5, 123.0, 128.1, 130.8, 131.5, 131.4, 131.1, 131.3, 131.6, 131.4, 130.1, 127.3, 123.6, 120.0, 117.4, 116.5, 116.8, 117.6, 118.4, 118.4, 118.0, 117.6, 117.4, 117.9, 119.3, 122.0, 126.2, 132.0, 138.7, 145.2, 150.6, 154.2, 156.4, 157.9, 159.4, 161.5, 163.8, 165.9, 167.3, 167.6, 166.9, 165.1, 162.4, 158.7, 153.5, 146.1, 136.0, 122.8, 108.1, 93.6, 81.2, 72.3, 66.4, 62.5, 59.7}
        Dim SonntagslisteG3 As New List(Of Double) From {87.6, 87.3, 87.4, 87.7, 88.0, 88.4, 88.9, 89.5, 90.3, 91.0, 91.2, 90.7, 89.2, 87.2, 85.1, 83.5, 82.7, 82.7, 83.1, 83.5, 83.7, 84.0, 84.8, 86.5, 89.2, 92.4, 95.4, 97.4, 97.9, 97.6, 97.3, 98.0, 100.1, 102.9, 105.4, 106.4, 105.4, 102.9, 99.9, 97.4, 96.1, 95.9, 96.3, 96.8, 96.9, 96.8, 96.6, 96.2, 95.7, 95.4, 95.1, 95.0, 95.0, 95.3, 95.6, 96.2, 96.7, 97.3, 97.5, 97.4, 96.7, 95.8, 94.9, 94.3, 94.4, 95.0, 95.9, 96.8, 97.6, 98.2, 98.8, 99.2, 99.5, 99.9, 100.5, 101.6, 103.2, 105.2, 107.4, 109.5, 111.2, 112.4, 112.5, 111.3, 108.5, 104.8, 100.8, 97.4, 95.0, 93.5, 92.4, 91.3, 89.9, 88.4, 87.2, 86.5}
        Dim SonntagslisteG4 As New List(Of Double) From {63.1, 62.2, 61.3, 60.3, 59.4, 58.6, 58.0, 57.6, 57.4, 57.4, 57.5, 57.6, 57.7, 57.7, 57.7, 57.6, 57.4, 57.3, 57.3, 57.6, 58.2, 58.9, 59.4, 59.4, 58.7, 57.7, 57.2, 57.6, 59.4, 62.0, 64.6, 66.6, 67.3, 67.0, 66.0, 64.8, 63.7, 62.8, 62.3, 62.1, 62.3, 62.9, 63.8, 64.8, 65.8, 66.7, 67.3, 67.5, 67.1, 66.2, 65.1, 63.9, 62.8, 62.0, 61.4, 61.2, 61.4, 61.9, 62.5, 63.0, 63.3, 63.4, 63.3, 63.0, 62.6, 62.3, 62.4, 63.0, 64.3, 65.9, 67.5, 68.4, 68.4, 68.0, 67.8, 68.4, 70.2, 72.8, 75.7, 78.3, 80.2, 81.3, 81.5, 81.0, 79.6, 77.7, 75.4, 72.9, 70.4, 68.1, 65.9, 63.9, 62.2, 61.0, 60.3, 60.3}
        Dim SonntagslisteG5 As New List(Of Double) From {42.5, 42.0, 41.6, 41.3, 41.1, 40.9, 41.0, 41.3, 41.9, 42.6, 43.1, 43.3, 43.0, 42.2, 41.3, 40.3, 39.5, 39.0, 38.9, 39.3, 40.4, 42.0, 44.0, 46.3, 48.8, 51.2, 53.2, 54.4, 54.8, 54.4, 53.5, 52.4, 51.3, 50.4, 50.1, 50.4, 51.6, 53.5, 55.8, 58.4, 61.1, 63.7, 66.2, 68.5, 70.6, 72.4, 73.7, 74.6, 74.8, 74.4, 73.3, 71.5, 69.1, 66.3, 63.7, 61.5, 60.0, 59.3, 59.2, 59.4, 59.9, 60.4, 60.6, 60.5, 59.7, 58.9, 58.3, 58.4, 59.7, 61.5, 63.3, 64.5, 64.6, 63.7, 62.2, 60.5, 58.6, 56.8, 55.1, 53.4, 51.8, 50.5, 49.3, 48.4, 47.7, 47.3, 46.9, 46.3, 45.6, 44.6, 43.5, 42.3, 41.1, 40.1, 39.4, 39.3}
        Dim SonntagslisteG6 As New List(Of Double) From {98.7, 91.2, 84.5, 78.5, 73.1, 68.1, 63.8, 60.0, 57.0, 54.3, 52.0, 49.7, 47.2, 44.7, 42.4, 40.4, 38.9, 37.8, 37.1, 37.0, 37.2, 37.5, 37.5, 37.0, 35.7, 34.5, 34.6, 37.0, 42.3, 49.8, 58.0, 65.8, 72.3, 78.7, 86.4, 97.0, 111.6, 129.1, 147.9, 166.3, 183.1, 198.4, 213.1, 227.5, 242.0, 255.2, 265.6, 271.4, 271.6, 267.8, 262.4, 257.5, 254.9, 253.3, 250.9, 246.0, 237.1, 225.2, 211.5, 197.5, 184.2, 171.9, 160.6, 150.1, 140.8, 133.8, 130.7, 132.8, 141.1, 154.4, 170.7, 188.2, 205.2, 220.5, 232.9, 241.3, 245.2, 245.3, 242.8, 239.0, 234.9, 230.1, 224.3, 217.1, 208.0, 197.2, 184.8, 170.9, 155.9, 140.2, 124.6, 109.7, 96.0, 83.9, 73.4, 64.7}
        Dim SonntagslisteL0 As New List(Of Double) From {64.8, 62.7, 61.3, 60.2, 59.2, 58.2, 57.3, 56.5, 55.8, 55.3, 54.9, 54.7, 54.6, 54.6, 54.7, 54.7, 54.5, 54.3, 54.3, 54.7, 55.5, 57.3, 60.3, 64.8, 71.3, 79.8, 90.6, 103.7, 119.3, 136.3, 153.8, 170.4, 185.3, 197.0, 204.6, 206.6, 202.4, 193.4, 181.5, 168.6, 156.5, 146.4, 139.6, 137.1, 139.4, 144.3, 148.8, 150.1, 146.0, 138.1, 128.5, 119.5, 112.9, 108.6, 105.7, 103.7, 102.0, 100.5, 99.2, 98.2, 97.4, 96.7, 96.1, 95.4, 94.7, 94.5, 95.8, 99.1, 105.2, 114.0, 125.3, 138.9, 154.5, 170.3, 184.6, 195.4, 201.4, 202.7, 199.9, 193.6, 184.4, 173.4, 161.6, 150.1, 139.6, 130.3, 122.1, 114.9, 108.4, 102.5, 97.0, 91.7, 86.4, 81.2, 76.4, 72.3}
        Dim SonntagslisteL1 As New List(Of Double) From {60.4, 59.6, 59.1, 58.4, 57.3, 56.1, 55.1, 54.9, 55.7, 57.0, 58.1, 58.4, 57.4, 55.5, 53.3, 51.4, 50.4, 50.3, 51.0, 52.6, 54.9, 58.1, 62.4, 67.8, 74.7, 84.4, 98.3, 118.0, 144.0, 173.6, 203.1, 229.0, 248.0, 258.5, 259.2, 248.9, 227.3, 198.8, 169.1, 143.7, 126.8, 117.8, 114.7, 115.7, 118.7, 122.2, 124.5, 123.8, 119.2, 111.8, 103.4, 95.8, 90.5, 87.3, 85.8, 85.3, 85.4, 85.8, 86.2, 86.5, 86.3, 85.8, 85.0, 84.1, 83.2, 82.6, 82.8, 84.1, 87.4, 94.7, 108.4, 130.9, 162.9, 198.9, 231.9, 254.7, 262.0, 256.0, 240.6, 219.6, 196.8, 173.8, 152.2, 133.2, 118.0, 106.3, 97.5, 91.1, 86.5, 83.0, 80.0, 77.1, 73.8, 70.3, 67.0, 64.3}
        Dim SonntagslisteL2 As New List(Of Double) From {66.8, 64.3, 62.4, 61.0, 60.0, 59.1, 58.4, 57.7, 57.0, 56.2, 55.6, 55.2, 55.1, 55.2, 55.3, 55.2, 54.9, 54.7, 54.7, 55.2, 56.7, 59.1, 62.7, 67.6, 73.9, 81.5, 90.4, 100.6, 111.8, 123.7, 135.8, 147.6, 158.5, 168.0, 175.6, 180.5, 182.4, 181.3, 177.3, 170.6, 161.9, 152.9, 146.0, 143.4, 146.6, 153.0, 159.2, 161.6, 157.8, 149.4, 139.1, 129.4, 122.5, 118.1, 115.2, 112.9, 110.7, 108.4, 106.3, 104.7, 103.6, 102.8, 102.2, 101.4, 100.4, 99.9, 101.0, 104.7, 111.5, 120.6, 130.8, 141.0, 150.0, 157.9, 164.7, 170.6, 175.7, 179.4, 180.9, 179.7, 175.3, 168.5, 160.3, 151.7, 143.5, 135.9, 128.7, 122.0, 115.6, 109.4, 103.3, 97.3, 91.2, 85.3, 79.8, 75.0}

        Select Case Lastgang
            Case "G0"
                Return SonntagslisteG0
            Case "G1"
                Return SonntagslisteG1
            Case "G2"
                Return SonntagslisteG2
            Case "G3"
                Return SonntagslisteG3
            Case "G4"
                Return SonntagslisteG4
            Case "G5"
                Return SonntagslisteG5
            Case "G6"
                Return SonntagslisteG6
            Case "L0"
                Return SonntagslisteL0
            Case "L1"
                Return SonntagslisteL1
            Case Else
                Return SonntagslisteL2
        End Select
    End Function

    Function GibStandardLastgangWerktag(Lastgang As String)

        Dim WerktagslisteG0 As New List(Of Double) From {73.0, 70.1, 67.1, 64.5, 62.3, 60.6, 59.2, 57.9, 56.7, 55.6, 54.7, 54.2, 54.1, 54.6, 55.8, 57.9, 60.9, 64.4, 68.0, 71.0, 73.2, 74.7, 75.7, 76.6, 77.7, 79.3, 81.9, 86.0, 91.9, 100.4, 111.9, 127.1, 145.9, 166.2, 185.2, 200.0, 208.5, 212.1, 212.6, 212.1, 212.2, 213.1, 214.6, 216.8, 219.2, 221.2, 222.0, 220.5, 216.3, 209.8, 201.9, 193.4, 185.0, 177.4, 170.9, 166.3, 163.9, 163.6, 165.1, 168.2, 172.5, 177.3, 181.4, 184.1, 184.5, 183.6, 182.1, 181.3, 181.5, 181.7, 180.0, 174.7, 164.8, 151.5, 137.0, 123.3, 112.1, 103.4, 97.3, 93.4, 91.6, 91.1, 91.1, 90.6, 89.2, 87.2, 85.0, 83.2, 82.1, 81.7, 81.6, 81.3, 80.6, 79.5, 77.9, 75.7}
        Dim WerktagslisteG1 As New List(Of Double) From {20.2, 19.7, 19.2, 18.9, 18.8, 18.8, 18.9, 18.9, 18.9, 18.9, 18.9, 18.9, 19.0, 19.1, 19.1, 18.9, 18.5, 18.3, 18.9, 20.8, 24.1, 27.2, 28.1, 24.6, 27.9, 28.6, 30.8, 32.2, 74.1, 131.7, 195.3, 255.5, 304.6, 341.8, 368.0, 384.2, 391.7, 393.1, 391.5, 389.9, 390.6, 392.9, 395.7, 397.5, 397.3, 395.0, 390.6, 384.2, 375.8, 364.5, 349.3, 329.3, 304.7, 279.8, 260.3, 251.7, 257.5, 272.9, 290.9, 304.7, 309.0, 304.7, 294.3, 280.1, 264.3, 246.5, 226.2, 202.5, 175.4, 146.9, 119.7, 96.5, 79.3, 67.2, 59.0, 53.0, 48.1, 44.0, 40.7, 37.9, 35.6, 33.6, 31.9, 30.3, 28.7, 27.1, 25.7, 24.6, 23.8, 23.4, 23.0, 22.7, 22.3, 21.9, 21.4, 20.8}
        Dim WerktagslisteG2 As New List(Of Double) From {70.5, 61.9, 54.4, 47.9, 42.5, 38.1, 34.7, 32.3, 30.8, 29.9, 29.5, 29.3, 29.2, 29.1, 29.1, 29.3, 29.9, 30.3, 30.3, 29.3, 27.5, 26.1, 26.8, 31.3, 40.6, 52.3, 63.3, 70.4, 71.5, 68.5, 64.2, 61.6, 62.9, 67.7, 75.1, 84.1, 93.8, 103.7, 113.3, 122.3, 130.2, 137.0, 142.5, 146.7, 149.6, 151.2, 151.5, 150.6, 148.8, 146.4, 143.9, 141.8, 140.6, 140.1, 140.0, 139.9, 139.7, 139.9, 141.1, 143.8, 148.4, 153.9, 159.3, 163.4, 165.3, 166.2, 167.4, 170.2, 175.7, 183.0, 190.7, 197.6, 202.6, 206.0, 208.0, 209.3, 210.2, 210.9, 211.6, 212.3, 213.1, 213.5, 213.1, 211.3, 207.6, 201.8, 194.0, 183.9, 171.7, 157.9, 143.5, 129.1, 115.5, 102.7, 91.0, 80.2}
        Dim WerktagslisteG3 As New List(Of Double) From {91.2, 90.2, 89.4, 88.9, 88.7, 88.8, 89.1, 89.5, 90.0, 90.3, 90.2, 89.5, 88.0, 86.1, 84.0, 82.3, 81.1, 80.5, 80.4, 80.4, 80.7, 81.3, 82.5, 84.7, 87.9, 91.6, 95.2, 98.0, 99.6, 100.9, 102.8, 106.4, 112.4, 119.5, 126.3, 131.2, 133.3, 133.2, 132.1, 131.2, 131.5, 132.8, 134.7, 136.7, 138.4, 139.7, 140.6, 140.9, 140.7, 140.0, 139.0, 137.9, 136.8, 135.9, 135.0, 134.3, 133.7, 133.3, 133.1, 133.1, 133.2, 133.4, 133.6, 133.7, 133.4, 133.1, 132.9, 133.1, 133.6, 134.5, 135.6, 136.7, 137.6, 138.0, 137.6, 136.1, 133.2, 129.6, 126.1, 123.4, 122.1, 121.6, 121.1, 119.7, 117.0, 113.3, 109.4, 105.8, 103.2, 101.3, 99.9, 98.6, 97.1, 95.6, 94.0, 92.5}
        Dim WerktagslisteG4 As New List(Of Double) From {67.2, 66.1, 64.9, 63.9, 63.0, 62.2, 61.6, 61.2, 61.1, 61.1, 61.2, 61.2, 61.1, 60.9, 60.6, 60.3, 60.0, 59.8, 59.9, 60.3, 61.1, 62.1, 62.8, 63.0, 62.5, 62.2, 63.2, 66.6, 73.2, 83.3, 96.7, 113.4, 132.9, 153.2, 171.8, 186.3, 194.8, 198.7, 199.7, 199.8, 200.4, 201.5, 202.7, 203.4, 203.2, 202.3, 200.8, 198.9, 196.6, 193.3, 188.3, 180.9, 170.7, 159.4, 149.2, 142.2, 139.9, 142.2, 148.0, 156.6, 166.9, 177.6, 186.9, 193.5, 196.1, 196.0, 194.9, 194.4, 195.6, 197.4, 197.9, 195.3, 188.3, 177.7, 164.9, 151.2, 137.8, 125.5, 115.3, 108.0, 103.9, 102.1, 101.2, 99.9, 97.1, 93.2, 88.8, 84.6, 81.0, 78.1, 75.7, 73.8, 72.2, 70.8, 69.6, 68.4}
        Dim WerktagslisteG5 As New List(Of Double) From {56.0, 51.3, 46.6, 43.3, 42.4, 42.9, 43.7, 43.3, 41.4, 40.1, 42.8, 52.4, 71.0, 95.9, 123.5, 150.1, 172.6, 190.3, 203.3, 211.6, 215.4, 216.2, 215.7, 215.6, 217.2, 220.0, 223.1, 225.7, 227.0, 226.9, 225.8, 223.7, 220.8, 217.7, 214.8, 212.6, 211.3, 210.5, 209.1, 206.5, 202.2, 196.5, 190.3, 184.4, 179.2, 174.3, 168.9, 162.2, 153.7, 144.2, 134.6, 125.9, 119.1, 114.2, 111.1, 109.8, 110.1, 111.4, 112.9, 113.9, 113.8, 112.9, 111.4, 109.8, 108.3, 107.1, 106.2, 105.8, 105.8, 105.8, 105.3, 103.8, 100.8, 96.7, 91.9, 86.6, 81.5, 76.5, 72.2, 68.5, 65.8, 63.8, 62.5, 61.5, 60.6, 59.9, 59.2, 58.4, 57.7, 57.1, 56.9, 57.4, 58.7, 60.1, 60.6, 59.4}
        Dim WerktagslisteG6 As New List(Of Double) From {61.0, 54.9, 49.9, 46.2, 43.7, 42.1, 41.1, 40.4, 39.7, 39.0, 38.5, 38.1, 38.0, 38.1, 38.2, 38.1, 37.8, 37.4, 37.0, 37.0, 37.3, 37.9, 38.6, 39.3, 39.8, 40.4, 41.2, 42.7, 45.0, 48.1, 52.0, 56.6, 61.8, 67.5, 73.1, 78.5, 83.4, 88.1, 92.9, 98.2, 104.3, 111.6, 120.6, 131.6, 144.7, 158.3, 170.4, 179.0, 182.7, 182.6, 180.1, 176.7, 173.6, 170.1, 165.3, 158.2, 148.2, 136.6, 125.1, 115.5, 109.0, 105.2, 103.4, 102.8, 102.7, 103.7, 106.2, 110.9, 118.1, 127.2, 137.4, 147.8, 157.6, 166.3, 173.6, 179.0, 182.4, 184.2, 185.1, 185.9, 187.0, 188.0, 188.2, 187.1, 184.0, 178.9, 171.4, 161.7, 149.6, 136.0, 122.0, 108.5, 96.4, 85.8, 76.4, 68.1}
        Dim WerktagslisteL0 As New List(Of Double) From {70.3, 67.1, 64.3, 62.1, 60.3, 59.1, 58.1, 57.4, 56.9, 56.4, 56.0, 55.6, 55.1, 54.5, 54.1, 53.7, 53.6, 53.7, 54.0, 54.7, 55.6, 57.2, 59.8, 63.9, 69.8, 77.6, 87.6, 100.0, 114.8, 131.3, 148.6, 165.8, 181.9, 195.1, 203.4, 204.7, 198.0, 185.5, 170.6, 156.5, 145.9, 139.0, 135.5, 135.2, 137.5, 140.7, 143.1, 142.6, 138.2, 130.9, 122.5, 114.9, 109.4, 105.9, 103.9, 102.8, 102.1, 101.7, 101.4, 101.0, 100.4, 99.9, 99.4, 99.1, 99.2, 99.9, 101.6, 104.7, 109.4, 116.2, 125.6, 138.0, 153.5, 170.2, 185.8, 198.2, 205.5, 207.5, 204.7, 197.3, 185.9, 172.1, 157.7, 144.5, 133.8, 125.5, 118.8, 113.0, 107.7, 102.5, 97.6, 92.6, 87.7, 82.9, 78.3, 74.1}
        Dim WerktagslisteL1 As New List(Of Double) From {64.4, 62.6, 61.0, 59.6, 58.2, 57.0, 56.2, 56.1, 56.7, 57.6, 58.3, 58.4, 57.5, 55.9, 54.1, 52.6, 51.7, 51.5, 51.8, 52.6, 53.8, 55.9, 59.2, 64.3, 71.5, 81.9, 96.3, 115.7, 140.3, 168.1, 196.6, 223.1, 245.1, 259.7, 264.2, 255.9, 233.6, 202.5, 169.5, 141.4, 123.3, 114.3, 111.8, 113.3, 116.5, 119.6, 121.4, 120.3, 115.6, 108.4, 100.4, 93.5, 88.9, 86.4, 85.4, 85.3, 85.5, 85.9, 86.3, 86.5, 86.3, 86.0, 85.6, 85.3, 85.2, 85.4, 86.2, 87.6, 90.3, 96.6, 109.2, 130.9, 162.7, 198.8, 232.0, 254.7, 261.4, 254.4, 237.9, 216.1, 192.7, 169.6, 148.1, 129.7, 115.3, 104.6, 96.8, 91.1, 86.9, 83.7, 80.9, 78.3, 75.3, 72.3, 69.3, 66.6}
        Dim WerktagslisteL2 As New List(Of Double) From {73.1, 69.3, 66.0, 63.5, 61.8, 60.7, 60.0, 59.4, 58.6, 57.7, 56.9, 56.1, 55.4, 54.9, 54.6, 54.4, 54.5, 54.7, 55.3, 56.1, 57.2, 59.0, 61.8, 65.9, 71.7, 78.9, 87.5, 97.3, 108.0, 119.3, 131.0, 142.6, 153.7, 163.5, 170.8, 174.8, 174.7, 171.3, 165.7, 159.1, 152.5, 146.9, 143.3, 142.6, 145.3, 149.5, 152.9, 153.3, 149.1, 141.5, 132.6, 124.5, 118.6, 114.9, 112.7, 111.3, 110.2, 109.2, 108.5, 108.0, 107.7, 107.5, 107.3, 107.2, 107.0, 107.4, 108.9, 112.1, 117.6, 124.7, 133.0, 141.8, 150.4, 158.8, 166.6, 173.9, 180.4, 185.0, 186.8, 184.7, 178.0, 168.2, 157.1, 146.7, 138.4, 131.9, 126.4, 121.2, 115.7, 109.8, 103.9, 98.1, 92.5, 87.2, 82.2, 77.5}

        Select Case Lastgang
            Case "G0"
                Return WerktagslisteG0
            Case "G1"
                Return WerktagslisteG1
            Case "G2"
                Return WerktagslisteG2
            Case "G3"
                Return WerktagslisteG3
            Case "G4"
                Return WerktagslisteG4
            Case "G5"
                Return WerktagslisteG5
            Case "G6"
                Return WerktagslisteG6
            Case "L0"
                Return WerktagslisteL0
            Case "L1"
                Return WerktagslisteL1
            Case Else
                Return WerktagslisteL2
        End Select
    End Function

    Sub ErstelleLastgangNachProfil(Profil As String)
        Dim Lastgang As New List(Of Double)
        Dim Jahr As Integer
        Dim TageImJahr As Integer
        If FehlendeEingabe() Or Profil = "" Then
            MsgBox("Fehlende Eingabe!")
            Exit Sub
        End If
        Jahr = TextBoxJahr.Text
        TageImJahr = GetTageImJahr(Jahr)

        Dim DatumArray() As Date = ErstelleDatumArray(Jahr)
        Dim tagesArray() As Date = ErstelleTagesArray(Jahr)

        Dim Samstagsliste As New List(Of Double)
        Dim Sonntagsliste As New List(Of Double)
        Dim Werktagsliste As New List(Of Double)

        Samstagsliste = GibStandardLastgangSamstag(Profil)
        Sonntagsliste = GibStandardLastgangSonntag(Profil)
        Werktagsliste = GibStandardLastgangWerktag(Profil)

        For i = 0 To TageImJahr - 1
            If Weekday(tagesArray(i)) = 1 Then      'Sonntag
                Lastgang.AddRange(Sonntagsliste)
            ElseIf Weekday(tagesArray(i)) = 7 Then  'Samstag
                Lastgang.AddRange(Samstagsliste)
            Else                                    'Werktag
                Lastgang.AddRange(Werktagsliste)
            End If
        Next

        Dim DArray = Lastgang.ToArray()

        Chart1.Series(0).XValueType = DataVisualization.Charting.ChartValueType.DateTime
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "ddd dd.MM.yy  HH:mm"
        Chart1.Series(0).Points.DataBindXY(DatumArray, DArray)
        TextBox1.Text = Format(DArray.Sum / 4000, "###,##0.")

    End Sub

    Function GetTageImJahr(jahr)
        If (jahr Mod 4) = 0 Then
            Return 366
        Else
            Return 365
        End If

    End Function

    Function ErstelleTagesArray(jahr As Integer)

        Dim TageImJahr As Integer = GetTageImJahr(jahr)
        Dim TagesArray(TageImJahr) As Date
        TagesArray(0) = #1/1/0001#
        TagesArray(0) = TagesArray(0).AddYears(jahr - 1)
        For i = 1 To TageImJahr - 1
            TagesArray(i) = TagesArray(i - 1).AddDays(1)
            ' Console.WriteLine(Format(TagesArray(i), "ddd dd.MM.yy"))
        Next
        Return TagesArray
    End Function

    Sub GibDatumArrayAus()
        Dim Datumarray() As Date
        Datumarray = ErstelleDatumArray(TextBoxJahr.Text)

        For i = 0 To Datumarray.GetUpperBound(0)
            Console.WriteLine(Format(Datumarray(i), "ddd dd.MM.yy  HH:mm"))
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

    Function Anstieg(Start As Date, Ende As Date, Anfangsleistung As Double, Endleistung As Double)
        Dim Startindex As Integer = IndexDerUhrzeit(Start)
        Dim Endindex As Integer = IndexDerUhrzeit(Ende)
        Dim LängeAnstieg As Integer = Endindex - Startindex
        Dim HöheAnstieg As Double = Endleistung - Anfangsleistung
        Dim Steilheit As Double = HöheAnstieg / LängeAnstieg
        Dim AusgabeArray(95) As Double

        For i = Startindex To Endindex     '4*24 = 96 
            AusgabeArray(i) = Anfangsleistung + (i - Startindex) * Steilheit
        Next
        Return AusgabeArray
    End Function



    Function IndexDerUhrzeit(Zeit As Date)
        Dim StundenIndex As Integer = Hour(Zeit)          '0 bis 23
        'Dim MinutenIndex As Integer = Minute(Zeit)  '0 bis 59
        Dim Index As Integer
        Index = StundenIndex * 4
        Return Index

    End Function

    Function PrüfeZeit(Datum As Date)
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

    Private Sub ButtonNeu_Click(sender As Object, e As EventArgs) Handles ButtonNeu.Click
        Dim Profil As String
        Select Case ComboBox1.Text
            Case "G0 - Gewerbe allgemein"
                Profil = "G0"
            Case "G1 - Gewerbe werktags 8 - 18"
                Profil = "G1"
            Case "G2 - Gewerbe Abendstunden"
                Profil = "G2"
            Case "G3 - Gewerbe Durchlaufend"
                Profil = "G3"
            Case "G4 - Laden/Friseur"
                Profil = "G4"
            Case "G5 - Bäckerei mit Backstube"
                Profil = "G5"
            Case "G6 - Wochenendbetrieb"
                Profil = "G6"
            Case "L0 - Landwirtschaft allgemein"
                Profil = "L0"
            Case "L1 - Landwirtschaft Milch"
                Profil = "L1"
            Case "L2 - Landwirtschaft sonstige"
                Profil = "L2"
            Case Else
                Profil = ""
        End Select
        ErstelleLastgangNachProfil(Profil)
    End Sub
End Class