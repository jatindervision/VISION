Public Class Typing
    Dim cw As Integer ' Forms current Width.
    Dim ch As Integer ' Forms current Height.
    Dim iw As Integer = 1015 ' Forms initial width.
    Dim ih As Integer = 633 ' Forms initial height.
    ' Retrieve the working rectangle from the Screen class using the        PrimaryScreen and the WorkingArea properties.  
    Dim workingRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Typing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(workingRectangle.Width - 5, workingRectangle.Height - 130)
        ' Set the location so the entire form is visible. 
        Me.Location = New System.Drawing.Point(3, 5)
        ForTyping()
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub
    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' Change controls size and fonts to fit screen working area..
        Dim rw As Double = (Me.Width - cw) / cw ' Ratio change of original form width.
        Dim rh As Double = (Me.Height - ch) / ch ' Ratio change of original form height.
        ' Change controls size to fit users screen working area.
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * rw)
            Ctrl.Height += CInt(Ctrl.Height * rh)
            Ctrl.Left += CInt(Ctrl.Left * rw)
            Ctrl.Top += CInt(Ctrl.Top * rh)
        Next
        cw = Me.Width
        ch = Me.Height
        ' Change all the forms controls font size.
        Dim nfsize As Single
        If cw > iw + 500 Then
            For Each Ctrl As Control In Controls
                ' Get the forms controls font size's property and increase it. Reset the font to the new size. 
                nfsize = Me.Font.Size + 3
                Ctrl.Font = New Font(Ctrl.Font.Name, nfsize, FontStyle.Bold, Ctrl.Font.Unit)
            Next
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        rtfDocument.Clear()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        rtfDocument.Clear()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        rtfDocument.Undo()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        rtfDocument.Undo()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        rtfDocument.Redo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        rtfDocument.Redo()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        rtfDocument.Cut()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        rtfDocument.Cut()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        rtfDocument.Copy()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        rtfDocument.Copy()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        rtfDocument.Paste()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        rtfDocument.Paste()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        rtfDocument.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        rtfDocument.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        rtfDocument.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblbold_Click(sender As Object, e As EventArgs) Handles lblbold.Click
        rtfDocument.SelectionFont = New Font(rtfDocument.Font, FontStyle.Bold)
    End Sub

    Private Sub lblitalic_Click(sender As Object, e As EventArgs) Handles lblitalic.Click
        rtfDocument.SelectionFont = New Font(rtfDocument.Font, FontStyle.Italic)
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        rtfDocument.SelectionFont = New Font(rtfDocument.Font, FontStyle.Underline)
    End Sub

    Private Sub lblstrike_Click(sender As Object, e As EventArgs) Handles lblstrike.Click
        rtfDocument.SelectionFont = New Font(rtfDocument.Font, FontStyle.Strikeout)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"
        If (OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            rtfDocument.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            End
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
      
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"
        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, rtfDocument.Text, True)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ToolStripButton3.PerformClick()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(rtfDocument.Text, New Font("Arial", 16, FontStyle.Regular), Brushes.Black, 120, 120)
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles lblback.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            'lblback.ForeColor = ColorDialog1.Color
            rtfDocument.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles lblfont.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            ' lblfont.ForeColor = ColorDialog1.Color
            rtfDocument.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FontColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColour.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            lblfont.ForeColor = ColorDialog1.Color
            rtfDocument.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub BackColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackColourToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            lblback.ForeColor = ColorDialog1.Color
            rtfDocument.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FontSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontSizeToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            rtfDocument.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        rtfDocument.Refresh()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        rtfDocument.SelectAll()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ToolStripButton6.PerformClick()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub rtfDocument_TextChanged(sender As Object, e As EventArgs) Handles rtfDocument.TextChanged

    End Sub
End Class
