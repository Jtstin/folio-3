'Name:         Justin Tan
'Start Date:   28/2/20
'Last Udpated: 28/02/20
'Description: A data dictionary that contains names
Public Class frrmMobiles

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dlgBrowseFiles.InitialDirectory = FileSystem.CurDir
        dlgBrowseFiles.FileName = "mobiles.txt"

        Dim dlgResult = dlgBrowseFiles.ShowDialog()
        If dlgResult = dlgResult.OK Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(dlgBrowseFiles.FileName)
            Dim line As String
            Dim lineNumber As Int32 = 0

            While Not fileReader.EndOfStream
                line = fileReader.ReadLine()
                Dim row = line.Split(",")
                lstNumbers.Items.Add(row(0))
                lstNumbers.Items(lineNumber).SubItems.Add(row(2))
                lineNumber = lineNumber + 1
            End While
        End If
    End Sub
End Class
