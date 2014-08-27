Imports System.IO.Ports
Imports System.Net.Sockets
Imports System.Text

Public Class Command

	Private m_commandName As String
	Private m_commandDisplay As String
	Private m_command As [Byte]()

	Public Sub New()

	End Sub

	Public Sub New(ByVal name As String, ByVal ASCII As String)
		m_commandName = name
		m_command = Encoding.UTF8.GetBytes(ASCII)
	End Sub

#Region "Get"
	Public Function getName() As String
		Return m_commandName
	End Function

	Public Function getDisplayCommand() As String
		Dim ret As String = ""
		Dim ascii As ASCII = ascii.getInstance()
		For Each c As Byte In m_command
			ret &= ascii.getTag(CInt(c))
		Next
		Return ret
	End Function
#End Region

#Region "Set"
	Public Sub setCommand(ByVal command As [Byte]())
		m_command = command
	End Sub
#End Region

#Region "Send"
	Public Sub send(ByVal serial As SerialPort)
		Dim chaine As String
		chaine = Encoding.ASCII.GetString(m_command)

		Dim tmpCKS As Integer
		For Each Chr As Char In chaine.Remove(chaine.Length - 1)
			tmpCKS += AscW(Chr)
		Next
		Dim checkSum As [Byte]() = {CByte(tmpCKS And 127)}

		Dim command As [Byte]() = Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(m_command) & Encoding.ASCII.GetString(checkSum))
		serial.Write(command, 0, command.Length)
		Form1.addToHistory("Send : " & getDisplayCommand(), Form1.TYPE_SEND)
	End Sub

	Public Sub send(ByVal tcpStream As NetworkStream)
		Form1.addToHistory("Sending : " & getDisplayCommand(), Form1.TYPE_SEND)
		Try
			tcpStream.Write(m_command, 0, m_command.Length)
			Form1.addToHistory("Sent !", Form1.TYPE_SEND)
		Catch ex As Exception
			Console.WriteLine(ex)
		End Try
	End Sub
#End Region

	Private Function CheckSum(ByVal chaine As String) As Boolean
		Dim tmpCKS As Integer
		Dim CKS As Integer = AscW(chaine.Chars(chaine.Length - 1))

		For Each Chr As Char In chaine.Remove(chaine.Length - 1)
			tmpCKS += AscW(Chr)
		Next
		Return CKS = (tmpCKS And 127)
	End Function

End Class
