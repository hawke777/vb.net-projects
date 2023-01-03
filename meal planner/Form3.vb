Public Class Form3
    'TODO
    'create a achieve form that will allow you to go back and see what you have cooked already.
    Private Sub setdateindatetimepickers()
        DateTimePicker1.Value = Now.AddDays(1).ToShortDateString
    End Sub

    Private Sub savemealplan()
        If Button1.Enabled = True Then
            Dim FILE_NAME As String = "C:\Dinner Plan\" & DateTimePicker1.Value.ToString("ddd_MMM_dd_yyyy")
            Try
                If Not System.IO.Directory.Exists("C:\Dinner Plan") Then
                    System.IO.Directory.CreateDirectory("C:\Dinner Plan")
                    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
                    objWriter.Write(Button1.Text & vbNewLine & Label9.Text & vbNewLine & Label19.Text & vbNewLine & Label26.Text)
                    objWriter.Close()
                    MessageBox.Show(Button1.Text & "'s meal plan written to file")
                Else
                    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
                    objWriter.Write(Button1.Text & vbNewLine & Label9.Text & vbNewLine & Label19.Text & vbNewLine & Label26.Text)
                    objWriter.Close()
                    MessageBox.Show(Button1.Text & "'s meal plan written to file")
                End If
            Catch ex As Exception
                MessageBox.Show(Button1.Text & "'s meal plan not written to file")
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mealplannerclosed()
        Me.Hide()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label2.Text = DateTimePicker1.Value.ToString("ddd_MMM_dd_yyyy")
        Button1.Text = Label2.Text
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.ResetText()
        Label19.ResetText()
        Label26.ResetText()
        Label2.Text = DateTimePicker1.Value.ToString("ddd_MMM_dd_yyyy")
        Button1.Text = Label2.Text
        setdateindatetimepickers()

    End Sub

    Private Sub MealPlannerClosedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MealPlannerClosedToolStripMenuItem.Click
        mealplannerclosed()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label9.Text = TextBox1.Text
        Label19.Text = TextBox2.Text
        Label26.Text = TextBox3.Text
        savemealplan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DateTimePicker1.Value = Now.ToShortDateString
        Label9.ResetText()
        Label19.ResetText()
        Label26.ResetText()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Dinner Plan\" & DateTimePicker1.Value.ToString("ddd_MMM_dd_yyyy"))
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()
            MsgBox("You have this planned for " & stringReader)
        Catch
            MsgBox("There is Not a plan for " & DateTimePicker1.Value.ToString("ddd"))
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Dinner Plan\" & DateTimePicker1.Value.AddDays(1).ToString("ddd_MMM_dd_yyyy"))
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()
            MsgBox("You have this planned for " & stringReader)
        Catch
            MsgBox("There is Not a plan for " & DateTimePicker1.Value.AddDays(1).ToString("ddd_MMM_dd_yyyy"))
        End Try
    End Sub

    Private Sub DaysAgoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaysAgoToolStripMenuItem.Click
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Dinner Plan\" & DateTimePicker1.Value.AddDays(2).ToString("ddd_MMM_dd_yyyy"))
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()
            MsgBox("You have this planned for " & stringReader)
        Catch
            MsgBox("There is Not a plan for " & DateTimePicker1.Value.AddDays(2).ToString("ddd_MMM_dd_yyyy"))
        End Try
    End Sub

    Private Sub DaysAgoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaysAgoToolStripMenuItem1.Click
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Dinner Plan\" & DateTimePicker1.Value.AddDays(3).ToString("ddd_MMM_dd_yyyy"))
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()
            MsgBox("You have this planned for " & stringReader)
        Catch
            MsgBox("There is Not a plan for " & DateTimePicker1.Value.AddDays(3).ToString("ddd_MMM_dd_yyyy"))
        End Try
    End Sub

    Private Sub DaysAgoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DaysAgoToolStripMenuItem2.Click
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Dinner Plan\" & DateTimePicker1.Value.AddDays(4).ToString("ddd_MMM_dd_yyyy"))
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()
            MsgBox("You have this planned for " & stringReader)
        Catch
            MsgBox("There is Not a plan for " & DateTimePicker1.Value.AddDays(4).ToString("ddd_MMM_dd_yyyy"))
        End Try
    End Sub

    Private Sub DaysAgoToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DaysAgoToolStripMenuItem3.Click
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Dinner Plan\" & DateTimePicker1.Value.AddDays(5).ToString("ddd_MMM_dd_yyyy"))
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()
            MsgBox("You have this planned for " & stringReader)
        Catch
            MsgBox("There is Not a plan for " & DateTimePicker1.Value.AddDays(5).ToString("ddd_MMM_dd_yyyy"))
        End Try

    End Sub

    Private Sub DaysAgoToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DaysAgoToolStripMenuItem4.Click
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\Dinner Plan\" & DateTimePicker1.Value.AddDays(6).ToString("ddd_MMM_dd_yyyy"))
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()
            MsgBox("You have this planned for " & stringReader)
        Catch
            MsgBox("There is Not a plan for " & DateTimePicker1.Value.AddDays(6).ToString("ddd_MMM_dd_yyyy"))
        End Try
    End Sub


End Class