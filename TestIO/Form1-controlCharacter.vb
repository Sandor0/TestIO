Partial Public Class Form1

	Private Sub listView_controlsChar_DoubleClick(sender As Object, e As EventArgs) Handles listView_controlsChar.DoubleClick
		If listView_controlsChar.SelectedItems.Count > 0 Then
			Dim toAdd As String
			If listView_controlsChar.SelectedItems(0).SubItems(1).Text.Trim = "" Then
				toAdd = listView_controlsChar.SelectedItems(0).SubItems(0).Text
			Else
				toAdd = listView_controlsChar.SelectedItems(0).SubItems(1).Text
			End If
			If radioButton_after.Checked Then
				listBox_charAfter.Items.Add(toAdd)
			Else
				listBox_charBefore.Items.Add(toAdd)
			End If
		End If
		updatePreview()
	End Sub

	Private Sub button_upChar_Click(sender As Object, e As EventArgs) Handles button_upChar.Click
		Dim listbox As ListBox
		If radioButton_after.Checked Then
			listbox = listBox_charAfter
		ElseIf radioButton_before.Checked Then
			listbox = listBox_charBefore
		Else
			Return
		End If

		If listbox.SelectedIndex > 0 Then
			Dim I = listbox.SelectedIndex - 1
			listbox.Items.Insert(I, listbox.SelectedItem)
			listbox.Items.RemoveAt(listbox.SelectedIndex)
			listbox.SelectedIndex = I
		End If
		updatePreview()
	End Sub

	Private Sub button_downChar_Click(sender As Object, e As EventArgs) Handles button_downChar.Click
		Dim listbox As ListBox
		If radioButton_after.Checked Then
			listbox = listBox_charAfter
		ElseIf radioButton_before.Checked Then
			listbox = listBox_charBefore
		Else
			Return
		End If

		If listbox.SelectedIndex < listbox.Items.Count - 1 Then
			Dim I = listbox.SelectedIndex + 2
			listbox.Items.Insert(I, listbox.SelectedItem)
			listbox.Items.RemoveAt(listbox.SelectedIndex)
			listbox.SelectedIndex = I - 1
		End If
		updatePreview()
	End Sub

	Private Sub listBox_charBefore_Click(sender As Object, e As EventArgs) Handles listBox_charBefore.Click
		If listBox_charBefore.SelectedIndex <> -1 Then
			listBox_charAfter.SelectedIndex = -1
		End If
		radioButton_before.Checked = True
	End Sub

	Private Sub listBox_charAfter_Click(sender As Object, e As EventArgs) Handles listBox_charAfter.Click
		If listBox_charBefore.SelectedIndex <> -1 Then
			listBox_charAfter.SelectedIndex = -1
		End If
		radioButton_after.Checked = True
	End Sub

	Private Sub listBox_charBefore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_charBefore.SelectedIndexChanged
		If listBox_charBefore.SelectedIndex <> -1 Then
			listBox_charAfter.SelectedIndex = -1
			radioButton_before.Checked = True
		End If
	End Sub

	Private Sub listBox_charAfter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_charAfter.SelectedIndexChanged
		If listBox_charAfter.SelectedIndex <> -1 Then
			listBox_charBefore.SelectedIndex = -1
			radioButton_after.Checked = True
		End If
	End Sub

	Private Sub button_addChar_Click(sender As Object, e As EventArgs) Handles button_addChar.Click
		If listView_controlsChar.SelectedItems.Count > 0 Then
			Dim toAdd As String
			If listView_controlsChar.SelectedItems(0).SubItems(1).Text.Trim = "" Then
				toAdd = listView_controlsChar.SelectedItems(0).SubItems(0).Text
			Else
				toAdd = listView_controlsChar.SelectedItems(0).SubItems(1).Text
			End If
			If radioButton_after.Checked Then
				listBox_charAfter.Items.Add(toAdd)
			Else
				listBox_charBefore.Items.Add(toAdd)
			End If
		End If
		updatePreview()
	End Sub

	Private Sub button_deleteChar_Click(sender As Object, e As EventArgs) Handles button_deleteChar.Click
		If listBox_charAfter.SelectedIndex = -1 And listBox_charBefore.SelectedIndex = -1 Then
			Return
		End If
		If radioButton_after.Checked Then
			Dim index As Integer = listBox_charAfter.SelectedIndex - 1
			If index < 0 Then
				index = 0
			End If
			listBox_charAfter.Items.RemoveAt(listBox_charAfter.SelectedIndex)
			If index < listBox_charAfter.Items.Count Then
				listBox_charAfter.SelectedIndex = index
			End If
		Else
			Dim index As Integer = listBox_charBefore.SelectedIndex - 1
			If index < 0 Then
				index = 0
			End If
			listBox_charBefore.Items.RemoveAt(listBox_charBefore.SelectedIndex)
			If index < listBox_charBefore.Items.Count Then
				listBox_charBefore.SelectedIndex = index
			End If
		End If
		updatePreview()
	End Sub

End Class
