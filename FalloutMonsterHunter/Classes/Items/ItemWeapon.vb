Public Class ItemWeapon
    Inherits Item

    Private damage As Integer
    Private critChance As Integer

    Private displaySprite As Image

    Public craftingComponents As ItemStack()

    Public Shared weaponUnpheasantSword As ItemWeapon

    Overloads Public Shared Sub initialize()
        weaponUnpheasantSword = New ItemWeapon("Unpheasant Sword", 1, My.Resources.uziCartiBigBaller, 35, 3, My.Resources.uziCartiBigBaller)
        weaponUnpheasantSword.craftingComponents = {
            New ItemStack(Item.itemRaptorClaws1, 6),
            New ItemStack(Item.itemRaptorHide1, 4),
            New ItemStack(Item.itemRaptorBone1, 6)}
    End Sub

    Public Sub New(name As String, tier As Integer, image As Bitmap, damage As Integer, critChance As Integer, display As Bitmap)
        MyBase.New(name, tier, image)

        Me.setDamage(damage)
        Me.setCritChance(critChance)
        Me.setDisplaySprite(display)
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
End Class
