<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCart
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
        Me.lvCart = New System.Windows.Forms.ListView()
        Me.hItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCartHeader = New System.Windows.Forms.Label()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvCart
        '
        Me.lvCart.BackColor = System.Drawing.SystemColors.Window
        Me.lvCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hItem, Me.hPrice, Me.hQuantity})
        Me.lvCart.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCart.FullRowSelect = True
        Me.lvCart.GridLines = True
        Me.lvCart.HideSelection = False
        Me.lvCart.Location = New System.Drawing.Point(13, 63)
        Me.lvCart.Name = "lvCart"
        Me.lvCart.Size = New System.Drawing.Size(288, 477)
        Me.lvCart.TabIndex = 0
        Me.lvCart.UseCompatibleStateImageBehavior = False
        Me.lvCart.View = System.Windows.Forms.View.Details
        '
        'hItem
        '
        Me.hItem.Text = "Item(s)"
        Me.hItem.Width = 165
        '
        'hPrice
        '
        Me.hPrice.Text = "Price"
        Me.hPrice.Width = 80
        '
        'hQuantity
        '
        Me.hQuantity.Text = "Qty."
        Me.hQuantity.Width = 39
        '
        'lblCartHeader
        '
        Me.lblCartHeader.AutoSize = True
        Me.lblCartHeader.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartHeader.Location = New System.Drawing.Point(128, 24)
        Me.lblCartHeader.Name = "lblCartHeader"
        Me.lblCartHeader.Size = New System.Drawing.Size(88, 21)
        Me.lblCartHeader.TabIndex = 1
        Me.lblCartHeader.Text = "Cart Items"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.Location = New System.Drawing.Point(98, 560)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(118, 38)
        Me.btnCheckOut.TabIndex = 2
        Me.btnCheckOut.Text = "Check-Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'frmCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(313, 644)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.lblCartHeader)
        Me.Controls.Add(Me.lvCart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCart"
        Me.Text = "Cart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvCart As ListView
    Friend WithEvents hItem As ColumnHeader
    Friend WithEvents hPrice As ColumnHeader
    Friend WithEvents hQuantity As ColumnHeader
    Friend WithEvents lblCartHeader As Label
    Friend WithEvents btnCheckOut As Button
End Class
