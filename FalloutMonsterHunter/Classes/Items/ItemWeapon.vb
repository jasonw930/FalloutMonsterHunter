Public Class ItemWeapon
    Inherits Item

    Private damage As Integer
    Private critChance As Integer

    Private displaySprite As Image

    Private bigDisplaySprite As Image

    Public craftingComponents As ItemStack()

    Public Shared weaponRaptorSword1 As ItemWeapon
    Public Shared weaponRaptorSword2 As ItemWeapon
    Public Shared weaponRaptorSword3 As ItemWeapon

    Public Overloads Shared Sub initialize()
        weaponRaptorSword1 = New ItemWeapon("Unpheasant Sword", 1, My.Resources.raptorWeapon1_256, 35, 3, My.Resources.raptorWeapon1_Small160, My.Resources.raptorWeapon1)
        weaponRaptorSword1.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 6),
            New ItemStack(Item.itemRaptorHide1, 4),
            New ItemStack(Item.itemRaptorBone1, 6)}
        allCraftables(4) = weaponRaptorSword1

        weaponRaptorSword2 = New ItemWeapon("Mutahraptor Sword", 2, My.Resources.raptorWeapon2, 80, 5, My.Resources.raptorWeapon2_Small160)
        weaponRaptorSword2.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws2, 7),
            New ItemStack(Item.itemRaptorHide2, 5),
            New ItemStack(Item.itemRaptorBone2, 7)}
        allCraftables(9) = weaponRaptorSword2

        weaponRaptorSword3 = New ItemWeapon("Uzirappter Sword", 3, My.Resources.uziCartiBigBaller, 120, 6, My.Resources.uziCartiBigBaller)
        weaponRaptorSword3.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws3, 9),
            New ItemStack(Item.itemRaptorHide3, 6),
            New ItemStack(Item.itemRaptorBone3, 9)}
        allCraftables(14) = weaponRaptorSword3
    End Sub

    Public Sub New(name As String, tier As Integer, image As Bitmap, damage As Integer, critChance As Integer, display As Bitmap, Optional bigDisplay As Bitmap = Nothing)
        MyBase.New(name, tier, image)

        Me.setDamage(damage)
        Me.setCritChance(critChance)
        Me.setDisplaySprite(display)
        Me.setBigDisplaySprite(If(bigDisplay Is Nothing, display, bigDisplay))
    End Sub

    Public Sub setDamage(damage As Integer)
        Me.damage = damage
    End Sub

    Public Function getDamage()
        Return Me.damage
    End Function

    Public Sub setCritChance(chance As Integer)
        Me.critChance = chance
    End Sub

    Public Function getCritChance()
        Return Me.critChance
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
