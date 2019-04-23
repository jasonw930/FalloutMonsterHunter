Public Class ItemStack
    Dim itemType as Item
    Dim stackSize as Integer

    Sub New(item as Item, size As Integer)
        Me.itemType = item
        If size > 0 Then
            Me.stackSize = size
        Else
            Throw New System.Exception("Error: Decared stack size of 0")
        End If
    End Sub

    Sub setItem(item as Item)
        Me.itemType = item
    End Sub

    Function getItem(item As Item)
        Return Me.itemType
    End Function
End Class