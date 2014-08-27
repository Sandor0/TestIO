<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.textBox_port = New System.Windows.Forms.TextBox()
		Me.textBox_history = New System.Windows.Forms.TextBox()
		Me.textBox_message = New System.Windows.Forms.TextBox()
		Me.button_send = New System.Windows.Forms.Button()
		Me.comboBox_IP = New System.Windows.Forms.ComboBox()
		Me.tabControl_commands = New System.Windows.Forms.TabControl()
		Me.listView_controlsChar = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.listBox_charBefore = New System.Windows.Forms.ListBox()
		Me.listBox_charAfter = New System.Windows.Forms.ListBox()
		Me.radioButton_before = New System.Windows.Forms.RadioButton()
		Me.radioButton_after = New System.Windows.Forms.RadioButton()
		Me.button_upChar = New System.Windows.Forms.Button()
		Me.button_downChar = New System.Windows.Forms.Button()
		Me.button_deleteChar = New System.Windows.Forms.Button()
		Me.button_addChar = New System.Windows.Forms.Button()
		Me.textBox_preview = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.groupBox_ip = New System.Windows.Forms.GroupBox()
		Me.button_IPDisconnect = New System.Windows.Forms.Button()
		Me.button_IPConnect = New System.Windows.Forms.Button()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
		Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.groupBox_serial = New System.Windows.Forms.GroupBox()
		Me.button_serialDisconnect = New System.Windows.Forms.Button()
		Me.comboBox_serialBauds = New System.Windows.Forms.ComboBox()
		Me.comboBox_serialPortName = New System.Windows.Forms.ComboBox()
		Me.button_serialConnect = New System.Windows.Forms.Button()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.button_hexDump = New System.Windows.Forms.Button()
		Me.checkBox_newLine = New System.Windows.Forms.CheckBox()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.groupBox_ip.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.MenuStrip2.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.groupBox_serial.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.SuspendLayout()
		'
		'textBox_port
		'
		Me.textBox_port.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.textBox_port.Location = New System.Drawing.Point(158, 0)
		Me.textBox_port.Name = "textBox_port"
		Me.textBox_port.Size = New System.Drawing.Size(80, 20)
		Me.textBox_port.TabIndex = 2
		Me.textBox_port.Text = "4001"
		'
		'textBox_history
		'
		Me.textBox_history.AcceptsReturn = True
		Me.textBox_history.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox_history.BackColor = System.Drawing.Color.White
		Me.textBox_history.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.textBox_history.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.textBox_history.Location = New System.Drawing.Point(0, 0)
		Me.textBox_history.Multiline = True
		Me.textBox_history.Name = "textBox_history"
		Me.textBox_history.ReadOnly = True
		Me.textBox_history.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox_history.Size = New System.Drawing.Size(517, 124)
		Me.textBox_history.TabIndex = 3
		Me.textBox_history.WordWrap = False
		'
		'textBox_message
		'
		Me.textBox_message.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox_message.Enabled = False
		Me.textBox_message.Location = New System.Drawing.Point(0, 130)
		Me.textBox_message.Name = "textBox_message"
		Me.textBox_message.Size = New System.Drawing.Size(436, 20)
		Me.textBox_message.TabIndex = 4
		Me.textBox_message.Text = "Test"
		'
		'button_send
		'
		Me.button_send.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_send.Enabled = False
		Me.button_send.Location = New System.Drawing.Point(442, 128)
		Me.button_send.Name = "button_send"
		Me.button_send.Size = New System.Drawing.Size(75, 23)
		Me.button_send.TabIndex = 5
		Me.button_send.Text = "Envoyer"
		Me.button_send.UseVisualStyleBackColor = True
		'
		'comboBox_IP
		'
		Me.comboBox_IP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBox_IP.FormattingEnabled = True
		Me.comboBox_IP.Items.AddRange(New Object() {"192.168.0.4", "192.168.0.105"})
		Me.comboBox_IP.Location = New System.Drawing.Point(0, 0)
		Me.comboBox_IP.Name = "comboBox_IP"
		Me.comboBox_IP.Size = New System.Drawing.Size(152, 21)
		Me.comboBox_IP.TabIndex = 8
		'
		'tabControl_commands
		'
		Me.tabControl_commands.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabControl_commands.Enabled = False
		Me.tabControl_commands.Location = New System.Drawing.Point(0, 189)
		Me.tabControl_commands.Name = "tabControl_commands"
		Me.tabControl_commands.SelectedIndex = 0
		Me.tabControl_commands.Size = New System.Drawing.Size(517, 196)
		Me.tabControl_commands.TabIndex = 11
		'
		'listView_controlsChar
		'
		Me.listView_controlsChar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.listView_controlsChar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
		Me.listView_controlsChar.FullRowSelect = True
		Me.listView_controlsChar.GridLines = True
		Me.listView_controlsChar.Location = New System.Drawing.Point(0, 0)
		Me.listView_controlsChar.MultiSelect = False
		Me.listView_controlsChar.Name = "listView_controlsChar"
		Me.listView_controlsChar.Size = New System.Drawing.Size(427, 237)
		Me.listView_controlsChar.TabIndex = 14
		Me.listView_controlsChar.UseCompatibleStateImageBehavior = False
		Me.listView_controlsChar.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "Caractères de contrôle"
		Me.ColumnHeader1.Width = 168
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Tag"
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "Code ASCII"
		Me.ColumnHeader3.Width = 83
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "Hex"
		'
		'listBox_charBefore
		'
		Me.listBox_charBefore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.listBox_charBefore.FormattingEnabled = True
		Me.listBox_charBefore.Location = New System.Drawing.Point(0, 0)
		Me.listBox_charBefore.Name = "listBox_charBefore"
		Me.listBox_charBefore.Size = New System.Drawing.Size(160, 173)
		Me.listBox_charBefore.TabIndex = 17
		'
		'listBox_charAfter
		'
		Me.listBox_charAfter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.listBox_charAfter.FormattingEnabled = True
		Me.listBox_charAfter.Location = New System.Drawing.Point(267, 0)
		Me.listBox_charAfter.Name = "listBox_charAfter"
		Me.listBox_charAfter.Size = New System.Drawing.Size(160, 173)
		Me.listBox_charAfter.TabIndex = 18
		'
		'radioButton_before
		'
		Me.radioButton_before.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.radioButton_before.AutoSize = True
		Me.radioButton_before.Location = New System.Drawing.Point(107, 35)
		Me.radioButton_before.Name = "radioButton_before"
		Me.radioButton_before.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.radioButton_before.Size = New System.Drawing.Size(53, 17)
		Me.radioButton_before.TabIndex = 19
		Me.radioButton_before.TabStop = True
		Me.radioButton_before.Text = "Avant"
		Me.radioButton_before.UseVisualStyleBackColor = True
		'
		'radioButton_after
		'
		Me.radioButton_after.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.radioButton_after.AutoSize = True
		Me.radioButton_after.Location = New System.Drawing.Point(267, 35)
		Me.radioButton_after.Name = "radioButton_after"
		Me.radioButton_after.Size = New System.Drawing.Size(52, 17)
		Me.radioButton_after.TabIndex = 20
		Me.radioButton_after.TabStop = True
		Me.radioButton_after.Text = "Après"
		Me.radioButton_after.UseVisualStyleBackColor = True
		'
		'button_upChar
		'
		Me.button_upChar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_upChar.Location = New System.Drawing.Point(166, 58)
		Me.button_upChar.Name = "button_upChar"
		Me.button_upChar.Size = New System.Drawing.Size(95, 27)
		Me.button_upChar.TabIndex = 21
		Me.button_upChar.Text = "Monter"
		Me.button_upChar.UseVisualStyleBackColor = True
		'
		'button_downChar
		'
		Me.button_downChar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_downChar.Location = New System.Drawing.Point(166, 91)
		Me.button_downChar.Name = "button_downChar"
		Me.button_downChar.Size = New System.Drawing.Size(95, 27)
		Me.button_downChar.TabIndex = 22
		Me.button_downChar.Text = "Descendre"
		Me.button_downChar.UseVisualStyleBackColor = True
		'
		'button_deleteChar
		'
		Me.button_deleteChar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_deleteChar.Location = New System.Drawing.Point(166, 141)
		Me.button_deleteChar.Name = "button_deleteChar"
		Me.button_deleteChar.Size = New System.Drawing.Size(95, 27)
		Me.button_deleteChar.TabIndex = 23
		Me.button_deleteChar.Text = "Supprimer"
		Me.button_deleteChar.UseVisualStyleBackColor = True
		'
		'button_addChar
		'
		Me.button_addChar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_addChar.Location = New System.Drawing.Point(166, 8)
		Me.button_addChar.Name = "button_addChar"
		Me.button_addChar.Size = New System.Drawing.Size(95, 27)
		Me.button_addChar.TabIndex = 24
		Me.button_addChar.Text = "Ajouter"
		Me.button_addChar.UseVisualStyleBackColor = True
		'
		'textBox_preview
		'
		Me.textBox_preview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox_preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.textBox_preview.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.textBox_preview.Location = New System.Drawing.Point(3, 9)
		Me.textBox_preview.Name = "textBox_preview"
		Me.textBox_preview.ReadOnly = True
		Me.textBox_preview.Size = New System.Drawing.Size(421, 20)
		Me.textBox_preview.TabIndex = 25
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.Controls.Add(Me.Panel3)
		Me.Panel1.Controls.Add(Me.listView_controlsChar)
		Me.Panel1.Location = New System.Drawing.Point(538, 52)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(427, 471)
		Me.Panel1.TabIndex = 26
		'
		'Panel3
		'
		Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel3.Controls.Add(Me.Panel2)
		Me.Panel3.Controls.Add(Me.textBox_preview)
		Me.Panel3.Controls.Add(Me.radioButton_before)
		Me.Panel3.Controls.Add(Me.radioButton_after)
		Me.Panel3.Location = New System.Drawing.Point(0, 240)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(427, 231)
		Me.Panel3.TabIndex = 27
		'
		'Panel2
		'
		Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Panel2.Controls.Add(Me.listBox_charAfter)
		Me.Panel2.Controls.Add(Me.listBox_charBefore)
		Me.Panel2.Controls.Add(Me.button_addChar)
		Me.Panel2.Controls.Add(Me.button_upChar)
		Me.Panel2.Controls.Add(Me.button_deleteChar)
		Me.Panel2.Controls.Add(Me.button_downChar)
		Me.Panel2.Location = New System.Drawing.Point(0, 58)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(427, 173)
		Me.Panel2.TabIndex = 27
		'
		'groupBox_ip
		'
		Me.groupBox_ip.Controls.Add(Me.button_IPDisconnect)
		Me.groupBox_ip.Controls.Add(Me.button_IPConnect)
		Me.groupBox_ip.Controls.Add(Me.Panel4)
		Me.groupBox_ip.Location = New System.Drawing.Point(12, 52)
		Me.groupBox_ip.Name = "groupBox_ip"
		Me.groupBox_ip.Size = New System.Drawing.Size(250, 81)
		Me.groupBox_ip.TabIndex = 27
		Me.groupBox_ip.TabStop = False
		Me.groupBox_ip.Text = "Connection par IP"
		'
		'button_IPDisconnect
		'
		Me.button_IPDisconnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_IPDisconnect.Location = New System.Drawing.Point(128, 47)
		Me.button_IPDisconnect.Name = "button_IPDisconnect"
		Me.button_IPDisconnect.Size = New System.Drawing.Size(116, 23)
		Me.button_IPDisconnect.TabIndex = 10
		Me.button_IPDisconnect.Text = "Deconnexion"
		Me.button_IPDisconnect.UseVisualStyleBackColor = True
		'
		'button_IPConnect
		'
		Me.button_IPConnect.Location = New System.Drawing.Point(6, 47)
		Me.button_IPConnect.Name = "button_IPConnect"
		Me.button_IPConnect.Size = New System.Drawing.Size(116, 23)
		Me.button_IPConnect.TabIndex = 6
		Me.button_IPConnect.Text = "Connexion"
		Me.button_IPConnect.UseVisualStyleBackColor = True
		'
		'Panel4
		'
		Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel4.Controls.Add(Me.comboBox_IP)
		Me.Panel4.Controls.Add(Me.textBox_port)
		Me.Panel4.Location = New System.Drawing.Point(6, 19)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(238, 22)
		Me.Panel4.TabIndex = 9
		'
		'MenuStrip2
		'
		Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
		Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip2.Name = "MenuStrip2"
		Me.MenuStrip2.Size = New System.Drawing.Size(977, 24)
		Me.MenuStrip2.TabIndex = 29
		Me.MenuStrip2.Text = "MenuStrip2"
		'
		'FichierToolStripMenuItem
		'
		Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
		Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
		Me.FichierToolStripMenuItem.Text = "Fichier"
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(977, 25)
		Me.ToolStrip1.TabIndex = 30
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(29, 22)
		Me.ToolStripLabel1.Text = "Test"
		'
		'groupBox_serial
		'
		Me.groupBox_serial.Controls.Add(Me.button_serialDisconnect)
		Me.groupBox_serial.Controls.Add(Me.comboBox_serialBauds)
		Me.groupBox_serial.Controls.Add(Me.comboBox_serialPortName)
		Me.groupBox_serial.Controls.Add(Me.button_serialConnect)
		Me.groupBox_serial.Location = New System.Drawing.Point(268, 52)
		Me.groupBox_serial.Name = "groupBox_serial"
		Me.groupBox_serial.Size = New System.Drawing.Size(261, 81)
		Me.groupBox_serial.TabIndex = 28
		Me.groupBox_serial.TabStop = False
		Me.groupBox_serial.Text = "Connection par port série"
		'
		'button_serialDisconnect
		'
		Me.button_serialDisconnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_serialDisconnect.Location = New System.Drawing.Point(133, 47)
		Me.button_serialDisconnect.Name = "button_serialDisconnect"
		Me.button_serialDisconnect.Size = New System.Drawing.Size(122, 23)
		Me.button_serialDisconnect.TabIndex = 10
		Me.button_serialDisconnect.Text = "Deconnexion"
		Me.button_serialDisconnect.UseVisualStyleBackColor = True
		'
		'comboBox_serialBauds
		'
		Me.comboBox_serialBauds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox_serialBauds.FormattingEnabled = True
		Me.comboBox_serialBauds.Items.AddRange(New Object() {"75", "110", "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
		Me.comboBox_serialBauds.Location = New System.Drawing.Point(163, 18)
		Me.comboBox_serialBauds.Name = "comboBox_serialBauds"
		Me.comboBox_serialBauds.Size = New System.Drawing.Size(92, 21)
		Me.comboBox_serialBauds.TabIndex = 9
		'
		'comboBox_serialPortName
		'
		Me.comboBox_serialPortName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBox_serialPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox_serialPortName.FormattingEnabled = True
		Me.comboBox_serialPortName.Location = New System.Drawing.Point(6, 19)
		Me.comboBox_serialPortName.Name = "comboBox_serialPortName"
		Me.comboBox_serialPortName.Size = New System.Drawing.Size(151, 21)
		Me.comboBox_serialPortName.TabIndex = 8
		'
		'button_serialConnect
		'
		Me.button_serialConnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.button_serialConnect.Location = New System.Drawing.Point(6, 47)
		Me.button_serialConnect.Name = "button_serialConnect"
		Me.button_serialConnect.Size = New System.Drawing.Size(121, 23)
		Me.button_serialConnect.TabIndex = 6
		Me.button_serialConnect.Text = "Connexion"
		Me.button_serialConnect.UseVisualStyleBackColor = True
		'
		'Panel6
		'
		Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel6.Controls.Add(Me.textBox_history)
		Me.Panel6.Controls.Add(Me.textBox_message)
		Me.Panel6.Controls.Add(Me.button_send)
		Me.Panel6.Location = New System.Drawing.Point(0, 32)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(517, 151)
		Me.Panel6.TabIndex = 31
		'
		'Panel7
		'
		Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel7.Controls.Add(Me.button_hexDump)
		Me.Panel7.Controls.Add(Me.checkBox_newLine)
		Me.Panel7.Controls.Add(Me.tabControl_commands)
		Me.Panel7.Controls.Add(Me.Panel6)
		Me.Panel7.Location = New System.Drawing.Point(12, 139)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(517, 385)
		Me.Panel7.TabIndex = 32
		'
		'button_hexDump
		'
		Me.button_hexDump.Location = New System.Drawing.Point(97, 3)
		Me.button_hexDump.Name = "button_hexDump"
		Me.button_hexDump.Size = New System.Drawing.Size(75, 23)
		Me.button_hexDump.TabIndex = 33
		Me.button_hexDump.Text = "HexDump"
		Me.button_hexDump.UseVisualStyleBackColor = True
		'
		'checkBox_newLine
		'
		Me.checkBox_newLine.AutoSize = True
		Me.checkBox_newLine.Location = New System.Drawing.Point(3, 3)
		Me.checkBox_newLine.Name = "checkBox_newLine"
		Me.checkBox_newLine.Size = New System.Drawing.Size(88, 17)
		Me.checkBox_newLine.TabIndex = 32
		Me.checkBox_newLine.Text = "Saut de ligne"
		Me.checkBox_newLine.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(977, 535)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.groupBox_serial)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.groupBox_ip)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.MenuStrip2)
		Me.MinimumSize = New System.Drawing.Size(993, 500)
		Me.Name = "Form1"
		Me.Text = "Testeur de protocole"
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.groupBox_ip.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.MenuStrip2.ResumeLayout(False)
		Me.MenuStrip2.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.groupBox_serial.ResumeLayout(False)
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents textBox_port As System.Windows.Forms.TextBox
	Friend WithEvents textBox_history As System.Windows.Forms.TextBox
	Friend WithEvents textBox_message As System.Windows.Forms.TextBox
	Friend WithEvents button_send As System.Windows.Forms.Button
	Friend WithEvents comboBox_IP As System.Windows.Forms.ComboBox
	Friend WithEvents tabControl_commands As System.Windows.Forms.TabControl
	Friend WithEvents listView_controlsChar As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents listBox_charBefore As System.Windows.Forms.ListBox
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
	Friend WithEvents listBox_charAfter As System.Windows.Forms.ListBox
	Friend WithEvents radioButton_before As System.Windows.Forms.RadioButton
	Friend WithEvents radioButton_after As System.Windows.Forms.RadioButton
	Friend WithEvents button_upChar As System.Windows.Forms.Button
	Friend WithEvents button_downChar As System.Windows.Forms.Button
	Friend WithEvents button_deleteChar As System.Windows.Forms.Button
	Friend WithEvents button_addChar As System.Windows.Forms.Button
	Friend WithEvents textBox_preview As System.Windows.Forms.TextBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents groupBox_ip As System.Windows.Forms.GroupBox
	Friend WithEvents Panel4 As System.Windows.Forms.Panel
	Friend WithEvents button_IPDisconnect As System.Windows.Forms.Button
	Friend WithEvents button_IPConnect As System.Windows.Forms.Button
	Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
	Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents groupBox_serial As System.Windows.Forms.GroupBox
	Friend WithEvents comboBox_serialPortName As System.Windows.Forms.ComboBox
	Friend WithEvents button_serialConnect As System.Windows.Forms.Button
	Friend WithEvents comboBox_serialBauds As System.Windows.Forms.ComboBox
	Friend WithEvents Panel6 As System.Windows.Forms.Panel
	Friend WithEvents Panel7 As System.Windows.Forms.Panel
	Friend WithEvents button_serialDisconnect As System.Windows.Forms.Button
	Friend WithEvents checkBox_newLine As System.Windows.Forms.CheckBox
	Friend WithEvents button_hexDump As System.Windows.Forms.Button
	Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

End Class
