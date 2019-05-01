Public Class Item
    Private itemName As String = ""
    Private itemTier As Integer
    Private itemSprite As Image

    Public Shared itemNull As New Item("null", 0, New Bitmap(0, 0))

    Public Shared itemRaptorClaws1 As New Item("Unpheasant Claw", 1, My.Resources.uziCartiBigBaller)
    Public Shared itemRaptorHide1 As New Item("Unpheasant Hide", 1)
    Public Shared itemRaptorBone1 As New Item("Unpheasant Bone", 1)
    Public Shared itemRaptorSkull1 As New Item("Unpheasant Skull", 1)
    Public Shared itemRaptorTail1 As New Item("Unpheasant Tail", 1)

    Public Shared itemRaptorClaws2 As New Item("Mutahraptor Claw", 2)
    Public Shared itemRaptorHide2 As New Item("Mutahraptor Hide", 2)
    Public Shared itemRaptorBone2 As New Item("Mutahraptor Bone", 2)
    Public Shared itemRaptorSkull2 As New Item("Mutahraptor Skull", 2)
    Public Shared itemRaptorTail2 As New Item("Mutahraptor Tail", 2)

    Public Shared itemRaptorClaws3 As New Item("Uzirappter Claw", 3)
    Public Shared itemRaptorHide3 As New Item("Uzirappter Hide", 3)
    Public Shared itemRaptorBone3 As New Item("Uzirappter Bone", 3)
    Public Shared itemRaptorSkull3 As New Item("Uzirappter Skull", 3)
    Public Shared itemRaptorTail3 As New Item("Uzirappter Tail", 3)

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