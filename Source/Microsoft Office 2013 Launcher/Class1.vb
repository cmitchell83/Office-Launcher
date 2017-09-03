Imports System.Drawing.Imaging

Public Class Class1

    Public Shared Sub OfficeVersionSel(ByVal OfficeVersion As String)
        'Run the Sub that corrispons to the current version
        Dim v As String = OfficeVersion

        If v = "Home and Student" Then
            HomeAndStudent()
        ElseIf v = "Home and Business" Then
            HomeAndBusiness()
        ElseIf v = "Standard" Then
            Standard()
        ElseIf v = "Professional" Then
            Professional()
        Else
            MsgBox("ERROR " & Chr(13) & "Error at Class1\OfficeVersionSel")

        End If
        MakeOpacityChange()

    End Sub

    Public Shared Sub HomeAndStudent()
        'Version Home and Student
        'Word,Excel,PowerPoint,OneNote
        Form1.PicAccess.Enabled = False
        'Form1.PicAccess.Image = ChangeOpacity(Form1.PicAccess.Image, 0.3)
        Form1.PicOneNote.Enabled = True
        'Form1.PicOneNote.Image = ChangeOpacity(Form1.PicOneNote.Image, 1 / 0.3)
        Form1.PicOutlook.Enabled = False
        Form1.PicPowerPoint.Enabled = True
        Form1.PicPublisher.Enabled = False

    End Sub

    Public Shared Sub HomeAndBusiness()
        'Version Home and Business
        'Word,Excel,PowerPoint,OneNote,Outlook
        Form1.PicAccess.Enabled = False
        Form1.PicOneNote.Enabled = True
        Form1.PicOutlook.Enabled = True
        Form1.PicPowerPoint.Enabled = True
        Form1.PicPublisher.Enabled = False

    End Sub

    Public Shared Sub SmallBusiness()
        'Version Small Business Basic
        'Word,Excel,OneNote,Outlook
        Form1.PicAccess.Enabled = False
        Form1.PicOneNote.Enabled = True
        Form1.PicOutlook.Enabled = True
        Form1.PicPowerPoint.Enabled = False
        Form1.PicPublisher.Enabled = False

    End Sub

    Public Shared Sub Standard()
        'Version Standard
        'Word,Excel,PowerPoint,OneNote,Outlook,Publisher
        Form1.PicAccess.Enabled = False
        Form1.PicOneNote.Enabled = True
        Form1.PicOutlook.Enabled = True
        Form1.PicPowerPoint.Enabled = True
        Form1.PicPublisher.Enabled = True

    End Sub

    Public Shared Sub Professional()
        'Version Professional
        'Word,Excel,PowerPoint,OneNote,Outlook,Publisher,Access
        Form1.PicAccess.Enabled = True
        Form1.PicOneNote.Enabled = True
        Form1.PicOutlook.Enabled = True
        Form1.PicPowerPoint.Enabled = True
        Form1.PicPublisher.Enabled = True

    End Sub

    Public Shared Sub MakeOpacityChange()
        'If the image is enabled set the opacity to full else if not enabled set the opacity to 30%

        'PicAccess
        If Form1.PicAccess.Enabled = True Then
            Form1.PicAccess.Image = ChangeOpacity(Form1.PicAccess.Image, 1 / 0.3)
        ElseIf Form1.PicAccess.Enabled = False Then
            Form1.PicAccess.Image = ChangeOpacity(Form1.PicAccess.Image, 0.3)
        Else
            MsgBox("ERROR at Class1\MakingOpacityChange_PicAccess")
        End If

        'PicOneNote
        If Form1.PicOneNote.Enabled = True Then
            Form1.PicOneNote.Image = ChangeOpacity(Form1.PicOneNote.Image, 1 / 0.3)
        ElseIf Form1.PicOneNote.Enabled = False Then
            Form1.PicOneNote.Image = ChangeOpacity(Form1.PicOneNote.Image, 0.3)
        Else
            MsgBox("ERROR at Class1\MakingOpacityChange_PicOneNote")
        End If

        'PicOutlook
        If Form1.PicOutlook.Enabled = True Then
            Form1.PicOutlook.Image = ChangeOpacity(Form1.PicOutlook.Image, 1 / 0.3)
        ElseIf Form1.PicOutlook.Enabled = False Then
            Form1.PicOutlook.Image = ChangeOpacity(Form1.PicOutlook.Image, 0.3)
        Else
            MsgBox("ERROR at Class1\MakingOpacityChange_PicOutlook")
        End If

        'PicPowerPoint
        If Form1.PicPowerPoint.Enabled = True Then
            Form1.PicPowerPoint.Image = ChangeOpacity(Form1.PicPowerPoint.Image, 1 / 0.3)
        ElseIf Form1.PicPowerPoint.Enabled = False Then
            Form1.PicPowerPoint.Image = ChangeOpacity(Form1.PicPowerPoint.Image, 0.3)
        Else
            MsgBox("ERROR at Class1\MakingOpacityChange_PicPowerPoint")
        End If

        'PicPublisher
        If Form1.PicPublisher.Enabled = True Then
            Form1.PicPublisher.Image = ChangeOpacity(Form1.PicPublisher.Image, 1 / 0.3)
        ElseIf Form1.PicPublisher.Enabled = False Then
            Form1.PicPublisher.Image = ChangeOpacity(Form1.PicPublisher.Image, 0.3)
        Else
            MsgBox("ERROR at Class1\MakingOpacityChange_PicPublisher")
        End If

    End Sub

    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix
        colormatrix.Matrix33 = opacityvalue
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, _
         GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp
    End Function

End Class
