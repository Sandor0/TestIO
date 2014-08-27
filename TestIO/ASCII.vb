Public Class ASCII

	Dim ASCIIName As List(Of String)
	Dim ASCIITag As List(Of String)

	Private Shared m_instance As ASCII = Nothing
	Private Sub New()
		ASCIIName = New List(Of String)
		ASCIITag = New List(Of String)
		For Each character_data As String() In ASCIIControlChars
			ASCIIName.Add(character_data(0))
			ASCIITag.Add(character_data(1))
		Next
	End Sub

	Public Shared Function getInstance() As ASCII
		If m_instance Is Nothing Then
			m_instance = New ASCII
		End If
		Return m_instance
	End Function

	Public Function getASCIIName(i As Integer) As String
		If i >= 0 And i < ASCIIControlChars.Count Then
			Return ASCIIName(i)
		End If
		Return ""
	End Function

	Public Function getASCIIName(t As String) As String
		Return ASCIIName(ASCIITag.IndexOf(t))
	End Function

	Public Function getTag(ByVal i As Integer) As String
		Return ASCIITag(i)
	End Function

	Public Function getASCIIChar(t As String) As Char
		Return Chr(ASCIITag.IndexOf(t))
	End Function

	Public Function getASCIIArray() As String()()
		Return ASCIIControlChars
	End Function


