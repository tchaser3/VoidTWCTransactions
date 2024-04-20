'Title:         Void TWC Transactions
'Date:          3-31-15
'Author:        Terry Holmes

'Description:   This application is used to void transactions

Option Strict On

Public Class Form1

    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the form
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnRemoveProject_Click(sender As Object, e As EventArgs) Handles btnRemoveProject.Click

        'This will display the Remove Project Form
        LastTransaction.Show()
        RemoveProject.Show()
        Me.Close()

    End Sub

    Private Sub btnVoidReceiveTransactions_Click(sender As Object, e As EventArgs) Handles btnVoidReceiveTransactions.Click
        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnVoidPickList_Click(sender As Object, e As EventArgs) Handles btnVoidPickList.Click
        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnVoidIssuedTransactions_Click(sender As Object, e As EventArgs) Handles btnVoidIssuedTransactions.Click
        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnVoidUsedTransactions_Click(sender As Object, e As EventArgs) Handles btnVoidUsedTransactions.Click
        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will set up the last transactions
        Logon.mstrLastTransactionSummary = "LOADED THE VOID TWC INVENTORY TRANSACTION"
    End Sub
End Class
