Imports System.Net.Sockets
Imports System.Text
Imports System.Windows.Forms.ListView
Imports System.Windows.Forms.ListViewItem
Imports System.Windows.Forms.ListBox
Imports System.IO

Partial Public Class Form1

#Region "Constantes"
	Public Const TYPE_CONNECTION = 0
	Public Const TYPE_SEND = 1
	Public Const TYPE_RECEIVE = 2

	Private Const FILELOAD_NEW_TAB As Integer = 0
	Private Const FILELOAD_TAB_NAME As Integer = 1
	Private Const FILELOAD_NEW_COMMAND As Integer = 2
	Private Const FILELOAD_COMMAND_NAME As Integer = 3
	Private Const FILELOAD_COMMAND_LENGTH As Integer = 4
	Private Const FILELOAD_COMMAND_READ As Integer = 5
#End Region

#Region "Attributs"
	Private m_commandsDictionary As Dictionary(Of String, List(Of Command)) = New Dictionary(Of String, List(Of Command))
	Private m_currentCommand As Command = New Command()
#End Region

#Region "Form1.Load"
	Public Sub Form1_load(sender As Object, e As EventArgs) Handles Me.Load
		checkBox_newLine.Appearance = Appearance.Button
		loadControlChars()
		LoadIO()
		loadCommands()
		loadTab(m_commandsDictionary)
		updatePreview()
	End Sub
#End Region

#Region "Loader"
	Private Sub loadControlChars()
		For Each character_data As String() In ASCII.getInstance().getASCIIArray()
			Dim item As ListViewItem = listView_controlsChar.Items.Add(character_data(0))
			Dim subItem As New ListViewSubItemCollection(item)
			Dim hexa As String = Hex(character_data(2))
			If hexa.Length = 1 Then
				hexa = "0x0" & hexa
			Else
				hexa = "0x" & hexa
			End If

			subItem.Add(character_data(1))
			subItem.Add(character_data(2))
			subItem.Add(hexa)
		Next
	End Sub

	Private Sub LoadIO()
		For Each port As String In IO.Ports.SerialPort.GetPortNames()
			comboBox_serialPortName.Items.Add(port)
		Next
		If comboBox_serialPortName.Items.Count > 0 Then
			comboBox_serialPortName.SelectedIndex = 0
		End If
		comboBox_serialBauds.SelectedIndex = 6
	End Sub


	Private Sub loadCommands()
		tabControl_commands.TabPages.Clear()
		m_commandsDictionary.Clear()

		Dim binaryFile As BinaryReader = New BinaryReader(File.Open("test.cmdprot", FileMode.Open))
		Dim byteRead As Byte
		Dim pos As Integer = 0
		Dim state As Integer = -1

		Dim tabName As String = ""

		Dim commandName As String = ""
		Dim commandCode As String = ""
		Dim commandLength As Integer
		Dim commandReadPos As Integer
		Dim list As List(Of Command) = New List(Of Command)

		While pos < binaryFile.BaseStream.Length
			byteRead = binaryFile.ReadByte()
			If state = -1 And byteRead = &H1 Then	' Début du fichier
				state = FILELOAD_NEW_TAB
				tabName = ""
			ElseIf state = FILELOAD_NEW_TAB And byteRead = &H2 Then	' ETAT : Lecture du nom de l'onglet
				state = FILELOAD_TAB_NAME
			ElseIf (state = FILELOAD_TAB_NAME And byteRead = &H3) Then	' Fin de la lecture du nom de l'onglet
				state = FILELOAD_NEW_COMMAND
			ElseIf state = FILELOAD_TAB_NAME Then	' On lit le nom de l'onglet
				tabName &= Chr(byteRead)
			ElseIf (state = FILELOAD_NEW_COMMAND And byteRead = &H2) Then
				commandName = ""
				state = FILELOAD_COMMAND_NAME
			ElseIf (state = FILELOAD_COMMAND_NAME And byteRead = &H3) Then	' ETAT : Lecture de la taille de la commande
				state = FILELOAD_COMMAND_LENGTH
			ElseIf state = FILELOAD_COMMAND_NAME Then		' On lit le nom de la commande
				commandName &= Chr(byteRead)
			ElseIf state = FILELOAD_COMMAND_LENGTH Then	' On lit la taille de la commande
				commandLength = byteRead
				commandReadPos = 0
				state = FILELOAD_COMMAND_READ
			ElseIf state = FILELOAD_COMMAND_READ And commandReadPos = commandLength And byteRead = &H0 Then	' Fin de la commande
				list.Add(New Command(commandName, commandCode))
				commandCode = ""
				state = FILELOAD_NEW_COMMAND
			ElseIf state = FILELOAD_COMMAND_READ Then	' On lit la commande
				commandCode &= Chr(byteRead)
				commandReadPos += 1
			ElseIf state = FILELOAD_NEW_COMMAND And byteRead = &H4 Then
				m_commandsDictionary.Add(tabName, list)
				list = New List(Of Command)
				state = FILELOAD_NEW_TAB
				tabName = ""
			End If
			pos += 1
		End While
	End Sub

	Public Sub loadTab(ByVal tabs As Dictionary(Of String, List(Of Command)))
		For Each pair As KeyValuePair(Of String, List(Of Command)) In tabs
			Dim newTab As TabPage = New TabPage(pair.Key)
			Dim listView As ListView = New ListView()
			listView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
			listView.Dock = DockStyle.Fill
			listView.View = Windows.Forms.View.Details
			listView.FullRowSelect = True
			listView.GridLines = True
			listView.MultiSelect = False
			listView.Columns.Add("Nom de la commande").AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
			listView.Columns.Add("Code de la commande").AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
			AddHandler listView.DoubleClick, AddressOf listsViewCommands_doubleClick
			For Each cmd As Command In pair.Value
				listView.Items.Add(cmd.getName()).SubItems.Add(cmd.getDisplayCommand())
			Next
			newTab.Controls.Add(listView)
			tabControl_commands.TabPages.Add(newTab)
		Next
		addAdderTab()
		AddHandler tabControl_commands.SelectedIndexChanged, AddressOf addCommandTab
	End Sub

	Private Sub addCommandTab(sender As Object, e As EventArgs)
		If tabControl_commands.SelectedIndex = tabControl_commands.TabPages.Count - 1 Then
			Dim form As FormNewTab = New FormNewTab
			Dim result As DialogResult = form.ShowDialog()
			If result = Windows.Forms.DialogResult.OK And form.TextBox1.Text.Trim <> "" Then
				tabControl_commands.TabPages(tabControl_commands.TabPages.Count - 1).Text = form.TextBox1.Text
			Else
				tabControl_commands.SelectedIndex -= 1
				Exit Sub
			End If
			'tabControl_commands.TabPages.RemoveAt(tabControl_commands.TabPages.Count - 1)
		End If
	End Sub

	Private Sub addAdderTab()
		Dim tab As TabPage = New TabPage
		tab.Text = "+"

		tabControl_commands.TabPages.Add(tab)
	End Sub
