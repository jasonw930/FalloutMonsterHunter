Public Class frmMain
    Dim ricky As Integer = 3
    Dim newCommitFromVS As Boolean = True
    Dim extension = True
    Dim fadingControls As New List(Of Object)

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Console.WriteLine("click")
        'btnPlay.Visible = False
        picFader.Visible = True
        picFader.BringToFront()
        fadeInTimer.Start()

        'moveAllControls(pnlMainMenu, picFader)
    End Sub

    Private Sub fadeOutTimerTick() Handles fadeOutTimer.Tick
        Static alpha As Integer = 0
        alpha += 5
        Dim rectColor As System.Drawing.Color
        rectColor = Color.FromArgb(alpha, 0, 0, 0)

        picFader.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)

        If alpha >= 100 Then
            picFader.Refresh()
            picFader.SendToBack()
            fadeOutTimer.Stop()

            picFader.BringToFront()
            fadeInTimer.Start()
        End If
    End Sub

    Private Sub fadeInTimerTick() Handles fadeInTimer.Tick
        Static alpha As Integer = 100
        alpha -= 5
        Dim rectColor As System.Drawing.Color
        rectColor = Color.FromArgb(alpha, 0, 0, 0)

        If alpha Mod 2 = 0 Then
            picFader.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)
            pic
        Else

        End If

        If alpha <= 0 Then
            picFader.Refresh()
            picFader.SendToBack()
            fadeInTimer.Stop()
        End If
    End Sub

    ''Function moveAllControls(old As Object, target As Object)
    ''    For Each ctrl As Object In old.Controls
    ''        fadingControls.Add(ctrl)
    ''        target.Controls.Add(ctrl)
    ''    Next
    ''End Function

    'Private Sub fade_out() Handles fadeOutTimer.Tick
    '    Static ipass As Integer = 0
    '    Dim mycolor As System.Drawing.Color
    '    ipass += 5
    '    If ipass >= 100 Then
    '        'picFader.Invalidate()
    '        'picFader.Update()
    '        fadeOutTimer.Stop()
    '        'picFader.SendToBack()
    '        ipass = 0
    '        picFader.Visible = True
    '        fadeInTimer.Start()
    '        'picFader.CreateGraphics.Clear(Color.Transparent)
    '        'moveAllControls(picFader, pnlMainMenu)
    '        'pnlMainMenu.Visible = False
    '    End If
    '    Console.WriteLine(ipass)
    '    mycolor = Color.FromArgb(ipass, 0, 0, 0)
    '    picFader.CreateGraphics.FillRectangle(New SolidBrush(mycolor), 0, 0, 1000, 750)
    'End Sub

    'Private Sub fade_in() Handles fadeInTimer.Tick
    '    picFader.Refresh()
    '    'picFader.CreateGraphics.FillRectangle(New SolidBrush(Color.Transparent), 0, 0, 1000, 750)
    '    'picFader.Invalidate()
    '    'picFader.Update()
    '    Static ipass As Integer = 100
    '    Static mycolor As System.Drawing.Color
    '    Dim rect As New Rectangle(0, 0, 1000, 750)
    '    mycolor = Color.FromArgb(ipass, 0, 0, 0)
    '    ipass -= 1
    '    If ipass <= 0 Then
    '        'picFader.CreateGraphics.Dispose()
    '        'picFader.CreateGraphics.Clear(Color.Empty)
    '        fadeInTimer.Stop()
    '        picFader.Visible = False
    '        'picFader.SendToBack()
    '        ipass = 100
    '        'moveAllControls(picFader, pnlMainMenu)
    '        'pnlMainMenu.Visible = False
    '    End If
    '    Console.WriteLine(ipass)
    '    'picFader.Invalidate()

    '    picFader.CreateGraphics.FillRectangle(New SolidBrush(mycolor), rect)
    '    'picFader.Update()
    '    picFader.CreateGraphics.Dispose()
    'End Sub

    ''Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
    ''    Static fader As Integer = 255

    ''    pnlMainMenu.BackColor = Color.FromArgb(fader, 0, 0, 0)
    ''    fader -= 5 'amount of opacity change for each timer tick

    ''    Console.WriteLine(fader.ToString())

    ''    If fader <= 0 Then fadeTimer.Enabled = False 'finished fade-in
    ''End Sub
End Class
