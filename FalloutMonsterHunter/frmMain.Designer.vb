<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlIntro = New System.Windows.Forms.Panel()
        Me.picIntro = New System.Windows.Forms.PictureBox()
        Me.pnlDialog = New System.Windows.Forms.Panel()
        Me.txtUserIn = New System.Windows.Forms.TextBox()
        Me.lblDialog = New System.Windows.Forms.Label()
        Me.lblClickCont = New System.Windows.Forms.Label()
        Me.lblBigOutline = New System.Windows.Forms.Label()
        Me.lblSpeaker = New System.Windows.Forms.Label()
        Me.timerMove = New System.Windows.Forms.Timer(Me.components)
        Me.waitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlCraftingMenu = New System.Windows.Forms.Panel()
        Me.lblCloseCrafting = New System.Windows.Forms.Label()
        Me.pnlCraftingItem = New System.Windows.Forms.Panel()
        Me.btnCraftEquipment = New System.Windows.Forms.Button()
        Me.picComponent4 = New System.Windows.Forms.PictureBox()
        Me.lblCraftingComponent4 = New System.Windows.Forms.Label()
        Me.picComponent3 = New System.Windows.Forms.PictureBox()
        Me.lblCraftingComponent3 = New System.Windows.Forms.Label()
        Me.picComponent2 = New System.Windows.Forms.PictureBox()
        Me.lblCraftingComponent2 = New System.Windows.Forms.Label()
        Me.picComponent1 = New System.Windows.Forms.PictureBox()
        Me.lblCraftingComponent1 = New System.Windows.Forms.Label()
        Me.picComponent0 = New System.Windows.Forms.PictureBox()
        Me.lblCraftingComponent0 = New System.Windows.Forms.Label()
        Me.picCraftPic = New System.Windows.Forms.PictureBox()
        Me.lblCraftStats = New System.Windows.Forms.Label()
        Me.lblCraftName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlCraftingList = New System.Windows.Forms.Panel()
        Me.scrlCraftingList = New System.Windows.Forms.VScrollBar()
        Me.pnlScrollFrame = New System.Windows.Forms.Panel()
        Me.pnlCraftNegativeOne = New System.Windows.Forms.Panel()
        Me.picCraft0 = New System.Windows.Forms.PictureBox()
        Me.lblCraft0 = New System.Windows.Forms.Label()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.pnlDeletion = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblDeleteConfirm = New System.Windows.Forms.Label()
        Me.pnlPlayerPreview = New System.Windows.Forms.Panel()
        Me.picBigBoots = New System.Windows.Forms.PictureBox()
        Me.picBigLeggings = New System.Windows.Forms.PictureBox()
        Me.picBigChestplate = New System.Windows.Forms.PictureBox()
        Me.picBigHelmet = New System.Windows.Forms.PictureBox()
        Me.picBigWeapon = New System.Windows.Forms.PictureBox()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.lblExitInventory = New System.Windows.Forms.Label()
        Me.picSlotHelmet = New System.Windows.Forms.PictureBox()
        Me.picSlotChestplate = New System.Windows.Forms.PictureBox()
        Me.picSlotLeggings = New System.Windows.Forms.PictureBox()
        Me.picSlotBoots = New System.Windows.Forms.PictureBox()
        Me.picSlotWeapon = New System.Windows.Forms.PictureBox()
        Me.picInvSlot23 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot15 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot7 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot22 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot14 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot6 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot21 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot13 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot5 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot20 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot12 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot4 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot19 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot11 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot3 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot18 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot10 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot2 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot17 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot9 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot1 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot16 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot8 = New System.Windows.Forms.PictureBox()
        Me.picInvSlot0 = New System.Windows.Forms.PictureBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.pnlFight = New System.Windows.Forms.Panel()
        Me.pnlDropMenu = New System.Windows.Forms.Panel()
        Me.lblExitDropMenu = New System.Windows.Forms.Label()
        Me.lblDrop5 = New System.Windows.Forms.Label()
        Me.picDrop5 = New System.Windows.Forms.PictureBox()
        Me.lblDrop4 = New System.Windows.Forms.Label()
        Me.lblDrop3 = New System.Windows.Forms.Label()
        Me.picDrop4 = New System.Windows.Forms.PictureBox()
        Me.picDrop3 = New System.Windows.Forms.PictureBox()
        Me.lblDrop2 = New System.Windows.Forms.Label()
        Me.lblDrop1 = New System.Windows.Forms.Label()
        Me.lblDrop0 = New System.Windows.Forms.Label()
        Me.picDrop2 = New System.Windows.Forms.PictureBox()
        Me.picDrop1 = New System.Windows.Forms.PictureBox()
        Me.picDrop0 = New System.Windows.Forms.PictureBox()
        Me.lblReceived = New System.Windows.Forms.Label()
        Me.pnlMob = New System.Windows.Forms.Panel()
        Me.picFighting = New System.Windows.Forms.PictureBox()
        Me.pnlPlayer = New System.Windows.Forms.Panel()
        Me.picBoots = New System.Windows.Forms.PictureBox()
        Me.picLeggings = New System.Windows.Forms.PictureBox()
        Me.picChestplate = New System.Windows.Forms.PictureBox()
        Me.picHelmet = New System.Windows.Forms.PictureBox()
        Me.picWeapon = New System.Windows.Forms.PictureBox()
        Me.pnlFujiCity = New System.Windows.Forms.Panel()
        Me.btnFightUzirappter = New System.Windows.Forms.Button()
        Me.btnFightMutahraptor = New System.Windows.Forms.Button()
        Me.btnFightUnpheasantRaptor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrafting = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.pnlMainMenu = New System.Windows.Forms.Panel()
        Me.picBackdrop = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.picFader2 = New System.Windows.Forms.PictureBox()
        Me.picFader = New System.Windows.Forms.PictureBox()
        Me.pnlIntro.SuspendLayout()
        CType(Me.picIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picIntro.SuspendLayout()
        Me.pnlDialog.SuspendLayout()
        Me.lblDialog.SuspendLayout()
        Me.pnlCraftingMenu.SuspendLayout()
        Me.pnlCraftingItem.SuspendLayout()
        CType(Me.picComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picComponent4.SuspendLayout()
        CType(Me.picComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picComponent3.SuspendLayout()
        CType(Me.picComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picComponent2.SuspendLayout()
        CType(Me.picComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picComponent1.SuspendLayout()
        CType(Me.picComponent0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picComponent0.SuspendLayout()
        CType(Me.picCraftPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picCraftPic.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCraftingList.SuspendLayout()
        Me.pnlCraftNegativeOne.SuspendLayout()
        CType(Me.picCraft0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        Me.pnlDeletion.SuspendLayout()
        Me.pnlPlayerPreview.SuspendLayout()
        CType(Me.picBigBoots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBigBoots.SuspendLayout()
        CType(Me.picBigLeggings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBigLeggings.SuspendLayout()
        CType(Me.picBigChestplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBigChestplate.SuspendLayout()
        CType(Me.picBigHelmet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBigHelmet.SuspendLayout()
        CType(Me.picBigWeapon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlotHelmet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlotChestplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlotLeggings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlotBoots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlotWeapon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvSlot0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picInvSlot0.SuspendLayout()
        Me.pnlFight.SuspendLayout()
        Me.pnlDropMenu.SuspendLayout()
        CType(Me.picDrop5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDrop4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDrop3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDrop2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDrop1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDrop0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFighting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picFighting.SuspendLayout()
        Me.pnlPlayer.SuspendLayout()
        CType(Me.picBoots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBoots.SuspendLayout()
        CType(Me.picLeggings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picLeggings.SuspendLayout()
        CType(Me.picChestplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picChestplate.SuspendLayout()
        CType(Me.picHelmet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picHelmet.SuspendLayout()
        CType(Me.picWeapon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFujiCity.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainMenu.SuspendLayout()
        CType(Me.picBackdrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBackdrop.SuspendLayout()
        CType(Me.picFader2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlIntro
        '
        Me.pnlIntro.BackColor = System.Drawing.Color.Maroon
        Me.pnlIntro.Controls.Add(Me.picIntro)
        Me.pnlIntro.Location = New System.Drawing.Point(1000, 193)
        Me.pnlIntro.Name = "pnlIntro"
        Me.pnlIntro.Size = New System.Drawing.Size(1000, 750)
        Me.pnlIntro.TabIndex = 3
        '
        'picIntro
        '
        Me.picIntro.Controls.Add(Me.pnlDialog)
        Me.picIntro.Image = Global.FalloutMonsterHunter.My.Resources.Resources.falloutMonsterHunterIntroCutscene
        Me.picIntro.Location = New System.Drawing.Point(0, 0)
        Me.picIntro.Name = "picIntro"
        Me.picIntro.Size = New System.Drawing.Size(1000, 750)
        Me.picIntro.TabIndex = 0
        Me.picIntro.TabStop = False
        '
        'pnlDialog
        '
        Me.pnlDialog.BackColor = System.Drawing.Color.Transparent
        Me.pnlDialog.Controls.Add(Me.txtUserIn)
        Me.pnlDialog.Controls.Add(Me.lblDialog)
        Me.pnlDialog.Controls.Add(Me.lblBigOutline)
        Me.pnlDialog.Controls.Add(Me.lblSpeaker)
        Me.pnlDialog.Location = New System.Drawing.Point(74, 423)
        Me.pnlDialog.Name = "pnlDialog"
        Me.pnlDialog.Size = New System.Drawing.Size(852, 253)
        Me.pnlDialog.TabIndex = 3
        Me.pnlDialog.Visible = False
        '
        'txtUserIn
        '
        Me.txtUserIn.BackColor = System.Drawing.Color.Black
        Me.txtUserIn.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIn.ForeColor = System.Drawing.Color.White
        Me.txtUserIn.Location = New System.Drawing.Point(17, 208)
        Me.txtUserIn.Name = "txtUserIn"
        Me.txtUserIn.Size = New System.Drawing.Size(276, 28)
        Me.txtUserIn.TabIndex = 4
        Me.txtUserIn.Visible = False
        '
        'lblDialog
        '
        Me.lblDialog.BackColor = System.Drawing.Color.Black
        Me.lblDialog.Controls.Add(Me.lblClickCont)
        Me.lblDialog.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDialog.ForeColor = System.Drawing.Color.White
        Me.lblDialog.Location = New System.Drawing.Point(3, 39)
        Me.lblDialog.Name = "lblDialog"
        Me.lblDialog.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblDialog.Size = New System.Drawing.Size(846, 211)
        Me.lblDialog.TabIndex = 1
        '
        'lblClickCont
        '
        Me.lblClickCont.AutoSize = True
        Me.lblClickCont.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickCont.ForeColor = System.Drawing.Color.White
        Me.lblClickCont.Location = New System.Drawing.Point(650, 174)
        Me.lblClickCont.Name = "lblClickCont"
        Me.lblClickCont.Size = New System.Drawing.Size(179, 20)
        Me.lblClickCont.TabIndex = 5
        Me.lblClickCont.Tag = "650, 174"
        Me.lblClickCont.Text = "click to continue"
        Me.lblClickCont.Visible = False
        '
        'lblBigOutline
        '
        Me.lblBigOutline.BackColor = System.Drawing.Color.White
        Me.lblBigOutline.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBigOutline.ForeColor = System.Drawing.Color.White
        Me.lblBigOutline.Location = New System.Drawing.Point(0, 36)
        Me.lblBigOutline.Name = "lblBigOutline"
        Me.lblBigOutline.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblBigOutline.Size = New System.Drawing.Size(852, 217)
        Me.lblBigOutline.TabIndex = 3
        Me.lblBigOutline.Text = "Hello? Hello?? Is anybody there???"
        '
        'lblSpeaker
        '
        Me.lblSpeaker.BackColor = System.Drawing.Color.Black
        Me.lblSpeaker.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeaker.ForeColor = System.Drawing.Color.White
        Me.lblSpeaker.Location = New System.Drawing.Point(0, 0)
        Me.lblSpeaker.Name = "lblSpeaker"
        Me.lblSpeaker.Size = New System.Drawing.Size(224, 37)
        Me.lblSpeaker.TabIndex = 2
        Me.lblSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerMove
        '
        Me.timerMove.Interval = 50
        '
        'waitTimer
        '
        Me.waitTimer.Interval = 1000
        '
        'pnlCraftingMenu
        '
        Me.pnlCraftingMenu.BackColor = System.Drawing.Color.DimGray
        Me.pnlCraftingMenu.Controls.Add(Me.lblCloseCrafting)
        Me.pnlCraftingMenu.Controls.Add(Me.pnlCraftingItem)
        Me.pnlCraftingMenu.Controls.Add(Me.pnlCraftingList)
        Me.pnlCraftingMenu.Location = New System.Drawing.Point(0, 1000)
        Me.pnlCraftingMenu.Name = "pnlCraftingMenu"
        Me.pnlCraftingMenu.Size = New System.Drawing.Size(1000, 750)
        Me.pnlCraftingMenu.TabIndex = 7
        '
        'lblCloseCrafting
        '
        Me.lblCloseCrafting.AutoSize = True
        Me.lblCloseCrafting.BackColor = System.Drawing.Color.DarkGray
        Me.lblCloseCrafting.Font = New System.Drawing.Font("Courier New", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseCrafting.ForeColor = System.Drawing.Color.White
        Me.lblCloseCrafting.Location = New System.Drawing.Point(933, 20)
        Me.lblCloseCrafting.Name = "lblCloseCrafting"
        Me.lblCloseCrafting.Size = New System.Drawing.Size(42, 43)
        Me.lblCloseCrafting.TabIndex = 31
        Me.lblCloseCrafting.Text = "X"
        Me.lblCloseCrafting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCraftingItem
        '
        Me.pnlCraftingItem.BackColor = System.Drawing.Color.DarkGray
        Me.pnlCraftingItem.Controls.Add(Me.btnCraftEquipment)
        Me.pnlCraftingItem.Controls.Add(Me.picComponent4)
        Me.pnlCraftingItem.Controls.Add(Me.picComponent3)
        Me.pnlCraftingItem.Controls.Add(Me.picComponent2)
        Me.pnlCraftingItem.Controls.Add(Me.picComponent1)
        Me.pnlCraftingItem.Controls.Add(Me.picComponent0)
        Me.pnlCraftingItem.Controls.Add(Me.picCraftPic)
        Me.pnlCraftingItem.Controls.Add(Me.lblCraftName)
        Me.pnlCraftingItem.Controls.Add(Me.Panel2)
        Me.pnlCraftingItem.Location = New System.Drawing.Point(494, 101)
        Me.pnlCraftingItem.Name = "pnlCraftingItem"
        Me.pnlCraftingItem.Size = New System.Drawing.Size(370, 540)
        Me.pnlCraftingItem.TabIndex = 3
        '
        'btnCraftEquipment
        '
        Me.btnCraftEquipment.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCraftEquipment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCraftEquipment.FlatAppearance.BorderSize = 0
        Me.btnCraftEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCraftEquipment.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCraftEquipment.ForeColor = System.Drawing.Color.Black
        Me.btnCraftEquipment.Location = New System.Drawing.Point(243, 461)
        Me.btnCraftEquipment.Name = "btnCraftEquipment"
        Me.btnCraftEquipment.Size = New System.Drawing.Size(72, 30)
        Me.btnCraftEquipment.TabIndex = 13
        Me.btnCraftEquipment.Text = "craft"
        Me.btnCraftEquipment.UseVisualStyleBackColor = False
        '
        'picComponent4
        '
        Me.picComponent4.Controls.Add(Me.lblCraftingComponent4)
        Me.picComponent4.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorSkull1_InventorySmall
        Me.picComponent4.Location = New System.Drawing.Point(243, 341)
        Me.picComponent4.Name = "picComponent4"
        Me.picComponent4.Size = New System.Drawing.Size(72, 72)
        Me.picComponent4.TabIndex = 12
        Me.picComponent4.TabStop = False
        '
        'lblCraftingComponent4
        '
        Me.lblCraftingComponent4.AutoSize = True
        Me.lblCraftingComponent4.BackColor = System.Drawing.Color.Transparent
        Me.lblCraftingComponent4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftingComponent4.Location = New System.Drawing.Point(43, 52)
        Me.lblCraftingComponent4.Name = "lblCraftingComponent4"
        Me.lblCraftingComponent4.Size = New System.Drawing.Size(29, 20)
        Me.lblCraftingComponent4.TabIndex = 13
        Me.lblCraftingComponent4.Text = "x1"
        Me.lblCraftingComponent4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picComponent3
        '
        Me.picComponent3.Controls.Add(Me.lblCraftingComponent3)
        Me.picComponent3.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorSkull1_InventorySmall
        Me.picComponent3.Location = New System.Drawing.Point(146, 440)
        Me.picComponent3.Name = "picComponent3"
        Me.picComponent3.Size = New System.Drawing.Size(72, 72)
        Me.picComponent3.TabIndex = 7
        Me.picComponent3.TabStop = False
        '
        'lblCraftingComponent3
        '
        Me.lblCraftingComponent3.AutoSize = True
        Me.lblCraftingComponent3.BackColor = System.Drawing.Color.Transparent
        Me.lblCraftingComponent3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftingComponent3.Location = New System.Drawing.Point(43, 52)
        Me.lblCraftingComponent3.Name = "lblCraftingComponent3"
        Me.lblCraftingComponent3.Size = New System.Drawing.Size(29, 20)
        Me.lblCraftingComponent3.TabIndex = 11
        Me.lblCraftingComponent3.Text = "x1"
        Me.lblCraftingComponent3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picComponent2
        '
        Me.picComponent2.Controls.Add(Me.lblCraftingComponent2)
        Me.picComponent2.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorSkull1_InventorySmall
        Me.picComponent2.Location = New System.Drawing.Point(146, 341)
        Me.picComponent2.Name = "picComponent2"
        Me.picComponent2.Size = New System.Drawing.Size(72, 72)
        Me.picComponent2.TabIndex = 6
        Me.picComponent2.TabStop = False
        '
        'lblCraftingComponent2
        '
        Me.lblCraftingComponent2.AutoSize = True
        Me.lblCraftingComponent2.BackColor = System.Drawing.Color.Transparent
        Me.lblCraftingComponent2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftingComponent2.Location = New System.Drawing.Point(43, 52)
        Me.lblCraftingComponent2.Name = "lblCraftingComponent2"
        Me.lblCraftingComponent2.Size = New System.Drawing.Size(29, 20)
        Me.lblCraftingComponent2.TabIndex = 10
        Me.lblCraftingComponent2.Text = "x1"
        Me.lblCraftingComponent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picComponent1
        '
        Me.picComponent1.Controls.Add(Me.lblCraftingComponent1)
        Me.picComponent1.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorSkull1_InventorySmall
        Me.picComponent1.Location = New System.Drawing.Point(49, 440)
        Me.picComponent1.Name = "picComponent1"
        Me.picComponent1.Size = New System.Drawing.Size(72, 72)
        Me.picComponent1.TabIndex = 5
        Me.picComponent1.TabStop = False
        '
        'lblCraftingComponent1
        '
        Me.lblCraftingComponent1.AutoSize = True
        Me.lblCraftingComponent1.BackColor = System.Drawing.Color.Transparent
        Me.lblCraftingComponent1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftingComponent1.Location = New System.Drawing.Point(43, 52)
        Me.lblCraftingComponent1.Name = "lblCraftingComponent1"
        Me.lblCraftingComponent1.Size = New System.Drawing.Size(29, 20)
        Me.lblCraftingComponent1.TabIndex = 9
        Me.lblCraftingComponent1.Text = "x1"
        Me.lblCraftingComponent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picComponent0
        '
        Me.picComponent0.Controls.Add(Me.lblCraftingComponent0)
        Me.picComponent0.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorSkull1_InventorySmall
        Me.picComponent0.Location = New System.Drawing.Point(49, 341)
        Me.picComponent0.Name = "picComponent0"
        Me.picComponent0.Size = New System.Drawing.Size(72, 72)
        Me.picComponent0.TabIndex = 4
        Me.picComponent0.TabStop = False
        '
        'lblCraftingComponent0
        '
        Me.lblCraftingComponent0.AutoSize = True
        Me.lblCraftingComponent0.BackColor = System.Drawing.Color.Transparent
        Me.lblCraftingComponent0.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftingComponent0.ForeColor = System.Drawing.Color.White
        Me.lblCraftingComponent0.Location = New System.Drawing.Point(43, 52)
        Me.lblCraftingComponent0.Name = "lblCraftingComponent0"
        Me.lblCraftingComponent0.Size = New System.Drawing.Size(29, 20)
        Me.lblCraftingComponent0.TabIndex = 8
        Me.lblCraftingComponent0.Text = "x1"
        Me.lblCraftingComponent0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picCraftPic
        '
        Me.picCraftPic.Controls.Add(Me.lblCraftStats)
        Me.picCraftPic.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorTail1
        Me.picCraftPic.Location = New System.Drawing.Point(59, 59)
        Me.picCraftPic.Name = "picCraftPic"
        Me.picCraftPic.Size = New System.Drawing.Size(256, 256)
        Me.picCraftPic.TabIndex = 3
        Me.picCraftPic.TabStop = False
        '
        'lblCraftStats
        '
        Me.lblCraftStats.BackColor = System.Drawing.Color.Transparent
        Me.lblCraftStats.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftStats.ForeColor = System.Drawing.Color.White
        Me.lblCraftStats.Location = New System.Drawing.Point(0, 0)
        Me.lblCraftStats.Name = "lblCraftStats"
        Me.lblCraftStats.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblCraftStats.Size = New System.Drawing.Size(260, 256)
        Me.lblCraftStats.TabIndex = 8
        Me.lblCraftStats.Text = "Health +25" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defense +10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luck: +5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCraftStats.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblCraftName
        '
        Me.lblCraftName.BackColor = System.Drawing.Color.Transparent
        Me.lblCraftName.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftName.ForeColor = System.Drawing.Color.White
        Me.lblCraftName.Location = New System.Drawing.Point(0, 0)
        Me.lblCraftName.Name = "lblCraftName"
        Me.lblCraftName.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblCraftName.Size = New System.Drawing.Size(370, 72)
        Me.lblCraftName.TabIndex = 2
        Me.lblCraftName.Text = "Chestplate"
        Me.lblCraftName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 1000)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 90)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorBone1_InventorySmall
        Me.PictureBox2.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unpheasant Chestplate"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlCraftingList
        '
        Me.pnlCraftingList.BackColor = System.Drawing.Color.DarkGray
        Me.pnlCraftingList.Controls.Add(Me.scrlCraftingList)
        Me.pnlCraftingList.Controls.Add(Me.pnlScrollFrame)
        Me.pnlCraftingList.Controls.Add(Me.pnlCraftNegativeOne)
        Me.pnlCraftingList.Location = New System.Drawing.Point(124, 101)
        Me.pnlCraftingList.Name = "pnlCraftingList"
        Me.pnlCraftingList.Size = New System.Drawing.Size(370, 540)
        Me.pnlCraftingList.TabIndex = 0
        '
        'scrlCraftingList
        '
        Me.scrlCraftingList.LargeChange = 1
        Me.scrlCraftingList.Location = New System.Drawing.Point(348, 0)
        Me.scrlCraftingList.Maximum = 0
        Me.scrlCraftingList.Name = "scrlCraftingList"
        Me.scrlCraftingList.Size = New System.Drawing.Size(21, 540)
        Me.scrlCraftingList.TabIndex = 3
        '
        'pnlScrollFrame
        '
        Me.pnlScrollFrame.Location = New System.Drawing.Point(0, 0)
        Me.pnlScrollFrame.Name = "pnlScrollFrame"
        Me.pnlScrollFrame.Size = New System.Drawing.Size(349, 23)
        Me.pnlScrollFrame.TabIndex = 4
        '
        'pnlCraftNegativeOne
        '
        Me.pnlCraftNegativeOne.BackColor = System.Drawing.Color.Silver
        Me.pnlCraftNegativeOne.Controls.Add(Me.picCraft0)
        Me.pnlCraftNegativeOne.Controls.Add(Me.lblCraft0)
        Me.pnlCraftNegativeOne.Location = New System.Drawing.Point(0, 1000)
        Me.pnlCraftNegativeOne.Name = "pnlCraftNegativeOne"
        Me.pnlCraftNegativeOne.Size = New System.Drawing.Size(349, 90)
        Me.pnlCraftNegativeOne.TabIndex = 2
        '
        'picCraft0
        '
        Me.picCraft0.BackColor = System.Drawing.Color.Transparent
        Me.picCraft0.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorBone1_InventorySmall
        Me.picCraft0.Location = New System.Drawing.Point(12, 9)
        Me.picCraft0.Name = "picCraft0"
        Me.picCraft0.Size = New System.Drawing.Size(72, 72)
        Me.picCraft0.TabIndex = 1
        Me.picCraft0.TabStop = False
        '
        'lblCraft0
        '
        Me.lblCraft0.BackColor = System.Drawing.Color.Transparent
        Me.lblCraft0.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraft0.ForeColor = System.Drawing.Color.White
        Me.lblCraft0.Location = New System.Drawing.Point(96, 9)
        Me.lblCraft0.Name = "lblCraft0"
        Me.lblCraft0.Size = New System.Drawing.Size(240, 72)
        Me.lblCraft0.TabIndex = 1
        Me.lblCraft0.Text = "Unpheasant Chestplate"
        Me.lblCraft0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlInventory
        '
        Me.pnlInventory.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.pnlInventory
        Me.pnlInventory.Controls.Add(Me.pnlDeletion)
        Me.pnlInventory.Controls.Add(Me.pnlPlayerPreview)
        Me.pnlInventory.Controls.Add(Me.lblStats)
        Me.pnlInventory.Controls.Add(Me.lblExitInventory)
        Me.pnlInventory.Controls.Add(Me.picSlotHelmet)
        Me.pnlInventory.Controls.Add(Me.picSlotChestplate)
        Me.pnlInventory.Controls.Add(Me.picSlotLeggings)
        Me.pnlInventory.Controls.Add(Me.picSlotBoots)
        Me.pnlInventory.Controls.Add(Me.picSlotWeapon)
        Me.pnlInventory.Controls.Add(Me.picInvSlot23)
        Me.pnlInventory.Controls.Add(Me.picInvSlot15)
        Me.pnlInventory.Controls.Add(Me.picInvSlot7)
        Me.pnlInventory.Controls.Add(Me.picInvSlot22)
        Me.pnlInventory.Controls.Add(Me.picInvSlot14)
        Me.pnlInventory.Controls.Add(Me.picInvSlot6)
        Me.pnlInventory.Controls.Add(Me.picInvSlot21)
        Me.pnlInventory.Controls.Add(Me.picInvSlot13)
        Me.pnlInventory.Controls.Add(Me.picInvSlot5)
        Me.pnlInventory.Controls.Add(Me.picInvSlot20)
        Me.pnlInventory.Controls.Add(Me.picInvSlot12)
        Me.pnlInventory.Controls.Add(Me.picInvSlot4)
        Me.pnlInventory.Controls.Add(Me.picInvSlot19)
        Me.pnlInventory.Controls.Add(Me.picInvSlot11)
        Me.pnlInventory.Controls.Add(Me.picInvSlot3)
        Me.pnlInventory.Controls.Add(Me.picInvSlot18)
        Me.pnlInventory.Controls.Add(Me.picInvSlot10)
        Me.pnlInventory.Controls.Add(Me.picInvSlot2)
        Me.pnlInventory.Controls.Add(Me.picInvSlot17)
        Me.pnlInventory.Controls.Add(Me.picInvSlot9)
        Me.pnlInventory.Controls.Add(Me.picInvSlot1)
        Me.pnlInventory.Controls.Add(Me.picInvSlot16)
        Me.pnlInventory.Controls.Add(Me.picInvSlot8)
        Me.pnlInventory.Controls.Add(Me.picInvSlot0)
        Me.pnlInventory.Location = New System.Drawing.Point(1000, 1000)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(1000, 750)
        Me.pnlInventory.TabIndex = 6
        '
        'pnlDeletion
        '
        Me.pnlDeletion.BackColor = System.Drawing.Color.Silver
        Me.pnlDeletion.Controls.Add(Me.btnCancel)
        Me.pnlDeletion.Controls.Add(Me.btnDelete)
        Me.pnlDeletion.Controls.Add(Me.lblDeleteConfirm)
        Me.pnlDeletion.Location = New System.Drawing.Point(250, 290)
        Me.pnlDeletion.Name = "pnlDeletion"
        Me.pnlDeletion.Size = New System.Drawing.Size(500, 170)
        Me.pnlDeletion.TabIndex = 34
        Me.pnlDeletion.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(258, 119)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Location = New System.Drawing.Point(136, 119)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblDeleteConfirm
        '
        Me.lblDeleteConfirm.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteConfirm.ForeColor = System.Drawing.Color.White
        Me.lblDeleteConfirm.Location = New System.Drawing.Point(0, 0)
        Me.lblDeleteConfirm.Name = "lblDeleteConfirm"
        Me.lblDeleteConfirm.Padding = New System.Windows.Forms.Padding(5)
        Me.lblDeleteConfirm.Size = New System.Drawing.Size(500, 119)
        Me.lblDeleteConfirm.TabIndex = 0
        Me.lblDeleteConfirm.Text = "Are you sure you want to delete Unpheasant Tail (x3)?"
        Me.lblDeleteConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPlayerPreview
        '
        Me.pnlPlayerPreview.BackColor = System.Drawing.Color.Transparent
        Me.pnlPlayerPreview.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.Player_Shoeless
        Me.pnlPlayerPreview.Controls.Add(Me.picBigBoots)
        Me.pnlPlayerPreview.Location = New System.Drawing.Point(284, 34)
        Me.pnlPlayerPreview.Name = "pnlPlayerPreview"
        Me.pnlPlayerPreview.Size = New System.Drawing.Size(312, 392)
        Me.pnlPlayerPreview.TabIndex = 33
        '
        'picBigBoots
        '
        Me.picBigBoots.Controls.Add(Me.picBigLeggings)
        Me.picBigBoots.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorBoots1
        Me.picBigBoots.Location = New System.Drawing.Point(0, 0)
        Me.picBigBoots.Name = "picBigBoots"
        Me.picBigBoots.Size = New System.Drawing.Size(312, 392)
        Me.picBigBoots.TabIndex = 0
        Me.picBigBoots.TabStop = False
        '
        'picBigLeggings
        '
        Me.picBigLeggings.Controls.Add(Me.picBigChestplate)
        Me.picBigLeggings.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorLeggings1
        Me.picBigLeggings.Location = New System.Drawing.Point(0, 0)
        Me.picBigLeggings.Name = "picBigLeggings"
        Me.picBigLeggings.Size = New System.Drawing.Size(312, 392)
        Me.picBigLeggings.TabIndex = 1
        Me.picBigLeggings.TabStop = False
        '
        'picBigChestplate
        '
        Me.picBigChestplate.Controls.Add(Me.picBigHelmet)
        Me.picBigChestplate.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorChestplate1
        Me.picBigChestplate.Location = New System.Drawing.Point(0, 0)
        Me.picBigChestplate.Name = "picBigChestplate"
        Me.picBigChestplate.Size = New System.Drawing.Size(312, 392)
        Me.picBigChestplate.TabIndex = 2
        Me.picBigChestplate.TabStop = False
        '
        'picBigHelmet
        '
        Me.picBigHelmet.Controls.Add(Me.picBigWeapon)
        Me.picBigHelmet.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorHelmet1
        Me.picBigHelmet.Location = New System.Drawing.Point(0, 0)
        Me.picBigHelmet.Name = "picBigHelmet"
        Me.picBigHelmet.Size = New System.Drawing.Size(312, 392)
        Me.picBigHelmet.TabIndex = 3
        Me.picBigHelmet.TabStop = False
        '
        'picBigWeapon
        '
        Me.picBigWeapon.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorWeapon1
        Me.picBigWeapon.Location = New System.Drawing.Point(0, 0)
        Me.picBigWeapon.Name = "picBigWeapon"
        Me.picBigWeapon.Size = New System.Drawing.Size(312, 392)
        Me.picBigWeapon.TabIndex = 4
        Me.picBigWeapon.TabStop = False
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.BackColor = System.Drawing.Color.Transparent
        Me.lblStats.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.ForeColor = System.Drawing.Color.White
        Me.lblStats.Location = New System.Drawing.Point(641, 71)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(159, 320)
        Me.lblStats.TabIndex = 31
        Me.lblStats.Text = "Health: 100 HP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defense: 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Attack: 25" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Criticals: 100%"
        '
        'lblExitInventory
        '
        Me.lblExitInventory.AutoSize = True
        Me.lblExitInventory.BackColor = System.Drawing.Color.DimGray
        Me.lblExitInventory.Font = New System.Drawing.Font("Courier New", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExitInventory.ForeColor = System.Drawing.Color.White
        Me.lblExitInventory.Location = New System.Drawing.Point(921, 34)
        Me.lblExitInventory.Name = "lblExitInventory"
        Me.lblExitInventory.Size = New System.Drawing.Size(42, 43)
        Me.lblExitInventory.TabIndex = 30
        Me.lblExitInventory.Text = "X"
        Me.lblExitInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picSlotHelmet
        '
        Me.picSlotHelmet.BackColor = System.Drawing.Color.Transparent
        Me.picSlotHelmet.Location = New System.Drawing.Point(184, 34)
        Me.picSlotHelmet.Name = "picSlotHelmet"
        Me.picSlotHelmet.Size = New System.Drawing.Size(72, 72)
        Me.picSlotHelmet.TabIndex = 28
        Me.picSlotHelmet.TabStop = False
        '
        'picSlotChestplate
        '
        Me.picSlotChestplate.BackColor = System.Drawing.Color.Transparent
        Me.picSlotChestplate.Location = New System.Drawing.Point(184, 114)
        Me.picSlotChestplate.Name = "picSlotChestplate"
        Me.picSlotChestplate.Size = New System.Drawing.Size(72, 72)
        Me.picSlotChestplate.TabIndex = 27
        Me.picSlotChestplate.TabStop = False
        '
        'picSlotLeggings
        '
        Me.picSlotLeggings.BackColor = System.Drawing.Color.Transparent
        Me.picSlotLeggings.Location = New System.Drawing.Point(184, 194)
        Me.picSlotLeggings.Name = "picSlotLeggings"
        Me.picSlotLeggings.Size = New System.Drawing.Size(72, 72)
        Me.picSlotLeggings.TabIndex = 26
        Me.picSlotLeggings.TabStop = False
        '
        'picSlotBoots
        '
        Me.picSlotBoots.BackColor = System.Drawing.Color.Transparent
        Me.picSlotBoots.Location = New System.Drawing.Point(184, 274)
        Me.picSlotBoots.Name = "picSlotBoots"
        Me.picSlotBoots.Size = New System.Drawing.Size(72, 72)
        Me.picSlotBoots.TabIndex = 25
        Me.picSlotBoots.TabStop = False
        '
        'picSlotWeapon
        '
        Me.picSlotWeapon.BackColor = System.Drawing.Color.Transparent
        Me.picSlotWeapon.Location = New System.Drawing.Point(184, 354)
        Me.picSlotWeapon.Name = "picSlotWeapon"
        Me.picSlotWeapon.Size = New System.Drawing.Size(72, 72)
        Me.picSlotWeapon.TabIndex = 24
        Me.picSlotWeapon.TabStop = False
        '
        'picInvSlot23
        '
        Me.picInvSlot23.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot23.Location = New System.Drawing.Point(744, 624)
        Me.picInvSlot23.Name = "picInvSlot23"
        Me.picInvSlot23.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot23.TabIndex = 23
        Me.picInvSlot23.TabStop = False
        '
        'picInvSlot15
        '
        Me.picInvSlot15.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot15.Location = New System.Drawing.Point(744, 544)
        Me.picInvSlot15.Name = "picInvSlot15"
        Me.picInvSlot15.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot15.TabIndex = 22
        Me.picInvSlot15.TabStop = False
        '
        'picInvSlot7
        '
        Me.picInvSlot7.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot7.Location = New System.Drawing.Point(744, 464)
        Me.picInvSlot7.Name = "picInvSlot7"
        Me.picInvSlot7.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot7.TabIndex = 21
        Me.picInvSlot7.TabStop = False
        '
        'picInvSlot22
        '
        Me.picInvSlot22.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot22.Location = New System.Drawing.Point(664, 624)
        Me.picInvSlot22.Name = "picInvSlot22"
        Me.picInvSlot22.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot22.TabIndex = 20
        Me.picInvSlot22.TabStop = False
        '
        'picInvSlot14
        '
        Me.picInvSlot14.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot14.Location = New System.Drawing.Point(664, 544)
        Me.picInvSlot14.Name = "picInvSlot14"
        Me.picInvSlot14.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot14.TabIndex = 19
        Me.picInvSlot14.TabStop = False
        '
        'picInvSlot6
        '
        Me.picInvSlot6.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot6.Location = New System.Drawing.Point(664, 464)
        Me.picInvSlot6.Name = "picInvSlot6"
        Me.picInvSlot6.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot6.TabIndex = 18
        Me.picInvSlot6.TabStop = False
        '
        'picInvSlot21
        '
        Me.picInvSlot21.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot21.Location = New System.Drawing.Point(584, 624)
        Me.picInvSlot21.Name = "picInvSlot21"
        Me.picInvSlot21.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot21.TabIndex = 17
        Me.picInvSlot21.TabStop = False
        '
        'picInvSlot13
        '
        Me.picInvSlot13.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot13.Location = New System.Drawing.Point(584, 544)
        Me.picInvSlot13.Name = "picInvSlot13"
        Me.picInvSlot13.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot13.TabIndex = 16
        Me.picInvSlot13.TabStop = False
        '
        'picInvSlot5
        '
        Me.picInvSlot5.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot5.Location = New System.Drawing.Point(584, 464)
        Me.picInvSlot5.Name = "picInvSlot5"
        Me.picInvSlot5.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot5.TabIndex = 15
        Me.picInvSlot5.TabStop = False
        '
        'picInvSlot20
        '
        Me.picInvSlot20.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot20.Location = New System.Drawing.Point(504, 624)
        Me.picInvSlot20.Name = "picInvSlot20"
        Me.picInvSlot20.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot20.TabIndex = 14
        Me.picInvSlot20.TabStop = False
        '
        'picInvSlot12
        '
        Me.picInvSlot12.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot12.Location = New System.Drawing.Point(504, 544)
        Me.picInvSlot12.Name = "picInvSlot12"
        Me.picInvSlot12.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot12.TabIndex = 13
        Me.picInvSlot12.TabStop = False
        '
        'picInvSlot4
        '
        Me.picInvSlot4.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot4.Location = New System.Drawing.Point(504, 464)
        Me.picInvSlot4.Name = "picInvSlot4"
        Me.picInvSlot4.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot4.TabIndex = 12
        Me.picInvSlot4.TabStop = False
        '
        'picInvSlot19
        '
        Me.picInvSlot19.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot19.Location = New System.Drawing.Point(424, 624)
        Me.picInvSlot19.Name = "picInvSlot19"
        Me.picInvSlot19.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot19.TabIndex = 11
        Me.picInvSlot19.TabStop = False
        '
        'picInvSlot11
        '
        Me.picInvSlot11.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot11.Location = New System.Drawing.Point(424, 544)
        Me.picInvSlot11.Name = "picInvSlot11"
        Me.picInvSlot11.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot11.TabIndex = 10
        Me.picInvSlot11.TabStop = False
        '
        'picInvSlot3
        '
        Me.picInvSlot3.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot3.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorClaws1_InventorySmall
        Me.picInvSlot3.Location = New System.Drawing.Point(424, 464)
        Me.picInvSlot3.Name = "picInvSlot3"
        Me.picInvSlot3.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot3.TabIndex = 9
        Me.picInvSlot3.TabStop = False
        '
        'picInvSlot18
        '
        Me.picInvSlot18.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot18.Location = New System.Drawing.Point(344, 624)
        Me.picInvSlot18.Name = "picInvSlot18"
        Me.picInvSlot18.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot18.TabIndex = 8
        Me.picInvSlot18.TabStop = False
        '
        'picInvSlot10
        '
        Me.picInvSlot10.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot10.Location = New System.Drawing.Point(344, 544)
        Me.picInvSlot10.Name = "picInvSlot10"
        Me.picInvSlot10.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot10.TabIndex = 7
        Me.picInvSlot10.TabStop = False
        '
        'picInvSlot2
        '
        Me.picInvSlot2.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot2.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorHide1_InventorySmall
        Me.picInvSlot2.Location = New System.Drawing.Point(344, 464)
        Me.picInvSlot2.Name = "picInvSlot2"
        Me.picInvSlot2.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot2.TabIndex = 6
        Me.picInvSlot2.TabStop = False
        '
        'picInvSlot17
        '
        Me.picInvSlot17.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot17.Location = New System.Drawing.Point(264, 624)
        Me.picInvSlot17.Name = "picInvSlot17"
        Me.picInvSlot17.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot17.TabIndex = 5
        Me.picInvSlot17.TabStop = False
        '
        'picInvSlot9
        '
        Me.picInvSlot9.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot9.Location = New System.Drawing.Point(264, 544)
        Me.picInvSlot9.Name = "picInvSlot9"
        Me.picInvSlot9.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot9.TabIndex = 4
        Me.picInvSlot9.TabStop = False
        '
        'picInvSlot1
        '
        Me.picInvSlot1.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot1.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorSkull1_InventorySmall
        Me.picInvSlot1.Location = New System.Drawing.Point(264, 464)
        Me.picInvSlot1.Name = "picInvSlot1"
        Me.picInvSlot1.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot1.TabIndex = 3
        Me.picInvSlot1.TabStop = False
        '
        'picInvSlot16
        '
        Me.picInvSlot16.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot16.Location = New System.Drawing.Point(184, 624)
        Me.picInvSlot16.Name = "picInvSlot16"
        Me.picInvSlot16.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot16.TabIndex = 2
        Me.picInvSlot16.TabStop = False
        '
        'picInvSlot8
        '
        Me.picInvSlot8.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot8.Location = New System.Drawing.Point(184, 544)
        Me.picInvSlot8.Name = "picInvSlot8"
        Me.picInvSlot8.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot8.TabIndex = 1
        Me.picInvSlot8.TabStop = False
        '
        'picInvSlot0
        '
        Me.picInvSlot0.BackColor = System.Drawing.Color.Transparent
        Me.picInvSlot0.Controls.Add(Me.lblCount)
        Me.picInvSlot0.Image = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorTail1_InventorySmall
        Me.picInvSlot0.Location = New System.Drawing.Point(184, 464)
        Me.picInvSlot0.Name = "picInvSlot0"
        Me.picInvSlot0.Size = New System.Drawing.Size(72, 72)
        Me.picInvSlot0.TabIndex = 0
        Me.picInvSlot0.TabStop = False
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(0, 47)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(72, 25)
        Me.lblCount.TabIndex = 30
        Me.lblCount.Text = "x19"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCount.Visible = False
        '
        'pnlFight
        '
        Me.pnlFight.BackColor = System.Drawing.Color.Transparent
        Me.pnlFight.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.fmhFightScene
        Me.pnlFight.Controls.Add(Me.pnlDropMenu)
        Me.pnlFight.Controls.Add(Me.pnlMob)
        Me.pnlFight.Controls.Add(Me.picFighting)
        Me.pnlFight.Location = New System.Drawing.Point(0, 0)
        Me.pnlFight.Name = "pnlFight"
        Me.pnlFight.Size = New System.Drawing.Size(1000, 750)
        Me.pnlFight.TabIndex = 5
        '
        'pnlDropMenu
        '
        Me.pnlDropMenu.BackColor = System.Drawing.Color.DimGray
        Me.pnlDropMenu.Controls.Add(Me.lblExitDropMenu)
        Me.pnlDropMenu.Controls.Add(Me.lblDrop5)
        Me.pnlDropMenu.Controls.Add(Me.picDrop5)
        Me.pnlDropMenu.Controls.Add(Me.lblDrop4)
        Me.pnlDropMenu.Controls.Add(Me.lblDrop3)
        Me.pnlDropMenu.Controls.Add(Me.picDrop4)
        Me.pnlDropMenu.Controls.Add(Me.picDrop3)
        Me.pnlDropMenu.Controls.Add(Me.lblDrop2)
        Me.pnlDropMenu.Controls.Add(Me.lblDrop1)
        Me.pnlDropMenu.Controls.Add(Me.lblDrop0)
        Me.pnlDropMenu.Controls.Add(Me.picDrop2)
        Me.pnlDropMenu.Controls.Add(Me.picDrop1)
        Me.pnlDropMenu.Controls.Add(Me.picDrop0)
        Me.pnlDropMenu.Controls.Add(Me.lblReceived)
        Me.pnlDropMenu.Location = New System.Drawing.Point(270, 42)
        Me.pnlDropMenu.Name = "pnlDropMenu"
        Me.pnlDropMenu.Size = New System.Drawing.Size(460, 652)
        Me.pnlDropMenu.TabIndex = 5
        Me.pnlDropMenu.Visible = False
        '
        'lblExitDropMenu
        '
        Me.lblExitDropMenu.AutoSize = True
        Me.lblExitDropMenu.BackColor = System.Drawing.Color.DimGray
        Me.lblExitDropMenu.Font = New System.Drawing.Font("Courier New", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExitDropMenu.ForeColor = System.Drawing.Color.White
        Me.lblExitDropMenu.Location = New System.Drawing.Point(391, 24)
        Me.lblExitDropMenu.Name = "lblExitDropMenu"
        Me.lblExitDropMenu.Size = New System.Drawing.Size(42, 43)
        Me.lblExitDropMenu.TabIndex = 31
        Me.lblExitDropMenu.Text = "X"
        Me.lblExitDropMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDrop5
        '
        Me.lblDrop5.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop5.ForeColor = System.Drawing.Color.White
        Me.lblDrop5.Location = New System.Drawing.Point(118, 545)
        Me.lblDrop5.Name = "lblDrop5"
        Me.lblDrop5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblDrop5.Size = New System.Drawing.Size(302, 72)
        Me.lblDrop5.TabIndex = 12
        Me.lblDrop5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picDrop5
        '
        Me.picDrop5.BackColor = System.Drawing.Color.Transparent
        Me.picDrop5.Location = New System.Drawing.Point(40, 545)
        Me.picDrop5.Name = "picDrop5"
        Me.picDrop5.Size = New System.Drawing.Size(72, 72)
        Me.picDrop5.TabIndex = 11
        Me.picDrop5.TabStop = False
        '
        'lblDrop4
        '
        Me.lblDrop4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop4.ForeColor = System.Drawing.Color.White
        Me.lblDrop4.Location = New System.Drawing.Point(118, 456)
        Me.lblDrop4.Name = "lblDrop4"
        Me.lblDrop4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblDrop4.Size = New System.Drawing.Size(302, 72)
        Me.lblDrop4.TabIndex = 10
        Me.lblDrop4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDrop3
        '
        Me.lblDrop3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop3.ForeColor = System.Drawing.Color.White
        Me.lblDrop3.Location = New System.Drawing.Point(118, 367)
        Me.lblDrop3.Name = "lblDrop3"
        Me.lblDrop3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblDrop3.Size = New System.Drawing.Size(302, 72)
        Me.lblDrop3.TabIndex = 9
        Me.lblDrop3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picDrop4
        '
        Me.picDrop4.BackColor = System.Drawing.Color.Transparent
        Me.picDrop4.Location = New System.Drawing.Point(40, 456)
        Me.picDrop4.Name = "picDrop4"
        Me.picDrop4.Size = New System.Drawing.Size(72, 72)
        Me.picDrop4.TabIndex = 8
        Me.picDrop4.TabStop = False
        '
        'picDrop3
        '
        Me.picDrop3.BackColor = System.Drawing.Color.Transparent
        Me.picDrop3.Location = New System.Drawing.Point(40, 367)
        Me.picDrop3.Name = "picDrop3"
        Me.picDrop3.Size = New System.Drawing.Size(72, 72)
        Me.picDrop3.TabIndex = 7
        Me.picDrop3.TabStop = False
        '
        'lblDrop2
        '
        Me.lblDrop2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop2.ForeColor = System.Drawing.Color.White
        Me.lblDrop2.Location = New System.Drawing.Point(118, 278)
        Me.lblDrop2.Name = "lblDrop2"
        Me.lblDrop2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblDrop2.Size = New System.Drawing.Size(302, 72)
        Me.lblDrop2.TabIndex = 6
        Me.lblDrop2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDrop1
        '
        Me.lblDrop1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop1.ForeColor = System.Drawing.Color.White
        Me.lblDrop1.Location = New System.Drawing.Point(118, 189)
        Me.lblDrop1.Name = "lblDrop1"
        Me.lblDrop1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblDrop1.Size = New System.Drawing.Size(302, 72)
        Me.lblDrop1.TabIndex = 5
        Me.lblDrop1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDrop0
        '
        Me.lblDrop0.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop0.ForeColor = System.Drawing.Color.White
        Me.lblDrop0.Location = New System.Drawing.Point(118, 100)
        Me.lblDrop0.Name = "lblDrop0"
        Me.lblDrop0.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblDrop0.Size = New System.Drawing.Size(302, 72)
        Me.lblDrop0.TabIndex = 4
        Me.lblDrop0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picDrop2
        '
        Me.picDrop2.BackColor = System.Drawing.Color.Transparent
        Me.picDrop2.Location = New System.Drawing.Point(40, 278)
        Me.picDrop2.Name = "picDrop2"
        Me.picDrop2.Size = New System.Drawing.Size(72, 72)
        Me.picDrop2.TabIndex = 3
        Me.picDrop2.TabStop = False
        '
        'picDrop1
        '
        Me.picDrop1.BackColor = System.Drawing.Color.Transparent
        Me.picDrop1.Location = New System.Drawing.Point(40, 189)
        Me.picDrop1.Name = "picDrop1"
        Me.picDrop1.Size = New System.Drawing.Size(72, 72)
        Me.picDrop1.TabIndex = 2
        Me.picDrop1.TabStop = False
        '
        'picDrop0
        '
        Me.picDrop0.BackColor = System.Drawing.Color.Transparent
        Me.picDrop0.Location = New System.Drawing.Point(40, 100)
        Me.picDrop0.Name = "picDrop0"
        Me.picDrop0.Size = New System.Drawing.Size(72, 72)
        Me.picDrop0.TabIndex = 1
        Me.picDrop0.TabStop = False
        '
        'lblReceived
        '
        Me.lblReceived.Font = New System.Drawing.Font("Courier New", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceived.ForeColor = System.Drawing.Color.White
        Me.lblReceived.Location = New System.Drawing.Point(0, 24)
        Me.lblReceived.Name = "lblReceived"
        Me.lblReceived.Size = New System.Drawing.Size(460, 43)
        Me.lblReceived.TabIndex = 0
        Me.lblReceived.Text = "You Won!"
        Me.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMob
        '
        Me.pnlMob.BackColor = System.Drawing.Color.Transparent
        Me.pnlMob.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.mobRaptor1
        Me.pnlMob.Location = New System.Drawing.Point(470, 499)
        Me.pnlMob.Name = "pnlMob"
        Me.pnlMob.Size = New System.Drawing.Size(440, 180)
        Me.pnlMob.TabIndex = 3
        '
        'picFighting
        '
        Me.picFighting.BackColor = System.Drawing.Color.Transparent
        Me.picFighting.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.fmhFightScene
        Me.picFighting.Controls.Add(Me.pnlPlayer)
        Me.picFighting.ErrorImage = Global.FalloutMonsterHunter.My.Resources.Resources.fmhFightScene
        Me.picFighting.Image = Global.FalloutMonsterHunter.My.Resources.Resources.fmhFightScene
        Me.picFighting.InitialImage = Global.FalloutMonsterHunter.My.Resources.Resources.fmhFightScene
        Me.picFighting.Location = New System.Drawing.Point(0, 0)
        Me.picFighting.Name = "picFighting"
        Me.picFighting.Size = New System.Drawing.Size(1000, 750)
        Me.picFighting.TabIndex = 4
        Me.picFighting.TabStop = False
        '
        'pnlPlayer
        '
        Me.pnlPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pnlPlayer.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.Player_Shoeless_Small160
        Me.pnlPlayer.Controls.Add(Me.picBoots)
        Me.pnlPlayer.Location = New System.Drawing.Point(90, 479)
        Me.pnlPlayer.Name = "pnlPlayer"
        Me.pnlPlayer.Size = New System.Drawing.Size(160, 200)
        Me.pnlPlayer.TabIndex = 2
        '
        'picBoots
        '
        Me.picBoots.BackColor = System.Drawing.Color.Transparent
        Me.picBoots.Controls.Add(Me.picLeggings)
        Me.picBoots.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorBoots1_Small160
        Me.picBoots.Location = New System.Drawing.Point(0, 0)
        Me.picBoots.Name = "picBoots"
        Me.picBoots.Size = New System.Drawing.Size(160, 200)
        Me.picBoots.TabIndex = 0
        Me.picBoots.TabStop = False
        '
        'picLeggings
        '
        Me.picLeggings.BackColor = System.Drawing.Color.Transparent
        Me.picLeggings.Controls.Add(Me.picChestplate)
        Me.picLeggings.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorLeggings1_Small160
        Me.picLeggings.Location = New System.Drawing.Point(0, 0)
        Me.picLeggings.Name = "picLeggings"
        Me.picLeggings.Size = New System.Drawing.Size(160, 200)
        Me.picLeggings.TabIndex = 1
        Me.picLeggings.TabStop = False
        '
        'picChestplate
        '
        Me.picChestplate.BackColor = System.Drawing.Color.Transparent
        Me.picChestplate.Controls.Add(Me.picHelmet)
        Me.picChestplate.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorChestplate1_Small160
        Me.picChestplate.Location = New System.Drawing.Point(0, 0)
        Me.picChestplate.Name = "picChestplate"
        Me.picChestplate.Size = New System.Drawing.Size(160, 200)
        Me.picChestplate.TabIndex = 1
        Me.picChestplate.TabStop = False
        '
        'picHelmet
        '
        Me.picHelmet.BackColor = System.Drawing.Color.Transparent
        Me.picHelmet.Controls.Add(Me.picWeapon)
        Me.picHelmet.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorHelmet1_Small160
        Me.picHelmet.Location = New System.Drawing.Point(0, 0)
        Me.picHelmet.Name = "picHelmet"
        Me.picHelmet.Size = New System.Drawing.Size(160, 200)
        Me.picHelmet.TabIndex = 1
        Me.picHelmet.TabStop = False
        '
        'picWeapon
        '
        Me.picWeapon.BackColor = System.Drawing.Color.Transparent
        Me.picWeapon.Image = Global.FalloutMonsterHunter.My.Resources.Resources.raptorWeapon1_Small160
        Me.picWeapon.Location = New System.Drawing.Point(0, 0)
        Me.picWeapon.Name = "picWeapon"
        Me.picWeapon.Size = New System.Drawing.Size(160, 200)
        Me.picWeapon.TabIndex = 1
        Me.picWeapon.TabStop = False
        '
        'pnlFujiCity
        '
        Me.pnlFujiCity.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.fujiCity
        Me.pnlFujiCity.Controls.Add(Me.btnFightUzirappter)
        Me.pnlFujiCity.Controls.Add(Me.btnFightMutahraptor)
        Me.pnlFujiCity.Controls.Add(Me.btnFightUnpheasantRaptor)
        Me.pnlFujiCity.Controls.Add(Me.PictureBox1)
        Me.pnlFujiCity.Controls.Add(Me.btnCrafting)
        Me.pnlFujiCity.Controls.Add(Me.btnInventory)
        Me.pnlFujiCity.Location = New System.Drawing.Point(1000, 750)
        Me.pnlFujiCity.Name = "pnlFujiCity"
        Me.pnlFujiCity.Size = New System.Drawing.Size(1000, 750)
        Me.pnlFujiCity.TabIndex = 4
        '
        'btnFightUzirappter
        '
        Me.btnFightUzirappter.BackColor = System.Drawing.Color.Transparent
        Me.btnFightUzirappter.FlatAppearance.BorderSize = 0
        Me.btnFightUzirappter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFightUzirappter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFightUzirappter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFightUzirappter.Image = Global.FalloutMonsterHunter.My.Resources.Resources.fmhRaptorHead3_86Icon
        Me.btnFightUzirappter.Location = New System.Drawing.Point(425, 395)
        Me.btnFightUzirappter.Name = "btnFightUzirappter"
        Me.btnFightUzirappter.Size = New System.Drawing.Size(99, 99)
        Me.btnFightUzirappter.TabIndex = 8
        Me.btnFightUzirappter.UseVisualStyleBackColor = False
        '
        'btnFightMutahraptor
        '
        Me.btnFightMutahraptor.BackColor = System.Drawing.Color.Transparent
        Me.btnFightMutahraptor.FlatAppearance.BorderSize = 0
        Me.btnFightMutahraptor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFightMutahraptor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFightMutahraptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFightMutahraptor.Image = Global.FalloutMonsterHunter.My.Resources.Resources.fmhRaptorHead2_86Icon
        Me.btnFightMutahraptor.Location = New System.Drawing.Point(710, 554)
        Me.btnFightMutahraptor.Name = "btnFightMutahraptor"
        Me.btnFightMutahraptor.Size = New System.Drawing.Size(99, 99)
        Me.btnFightMutahraptor.TabIndex = 7
        Me.btnFightMutahraptor.UseVisualStyleBackColor = False
        '
        'btnFightUnpheasantRaptor
        '
        Me.btnFightUnpheasantRaptor.BackColor = System.Drawing.Color.Transparent
        Me.btnFightUnpheasantRaptor.FlatAppearance.BorderSize = 0
        Me.btnFightUnpheasantRaptor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFightUnpheasantRaptor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFightUnpheasantRaptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFightUnpheasantRaptor.Image = Global.FalloutMonsterHunter.My.Resources.Resources.fmhRaptorHead1_86Icon_NoGlow
        Me.btnFightUnpheasantRaptor.Location = New System.Drawing.Point(624, 395)
        Me.btnFightUnpheasantRaptor.Name = "btnFightUnpheasantRaptor"
        Me.btnFightUnpheasantRaptor.Size = New System.Drawing.Size(99, 99)
        Me.btnFightUnpheasantRaptor.TabIndex = 6
        Me.btnFightUnpheasantRaptor.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FalloutMonsterHunter.My.Resources.Resources.fmhProtagonistHeadPNG
        Me.PictureBox1.Location = New System.Drawing.Point(874, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 91)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnCrafting
        '
        Me.btnCrafting.BackColor = System.Drawing.Color.DimGray
        Me.btnCrafting.FlatAppearance.BorderSize = 0
        Me.btnCrafting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrafting.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrafting.ForeColor = System.Drawing.Color.White
        Me.btnCrafting.Location = New System.Drawing.Point(174, 12)
        Me.btnCrafting.Name = "btnCrafting"
        Me.btnCrafting.Size = New System.Drawing.Size(140, 39)
        Me.btnCrafting.TabIndex = 3
        Me.btnCrafting.Text = "crafting"
        Me.btnCrafting.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.DimGray
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Location = New System.Drawing.Point(12, 12)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(150, 39)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "inventory"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackgroundImage = CType(resources.GetObject("pnlMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.pnlMainMenu.Controls.Add(Me.picBackdrop)
        Me.pnlMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(1000, 750)
        Me.pnlMainMenu.TabIndex = 2
        '
        'picBackdrop
        '
        Me.picBackdrop.Controls.Add(Me.btnPlay)
        Me.picBackdrop.Controls.Add(Me.picFader2)
        Me.picBackdrop.Controls.Add(Me.picFader)
        Me.picBackdrop.Image = Global.FalloutMonsterHunter.My.Resources.Resources.falloutMonsterHunterMainMenu1
        Me.picBackdrop.InitialImage = Nothing
        Me.picBackdrop.Location = New System.Drawing.Point(0, 0)
        Me.picBackdrop.Name = "picBackdrop"
        Me.picBackdrop.Size = New System.Drawing.Size(1000, 750)
        Me.picBackdrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBackdrop.TabIndex = 0
        Me.picBackdrop.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Location = New System.Drawing.Point(819, 343)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(122, 34)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'picFader2
        '
        Me.picFader2.BackColor = System.Drawing.Color.Transparent
        Me.picFader2.Location = New System.Drawing.Point(0, 0)
        Me.picFader2.Name = "picFader2"
        Me.picFader2.Size = New System.Drawing.Size(1000, 750)
        Me.picFader2.TabIndex = 5
        Me.picFader2.TabStop = False
        '
        'picFader
        '
        Me.picFader.BackColor = System.Drawing.Color.Transparent
        Me.picFader.Location = New System.Drawing.Point(0, 0)
        Me.picFader.Name = "picFader"
        Me.picFader.Size = New System.Drawing.Size(1000, 750)
        Me.picFader.TabIndex = 4
        Me.picFader.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 750)
        Me.Controls.Add(Me.pnlCraftingMenu)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.pnlFight)
        Me.Controls.Add(Me.pnlFujiCity)
        Me.Controls.Add(Me.pnlIntro)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fallout Monster Hunter"
        Me.pnlIntro.ResumeLayout(False)
        CType(Me.picIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picIntro.ResumeLayout(False)
        Me.pnlDialog.ResumeLayout(False)
        Me.pnlDialog.PerformLayout()
        Me.lblDialog.ResumeLayout(False)
        Me.lblDialog.PerformLayout()
        Me.pnlCraftingMenu.ResumeLayout(False)
        Me.pnlCraftingMenu.PerformLayout()
        Me.pnlCraftingItem.ResumeLayout(False)
        CType(Me.picComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picComponent4.ResumeLayout(False)
        Me.picComponent4.PerformLayout()
        CType(Me.picComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picComponent3.ResumeLayout(False)
        Me.picComponent3.PerformLayout()
        CType(Me.picComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picComponent2.ResumeLayout(False)
        Me.picComponent2.PerformLayout()
        CType(Me.picComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picComponent1.ResumeLayout(False)
        Me.picComponent1.PerformLayout()
        CType(Me.picComponent0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picComponent0.ResumeLayout(False)
        Me.picComponent0.PerformLayout()
        CType(Me.picCraftPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picCraftPic.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCraftingList.ResumeLayout(False)
        Me.pnlCraftNegativeOne.ResumeLayout(False)
        CType(Me.picCraft0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventory.ResumeLayout(False)
        Me.pnlInventory.PerformLayout()
        Me.pnlDeletion.ResumeLayout(False)
        Me.pnlPlayerPreview.ResumeLayout(False)
        CType(Me.picBigBoots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBigBoots.ResumeLayout(False)
        CType(Me.picBigLeggings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBigLeggings.ResumeLayout(False)
        CType(Me.picBigChestplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBigChestplate.ResumeLayout(False)
        CType(Me.picBigHelmet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBigHelmet.ResumeLayout(False)
        CType(Me.picBigWeapon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlotHelmet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlotChestplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlotLeggings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlotBoots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlotWeapon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvSlot0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picInvSlot0.ResumeLayout(False)
        Me.pnlFight.ResumeLayout(False)
        Me.pnlDropMenu.ResumeLayout(False)
        Me.pnlDropMenu.PerformLayout()
        CType(Me.picDrop5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDrop4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDrop3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDrop2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDrop1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDrop0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFighting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picFighting.ResumeLayout(False)
        Me.pnlPlayer.ResumeLayout(False)
        CType(Me.picBoots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBoots.ResumeLayout(False)
        CType(Me.picLeggings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picLeggings.ResumeLayout(False)
        CType(Me.picChestplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picChestplate.ResumeLayout(False)
        CType(Me.picHelmet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picHelmet.ResumeLayout(False)
        CType(Me.picWeapon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFujiCity.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainMenu.ResumeLayout(False)
        CType(Me.picBackdrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBackdrop.ResumeLayout(False)
        CType(Me.picFader2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMainMenu As Panel
    Friend WithEvents picBackdrop As PictureBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents pnlIntro As Panel
    Friend WithEvents picFader2 As PictureBox
    Friend WithEvents picFader As PictureBox
    Friend WithEvents picIntro As PictureBox
    Friend WithEvents pnlFujiCity As Panel
    Friend WithEvents lblDialog As Label
    Friend WithEvents lblOutline As Label
    Friend WithEvents lblSpeaker As Label
    Friend WithEvents pnlDialog As Panel
    Friend WithEvents lblBigOutline As Label
    Friend WithEvents txtUserIn As TextBox
    Friend WithEvents lblClickCont As Label
    Friend WithEvents pnlFight As Panel
    Friend WithEvents picMob As PictureBox
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents pnlMob As Panel
    Friend WithEvents pnlPlayer As Panel
    Friend WithEvents picFighting As PictureBox
    Friend WithEvents timerMove As Timer
    Friend WithEvents waitTimer As Timer
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents picSlotHelmet As PictureBox
    Friend WithEvents picSlotChestplate As PictureBox
    Friend WithEvents picSlotLeggings As PictureBox
    Friend WithEvents picSlotBoots As PictureBox
    Friend WithEvents picSlotWeapon As PictureBox
    Friend WithEvents picInvSlot23 As PictureBox
    Friend WithEvents picInvSlot15 As PictureBox
    Friend WithEvents picInvSlot7 As PictureBox
    Friend WithEvents picInvSlot22 As PictureBox
    Friend WithEvents picInvSlot14 As PictureBox
    Friend WithEvents picInvSlot6 As PictureBox
    Friend WithEvents picInvSlot21 As PictureBox
    Friend WithEvents picInvSlot13 As PictureBox
    Friend WithEvents picInvSlot5 As PictureBox
    Friend WithEvents picInvSlot20 As PictureBox
    Friend WithEvents picInvSlot12 As PictureBox
    Friend WithEvents picInvSlot4 As PictureBox
    Friend WithEvents picInvSlot19 As PictureBox
    Friend WithEvents picInvSlot11 As PictureBox
    Friend WithEvents picInvSlot3 As PictureBox
    Friend WithEvents picInvSlot18 As PictureBox
    Friend WithEvents picInvSlot10 As PictureBox
    Friend WithEvents picInvSlot2 As PictureBox
    Friend WithEvents picInvSlot17 As PictureBox
    Friend WithEvents picInvSlot9 As PictureBox
    Friend WithEvents picInvSlot1 As PictureBox
    Friend WithEvents picInvSlot16 As PictureBox
    Friend WithEvents picInvSlot8 As PictureBox
    Friend WithEvents picInvSlot0 As PictureBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblExitInventory As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCrafting As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnFightUnpheasantRaptor As Button
    Friend WithEvents pnlDropMenu As Panel
    Friend WithEvents picDrop0 As PictureBox
    Friend WithEvents lblReceived As Label
    Friend WithEvents picDrop1 As PictureBox
    Friend WithEvents lblDrop5 As Label
    Friend WithEvents picDrop5 As PictureBox
    Friend WithEvents lblDrop4 As Label
    Friend WithEvents lblDrop3 As Label
    Friend WithEvents picDrop4 As PictureBox
    Friend WithEvents picDrop3 As PictureBox
    Friend WithEvents lblDrop2 As Label
    Friend WithEvents lblDrop1 As Label
    Friend WithEvents lblDrop0 As Label
    Friend WithEvents picDrop2 As PictureBox
    Friend WithEvents lblExitDropMenu As Label
    Friend WithEvents lblStats As Label
    Friend WithEvents pnlCraftingMenu As Panel
    Friend WithEvents pnlCraftingList As Panel
    Friend WithEvents pnlCraftNegativeOne As Panel
    Friend WithEvents lblCraft0 As Label
    Friend WithEvents picCraft0 As PictureBox
    Friend WithEvents pnlCraftingItem As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCraftName As Label
    Friend WithEvents pnlScrollFrame As Panel
    Friend WithEvents scrlCraftingList As VScrollBar
    Friend WithEvents picCraftPic As PictureBox
    Friend WithEvents picComponent3 As PictureBox
    Friend WithEvents picComponent2 As PictureBox
    Friend WithEvents picComponent1 As PictureBox
    Friend WithEvents picComponent0 As PictureBox
    Friend WithEvents lblCraftStats As Label
    Friend WithEvents lblCraftingComponent0 As Label
    Friend WithEvents lblCraftingComponent3 As Label
    Friend WithEvents lblCraftingComponent2 As Label
    Friend WithEvents lblCraftingComponent1 As Label
    Friend WithEvents lblCraftingComponent4 As Label
    Friend WithEvents picComponent4 As PictureBox
    Friend WithEvents btnCraftEquipment As Button
    Friend WithEvents lblCloseCrafting As Label
    Friend WithEvents picBoots As PictureBox
    Friend WithEvents picLeggings As PictureBox
    Friend WithEvents picChestplate As PictureBox
    Friend WithEvents picHelmet As PictureBox
    Friend WithEvents picWeapon As PictureBox
    Friend WithEvents pnlPlayerPreview As Panel
    Friend WithEvents picBigBoots As PictureBox
    Friend WithEvents picBigLeggings As PictureBox
    Friend WithEvents picBigChestplate As PictureBox
    Friend WithEvents picBigHelmet As PictureBox
    Friend WithEvents picBigWeapon As PictureBox
    Friend WithEvents pnlDeletion As Panel
    Friend WithEvents lblDeleteConfirm As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFightMutahraptor As Button
    Friend WithEvents btnFightUzirappter As Button
End Class