#End Region

#Region "UI"

	Private Function getCommandByName(ByVal tabName As String, ByVal name As String) As Command
		For Each command As Command In m_commandsDictionary(tabName)
			If command.getName() = name Then
				Return command
			End If
		Next
		Return Nothing
	End Function

	Private Sub listsViewCommands_doubleClick(sender As Object, e As EventArgs)
		Dim listview As ListView = DirectCast(sender, ListView)
		Dim command As Command = getCommandByName(tabControl_commands.SelectedTab.Text, listview.Items(listview.SelectedIndices(0)).Text)
		send(command)
	End Sub

	Public Sub addToHistory(ByVal text As String, ByVal type As Integer)
		Dim toAppend As String = Now & " | "
		If connectionState = CONNECTION_STATE_INTERNET Then
			toAppend &= getValue(comboBox_IP) & ":" & textBox_port.Text & " | "
		ElseIf connectionState = CONNECTION_STATE_SERIAL Then
			toAppend &= getValue(comboBox_serialPortName) & " | "
		End If
		Select Case type
			Case TYPE_CONNECTION : toAppend &= "--- " : Exit Select
			Case TYPE_SEND : toAppend &= "--> " : Exit Select
			Case TYPE_RECEIVE : toAppend &= "<-- " : Exit Select
		End Select
		toAppend &= text & vbCrLf
		textBox_history.AppendText(toAppend)
	End Sub

	Private Sub updatePreview()
		updateCurrentCommand()
		textBox_preview.Text = m_currentCommand.getDisplayCommand()
	End Sub

	Private Sub checkBox_newLine_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_newLine.CheckedChanged
		textBox_history.WordWrap = checkBox_newLine.Checked
	End Sub

	Private Function getValue(combo As ComboBox) As String
		If combo.SelectedIndex >= 0 Then
			Return combo.SelectedItem.ToString
		Else
			Return combo.Text
		End If
	End Function
#End Region

	Private Function getCommandBytes() As [Byte]()
		Dim ascii As ASCII = ascii.getInstance()
		Dim text As String = ""
		For Each item As String In listBox_charBefore.Items
			text &= ascii.getASCIIChar(item)
		Next
		text &= textBox_message.Text
		For Each item As String In listBox_charAfter.Items
			text &= ascii.getASCIIChar(item)
		Next
		Return Encoding.ASCII.GetBytes(text)
	End Function

	Public Sub updateCurrentCommand()
		m_currentCommand.setCommand(getCommandBytes())
	End Sub

	Private Sub textBox_message_TextChanged(sender As Object, e As EventArgs) Handles textBox_message.TextChanged
		updatePreview()
	End Sub

End Class