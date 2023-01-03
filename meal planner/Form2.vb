Imports CefSharp.WinForms
Public Class Form2
    Dim url6 As String = "https://www.delish.com/cooking/menus/g1478/quick-dinner-ideas/"
    Dim url7 As String = "https://www.thelazydish.com/quick-easy-dinner-recipes-for-family-with-kids/"
    Dim url8 As String = "https://www.jaroflemons.com/50-quick-healthy-dinners-30-minutes-or-less/"
    Dim url9 As String = "https://www.thedinnerbite.com/31-quick-easy-family-dinner-recipes/"
    Dim url10 As String = "https://iresults.com/diabetes?rgid=437072&sub=gclid&gclid=CjwKCAiA76-dBhByEiwAA0_s9f-1gVfEARKB3ZNPGSqb1Wu4QUrCN6NO-zYx0gmyZnOpXbRZBbFNKxoCyv4QAvD_BwE"
    Dim url11 As String = "https://www.eatingwell.com/gallery/7918302/diabetes-friendly-dinner-recipes-to-make-forever/"
    Private WithEvents browser2 As ChromiumWebBrowser
    Private Sub InitializeChromium()
        Dim settings As New CefSettings()
        settings.CachePath = Environment.GetFolderPath(folder:=Environment.SpecialFolder.Cookies)
        browser2 = New ChromiumWebBrowser(url6)
        ChromiumWebBrowser1.Controls.Add(browser2)
        browser2.Dock = DockStyle.Fill
    End Sub
    Public Sub New()
        InitializeComponent()
        InitializeChromium()
    End Sub

    Private Sub firststart()
        CheckBox6.CheckState = CheckState.Checked
        ChromiumWebBrowser1.Visible = True
        If browser2 IsNot Nothing Then
            browser2.Load(url6)
        End If
    End Sub

    Private Sub checkbox6enable()
        If CheckBox6.CheckState = CheckState.Checked Then
            CheckBox7.CheckState = CheckState.Unchecked
            CheckBox8.CheckState = CheckState.Unchecked
            CheckBox9.CheckState = CheckState.Unchecked
            CheckBox10.CheckState = CheckState.Unchecked
            CheckBox11.CheckState = CheckState.Unchecked
        End If
        If browser2 IsNot Nothing Then
            browser2.Load(url6)
        End If
    End Sub
    Private Sub checkbox7enable()
        If CheckBox7.CheckState = CheckState.Checked Then
            CheckBox6.CheckState = CheckState.Unchecked
            CheckBox8.CheckState = CheckState.Unchecked
            CheckBox9.CheckState = CheckState.Unchecked
            CheckBox10.CheckState = CheckState.Unchecked
            CheckBox11.CheckState = CheckState.Unchecked
        End If
        If browser2 IsNot Nothing Then
            browser2.Load(url7)
        End If
    End Sub
    Private Sub checkbox8enable()
        If CheckBox8.CheckState = CheckState.Checked Then
            CheckBox6.CheckState = CheckState.Unchecked
            CheckBox7.CheckState = CheckState.Unchecked
            CheckBox9.CheckState = CheckState.Unchecked
            CheckBox10.CheckState = CheckState.Unchecked
            CheckBox11.CheckState = CheckState.Unchecked
        End If
        If browser2 IsNot Nothing Then
            browser2.Load(url8)
        End If
    End Sub
    Private Sub checkbox9enable()
        If CheckBox9.CheckState = CheckState.Checked Then
            CheckBox6.CheckState = CheckState.Unchecked
            CheckBox7.CheckState = CheckState.Unchecked
            CheckBox8.CheckState = CheckState.Unchecked
            CheckBox10.CheckState = CheckState.Unchecked
            CheckBox11.CheckState = CheckState.Unchecked
        End If
        If browser2 IsNot Nothing Then
            browser2.Load(url9)
        End If
    End Sub
    Private Sub checkbox10enable()
        If CheckBox10.CheckState = CheckState.Checked Then
            CheckBox6.CheckState = CheckState.Unchecked
            CheckBox7.CheckState = CheckState.Unchecked
            CheckBox8.CheckState = CheckState.Unchecked
            CheckBox9.CheckState = CheckState.Unchecked
            CheckBox11.CheckState = CheckState.Unchecked
        End If
        If browser2 IsNot Nothing Then
            browser2.Load(url10)
        End If
    End Sub
    Private Sub checkbox11enable()
        If CheckBox11.CheckState = CheckState.Checked Then
            CheckBox6.CheckState = CheckState.Unchecked
            CheckBox7.CheckState = CheckState.Unchecked
            CheckBox8.CheckState = CheckState.Unchecked
            CheckBox9.CheckState = CheckState.Unchecked
            CheckBox10.CheckState = CheckState.Unchecked
        End If
        If browser2 IsNot Nothing Then
            browser2.Load(url11)
        End If
    End Sub

    Private Sub GroceryOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroceryOrderToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        checkbox6enable()
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        checkbox7enable()
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        checkbox8enable()
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        checkbox9enable()
    End Sub
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        checkbox10enable()
    End Sub
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        checkbox11enable()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firststart()
    End Sub
    Private Sub SideBySideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SideBySideToolStripMenuItem.Click
        Form1.Show()
    End Sub
    Private Sub SingleViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SingleViewToolStripMenuItem.Click
        Form1.Hide()
    End Sub
    Private Sub MealPlannerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MealPlannerToolStripMenuItem.Click
        Form3.Show()
    End Sub
    Private Sub MealPlannerCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MealPlannerCloseToolStripMenuItem.Click
        Form3.Hide()
    End Sub
End Class