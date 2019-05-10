Public Class Mob

    Public Dim mobName As String = ""
    Public Dim mobSprite As Image

    Public Dim currentHealth As Integer

    Public Dim health As Integer
    Public Dim defense As Integer
    Public Dim attack As Integer
    Public Dim critChance As Integer

    Public Dim dropItems As Item()
    Public Dim dropChance As Double()
    Public Dim dropAmount As Double()

    Public Shared mobRaptor1 As Mob

    Public Shared Sub initialize()
        mobRaptor1 = New Mob("Unpheasant", 100, 5, 25, 5, New Bitmap(0, 0))
        mobRaptor1.dropItems = {Item.itemRaptorClaws1, Item.itemRaptorHide1, Item.itemRaptorBone1, Item.itemRaptorSkull1, Item.itemRaptorTail1}
        mobRaptor1.dropChance = {0.3, 0.5, 0.5, 0.08, 0.08}
        mobRaptor1.dropAmount = {6, 6, 6, 1.8, 1.8}
    End Sub

    Public Sub New(name As String, health As Integer, defense As Integer, attack As Integer, critChance As Integer, sprite As Bitmap)
        Me.mobName = name
        Me.health = health
        Me.defense = defense
        Me.attack = attack
        Me.critChance = critChance
        Me.mobSprite = sprite
    End Sub

End Class
