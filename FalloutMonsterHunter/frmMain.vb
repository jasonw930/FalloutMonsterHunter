Public Class frmMain
    Dim ricky As Integer = 3
    Dim newCommitFromVS As Boolean = True
    Dim extension = True
    Dim fadingControls As New List(Of Object)

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Console.WriteLine("click")
        fadeOutTimer.Start()
        'btnPlay.Visible = False
        picFader.Visible = True
        picFader.BringToFront()
        'moveAllControls(pnlMainMenu, picFader)
    End Sub

    'Function moveAllControls(old As Object, target As Object)
    '    For Each ctrl As Object In old.Controls
    '        fadingControls.Add(ctrl)
    '        target.Controls.Add(ctrl)
    '    Next
    'End Function

    Dim transitionRectangles As New List(Of Rectangle)

    Private Sub fade_out() Handles fadeOutTimer.Tick
        Static ipass As Integer = 0
        Dim mycolor As System.Drawing.Color
        Dim rect As New Rectangle(0, 0, 1000, 750)
        transitionRectangles.Add(rect)
        Console.WriteLine(transitionRectangles.Count)
        ipass += 5
        If ipass >= 100 Then
            'picFader.Invalidate()
            'picFader.Update()
            fadeOutTimer.Stop()
            'picFader.SendToBack()
            ipass = 0
            'picFader.Invalidate()
            'picFader.Refresh()
            fadeInTimer.Start()
            'picFader.CreateGraphics.Clear(Color.Transparent)
            'moveAllControls(picFader, pnlMainMenu)
            'pnlMainMenu.Visible = False
        End If
        'Console.WriteLine(ipass)
        mycolor = Color.FromArgb(ipass, 0, 0, 0)
        picFader.CreateGraphics.FillRectangle(New SolidBrush(mycolor), rect)
    End Sub

    Private Sub fade_in() Handles fadeInTimer.Tick



        '' ******remove previous rectangle after current drawn
        'Console.WriteLine("fadein tick")
        'Static previousRectangle As Rectangle
        'Static noPreviousRectangle As Boolean = True
        Static numRecsLeft As Integer = transitionRectangles.Count - 1
        ''picFader.Refresh()
        ''picFader.CreateGraphics.FillRectangle(New SolidBrush(Color.Transparent), 0, 0, 1000, 750)
        ''picFader.Invalidate()
        ''picFader.Update()
        'Static ipass As Integer = 100
        'ipass -= 5
        'Static mycolor As System.Drawing.Color
        'mycolor = Color.FromArgb(ipass, 0, 0, 0)

        'Dim rect As New Rectangle(0, 0, 1000, 750)
        'picFader.CreateGraphics.FillRectangle(New SolidBrush(mycolor), rect)

        'If noPreviousRectangle = True Then
        '    previousRectangle = rect
        '    noPreviousRectangle = False
        'ElseIf noPreviousRectangle = False Then
        '    picFader.CreateGraphics.FillRectangle(New SolidBrush(Color.Transparent), previousRectangle)
        '    picFader.Refresh()
        '    previousRectangle = rect
        'End If

        'If ipass <= 0 Then
        '    fadeInTimer.Stop()
        '    picFader.SendToBack()
        '    picFader.Visible = False
        '    ipass = 100
        'End If

        '' ******remove previous rectangle after current drawn


        'If numRecsLeft >= 1 Then
        '    Dim offscreen As Point = New Point(-1000, -1000)
        '    transitionRectangles(numRecsLeft).Offset(offscreen)
        '    numRecsLeft -= 1
        'Else
        '    fadeInTimer.Stop()
        '    'picFader.Visible = False



        '    'picFader.Refresh()
        '    transitionRectangles.Clear()
        'End If
        'Console.WriteLine(numRecsLeft)
        'picFader.Invalidate()
    End Sub

    'Private Sub fade_in2() Handles' fadeOutTimer.Tick
    '    Dim rect1 As New Rectangle(0, 0, 1000, 750)
    '    Dim oldRect As Rectangle
    '    Dim alpha As Integer = 100

    '    If alpha <= 0 Then

    '    End If


    'End Sub

    'Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
    '    Static fader As Integer = 255

    '    pnlMainMenu.BackColor = Color.FromArgb(fader, 0, 0, 0)
    '    fader -= 5 'amount of opacity change for each timer tick

    '    Console.WriteLine(fader.ToString())

    '    If fader <= 0 Then fadeTimer.Enabled = False 'finished fade-in
    'End Sub
End Class
