Public Class frmMain
    'Variables--------------------------------------------------------------------------------------------
    Dim fadingControls As New List(Of Object)
    Dim targetScene As Panel
    Dim panelsAndPics As New Dictionary(Of Panel, PictureBox)

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

        panelsAndPics.Add(pnlIntro, picBackdrop)
        panelsAndPics.Add(pnlMainMenu, PictureBox1)

        Dim player As New Player("Bob")

        'Item.initialize()
        'Mob.initialize()
    End Sub

    'Procedures-------------------------------------------------------------------------------------------
    Private Sub transition(scene As Panel)
        'scene.Visible = False
        scene.BringToFront()
        'picFader.Visible = True
        'picFader.BringToFront()
        'picFader2.Visible = True
        'picFader2.BringToFront()

        'fadeOutTimer.Start()


        'For alpha As Integer = 0 To 100 Step 5
        '    Threading.Thread.Sleep(10)
        '    Dim rectColor As System.Drawing.Color
        '    rectColor = Color.FromArgb(alpha, 0, 0, 0)

        '    Console.WriteLine("picFader: Fade in at opacity " & alpha)
        '    picFader.BringToFront()
        '    picFader.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)
        'Next

        scene.Visible = True
        'panelsAndPics.Item(scene).Controls.Add(picFader)
        'panelsAndPics.Item(scene).Controls.Add(picFader2)
        ''scene.Controls.Add(picFader)
        ''scene.Controls.Add(picFader2)
        'picFader.Visible = True
        'picFader.BringToFront()
        'picFader.Refresh()
        'picFader2.Visible = True
        'picFader2.BringToFront()
        'picFader2.Refresh()

        'For alpha As Integer = 100 To 0 Step -10
        '    Threading.Thread.Sleep(20)

        '    Dim rectColor As System.Drawing.Color
        '    rectColor = Color.FromArgb(alpha, 0, 0, 0)

        '    If alpha Mod 20 = 0 Then
        '        Console.WriteLine("picFader: Fade out at opacity " & alpha)
        '        picFader.BringToFront()
        '        picFader.Refresh()
        '        picFader.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)
        '        picFader2.Refresh()
        '    ElseIf alpha Mod 20 = 10 Then
        '        Console.WriteLine("picFader2: Fade in at opacity " & alpha)
        '        picFader2.BringToFront()
        '        picFader2.Refresh()
        '        picFader2.CreateGraphics.FillRectangle(New SolidBrush(rectColor), 0, 0, 1000, 750)
        '        picFader.Refresh()
        '    End If

        'Next

        'picFader.Refresh()
        'picFader.SendToBack()
        'picFader2.Refresh()
        'picFader2.SendToBack()

    End Sub

    Public Function pause(milliseconds As Integer) 'Handles intervalPauseTimer.Tick
        'If pauseTimer.Enabled = False Then
        '    intervalPauseTimer.Stop()
        '    intervalPauseTimer.Enabled = False
        '    Return True
        'End If
        pauseTimer.Interval = milliseconds
        pauseTimer.Start()
        pauseTimer.Enabled = True
        Do While pauseTimer.Enabled = True

        Loop
        Return True
    End Function

    'Event Handles---------------------------------------------------------------------------------------
    Public Sub pauseTimerEnd() Handles pauseTimer.Tick
        pauseTimer.Stop()
        pauseTimer.Enabled = False
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Console.WriteLine("now we're running")
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

End Class
