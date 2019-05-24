Public Class ItemArmor
    Inherits Item

    Private defense As Integer
    Private bonusHealth As Integer
    Private armorPosition As Integer

    Private displaySprite As Image

    Public craftingComponents As ItemStack()

    Public Shared armorRaptorHelmet1 As ItemArmor
    Public Shared armorRaptorChestplate1 As ItemArmor
    Public Shared armorRaptorLeggings1 As ItemArmor
    Public Shared armorRaptorBoots1 As ItemArmor

    Public Overloads Shared Sub initialize()
        armorRaptorHelmet1 = New ItemArmor("Unpheasant Helmet", 1, My.Resources.uziCartiBigBaller, 6, 5, 0, My.Resources.uziCartiBigBaller)
        armorRaptorHelmet1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 2),
            New ItemStack(Item.itemRaptorHide1, 5),
            New ItemStack(Item.itemRaptorBone1, 5),
            New ItemStack(Item.itemRaptorSkull1, 2)}
        allCraftables(0) = armorRaptorHelmet1

        armorRaptorChestplate1 = New ItemArmor("Unpheasant Chestplate", 1, My.Resources.uziCartiBigBaller, 10, 5, 1, My.Resources.uziCartiBigBaller)
        armorRaptorChestplate1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 3),
            New ItemStack(Item.itemRaptorHide1, 6),
            New ItemStack(Item.itemRaptorBone1, 6)}
        allCraftables(1) = armorRaptorChestplate1

        armorRaptorLeggings1 = New ItemArmor("Unpheasant Leggings", 1, My.Resources.uziCartiBigBaller, 8, 5, 2, My.Resources.uziCartiBigBaller)
        armorRaptorLeggings1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 3),
            New ItemStack(Item.itemRaptorHide1, 6),
            New ItemStack(Item.itemRaptorBone1, 5)}
        allCraftables(2) = armorRaptorLeggings1

        armorRaptorBoots1 = New ItemArmor("Unpheasant Boots", 1, My.Resources.uziCartiBigBaller, 6, 5, 3, My.Resources.uziCartiBigBaller)
        armorRaptorBoots1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 2),
            New ItemStack(Item.itemRaptorHide1, 5),
            New ItemStack(Item.itemRaptorBone1, 4),
            New ItemStack(Item.itemRaptorTail1, 2)}
        allCraftables(3) = armorRaptorBoots1


    End Sub

    Public Sub New(name As String, tier As Integer, image As Bitmap, defense As Integer, health As Integer, position As Integer, display As Bitmap)
        MyBase.New(name, tier, image)

        Me.setDefense(defense)
        Me.setBonusHealth(health)
        Me.setArmorPos(position)
        Me.setDisplaySprite(display)
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
End Class
