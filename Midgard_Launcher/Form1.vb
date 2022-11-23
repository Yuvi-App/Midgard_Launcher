Imports System.IO
Imports Microsoft.Win32

Public Class Form1
    Dim MLConfig = "ml.config"
    Dim ML_Game_Exe As String
    Dim ML_Game_Dir As String
    Dim ML_Game_BMP_Dir As String
    Dim Ml_Debug
    Dim UseUpscaledBG

    'Button Stuff
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupAdditonalREGKeys()
        GetLauncherConfig()
        GetCurrentConfig()
    End Sub
    Private Sub btnResetConfig_Click(sender As Object, e As EventArgs) Handles btnResetConfig.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset your Midgard Launcher config?", "Reset?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            File.Delete(MLConfig)
            Application.Restart()
        End If
    End Sub
    Private Sub btnGFXSave_Click(sender As Object, e As EventArgs) Handles btnGFXSave.Click
        Try
            Dim MidgardReg = My.Computer.Registry.CurrentUser.OpenSubKey("Software\BAROQUE\Midgard\Main", True)
            Dim ScreenWidth
            Dim ScreenHeight

            If cbxWindowsMode.Text = "Window" Then
                MidgardReg.SetValue("WindowMode", 1)
            ElseIf cbxWindowsMode.Text = "Fullscreen" Then
                MidgardReg.SetValue("WindowMode", 0)
            End If

            Select Case cbxScreenRes.Text
                Case "640x480"
                    MidgardReg.SetValue("ScreenWidth", 640)
                    MidgardReg.SetValue("ScreenHeight", 480)
                    ScreenWidth = 640
                    ScreenHeight = 480
                Case "800x600"
                    MidgardReg.SetValue("ScreenWidth", 800)
                    MidgardReg.SetValue("ScreenHeight", 600)
                    ScreenWidth = 800
                    ScreenHeight = 600
                Case "1024x768"
                    MidgardReg.SetValue("ScreenWidth", 1024)
                    MidgardReg.SetValue("ScreenHeight", 768)
                    ScreenWidth = 1024
                    ScreenHeight = 768
                Case "1280x960"
                    MidgardReg.SetValue("ScreenWidth", 1280)
                    MidgardReg.SetValue("ScreenHeight", 960)
                    ScreenWidth = 1280
                    ScreenHeight = 960
                Case "1600x1200"
                    MidgardReg.SetValue("ScreenWidth", 1600)
                    MidgardReg.SetValue("ScreenHeight", 1200)
                    ScreenWidth = 1600
                    ScreenHeight = 1200
                Case "1920x1440"
                    MidgardReg.SetValue("ScreenWidth", 1920)
                    MidgardReg.SetValue("ScreenHeight", 1440)
                    ScreenWidth = 1920
                    ScreenHeight = 1440
            End Select
            'Setup Fixes to Black BG due to Resolutions Changes


            If chkbxAlpha.Checked = True Then
                MidgardReg.SetValue("NoAlpha", 0)
            Else
                MidgardReg.SetValue("NoAlpha", 1)
            End If

            If chkbxDithering.Checked = True Then
                MidgardReg.SetValue("NoDither", 0)
            Else
                MidgardReg.SetValue("NoDither", 1)
            End If

            If chkbxFilter.Checked = True Then
                MidgardReg.SetValue("NoFilter", 0)
            Else
                MidgardReg.SetValue("NoFilter", 1)
            End If

            If chkbxFog.Checked = True Then
                MidgardReg.SetValue("NoFog", 0)
            Else
                MidgardReg.SetValue("NoFog", 1)
            End If

            'Setup/Use Waifu2x/UpscaledBGs
            If chkUpscaledBG.Checked = True Then
                MidgardReg.SetValue("UseUpscaledBG", 1)
            Else
                MidgardReg.SetValue("UseUpscaledBG", 0)
            End If

            MessageBox.Show("Saved Successfully")
            GetCurrentConfig()
        Catch ex As Exception
            MessageBox.Show("Failed to save gfx settings")
        End Try
    End Sub
    Private Sub btnGFXDefault_Click(sender As Object, e As EventArgs) Handles btnGFXDefault.Click
        Try
            Dim MidgardReg = My.Computer.Registry.CurrentUser.OpenSubKey("Software\BAROQUE\Midgard\Main", True)
            MidgardReg.SetValue("WindowMode", 1)
            MidgardReg.SetValue("ScreenHeight", 480)
            MidgardReg.SetValue("ScreenWidth", 640)
            MidgardReg.SetValue("NoAlpha", 0)
            MidgardReg.SetValue("NoDither", 0)
            MidgardReg.SetValue("NoFilter", 0)
            MidgardReg.SetValue("NoFog", 0)
            MidgardReg.SetValue("UseUpscaledBG", 0)

            MessageBox.Show("Set Default Settings Successfully")
            GetCurrentConfig()
        Catch ex As Exception
            MessageBox.Show("Failed to set defaults")
        End Try
    End Sub
    Private Sub btnSNDDefault_Click(sender As Object, e As EventArgs) Handles btnSNDDefault.Click
        Try
            Dim MidgardReg = My.Computer.Registry.CurrentUser.OpenSubKey("Software\BAROQUE\Midgard\Main", True)
            MidgardReg.SetValue("EaxFlag", 0)
            MidgardReg.SetValue("MusicVolume", 100, RegistryValueKind.DWord)
            MidgardReg.SetValue("SoundVolume", 100, RegistryValueKind.DWord)
            MessageBox.Show("Set Default Settings Successfully")
            GetCurrentConfig()
        Catch ex As Exception
            MessageBox.Show("Failed to set to defaults")
        End Try
    End Sub
    Private Sub btnSNDSave_Click(sender As Object, e As EventArgs) Handles btnSNDSave.Click
        Try
            Dim MidgardReg = My.Computer.Registry.CurrentUser.OpenSubKey("Software\BAROQUE\Midgard\Main", True)
            If chkbxUseEAX.Checked = True Then
                MidgardReg.SetValue("EaxFlag", 1)
            Else
                MidgardReg.SetValue("EaxFlag", 0)
            End If
            MidgardReg.SetValue("MusicVolume", Convert.ToInt32(nudMusicVolume.Value), RegistryValueKind.DWord)
            MidgardReg.SetValue("SoundVolume", Convert.ToInt32(nudSEVolume.Value), RegistryValueKind.DWord)
            MessageBox.Show("Saved Successfully")
            GetCurrentConfig()
        Catch ex As Exception
            MessageBox.Show("Failed to Save")
        End Try
    End Sub
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        Process.Start(ML_Game_Exe)
        Application.Exit()
    End Sub

    'Functions
    Public Function PatchGameToEnglish()
        Dim PatchedFiledSize = 1609728
        Dim OGFile As New FileInfo(ML_Game_Exe)
        Dim OGFileSize As Long = OGFile.Length
        If OGFileSize <> PatchedFiledSize Then
            'Insert Function to patch here
        End If
    End Function
    Public Function SetupAdditonalREGKeys()
        Dim RegLoc
        Try
            RegLoc = My.Computer.Registry.CurrentUser.OpenSubKey("Software\BAROQUE\Midgard\Main", True)
        Catch ex As Exception
            MessageBox.Show("Didnt detect midgard registry location.. Please run the game for the first time to initialize registry.")
        End Try

        If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("UseUpscaledBG") Is Nothing Then
            ' Key doesn't exist
            My.Computer.Registry.CurrentUser.CreateSubKey("UseUpscaledBG", True)
            RegLoc.SetValue("UseUpscaledBG", 0)
        End If
    End Function
    Public Function GetLauncherConfig()
        'Launcher Config
        If File.Exists(MLConfig) = False Then
            MessageBox.Show("Failed to find config, Please select Midgard.exe from the installed directory.")
            If ofdMidgardEXE.ShowDialog = DialogResult.OK Then
                If ofdMidgardEXE.FileName.ToLower.Contains("midgard") Then
                    ML_Game_Exe = ofdMidgardEXE.FileName
                    Dim fi As New FileInfo(ML_Game_Exe)
                    ML_Game_Dir = fi.DirectoryName & "\"
                    txtGameDIR.Text = ML_Game_Dir
                    txtGameEXE.Text = ML_Game_Exe
                    ML_Game_BMP_Dir = ML_Game_Dir & "Bitmap"
                    GlobalVariables.Game_Dir = ML_Game_Dir
                    GlobalVariables.Save_Dir = ML_Game_Dir & "Backup_Saves"
                End If
            End If
            Using sw As StreamWriter = New StreamWriter(File.Open(MLConfig, FileMode.Create))
                sw.WriteLine("---MIDGARD LAUNCHER CONFIG---")
                sw.WriteLine("Game_EXE = " & ML_Game_Exe)
                sw.WriteLine("Game_Directory = " & ML_Game_Dir)
            End Using
        ElseIf File.Exists(MLConfig) = True Then
            Try
                Dim ConfigLines = File.ReadAllLines(MLConfig)
                ML_Game_Exe = ConfigLines(1).Split("=")(1).Trim
                ML_Game_Dir = ConfigLines(2).Split("=")(1).Trim
                Try
                    If ConfigLines(3).ToLower = "true" Then
                        Ml_Debug = True
                    End If
                Catch ex As Exception
                    Ml_Debug = False
                End Try

                txtGameDIR.Text = ML_Game_Dir
                txtGameEXE.Text = ML_Game_Exe
                ML_Game_BMP_Dir = ML_Game_Dir & "Bitmap"
                GlobalVariables.Game_Dir = ML_Game_Dir
                GlobalVariables.Save_Dir = ML_Game_Dir & "Backup_Saves"
            Catch ex As Exception
                Dim result As DialogResult = MessageBox.Show("Config seems corrupt, Do you wish to delete and creat a new one?", "Corrupt Config File", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Application.Exit()
                ElseIf result = DialogResult.Yes Then
                    File.Delete(MLConfig)
                    Application.Restart()
                End If
            End Try
        End If
    End Function
    Public Function GetCurrentConfig()
        'Controls
        Try
            Dim ButtonAttack = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ButtonAttack", Nothing)
            Dim ButtonDash = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ButtonDash", Nothing)
            Dim ButtonItem = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ButtonItem", Nothing)
            Dim ButtonMap = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ButtonMap", Nothing)
            Dim ButtonMenu = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ButtonMenu", Nothing)
            Dim ButtonSpecial = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ButtonSpecial", Nothing)
            Dim JoystickName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "JoyStick", Nothing)
            Dim JoystickNo = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "JoyStickNo", Nothing)
            cbxAttack.SelectedIndex = ButtonAttack
            cbxDash.SelectedIndex = ButtonDash
            cbxItem.SelectedIndex = ButtonItem
            cbxMap.SelectedIndex = ButtonMap
            cbxMenu.SelectedIndex = ButtonMenu
            cbxSpecial.SelectedIndex = ButtonSpecial
        Catch ex As Exception
            MessageBox.Show("Failed to get current Control config")
            Exit Function
        End Try

        'Sound
        Try
            Dim EaxFlag = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "EaxFlag", Nothing)
            Dim MusicDevice = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "MusicDevice", Nothing)
            Dim MusicVolume = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "MusicVolume", Nothing)
            Dim SoundVolume = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "SoundVolume", Nothing)

            nudMusicVolume.Value = Convert.ToInt16(MusicVolume)
            nudSEVolume.Value = Convert.ToInt16(SoundVolume)
            If Convert.ToInt16(EaxFlag) = 1 Then
                chkbxUseEAX.Checked = True
            ElseIf Convert.ToInt16(EaxFlag) = 0 Then
                chkbxUseEAX.Checked = False
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to get current Sound config")
            Exit Function
        End Try

        'Graphics
        Try
            Dim WindowMode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "WindowMode", Nothing)
            Dim ScreenHeight = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ScreenHeight", Nothing)
            Dim ScreenWidth = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "ScreenWidth", Nothing)
            Dim NoAlpha = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "NoAlpha", Nothing)
            Dim NoDither = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "NoDither", Nothing)
            Dim NoFilter = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "NoFilter", Nothing)
            Dim NoFog = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "NoFog", Nothing)
            Dim UpscaledBG = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\BAROQUE\Midgard\Main", "UseUpscaledBG", Nothing)

            If NoAlpha = 0 Then
                chkbxAlpha.Checked = True
            ElseIf NoAlpha = 1 Then
                chkbxAlpha.Checked = False
            End If

            If NoDither = 0 Then
                chkbxDithering.Checked = True
            ElseIf NoDither = 1 Then
                chkbxDithering.Checked = False
            End If

            If NoFilter = 0 Then
                chkbxFilter.Checked = True
            ElseIf NoFilter = 1 Then
                chkbxFilter.Checked = False
            End If

            If NoFog = 0 Then
                chkbxFog.Checked = True
            ElseIf NoFog = 1 Then
                chkbxFog.Checked = False
            End If

            Select Case ScreenWidth
                Case 640
                    cbxScreenRes.SelectedItem = "640x480"
                Case 800
                    cbxScreenRes.SelectedItem = "800x600"
                Case 1024
                    cbxScreenRes.SelectedItem = "1024x768"
                Case 1280
                    cbxScreenRes.SelectedItem = "1280x960"
                Case 1600
                    cbxScreenRes.SelectedItem = "1600x1200"
                Case 1920
                    cbxScreenRes.SelectedItem = "1920x1440"
            End Select

            If WindowMode = 1 Then
                cbxWindowsMode.SelectedItem = "Window"
            ElseIf WindowMode = 0 Then
                cbxWindowsMode.SelectedItem = "Fullscreen"
            End If

            If UpscaledBG = 1 Then
                chkUpscaledBG.Checked = True
            ElseIf UpscaledBG = 0 Then
                chkUpscaledBG.Checked = False
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to get current Graphics config")
            Exit Function
        End Try
    End Function
    Public Function FixBMPforResolution(ByVal ScreenWidth As Int16, ByVal ScreenHeight As Int16)
        Dim ResizableBMPList As New List(Of String) From {"c2d640.bmp", "church640.bmp", "d1_640.bmp", "d2c640.bmp", "d2t640.bmp", "d2_640.bmp", "d3_640.bmp", "dragon640.bmp", "dress640.bmp",
    "d_create640.bmp", "equip640.bmp", "inn640.bmp", "job00a_640.bmp", "job00b_640.bmp", "job00_640.bmp", "job01a_640.bmp", "job01b_640.bmp", "job01_640.bmp", "job02a_640.bmp", "job02b_640.bmp",
    "job02_640.bmp", "job03a_640.bmp", "job03b_640.bmp", "job03_640.bmp", "job04a_640.bmp", "job04b_640.bmp", "job04_640.bmp", "last640.bmp", "t2_640.bmp", "t3_640.bmp", "t4_640.bmp",
    "tool640.bmp", "tower640.bmp", "t_create640.bmp"}
        If Not ScreenWidth = 640 Then
            Dim BackupDest = ML_Game_BMP_Dir & "\Original\"
            If Directory.Exists(BackupDest) = False Then
                Directory.CreateDirectory(BackupDest)
            End If

            For Each I In Directory.GetFiles(ML_Game_BMP_Dir)
                Using bmp As New Bitmap(I)
                    If bmp.Width = ScreenWidth Then
                        Exit For
                    End If
                End Using

                If ResizableBMPList.Contains(Path.GetFileName(I.ToLower)) Then
                    If File.Exists(I & ".new") = True Then
                        File.Delete(I & ".new")
                    End If

                    Using img As Bitmap = Image.FromFile(I)
                        Using resizedImg As New Bitmap(img, ScreenWidth, ScreenHeight)
                            resizedImg.Save(I & ".new", Imaging.ImageFormat.Bmp)
                        End Using
                    End Using

                    If File.Exists(BackupDest & Path.GetFileName(I)) = False Then
                        File.Copy(I, BackupDest & Path.GetFileName(I))
                    End If
                    File.Delete(I)
                    FileSystem.Rename(I & ".new", I)
                End If
            Next
        End If
    End Function
    Public Class GlobalVariables
        Public Shared Game_Dir As String
        Public Shared Save_Dir As String
    End Class
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveData.Show()
    End Sub

    'Insertion Tool Stuff
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        If Ml_Debug = True Then
            Toolkit.Show()
        End If
    End Sub
End Class
