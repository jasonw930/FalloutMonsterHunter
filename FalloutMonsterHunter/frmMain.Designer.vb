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
        Me.pnlMainMenu = New System.Windows.Forms.Panel()
        Me.picBackdrop = New System.Windows.Forms.PictureBox()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.picFader2 = New System.Windows.Forms.PictureBox()
        Me.picFader = New System.Windows.Forms.PictureBox()
        Me.pnlIntro = New System.Windows.Forms.Panel()
        Me.fadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMainMenu.SuspendLayout()
        CType(Me.picBackdrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBackdrop.SuspendLayout()
        CType(Me.picFader2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackgroundImage = Global.FalloutMonsterHunter.My.Resources.Resources.uziCartiBigBaller
        Me.pnlMainMenu.Controls.Add(Me.picBackdrop)
        Me.pnlMainMenu.Location = New System.Drawing.Point(0, 0)
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
        'pnlIntro
        '
        Me.pnlIntro.Location = New System.Drawing.Point(986, 0)
        Me.pnlIntro.Name = "pnlIntro"
        Me.pnlIntro.Size = New System.Drawing.Size(1000, 750)
        Me.pnlIntro.TabIndex = 3
        '
        'fadeOutTimer
        '
        Me.fadeOutTimer.Interval = 20
        '
        'fadeInTimer
        '
        Me.fadeInTimer.Interval = 20
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 750)
        Me.Controls.Add(Me.pnlIntro)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fallout Monster Hunter"
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
End Class
