Public Class frmMain
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
    Dim cheatGodMode As Boolean

    Dim craftingMenuItems As New List(Of Panel)
    Dim selectedCraftingItem As Item

    Dim componentImage As New List(Of PictureBox)
    Dim componentLabel As New List(Of Label)

    'Form Load--------------------------------------------------------------------------------------------
    Public Function resizeImage(source As Bitmap, x As Integer, y As Integer)
        'Dim sourceImg As Bitmap
        'sourceImg = source

        'If sourceImg.Width = x And sourceImg.Height = y Then
        '    Return sourceImg
        'End If

        '' Make a bitmap for the result.
        'Dim resultBitmap As New Bitmap(x, y)

        '' Make a Graphics object for the result Bitmap.
        'Dim resultGraphics As Graphics = Graphics.FromImage(resultBitmap)

        '' Copy the source image into the destination bitmap.
        'resultGraphics.DrawImage(sourceImg, 0, 0,
        'resultBitmap.Width + 1,
        'resultBitmap.Height + 1)

        '' Display the result.
        'Return resultBitmap
        If source.Width = x And source.Height = y Then
            Return source
        End If
        Return New Bitmap(source, New Size(x, y))
    End Function


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

        For Each scenepnl In Me.Controls.OfType(Of Panel) ' add handlers to fight buttons
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
        cheatGodMode = False


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

        For indixx As Integer = 0 To Item.allCraftables.Length - 1 ' initialize crafting menu
            If Item.allCraftables(indixx) Is Nothing Then
                pnlScrollFrame.Size = New Point(349, indixx * 90)
                scrlCraftingList.Minimum = 0
                scrlCraftingList.Maximum = Math.Max(0, indixx * 90 - pnlCraftingList.Size.Height)
                scrlCraftingList.SmallChange = 6
                scrlCraftingList.LargeChange = 9
                Console.WriteLine("ended at " & indixx.ToString())
                Exit For
            End If
            Dim newPanel As New Panel
            pnlScrollFrame.Controls.Add(newPanel)
            craftingMenuItems.Add(newPanel)
            newPanel.Name = "pnlCraft" & indixx.ToString()
            newPanel.Size = New Point(349, 90)
            newPanel.BackColor = Color.Silver
            newPanel.Location = New Point(0, indixx * 90)
            AddHandler newPanel.Click, AddressOf pnlCraftItem_Click
            Dim newCraftPic As New PictureBox
            newPanel.Controls.Add(newCraftPic)
            newCraftPic.Name = "picCraft" & indixx.ToString()
            newCraftPic.Size = New Point(72, 72)
            newCraftPic.Location = New Point(12, 9)
            newCraftPic.BackColor = Color.Transparent
            newCraftPic.Image = resizeImage(Item.allCraftables(indixx).getItemSprite(), 72, 72)
            AddHandler newCraftPic.Click, AddressOf pnlCraftItem_Click
            Dim newCraftLbl As New Label
            newPanel.Controls.Add(newCraftLbl)
            newCraftLbl.Name = "lblCraft" & indixx.ToString()
            newCraftLbl.Size = New Point(240, 72)
            newCraftLbl.Location = New Point(96, 9)
            newCraftLbl.Font = New Font("Courier New", 10, FontStyle.Bold)
            newCraftLbl.ForeColor = Color.White
            newCraftLbl.BackColor = Color.Transparent
            newCraftLbl.Text = Item.allCraftables(indixx).getItemName()
            newCraftLbl.TextAlign = ContentAlignment.MiddleLeft
            AddHandler newCraftLbl.Click, AddressOf pnlCraftItem_Click

        Next

        'For indixx As Integer = 0 To craftingMenuItems.Count - 1
        '    For Each crftPic In craftingMenuItems(indixx).Controls.OfType(Of PictureBox)
        '        crftPic.Image = Item.allCraftables(indixx).getItemSprite()
        '    Next
        '    For Each crftLbl In craftingMenuItems(indixx).Controls.OfType(Of Label)
        '        crftLbl.Text = Item.allCraftables(indixx).getItemName()
        '    Next
        'Next

        selectedCraftingItem = Item.itemNull

        componentImage.Add(picComponent0)
        componentImage.Add(picComponent1)
        componentImage.Add(picComponent2)
        componentImage.Add(picComponent3)
        componentImage.Add(picComponent4)

        componentLabel.Add(lblCraftingComponent0)
        componentLabel.Add(lblCraftingComponent1)
        componentLabel.Add(lblCraftingComponent2)
        componentLabel.Add(lblCraftingComponent3)
        componentLabel.Add(lblCraftingComponent4)

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

        picHelmet.Image = If(TypeOf Player.player.equippedArmor0.getItem() Is ItemArmor, resizeImage(Player.player.equippedArmor0.getItem().getDisplaySprite(), 160, 200), Nothing)
        picChestplate.Image = If(TypeOf Player.player.equippedArmor1.getItem() Is ItemArmor, resizeImage(Player.player.equippedArmor1.getItem().getDisplaySprite(), 160, 200), Nothing)
        picLeggings.Image = If(TypeOf Player.player.equippedArmor2.getItem() Is ItemArmor, resizeImage(Player.player.equippedArmor2.getItem().getDisplaySprite(), 160, 200), Nothing)
        picBoots.Image = If(TypeOf Player.player.equippedArmor3.getItem() Is ItemArmor, resizeImage(Player.player.equippedArmor3.getItem().getDisplaySprite(), 160, 200), Nothing)
        picWeapon.Image = If(TypeOf Player.player.equippedWeapon.getItem() Is ItemWeapon, resizeImage(Player.player.equippedWeapon.getItem().getDisplaySprite(), 160, 200), resizeImage(My.Resources.arms, 160, 200))
        pnlPlayer.BackgroundImage = If(TypeOf Player.player.equippedArmor3.getItem() Is ItemArmor, My.Resources.Player_Shoeless_Small160, My.Resources.Player_Small160)

        pnlMob.BackgroundImage = mob.mobSprite

        Do While True
            Randomize()
            Dim attackValue As Integer
            Dim animationSpeed As Integer = If(cheatFastFight, 50, 1000)

            'Player Attack
            attackValue = (player.attack - mob.defense) * If(Rnd() <= player.critChance / 100, 2, 1)
            attackValue += If(cheatGodMode, 9001, 0)
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
            lblReceived.Text = "You Won!"
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
                    dropPics(numDrops).Image = resizeImage(item.getItemSprite(), 72, 72)
                    dropLbls(numDrops).Text = "x" & amount.ToString() & " " & item.getItemName()
                    numDrops += 1
                End If
            Next
        Else
            lblReceived.Text = "Defeat!"
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
                cheatSkipCutscene = Player.player.playerName.Contains("skipCutscene") Or Player.player.playerName.Contains("ALL")
                cheatFastFight = Player.player.playerName.Contains("fastFight") Or Player.player.playerName.Contains("ALL")
                cheatGodMode = Player.player.playerName.Contains("godMode") Or Player.player.playerName.Contains("ALL")

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

    Private Sub updateCraftability()
        If TypeOf selectedCraftingItem Is ItemArmor Then
            Dim craftItem As ItemArmor = DirectCast(selectedCraftingItem, ItemArmor)
            lblCraftStats.Text = "Health +" & craftItem.getBonusHealth().ToString() & vbCrLf & vbCrLf & "Defence +" & craftItem.getDefence().ToString() & vbCrLf & vbCrLf & "Luck: +0"
            For index As Integer = 0 To 4
                If index < craftItem.craftingComponents.Length Then
                    componentImage(index).Image = resizeImage(craftItem.craftingComponents(index).getItem().getItemSprite(), 72, 72)
                    componentLabel(index).Text = "x" & craftItem.craftingComponents(index).getSize()
                    If Player.player.getPosOfItem(craftItem.craftingComponents(index).getItem()) > -1 Then
                        componentLabel(index).ForeColor = If(Player.player.inventory(Player.player.getPosOfItem(craftItem.craftingComponents(index).getItem())).getSize() >= craftItem.craftingComponents(index).getSize(), Color.White, Color.Black)
                    Else
                        componentLabel(index).ForeColor = Color.Black
                    End If
                Else
                    componentImage(index).Image = Nothing
                    componentImage(index).BackColor = Color.Transparent
                    componentLabel(index).Text = Nothing
                End If
            Next
            picCraftPic.Image = craftItem.getItemSprite()
        ElseIf TypeOf selectedCraftingItem Is ItemWeapon Then
            Dim craftItem As ItemWeapon = DirectCast(selectedCraftingItem, ItemWeapon)
            lblCraftStats.Text = "Attack +" & craftItem.getDamage().ToString() & vbCrLf & vbCrLf & "Criticals +" & craftItem.getCritChance().ToString()
            For index As Integer = 0 To 4
                If index < craftItem.craftingComponents.Length Then
                    componentImage(index).Image = resizeImage(craftItem.craftingComponents(index).getItem().getItemSprite(), 72, 72)
                    componentLabel(index).Text = "x" & craftItem.craftingComponents(index).getSize()
                    If Player.player.getPosOfItem(craftItem.craftingComponents(index).getItem()) > -1 Then
                        componentLabel(index).ForeColor = If(Player.player.inventory(Player.player.getPosOfItem(craftItem.craftingComponents(index).getItem())).getSize() >= craftItem.craftingComponents(index).getSize(), Color.White, Color.Black)
                    Else
                        componentLabel(index).ForeColor = Color.Black
                    End If
                Else
                    componentImage(index).Image = Nothing
                    componentImage(index).BackColor = Color.Transparent
                    componentLabel(index).Text = Nothing
                End If
            Next
            picCraftPic.Image = craftItem.getItemSprite()
        Else
            lblCraftName.Text = Nothing
            picCraftPic.Image = Nothing
            lblCraftStats.Text = Nothing
            For Each picture In componentImage
                picture.Image = Nothing
            Next
            For Each label In componentLabel
                label.Text = Nothing
            Next
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

    Private Sub btnFightMob_Click(sender As Object, e As EventArgs)
        If Not isFighting Then
            isFighting = True
            Select Case sender.Name
                Case "btnFightUnpheasantRaptor"
                    fight(Player.player, Mob.mobRaptor1)
                Case "btnFightMutahraptor"
                    fight(Player.player, Mob.mobRaptor2)
            End Select
        End If
    End Sub


    Private Sub lblDialog_lblClickCont_Click(sender As Object, e As EventArgs) Handles lblDialog.Click, lblClickCont.Click
        If txtUserIn.Visible = False Or txtUserIn.Text.Trim() <> "" Then
            hasClickedToContinue = True
        End If
    End Sub

    Private Sub lblExitDropMenu_Click(sender As Object, e As EventArgs) Handles lblExitDropMenu.Click
        For invisIndex As Integer = 0 To dropPics.Length - 1
            dropPics(invisIndex).Image = Nothing
            dropLbls(invisIndex).Text = Nothing
        Next

        pnlDropMenu.Visible = False
        transition(currentCity)
    End Sub

    Private Sub lblExitInventory_Click(sender As Object, e As EventArgs) Handles lblExitInventory.Click
        If Not Player.player.isDeleting Then
            transition(currentCity)
        End If
    End Sub




    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        transition(pnlInventory)
        Player.player.updateInventoryVisuals()
    End Sub

    Private Sub btnCrafting_Click(sender As Object, e As EventArgs) Handles btnCrafting.Click
        transition(pnlCraftingMenu)
        updateCraftability()
    End Sub

    Private Sub scrlCraftingList_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCraftingList.Scroll
        pnlScrollFrame.Location = New Point(0, scrlCraftingList.Value * -1)
    End Sub

    Private Sub pnlCraftItem_Click(sender As Object, e As EventArgs)
        selectedCraftingItem = Item.allCraftables(CInt(sender.name.SubString(8)))
        lblCraftName.Text = selectedCraftingItem.getItemName()
        updateCraftability()
    End Sub

    Private Sub pnlCraftButton(sender As Object, e As EventArgs) Handles btnCraftEquipment.Click
        If Player.player.craftItem(selectedCraftingItem) Then
            Console.WriteLine("crafted " & selectedCraftingItem.getItemName())
            lblCraftName.Text = "Successfully crafted " & selectedCraftingItem.getItemName()
            updateCraftability()
            wait(2250)
            lblCraftName.Text = selectedCraftingItem.getItemName()
        End If
    End Sub

    Private Sub lblCloseCrafting_Click(sender As Object, e As EventArgs) Handles lblCloseCrafting.Click
        transition(currentCity)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Player.player.finalDelete = 1
        Player.player.deleteItem(Player.player.toDelete)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Player.player.finalDelete = 0
        Player.player.deleteItem(Player.player.toDelete)
    End Sub
End Class