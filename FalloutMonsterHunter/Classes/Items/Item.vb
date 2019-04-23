Public Class Item
    Private itemName As String = ""
    Private itemTier As Integer

    Sub setItemName(name As String)
        Me.itemName = name
    End Sub

    Function getItemName(name As String)
        Return Me.itemName
    End Function
End Class