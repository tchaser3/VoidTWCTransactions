<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveProject
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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFindProjectID = New System.Windows.Forms.TextBox()
        Me.btnFindProjectID = New System.Windows.Forms.Button()
        Me.cboProjectID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTWCProjectID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(483, 389)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 66)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(483, 317)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(138, 66)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 44)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Remove Project"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter Project ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindProjectID
        '
        Me.txtFindProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFindProjectID.Location = New System.Drawing.Point(275, 93)
        Me.txtFindProjectID.Name = "txtFindProjectID"
        Me.txtFindProjectID.Size = New System.Drawing.Size(100, 20)
        Me.txtFindProjectID.TabIndex = 10
        '
        'btnFindProjectID
        '
        Me.btnFindProjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindProjectID.Location = New System.Drawing.Point(395, 85)
        Me.btnFindProjectID.Name = "btnFindProjectID"
        Me.btnFindProjectID.Size = New System.Drawing.Size(85, 35)
        Me.btnFindProjectID.TabIndex = 11
        Me.btnFindProjectID.Text = "Find"
        Me.btnFindProjectID.UseVisualStyleBackColor = True
        '
        'cboProjectID
        '
        Me.cboProjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProjectID.FormattingEnabled = True
        Me.cboProjectID.Location = New System.Drawing.Point(182, 145)
        Me.cboProjectID.Name = "cboProjectID"
        Me.cboProjectID.Size = New System.Drawing.Size(121, 21)
        Me.cboProjectID.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Enter Project ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTWCProjectID
        '
        Me.txtTWCProjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTWCProjectID.Location = New System.Drawing.Point(182, 172)
        Me.txtTWCProjectID.Name = "txtTWCProjectID"
        Me.txtTWCProjectID.ReadOnly = True
        Me.txtTWCProjectID.Size = New System.Drawing.Size(121, 20)
        Me.txtTWCProjectID.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "TWC Project ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectName
        '
        Me.txtProjectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProjectName.Location = New System.Drawing.Point(182, 198)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.ReadOnly = True
        Me.txtProjectName.Size = New System.Drawing.Size(121, 20)
        Me.txtProjectName.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Project Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemoveProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTWCProjectID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboProjectID)
        Me.Controls.Add(Me.btnFindProjectID)
        Me.Controls.Add(Me.txtFindProjectID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "RemoveProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RemoveProject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFindProjectID As System.Windows.Forms.TextBox
    Friend WithEvents btnFindProjectID As System.Windows.Forms.Button
    Friend WithEvents cboProjectID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTWCProjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
