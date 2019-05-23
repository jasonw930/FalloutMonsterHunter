﻿Public Class frmMain
    'Variables--------------------------------------------------------------------------------------------
    Dim fadingControls As New List(Of Object)
    Dim panelsAndPics As New Dictionary(Of Panel, PictureBox)

    Dim dropPics(5) As PictureBox
    Dim dropLbls(5) As Label

    Dim currentCity As Panel
    Dim currentScene As Panel
    Dim currentUnlockedCity As Panel
    Dim isFighting As Boolean = False

    'Dim inventorySlotLabels As New List(Of Label)
    'Dim inventorySlotPicBox As New List(Of PictureBox)

    Dim isAutoCont As Boolean = False

    Dim dialogLines As String()

    Dim cheatSkipCutscene As Boolean
    Dim cheatFastFight As Boolean

    'Form Load--------------------------------------------------------------------------------------------
    Private Sub formLoad() Handles Me.Load
        Console.WriteLine("---------------------------------------------")

        For Each pnl In Me.Controls.OfType(Of Panel)
            pnl.Location = New System.Drawing.Point(0, 0)
        Next

        For Each picBox In pnlDropMenu.Controls.OfType(Of PictureBox) ' add drop menu pics to array
            Dim lengthOfDigits As Integer = picBox.Name.Length - 7
            Dim dropPos = CInt(picBox.Name.Substring(7, lengthOfDigits))
            dropPics(dropPos) = picBox
        Next

        For Each lbl In pnlDropMenu.Controls.OfType(Of Label) ' add drop menu labels to array
            If lbl.Name.Contains("lblDrop") Then
                Dim lengthOfDigits As Integer = lbl.Name.Length - 7
                Dim dropPos = CInt(lbl.Name.Substring(7, lengthOfDigits))
                dropLbls(dropPos) = lbl
            End If
        Next

        For Each scenepnl In Me.Controls.OfType(Of Panel)
            If scenepnl.Name.Contains("City") Then
                For Each btn In scenepnl.Controls.OfType(Of Button)
                    If btn.Name.Contains("Fight") Then
                        AddHandler btn.Click, AddressOf btnFightMob_Click
                    End If
                Next
            End If
        Next

        picFader.Location = New Point(0, 0)
        picFader2.Location = New Point(0, 0)
        pnlMainMenu.Visible = True
        pnlMainMenu.BringToFront()

        panelsAndPics.Add(pnlIntro, picIntro)
        panelsAndPics.Add(pnlMainMenu, picBackdrop)



        cheatSkipCutscene = False
        cheatFastFight = False

        Player.player = New Player("Bob")

        ' note: '|' stands for Player.player.playerName; replaced at runtime of the line, so we don't affix the Player.player.playerName before user inputs it
        ' the transitions/continue to next line methods are: 
        ' clkCont --> wait for user to click before continuing
        ' usrIn --> wait for user to input something (that is not "", even when trimmed) and click before continuing
        ' delayAutoCont --> wait for 500 milliseconds before continuing to next line automatically. if user clicks to interrupt, stop typing (whole line will not be displayed) and wait 500 milliseconds before going to next line

        'key: 0-21 = intro; 
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
            "<Misa>I am sorry, my love. You must survive this. You must survive to ensure our child does, too. I love you, " & "|" & ", I always will. I lo--(atomBlast)",
            "<...>[You hear a deafening burst]" & vbCrLf & vbCrLf & "[Your vision fills with white]" & vbCrLf & vbCrLf & "[You start to feel yourself slipping...](clkCont)"
        }

        Item.initialize()
        ItemArmor.initialize()
        ItemWeapon.initialize()
        Mob.initialize()
        Player.player = New Player("Bob")
    End Sub

    'Procedures-------------------------------------------------------------------------------------------
    Private Sub transition(scene As Panel)
        scene.BringToFront()
        scene.Visible = True
        If scene.Name = "pnlFujiCity" Or scene.Name = "pnlKyoto" Or scene.Name = "pnlHiroshima" Then
            currentCity = scene
            currentScene = scene
        Else
            currentScene = scene
        End If
    End Sub

    Dim waitDone As Boolean = False

    Public Sub waitTimerWaiter() Handles waitTimer.Tick
        waitTimer.Stop()
        waitDone = True
    End Sub

    Public Sub wait(time As Integer)
        waitTimer.Interval = time
        waitTimer.Start()
        Do Until waitDone
            Application.DoEvents()
        Loop
        waitDone = False
    End Sub

    Public Sub fight(player As Player, mob As Mob, Optional prevCity As Panel = Nothing)
        Dim result As Boolean
        'Fight
        transition(pnlFight)
        player.updateStats()
        player.currentHealth = player.health
        mob.currentHealth = mob.health
        Do While True
            Randomize()
            Dim attackValue As Integer
            Dim animationSpeed As Integer = If(cheatFastFight, 50, 1000)

            'Player Attack
            attackValue = (player.attack - mob.defense) * If(Rnd() <= player.critChance / 100, 2, 1)
            mob.currentHealth -= attackValue
            Console.WriteLine(mob.currentHealth & " is Raptor's health")


            pnlPlayer.Location = New Point(290, 479)
            wait(animationSpeed)
            Application.DoEvents()
            pnlPlayer.Location = New Point(90, 479)
            wait(animationSpeed)
            Application.DoEvents()

            If mob.currentHealth <= 0 Then
                result = True
                Exit Do
            End If

            'Mob Attack
            attackValue = (mob.attack - player.defense) * If(Rnd() <= mob.critChance / 100, 2, 1)
            player.currentHealth -= attackValue
            Console.WriteLine(player.currentHealth & " is Player's health")

            pnlMob.Location = New Point(270, 499)
            wait(animationSpeed)
            Application.DoEvents()
            pnlMob.Location = New Point(470, 499)
            wait(animationSpeed)
            Application.DoEvents()

            If player.currentHealth <= 0 Then
                result = False
                Exit Do
            End If

            Threading.Thread.Sleep(1000)
            Application.DoEvents()
        Loop
        'Result
        If result Then
            Dim numDrops As Integer = 0
            For x = 0 To mob.dropItems.Length - 1
                Randomize()
                Dim item As Item = mob.dropItems(x)
                Dim amount As Integer = If(Rnd() <= mob.dropChance(x), Int(Rnd() * mob.dropAmount(x)) + 1, 0)
                Dim itemStack As ItemStack = If(amount > 0, New ItemStack(item, amount), New ItemStack(Item.itemNull, 1))
                player.addItemToInventory(itemStack)
                Console.WriteLine(itemStack.getSize() & " " & itemStack.getItem().getItemName() & " was dropped")
                ' update drop menu
                If amount > 0 Then
                    dropPics(numDrops).Image = item.getItemSprite()
                    dropLbls(numDrops).Text = "x" & amount.ToString() & " " & item.getItemName()
                    numDrops += 1
                End If
            Next
        End If
        Console.WriteLine("finished fighting")
        isFighting = False
        pnlDropMenu.Visible = True
    End Sub

    Dim toVisible As Object
    Dim hasClickedToContinue As Boolean = False

    Public Sub displayText(dialogRollStart As Integer, dialogRollEnd As Integer, Optional targetPanel As Panel = Nothing)
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

            If contMethod.Equals("delayAutoCont") Or contMethod.Equals("atomBlast") Then
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

                'Player Cheats Enable
                If Player.player.playerName.Contains("skipCutscene") Then
                    cheatSkipCutscene = True
                End If
                If Player.player.playerName.Contains("fastFight") Then
                    cheatFastFight = True
                End If

                txtUserIn.Visible = False
                lblClickCont.Visible = False
                hasClickedToContinue = False
                If cheatSkipCutscene Then
                    Exit For
                End If
            ElseIf contMethod.Equals("delayAutoCont") Then
                Threading.Thread.Sleep(500)
                Application.DoEvents()
                isAutoCont = False
            ElseIf contMethod.Equals("atomBlast") Then
                Threading.Thread.Sleep(500)
                Application.DoEvents()
                Dim currentPicbox As PictureBox = panelsAndPics.Item(currentScene)
                Console.WriteLine(currentPicbox.Name)
                currentPicbox.Image = Nothing
                currentPicbox.BackColor = Color.White
                Threading.Thread.Sleep(2000)
                Application.DoEvents()
                isAutoCont = False
            End If
        Next
        Threading.Thread.Sleep(300)
        Application.DoEvents()
        pnlDialog.Visible = False
        If targetPanel IsNot Nothing Then
            transition(targetPanel)
        End If

    End Sub

    'Event Handles---------------------------------------------------------------------------------------

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Console.WriteLine("now we're running")
        transition(pnlIntro)
        Application.DoEvents()
        displayText(0, 21, pnlFujiCity)

        transition(pnlFujiCity)

    End Sub

    Private Sub btnFightMob_Click()
        If Not isFighting Then
            isFighting = True
            fight(Player.player, Mob.mobRaptor1)
        End If
    End Sub


    Private Sub lblDialog_lblClickCont_Click(sender As Object, e As EventArgs) Handles lblDialog.Click, lblClickCont.Click
        If txtUserIn.Visible = False Or txtUserIn.Text.Trim() <> "" Then
            hasClickedToContinue = True
        End If
    End Sub

    Private Sub pnlInventory_Click(sender As Object, e As EventArgs) Handles pnlInventory.Click
        transition(currentCity)
    End Sub

    Private Sub picInvSlot23_Click() Handles picInvSlot23.Click
        Player.player.craftItem(ItemArmor.armorUnpheasantLeggings)
    End Sub

    Private Sub lblExitDropMenu_Click(sender As Object, e As EventArgs) Handles lblExitDropMenu.Click
        For invisIndex As Integer = 0 To dropPics.Length - 1
            dropPics(invisIndex).Image = Nothing
            dropLbls(invisIndex).Text = Nothing
        Next

        pnlDropMenu.Visible = False
        transition(pnlInventory)
        Player.player.updateInventoryVisuals()
    End Sub

    Private Sub lblExitInventory_Click(sender As Object, e As EventArgs) Handles lblExitInventory.Click
        transition(currentCity)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        transition(pnlInventory)
        Player.player.updateInventoryVisuals()
    End Sub

    Private Sub picInvSlot23_Click(sender As Object, e As EventArgs) Handles picInvSlot23.Click

    End Sub
End Class
