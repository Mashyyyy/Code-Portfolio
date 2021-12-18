<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckOut))
        Me.lvFinalItems = New System.Windows.Forms.ListView()
        Me.hItems = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCafe = New System.Windows.Forms.Label()
        Me.txtTotCost = New System.Windows.Forms.TextBox()
        Me.lblTotCost = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.gbPaymentType = New System.Windows.Forms.GroupBox()
        Me.rdCard = New System.Windows.Forms.RadioButton()
        Me.rdCash = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPaymentType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvFinalItems
        '
        Me.lvFinalItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hItems, Me.hPrice, Me.hQuantity})
        Me.lvFinalItems.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFinalItems.FullRowSelect = True
        Me.lvFinalItems.GridLines = True
        Me.lvFinalItems.HideSelection = False
        Me.lvFinalItems.Location = New System.Drawing.Point(16, 17)
        Me.lvFinalItems.Name = "lvFinalItems"
        Me.lvFinalItems.Size = New System.Drawing.Size(403, 483)
        Me.lvFinalItems.TabIndex = 0
        Me.lvFinalItems.UseCompatibleStateImageBehavior = False
        Me.lvFinalItems.View = System.Windows.Forms.View.Details
        '
        'hItems
        '
        Me.hItems.Text = "Items"
        Me.hItems.Width = 262
        '
        'hPrice
        '
        Me.hPrice.Text = "Price"
        Me.hPrice.Width = 69
        '
        'hQuantity
        '
        Me.hQuantity.Text = "Quantity"
        Me.hQuantity.Width = 68
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(453, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblCafe
        '
        Me.lblCafe.AutoSize = True
        Me.lblCafe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCafe.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCafe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCafe.Location = New System.Drawing.Point(468, 213)
        Me.lblCafe.Name = "lblCafe"
        Me.lblCafe.Size = New System.Drawing.Size(320, 32)
        Me.lblCafe.TabIndex = 8
        Me.lblCafe.Text = "MiHoyo Festival Invoice"
        '
        'txtTotCost
        '
        Me.txtTotCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCost.Location = New System.Drawing.Point(540, 262)
        Me.txtTotCost.Name = "txtTotCost"
        Me.txtTotCost.ReadOnly = True
        Me.txtTotCost.Size = New System.Drawing.Size(248, 27)
        Me.txtTotCost.TabIndex = 9
        '
        'lblTotCost
        '
        Me.lblTotCost.AutoSize = True
        Me.lblTotCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCost.Location = New System.Drawing.Point(449, 265)
        Me.lblTotCost.Name = "lblTotCost"
        Me.lblTotCost.Size = New System.Drawing.Size(85, 21)
        Me.lblTotCost.TabIndex = 10
        Me.lblTotCost.Text = "TotalCost"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(449, 315)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(80, 21)
        Me.lblPayment.TabIndex = 12
        Me.lblPayment.Text = "Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(540, 312)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(248, 27)
        Me.txtPayment.TabIndex = 11
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(449, 476)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(75, 21)
        Me.lblChange.TabIndex = 14
        Me.lblChange.Text = "Change"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(540, 473)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(248, 27)
        Me.txtChange.TabIndex = 13
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(613, 356)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(134, 42)
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'gbPaymentType
        '
        Me.gbPaymentType.Controls.Add(Me.rdCard)
        Me.gbPaymentType.Controls.Add(Me.rdCash)
        Me.gbPaymentType.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPaymentType.Location = New System.Drawing.Point(453, 356)
        Me.gbPaymentType.Name = "gbPaymentType"
        Me.gbPaymentType.Size = New System.Drawing.Size(140, 99)
        Me.gbPaymentType.TabIndex = 16
        Me.gbPaymentType.TabStop = False
        Me.gbPaymentType.Text = "Payment Type"
        '
        'rdCard
        '
        Me.rdCard.AutoSize = True
        Me.rdCard.Location = New System.Drawing.Point(13, 58)
        Me.rdCard.Name = "rdCard"
        Me.rdCard.Size = New System.Drawing.Size(64, 24)
        Me.rdCard.TabIndex = 1
        Me.rdCard.TabStop = True
        Me.rdCard.Text = "Card"
        Me.rdCard.UseVisualStyleBackColor = True
        '
        'rdCash
        '
        Me.rdCash.AutoSize = True
        Me.rdCash.Location = New System.Drawing.Point(12, 28)
        Me.rdCash.Name = "rdCash"
        Me.rdCash.Size = New System.Drawing.Size(64, 24)
        Me.rdCash.TabIndex = 0
        Me.rdCash.TabStop = True
        Me.rdCash.Text = "Cash"
        Me.rdCash.UseVisualStyleBackColor = True
        '
        'frmCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 524)
        Me.Controls.Add(Me.gbPaymentType)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblTotCost)
        Me.Controls.Add(Me.txtTotCost)
        Me.Controls.Add(Me.lblCafe)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lvFinalItems)
        Me.Name = "frmCheckOut"
        Me.Text = "MiHoyo Festival Check Out"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPaymentType.ResumeLayout(False)
        Me.gbPaymentType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvFinalItems As ListView
    Friend WithEvents hItems As ColumnHeader
    Friend WithEvents hPrice As ColumnHeader
    Friend WithEvents hQuantity As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCafe As Label
    Friend WithEvents txtTotCost As TextBox
    Friend WithEvents lblTotCost As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents gbPaymentType As GroupBox
    Friend WithEvents rdCard As RadioButton
    Friend WithEvents rdCash As RadioButton
End Class
