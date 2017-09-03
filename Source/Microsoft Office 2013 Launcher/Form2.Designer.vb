<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Access = New System.Windows.Forms.TextBox()
        Me.tb_Excel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_OneNote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Outlook = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_PowerPoint = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Publisher = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_UploadCenter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_Word = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Apply = New System.Windows.Forms.Button()
        Me.btn_Restore = New System.Windows.Forms.Button()
        Me.cb_MinOnLaunch = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tb_Office = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Link_Help = New System.Windows.Forms.LinkLabel()
        Me.cb_EnableEdit = New System.Windows.Forms.CheckBox()
        Me.cob_OfficeVersion = New System.Windows.Forms.ComboBox()
        Me.GeckoWebBrowser1 = New Skybound.Gecko.GeckoWebBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Access"
        '
        'tb_Access
        '
        Me.tb_Access.Location = New System.Drawing.Point(80, 10)
        Me.tb_Access.Name = "tb_Access"
        Me.tb_Access.Size = New System.Drawing.Size(512, 20)
        Me.tb_Access.TabIndex = 1
        '
        'tb_Excel
        '
        Me.tb_Excel.Location = New System.Drawing.Point(80, 36)
        Me.tb_Excel.Name = "tb_Excel"
        Me.tb_Excel.Size = New System.Drawing.Size(512, 20)
        Me.tb_Excel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Excel"
        '
        'tb_OneNote
        '
        Me.tb_OneNote.Location = New System.Drawing.Point(80, 62)
        Me.tb_OneNote.Name = "tb_OneNote"
        Me.tb_OneNote.Size = New System.Drawing.Size(512, 20)
        Me.tb_OneNote.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "OneNote"
        '
        'tb_Outlook
        '
        Me.tb_Outlook.Location = New System.Drawing.Point(80, 88)
        Me.tb_Outlook.Name = "tb_Outlook"
        Me.tb_Outlook.Size = New System.Drawing.Size(512, 20)
        Me.tb_Outlook.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Outlook"
        '
        'tb_PowerPoint
        '
        Me.tb_PowerPoint.Location = New System.Drawing.Point(80, 114)
        Me.tb_PowerPoint.Name = "tb_PowerPoint"
        Me.tb_PowerPoint.Size = New System.Drawing.Size(512, 20)
        Me.tb_PowerPoint.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PowerPoint"
        '
        'tb_Publisher
        '
        Me.tb_Publisher.Location = New System.Drawing.Point(80, 140)
        Me.tb_Publisher.Name = "tb_Publisher"
        Me.tb_Publisher.Size = New System.Drawing.Size(512, 20)
        Me.tb_Publisher.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Publisher"
        '
        'tb_UploadCenter
        '
        Me.tb_UploadCenter.Location = New System.Drawing.Point(80, 166)
        Me.tb_UploadCenter.Name = "tb_UploadCenter"
        Me.tb_UploadCenter.Size = New System.Drawing.Size(512, 20)
        Me.tb_UploadCenter.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Upload Center"
        '
        'tb_Word
        '
        Me.tb_Word.Location = New System.Drawing.Point(80, 192)
        Me.tb_Word.Name = "tb_Word"
        Me.tb_Word.Size = New System.Drawing.Size(512, 20)
        Me.tb_Word.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Word"
        '
        'btn_Apply
        '
        Me.btn_Apply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Apply.Location = New System.Drawing.Point(518, 282)
        Me.btn_Apply.Name = "btn_Apply"
        Me.btn_Apply.Size = New System.Drawing.Size(75, 23)
        Me.btn_Apply.TabIndex = 16
        Me.btn_Apply.Text = "Apply"
        Me.btn_Apply.UseVisualStyleBackColor = True
        '
        'btn_Restore
        '
        Me.btn_Restore.Location = New System.Drawing.Point(437, 282)
        Me.btn_Restore.Name = "btn_Restore"
        Me.btn_Restore.Size = New System.Drawing.Size(75, 23)
        Me.btn_Restore.TabIndex = 17
        Me.btn_Restore.Text = "Restore"
        Me.btn_Restore.UseVisualStyleBackColor = True
        '
        'cb_MinOnLaunch
        '
        Me.cb_MinOnLaunch.AutoSize = True
        Me.cb_MinOnLaunch.Location = New System.Drawing.Point(309, 288)
        Me.cb_MinOnLaunch.Name = "cb_MinOnLaunch"
        Me.cb_MinOnLaunch.Size = New System.Drawing.Size(122, 17)
        Me.cb_MinOnLaunch.TabIndex = 18
        Me.cb_MinOnLaunch.Text = "Minimize On Launch"
        Me.cb_MinOnLaunch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Locate WINWORD.exe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tb_Office
        '
        Me.tb_Office.Location = New System.Drawing.Point(93, 219)
        Me.tb_Office.Name = "tb_Office"
        Me.tb_Office.Size = New System.Drawing.Size(419, 20)
        Me.tb_Office.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "MSOffice Folder"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(518, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Fill EXE Loc"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Link_Help
        '
        Me.Link_Help.AutoSize = True
        Me.Link_Help.Location = New System.Drawing.Point(4, 295)
        Me.Link_Help.Name = "Link_Help"
        Me.Link_Help.Size = New System.Drawing.Size(29, 13)
        Me.Link_Help.TabIndex = 23
        Me.Link_Help.TabStop = True
        Me.Link_Help.Text = "Help"
        '
        'cb_EnableEdit
        '
        Me.cb_EnableEdit.AutoSize = True
        Me.cb_EnableEdit.Location = New System.Drawing.Point(39, 295)
        Me.cb_EnableEdit.Name = "cb_EnableEdit"
        Me.cb_EnableEdit.Size = New System.Drawing.Size(151, 17)
        Me.cb_EnableEdit.TabIndex = 24
        Me.cb_EnableEdit.Text = "ENABLE MANUAL EDITS"
        Me.cb_EnableEdit.UseVisualStyleBackColor = True
        '
        'cob_OfficeVersion
        '
        Me.cob_OfficeVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cob_OfficeVersion.FormattingEnabled = True
        Me.cob_OfficeVersion.Items.AddRange(New Object() {"Home and Student", "Home and Business", "Standard", "Professional"})
        Me.cob_OfficeVersion.Location = New System.Drawing.Point(156, 254)
        Me.cob_OfficeVersion.Name = "cob_OfficeVersion"
        Me.cob_OfficeVersion.Size = New System.Drawing.Size(195, 21)
        Me.cob_OfficeVersion.TabIndex = 25
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(0, 0)
        Me.GeckoWebBrowser1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 317)
        Me.Controls.Add(Me.cob_OfficeVersion)
        Me.Controls.Add(Me.cb_EnableEdit)
        Me.Controls.Add(Me.Link_Help)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_Office)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_MinOnLaunch)
        Me.Controls.Add(Me.btn_Restore)
        Me.Controls.Add(Me.btn_Apply)
        Me.Controls.Add(Me.tb_Word)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_UploadCenter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_Publisher)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_PowerPoint)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_Outlook)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_OneNote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_Excel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Access)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_Access As System.Windows.Forms.TextBox
    Friend WithEvents tb_Excel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_OneNote As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_Outlook As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_PowerPoint As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_Publisher As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_UploadCenter As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_Word As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_Apply As System.Windows.Forms.Button
    Friend WithEvents btn_Restore As System.Windows.Forms.Button
    Friend WithEvents cb_MinOnLaunch As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tb_Office As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Link_Help As System.Windows.Forms.LinkLabel
    Friend WithEvents cb_EnableEdit As System.Windows.Forms.CheckBox
    Friend WithEvents cob_OfficeVersion As System.Windows.Forms.ComboBox
    Friend WithEvents GeckoWebBrowser1 As Skybound.Gecko.GeckoWebBrowser
End Class
