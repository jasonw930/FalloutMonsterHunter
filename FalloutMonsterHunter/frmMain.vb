﻿Public Class frmMain
    'Variables--------------------------------------------------------------------------------------------
    Dim fadingControls As New List(Of Object)
    Dim targetScene As Panel
    Dim panelsAndPics As New Dictionary(Of Panel, PictureBox)
    Dim currentCity As Panel
    Dim currentUnlockedCity As Panel

    Dim isAutoCont As Boolean = False

    Dim dialogLines As String()

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

        ' note: '|' stands for Player.player.playerName; replaced at runtime of the line, so we don't affix the Player.player.playerName before user inputs it
        ' the transitions/continue to next line methods are: 
        ' clkCont --> wait for user to click before continuing
        ' usrIn --> wait for user to input something (that is not "", even when trimmed) and click before continuing
        ' delayAutoCont --> wait for 500 milliseconds before continuing to next line automatically. if user clicks to interrupt, stop typing (whole line will not be displayed) and wait 500 milliseconds before going to next line
        dialogLines = {
            "<Walkie-Talkie>Hello? Hello?? Is anybody there???(clkCont)",
            "<You>[Tiredly] Yes. Who is this?(clkCont)",
            "<Walkie-Talkie>This is Emperor Hirohito! Report your name!(usrIn)",
            "<Emperor Hirohito>" & "|" & "! Be warned, we detected an American bomber approaching Hiroshima. We have reason to believe that it is yielding the Manhattan Weapon.(clkCont)",
            "<You>No...(clkCont)",
            "<You>[To self] My wife! My child!(clkCont)",
            "<You>[Changes frequency to long-range](clkCont)",
            "<You>Misa! Can you hear me?!(clkCont)",
            "<...>[There is only static...](clkCont)",
            "<You>Misa!!(clkCont)",
            "<Misa>Hello? Hello?? Is that you, " & "|" & "? What is it, my love?(clkCont)",
            "<You>Misa, my love! The fallback! Protect yourselves, the Manhattan Weapon is coming for Hiroshima!(clkCont)",
            "<Misa>The Manhattan Weapon? It can't be...(clkCont)",
            "<You>Hurry! You must protect yourselves!(clkCont)",
            "<Misa>I will!" & vbCrLf & vbCrLf & "[You hear running and the clicking of machinery](clkCont)",
            "<...>[Radio silence]" & vbCrLf & vbCrLf & "[It seems to last a lifetime](clkCont)",
            "<Misa>" & "|" & "! Are you still there?(clkCont)",
            "<You>Yes! I am still here, my love. But why--(delayAutoCont)",
            "<Misa>Our child is safe. But the second machine...(clkCont)",
            "<You>No...(clkCont)",
            "<Misa>I am sorry, my love. You must survive this. You must survive to ensure our child does, too. I love you, " & "|" & ", I always will. I lo--(delayAutoCont)"
        }

        'Item.initialize()
        'ItemArmor.initialize()
        'ItemWeapon.initialize()
        Mob.initialize()
    End Sub

    'Procedures-------------------------------------------------------------------------------------------
    Private Sub transition(scene As Panel)
        scene.BringToFront()
        scene.Visible = True
    End Sub

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

    Dim toVisible As Object
    Dim hasClickedToContinue As Boolean = False

    Public Sub displayText(dialogRollStart As Integer, dialogRollEnd As Integer)
        Application.DoEvents()
        Threading.Thread.Sleep(2000)
        Application.DoEvents()
        pnlDialog.Visible = True
        Application.DoEvents()

        For i As Integer = dialogRollStart To dialogRollEnd
            Application.DoEvents()
            Dim dialogRoll As String = dialogLines(i).Replace("|", Player.player.playerName)
            Dim speaker As String = dialogRoll.Substring(1, dialogRoll.IndexOf(">") - 1)
            Dim text As String = dialogRoll.Substring(dialogRoll.IndexOf(">") + 1, dialogRoll.IndexOf("(") - dialogRoll.IndexOf(">") - 1)
            Dim contMethod As String = dialogRoll.Substring(dialogRoll.IndexOf("(") + 1, dialogRoll.Length - dialogRoll.IndexOf("(") - 2)
            lblSpeaker.Text = speaker
            lblDialog.Text = text

            If contMethod.Equals("delayAutoCont") Then
                isAutoCont = True
            End If

            For x As Integer = 1 To text.Length
                Threading.Thread.Sleep(100)
                lblDialog.Text = text.Substring(0, x)
                If x < text.Length Then
                    lblDialog.Text = lblDialog.Text & "_"
                End If
                Application.DoEvents()
                If hasClickedToContinue And isAutoCont = False Then
                    lblDialog.Text = text
                    hasClickedToContinue = False
                    Exit For
                ElseIf hasClickedToContinue And isAutoCont = True Then
                    hasClickedToContinue = False
                    Exit For
                End If
            Next
            Console.WriteLine(contMethod)
            If contMethod.Equals("clkCont") Then
                lblClickCont.Visible = True
                Do Until hasClickedToContinue
                    Threading.Thread.Sleep(10)
                    Application.DoEvents()
                Loop
                hasClickedToContinue = False
                lblClickCont.Visible = False
            ElseIf contMethod.Equals("usrIn") Then
                lblClickCont.Visible = True
                txtUserIn.Visible = True
                Do Until hasClickedToContinue And txtUserIn.Text.Trim() <> ""
                    Threading.Thread.Sleep(10)
                    hasClickedToContinue = False
                    Application.DoEvents()
                Loop
                Player.player.playerName = txtUserIn.Text
                txtUserIn.Visible = False
                lblClickCont.Visible = False
                hasClickedToContinue = False
            ElseIf contMethod.Equals("delayAutoCont") Then
                Threading.Thread.Sleep(500)
                Application.DoEvents()
                isAutoCont = False
            End If
        Next
        Threading.Thread.Sleep(300)
        Application.DoEvents()
        pnlDialog.Visible = False
    End Sub

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
        displayText(0, dialogLines.Length - 1)
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

    Private Sub lblDialog_lblClickCont_Click(sender As Object, e As EventArgs) Handles lblDialog.Click, lblClickCont.Click
        If txtUserIn.Visible = False Or txtUserIn.Text.Trim() <> "" Then
            hasClickedToContinue = True
        End If
    End Sub

End Class
