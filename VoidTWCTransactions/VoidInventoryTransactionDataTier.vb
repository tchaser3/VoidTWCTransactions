'Title:         Void Inventory Transaction Data Tier
'Date:          3-51-15
'Author:        Terry Holmes

'Description:   This class is the data tier

Public Class VoidInventoryTransactionDataTier

    Private aVoidInventoryTransactionDataSetTableAdapter As VoidInventoryTransactionDataSetTableAdapters.voidinventorytransactionTableAdapter
    Private aVoidInventoryTransactionDataSet As VoidInventoryTransactionDataSet

    Private aVoidInventoryTransactionIDDataSetTableAdapter As VoidInventoryTransactionIDDataSetTableAdapters.voidinventorytransactionidTableAdapter
    Private aVoidInventoryTransactionIDDataSet As VoidInventoryTransactionIDDataSet

    Public Function GetVoidInventoryTransactionInformation() As VoidInventoryTransactionDataSet

        'Setting up the Datatier
        Try
            aVoidInventoryTransactionDataSet = New VoidInventoryTransactionDataSet
            aVoidInventoryTransactionDataSetTableAdapter = New VoidInventoryTransactionDataSetTableAdapters.voidinventorytransactionTableAdapter
            aVoidInventoryTransactionDataSetTableAdapter.Fill(aVoidInventoryTransactionDataSet.voidinventorytransaction)
            Return aVoidInventoryTransactionDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aVoidInventoryTransactionDataSet
        End Try
    End Function

    Public Sub UpdateVoidInventoryTransactionDB(ByVal aVoidInventoryTransactionDataSet As VoidInventoryTransactionDataSet)

        'This will update the database
        Try
            aVoidInventoryTransactionDataSetTableAdapter.Update(aVoidInventoryTransactionDataSet.voidinventorytransaction)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetVoidInventoryTransactionIDInformation() As VoidInventoryTransactionIDDataSet

        'Setting up the Datatier
        Try
            aVoidInventoryTransactionIDDataSet = New VoidInventoryTransactionIDDataSet
            aVoidInventoryTransactionIDDataSetTableAdapter = New VoidInventoryTransactionIDDataSetTableAdapters.voidinventorytransactionidTableAdapter
            aVoidInventoryTransactionIDDataSetTableAdapter.Fill(aVoidInventoryTransactionIDDataSet.voidinventorytransactionid)
            Return aVoidInventoryTransactionIDDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aVoidInventoryTransactionIDDataSet
        End Try
    End Function

    Public Sub UpdateVoidInventoryTransactionIDDB(ByVal aVoidInventoryTransactionIDDataSet As VoidInventoryTransactionIDDataSet)

        'This will update the database
        Try
            aVoidInventoryTransactionIDDataSetTableAdapter.Update(aVoidInventoryTransactionIDDataSet.voidinventorytransactionid)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
