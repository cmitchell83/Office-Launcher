<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PicOfficeLogo = New System.Windows.Forms.PictureBox()
        Me.PicWinExplorer = New System.Windows.Forms.PictureBox()
        Me.PicWord = New System.Windows.Forms.PictureBox()
        Me.PicPublisher = New System.Windows.Forms.PictureBox()
        Me.PicPowerPoint = New System.Windows.Forms.PictureBox()
        Me.PicOutlook = New System.Windows.Forms.PictureBox()
        Me.PicOneNote = New System.Windows.Forms.PictureBox()
        Me.PicExcel = New System.Windows.Forms.PictureBox()
        Me.PicAccess = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.PicOfficeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWinExplorer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPublisher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPowerPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOutlook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOneNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicOfficeLogo
        '
        Me.PicOfficeLogo.BackgroundImage = CType(resources.GetObject("PicOfficeLogo.BackgroundImage"), System.Drawing.Image)
        Me.PicOfficeLogo.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.OfficeLogo
        Me.PicOfficeLogo.Location = New System.Drawing.Point(20, 13)
        Me.PicOfficeLogo.Name = "PicOfficeLogo"
        Me.PicOfficeLogo.Size = New System.Drawing.Size(399, 131)
        Me.PicOfficeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicOfficeLogo.TabIndex = 8
        Me.PicOfficeLogo.TabStop = False
        '
        'PicWinExplorer
        '
        Me.PicWinExplorer.BackgroundImage = CType(resources.GetObject("PicWinExplorer.BackgroundImage"), System.Drawing.Image)
        Me.PicWinExplorer.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.Windows_Explorer
        Me.PicWinExplorer.Location = New System.Drawing.Point(330, 261)
        Me.PicWinExplorer.Name = "PicWinExplorer"
        Me.PicWinExplorer.Size = New System.Drawing.Size(100, 100)
        Me.PicWinExplorer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWinExplorer.TabIndex = 7
        Me.PicWinExplorer.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicWinExplorer, "Windows Explorer")
        '
        'PicWord
        '
        Me.PicWord.BackgroundImage = CType(resources.GetObject("PicWord.BackgroundImage"), System.Drawing.Image)
        Me.PicWord.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.Word
        Me.PicWord.Location = New System.Drawing.Point(224, 261)
        Me.PicWord.Name = "PicWord"
        Me.PicWord.Size = New System.Drawing.Size(100, 100)
        Me.PicWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWord.TabIndex = 6
        Me.PicWord.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicWord, "Word")
        '
        'PicPublisher
        '
        Me.PicPublisher.BackgroundImage = CType(resources.GetObject("PicPublisher.BackgroundImage"), System.Drawing.Image)
        Me.PicPublisher.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.Publisher
        Me.PicPublisher.Location = New System.Drawing.Point(118, 261)
        Me.PicPublisher.Name = "PicPublisher"
        Me.PicPublisher.Size = New System.Drawing.Size(100, 100)
        Me.PicPublisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPublisher.TabIndex = 5
        Me.PicPublisher.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicPublisher, "Publisher")
        '
        'PicPowerPoint
        '
        Me.PicPowerPoint.BackgroundImage = CType(resources.GetObject("PicPowerPoint.BackgroundImage"), System.Drawing.Image)
        Me.PicPowerPoint.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.PowerPoint
        Me.PicPowerPoint.Location = New System.Drawing.Point(12, 261)
        Me.PicPowerPoint.Name = "PicPowerPoint"
        Me.PicPowerPoint.Size = New System.Drawing.Size(100, 100)
        Me.PicPowerPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPowerPoint.TabIndex = 4
        Me.PicPowerPoint.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicPowerPoint, "PowerPoint")
        '
        'PicOutlook
        '
        Me.PicOutlook.BackgroundImage = CType(resources.GetObject("PicOutlook.BackgroundImage"), System.Drawing.Image)
        Me.PicOutlook.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.outlook
        Me.PicOutlook.Location = New System.Drawing.Point(330, 155)
        Me.PicOutlook.Name = "PicOutlook"
        Me.PicOutlook.Size = New System.Drawing.Size(100, 100)
        Me.PicOutlook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicOutlook.TabIndex = 3
        Me.PicOutlook.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicOutlook, "Outlook")
        '
        'PicOneNote
        '
        Me.PicOneNote.BackgroundImage = CType(resources.GetObject("PicOneNote.BackgroundImage"), System.Drawing.Image)
        Me.PicOneNote.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.OneNote
        Me.PicOneNote.Location = New System.Drawing.Point(224, 155)
        Me.PicOneNote.Name = "PicOneNote"
        Me.PicOneNote.Size = New System.Drawing.Size(100, 100)
        Me.PicOneNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicOneNote.TabIndex = 2
        Me.PicOneNote.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicOneNote, "OneNote")
        '
        'PicExcel
        '
        Me.PicExcel.BackgroundImage = CType(resources.GetObject("PicExcel.BackgroundImage"), System.Drawing.Image)
        Me.PicExcel.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.Excel
        Me.PicExcel.Location = New System.Drawing.Point(118, 155)
        Me.PicExcel.Name = "PicExcel"
        Me.PicExcel.Size = New System.Drawing.Size(100, 100)
        Me.PicExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExcel.TabIndex = 1
        Me.PicExcel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicExcel, "Excel")
        '
        'PicAccess
        '
        Me.PicAccess.BackgroundImage = CType(resources.GetObject("PicAccess.BackgroundImage"), System.Drawing.Image)
        Me.PicAccess.Image = Global.Microsoft_Office_Launcher.My.Resources.Resources.Access
        Me.PicAccess.Location = New System.Drawing.Point(12, 155)
        Me.PicAccess.Name = "PicAccess"
        Me.PicAccess.Size = New System.Drawing.Size(100, 100)
        Me.PicAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAccess.TabIndex = 0
        Me.PicAccess.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicAccess, "Access")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 26)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Microsoft_Office_Launcher.My.Resources.Resources.BG
        Me.ClientSize = New System.Drawing.Size(440, 373)
        Me.Controls.Add(Me.PicOfficeLogo)
        Me.Controls.Add(Me.PicWinExplorer)
        Me.Controls.Add(Me.PicWord)
        Me.Controls.Add(Me.PicPublisher)
        Me.Controls.Add(Me.PicPowerPoint)
        Me.Controls.Add(Me.PicOutlook)
        Me.Controls.Add(Me.PicOneNote)
        Me.Controls.Add(Me.PicExcel)
        Me.Controls.Add(Me.PicAccess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Microsoft Office 2013 Launcher"
        CType(Me.PicOfficeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWinExplorer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPublisher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPowerPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOutlook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOneNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicAccess As System.Windows.Forms.PictureBox
    Friend WithEvents PicExcel As System.Windows.Forms.PictureBox
    Friend WithEvents PicOneNote As System.Windows.Forms.PictureBox
    Friend WithEvents PicOutlook As System.Windows.Forms.PictureBox
    Friend WithEvents PicPowerPoint As System.Windows.Forms.PictureBox
    Friend WithEvents PicPublisher As System.Windows.Forms.PictureBox
    Friend WithEvents PicWord As System.Windows.Forms.PictureBox
    Friend WithEvents PicWinExplorer As System.Windows.Forms.PictureBox
    Friend WithEvents PicOfficeLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip

End Class
