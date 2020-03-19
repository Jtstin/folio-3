'Name:         Justin Tan
'Start Date:   28/2/20
'Last Udpated: 28/02/20
'Description: A data dictionary that contains names
Public Class frrmMobiles

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dlgBrowseFiles.InitialDirectory = FileSystem.CurDir
        dlgBrowseFiles.FileName = "mobiles.txt"

        Dim dlgResult = dlgBrowseFiles.ShowDialog() 'Open file browser to select file
        If dlgResult = DialogResult.OK Then
            Dim fileReader As System.IO.StreamReader
            lstNumbers.Items.Clear() 'Clears all items so that previous items are removed
            fileReader = My.Computer.FileSystem.OpenTextFileReader(dlgBrowseFiles.FileName) 'This creates a text reader which allows the program to read the textfile
            Dim line As String
            Dim lineNumber As Int32 = 0
            While Not fileReader.EndOfStream 'While not at the end of the file, the file reader will conitnue to read the names and mobile numbers
                line = fileReader.ReadLine()
                Dim row = line.Split(",")
                Dim person As Person = New Person
                person.Name = row(0) + " " + row(1)
                Dim mobileNumber As String = row(2)
                person.Mobile = mobileNumber.Substring(0, 4) + " " + mobileNumber.Substring(4, 3) + " " + mobileNumber.Substring(7, 3) 'Formatting for the phone number
                lstNumbers.Items.Add(person.Name)
                lstNumbers.Items(lineNumber).SubItems.Add(person.Mobile)
                lineNumber = lineNumber + 1 'Add the next person and their mobile number to the next line
            End While
            frrmMobiles.ActiveForm.Text = "Friends (file:" + dlgBrowseFiles.FileName + ")"
            fileReader.Close()
        End If
    End Sub


End Class
