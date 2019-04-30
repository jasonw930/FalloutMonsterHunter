Public Class Item
    Private itemName As String = ""
    Private itemTier As Integer
    Private itemSprite As Image

    Shared itemRaptorClaws1 As New Item("Unpheasant Claw", 1, My.Resources.uziCartiBigBaller)
    Shared itemRaptorHide1 As New Item("Unpheasant Hide", 1)
    Shared itemRaptorBone1 As New Item("Unpheasant Bone", 1)
    Shared itemRaptorSkull1 As New Item("Unpheasant Skull", 1)
    Shared itemRaptorTail1 As New Item("Unpheasant Tail", 1)

    Shared itemRaptorClaws2 As New Item("Mutahraptor Claw", 2)
    Shared itemRaptorHide2 As New Item("Mutahraptor Hide", 2)
    Shared itemRaptorBone2 As New Item("Mutahraptor Bone", 2)
    Shared itemRaptorSkull2 As New Item("Mutahraptor Skull", 2)
    Shared itemRaptorTail2 As New Item("Mutahraptor Tail", 2)

    Shared itemRaptorClaws3 As New Item("Uzirappter Claw", 3)
    Shared itemRaptorHide3 As New Item("Uzirappter Hide", 3)
    Shared itemRaptorBone3 As New Item("Uzirappter Bone", 3)
    Shared itemRaptorSkull3 As New Item("Uzirappter Skull", 3)
    Shared itemRaptorTail3 As New Item("Uzirappter Tail", 3)

    Public Sub New(name As String, tier As Integer, image As Bitmap)
        Me.setItemName(name)
        Me.setItemTier(tier)
        Me.setItemSprite(image)
    End Sub

    Public Sub setItemName(name As String)
        Me.itemName = name
    End Sub

    Public Function getItemName()
        Return Me.itemName
    End Function

    Public Sub setItemTier(tier As Integer)
        Me.itemTier = tier
    End Sub

    Public Function getItemTier()
        Return Me.itemTier
    End Function

    Public Sub setItemSprite(sprite As Image)
        Me.itemSprite = sprite
    End Sub

    Public Function getItemSprite()
        Return Me.itemSprite
    End Function
End Class