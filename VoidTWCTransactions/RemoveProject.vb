'Title:         Remove Project
'Date:          3-31-15
'Author:        Terry Holmes

'Description:   This form is used to remove a project

Option Strict On

Public Class RemoveProject

    'Setting up global variables
    Private TheInternalProjectsDataSet As InternalProjectsDataSet
    Private TheInternalProjectsDataTier As InternalProjectsDataTier
    Private WithEvents TheInternalProjectsBindingSource As BindingSource

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Dim TheInputDataValidation As New InputDataValidation

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub

    Private Sub RemoveProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Loading the Project bindings
        'try catch for exceptions
        Try

            'Setting up the data variables
            TheInternalProjectsDataTier = New InternalProjectsDataTier
            TheInternalProjectsDataSet = TheInternalProjectsDataTier.GetInternalProjectsInformation
            TheInternalProjectsBindingSource = New BindingSource

            'setting up the binding source
            With TheInternalProjectsBindingSource
                .DataSource = TheInternalProjectsDataSet
                .DataMember = "internalprojects"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboProjectID
                .DataSource = TheInternalProjectsBindingSource
                .DisplayMember = "internalProjectID"
                DataBindings.Add("text", TheInternalProjectsBindingSource, "internalProjectID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtProjectName.DataBindings.Add("text", TheInternalProjectsBindingSource, "ProjectName")
            txtTWCProjectID.DataBindings.Add("text", TheInternalProjectsBindingSource, "TWCControlNumber")

        Catch ex As Exception

            'Message to user
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        'this will display the main menu
        LastTransaction.Show()
        Form1.Show()
        Me.Close()

    End Sub
    Private Sub btnFindProjectID_Click(sender As Object, e As EventArgs) Handles btnFindProjectID.Click

        'This will run the sub routine
        FindSelectedIndex()

    End Sub
    Public Sub DuplicTWProjectFound()

        'This will rerun the sub routine
        FindSelectedIndex()

    End Sub
    Private Sub FindAllTransactions()

    End Sub
    Private Sub FindSelectedIndex()

        'This will find the Project ID
        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intNumberOfProjects As Integer = 0
        Dim intSelectedIndex As Integer
        Dim intProjectIDForSearch As Integer
        Dim intProjectIDFromTable As Integer
        Dim blnFatalError As Boolean = False
        Dim blnItemNotFound As Boolean = True
        Dim blnItemNotInteger As Boolean = False
        Dim strProjectIDForSearch As String
        Dim strProjectIDFromTable As String
        Dim blnSearchNotFound As Boolean

        'validating the information
        strProjectIDForSearch = txtFindProjectID.Text
        blnFatalError = TheInputDataValidation.VerifyTextData(strProjectIDForSearch)

        'Output to user
        If blnFatalError = True Then
            MessageBox.Show(Logon.mstrErrorMessage, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'determining if input is an integer
        blnItemNotInteger = TheInputDataValidation.VerifyData(strProjectIDForSearch)

        'Setting up for the loop
        intNumberOfRecords = cboProjectID.Items.Count - 1
        strProjectIDForSearch = txtFindProjectID.Text
        If blnItemNotInteger = False Then
            intProjectIDForSearch = CInt(txtFindProjectID.Text)
        End If

        'Performing loop
        For intCounter = 0 To intNumberOfRecords

            'incrementing the combo box
            cboProjectID.SelectedIndex = intCounter
            blnSearchNotFound = True

            'If statement if the project is an integer
            If blnItemNotInteger = False Then
                intProjectIDFromTable = CInt(cboProjectID.Text)
                If intProjectIDForSearch = intProjectIDFromTable Then
                    intSelectedIndex = intCounter
                    intNumberOfProjects += 1
                    blnItemNotFound = False
                    blnSearchNotFound = False
                End If
            End If
            If blnSearchNotFound = True Then
                strProjectIDFromTable = txtTWCProjectID.Text
                If strProjectIDForSearch = strProjectIDFromTable Then
                    intSelectedIndex = intCounter
                    intNumberOfProjects += 1
                    blnItemNotFound = False
                End If
            End If

        Next

        If blnItemNotFound = True Then
            txtFindProjectID.Text = ""
            MessageBox.Show("Project Entered Not Found", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If intNumberOfProjects = 1 Then
            cboProjectID.SelectedIndex = intSelectedIndex
            FindAllTransactions()
        ElseIf intNumberOfProjects > 1 Then
            Logon.mstrTWProjectID = strProjectIDForSearch
            DuplicateProjectFound.ShowDialog()
        End If


    End Sub
End Class