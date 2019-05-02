Public Class Item
    Private itemName As String = ""
    Private itemTier As Integer
    Private itemSprite As Image

    Public Shared itemNull As New Item("null", 0, New Bitmap(0, 0))

    Public Shared itemRaptorClaws1 As Item
    Public Shared itemRaptorHide1 As Item
    Public Shared itemRaptorBone1 As Item
    Public Shared itemRaptorSkull1 As Item
    Public Shared itemRaptorTail1 As Item

    Public Shared itemRaptorClaws2 As Item
    Public Shared itemRaptorHide2 As Item
    Public Shared itemRaptorBone2 As Item
    Public Shared itemRaptorSkull2 As Item
    Public Shared itemRaptorTail2 As Item

    Public Shared itemRaptorClaws3 As Item
    Public Shared itemRaptorHide3 As Item
    Public Shared itemRaptorBone3 As Item
    Public Shared itemRaptorSkull3 As Item
    Public Shared itemRaptorTail3 As Item

    Public Shared Sub initialize()
        itemNull = New Item("null", 0, New Bitmap(0, 0))

        itemRaptorClaws1 = New Item("Unpheasant Claw", 1, My.Resources.uziCartiBigBaller)
        itemRaptorHide1 = New Item("Unpheasant Hide", 1)
        itemRaptorBone1 = New Item("Unpheasant Bone", 1)
        itemRaptorSkull1 = New Item("Unpheasant Skull", 1)
        itemRaptorTail1 = New Item("Unpheasant Tail", 1)

        itemRaptorClaws2 = New Item("Mutahraptor Claw", 2)
        itemRaptorHide2 = New Item("Mutahraptor Hide", 2)
        itemRaptorBone2 = New Item("Mutahraptor Bone", 2)
        itemRaptorSkull2 = New Item("Mutahraptor Skull", 2)
        itemRaptorTail2 = New Item("Mutahraptor Tail", 2)

        itemRaptorClaws3 = New Item("Uzirappter Claw", 3)
        itemRaptorHide3 = New Item("Uzirappter Hide", 3)
        itemRaptorBone3 = New Item("Uzirappter Bone", 3)
        itemRaptorSkull3 = New Item("Uzirappter Skull", 3)
        itemRaptorTail3 = New Item("Uzirappter Tail", 3)
    End Sub

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