#Region "ASCIIControlChars"
	Private ASCIIControlChars()() As String =
	{
		New String() {"Null", "<NUL>", "0"},
		New String() {"Start of Heading", "<SOH>", "1"},
		New String() {"Start of Text", "<STX>", "2"},
		New String() {"End of Text", "<ETX>", "3"},
		New String() {"End of Transmission", "<EOT>", "4"},
		New String() {"Enquiry", "<ENQ>", "5"},
		New String() {"Acknowledgment", "<ACK>", "6"},
		New String() {"Bell", "<BEL>", "7"},
		New String() {"Backspace", "<BS>", "8"},
		New String() {"Horizontal Tab", "<HT>", "9"},
		New String() {"Line Feed", "<LF>", "10"},
		New String() {"Vertical Tab", "<VT>", "11"},
		New String() {"Form Feed", "<FF>", "12"},
		New String() {"Carriage Return", "<CR>", "13"},
		New String() {"Shift Out", "<SO>", "14"},
		New String() {"Shift In", "<SI>", "15"},
		New String() {"Data Link Escape", "<DLE>", "16"},
		New String() {"Device Control 1", "<DC1>", "17"},
		New String() {"Device Control 2", "<DC2>", "18"},
		New String() {"Device Control 3", "<DC3>", "19"},
		New String() {"Device Control 4", "<DC4>", "20"},
		New String() {"Negative Acknowledge", "<NAK>", "21"},
		New String() {"Synchronous Idle", "<SYN>", "22"},
		New String() {"End of Transmit Block", "<ETB>", "23"},
		New String() {"Cancel", "<CAN>", "24"},
		New String() {"End of Medium", "<EM>", "25"},
		New String() {"Substitute", "<SUB>", "26"},
		New String() {"Escape", "<ESC>", "27"},
		New String() {"File Separator", "<FS>", "28"},
		New String() {"Group Separator", "<GS>", "29"},
		New String() {"Record Separator", "<RS>", "30"},
		New String() {"Unit Separator", "<US>", "31"},
		New String() {"Space", " ", "32"},
		New String() {"Exclamation mark", "!", "33"},
		New String() {"Double quotes", """", "34"},
		New String() {"Number", "#", "35"},
		New String() {"Dollar", "$", "36"},
		New String() {"Percentage", "%", "37"},
		New String() {"Ampersand", "&", "38"},
		New String() {"Single quote", "'", "39"},
		New String() {"Open parenthesis", "(", "40"},
		New String() {"Close parenthesis", ")", "41"},
		New String() {"Asterisk", "*", "42"},
		New String() {"Plus", "+", "43"},
		New String() {"Comma", ",", "44"},
		New String() {"Hyphen", "-", "45"},
		New String() {"Period", ".", "46"},
		New String() {"Slash", "/", "47"},
		New String() {"Zero", "0", "48"},
		New String() {"One", "1", "49"},
		New String() {"Two", "2", "50"},
		New String() {"Three", "3", "51"},
		New String() {"Four", "4", "52"},
		New String() {"Five", "5", "53"},
		New String() {"Six", "6", "54"},
		New String() {"Seven", "7", "55"},
		New String() {"Eight", "8", "56"},
		New String() {"Nine", "9", "57"},
		New String() {"Colon", ":", "58"},
		New String() {"Semicolon", ";", "59"},
		New String() {"Less than", "<", "60"},
		New String() {"Equals", "=", "61"},
		New String() {"Greater than", ">", "62"},
		New String() {"Question mark", "?", "63"},
		New String() {"Arobase", "@", "64"},
		New String() {"Uppercase A", "A", "65"},
		New String() {"Uppercase B", "B", "66"},
		New String() {"Uppercase C", "C", "67"},
		New String() {"Uppercase D", "D", "68"},
		New String() {"Uppercase E", "E", "69"},
		New String() {"Uppercase F", "F", "70"},
		New String() {"Uppercase G", "G", "71"},
		New String() {"Uppercase H", "H", "72"},
		New String() {"Uppercase I", "I", "73"},
		New String() {"Uppercase J", "J", "74"},
		New String() {"Uppercase K", "K", "75"},
		New String() {"Uppercase L", "L", "76"},
		New String() {"Uppercase M", "M", "77"},
		New String() {"Uppercase N", "N", "78"},
		New String() {"Uppercase O", "O", "79"},
		New String() {"Uppercase P", "P", "80"},
		New String() {"Uppercase Q", "Q", "81"},
		New String() {"Uppercase R", "R", "82"},
		New String() {"Uppercase S", "S", "83"},
		New String() {"Uppercase T", "T", "84"},
		New String() {"Uppercase U", "U", "85"},
		New String() {"Uppercase V", "V", "86"},
		New String() {"Uppercase W", "W", "87"},
		New String() {"Uppercase X", "X", "88"},
		New String() {"Uppercase Y", "Y", "89"},
		New String() {"Uppercase Z", "Z", "90"},
		New String() {"Opening bracket", "[", "91"},
		New String() {"Backslash", "\", "92"},
		New String() {"Closing bracket", "]", "93"},
		New String() {"Circumflex", "^", "94"},
		New String() {"Underscore", "_", "95"},
		New String() {"Grave accent", "`", "96"},
		New String() {"Lowercase a", "a", "97"},
		New String() {"Lowercase b", "b", "98"},
		New String() {"Lowercase c", "c", "99"},
		New String() {"Lowercase d", "d", "100"},
		New String() {"Lowercase e", "e", "101"},
		New String() {"Lowercase f", "f", "102"},
		New String() {"Lowercase g", "g", "103"},
		New String() {"Lowercase h", "h", "104"},
		New String() {"Lowercase i", "i", "105"},
		New String() {"Lowercase j", "j", "106"},
		New String() {"Lowercase k", "k", "107"},
		New String() {"Lowercase l", "l", "108"},
		New String() {"Lowercase m", "m", "109"},
		New String() {"Lowercase n", "n", "110"},
		New String() {"Lowercase o", "o", "111"},
		New String() {"Lowercase p", "p", "112"},
		New String() {"Lowercase q", "q", "113"},
		New String() {"Lowercase r", "r", "114"},
		New String() {"Lowercase s", "s", "115"},
		New String() {"Lowercase t", "t", "116"},
		New String() {"Lowercase u", "u", "117"},
		New String() {"Lowercase v", "v", "118"},
		New String() {"Lowercase w", "w", "119"},
		New String() {"Lowercase x", "x", "120"},
		New String() {"Lowercase y", "y", "121"},
		New String() {"Lowercase z", "z", "122"},
		New String() {"Opening brace", "{", "123"},
		New String() {"Vertical bar", "|", "124"},
		New String() {"Closing brace", "}", "125"},
		New String() {"Tilde", "~", "126"},
		New String() {"Delete", "<DEL>", "127"}
	}
#End Region

End Class
