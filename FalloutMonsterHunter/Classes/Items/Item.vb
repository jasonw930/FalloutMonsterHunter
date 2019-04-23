Public Class Item
    Private itemName As String = ""
    Private itemTier As Integer

    Public Sub New(name As String)
        Me.itemName = name
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
End Class