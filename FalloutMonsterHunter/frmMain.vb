Public Class frmMain
    'Variables--------------------------------------------------------------------------------------------
    Dim fadingControls As New List(Of Object)
    Dim targetScene As Panel

    'Form Load--------------------------------------------------------------------------------------------
    Private Sub formLoad() Handles Me.Load
        Console.WriteLine("---------------------------------------------")
        For Each pnl In Me.Controls.OfType(Of Panel)
            pnl.Location = New System.Drawing.Point(0, 0)
        Next
        picFader.Location = New Point(0, 0)
        picFader2.Location = New Point(0, 0)
        pnlMainMenu.Visible = True
        pnlMainMenu.BringToFront()

        Dim player As New Player("Bob")
        Item.initialize()
        Mob.initialize()
    End Sub

    'Procedures-------------------------------------------------------------------------------------------
    Private Sub transition(scene As Panel)
        targetScene = scene
        targetScene.Visible = False
        targetScene.BringToFront()
        picFader.Visible = True
        picFader.BringToFront()
        picFader2.Visible = True
        picFader2.BringToFront()

        fadeOutTimer.Start()
    End Sub

    'Event Handles---------------------------------------------------------------------------------------
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        transition(pnlIntro)
    End Sub

    Private Sub fadeOutTimerTick() Handles fadeOutTimer.Tick
        Static alpha As Integer = 0
        alpha += 5
        Dim rectColor As System.Drawing.Color
        rectColor = Color.FromArgb(alpha, 0, 0, 0)

        Console.WriteLine("picFader: Fade in at opacity " & alpha)
        picFader.BringToFront()
        picFader.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)

        If alpha >= 100 Then
            alpha = 0
            targetScene.Visible = True
            fadeOutTimer.Stop()
            fadeInTimer.Start()
        End If
    End Sub

    Private Sub fadeInTimerTick() Handles fadeInTimer.Tick
        Static alpha As Integer = 100
        alpha -= 10
        Dim rectColor As System.Drawing.Color
        rectColor = Color.FromArgb(alpha, 0, 0, 0)

        If alpha Mod 10 = 0 Then
            Console.WriteLine("picFader: Fade out at opacity " & alpha)
            picFader.BringToFront()
            picFader.Refresh()
            picFader.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)
            picFader2.Refresh()
        ElseIf alpha Mod 10 = 5 Then
            Console.WriteLine("picFader2: Fade in at opacity " & alpha)
            picFader2.BringToFront()
            picFader2.Refresh()
            picFader2.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)
            picFader.Refresh()
        End If

        If alpha <= 0 Then
            alpha = 100
            picFader.Refresh()
            picFader.SendToBack()
            picFader2.Refresh()
            picFader2.SendToBack()
            fadeInTimer.Stop()
        End If
    End Sub

    ''Function moveAllControls(old As Object, target As Object)
    ''    For Each ctrl As Object In old.Controls
    ''        fadingControls.Add(ctrl)
    ''        target.Controls.Add(ctrl)
    ''    Next
    ''End Function

    'Dim transitionRectangles As New List(Of Rectangle)

    'Private Sub fade_out() Handles fadeOutTimer.Tick
    '    Static ipass As Integer = 0
    '    Dim mycolor As System.Drawing.Color
    '    Dim rect As New Rectangle(0, 0, 1000, 750)
    '    transitionRectangles.Add(rect)
    '    Console.WriteLine(transitionRectangles.Count)
    '    ipass += 5
    '    If ipass >= 100 Then
    '        'picFader.Invalidate()
    '        'picFader.Update()
    '        fadeOutTimer.Stop()
    '        'picFader.SendToBack()
    '        ipass = 0
    '        'picFader.Invalidate()
    '        'picFader.Refresh()
    '        fadeInTimer.Start()
    '        'picFader.CreateGraphics.Clear(Color.Transparent)
    '        'moveAllControls(picFader, pnlMainMenu)
    '        'pnlMainMenu.Visible = False
    '    End If
    '    'Console.WriteLine(ipass)
    '    mycolor = Color.FromArgb(ipass, 0, 0, 0)
    '    picFader.CreateGraphics.FillRectangle(New SolidBrush(mycolor), rect)
    'End Sub

    'Private Sub fade_in() Handles fadeInTimer.Tick



    '    '' ******remove previous rectangle after current drawn
    '    'Console.WriteLine("fadein tick")
    '    'Static previousRectangle As Rectangle
    '    'Static noPreviousRectangle As Boolean = True
    '    Static numRecsLeft As Integer = transitionRectangles.Count - 1
    '    ''picFader.Refresh()
    '    ''picFader.CreateGraphics.FillRectangle(New SolidBrush(Color.Transparent), 0, 0, 1000, 750)
    '    ''picFader.Invalidate()
    '    ''picFader.Update()
    '    'Static ipass As Integer = 100
    '    'ipass -= 5
    '    'Static mycolor As System.Drawing.Color
    '    'mycolor = Color.FromArgb(ipass, 0, 0, 0)

    '    'Dim rect As New Rectangle(0, 0, 1000, 750)
    '    'picFader.CreateGraphics.FillRectangle(New SolidBrush(mycolor), rect)

    '    'If noPreviousRectangle = True Then
    '    '    previousRectangle = rect
    '    '    noPreviousRectangle = False
    '    'ElseIf noPreviousRectangle = False Then
    '    '    picFader.CreateGraphics.FillRectangle(New SolidBrush(Color.Transparent), previousRectangle)
    '    '    picFader.Refresh()
    '    '    previousRectangle = rect
    '    'End If

    '    'If ipass <= 0 Then
    '    '    fadeInTimer.Stop()
    '    '    picFader.SendToBack()
    '    '    picFader.Visible = False
    '    '    ipass = 100
    '    'End If

    '    '' ******remove previous rectangle after current drawn


    '    'If numRecsLeft >= 1 Then
    '    '    Dim offscreen As Point = New Point(-1000, -1000)
    '    '    transitionRectangles(numRecsLeft).Offset(offscreen)
    '    '    numRecsLeft -= 1
    '    'Else
    '    '    fadeInTimer.Stop()
    '    '    'picFader.Visible = False



    '    '    'picFader.Refresh()
    '    '    transitionRectangles.Clear()
    '    'End If
    '    'Console.WriteLine(numRecsLeft)
    '    'picFader.Invalidate()
    'End Sub

    ''Private Sub fade_in2() Handles' fadeOutTimer.Tick
    ''    Dim rect1 As New Rectangle(0, 0, 1000, 750)
    ''    Dim oldRect As Rectangle
    ''    Dim alpha As Integer = 100

    ''    If alpha <= 0 Then

    ''    End If


    ''End Sub

    ''Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
    ''    Static fader As Integer = 255

    ''    pnlMainMenu.BackColor = Color.FromArgb(fader, 0, 0, 0)
    ''    fader -= 5 'amount of opacity change for each timer tick

    ''    Console.WriteLine(fader.ToString())

    ''    If fader <= 0 Then fadeTimer.Enabled = False 'finished fade-in
    ''End Sub
End Class
