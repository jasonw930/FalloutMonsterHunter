Public Class ItemStack
    Private itemType As Item
    Private stackSize As Integer

    Public Sub New(item As Item, size As Integer)
        Me.setItem(item)
        Me.setSize(size)
    End Sub

    Public Sub setItem(item As Item)
        Me.itemType = item
    End Sub

    Public Function getItem()
        Return Me.itemType
    End Function

    Public Sub setSize(size As Integer)
        Me.stackSize = size
    End Sub

    Public Function getSize()
        Return Me.stackSize
    End Function
End Class