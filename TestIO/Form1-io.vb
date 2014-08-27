Imports System.Net.Sockets
Imports System.Text
Imports System.IO.Ports

Partial Public Class Form1

	Private Const CONNECTION_STATE_DISCONNECTED = 0
	Private Const CONNECTION_STATE_INTERNET = 1
	Private Const CONNECTION_STATE_SERIAL = 2


	Private connectionState As Integer

	Private tcpSocket As New TcpClient
	Private tcpStream As NetworkStream

	Private serialPort As SerialPort = Nothing
	Private m_connected As Boolean = False

	Public Sub conf()
		With serialPort

			Dim newLine As String = ""
			For Each c As Char In .NewLine
				newLine &= Asc(c)
			Next

			Console.WriteLine(".BaseStream.ToString = " & .BaseStream.ToString)
			Console.WriteLine(".BaseStream.CanRead = " & .BaseStream.CanRead)
			Console.WriteLine(".BaseStream.CanSeek = " & .BaseStream.CanSeek)
			Console.WriteLine(".BaseStream.CanWrite = " & .BaseStream.CanWrite)
			Console.WriteLine(".BaudRate = " & .BaudRate)
			Console.WriteLine(".BreakState = " & .BreakState)
			Console.WriteLine(".BytesToRead = " & .BytesToRead)
			Console.WriteLine(".BytesToWrite = " & .BytesToWrite)
			Console.WriteLine(".CDHolding = " & .CDHolding)
			Console.WriteLine(".CtsHolding = " & .CtsHolding)
			Console.WriteLine(".DataBits = " & .DataBits)
			Console.WriteLine(".DiscardNull = " & .DiscardNull)
			Console.WriteLine(".DsrHolding = " & .DsrHolding)
			Console.WriteLine(".DtrEnable = " & .DtrEnable)
			Console.WriteLine(".Encoding.ToString = " & .Encoding.ToString)
			Console.WriteLine(".Handshake = " & .Handshake)
			Console.WriteLine(".IsOpen = " & .IsOpen)
			Console.WriteLine(".NewLine = " & newLine)
			Console.WriteLine(".Parity = " & .Parity)
			Console.WriteLine(".ParityReplace = " & .ParityReplace)
			Console.WriteLine(".PortName = " & .PortName)
			Console.WriteLine(".ReadBufferSize = " & .ReadBufferSize)
			Console.WriteLine(".ReadTimeout = " & .ReadTimeout)
			Console.WriteLine(".ReceivedBytesThreshold = " & .ReceivedBytesThreshold)
			Console.WriteLine(".RtsEnable = " & .RtsEnable)
			Console.WriteLine(".StopBits = " & .StopBits)
			Console.WriteLine(".WriteBufferSize = " & .WriteBufferSize)
			Console.WriteLine(".WriteTimeout = " & .WriteTimeout)
		End With
	End Sub
#Region "Serial"
	Private Sub closeSerial()
		addToHistory("Closing serial connection...", TYPE_CONNECTION)
		serialPort.Dispose()
		serialPort.Close()
		setConnectionState(CONNECTION_STATE_DISCONNECTED)
		addToHistory("Serial closed.", TYPE_CONNECTION)
	End Sub

	Private Sub button_serialConnect_Click(sender As Object, e As EventArgs) Handles button_serialConnect.Click
		If Not serialPort Is Nothing Then
			closeSerial()
		End If
		addToHistory("Connecting to serial port " & getValue(comboBox_serialPortName).ToString, TYPE_CONNECTION)
		serialPort = New SerialPort()
		AddHandler serialPort.DataReceived, AddressOf serialReceivedHandler
		AddHandler serialPort.ErrorReceived, AddressOf serialErrorHandler
		serialPort.PortName = getValue(comboBox_serialPortName).ToString
		serialPort.NewLine = Chr(13)
		serialPort.ReceivedBytesThreshold = 8
		serialPort.ReadTimeout = 1000
		serialPort.BaudRate = CInt(comboBox_serialBauds.SelectedItem.ToString)
		serialPort.Open()

		conf()

		setConnectionState(CONNECTION_STATE_SERIAL)
		addToHistory("Connected !", TYPE_CONNECTION)
	End Sub

	Private Sub button_serialDisconnect_Click(sender As Object, e As EventArgs) Handles button_serialDisconnect.Click
		closeSerial()
	End Sub

	Private Sub serialErrorHandler(sender As Object, e As SerialErrorReceivedEventArgs)
		Dim err As String = ""
		Select Case e.EventType
			Case SerialError.Frame
				err = "Frame : The hardware detected a framing error."
				Exit Select
			Case SerialError.Overrun
				err = "Overrun : A character-buffer overrun has occurred. The next character is lost."
				Exit Select
			Case SerialError.RXOver
				err = "RXOver : An input buffer overflow has occurred. There is either no room in the input buffer, or a character was received after the end-of-file (EOF) character."
				Exit Select
			Case SerialError.RXParity
				err = "RXParity : The hardware detected a parity error."
				Exit Select
			Case SerialError.TXFull
				err = "TXFull : The application tried to transmit a character, but the output buffer was full."
				Exit Select
		End Select
		addToHistory(err, TYPE_CONNECTION)
		'closeSerial()
	End Sub

	Private Delegate Sub serialReceiveHandlerDelegate(sender As Object, e As SerialDataReceivedEventArgs)

	Private Sub serialReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
		If Me.InvokeRequired Then
			Me.Invoke(New serialReceiveHandlerDelegate(AddressOf serialReceivedHandler), sender, e)
		Else
			Try
				Dim data As String = serialPort.ReadLine()
				Console.WriteLine("data: " & data)
				addToHistory(data, TYPE_RECEIVE)
			Catch ex As Exception
				If serialPort.IsOpen Then
					serialPort.DiscardInBuffer()
					Console.WriteLine("a")
				End If
			End Try
		End If
	End Sub
