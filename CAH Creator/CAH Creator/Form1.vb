Public Class Form1
    Private Sub cmdGenerateCards_Click(sender As Object, e As EventArgs)
        If tbxCardFrontLocation.Text = "" Then
            MsgBox("Please Select the Card Front", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If tbxCardTextLocation.Text = "" Then
            MsgBox("Please Select the Text File", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If tbxDestinationFolder.Text = "" Then
            MsgBox("Please Select the Destination Folder", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim img As Image = Image.FromFile(tbxCardFrontLocation.Text)
        Dim gr As Graphics = Graphics.FromImage(img)
        Dim rectF As RectangleF = New RectangleF(img.Width * 0.1, img.Height * 0.1, img.Width * 0.69, img.Height * 0.8)
        Dim fontColor As SolidBrush
        If rdoBlack.Checked Then
            fontColor = New SolidBrush(Color.White)
        ElseIf rdoWhite.Checked Then
            fontColor = New SolidBrush(Color.Black)
        Else
            MsgBox("Please Select a Card Color", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        For Each line As String In System.IO.File.ReadAllLines(tbxCardTextLocation.Text)
            Dim cardtext As String = line
            gr.DrawString(line, New Font("HelveticaNeueLTStd-Bd", tbxFontSize.Text), fontColor, rectF)
            gr.Dispose()
            img.Save(tbxDestinationFolder.Text & "\" & RemoveInvalidFileNameChars(line) & ".png")
            img = Image.FromFile(tbxCardFrontLocation.Text)
            gr = Graphics.FromImage(img)
        Next

    End Sub

    Public Sub cmdSelectCardFront_Click(sender As Object, e As EventArgs)
        Dim blah As OpenFileDialog = New OpenFileDialog
        blah.Filter = "Images|*.png; *.jpg; *.bmp; *.gif; *.tiff"
        If blah.ShowDialog() Then
            tbxCardFrontLocation.Text = blah.FileName
        End If
        Dim cardtext As String = "This Is some preview text"
        Dim img As Image = Image.FromFile(tbxCardFrontLocation.Text)
        Dim gr As Graphics = Graphics.FromImage(img)
        Dim rectF As RectangleF = New RectangleF(img.Width * 0.1, img.Height * 0.1, img.Width * 0.69, img.Height * 0.8)

        gr.DrawString(cardtext, New Font("HelveticaNeueLTStd-Bd", tbxFontSize.Text), New SolidBrush(Color.Gray), rectF)
        gr.Dispose()
        pbxPreview.Image = img
    End Sub

    Private Sub cmdSelectCardText_Click(sender As Object, e As EventArgs)
        Dim blah As OpenFileDialog = New OpenFileDialog
        blah.Filter = "Text File|*.txt"
        If blah.ShowDialog() Then
            tbxCardTextLocation.Text = blah.FileName
        End If
    End Sub

    Private Sub cmdSetDestinationFolder_Click(sender As Object, e As EventArgs)
        Dim blah As FolderBrowserDialog = New FolderBrowserDialog
        If blah.ShowDialog() Then
            tbxDestinationFolder.Text = blah.SelectedPath
        End If
    End Sub

    Private Function RemoveInvalidFileNameChars(UserInput As String) As String
        For Each invalidChar In IO.Path.GetInvalidFileNameChars
            UserInput = UserInput.Replace(invalidChar, "")
        Next
        Return UserInput
    End Function

    Private Sub tbxFontSize_TextChanged(sender As Object, e As EventArgs)
        If tbxCardFrontLocation.Text = "" Or tbxFontSize.Text = "" Then
            Exit Sub
        ElseIf CInt(tbxFontSize.Text) < 1 Then
            Exit Sub
        End If
        Dim cardtext As String = "This Is some preview text"
        Dim img As Image = Image.FromFile(tbxCardFrontLocation.Text)
        Dim gr As Graphics = Graphics.FromImage(img)
        Dim rectF As RectangleF = New RectangleF(img.Width * 0.1, img.Height * 0.1, img.Width * 0.69, img.Height * 0.8)

        gr.DrawString(cardtext, New Font("HelveticaNeueLTStd-Bd", tbxFontSize.Text), New SolidBrush(Color.Gray), rectF)
        gr.Dispose()
        pbxPreview.Image = img
    End Sub
End Class
