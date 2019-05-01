Public Class ItemStack
    Private itemType As Item
    Private stackSize As Integer

    Public Sub New(item As Item, size As Integer)
        Me.itemType = item
        If size > 0 Then
            Me.stackSize = size
        Else
            Throw New System.Exception("Error: Decared stack size of 0")
        End If
    End Sub

    Public Sub setItem(item As Item)
        Me.itemType = item
    End Sub

    Public Function getItem()
        Return Me.itemType
    End Function

    Private Sub setSize(size As Integer)
        Me.stackSize = size
    End Sub

    Private Function getSize()
        Return Me.stackSize
    End Function
End Class