#End Region

#Region "Internet"

	Private Sub closeInternet()
		addToHistory("Closing internet connection...", TYPE_CONNECTION)
		tcpStream.Close()
		tcpSocket.Close()
		addToHistory("Internet connection closed.", TYPE_CONNECTION)
		setConnectionState(CONNECTION_STATE_DISCONNECTED)
	End Sub

	Private Sub button_IPConnect_Click(sender As Object, e As EventArgs) Handles button_IPConnect.Click
		If m_connected Then
			closeInternet()
			tcpSocket = New TcpClient
		End If

		addToHistory("Connecting to : " & getValue(comboBox_IP) & ":" & textBox_port.Text, TYPE_CONNECTION)
		Try
			tcpSocket.Connect(getValue(comboBox_IP), CInt(textBox_port.Text))
			tcpStream = tcpSocket.GetStream()
			setConnectionState(CONNECTION_STATE_INTERNET)
			addToHistory("Connected !", TYPE_CONNECTION)
			m_connected = True

			tcpStream.WriteTimeout = 2500
			tcpStream.ReadTimeout = 1000
		Catch ex As SocketException
			addToHistory("Connection failed. (" & ex.ToString & ")", TYPE_CONNECTION)
		Catch ex As NullReferenceException
			Console.WriteLine(ex)
		End Try
	End Sub

	Private Sub button_IPDisconnect_Click(sender As Object, e As EventArgs) Handles button_IPDisconnect.Click
		closeInternet()
	End Sub

	Private Sub receiveInternet()
		Try
			Dim bufferSize As Integer = 10
			Dim bytes(bufferSize) As Byte
			Dim s_bytes As String = ""
			Dim numberOfBytesRead As Integer = 0
			Dim totalBytesRead As Integer = 0

			Dim Stopwatch As System.Diagnostics.Stopwatch
			Stopwatch = New Stopwatch

			Stopwatch.Start()
			While tcpStream.DataAvailable
				numberOfBytesRead = tcpStream.Read(bytes, 0, bufferSize)
				totalBytesRead += numberOfBytesRead
				s_bytes &= Encoding.ASCII.GetString(bytes, 0, numberOfBytesRead)
			End While
			Stopwatch.Stop()

			Dim hexValue As String = ""
			Dim stringValue As String = ""
			For Each c As Char In s_bytes
				Dim tmp As String = Convert.ToString(Convert.ToInt32(c), 16)
				hexValue &= "0x"
				If tmp.Length = 1 Then hexValue &= "0"
				hexValue &= tmp & " "
			Next
			addToHistory("Received (" & totalBytesRead & " bytes expected | " & s_bytes.Length & " bytes read in " & Stopwatch.Elapsed().TotalMilliseconds & "ms) : " & _
						 vbCrLf & "ASCII : " & _
						 vbCrLf & formattedASCII(s_bytes.Trim) & _
						 vbCrLf & "HexDump : " & _
						 vbCrLf & hexValue & _
						 vbCrLf,
						 TYPE_RECEIVE)
		Catch ex As Exception
			Console.WriteLine(Now & " " & ex.ToString)
		End Try
	End Sub
#End Region

	Private Function formattedASCII(ByVal ascii As String) As String
		Dim ret As String = ""
		For Each c As Char In ascii
			If Asc(c) > 31 And Asc(c) < 127 Then
				ret &= c
			Else
				ret &= "."
			End If
		Next
		Return ret
	End Function

	Private Sub setConnectionState(state As Integer)
		Select Case state
			Case CONNECTION_STATE_DISCONNECTED
				groupBox_ip.Enabled = True
				groupBox_serial.Enabled = True

				textBox_message.Enabled = False
				button_send.Enabled = False
				tabControl_commands.Enabled = False
				Exit Select
			Case CONNECTION_STATE_INTERNET
				groupBox_ip.Enabled = True
				groupBox_serial.Enabled = False

				textBox_message.Enabled = True
				button_send.Enabled = True
				tabControl_commands.Enabled = True
				Exit Select
			Case CONNECTION_STATE_SERIAL
				groupBox_ip.Enabled = False
				groupBox_serial.Enabled = True

				textBox_message.Enabled = True
				button_send.Enabled = True
				tabControl_commands.Enabled = True
				Exit Select
		End Select
		connectionState = state
	End Sub

	Private Function searchAscii(tag As String) As Char
		Return ASCII.getInstance().getASCIIChar(tag)
	End Function

	Private Function getCommandToSend() As String
		Dim command As String = ""
		For Each item As String In listBox_charBefore.Items
			command &= searchAscii(item)
		Next
		command &= textBox_message.Text
		For Each item As String In listBox_charAfter.Items
			command &= searchAscii(item)
		Next
		Console.WriteLine(command)
		Return command
	End Function

	Public Sub send(ByVal command As Command)
		If connectionState = CONNECTION_STATE_DISCONNECTED Then Return
		If connectionState = CONNECTION_STATE_SERIAL Then command.send(serialPort)
		If connectionState = CONNECTION_STATE_INTERNET Then
			command.send(tcpStream)
			receiveInternet()
		End If
	End Sub

	Private Sub button_send_Click(sender As Object, e As EventArgs) Handles button_send.Click
		send(m_currentCommand)
	End Sub

End Class