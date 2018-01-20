Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtString_TextChanged(sender As Object, e As EventArgs) Handles txtString.TextChanged
    End Sub

    Private Sub BtnLength_Click(sender As Object, e As EventArgs) Handles BtnLength.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the length of the string
        MessageBox.Show(strResults.Length.ToString & " characters(s)", "Strings")
    End Sub
End Class