Public Class ItemArmor
    Inherits Item

    Private defense As Integer
    Private bonusHealth As Integer
    Private armorPosition As Integer

    Private displaySprite As Image

    Private bigDisplaySprite As Image

    Public craftingComponents As ItemStack()

    Public Shared armorRaptorHelmet1 As ItemArmor
    Public Shared armorRaptorChestplate1 As ItemArmor
    Public Shared armorRaptorLeggings1 As ItemArmor
    Public Shared armorRaptorBoots1 As ItemArmor
                                
    Public Shared armorRaptorHelmet2 As ItemArmor
    Public Shared armorRaptorChestplate2 As ItemArmor
    Public Shared armorRaptorLeggings2 As ItemArmor
    Public Shared armorRaptorBoots2 As ItemArmor

    Public Shared armorRaptorHelmet3 As ItemArmor
    Public Shared armorRaptorChestplate3 As ItemArmor
    Public Shared armorRaptorLeggings3 As ItemArmor
    Public Shared armorRaptorBoots3 As ItemArmor

    Public Overloads Shared Sub initialize()
        armorRaptorHelmet1 = New ItemArmor("Unpheasant Helmet", 1, My.Resources.raptorHelmet1_256, 6, 5, 0, My.Resources.raptorHelmet1_Small160, My.Resources.raptorHelmet1)
        armorRaptorHelmet1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 2),
            New ItemStack(Item.itemRaptorHide1, 5),
            New ItemStack(Item.itemRaptorBone1, 5),
            New ItemStack(Item.itemRaptorSkull1, 2)}
        allCraftables(0) = armorRaptorHelmet1

        armorRaptorChestplate1 = New ItemArmor("Unpheasant Chestplate", 1, My.Resources.raptorChestplate1_256, 10, 5, 1, My.Resources.raptorChestplate1_Small160, My.Resources.raptorChestplate1)
        armorRaptorChestplate1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 3),
            New ItemStack(Item.itemRaptorHide1, 6),
            New ItemStack(Item.itemRaptorBone1, 6)}
        allCraftables(1) = armorRaptorChestplate1

        armorRaptorLeggings1 = New ItemArmor("Unpheasant Leggings", 1, My.Resources.raptorLeggings1_256, 8, 5, 2, My.Resources.raptorLeggings1_Small160, My.Resources.raptorLeggings1)
        armorRaptorLeggings1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 3),
            New ItemStack(Item.itemRaptorHide1, 6),
            New ItemStack(Item.itemRaptorBone1, 5)}
        allCraftables(2) = armorRaptorLeggings1

        armorRaptorBoots1 = New ItemArmor("Unpheasant Boots", 1, My.Resources.raptorBoots1_256, 6, 5, 3, My.Resources.raptorBoots1_Small160, My.Resources.raptorBoots1)
        armorRaptorBoots1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 2),
            New ItemStack(Item.itemRaptorHide1, 5),
            New ItemStack(Item.itemRaptorBone1, 4),
            New ItemStack(Item.itemRaptorTail1, 2)}
        allCraftables(3) = armorRaptorBoots1

        armorRaptorHelmet2 = New ItemArmor("Mutahraptor Helmet", 2, My.Resources.raptorHelmet2, 15, 10, 0, My.Resources.raptorHelmet2_Small160)
        armorRaptorHelmet2.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws2, 3),
            New ItemStack(Item.itemRaptorHide2, 6),
            New ItemStack(Item.itemRaptorBone2, 6),
            New ItemStack(Item.itemRaptorSkull2, 2)}
        allCraftables(5) = armorRaptorHelmet2

        armorRaptorChestplate2 = New ItemArmor("Mutahraptor Chestplate", 2, My.Resources.raptorChestplate2, 25, 15, 1, My.Resources.raptorChestplate2_Small160)
        armorRaptorChestplate2.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws2, 4),
            New ItemStack(Item.itemRaptorHide2, 7),
            New ItemStack(Item.itemRaptorBone2, 7)}
        allCraftables(6) = armorRaptorChestplate2

        armorRaptorLeggings2 = New ItemArmor("Mutahraptor Leggings", 2, My.Resources.raptorLeggings2, 20, 15, 2, My.Resources.raptorLeggings2_Small160)
        armorRaptorLeggings2.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws2, 4),
            New ItemStack(Item.itemRaptorHide2, 7),
            New ItemStack(Item.itemRaptorBone2, 6)}
        allCraftables(7) = armorRaptorLeggings2

        armorRaptorBoots2 = New ItemArmor("Mutahraptor Boots", 2, My.Resources.raptorBoots2, 15, 10, 3, My.Resources.raptorBoots2_Small160)
        armorRaptorBoots2.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws2, 3),
            New ItemStack(Item.itemRaptorHide2, 6),
            New ItemStack(Item.itemRaptorBone2, 5),
            New ItemStack(Item.itemRaptorTail2, 2)}
        allCraftables(8) = armorRaptorBoots2

        armorRaptorHelmet3 = New ItemArmor("Uzirappter Helmet", 3, My.Resources.uziCartiBigBaller, 25, 15, 0, My.Resources.uziCartiBigBaller)
        armorRaptorHelmet3.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws3, 4),
            New ItemStack(Item.itemRaptorHide3, 7),
            New ItemStack(Item.itemRaptorBone3, 7),
            New ItemStack(Item.itemRaptorSkull3, 2)}
        allCraftables(10) = armorRaptorHelmet3

        armorRaptorChestplate3 = New ItemArmor("Uzirappter Chestplate", 3, My.Resources.uziCartiBigBaller, 40, 20, 1, My.Resources.uziCartiBigBaller)
        armorRaptorChestplate3.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws3, 5),
            New ItemStack(Item.itemRaptorHide3, 8),
            New ItemStack(Item.itemRaptorBone3, 8)}
        allCraftables(11) = armorRaptorChestplate3

        armorRaptorLeggings3 = New ItemArmor("Uzirappter Leggings", 3, My.Resources.uziCartiBigBaller, 30, 20, 2, My.Resources.uziCartiBigBaller)
        armorRaptorLeggings3.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws3, 5),
            New ItemStack(Item.itemRaptorHide3, 8),
            New ItemStack(Item.itemRaptorBone3, 7)}
        allCraftables(12) = armorRaptorLeggings3

        armorRaptorBoots3 = New ItemArmor("Uzirappter Boots", 3, My.Resources.uziCartiBigBaller, 25, 15, 3, My.Resources.uziCartiBigBaller)
        armorRaptorBoots3.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws3, 4),
            New ItemStack(Item.itemRaptorHide3, 7),
            New ItemStack(Item.itemRaptorBone3, 6),
            New ItemStack(Item.itemRaptorTail3, 2)}
        allCraftables(13) = armorRaptorBoots3

    End Sub

    Public Sub New(name As String, tier As Integer, image As Bitmap, defense As Integer, health As Integer, position As Integer, display As Bitmap, Optional bigDisplay As Bitmap = Nothing)
        MyBase.New(name, tier, image)

        Me.setDefense(defense)
        Me.setBonusHealth(health)
        Me.setArmorPos(position)
        Me.setDisplaySprite(display)
        Me.setBigDisplaySprite(If(bigDisplay Is Nothing, display, bigDisplay))
    End Sub

    Public Sub setDefense(defense As Integer)
        Me.defense = defense
    End Sub

    Public Function getDefence()
        Return Me.defense
    End Function

    Public Sub setBonusHealth(health As Integer)
        Me.bonusHealth = health
    End Sub

    Public Function getBonusHealth()
        Return Me.bonusHealth
    End Function

    Public Sub setArmorPos(pos As Integer)
        Me.armorPosition = pos
    End Sub

    Public Function getArmorPos()
        Return Me.armorPosition
    End Function

    Public Sub setDisplaySprite(sprite As Image)
        Me.displaySprite = sprite
    End Sub

    Public Function getDisplaySprite()
        Return Me.displaySprite
    End Function

    Public Sub setBigDisplaySprite(sprite As Image)
        Me.bigDisplaySprite = sprite
    End Sub

    Public Function getBigDisplaySprite()
        Return Me.bigDisplaySprite
    End Function

End Class
