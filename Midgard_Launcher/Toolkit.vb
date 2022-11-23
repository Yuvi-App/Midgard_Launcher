Imports System.IO
Imports System.Security.Cryptography

Public Class Toolkit
    Private Sub btnInsertText_Click(sender As Object, e As EventArgs) Handles btnInsertText.Click
        Dim TextSectionOffset = &H181000
        Dim DataSectionOffset = &H400000
        Dim Data2SectionOffset = &H18DC000
        Dim PointerTableOffset = &H16CDB4

        Dim FileLine = File.ReadAllLines("midgard.exe.po")
        Dim LineCount = 0
        Dim NewEXEFile = Form1.GlobalVariables.Game_Dir & "Midgard_New.exe"
        Dim JPSTRING As String

        Dim Listofin32ZeroedString As New List(Of String) From {
            "ここまで下りて来られた者は久しぶりだ‥‥", "艪ﾍさらなる深みで汝を待とう‥‥", "ふむ‥‥我を二度も退けるとは‥‥", "これならば、我が悲願も叶うやも知れぬ",
            "遙かなる高きに、主は住み給う‥‥だが‥‥", "良かろう‥試練を受けよ！そしてかの地へと来たれ！", "よくぞ、ここまで来た", "我らは、この地にて古の神々を招こうとした", "だが‥‥現れたものは‥‥",
            "我らが招きしもの‥‥我が国を滅ぼしたもの‥‥", "それは、我が命と引き替えに封印されん‥‥", "この呪われし生‥‥それは、我に与えられし罰なのだ", "だが‥‥もはやそれも‥‥", "よくぞ我を越えた‥‥汝に我が最後の願いを‥‥",
            "我にもはや、封印を支える力はなし‥‥", "どうか、あの忌まわしき存在を‥‥", "名前を入力して下さい", "よろしいですか？", "体力と魔力が全快しました", "ﾌてるアイテムを選んで下さい", "本当に捨てても良いのですか？",
            "いらっしゃいませ。どんなご用ですか？", "どれを調べましょう？", "鑑定が必要な物はないようですよ？", "職業を変えるのかい？", "レベルアップしました", "無事にお戻りになられるよう祈っております", "気をつけて行きな",
            "何かお買い求めになりますか？", "何かお売りになりますか？", "おいおい、それは今のお前さんの職業じゃないか", "戦士だな。剣が得意で戦いには有利だぞ", "僧侶だ。神のご加護があるのか知らんが、守りが堅い",
            "盗賊か。とにかくすばしっこいからなぁ", "着替えるんなら、上の部屋を使いな", "%sを使いますか？", "あー‥‥いや、何でもない‥‥", "今、ここで使うものではないようだ", "すでにあるセーブデータが消されますがよろしいですか？",
            "ミッドガルドのゲームCDをCD-ROMに入れて下さい", "データが保存されない可能性がありますが、良いですか？", "ここで何か捨てることはできません", "透明な壁に阻まれている！", "扉は固く閉じられていて、開けることができない"
        }

        Dim ListofMultiTextPointers As New List(Of Long) From {&H16CEA0, &H16CEB0, &H16CEC0, &H16CED0, &H16CEE0, &H16CEF4, &H16CF04}

        If File.Exists(NewEXEFile) Then
            File.Delete(NewEXEFile)
            File.Copy(Form1.GlobalVariables.Game_Dir & "Midgard.exe", NewEXEFile)
        Else
            File.Copy(Form1.GlobalVariables.Game_Dir & "Midgard.exe", NewEXEFile)
        End If

        For Each f In FileLine
            If f.Contains("msgid """) And LineCount > 5 Then
                JPSTRING = f.Split("msgid """)(1).Replace("""", "")

            ElseIf f.Contains("msgstr """) And LineCount > 5 Then
                Dim FoundString = f.Split("msgstr """)(1).Replace("""", "")
                Dim StringBA = System.Text.Encoding.UTF8.GetBytes(FoundString)
                Dim ZeroInt16 As Int16 = 0
                Using bw As BinaryWriter = New BinaryWriter(File.Open(NewEXEFile, FileMode.Open))
                    bw.BaseStream.Seek(TextSectionOffset, SeekOrigin.Begin)
                    bw.Write(StringBA)
                    bw.Write(ZeroInt16)
                    Dim NewPointerLocation = BitConverter.GetBytes(Data2SectionOffset + TextSectionOffset)
                    TextSectionOffset = bw.BaseStream.Position

                    'Write Pointer 
                    bw.BaseStream.Seek(PointerTableOffset, SeekOrigin.Begin)
                    If ListofMultiTextPointers.Contains(bw.BaseStream.Position) Then
                        Select Case bw.BaseStream.Position
                            Case &H16CEA0
                                Dim bytes2write As Byte() = {&HC, &HED, &HA4, &H1}
                                bw.Write(bytes2write)
                            Case &H16CEB0
                                Dim bytes2write As Byte() = {&H10, &HED, &HA4, &H1}
                                bw.Write(bytes2write)
                            Case &H16CEC0
                                Dim bytes2write As Byte() = {&H14, &HED, &HA4, &H1}
                                bw.Write(bytes2write)
                            Case &H16CED0
                                Dim bytes2write As Byte() = {&H18, &HED, &HA4, &H1}
                                bw.Write(bytes2write)
                            Case &H16CEE0
                                Dim bytes2write As Byte() = {&H1C, &HED, &HA4, &H1}
                                bw.Write(bytes2write)
                            Case &H16CEF4
                                Dim bytes2write As Byte() = {&H20, &HED, &HA4, &H1}
                                bw.Write(bytes2write)
                            Case &H16CF04
                                Dim bytes2write As Byte() = {&H24, &HED, &HA4, &H1}
                                bw.Write(bytes2write)
                        End Select
                    End If
                    bw.Write(NewPointerLocation)
                    PointerTableOffset = bw.BaseStream.Position
                End Using
            End If
            LineCount = LineCount + 1
        Next
        MessageBox.Show("Inserted Script and Created EXE")
    End Sub
    Private Sub btnExtractGameData_Click(sender As Object, e As EventArgs) Handles btnExtractGameData.Click
        Dim GameDataFile = Form1.GlobalVariables.Game_Dir & "Game00.dat"
        Dim myFile As New FileInfo(GameDataFile)
        Dim GameDataLegth As Long = myFile.Length
        Dim FileHeader As Int32 = 23108
        Dim Unknown As Int32 = 36
        Dim FileStartOffsetBA
        Dim FileLegthBA
        Dim FileStartOffsetINT
        Dim FileLegthINT

        Using br As BinaryReader = New BinaryReader(File.Open(GameDataFile, FileMode.Open))
            br.ReadInt32()
            Dim FoundFilenameString As String
            While True
                'Read Unknown byte
                br.ReadInt32()

                'Get FileStart Offset
                FileStartOffsetBA = br.ReadBytes(4)
                FileStartOffsetINT = BitConverter.ToInt32(FileStartOffsetBA, 0)

                'Get File Legth
                FileLegthBA = br.ReadBytes(4)
                FileLegthINT = BitConverter.ToInt32(FileLegthBA, 0)

                'Start Getting  filepath/name
                Dim Readbyte = br.ReadByte
                While Readbyte <> 0
                    FoundFilenameString = FoundFilenameString + Convert.ToChar(Readbyte)
                    Readbyte = br.ReadByte
                End While
                Dim LastPosition = br.BaseStream.Position

                'Create Folder if needed
                Dim Directories = FoundFilenameString.Split("\")
                Dim JoinFullDir
                Dim ExportDir
                Dim FileName
                Dim FullOutputPath
                If Directories.Length = 3 Then
                    JoinFullDir = Directories(0) & "\" & Directories(1)
                    ExportDir = "Export\" & JoinFullDir
                    FileName = Directories(2)
                    FullOutputPath = ExportDir & "\" & FileName
                ElseIf Directories.Length = 2 Then
                    JoinFullDir = Directories(0)
                    ExportDir = "Export\" & JoinFullDir
                    FileName = Directories(1)
                    FullOutputPath = ExportDir & "\" & FileName
                ElseIf Directories.Length = 1 Then
                    JoinFullDir = Directories(0)
                    ExportDir = "Export\"
                    FileName = Directories(0)
                    FullOutputPath = ExportDir & "\" & FileName
                End If

                If Directory.Exists(ExportDir) = False Then
                    Directory.CreateDirectory(ExportDir)
                End If

                'Get File
                br.BaseStream.Seek(FileStartOffsetINT, SeekOrigin.Begin)
                Dim FileBA As Byte() = br.ReadBytes(FileLegthINT)
                If File.Exists(FullOutputPath) = True Then
                    File.Delete(FullOutputPath)
                End If
                Using bw As BinaryWriter = New BinaryWriter(File.Open(FullOutputPath, FileMode.Create))
                    bw.Write(FileBA)
                End Using
                br.BaseStream.Seek(LastPosition, SeekOrigin.Begin)
                FoundFilenameString = ""

                If FileName = "status.dat" Then
                    Exit While
                End If
            End While
            MessageBox.Show("Export Files Successfully")
        End Using
    End Sub
End Class