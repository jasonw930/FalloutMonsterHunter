﻿Public Class Mob

    Dim mobName As String = ""
    Dim mobSprite As Image

    Dim health As Integer
    Dim defense As Integer
    Dim attack As Integer
    Dim critChance As Integer

    Dim dropItems As Item()
    Dim dropChance As Double()
    Dim dropAmount As Double()

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