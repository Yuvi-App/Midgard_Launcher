Imports System.IO

Public Class SaveData
    Dim SavaDataFolder As String = Form1.GlobalVariables.Save_Dir
    Dim GameDirFolder As String = Form1.GlobalVariables.Game_Dir
    Dim CurrentSaveData As String = Form1.GlobalVariables.Game_Dir & "player.dat"

    Private Sub SaveData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(SavaDataFolder) = False Then
            Directory.CreateDirectory(SavaDataFolder)
        End If
        GetCurrentBackedupSaves()
    End Sub

    Private Sub btnBackupCurrentSave_Click(sender As Object, e As EventArgs) Handles btnBackupCurrentSave.Click
        If File.Exists(CurrentSaveData) Then
            Dim result As DialogResult = MessageBox.Show("Do you wish name your current save to backup?", "Choose a name?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Dim FormattedTime = Date.Now.ToString.Replace("/", "_").Replace(" ", "_").Replace(":", ".")
                Dim OutputFile = SavaDataFolder & "\player_" & FormattedTime & ".dat"
                File.Copy(CurrentSaveData, OutputFile)
                If File.Exists(OutputFile) = True Then
                    MessageBox.Show("Backed up save successfully")
                    GetCurrentBackedupSaves()
                Else
                    MessageBox.Show("Failed to Backup ERROR:5")
                End If
            ElseIf result = DialogResult.Yes Then
                Dim FileName = InputBox("Enter name for Save")
                Dim OutputFile = SavaDataFolder & "\" & FileName & ".dat"
                File.Copy(CurrentSaveData, OutputFile)
                If File.Exists(OutputFile) = True Then
                    MessageBox.Show("Backed up save successfully")
                    GetCurrentBackedupSaves()
                Else
                    MessageBox.Show("Failed to Backup ERROR:6")
                End If
            End If
        End If
    End Sub

    Private Sub btnRestoreSelectedSave_Click(sender As Object, e As EventArgs) Handles btnRestoreSelectedSave.Click
        Dim result As DialogResult = MessageBox.Show("Restore Selected (" & lbxSaveData.GetItemText(lbxSaveData.SelectedItem) & ") Save?" & vbNewLine & "Ensure you backup your current save before proceeding", "Restore Save?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim SelectedSaveFilePath = SavaDataFolder & "\" & lbxSaveData.GetItemText(lbxSaveData.SelectedItem) & ".dat"
            If File.Exists(CurrentSaveData) Then
                File.Delete(CurrentSaveData)
                Try
                    File.Copy(SelectedSaveFilePath, CurrentSaveData)
                    If File.Exists(CurrentSaveData) Then
                        MessageBox.Show("Restored save successfully")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Failed to restore save ERROR:7")
                End Try
            Else
                MessageBox.Show("Failed to delete current save ERROR:8")
            End If
        End If
    End Sub

    Private Sub btnDeleteSelectedSave_Click(sender As Object, e As EventArgs) Handles btnDeleteSelectedSave.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you wish to delete this backed up save?", "Delete Save?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim SelectedSaveFilePath = SavaDataFolder & "\" & lbxSaveData.GetItemText(lbxSaveData.SelectedItem) & ".dat"
            File.Delete(SelectedSaveFilePath)
            If File.Exists(SelectedSaveFilePath) = False Then
                GetCurrentBackedupSaves()
            End If
        End If
    End Sub


    Public Function GetCurrentBackedupSaves()
        lbxSaveData.Items.Clear()
        Dim Save_Count = Directory.GetFiles(SavaDataFolder).Count
        If Save_Count = 0 Then
            lbxSaveData.Items.Add("No Backup Saves Found")
        Else
            For Each S In Directory.GetFiles(SavaDataFolder)
                lbxSaveData.Items.Add(Path.GetFileNameWithoutExtension(S))
            Next
        End If
    End Function
End Class