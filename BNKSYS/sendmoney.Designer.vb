﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sendmoney
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.TextBoxSendMoney = New System.Windows.Forms.TextBox()
        Me.PanelWhite = New System.Windows.Forms.Panel()
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.LabelBank = New System.Windows.Forms.Label()
        Me.LabelSendMoney = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonThree = New System.Windows.Forms.Button()
        Me.ButtonSix = New System.Windows.Forms.Button()
        Me.ButtonNine = New System.Windows.Forms.Button()
        Me.ButtonZero = New System.Windows.Forms.Button()
        Me.ButtonTwo = New System.Windows.Forms.Button()
        Me.ButtonFive = New System.Windows.Forms.Button()
        Me.ButtonEight = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonOne = New System.Windows.Forms.Button()
        Me.ButtonFour = New System.Windows.Forms.Button()
        Me.ButtonSeven = New System.Windows.Forms.Button()
        Me.SEND_BTN = New System.Windows.Forms.Button()
        Me.PanelTop.SuspendLayout()
        Me.PanelWhite.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.TextBoxSendMoney)
        Me.PanelTop.Controls.Add(Me.PanelWhite)
        Me.PanelTop.Controls.Add(Me.LabelBank)
        Me.PanelTop.Controls.Add(Me.LabelSendMoney)
        Me.PanelTop.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTop.Location = New System.Drawing.Point(1, -1)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(776, 149)
        Me.PanelTop.TabIndex = 26
        '
        'TextBoxSendMoney
        '
        Me.TextBoxSendMoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBoxSendMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSendMoney.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxSendMoney.Font = New System.Drawing.Font("Elephant", 25.8!)
        Me.TextBoxSendMoney.ForeColor = System.Drawing.Color.White
        Me.TextBoxSendMoney.Location = New System.Drawing.Point(234, 85)
        Me.TextBoxSendMoney.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBoxSendMoney.Name = "TextBoxSendMoney"
        Me.TextBoxSendMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxSendMoney.Size = New System.Drawing.Size(280, 52)
        Me.TextBoxSendMoney.TabIndex = 1
        Me.TextBoxSendMoney.Text = "0"
        Me.TextBoxSendMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelWhite
        '
        Me.PanelWhite.BackColor = System.Drawing.Color.White
        Me.PanelWhite.Controls.Add(Me.LabelAmount)
        Me.PanelWhite.Location = New System.Drawing.Point(256, 40)
        Me.PanelWhite.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PanelWhite.Name = "PanelWhite"
        Me.PanelWhite.Size = New System.Drawing.Size(238, 61)
        Me.PanelWhite.TabIndex = 3
        '
        'LabelAmount
        '
        Me.LabelAmount.AutoSize = True
        Me.LabelAmount.BackColor = System.Drawing.Color.White
        Me.LabelAmount.Font = New System.Drawing.Font("Elephant", 20.25!)
        Me.LabelAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LabelAmount.Location = New System.Drawing.Point(22, 9)
        Me.LabelAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Size = New System.Drawing.Size(210, 35)
        Me.LabelAmount.TabIndex = 4
        Me.LabelAmount.Text = "Enter Amount"
        '
        'LabelBank
        '
        Me.LabelBank.AutoSize = True
        Me.LabelBank.Font = New System.Drawing.Font("Elephant", 11.25!)
        Me.LabelBank.Location = New System.Drawing.Point(591, 27)
        Me.LabelBank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBank.Name = "LabelBank"
        Me.LabelBank.Size = New System.Drawing.Size(173, 20)
        Me.LabelBank.TabIndex = 1
        Me.LabelBank.Text = "Clark Cloud Holdings"
        '
        'LabelSendMoney
        '
        Me.LabelSendMoney.AutoSize = True
        Me.LabelSendMoney.Font = New System.Drawing.Font("Elephant", 24.0!)
        Me.LabelSendMoney.Location = New System.Drawing.Point(19, 14)
        Me.LabelSendMoney.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSendMoney.Name = "LabelSendMoney"
        Me.LabelSendMoney.Size = New System.Drawing.Size(214, 41)
        Me.LabelSendMoney.TabIndex = 0
        Me.LabelSendMoney.Text = "Send Money"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonDelete.FlatAppearance.BorderSize = 2
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonDelete.Location = New System.Drawing.Point(232, 358)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(90, 45)
        Me.ButtonDelete.TabIndex = 37
        Me.ButtonDelete.Text = "Del"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonThree
        '
        Me.ButtonThree.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonThree.FlatAppearance.BorderSize = 2
        Me.ButtonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonThree.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonThree.Location = New System.Drawing.Point(421, 308)
        Me.ButtonThree.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonThree.Name = "ButtonThree"
        Me.ButtonThree.Size = New System.Drawing.Size(90, 45)
        Me.ButtonThree.TabIndex = 30
        Me.ButtonThree.Text = "3"
        Me.ButtonThree.UseVisualStyleBackColor = True
        '
        'ButtonSix
        '
        Me.ButtonSix.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonSix.FlatAppearance.BorderSize = 2
        Me.ButtonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSix.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonSix.Location = New System.Drawing.Point(421, 258)
        Me.ButtonSix.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonSix.Name = "ButtonSix"
        Me.ButtonSix.Size = New System.Drawing.Size(90, 45)
        Me.ButtonSix.TabIndex = 33
        Me.ButtonSix.Text = "6"
        Me.ButtonSix.UseVisualStyleBackColor = True
        '
        'ButtonNine
        '
        Me.ButtonNine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonNine.FlatAppearance.BorderSize = 2
        Me.ButtonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNine.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonNine.Location = New System.Drawing.Point(421, 207)
        Me.ButtonNine.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonNine.Name = "ButtonNine"
        Me.ButtonNine.Size = New System.Drawing.Size(90, 45)
        Me.ButtonNine.TabIndex = 36
        Me.ButtonNine.Text = "9"
        Me.ButtonNine.UseVisualStyleBackColor = True
        '
        'ButtonZero
        '
        Me.ButtonZero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonZero.FlatAppearance.BorderSize = 2
        Me.ButtonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonZero.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonZero.Location = New System.Drawing.Point(326, 358)
        Me.ButtonZero.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonZero.Name = "ButtonZero"
        Me.ButtonZero.Size = New System.Drawing.Size(90, 45)
        Me.ButtonZero.TabIndex = 27
        Me.ButtonZero.Text = "0"
        Me.ButtonZero.UseVisualStyleBackColor = True
        '
        'ButtonTwo
        '
        Me.ButtonTwo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonTwo.FlatAppearance.BorderSize = 2
        Me.ButtonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTwo.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonTwo.Location = New System.Drawing.Point(326, 308)
        Me.ButtonTwo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonTwo.Name = "ButtonTwo"
        Me.ButtonTwo.Size = New System.Drawing.Size(90, 45)
        Me.ButtonTwo.TabIndex = 29
        Me.ButtonTwo.Text = "2"
        Me.ButtonTwo.UseVisualStyleBackColor = True
        '
        'ButtonFive
        '
        Me.ButtonFive.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonFive.FlatAppearance.BorderSize = 2
        Me.ButtonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFive.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonFive.Location = New System.Drawing.Point(326, 258)
        Me.ButtonFive.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonFive.Name = "ButtonFive"
        Me.ButtonFive.Size = New System.Drawing.Size(90, 45)
        Me.ButtonFive.TabIndex = 32
        Me.ButtonFive.Text = "5"
        Me.ButtonFive.UseVisualStyleBackColor = True
        '
        'ButtonEight
        '
        Me.ButtonEight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonEight.FlatAppearance.BorderSize = 2
        Me.ButtonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEight.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonEight.Location = New System.Drawing.Point(326, 207)
        Me.ButtonEight.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonEight.Name = "ButtonEight"
        Me.ButtonEight.Size = New System.Drawing.Size(90, 45)
        Me.ButtonEight.TabIndex = 35
        Me.ButtonEight.Text = "8"
        Me.ButtonEight.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonBack.FlatAppearance.BorderSize = 2
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonBack.Location = New System.Drawing.Point(11, 429)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(115, 45)
        Me.ButtonBack.TabIndex = 38
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonOne
        '
        Me.ButtonOne.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonOne.FlatAppearance.BorderSize = 2
        Me.ButtonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOne.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonOne.Location = New System.Drawing.Point(231, 308)
        Me.ButtonOne.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonOne.Name = "ButtonOne"
        Me.ButtonOne.Size = New System.Drawing.Size(90, 45)
        Me.ButtonOne.TabIndex = 28
        Me.ButtonOne.Text = "1"
        Me.ButtonOne.UseVisualStyleBackColor = True
        '
        'ButtonFour
        '
        Me.ButtonFour.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonFour.FlatAppearance.BorderSize = 2
        Me.ButtonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFour.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonFour.Location = New System.Drawing.Point(231, 258)
        Me.ButtonFour.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonFour.Name = "ButtonFour"
        Me.ButtonFour.Size = New System.Drawing.Size(90, 45)
        Me.ButtonFour.TabIndex = 31
        Me.ButtonFour.Text = "4"
        Me.ButtonFour.UseVisualStyleBackColor = True
        '
        'ButtonSeven
        '
        Me.ButtonSeven.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ButtonSeven.FlatAppearance.BorderSize = 2
        Me.ButtonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSeven.Font = New System.Drawing.Font("Elephant", 10.2!)
        Me.ButtonSeven.Location = New System.Drawing.Point(231, 207)
        Me.ButtonSeven.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonSeven.Name = "ButtonSeven"
        Me.ButtonSeven.Size = New System.Drawing.Size(90, 45)
        Me.ButtonSeven.TabIndex = 34
        Me.ButtonSeven.Text = "7"
        Me.ButtonSeven.UseVisualStyleBackColor = True
        '
        'SEND_BTN
        '
        Me.SEND_BTN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SEND_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.SEND_BTN.FlatAppearance.BorderSize = 2
        Me.SEND_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SEND_BTN.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEND_BTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.SEND_BTN.Location = New System.Drawing.Point(421, 359)
        Me.SEND_BTN.Name = "SEND_BTN"
        Me.SEND_BTN.Size = New System.Drawing.Size(90, 45)
        Me.SEND_BTN.TabIndex = 40
        Me.SEND_BTN.Text = "Send"
        Me.SEND_BTN.UseVisualStyleBackColor = True
        '
        'sendmoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 486)
        Me.Controls.Add(Me.SEND_BTN)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonThree)
        Me.Controls.Add(Me.ButtonSix)
        Me.Controls.Add(Me.ButtonNine)
        Me.Controls.Add(Me.ButtonZero)
        Me.Controls.Add(Me.ButtonTwo)
        Me.Controls.Add(Me.ButtonFive)
        Me.Controls.Add(Me.ButtonEight)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonOne)
        Me.Controls.Add(Me.ButtonFour)
        Me.Controls.Add(Me.ButtonSeven)
        Me.Controls.Add(Me.PanelTop)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MinimumSize = New System.Drawing.Size(784, 525)
        Me.Name = "sendmoney"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Money"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelWhite.ResumeLayout(False)
        Me.PanelWhite.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As Panel
    Friend WithEvents TextBoxSendMoney As TextBox
    Friend WithEvents PanelWhite As Panel
    Friend WithEvents LabelAmount As Label
    Friend WithEvents LabelBank As Label
    Friend WithEvents LabelSendMoney As Label
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonThree As Button
    Friend WithEvents ButtonSix As Button
    Friend WithEvents ButtonNine As Button
    Friend WithEvents ButtonZero As Button
    Friend WithEvents ButtonTwo As Button
    Friend WithEvents ButtonFive As Button
    Friend WithEvents ButtonEight As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonOne As Button
    Friend WithEvents ButtonFour As Button
    Friend WithEvents ButtonSeven As Button
    Friend WithEvents SEND_BTN As Button
End Class
