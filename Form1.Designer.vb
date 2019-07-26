<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim menuNew As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        menuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuNew
        '
        menuNew.Name = "menuNew"
        menuNew.Size = New System.Drawing.Size(224, 26)
        menuNew.Text = "New              Ctrl + N"
        menuNew.ToolTipText = "Click to create a new file"
        AddHandler menuNew.Click, AddressOf Me.MenuNew_Click
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuEdit, Me.menuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {menuNew, Me.menuOpen, Me.menuSave, Me.menuSaveAs, Me.menuExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(44, 24)
        Me.menuFile.Text = "File"
        '
        'menuOpen
        '
        Me.menuOpen.Name = "menuOpen"
        Me.menuOpen.Size = New System.Drawing.Size(224, 26)
        Me.menuOpen.Text = "Open             Ctrl + O"
        Me.menuOpen.ToolTipText = "Click to open a file"
        '
        'menuSave
        '
        Me.menuSave.Name = "menuSave"
        Me.menuSave.Size = New System.Drawing.Size(224, 26)
        Me.menuSave.Text = "Save              Ctrl + S"
        Me.menuSave.ToolTipText = "Click to save file"
        '
        'menuSaveAs
        '
        Me.menuSaveAs.Name = "menuSaveAs"
        Me.menuSaveAs.Size = New System.Drawing.Size(224, 26)
        Me.menuSaveAs.Text = "Save As"
        Me.menuSaveAs.ToolTipText = "Click to save file as"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(224, 26)
        Me.menuExit.Text = "Exit"
        Me.menuExit.ToolTipText = "Click to exit program"
        '
        'menuEdit
        '
        Me.menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCopy, Me.menuCut, Me.menuPaste})
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(47, 24)
        Me.menuEdit.Text = "Edit"
        '
        'menuCopy
        '
        Me.menuCopy.Name = "menuCopy"
        Me.menuCopy.Size = New System.Drawing.Size(220, 26)
        Me.menuCopy.Text = "Copy             Ctrl+ C"
        Me.menuCopy.ToolTipText = "Click to copy text"
        '
        'menuCut
        '
        Me.menuCut.Name = "menuCut"
        Me.menuCut.Size = New System.Drawing.Size(220, 26)
        Me.menuCut.Text = "Cut                Ctrl + X"
        Me.menuCut.ToolTipText = "Click to cut text"
        '
        'menuPaste
        '
        Me.menuPaste.Name = "menuPaste"
        Me.menuPaste.Size = New System.Drawing.Size(220, 26)
        Me.menuPaste.Text = "Paste             Ctrl + V"
        Me.menuPaste.ToolTipText = "Click to paste text"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(53, 24)
        Me.menuHelp.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(13, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(583, 406)
        Me.TextBox1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Edit Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pineapple Pad"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuEdit As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuOpen As ToolStripMenuItem
    Friend WithEvents menuSave As ToolStripMenuItem
    Friend WithEvents menuSaveAs As ToolStripMenuItem
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents menuCopy As ToolStripMenuItem
    Friend WithEvents menuCut As ToolStripMenuItem
    Friend WithEvents menuPaste As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox1 As TextBox
End Class
