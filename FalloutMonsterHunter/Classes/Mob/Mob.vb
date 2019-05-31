Public Class Mob

    Public Dim mobName As String = ""
    Public Dim mobSprite As Image

    Public Dim currentHealth As Integer

    Public Dim health As Integer
    Public Dim defense As Integer
    Public Dim attack As Integer
    Public Dim critChance As Integer

    Public Dim dropItems As Item()
    Public Dim dropChance As Double()
    Public Dim dropAmount As Double()

    Public Shared mobRaptor1 As Mob
    Public Shared mobRaptor2 As Mob
    Public Shared mobRaptor3 As Mob

    Public Shared mobBoss As Mob

    Public Shared Sub initialize()
        mobRaptor1 = New Mob("UnpheasantRaptor", 100, 5, 25, 5, My.Resources.mobRaptor1)
        mobRaptor1.dropItems = {Item.itemRaptorClaws1, Item.itemRaptorHide1, Item.itemRaptorBone1, Item.itemRaptorSkull1, Item.itemRaptorTail1}
        mobRaptor1.dropChance = {0.3, 0.5, 0.5, 0.08, 0.08}
        mobRaptor1.dropAmount = {6, 6, 6, 1.2, 1.2}

        mobRaptor2 = New Mob("Mutahraptor", 200, 20, 60, 5, My.Resources.mobRaptor2)
        mobRaptor2.dropItems = {Item.itemRaptorClaws2, Item.itemRaptorHide2, Item.itemRaptorBone2, Item.itemRaptorSkull2, Item.itemRaptorTail2}
        mobRaptor2.dropChance = {0.3, 0.5, 0.5, 0.08, 0.08}
        mobRaptor2.dropAmount = {6, 6, 6, 1.2, 1.2}

        mobRaptor3 = New Mob("Uzirappter", 350, 70, 110, 10, My.Resources.mobRaptor3)
        mobRaptor3.dropItems = {Item.itemRaptorClaws3, Item.itemRaptorHide3, Item.itemRaptorBone3, Item.itemRaptorSkull3, Item.itemRaptorTail3}
        mobRaptor3.dropChance = {0.3, 0.5, 0.5, 0.08, 0.08}
        mobRaptor3.dropAmount = {6, 6, 6, 1.2, 1.2}

        mobBoss = New Mob("MobBoss", 420, 80, 160, 12, My.Resources.mobFinalDino2)
        mobBoss.dropItems = {}
        mobBoss.dropChance = {}
        mobBoss.dropAmount = {}
    End Sub

    Public Sub New(name As String, health As Integer, defense As Integer, attack As Integer, critChance As Integer, sprite As Bitmap)
        Me.mobName = name
        Me.health = health
        Me.defense = defense
        Me.attack = attack
        Me.critChance = critChance
        Me.mobSprite = sprite
    End Sub

    Public Shared Function getMobFromName(name As String)
        Select Case name
            Case "UnpheasantRaptor"
                Return mobRaptor1
            Case "Mutahraptor"
                Return mobRaptor2
            Case "Uzirappter"
                Return mobRaptor3
            Case "MobBoss"
                Return mobBoss
            Case Else
                Return Nothing
        End Select
    End Function
End Class
