Imports Microsoft_Office_Launcher.Class1

Public Class Form1

#Region "GlobalVar"

    Dim VersionNum As String = "1.2.2"


    'Using New xml app.config
    Dim s As New My.MySettings
    Dim AppName As String = s.AppName
    Dim MSAccess As String = s.Access
    Dim MSExcel As String = s.Excel
    Dim MSOneNote As String = s.OneNote
    Dim MSOutlook As String = s.Outlook
    Dim MSPowerPoint As String = s.PowerPoint
    Dim MSPublisher As String = s.Publisher
    Dim MSUploadCenter As String = s.UploadCenter
    Dim MSWord As String = s.Word
    Dim Min As Boolean = s.MinOnLaunch
    Dim OfficeVers As String = s.OfficeVersion
    Dim ExplorerStart As String = "%USERPROFILE%\my documents\"

    '/GlobalVar
#End Region


#Region "NotifyIcon"
    Public ContextMenu1 As New ContextMenu
    Public NotifyIcon1 As New NotifyIcon

    Public Sub CreateIconMenuStructure()
        ' Add menu items to context menu.
        ContextMenu1.MenuItems.Add("&Open Application")
        ContextMenu1.MenuItems.Add("S&uspend Application")
        ContextMenu1.MenuItems.Add("E&xit")

        ' Set properties of NotifyIcon component.
        NotifyIcon1.Visible = True
        NotifyIcon1.Icon = New System.Drawing.Icon _
           (System.Environment.GetFolderPath _
           (System.Environment.SpecialFolder.Personal) _
           & "\Icon.ico")
        NotifyIcon1.Text = "Right-click me!"
        NotifyIcon1.ContextMenu = ContextMenu1
    End Sub

#End Region


#Region "Key UP/Down Events"

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Check Which KeyDown occured
        If Control.ModifierKeys = Keys.Alt Then
            AltKeyDown()
            'PicWinExplorer.Image = My.Resources.ResourceManager.GetObject("UploadCenter")
        ElseIf Control.ModifierKeys = Keys.Shift Then
            ShiftKeyDown()
            'PicWinExplorer.Image = My.Resources.ResourceManager.GetObject("SettingsImage")
        ElseIf Control.ModifierKeys = Keys.ControlKey Then
            'Currently do nothing
            CTRLKeyDown()

        End If




    End Sub


    Private Sub Form1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'AltKeyUp()
        PicWinExplorer.Image = My.Resources.ResourceManager.GetObject("Windows_Explorer")

    End Sub

    'KeyDowns
    Sub AltKeyDown()
        ' Do
        'If Control.ModifierKeys = Keys.Alt Then
        PicWinExplorer.Image = My.Resources.ResourceManager.GetObject("UploadCenter")
        'End If
        'Dim AltKey As Boolean = True

    End Sub

    Sub CTRLKeyDown()
        ' Do

    End Sub

    Sub ShiftKeyDown()
        ' Do
        'If Control.ModifierKeys = Keys.Shift Then
        PicWinExplorer.Image = My.Resources.ResourceManager.GetObject("SettingsImage")
        'End If
    End Sub

    Sub AltKeyUp()
        'PicWinExplorer.Image = My.Resources.ResourceManager.GetObject("Windows_Explorer")
        'Dim AltKey As Boolean = False

    End Sub
#End Region


#Region "Settings.ini"
    Dim iniFN As String = "Settings.ini" 'INI File Name
    'Dim iFolder As String = Application.StartupPath & GetSettingItem(iniFN, "ImageFolder")

    Public Function ini(ByVal File As String, ByVal Identifier As String) As String
        Dim S As New IO.StreamReader(File) : Dim Result As String = ""
        Do While (S.Peek <> -1)
            Dim Line As String = S.ReadLine
            If Line.ToLower.StartsWith(Identifier.ToLower & ":") Then
                Result = Line.Substring(Identifier.Length + 2)
                Result = Result.Trim 'Remove Spaces from value (before and/or after value)

            End If
        Loop

        S.Close()
        Return Result

    End Function



    'Using Old Settings.ini
    'Dim AppName As String = ini(iniFN, "Name")
    'Dim MSAccess As String = ini(iniFN, "Access")
    'Dim MSExcel As String = ini(iniFN, "Excel")
    'Dim MSOneNote As String = ini(iniFN, "OneNote")
    'Dim MSOutlook As String = ini(iniFN, "Outlook")
    'Dim MSPowerPoint As String = ini(iniFN, "PowerPoint")
    'Dim MSPublisher As String = ini(iniFN, "Publisher")
    'Dim MSUploadCenter As String = ini(iniFN, "UploadCenter")
    'Dim MSWord As String = ini(iniFN, "Word")
    'Dim Min As String = ini(iniFN, "MinOnLaunch")
