Public Class Player

    Dim playerName As String = ""

    Dim money As Integer

    Dim health As Integer
    Dim defense As Integer
    Dim attack As Integer
    Dim critChance As Integer
    Dim luck As Integer

    Dim attributeVitality As Integer
    Dim attributeToughness As Integer
    Dim attributeStrength As Integer
    Dim attributePrecision As Integer
    Dim attributeLuck As Integer

    Dim inventory As List(Of ItemStack)
    Dim equippedWeapon As ItemStack
    Dim equippedArmor0 As ItemStack
    Dim equippedArmor1 As ItemStack
    Dim equippedArmor2 As ItemStack
    Dim equippedArmor3 As ItemStack

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

        For x = 0 To 23
            'Me.inventory.Add(New ItemStack(Item.itemNull, 1))
        Next

        'Dim equippedWeapon As ItemStack = New ItemStack(Item.itemNull, 1)
        'Dim equippedArmor0 As ItemStack = New ItemStack(Item.itemNull, 1)
        'Dim equippedArmor1 As ItemStack = New ItemStack(Item.itemNull, 1)
        'Dim equippedArmor2 As ItemStack = New ItemStack(Item.itemNull, 1)
        'Dim equippedArmor3 As ItemStack = New ItemStack(Item.itemNull, 1)
    End Sub

    Public Sub updateStats()
        Me.health = 100
        Me.health += If(TypeOf (equippedArmor0.getItem()) Is ItemArmor, DirectCast(equippedArmor0.getItem(), ItemArmor).getBonusHealth, 0)
        Me.health += If(TypeOf (equippedArmor1.getItem()) Is ItemArmor, DirectCast(equippedArmor1.getItem(), ItemArmor).getBonusHealth, 0)
        Me.health += If(TypeOf (equippedArmor2.getItem()) Is ItemArmor, DirectCast(equippedArmor2.getItem(), ItemArmor).getBonusHealth, 0)
        Me.health += If(TypeOf (equippedArmor3.getItem()) Is ItemArmor, DirectCast(equippedArmor3.getItem(), ItemArmor).getBonusHealth, 0)

        Me.attack = 25
        Me.attack += If(TypeOf (equippedWeapon.getItem()) Is ItemWeapon, DirectCast(equippedWeapon.getItem(), ItemWeapon).getDamage, 0)

        Me.critChance = 5
        Me.attack += If(TypeOf (equippedWeapon.getItem()) Is ItemWeapon, DirectCast(equippedWeapon.getItem(), ItemWeapon).getCritChance, 0)

        Me.luck = 0
    End Sub

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



End Class