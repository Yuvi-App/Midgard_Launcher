<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveData
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
        Me.lbxSaveData = New System.Windows.Forms.ListBox()
        Me.btnBackupCurrentSave = New System.Windows.Forms.Button()
        Me.btnRestoreSelectedSave = New System.Windows.Forms.Button()
        Me.btnDeleteSelectedSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxSaveData
        '
        Me.lbxSaveData.FormattingEnabled = True
        Me.lbxSaveData.ItemHeight = 15
        Me.lbxSaveData.Location = New System.Drawing.Point(12, 12)
        Me.lbxSaveData.Name = "lbxSaveData"
        Me.lbxSaveData.Size = New System.Drawing.Size(236, 274)
        Me.lbxSaveData.TabIndex = 0
        '
        'btnBackupCurrentSave
        '
        Me.btnBackupCurrentSave.Location = New System.Drawing.Point(254, 12)
        Me.btnBackupCurrentSave.Name = "btnBackupCurrentSave"
        Me.btnBackupCurrentSave.Size = New System.Drawing.Size(159, 23)
        Me.btnBackupCurrentSave.TabIndex = 1
        Me.btnBackupCurrentSave.Text = "Backup Current Save"
        Me.btnBackupCurrentSave.UseVisualStyleBackColor = True
        '
        'btnRestoreSelectedSave
        '
        Me.btnRestoreSelectedSave.Location = New System.Drawing.Point(254, 41)
        Me.btnRestoreSelectedSave.Name = "btnRestoreSelectedSave"
        Me.btnRestoreSelectedSave.Size = New System.Drawing.Size(159, 23)
        Me.btnRestoreSelectedSave.TabIndex = 2
        Me.btnRestoreSelectedSave.Text = "Restore Selected Save"
        Me.btnRestoreSelectedSave.UseVisualStyleBackColor = True
        '
        'btnDeleteSelectedSave
        '
        Me.btnDeleteSelectedSave.Location = New System.Drawing.Point(254, 263)
        Me.btnDeleteSelectedSave.Name = "btnDeleteSelectedSave"
        Me.btnDeleteSelectedSave.Size = New System.Drawing.Size(159, 23)
        Me.btnDeleteSelectedSave.TabIndex = 3
        Me.btnDeleteSelectedSave.Text = "Delete Selected Save"
        Me.btnDeleteSelectedSave.UseVisualStyleBackColor = True
        '
        'SaveData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 298)
        Me.Controls.Add(Me.btnDeleteSelectedSave)
        Me.Controls.Add(Me.btnRestoreSelectedSave)
        Me.Controls.Add(Me.btnBackupCurrentSave)
        Me.Controls.Add(Me.lbxSaveData)
        Me.Name = "SaveData"
        Me.Text = "SaveData"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxSaveData As ListBox
    Friend WithEvents btnBackupCurrentSave As Button
    Friend WithEvents btnRestoreSelectedSave As Button
    Friend WithEvents btnDeleteSelectedSave As Button
End Class
