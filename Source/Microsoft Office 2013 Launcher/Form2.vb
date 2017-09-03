Public Class Form2




    Private Sub btn_Apply_Click(sender As System.Object, e As System.EventArgs) Handles btn_Apply.Click
        ApplyChanges()

    End Sub

    Private Sub btn_Restore_Click(sender As System.Object, e As System.EventArgs) Handles btn_Restore.Click
        LoadSettings()

    End Sub

    Sub ApplyChanges()
        'DO Apply Changes
        'Dim s As New My.MySettings
        My.Settings.Access = tb_Access.Text
        My.Settings.Excel = tb_Excel.Text
        My.Settings.OneNote = tb_OneNote.Text
        My.Settings.Outlook = tb_Outlook.Text
        My.Settings.PowerPoint = tb_PowerPoint.Text
        My.Settings.Publisher = tb_Publisher.Text
        My.Settings.UploadCenter = tb_UploadCenter.Text
        My.Settings.Word = tb_Word.Text
        My.Settings.MinOnLaunch = cb_MinOnLaunch.Checked
        My.Settings.OfficeVersion = cob_OfficeVersion.Text.ToString
        Application.Restart()


    End Sub

    Sub LoadSettings()
        'DO Load Settings, used with app load and restore settings
        'Dim s As New My.MySettings
        tb_Access.Text = My.Settings.Access
        tb_Excel.Text = My.Settings.Excel
        tb_OneNote.Text = My.Settings.OneNote
        tb_Outlook.Text = My.Settings.Outlook
        tb_PowerPoint.Text = My.Settings.PowerPoint
        tb_Publisher.Text = My.Settings.Publisher
        tb_UploadCenter.Text = My.Settings.UploadCenter
        tb_Word.Text = My.Settings.Word
        cb_MinOnLaunch.Checked = My.Settings.MinOnLaunch
        cob_OfficeVersion.Text = My.Settings.OfficeVersion

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Refresh()

    End Sub


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadSettings()
        EnableManualEdit()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim word As String
        Dim officeFolder As String


        OpenFileDialog1.Title = " LOCATE MICROSOFT WORD"
        OpenFileDialog1.InitialDirectory = "C:\Program Files\"
        OpenFileDialog1.FileName = "WINWORD.EXE"
        OpenFileDialog1.Filter = "WINWORD.EXE |WINWORD.EXE"
        'OpenFileDialog1.ShowDialog()



        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try

                word = OpenFileDialog1.FileName
                If (word IsNot Nothing) Then
                    ' Insert code to read the stream here.
                    'MsgBox(word)
                    officeFolder = word.Replace("WINWORD.EXE", "")
                    tb_Office.Text = officeFolder
                    AutoLocation(officeFolder)
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            
            End Try
        End If

    End Sub

    Sub AutoLocation(ByVal officeFolder As String)
        Dim f As String = officeFolder

        tb_Access.Text = """" & f.TrimEnd(CChar(CStr(1))) & "MSACCESS.EXE"""
        tb_Excel.Text = """" & f.TrimEnd(CChar(CStr(1))) & "EXCEL.EXE"""
        tb_OneNote.Text = """" & f.TrimEnd(CChar(CStr(1))) & "ONENOTE.EXE"""
        tb_Outlook.Text = """" & f.TrimEnd(CChar(CStr(1))) & "OUTLOOK.EXE"""
        tb_PowerPoint.Text = """" & f.TrimEnd(CChar(CStr(1))) & "POWERPNT.EXE"""
        tb_Publisher.Text = """" & f.TrimEnd(CChar(CStr(1))) & "MSPUB.EXE"""
        tb_UploadCenter.Text = """" & f.TrimEnd(CChar(CStr(1))) & "MSOUC.EXE"""
        tb_Word.Text = """" & f.TrimEnd(CChar(CStr(1))) & "WINWORD.EXE"""
    End Sub

    Private Sub Link_Help_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_Help.LinkClicked
        MsgBox("The program can determine where each file is located based on the location of WINWORD.exe" & (Chr(13)) & _
               "to do so click on the button 'Locate WINWORD.exe' " & (Chr(13)) & _
               "Alterneately you can fill in the 'MSOffice Folder'")
    End Sub


    Private Sub cb_EnableEdit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb_EnableEdit.CheckedChanged
        EnableManualEdit()

    End Sub

    Sub EnableManualEdit()
        tb_Access.Enabled = cb_EnableEdit.CheckState
        tb_Excel.Enabled = cb_EnableEdit.CheckState
        tb_OneNote.Enabled = cb_EnableEdit.CheckState
        tb_Outlook.Enabled = cb_EnableEdit.CheckState
        tb_PowerPoint.Enabled = cb_EnableEdit.CheckState
        tb_Publisher.Enabled = cb_EnableEdit.CheckState
        tb_UploadCenter.Enabled = cb_EnableEdit.CheckState
        tb_Word.Enabled = cb_EnableEdit.CheckState
    End Sub



End Class