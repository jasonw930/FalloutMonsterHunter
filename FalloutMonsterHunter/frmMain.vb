Public Class frmMain
    'Variables--------------------------------------------------------------------------------------------
    Dim fadingControls As New List(Of Object)
    Dim targetScene As Panel
    Dim panelsAndPics As New Dictionary(Of Panel, PictureBox)
    Dim currentCity As Panel
    Dim currentUnlockedCity As Panel
    Dim dialogLines As String() = {
        "<Walkie-Talkie>Hello? Hello?? Is anybody there???(clkCont)",
        "<sANS>dOOT DOOT DOOT DOOT DOOT DOOOT DOOT DOOOOO DOOO DOOO DOOOOT(clkCont)"
    }

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
        panelsAndPics.Add(pnlMainMenu, picIntro)

        Player.player = New Player("Bob")

        'Item.initialize()
        Mob.initialize()
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

    Public Sub fight(player As Player, mob As Mob)
        Dim result As Boolean
        'Fight
        transition(pnlFujiCity)
        player.updateStats()
        player.currentHealth = player.health
        mob.currentHealth = mob.health
        Do While True
            Randomize()
            Dim attackValue As Integer
            'Player Attack
            attackValue = (player.attack - mob.defense) * If(Rnd() <= player.critChance / 100, 2, 1)
            mob.currentHealth -= attackValue
            If mob.currentHealth <= 0 Then
                result = True
                Exit Do
            End If
            'Mob Attack
            attackValue = (mob.attack - player.defense) * If(Rnd() <= mob.critChance / 100, 2, 1)
            player.currentHealth -= attackValue
            If player.currentHealth <= 0 Then
                result = False
                Exit Do
            End If
        Loop
        'Result
        If result Then
            For x = 0 To mob.dropItems.Length - 1
                Randomize()
                Dim item As Item = mob.dropItems(x)
                Dim amount As Integer = If(Rnd() <= mob.dropChance(x), Int(Rnd() * mob.dropAmount(x)) + 1, 0)
                Dim itemStack As ItemStack = If(amount > 0, New ItemStack(item, amount), New ItemStack(Item.itemNull, 1))
                player.addItemToInventory(itemStack)
            Next
        End If
    End Sub



    Public Function wait(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing, Optional duration As Integer = 0) Handles textDisplayTimer.Tick
        Console.WriteLine("went into wait")
        If duration > 0 Then
            textDisplayTimer.Interval = duration
            textDisplayTimer.Start()
            Console.WriteLine("started timer at " & duration.ToString() & " seconds to tick")
            Return False
        Else
            textDisplayTimer.Stop()
            Console.WriteLine("stopped timer")
            Return True
        End If
    End Function

    Dim toVisible As Object

    Public Function visibleAfterDelay(sender As Object, e As EventArgs) Handles textDisplayTimer.Tick
        toVisible.Visible = True
    End Function

    Public Function displayText(dialogRollStart As Integer, dialogRollEnd As Integer)
        Application.DoEvents()
        Threading.Thread.Sleep(2000)
        Application.DoEvents()
        pnlDialog.Visible = True
        Application.DoEvents()

        For i As Integer = dialogRollStart To dialogRollEnd
            Application.DoEvents()
            Dim speaker As String = dialogLines(i).Substring(1, dialogLines(i).IndexOf(">") - 1)
            Dim text As String = dialogLines(i).Substring(dialogLines(i).IndexOf(">") + 1, dialogLines(i).IndexOf("(") - dialogLines(i).IndexOf(">") - 1)
            Dim contMethod As String
            lblSpeaker.Text = speaker
            lblDialog.Text = text

            For x As Integer = 1 To text.Length
                Threading.Thread.Sleep(100)
                lblDialog.Text = text.Substring(0, x)
                If x < text.Length Then
                    lblDialog.Text = lblDialog.Text & "_"
                End If
                Application.DoEvents()
            Next

        Next
    End Function

    'Event Handles---------------------------------------------------------------------------------------
    Public Sub pauseTimerEnd() Handles pauseTimer.Tick
        pauseTimer.Stop()
        pauseTimer.Enabled = False
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Console.WriteLine("now we're running")
        transition(pnlIntro)
        'Threading.Thread.Sleep(2000)
        Application.DoEvents()
        displayText(0, 1)
    End Sub

    Private Sub pnlIntroClick() Handles pnlIntro.Click
        transition(pnlFujiCity)
        fight(Player.player, Mob.mobRaptor1)
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