#End Region










    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Application.ExecutablePath & ".config") Then
            'Do Nothing, all is good
        Else
            MsgBox("Failed to locate app.config file, please ensure that file exists in the exe directory")
            Me.Close()
        End If

        Try
            OfficeVersionSel(OfficeVers)
            Me.Text = AppName & " Ver " & VersionNum
            Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



#Region "Buttons"

    Private Sub PicAccess_Click(sender As System.Object, e As System.EventArgs) Handles PicAccess.Click
        Try
            Process.Start(MSAccess)
            MinWin(MSAccess)

        Catch ex As Exception
            TryFailed("Access")
        End Try

    End Sub

    Private Sub PicExcel_Click(sender As System.Object, e As System.EventArgs) Handles PicExcel.Click
        Try
            Process.Start(MSExcel)
            MinWin(MSExcel)

        Catch ex As Exception
            TryFailed("Excel")
        End Try

    End Sub

    Private Sub PicOneNote_Click(sender As System.Object, e As System.EventArgs) Handles PicOneNote.Click
        Try
            Process.Start(MSOneNote)
            MinWin(MSOneNote)

        Catch ex As Exception
            TryFailed("OneNote")
        End Try

    End Sub

    Private Sub PicOutlook_Click(sender As System.Object, e As System.EventArgs) Handles PicOutlook.Click
        Try
            Process.Start(MSOutlook, "/recycle")
            MinWin(MSOutlook)

        Catch ex As Exception
            TryFailed("Outlook")
        End Try

    End Sub

    Private Sub PicPowerPoint_Click(sender As System.Object, e As System.EventArgs) Handles PicPowerPoint.Click
        Try
            Process.Start(MSPowerPoint)
            MinWin(MSPowerPoint)

        Catch ex As Exception
            TryFailed("PowerPoint")
        End Try

    End Sub

    Private Sub PicPublisher_Click(sender As System.Object, e As System.EventArgs) Handles PicPublisher.Click
        Try
            Process.Start(MSPublisher)
            MinWin(MSPublisher)

        Catch ex As Exception
            TryFailed("Publisher")
        End Try

    End Sub

    Private Sub PicWord_Click(sender As System.Object, e As System.EventArgs) Handles PicWord.Click
        Try
            Process.Start(MSWord)
            MinWin(MSWord)

        Catch ex As Exception
            TryFailed("Word")
        End Try

    End Sub

    Private Sub PicWinExplorer_Click(sender As System.Object, e As System.EventArgs) Handles PicWinExplorer.Click
        Try
            ' If the CTRL key is pressed when the control is clicked
            If Control.ModifierKeys = Keys.Alt Then
                Try
                    Process.Start(MSUploadCenter)
                Catch ex As Exception
                    TryFailed("Upload Center")
                End Try


            ElseIf Control.ModifierKeys = Keys.Control Then
                'Open application folder
                Process.Start("Explorer", Application.StartupPath & "\")
                'DEBUG ORIGINAL CODE    CType(sender, Control).Hide() 'Hides the image

            ElseIf Control.ModifierKeys = Keys.Shift Then
                'Settings FormShiftKey 
                Form2.Show()


            Else
                Process.Start("Explorer.exe")
            End If

        Catch ex As Exception
            MsgBox("Shoot, something went wrong just there")
        End Try

    End Sub


    Private Sub PicOfficeLogo_Click(sender As System.Object, e As System.EventArgs) Handles PicOfficeLogo.Click
        ' If the CTRL key is pressed when the  
        ' control is clicked, hide the control.  
        If Control.ModifierKeys = Keys.Control Then
            'DEBUG ORIGINAL CODE    CType(sender, Control).Hide()
            MsgBox("Version " & VersionNum)
        End If
    End Sub

    'END BUTTONS
#End Region


    Sub TryFailed(M As String)
        MsgBox(M & " Wasn't located, please check settings file")
    End Sub


    Sub MinWin(app As String)
        If Min = True Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.Close()
        End If

    End Sub



End Class
