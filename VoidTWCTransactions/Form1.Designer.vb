<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveProject = New System.Windows.Forms.Button()
        Me.btnVoidReceiveTransactions = New System.Windows.Forms.Button()
        Me.btnVoidPickList = New System.Windows.Forms.Button()
        Me.btnVoidIssuedTransactions = New System.Windows.Forms.Button()
        Me.btnVoidUsedTransactions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(210, 220)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 66)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Void Transactions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemoveProject
        '
        Me.btnRemoveProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProject.Location = New System.Drawing.Point(12, 76)
        Me.btnRemoveProject.Name = "btnRemoveProject"
        Me.btnRemoveProject.Size = New System.Drawing.Size(138, 66)
        Me.btnRemoveProject.TabIndex = 0
        Me.btnRemoveProject.Text = "Remove Project"
        Me.btnRemoveProject.UseVisualStyleBackColor = True
        '
        'btnVoidReceiveTransactions
        '
        Me.btnVoidReceiveTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidReceiveTransactions.Location = New System.Drawing.Point(210, 76)
        Me.btnVoidReceiveTransactions.Name = "btnVoidReceiveTransactions"
        Me.btnVoidReceiveTransactions.Size = New System.Drawing.Size(138, 66)
        Me.btnVoidReceiveTransactions.TabIndex = 1
        Me.btnVoidReceiveTransactions.Text = "Void Receive Transactions"
        Me.btnVoidReceiveTransactions.UseVisualStyleBackColor = True
        '
        'btnVoidPickList
        '
        Me.btnVoidPickList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidPickList.Location = New System.Drawing.Point(12, 148)
        Me.btnVoidPickList.Name = "btnVoidPickList"
        Me.btnVoidPickList.Size = New System.Drawing.Size(138, 66)
        Me.btnVoidPickList.TabIndex = 2
        Me.btnVoidPickList.Text = "Void Pick List"
        Me.btnVoidPickList.UseVisualStyleBackColor = True
        '
        'btnVoidIssuedTransactions
        '
        Me.btnVoidIssuedTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidIssuedTransactions.Location = New System.Drawing.Point(210, 148)
        Me.btnVoidIssuedTransactions.Name = "btnVoidIssuedTransactions"
        Me.btnVoidIssuedTransactions.Size = New System.Drawing.Size(138, 66)
        Me.btnVoidIssuedTransactions.TabIndex = 3
        Me.btnVoidIssuedTransactions.Text = "Void Issued Transactions"
        Me.btnVoidIssuedTransactions.UseVisualStyleBackColor = True
        '
        'btnVoidUsedTransactions
        '
        Me.btnVoidUsedTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidUsedTransactions.Location = New System.Drawing.Point(12, 221)
        Me.btnVoidUsedTransactions.Name = "btnVoidUsedTransactions"
        Me.btnVoidUsedTransactions.Size = New System.Drawing.Size(138, 66)
        Me.btnVoidUsedTransactions.TabIndex = 4
        Me.btnVoidUsedTransactions.Text = "Void Used Transactions"
        Me.btnVoidUsedTransactions.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVoidUsedTransactions)
        Me.Controls.Add(Me.btnVoidIssuedTransactions)
        Me.Controls.Add(Me.btnVoidPickList)
        Me.Controls.Add(Me.btnVoidReceiveTransactions)
        Me.Controls.Add(Me.btnRemoveProject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveProject As System.Windows.Forms.Button
    Friend WithEvents btnVoidReceiveTransactions As System.Windows.Forms.Button
    Friend WithEvents btnVoidPickList As System.Windows.Forms.Button
    Friend WithEvents btnVoidIssuedTransactions As System.Windows.Forms.Button
    Friend WithEvents btnVoidUsedTransactions As System.Windows.Forms.Button

End Class
