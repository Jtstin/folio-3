'Name:         Justin Tan
'Start Date:   28/2/20
'Last Udpated: 28/02/20
'Description: A data dictionary that contains names
Public Class frrmMobiles

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dlgBrowseFiles.InitialDirectory = FileSystem.CurDir
        dlgBrowseFiles.FileName = "mobiles.txt"

        Dim dlgResult = dlgBrowseFiles.ShowDialog()
        If dlgResult = DialogResult.OK Then
            Dim fileReader As System.IO.StreamReader
            lstNumbers.Items.Clear()
            fileReader = My.Computer.FileSystem.OpenTextFileReader(dlgBrowseFiles.FileName)
            Dim line As String
            Dim lineNumber As Int32 = 0
            While Not fileReader.EndOfStream
                line = fileReader.ReadLine()
                Dim row = line.Split(",")
                Dim person As Person = New Person
                person.Name = row(0) + " " + row(1)
                Dim mobileNumber As String = row(2)
                person.Mobile = mobileNumber.Substring(0, 4) + " " + mobileNumber.Substring(4, 3) + " " + mobileNumber.Substring(7, 3)
                lstNumbers.Items.Add(person.Name)
                lstNumbers.Items(lineNumber).SubItems.Add(person.Mobile)
                lineNumber = lineNumber + 1
            End While
            frrmMobiles.ActiveForm.Text = "Friends (file:" + dlgBrowseFiles.FileName + ")"
            fileReader.Close()
        End If
    End Sub


End Class
