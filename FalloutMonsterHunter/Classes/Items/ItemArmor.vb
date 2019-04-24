Public Class ItemArmor
    Inherits Item

    Private defense As Integer
    Private bonusHealth As Integer

    Public Sub New(name As String)
        MyBase.New(name)
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
End Class
