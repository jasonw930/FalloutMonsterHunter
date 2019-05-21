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
    End Sub

    Public Function getPosOfItem(item As Item)
        For x = 0 To 23
            If Me.inventory(x).getItem = item Then
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
        Next x
    End Sub

    Public Sub addItemToInventory(itemStack As ItemStack)
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
    End Sub


    Public Sub updateInventoryVisuals()
        Dim slotCount As Integer = 0
        For Each pic In frmMain.pnlInventory.Controls.OfType(Of PictureBox)
            If pic.Name.Substring(0, 10).Equals("picInvSlot") Then
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
        inventoryUninitiated = False
    End Sub



    Public Sub equipItem(pos As Integer)
        If pos <= 23 And pos >= 0 Then
            If TypeOf Me.inventory(pos).getItem Is ItemArmor Then
                Select Case DirectCast(Me.inventory(pos).getItem, ItemArmor).getArmorPos
                    Case 0
                        Me.equippedArmor0 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                    Case 1
                        Me.equippedArmor1 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                    Case 2
                        Me.equippedArmor2 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                    Case 3
                        Me.equippedArmor3 = Me.inventory(pos)
                        Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
                End Select
            End If

            If TypeOf Me.inventory(pos).getItem Is ItemWeapon Then
                Me.equippedWeapon = Me.inventory(pos)
                Me.inventory(pos) = New ItemStack(Item.itemNull, 0)
            End If
        End If
        Me.updateStats()
    End Sub

    Public Sub craftItem(item As Item)
        Dim valid As Boolean = True

        If TypeOf item Is ItemArmor Then
            For Each itemStack In DirectCast(item, ItemArmor).craftingComponents
                
            Next
        End If
    End Sub

End Class