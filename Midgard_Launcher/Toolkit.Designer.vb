<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolkit
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
        Me.btnInsertText = New System.Windows.Forms.Button()
        Me.btnExtractGameData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInsertText
        '
        Me.btnInsertText.Location = New System.Drawing.Point(12, 12)
        Me.btnInsertText.Name = "btnInsertText"
        Me.btnInsertText.Size = New System.Drawing.Size(203, 23)
        Me.btnInsertText.TabIndex = 0
        Me.btnInsertText.Text = "Insert Text from PO"
        Me.btnInsertText.UseVisualStyleBackColor = True
        '
        'btnExtractGameData
        '
        Me.btnExtractGameData.Location = New System.Drawing.Point(12, 41)
        Me.btnExtractGameData.Name = "btnExtractGameData"
        Me.btnExtractGameData.Size = New System.Drawing.Size(203, 23)
        Me.btnExtractGameData.TabIndex = 1
        Me.btnExtractGameData.Text = "Extract GameData"
        Me.btnExtractGameData.UseVisualStyleBackColor = True
        '
        'Toolkit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 302)
        Me.Controls.Add(Me.btnExtractGameData)
        Me.Controls.Add(Me.btnInsertText)
        Me.Name = "Toolkit"
        Me.Text = "Toolkit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInsertText As Button
    Friend WithEvents btnExtractGameData As Button
End Class
