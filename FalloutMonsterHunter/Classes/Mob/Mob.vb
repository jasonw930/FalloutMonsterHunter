Public Class Mob

    Dim mobName As String = ""
    Dim mobSprite As Image

    Dim health As Integer
    Dim defense As Integer
    Dim attack As Integer
    Dim critChance As Integer

    Dim dropItems As List(Of Item)
    Dim dropChance As List(Of Integer)

    Public Sub New(name As String, health As Integer, defense As Integer, attack As Integer, critChance As Integer, sprite As Bitmap)
        Me.mobName = name
        Me.health = health
        Me.defense = defense
        Me.attack = attack
        Me.critChance = critChance
        Me.mobSprite = sprite
    End Sub

End Class
