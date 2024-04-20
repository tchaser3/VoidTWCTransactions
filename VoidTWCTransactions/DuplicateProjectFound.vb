'Title:         Duplicate Project Found
'Date:          4-1-15
'Author:        Terry Holmes

'Description:   This form is the dialog box seen if there are duplicate projects

Option Strict On

Public Class DuplicateProjectFound

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        'This will return the user to the call form
        Me.Close()

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        'This will open up the duplicate project ID From
        RemoveDuplicateProject.Show()
        Me.Close()

    End Sub
End Class