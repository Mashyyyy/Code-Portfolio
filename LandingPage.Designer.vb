<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLandingPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLandingPage))
        Me.pnCart = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCafe = New System.Windows.Forms.Label()
        Me.lblMerch = New System.Windows.Forms.Label()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnCart
        '
        Me.pnCart.Location = New System.Drawing.Point(644, 12)
        Me.pnCart.Name = "pnCart"
        Me.pnCart.Size = New System.Drawing.Size(316, 634)
        Me.pnCart.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 661)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MiHoyo © All rights reserved"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(304, 142)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(321, 372)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(304, 142)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 516)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(304, 142)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblCafe
        '
        Me.lblCafe.AutoSize = True
        Me.lblCafe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCafe.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCafe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCafe.Location = New System.Drawing.Point(350, 283)
        Me.lblCafe.Name = "lblCafe"
        Me.lblCafe.Size = New System.Drawing.Size(233, 44)
        Me.lblCafe.TabIndex = 7
        Me.lblCafe.Text = "HoyoCafé >"
        '
        'lblMerch
        '
        Me.lblMerch.AutoSize = True
        Me.lblMerch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMerch.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMerch.Location = New System.Drawing.Point(36, 429)
        Me.lblMerch.Name = "lblMerch"
        Me.lblMerch.Size = New System.Drawing.Size(261, 44)
        Me.lblMerch.TabIndex = 8
        Me.lblMerch.Text = "< HoyoMerch"
        '
        'lblHotel
        '
        Me.lblHotel.AutoSize = True
        Me.lblHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHotel.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHotel.Location = New System.Drawing.Point(344, 561)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(239, 44)
        Me.lblHotel.TabIndex = 9
        Me.lblHotel.Text = "HoyoHotel >"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDateTime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateTime.Location = New System.Drawing.Point(354, 36)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(55, 22)
        Me.lblDateTime.TabIndex = 10
        Me.lblDateTime.Text = "date"
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'frmLandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(956, 674)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblHotel)
        Me.Controls.Add(Me.lblMerch)
        Me.Controls.Add(Me.lblCafe)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnCart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmLandingPage"
        Me.Text = "MiHoyo Festival"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnCart As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCafe As Label
    Friend WithEvents lblMerch As Label
    Friend WithEvents lblHotel As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents timer As Timer
End Class
