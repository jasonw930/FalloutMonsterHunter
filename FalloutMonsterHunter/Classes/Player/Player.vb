Public Class Player

    Public playerName As String = ""

    Public money As Integer

    Public currentHealth As Integer

    Public health As Integer
    Public defense As Integer
    Public attack As Integer
    Public critChance As Integer
    Public luck As Integer

    Public attributeVitality As Integer
    Public attributeToughness As Integer
    Public attributeStrength As Integer
    Public attributePrecision As Integer
    Public attributeLuck As Integer

    Public inventory As List(Of ItemStack)
    Public equippedWeapon As ItemStack
    Public equippedArmor0 As ItemStack
    Public equippedArmor1 As ItemStack
    Public equippedArmor2 As ItemStack
    Public equippedArmor3 As ItemStack

    Public inventorySlotLabels(23) As Label
    Public inventorySlotPicBox(23) As PictureBox
    Public inventoryUninitiated As Boolean = True

    Public Shared player As Player

    Public Sub New(name As String)

        Me.playerName = name
        Me.money = 0

        Me.health = 100
        Me.defense = 10
        Me.attack = 25
        Me.critChance = 5
        Me.luck = 0

        Me.attributeVitality = 0
        Me.attributeToughness = 0
        Me.attributeStrength = 0
        Me.attributePrecision = 0
        Me.attributeLuck = 0

        inventory = New List(Of ItemStack)

        For x = 0 To 23
            Dim newIStack = New ItemStack(Item.itemNull, 1)
            'Console.WriteLine(newIStack.getItem().getItemName())
            Me.inventory.Add(newIStack)
            'Console.WriteLine("added " & Me.inventory(x).getItem().getItemName() & "; inv count is now " & Me.inventory.Count.ToString())
        Next

        Me.equippedWeapon = New ItemStack(Item.itemNull, 1)
        Me.equippedArmor0 = New ItemStack(Item.itemNull, 1)
        Me.equippedArmor1 = New ItemStack(Item.itemNull, 1)
        Me.equippedArmor2 = New ItemStack(Item.itemNull, 1)
        Me.equippedArmor3 = New ItemStack(Item.itemNull, 1)

        updateStats()
    End Sub

    Public Sub updateStats()
        Me.health = 100
        Me.health += If(TypeOf equippedArmor0.getItem() Is ItemArmor, DirectCast(equippedArmor0.getItem(), ItemArmor).getBonusHealth, 0)
        Me.health += If(TypeOf equippedArmor1.getItem() Is ItemArmor, DirectCast(equippedArmor1.getItem(), ItemArmor).getBonusHealth, 0)
        Me.health += If(TypeOf equippedArmor2.getItem() Is ItemArmor, DirectCast(equippedArmor2.getItem(), ItemArmor).getBonusHealth, 0)
        Me.health += If(TypeOf equippedArmor3.getItem() Is ItemArmor, DirectCast(equippedArmor3.getItem(), ItemArmor).getBonusHealth, 0)

        Me.defense = 10
        Me.defense += If(TypeOf equippedArmor0.getItem() Is ItemArmor, DirectCast(equippedArmor0.getItem(), ItemArmor).getDefence, 0)
        Me.defense += If(TypeOf equippedArmor1.getItem() Is ItemArmor, DirectCast(equippedArmor1.getItem(), ItemArmor).getDefence, 0)
        Me.defense += If(TypeOf equippedArmor2.getItem() Is ItemArmor, DirectCast(equippedArmor2.getItem(), ItemArmor).getDefence, 0)
        Me.defense += If(TypeOf equippedArmor3.getItem() Is ItemArmor, DirectCast(equippedArmor3.getItem(), ItemArmor).getDefence, 0)

        Me.attack = 25
        Me.attack += If(TypeOf equippedWeapon.getItem() Is ItemWeapon, DirectCast(equippedWeapon.getItem(), ItemWeapon).getDamage, 0)

        Me.critChance = 5
        Me.attack += If(TypeOf equippedWeapon.getItem() Is ItemWeapon, DirectCast(equippedWeapon.getItem(), ItemWeapon).getCritChance, 0)

        Me.luck = 0

        frmMain.lblStats.Text = "Health: " & Me.health & " HP" & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf &
            "Defense: " & Me.defense & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf &
            "Attack: " & Me.attack & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf &
            "Criticals: " & Me.critChance & "%"
    End Sub

    Public Function getPosOfItem(item As Item)
        For x = 0 To 23
            If Me.inventory(x).getItem.Equals(item) Then
                Return x
            End If
        Next
        Return -1
    End Function

    Public Sub condenseInventory()
        Dim emptySlots As New List(Of Integer)
        For x = 0 To Me.inventory.Count - 1
            If Me.inventory(x).Equals(Item.itemNull) Then
                emptySlots.Add(x)
            ElseIf emptySlots.Count > 0 Then
                Me.inventory(emptySlots(0)) = Me.inventory(x)
                Me.inventory(x) = New ItemStack(Item.itemNull, 1)
                emptySlots(0) = Nothing
                emptySlots.RemoveAt(0)
                emptySlots.Sort()
                emptySlots.TrimExcess()
                emptySlots.Add(x)
            End If
        Next

        For x = 0 To Me.inventory.Count - 1
            Me.inventory(x) = If(Me.inventory(x).getSize <= 0, New ItemStack(Item.itemNull, 1), Me.inventory(x))
        Next
    End Sub

    Public Sub addItemToInventory(itemStack As ItemStack)
        Me.condenseInventory()

        If Not itemStack.getItem().Equals(Item.itemNull) Then
            For x = 0 To 23
                If Me.inventory(x).getItem().Equals(itemStack.getItem()) Then
                    Me.inventory(x).setSize(Me.inventory(x).getSize() + itemStack.getSize())
                    Exit Sub
                End If
            Next

            For x = 0 To 23
                If Me.inventory(x).getItem().Equals(Item.itemNull) Then
                    Me.inventory(x) = itemStack
                    Console.WriteLine("added " & itemStack.getItem().getItemName() & " to slot " & x.ToString())
                    Exit Sub
                End If
            Next
        End If

        Me.condenseInventory()
        Me.updateInventoryVisuals()
    End Sub


    Public Sub updateInventoryVisuals()
        Dim slotCount As Integer = 0
        For Each pic In frmMain.pnlInventory.Controls.OfType(Of PictureBox) ' inventory labels
            If pic.Name.Contains("picInvSlot") Then
                Dim lengthOfDigits As Integer = pic.Name.Length - 10
                slotCount = CInt(pic.Name.Substring(10, lengthOfDigits))

                If inventoryUninitiated Then ' initiate

                    Dim newLabel As New Label
                    pic.Controls.Add(newLabel)
                    inventorySlotPicBox(slotCount) = pic
                    newLabel.Name = "lblInvSlot" & slotCount.ToString()
                    If Player.player.inventory(slotCount).getItem().getItemName().Equals("nil") Then
                        newLabel.Text = ""
                        pic.Image = Nothing
                    Else
                        newLabel.Text = "x" & Player.player.inventory(slotCount).getSize()
                        pic.Image = Player.player.inventory(slotCount).getItem().getItemSprite()
                    End If
                    newLabel.Font = New Font("Courier New", 8, FontStyle.Bold)
                    newLabel.ForeColor = Color.White
                    newLabel.BackColor = Color.Transparent
                    newLabel.AutoSize = False
                    newLabel.TextAlign = ContentAlignment.MiddleRight
                    newLabel.Size = New Point(72, 25)
                    newLabel.Location = New Point(0, 47)
                    newLabel.BringToFront()
                    newLabel.Visible = True

                    inventorySlotLabels(slotCount) = newLabel
                Else ' already initiated
                    If Player.player.inventory(slotCount).getItem().getItemName().Equals("nil") Then
                        Console.WriteLine("itemNull")
                        inventorySlotLabels(slotCount).Text = ""
                        inventorySlotPicBox(slotCount).Image = Nothing
                        inventorySlotPicBox(slotCount).Refresh()
                    Else
                        inventorySlotLabels(slotCount).Text = "x" & Player.player.inventory(slotCount).getSize
                        inventorySlotPicBox(slotCount).Image = Player.player.inventory(slotCount).getItem().getItemSprite()
                        inventorySlotPicBox(slotCount).Refresh()
                    End If
                End If
            End If
        Next

        If inventoryUninitiated Then
            For Each label As Label In inventorySlotLabels
                AddHandler label.MouseDoubleClick, AddressOf inventorSlot_MouseDoubleClick
            Next

            For Each pictBx As PictureBox In inventorySlotPicBox
                AddHandler pictBx.MouseDoubleClick, AddressOf inventorSlot_MouseDoubleClick
            Next
        End If

        inventoryUninitiated = False

    End Sub



    Public Sub equipItem(pos As Integer)
        If pos <= 23 And pos >= 0 Then
            Dim previousItem As ItemStack

            If TypeOf Me.inventory(pos).getItem Is ItemArmor Then
                Select Case DirectCast(Me.inventory(pos).getItem, ItemArmor).getArmorPos
                    Case 0
                        previousItem = Me.equippedArmor0
                        Me.equippedArmor0 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                        Me.addItemToInventory(previousItem)
                    Case 1
                        previousItem = Me.equippedArmor1
                        Me.equippedArmor1 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                        Me.addItemToInventory(previousItem)
                    Case 2
                        previousItem = Me.equippedArmor2
                        Me.equippedArmor2 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                        Me.addItemToInventory(previousItem)
                    Case 3
                        previousItem = Me.equippedArmor3
                        Me.equippedArmor3 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                        Me.addItemToInventory(previousItem)
                End Select
            ElseIf TypeOf Me.inventory(pos).getItem Is ItemWeapon Then
                previousItem = Me.equippedWeapon
                Me.equippedWeapon = Me.inventory(pos)
                Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                Me.addItemToInventory(previousItem)
            End If
        End If

        Me.updateStats()
        Me.condenseInventory()
        Me.updateInventoryVisuals()
    End Sub

    Public Sub craftItem(item As Item)
        Dim possible As Boolean = True

        If TypeOf item Is ItemArmor Then
            For Each itemStack In DirectCast(item, ItemArmor).craftingComponents
                If Me.getPosOfItem(itemStack.getItem) > -1 Then
                    possible = possible And Me.inventory(Me.getPosOfItem(itemStack.getItem)).getSize >= itemStack.getSize
                Else
                    possible = False
                End If
            Next

            If possible Then
                For Each itemStack In DirectCast(item, ItemArmor).craftingComponents
                    Dim newSize As Integer = Me.inventory(Me.getPosOfItem(itemStack.getItem)).getSize - itemStack.getSize
                    Me.inventory(Me.getPosOfItem(itemStack.getItem)).setSize(newSize)
                Next

                Me.condenseInventory()
                Me.addItemToInventory(New ItemStack(item, 1))
                Me.condenseInventory()
            End If
        ElseIf TypeOf item Is ItemWeapon Then
            For Each itemStack In DirectCast(item, ItemWeapon).craftingComponents
                If Me.getPosOfItem(itemStack.getItem) > -1 Then
                    possible = possible And Me.inventory(Me.getPosOfItem(itemStack.getItem)).getSize >= itemStack.getSize
                Else
                    possible = False
                End If
            Next

            If possible Then
                For Each itemStack In DirectCast(item, ItemWeapon).craftingComponents
                    Dim newSize As Integer = Me.inventory(Me.getPosOfItem(itemStack.getItem)).getSize - itemStack.getSize
                    Me.inventory(Me.getPosOfItem(itemStack.getItem)).setSize(newSize)
                Next

                Me.condenseInventory()
                Me.addItemToInventory(New ItemStack(item, 1))
                Me.condenseInventory()
            End If
        End If

        Me.condenseInventory()
        Me.updateInventoryVisuals()
    End Sub

    Public Sub inventorSlot_MouseDoubleClick(sender As Object, e As EventArgs)
        Console.WriteLine(sender.name & " has been double clicked")
    End Sub
End Class