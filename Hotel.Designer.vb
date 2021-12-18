<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHotel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotel))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.gbRoomType = New System.Windows.Forms.GroupBox()
        Me.rdRegular = New System.Windows.Forms.RadioButton()
        Me.rdDeluxe = New System.Windows.Forms.RadioButton()
        Me.rdSuite = New System.Windows.Forms.RadioButton()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.dpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblDatePicker = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.btnConfirm = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbType.SuspendLayout()
        Me.gbRoomType.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(564, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(224, 179)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'gbType
        '
        Me.gbType.Controls.Add(Me.txtDays)
        Me.gbType.Controls.Add(Me.lblDays)
        Me.gbType.Controls.Add(Me.gbRoomType)
        Me.gbType.Controls.Add(Me.cbType)
        Me.gbType.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbType.Location = New System.Drawing.Point(10, 148)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(225, 332)
        Me.gbType.TabIndex = 4
        Me.gbType.TabStop = False
        Me.gbType.Text = "Room Specicifcations"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(84, 268)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.ReadOnly = True
        Me.txtDays.Size = New System.Drawing.Size(119, 31)
        Me.txtDays.TabIndex = 7
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(16, 272)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(62, 21)
        Me.lblDays.TabIndex = 6
        Me.lblDays.Text = "Day(s)"
        '
        'gbRoomType
        '
        Me.gbRoomType.Controls.Add(Me.rdRegular)
        Me.gbRoomType.Controls.Add(Me.rdDeluxe)
        Me.gbRoomType.Controls.Add(Me.rdSuite)
        Me.gbRoomType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRoomType.Location = New System.Drawing.Point(20, 87)
        Me.gbRoomType.Name = "gbRoomType"
        Me.gbRoomType.Size = New System.Drawing.Size(183, 160)
        Me.gbRoomType.TabIndex = 5
        Me.gbRoomType.TabStop = False
        Me.gbRoomType.Text = "Room Type"
        '
        'rdRegular
        '
        Me.rdRegular.AutoSize = True
        Me.rdRegular.Location = New System.Drawing.Point(19, 114)
        Me.rdRegular.Name = "rdRegular"
        Me.rdRegular.Size = New System.Drawing.Size(88, 25)
        Me.rdRegular.TabIndex = 2
        Me.rdRegular.TabStop = True
        Me.rdRegular.Text = "Regular"
        Me.rdRegular.UseVisualStyleBackColor = True
        '
        'rdDeluxe
        '
        Me.rdDeluxe.AutoSize = True
        Me.rdDeluxe.Location = New System.Drawing.Point(19, 76)
        Me.rdDeluxe.Name = "rdDeluxe"
        Me.rdDeluxe.Size = New System.Drawing.Size(81, 25)
        Me.rdDeluxe.TabIndex = 1
        Me.rdDeluxe.TabStop = True
        Me.rdDeluxe.Text = "Deluxe"
        Me.rdDeluxe.UseVisualStyleBackColor = True
        '
        'rdSuite
        '
        Me.rdSuite.AutoSize = True
        Me.rdSuite.Location = New System.Drawing.Point(19, 39)
        Me.rdSuite.Name = "rdSuite"
        Me.rdSuite.Size = New System.Drawing.Size(66, 25)
        Me.rdSuite.TabIndex = 0
        Me.rdSuite.TabStop = True
        Me.rdSuite.Text = "Suite"
        Me.rdSuite.UseVisualStyleBackColor = True
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Single", "Double", "Family"})
        Me.cbType.Location = New System.Drawing.Point(20, 39)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(183, 30)
        Me.cbType.TabIndex = 0
        '
        'dpCheckIn
        '
        Me.dpCheckIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpCheckIn.Location = New System.Drawing.Point(257, 215)
        Me.dpCheckIn.MaxDate = New Date(2021, 12, 16, 0, 0, 0, 0)
        Me.dpCheckIn.MinDate = New Date(2021, 12, 13, 5, 47, 23, 0)
        Me.dpCheckIn.Name = "dpCheckIn"
        Me.dpCheckIn.Size = New System.Drawing.Size(276, 27)
        Me.dpCheckIn.TabIndex = 5
        Me.dpCheckIn.Value = New Date(2021, 12, 13, 5, 47, 23, 0)
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(252, 50)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(145, 25)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "MiHoyo Hotel"
        '
        'lblDatePicker
        '
        Me.lblDatePicker.AutoSize = True
        Me.lblDatePicker.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePicker.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDatePicker.Location = New System.Drawing.Point(318, 187)
        Me.lblDatePicker.Name = "lblDatePicker"
        Me.lblDatePicker.Size = New System.Drawing.Size(161, 25)
        Me.lblDatePicker.TabIndex = 7
        Me.lblDatePicker.Text = "Check-In Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(318, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Check-In Date"
        '
        'dpCheckOut
        '
        Me.dpCheckOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpCheckOut.Location = New System.Drawing.Point(257, 302)
        Me.dpCheckOut.MaxDate = New Date(2021, 12, 16, 0, 0, 0, 0)
        Me.dpCheckOut.MinDate = New Date(2021, 12, 13, 5, 47, 23, 0)
        Me.dpCheckOut.Name = "dpCheckOut"
        Me.dpCheckOut.Size = New System.Drawing.Size(276, 27)
        Me.dpCheckOut.TabIndex = 9
        Me.dpCheckOut.Value = New Date(2021, 12, 13, 5, 47, 23, 0)
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(257, 420)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(276, 60)
        Me.btnConfirm.TabIndex = 10
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.dpCheckOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDatePicker)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.dpCheckIn)
        Me.Controls.Add(Me.gbType)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmHotel"
        Me.Text = "Hotel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbType.ResumeLayout(False)
        Me.gbType.PerformLayout()
        Me.gbRoomType.ResumeLayout(False)
        Me.gbRoomType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gbType As GroupBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents gbRoomType As GroupBox
    Friend WithEvents rdSuite As RadioButton
    Friend WithEvents rdRegular As RadioButton
    Friend WithEvents rdDeluxe As RadioButton
    Friend WithEvents lblDays As Label
    Friend WithEvents dpCheckIn As DateTimePicker
    Friend WithEvents lblHeader As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents lblDatePicker As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dpCheckOut As DateTimePicker
    Friend WithEvents btnConfirm As Button
End Class
