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
        Me.fadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pauseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.intervalPauseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlIntro = New System.Windows.Forms.Panel()
        Me.picIntro = New System.Windows.Forms.PictureBox()
        Me.pnlDialog = New System.Windows.Forms.Panel()
        Me.txtUserIn = New System.Windows.Forms.TextBox()
        Me.lblDialog = New System.Windows.Forms.Label()
        Me.lblClickCont = New System.Windows.Forms.Label()
        Me.lblBigOutline = New System.Windows.Forms.Label()
        Me.lblSpeaker = New System.Windows.Forms.Label()
        Me.textDisplayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFight = New System.Windows.Forms.Panel()
        Me.picFighting = New System.Windows.Forms.PictureBox()
        Me.pnlMob = New System.Windows.Forms.Panel()
        Me.pnlPlayer = New System.Windows.Forms.Panel()
        Me.pnlFujiCity = New System.Windows.Forms.Panel()
        Me.pnlMainMenu = New System.Windows.Forms.Panel()
        Me.picBackdrop = New System.Windows.Forms.PictureBox()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.picFader2 = New System.Windows.Forms.PictureBox()
        Me.picFader = New System.Windows.Forms.PictureBox()
        Me.pnlIntro.SuspendLayout()
        CType(Me.picIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picIntro.SuspendLayout()
        Me.pnlDialog.SuspendLayout()
        Me.lblDialog.SuspendLayout()
        Me.pnlFight.SuspendLayout()
        CType(Me.picFighting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picFighting.SuspendLayout()
        Me.pnlMainMenu.SuspendLayout()
        CType(Me.picBackdrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBackdrop.SuspendLayout()
        CType(Me.picFader2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fadeOutTimer
        '
        Me.fadeOutTimer.Interval = 20
        '
        'fadeInTimer
        '
        Me.fadeInTimer.Interval = 20
        '
        'pauseTimer
        '
        Me.pauseTimer.Interval = 1000
        '
        'intervalPauseTimer
        '
        Me.intervalPauseTimer.Interval = 50
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
        'pnlFight
        '
        Me.pnlFight.BackColor = System.Drawing.Color.DarkRed
        Me.pnlFight.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.fmhFightScene
        Me.pnlFight.Controls.Add(Me.picFighting)
        Me.pnlFight.Location = New System.Drawing.Point(0, 0)
        Me.pnlFight.Name = "pnlFight"
        Me.pnlFight.Size = New System.Drawing.Size(1000, 750)
        Me.pnlFight.TabIndex = 5
        '
        'picFighting
        '
        Me.picFighting.BackColor = System.Drawing.Color.Transparent
        Me.picFighting.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.fmhFightScene
        Me.picFighting.Controls.Add(Me.pnlMob)
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
        'pnlMob
        '
        Me.pnlMob.BackColor = System.Drawing.Color.Transparent
        Me.pnlMob.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.mobRaptor1
        Me.pnlMob.Location = New System.Drawing.Point(497, 499)
        Me.pnlMob.Name = "pnlMob"
        Me.pnlMob.Size = New System.Drawing.Size(440, 180)
        Me.pnlMob.TabIndex = 3
        '
        'pnlPlayer
        '
        Me.pnlPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pnlPlayer.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.itemRaptorBone1
        Me.pnlPlayer.Location = New System.Drawing.Point(84, 479)
        Me.pnlPlayer.Name = "pnlPlayer"
        Me.pnlPlayer.Size = New System.Drawing.Size(160, 200)
        Me.pnlPlayer.TabIndex = 2
        '
        'pnlFujiCity
        '
        Me.pnlFujiCity.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.fujiCity
        Me.pnlFujiCity.Location = New System.Drawing.Point(1000, 750)
        Me.pnlFujiCity.Name = "pnlFujiCity"
        Me.pnlFujiCity.Size = New System.Drawing.Size(1000, 750)
        Me.pnlFujiCity.TabIndex = 4
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackgroundImage = CType(resources.GetObject("pnlMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.pnlMainMenu.Controls.Add(Me.picBackdrop)
        Me.pnlMainMenu.Location = New System.Drawing.Point(1000, 750)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(1000, 750)
        Me.pnlMainMenu.TabIndex = 2
        '
        'picBackdrop
        '
        Me.picBackdrop.Controls.Add(Me.lblMoney)
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
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblMoney.ForeColor = System.Drawing.Color.White
        Me.lblMoney.Location = New System.Drawing.Point(266, 58)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(74, 17)
        Me.lblMoney.TabIndex = 1
        Me.lblMoney.Text = "Money: 50"
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
        Me.Controls.Add(Me.pnlFight)
        Me.Controls.Add(Me.pnlFujiCity)
        Me.Controls.Add(Me.pnlIntro)
        Me.Controls.Add(Me.pnlMainMenu)
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
        Me.pnlFight.ResumeLayout(False)
        CType(Me.picFighting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picFighting.ResumeLayout(False)
        Me.pnlMainMenu.ResumeLayout(False)
        CType(Me.picBackdrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBackdrop.ResumeLayout(False)
        Me.picBackdrop.PerformLayout()
        CType(Me.picFader2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMainMenu As Panel
    Friend WithEvents picBackdrop As PictureBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents fadeOutTimer As Timer
    Friend WithEvents lblMoney As Label
    Friend WithEvents fadeInTimer As Timer
    Friend WithEvents pnlIntro As Panel
    Friend WithEvents picFader2 As PictureBox
    Friend WithEvents picFader As PictureBox
    Friend WithEvents pauseTimer As Timer
    Friend WithEvents intervalPauseTimer As Timer
    Friend WithEvents picIntro As PictureBox
    Friend WithEvents pnlFujiCity As Panel
    Friend WithEvents lblDialog As Label
    Friend WithEvents lblOutline As Label
    Friend WithEvents lblSpeaker As Label
    Friend WithEvents pnlDialog As Panel
    Friend WithEvents lblBigOutline As Label
    Friend WithEvents txtUserIn As TextBox
    Friend WithEvents textDisplayTimer As Timer
    Friend WithEvents lblClickCont As Label
    Friend WithEvents pnlFight As Panel
    Friend WithEvents picMob As PictureBox
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents pnlMob As Panel
    Friend WithEvents pnlPlayer As Panel
    Friend WithEvents picFighting As PictureBox
End Class
