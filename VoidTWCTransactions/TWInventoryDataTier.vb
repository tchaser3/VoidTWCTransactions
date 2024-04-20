'Title:         TW Inventory Data Tier
'Date:          11-27-14
'Author:        Terry Holmes

'Description:   This is the data tier for the whole application

Option Strict On

Public Class TWInventoryDataTier

    'Setting up the modular variables
    Private aBOMPartsDataSetTableAdapter As BOMPartsDataSetTableAdapters.BOMPartsTableAdapter
    Private aBOMPartsDataSet As BOMPartsDataSet

    Private aInventoryDataSetTableAdapter As InventoryDataSetTableAdapters.InventoryTableAdapter
    Private aInventoryDataSet As InventoryDataSet

    Private aIssuedPartsDataSetTableAdapter As IssuedPartsDataSetTableAdapters.IssuedPartsTableAdapter
    Private aIssuedPartsDataSet As New IssuedPartsDataSet

    Private aReceivedPartsDataSetTableAdapter As ReceivedPartsDataSetTableAdapters.ReceivedPartsTableAdapter
    Private aReceivedPartsDataSet As New ReceivedPartsDataSet

    Private aWarehouseInventoryDataSetTableAdapter As WarehouseInventoryDataSetTableAdapters.WarehouseInventoryTableAdapter
    Private aWarehouseInventoryDataSet As New WarehouseInventoryDataSet



    Public Function GetWarehouseInventoryInformation() As WarehouseInventoryDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aWarehouseInventoryDataSet = New WarehouseInventoryDataSet
            aWarehouseInventoryDataSetTableAdapter = New WarehouseInventoryDataSetTableAdapters.WarehouseInventoryTableAdapter
            aWarehouseInventoryDataSetTableAdapter.Fill(aWarehouseInventoryDataSet.WarehouseInventory)
            Return aWarehouseInventoryDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aWarehouseInventoryDataSet

        End Try

    End Function
    Public Sub UpdateWarehouseInventoryDB(ByVal aWarehouseInventoryDataSet As WarehouseInventoryDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aWarehouseInventoryDataSetTableAdapter.Update(aWarehouseInventoryDataSet.WarehouseInventory)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetReceivedPartsInformation() As ReceivedPartsDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aReceivedPartsDataSet = New ReceivedPartsDataSet
            aReceivedPartsDataSetTableAdapter = New ReceivedPartsDataSetTableAdapters.ReceivedPartsTableAdapter
            aReceivedPartsDataSetTableAdapter.Fill(aReceivedPartsDataSet.ReceivedParts)
            Return aReceivedPartsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aReceivedPartsDataSet

        End Try

    End Function
    Public Sub UpdateReceivedPartsDB(ByVal aReceivedPartsDataSet As ReceivedPartsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aReceivedPartsDataSetTableAdapter.Update(aReceivedPartsDataSet.ReceivedParts)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetIssuedPartsInformation() As IssuedPartsDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aIssuedPartsDataSet = New IssuedPartsDataSet
            aIssuedPartsDataSetTableAdapter = New IssuedPartsDataSetTableAdapters.IssuedPartsTableAdapter
            aIssuedPartsDataSetTableAdapter.Fill(aIssuedPartsDataSet.IssuedParts)
            Return aIssuedPartsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aIssuedPartsDataSet

        End Try

    End Function
    Public Sub UpdateIssuedPartsDB(ByVal aIssuedPartsDataSet As IssuedPartsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aIssuedPartsDataSetTableAdapter.Update(aIssuedPartsDataSet.IssuedParts)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetInventoryInformation() As InventoryDataSet

        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aInventoryDataSet = New InventoryDataSet
            aInventoryDataSetTableAdapter = New InventoryDataSetTableAdapters.InventoryTableAdapter
            aInventoryDataSetTableAdapter.Fill(aInventoryDataSet.Inventory)
            Return aInventoryDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aInventoryDataSet

        End Try

    End Function
    Public Sub UpdateInventoryDB(ByVal aInventoryDataSet As InventoryDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aInventoryDataSetTableAdapter.Update(aInventoryDataSet.Inventory)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    
    Public Function GetBOMPartsInformation() As BOMPartsDataSet

        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aBOMPartsDataSet = New BOMPartsDataSet
            aBOMPartsDataSetTableAdapter = New BOMPartsDataSetTableAdapters.BOMPartsTableAdapter
            aBOMPartsDataSetTableAdapter.Fill(aBOMPartsDataSet.BOMParts)
            Return aBOMPartsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aBOMPartsDataSet

        End Try

    End Function
    Public Sub UpdateBOMPartsDB(ByVal aBOMPartsDataSet As BOMPartsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aBOMPartsDataSetTableAdapter.Update(aBOMPartsDataSet.BOMParts)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class
