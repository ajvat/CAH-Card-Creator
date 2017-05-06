<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblTextFileType = New System.Windows.Forms.Label()
        Me.lblImageFileTypes = New System.Windows.Forms.Label()
        Me.lblDisclaimer = New System.Windows.Forms.Label()
        Me.tbxDestinationFolder = New System.Windows.Forms.TextBox()
        Me.tbxCardTextLocation = New System.Windows.Forms.TextBox()
        Me.tbxCardFrontLocation = New System.Windows.Forms.TextBox()
        Me.lblCardPreview = New System.Windows.Forms.Label()
        Me.pbxPreview = New System.Windows.Forms.PictureBox()
        Me.tbxFontSize = New System.Windows.Forms.MaskedTextBox()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.lblCardColor = New System.Windows.Forms.Label()
        Me.rdoWhite = New System.Windows.Forms.RadioButton()
        Me.rdoBlack = New System.Windows.Forms.RadioButton()
        Me.lblSetDestinationFolder = New System.Windows.Forms.Label()
        Me.cmdSetDestinationFolder = New System.Windows.Forms.Button()
        Me.lblCardTextLocations = New System.Windows.Forms.Label()
        Me.lblCardFrontLocation = New System.Windows.Forms.Label()
        Me.cmdSelectCardText = New System.Windows.Forms.Button()
        Me.cmdSelectCardFront = New System.Windows.Forms.Button()
        Me.cmdGenerateCards = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pbxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(669, 390)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(661, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Individual Card Generator"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblTextFileType)
        Me.TabPage2.Controls.Add(Me.lblImageFileTypes)
        Me.TabPage2.Controls.Add(Me.lblDisclaimer)
        Me.TabPage2.Controls.Add(Me.tbxDestinationFolder)
        Me.TabPage2.Controls.Add(Me.tbxCardTextLocation)
        Me.TabPage2.Controls.Add(Me.tbxCardFrontLocation)
        Me.TabPage2.Controls.Add(Me.lblCardPreview)
        Me.TabPage2.Controls.Add(Me.pbxPreview)
        Me.TabPage2.Controls.Add(Me.tbxFontSize)
        Me.TabPage2.Controls.Add(Me.lblFontSize)
        Me.TabPage2.Controls.Add(Me.lblCardColor)
        Me.TabPage2.Controls.Add(Me.rdoWhite)
        Me.TabPage2.Controls.Add(Me.rdoBlack)
        Me.TabPage2.Controls.Add(Me.lblSetDestinationFolder)
        Me.TabPage2.Controls.Add(Me.cmdSetDestinationFolder)
        Me.TabPage2.Controls.Add(Me.lblCardTextLocations)
        Me.TabPage2.Controls.Add(Me.lblCardFrontLocation)
        Me.TabPage2.Controls.Add(Me.cmdSelectCardText)
        Me.TabPage2.Controls.Add(Me.cmdSelectCardFront)
        Me.TabPage2.Controls.Add(Me.cmdGenerateCards)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(661, 364)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bulk Card Generator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblTextFileType
        '
        Me.lblTextFileType.AutoSize = True
        Me.lblTextFileType.Location = New System.Drawing.Point(178, 66)
        Me.lblTextFileType.Name = "lblTextFileType"
        Me.lblTextFileType.Size = New System.Drawing.Size(27, 13)
        Me.lblTextFileType.TabIndex = 40
        Me.lblTextFileType.Text = "(.txt)"
        '
        'lblImageFileTypes
        '
        Me.lblImageFileTypes.AutoSize = True
        Me.lblImageFileTypes.Location = New System.Drawing.Point(178, 12)
        Me.lblImageFileTypes.Name = "lblImageFileTypes"
        Me.lblImageFileTypes.Size = New System.Drawing.Size(126, 13)
        Me.lblImageFileTypes.TabIndex = 39
        Me.lblImageFileTypes.Text = "(.png, .jpg, .bmp, .gif, .tiff)"
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.AutoSize = True
        Me.lblDisclaimer.Location = New System.Drawing.Point(9, 246)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.Size = New System.Drawing.Size(267, 13)
        Me.lblDisclaimer.TabIndex = 38
        Me.lblDisclaimer.Text = "* Minimum card resolution is 822 x 1122 pixels (300DPI)"
        '
        'tbxDestinationFolder
        '
        Me.tbxDestinationFolder.Location = New System.Drawing.Point(114, 145)
        Me.tbxDestinationFolder.Name = "tbxDestinationFolder"
        Me.tbxDestinationFolder.ReadOnly = True
        Me.tbxDestinationFolder.Size = New System.Drawing.Size(283, 20)
        Me.tbxDestinationFolder.TabIndex = 37
        '
        'tbxCardTextLocation
        '
        Me.tbxCardTextLocation.Location = New System.Drawing.Point(114, 90)
        Me.tbxCardTextLocation.Name = "tbxCardTextLocation"
        Me.tbxCardTextLocation.ReadOnly = True
        Me.tbxCardTextLocation.Size = New System.Drawing.Size(283, 20)
        Me.tbxCardTextLocation.TabIndex = 36
        '
        'tbxCardFrontLocation
        '
        Me.tbxCardFrontLocation.Location = New System.Drawing.Point(114, 35)
        Me.tbxCardFrontLocation.Name = "tbxCardFrontLocation"
        Me.tbxCardFrontLocation.ReadOnly = True
        Me.tbxCardFrontLocation.Size = New System.Drawing.Size(283, 20)
        Me.tbxCardFrontLocation.TabIndex = 35
        '
        'lblCardPreview
        '
        Me.lblCardPreview.AutoSize = True
        Me.lblCardPreview.Location = New System.Drawing.Point(400, 12)
        Me.lblCardPreview.Name = "lblCardPreview"
        Me.lblCardPreview.Size = New System.Drawing.Size(78, 13)
        Me.lblCardPreview.TabIndex = 34
        Me.lblCardPreview.Text = "Blank Preview:"
        '
        'pbxPreview
        '
        Me.pbxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxPreview.Location = New System.Drawing.Point(403, 28)
        Me.pbxPreview.Name = "pbxPreview"
        Me.pbxPreview.Size = New System.Drawing.Size(249, 328)
        Me.pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPreview.TabIndex = 33
        Me.pbxPreview.TabStop = False
        '
        'tbxFontSize
        '
        Me.tbxFontSize.Location = New System.Drawing.Point(71, 171)
        Me.tbxFontSize.Mask = "000"
        Me.tbxFontSize.Name = "tbxFontSize"
        Me.tbxFontSize.Size = New System.Drawing.Size(100, 20)
        Me.tbxFontSize.TabIndex = 32
        Me.tbxFontSize.Text = "14"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(11, 174)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(54, 13)
        Me.lblFontSize.TabIndex = 31
        Me.lblFontSize.Text = "Font Size:"
        '
        'lblCardColor
        '
        Me.lblCardColor.AutoSize = True
        Me.lblCardColor.Location = New System.Drawing.Point(11, 199)
        Me.lblCardColor.Name = "lblCardColor"
        Me.lblCardColor.Size = New System.Drawing.Size(59, 13)
        Me.lblCardColor.TabIndex = 30
        Me.lblCardColor.Text = "Card Color:"
        '
        'rdoWhite
        '
        Me.rdoWhite.AutoSize = True
        Me.rdoWhite.Location = New System.Drawing.Point(134, 197)
        Me.rdoWhite.Name = "rdoWhite"
        Me.rdoWhite.Size = New System.Drawing.Size(53, 17)
        Me.rdoWhite.TabIndex = 29
        Me.rdoWhite.TabStop = True
        Me.rdoWhite.Text = "White"
        Me.rdoWhite.UseVisualStyleBackColor = True
        '
        'rdoBlack
        '
        Me.rdoBlack.AutoSize = True
        Me.rdoBlack.Location = New System.Drawing.Point(76, 197)
        Me.rdoBlack.Name = "rdoBlack"
        Me.rdoBlack.Size = New System.Drawing.Size(52, 17)
        Me.rdoBlack.TabIndex = 28
        Me.rdoBlack.TabStop = True
        Me.rdoBlack.Text = "Black"
        Me.rdoBlack.UseVisualStyleBackColor = True
        '
        'lblSetDestinationFolder
        '
        Me.lblSetDestinationFolder.AutoSize = True
        Me.lblSetDestinationFolder.Location = New System.Drawing.Point(9, 148)
        Me.lblSetDestinationFolder.Name = "lblSetDestinationFolder"
        Me.lblSetDestinationFolder.Size = New System.Drawing.Size(95, 13)
        Me.lblSetDestinationFolder.TabIndex = 27
        Me.lblSetDestinationFolder.Text = "Destination Folder:"
        '
        'cmdSetDestinationFolder
        '
        Me.cmdSetDestinationFolder.Location = New System.Drawing.Point(6, 116)
        Me.cmdSetDestinationFolder.Name = "cmdSetDestinationFolder"
        Me.cmdSetDestinationFolder.Size = New System.Drawing.Size(166, 23)
        Me.cmdSetDestinationFolder.TabIndex = 26
        Me.cmdSetDestinationFolder.Text = "Select Destination Folder"
        Me.cmdSetDestinationFolder.UseVisualStyleBackColor = True
        '
        'lblCardTextLocations
        '
        Me.lblCardTextLocations.AutoSize = True
        Me.lblCardTextLocations.Location = New System.Drawing.Point(9, 93)
        Me.lblCardTextLocations.Name = "lblCardTextLocations"
        Me.lblCardTextLocations.Size = New System.Drawing.Size(100, 13)
        Me.lblCardTextLocations.TabIndex = 25
        Me.lblCardTextLocations.Text = "Card Text Location:"
        '
        'lblCardFrontLocation
        '
        Me.lblCardFrontLocation.AutoSize = True
        Me.lblCardFrontLocation.Location = New System.Drawing.Point(9, 38)
        Me.lblCardFrontLocation.Name = "lblCardFrontLocation"
        Me.lblCardFrontLocation.Size = New System.Drawing.Size(99, 13)
        Me.lblCardFrontLocation.TabIndex = 24
        Me.lblCardFrontLocation.Text = "Card Front location:"
        '
        'cmdSelectCardText
        '
        Me.cmdSelectCardText.Location = New System.Drawing.Point(6, 61)
        Me.cmdSelectCardText.Name = "cmdSelectCardText"
        Me.cmdSelectCardText.Size = New System.Drawing.Size(166, 23)
        Me.cmdSelectCardText.TabIndex = 23
        Me.cmdSelectCardText.Text = "Select Card Text"
        Me.cmdSelectCardText.UseVisualStyleBackColor = True
        '
        'cmdSelectCardFront
        '
        Me.cmdSelectCardFront.Location = New System.Drawing.Point(6, 6)
        Me.cmdSelectCardFront.Name = "cmdSelectCardFront"
        Me.cmdSelectCardFront.Size = New System.Drawing.Size(166, 23)
        Me.cmdSelectCardFront.TabIndex = 22
        Me.cmdSelectCardFront.Text = "Select Card Front*"
        Me.cmdSelectCardFront.UseVisualStyleBackColor = True
        '
        'cmdGenerateCards
        '
        Me.cmdGenerateCards.Location = New System.Drawing.Point(6, 220)
        Me.cmdGenerateCards.Name = "cmdGenerateCards"
        Me.cmdGenerateCards.Size = New System.Drawing.Size(166, 23)
        Me.cmdGenerateCards.TabIndex = 21
        Me.cmdGenerateCards.Text = "Generate Cards"
        Me.cmdGenerateCards.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(700, 419)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "CAH Card Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pbxPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblTextFileType As Label
    Friend WithEvents lblImageFileTypes As Label
    Friend WithEvents lblDisclaimer As Label
    Friend WithEvents tbxDestinationFolder As TextBox
    Friend WithEvents tbxCardTextLocation As TextBox
    Friend WithEvents tbxCardFrontLocation As TextBox
    Friend WithEvents lblCardPreview As Label
    Friend WithEvents pbxPreview As PictureBox
    Friend WithEvents tbxFontSize As MaskedTextBox
    Friend WithEvents lblFontSize As Label
    Friend WithEvents lblCardColor As Label
    Friend WithEvents rdoWhite As RadioButton
    Friend WithEvents rdoBlack As RadioButton
    Friend WithEvents lblSetDestinationFolder As Label
    Friend WithEvents cmdSetDestinationFolder As Button
    Friend WithEvents lblCardTextLocations As Label
    Friend WithEvents lblCardFrontLocation As Label
    Friend WithEvents cmdSelectCardText As Button
    Friend WithEvents cmdSelectCardFront As Button
    Friend WithEvents cmdGenerateCards As Button
End Class
