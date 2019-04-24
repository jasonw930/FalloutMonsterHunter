Public Class ItemWeapon
    Inherits Item

    Private damage As Integer

    Public Sub New(name As String, damage As Integer)
        MyBase.New(name)
        Me.damage = damage
    End Sub

    Public Sub setDamage(damage As Integer)
        Me.damage = damage
    End Sub

    Public Function getDamage()
        Return Me.damage
    End Function
End Class
