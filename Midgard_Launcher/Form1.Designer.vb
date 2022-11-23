<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbxMenu = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxMap = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxItem = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxDash = New System.Windows.Forms.ComboBox()
        Me.cbxSpecial = New System.Windows.Forms.ComboBox()
        Me.cbxAttack = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSNDDefault = New System.Windows.Forms.Button()
        Me.btnSNDSave = New System.Windows.Forms.Button()
        Me.chkbxUseEAX = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudMusicVolume = New System.Windows.Forms.NumericUpDown()
        Me.nudSEVolume = New System.Windows.Forms.NumericUpDown()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkUpscaledBG = New System.Windows.Forms.CheckBox()
        Me.btnGFXDefault = New System.Windows.Forms.Button()
        Me.btnGFXSave = New System.Windows.Forms.Button()
        Me.chkbxFog = New System.Windows.Forms.CheckBox()
        Me.chkbxFilter = New System.Windows.Forms.CheckBox()
        Me.chkbxDithering = New System.Windows.Forms.CheckBox()
        Me.chkbxAlpha = New System.Windows.Forms.CheckBox()
        Me.cbxScreenRes = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxWindowsMode = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnResetConfig = New System.Windows.Forms.Button()
        Me.txtGameEXE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtGameDIR = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ofdMidgardEXE = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.nudMusicVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSEVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Midgard"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 67)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Manage Save Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnStartGame
        '
        Me.btnStartGame.Location = New System.Drawing.Point(16, 70)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(103, 67)
        Me.btnStartGame.TabIndex = 4
        Me.btnStartGame.Text = "Launch Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(6, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(249, 237)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbxMenu)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cbxMap)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cbxItem)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbxDash)
        Me.TabPage1.Controls.Add(Me.cbxSpecial)
        Me.TabPage1.Controls.Add(Me.cbxAttack)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(241, 209)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbxMenu
        '
        Me.cbxMenu.FormattingEnabled = True
        Me.cbxMenu.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cbxMenu.Location = New System.Drawing.Point(105, 162)
        Me.cbxMenu.Name = "cbxMenu"
        Me.cbxMenu.Size = New System.Drawing.Size(121, 23)
        Me.cbxMenu.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dash/Run"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Map Display"
        '
        'cbxMap
        '
        Me.cbxMap.FormattingEnabled = True
        Me.cbxMap.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cbxMap.Location = New System.Drawing.Point(105, 133)
        Me.cbxMap.Name = "cbxMap"
        Me.cbxMap.Size = New System.Drawing.Size(121, 23)
        Me.cbxMap.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Item Menu"
        '
        'cbxItem
        '
        Me.cbxItem.FormattingEnabled = True
        Me.cbxItem.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cbxItem.Location = New System.Drawing.Point(105, 104)
        Me.cbxItem.Name = "cbxItem"
        Me.cbxItem.Size = New System.Drawing.Size(121, 23)
        Me.cbxItem.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Special/Magic"
        '
        'cbxDash
        '
        Me.cbxDash.FormattingEnabled = True
        Me.cbxDash.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cbxDash.Location = New System.Drawing.Point(105, 75)
        Me.cbxDash.Name = "cbxDash"
        Me.cbxDash.Size = New System.Drawing.Size(121, 23)
        Me.cbxDash.TabIndex = 2
        '
        'cbxSpecial
        '
        Me.cbxSpecial.FormattingEnabled = True
        Me.cbxSpecial.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cbxSpecial.Location = New System.Drawing.Point(105, 46)
        Me.cbxSpecial.Name = "cbxSpecial"
        Me.cbxSpecial.Size = New System.Drawing.Size(121, 23)
        Me.cbxSpecial.TabIndex = 1
        '
        'cbxAttack
        '
        Me.cbxAttack.FormattingEnabled = True
        Me.cbxAttack.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cbxAttack.Location = New System.Drawing.Point(105, 17)
        Me.cbxAttack.Name = "cbxAttack"
        Me.cbxAttack.Size = New System.Drawing.Size(121, 23)
        Me.cbxAttack.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Attack/Select"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnSNDDefault)
        Me.TabPage3.Controls.Add(Me.btnSNDSave)
        Me.TabPage3.Controls.Add(Me.chkbxUseEAX)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.nudMusicVolume)
        Me.TabPage3.Controls.Add(Me.nudSEVolume)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(241, 209)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sound"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnSNDDefault
        '
        Me.btnSNDDefault.Location = New System.Drawing.Point(12, 137)
        Me.btnSNDDefault.Name = "btnSNDDefault"
        Me.btnSNDDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnSNDDefault.TabIndex = 9
        Me.btnSNDDefault.Text = "Default"
        Me.btnSNDDefault.UseVisualStyleBackColor = True
        '
        'btnSNDSave
        '
        Me.btnSNDSave.Location = New System.Drawing.Point(149, 137)
        Me.btnSNDSave.Name = "btnSNDSave"
        Me.btnSNDSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSNDSave.TabIndex = 10
        Me.btnSNDSave.Text = "Save"
        Me.btnSNDSave.UseVisualStyleBackColor = True
        '
        'chkbxUseEAX
        '
        Me.chkbxUseEAX.AutoSize = True
        Me.chkbxUseEAX.Location = New System.Drawing.Point(127, 69)
        Me.chkbxUseEAX.Name = "chkbxUseEAX"
        Me.chkbxUseEAX.Size = New System.Drawing.Size(69, 19)
        Me.chkbxUseEAX.TabIndex = 3
        Me.chkbxUseEAX.Text = "Use EAX"
        Me.chkbxUseEAX.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "SE Volume"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Music Volume"
        '
        'nudMusicVolume
        '
        Me.nudMusicVolume.Location = New System.Drawing.Point(127, 11)
        Me.nudMusicVolume.Name = "nudMusicVolume"
        Me.nudMusicVolume.Size = New System.Drawing.Size(69, 23)
        Me.nudMusicVolume.TabIndex = 0
        '
        'nudSEVolume
        '
        Me.nudSEVolume.Location = New System.Drawing.Point(127, 40)
        Me.nudSEVolume.Name = "nudSEVolume"
        Me.nudSEVolume.Size = New System.Drawing.Size(69, 23)
        Me.nudSEVolume.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkUpscaledBG)
        Me.TabPage2.Controls.Add(Me.btnGFXDefault)
        Me.TabPage2.Controls.Add(Me.btnGFXSave)
        Me.TabPage2.Controls.Add(Me.chkbxFog)
        Me.TabPage2.Controls.Add(Me.chkbxFilter)
        Me.TabPage2.Controls.Add(Me.chkbxDithering)
        Me.TabPage2.Controls.Add(Me.chkbxAlpha)
        Me.TabPage2.Controls.Add(Me.cbxScreenRes)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.cbxWindowsMode)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(241, 209)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Graphics"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkUpscaledBG
        '
        Me.chkUpscaledBG.AutoSize = True
        Me.chkUpscaledBG.Enabled = False
        Me.chkUpscaledBG.Location = New System.Drawing.Point(17, 139)
        Me.chkUpscaledBG.Name = "chkUpscaledBG"
        Me.chkUpscaledBG.Size = New System.Drawing.Size(97, 19)
        Me.chkUpscaledBG.TabIndex = 9
        Me.chkUpscaledBG.Text = "Upscaled BGs"
        Me.chkUpscaledBG.UseVisualStyleBackColor = True
        '
        'btnGFXDefault
        '
        Me.btnGFXDefault.Location = New System.Drawing.Point(13, 170)
        Me.btnGFXDefault.Name = "btnGFXDefault"
        Me.btnGFXDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnGFXDefault.TabIndex = 8
        Me.btnGFXDefault.Text = "Default"
        Me.btnGFXDefault.UseVisualStyleBackColor = True
        '
        'btnGFXSave
        '
        Me.btnGFXSave.Location = New System.Drawing.Point(149, 170)
        Me.btnGFXSave.Name = "btnGFXSave"
        Me.btnGFXSave.Size = New System.Drawing.Size(75, 23)
        Me.btnGFXSave.TabIndex = 8
        Me.btnGFXSave.Text = "Save"
        Me.btnGFXSave.UseVisualStyleBackColor = True
        '
        'chkbxFog
        '
        Me.chkbxFog.AutoSize = True
        Me.chkbxFog.Location = New System.Drawing.Point(137, 114)
        Me.chkbxFog.Name = "chkbxFog"
        Me.chkbxFog.Size = New System.Drawing.Size(79, 19)
        Me.chkbxFog.TabIndex = 7
        Me.chkbxFog.Text = "Fog Effect"
        Me.chkbxFog.UseVisualStyleBackColor = True
        '
        'chkbxFilter
        '
        Me.chkbxFilter.AutoSize = True
        Me.chkbxFilter.Location = New System.Drawing.Point(17, 114)
        Me.chkbxFilter.Name = "chkbxFilter"
        Me.chkbxFilter.Size = New System.Drawing.Size(90, 19)
        Me.chkbxFilter.TabIndex = 6
        Me.chkbxFilter.Text = "Bloom Filter"
        Me.chkbxFilter.UseVisualStyleBackColor = True
        '
        'chkbxDithering
        '
        Me.chkbxDithering.AutoSize = True
        Me.chkbxDithering.Location = New System.Drawing.Point(137, 89)
        Me.chkbxDithering.Name = "chkbxDithering"
        Me.chkbxDithering.Size = New System.Drawing.Size(75, 19)
        Me.chkbxDithering.TabIndex = 5
        Me.chkbxDithering.Text = "Dithering"
        Me.chkbxDithering.UseVisualStyleBackColor = True
        '
        'chkbxAlpha
        '
        Me.chkbxAlpha.AutoSize = True
        Me.chkbxAlpha.Location = New System.Drawing.Point(17, 89)
        Me.chkbxAlpha.Name = "chkbxAlpha"
        Me.chkbxAlpha.Size = New System.Drawing.Size(95, 19)
        Me.chkbxAlpha.TabIndex = 4
        Me.chkbxAlpha.Text = "Alpha Effects"
        Me.chkbxAlpha.UseVisualStyleBackColor = True
        '
        'cbxScreenRes
        '
        Me.cbxScreenRes.FormattingEnabled = True
        Me.cbxScreenRes.Items.AddRange(New Object() {"640x480", "800x600", "1024x768", "1280x960", "1600x1200", "1920x1440"})
        Me.cbxScreenRes.Location = New System.Drawing.Point(101, 45)
        Me.cbxScreenRes.Name = "cbxScreenRes"
        Me.cbxScreenRes.Size = New System.Drawing.Size(121, 23)
        Me.cbxScreenRes.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Resolution (4:3)"
        '
        'cbxWindowsMode
        '
        Me.cbxWindowsMode.FormattingEnabled = True
        Me.cbxWindowsMode.Items.AddRange(New Object() {"Window", "Fullscreen"})
        Me.cbxWindowsMode.Location = New System.Drawing.Point(101, 16)
        Me.cbxWindowsMode.Name = "cbxWindowsMode"
        Me.cbxWindowsMode.Size = New System.Drawing.Size(121, 23)
        Me.cbxWindowsMode.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Mode"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.btnResetConfig)
        Me.TabPage4.Controls.Add(Me.txtGameEXE)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.txtGameDIR)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(241, 209)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Launcher Config"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(196, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 15)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "- Yuvi"
        '
        'btnResetConfig
        '
        Me.btnResetConfig.Location = New System.Drawing.Point(159, 117)
        Me.btnResetConfig.Name = "btnResetConfig"
        Me.btnResetConfig.Size = New System.Drawing.Size(75, 44)
        Me.btnResetConfig.TabIndex = 4
        Me.btnResetConfig.Text = "Reset Config"
        Me.btnResetConfig.UseVisualStyleBackColor = True
        '
        'txtGameEXE
        '
        Me.txtGameEXE.Location = New System.Drawing.Point(8, 88)
        Me.txtGameEXE.Name = "txtGameEXE"
        Me.txtGameEXE.ReadOnly = True
        Me.txtGameEXE.Size = New System.Drawing.Size(226, 23)
        Me.txtGameEXE.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Game EXE"
        '
        'txtGameDIR
        '
        Me.txtGameDIR.Location = New System.Drawing.Point(8, 29)
        Me.txtGameDIR.Name = "txtGameDIR"
        Me.txtGameDIR.ReadOnly = True
        Me.txtGameDIR.Size = New System.Drawing.Size(226, 23)
        Me.txtGameDIR.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Game Directory"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 271)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell Condensed", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(194, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 22)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Launcher"
        '
        'ofdMidgardEXE
        '
        Me.ofdMidgardEXE.DefaultExt = "exe files (*.exe)|*.exe|All files (*.*)|*.*"
        Me.ofdMidgardEXE.FileName = "OpenFileDialog1"
        Me.ofdMidgardEXE.Title = "Select Midgard.exe"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 420)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Midgard Launcher"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.nudMusicVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSEVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnStartGame As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxMenu As ComboBox
    Friend WithEvents cbxMap As ComboBox
    Friend WithEvents cbxItem As ComboBox
    Friend WithEvents cbxDash As ComboBox
    Friend WithEvents cbxSpecial As ComboBox
    Friend WithEvents cbxAttack As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nudMusicVolume As NumericUpDown
    Friend WithEvents nudSEVolume As NumericUpDown
    Friend WithEvents chkbxUseEAX As CheckBox
    Friend WithEvents cbxWindowsMode As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxScreenRes As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkbxFog As CheckBox
    Friend WithEvents chkbxFilter As CheckBox
    Friend WithEvents chkbxDithering As CheckBox
    Friend WithEvents chkbxAlpha As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ofdMidgardEXE As OpenFileDialog
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtGameEXE As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtGameDIR As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnResetConfig As Button
    Friend WithEvents btnSNDDefault As Button
    Friend WithEvents btnSNDSave As Button
    Friend WithEvents btnGFXDefault As Button
    Friend WithEvents btnGFXSave As Button
    Friend WithEvents chkUpscaledBG As CheckBox
    Friend WithEvents Label16 As Label
End Class
