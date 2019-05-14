Public Class ItemArmor
    Inherits Item

    Private defense As Integer
    Private bonusHealth As Integer
    Private armorPosition As Integer

    Private displaySprite As Image

    Public Shared armorUnpheasantHelmet As ItemArmor
    Public Shared armorUnpheasantChestplate As ItemArmor
    Public Shared armorUnpheasantLeggings As ItemArmor
    Public Shared armorUnpheasantBoots As ItemArmor

    Public Shared Sub initialize()
        armorUnpheasantHelmet = New ItemArmor("Unpheasant Helmet", 1, My.Resources.uziCartiBigBaller, 6, 5, 0, My.Resources.uziCartiBigBaller)
        armorUnpheasantHelmet = New ItemArmor("Unpheasant Helmet", 1, My.Resources.uziCartiBigBaller, 6, 5, 1, My.Resources.uziCartiBigBaller)
        armorUnpheasantHelmet = New ItemArmor("Unpheasant Helmet", 1, My.Resources.uziCartiBigBaller, 6, 5, 2, My.Resources.uziCartiBigBaller)
        armorUnpheasantHelmet = New ItemArmor("Unpheasant Helmet", 1, My.Resources.uziCartiBigBaller, 6, 5, 3, My.Resources.uziCartiBigBaller)
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
