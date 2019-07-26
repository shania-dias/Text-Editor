Option Strict On
Imports System.IO

'Author: Shania Dias
'Date: July 23, 2019
'Program: Text editor
Public Class Form1

#Region "Declaration"
    Const New_File As String = "File1"          ' holds default file name
    Dim filePath As String = New_File           ' holds the file path
    Dim fileContent As String = String.Empty    ' holds the file content
    Dim clickedCancel As Boolean = False        ' variable to identify is user used the cancel button
#End Region

#Region "Handlers"

    ' Open new window

    Private Sub MenuOpen_Click(sender As Object, e As EventArgs) Handles menuOpen.Click
        ContentChanged()
        If Not clickedCancel Then
            Me.Text = " "
            OpenFileDialog1.Filter = "txt file (*.txt)|*.txt"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    filePath = OpenFileDialog1.FileName
                    Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                    Dim readStream As New StreamReader(fileStream)

                    TextBox1.Text = readStream.ReadToEnd()
                    fileContent = TextBox1.Text
                    RenewTitle()
                    OpenFileDialog1.FileName = String.Empty
                    readStream.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Else
                RenewTitle()
            End If
        End If
    End Sub

    Private Sub MenuSave_Click(sender As Object, e As EventArgs) Handles menuSave.Click
        Me.Text = " "
        If filePath = New_File Then
            SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Try
                    filePath = SaveFileDialog1.FileName
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Else
                RenewTitle()
                Exit Sub
            End If
        End If
        SaveFile(filePath)
        RenewTitle()
    End Sub

    Private Sub frmForm1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MenuSaveAs_Click(sender As Object, e As EventArgs) Handles menuSaveAs.Click
        Me.Text = "Save As"
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                filePath = SaveFileDialog1.FileName
                SaveFile(filePath)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
        RenewTitle()
    End Sub

    Private Sub MenuNew_Click(sender As Object, e As EventArgs)

        ContentChanged()
        If Not clickedCancel Then
            TextBox1.Text = String.Empty
            fileContent = TextBox1.Text
            filePath = New_File
            RenewTitle()
        End If
    End Sub

    Private Sub MenuCopy_Click(sender As Object, e As EventArgs) Handles menuCopy.Click
        My.Computer.Clipboard.SetText(TextBox1.SelectedText)
    End Sub

    Private Sub MenuCut_Click(sender As Object, e As EventArgs) Handles menuCut.Click
        My.Computer.Clipboard.SetText(TextBox1.SelectedText)
        TextBox1.SelectedText() = String.Empty
    End Sub

    Private Sub MenuPaste_Click(sender As Object, e As EventArgs) Handles menuPaste.Click
        TextBox1.SelectedText() = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("NETD2202" & vbCrLf & vbCrLf & "Lab 5" & vbCrLf & vbCrLf & "Shania Dias" & vbCrLf & vbCrLf & "This is a text editor", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub TextBox1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        RenewTitle()
    End Sub
#End Region

#Region "Sub"
    Private Sub RenewTitle()
        Me.Text = Path.GetFileName(filePath) & " - Text Editor"
    End Sub

    Private Sub SaveFile(path As String)
        Dim fileStream As New FileStream(path, FileMode.Create, FileAccess.Write)
        Dim writeStream As New StreamWriter(fileStream)

        writeStream.Write(TextBox1.Text)
        writeStream.Close()

        SaveFileDialog1.FileName = String.Empty
        fileContent = TextBox1.Text
    End Sub

    Private Sub ContentChanged()
        clickedCancel = False
        If TextBox1.Text <> fileContent Then
            Dim msgBoxResult = MsgBox("Would you kindly save changes to" & filePath.ToString() & "?", MsgBoxStyle.YesNoCancel, "Text Editor")
            If msgBoxResult = DialogResult.Yes Then
                menuSave.PerformClick()
            ElseIf msgBoxResult = DialogResult.Cancel Then
                clickedCancel = True
            End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.S) Then
            Me.Text = " "
            If filePath = New_File Then
                SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    Try
                        filePath = SaveFileDialog1.FileName
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString())
                    End Try
                Else
                    RenewTitle()
                    Exit Sub
                End If
            End If
        End If

        If (e.Control AndAlso e.KeyCode = Keys.N) Then
            ContentChanged()
            If Not clickedCancel Then
                TextBox1.Text = String.Empty
                fileContent = TextBox1.Text
                filePath = New_File
                RenewTitle()
            End If
        End If

        If (e.Control AndAlso e.KeyCode = Keys.O) Then
            ContentChanged()
            If Not clickedCancel Then
                Me.Text = "Open File"
                OpenFileDialog1.Filter = "txt file (*.txt)|*.txt"

                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    Try
                        filePath = OpenFileDialog1.FileName
                        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                        Dim readStream As New StreamReader(fileStream)

                        TextBox1.Text = readStream.ReadToEnd()
                        fileContent = TextBox1.Text
                        RenewTitle()
                        OpenFileDialog1.FileName = String.Empty
                        readStream.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString())
                    End Try
                Else
                    RenewTitle()
                End If
            End If
        End If

        If (e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.S) Then
            Me.Text = " "
            SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    filePath = SaveFileDialog1.FileName
                    SaveFile(filePath)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
            RenewTitle()
        End If

        If (e.Control AndAlso e.KeyCode = Keys.C) Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)
        End If

        If (e.Control AndAlso e.KeyCode = Keys.X) Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)
            TextBox1.SelectedText() = String.Empty
        End If

        If (e.Control AndAlso e.KeyCode = Keys.V) Then
            TextBox1.SelectedText() = My.Computer.Clipboard.GetText()
        End If
    End Sub

#End Region
End Class
