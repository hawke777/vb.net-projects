
Imports CefSharp.WinForms

Public Class Form1
    Dim url1 As String = "https://www.instacart.com/store/aldi/collections/produce"
    Dim url2 As String = "https://www.instacart.com/store/kroger/storefront"
    Dim url3 As String = "https://www.instacart.com/store/meijer/storefront"
    Dim url4 As String = "https://www.instacart.com/store/savealot/storefront"
    Dim url5 As String = "https://www.walmart.com/"
    Private WithEvents browser As ChromiumWebBrowser
    Private Sub InitializeChromium()
        Dim settings As New CefSettings()
        settings.CachePath = Environment.GetFolderPath(folder:=Environment.SpecialFolder.Cookies)
        CefSharp.Cef.Initialize(settings)
        browser = New ChromiumWebBrowser(url1)
        ChromiumWebBrowser1.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
    End Sub
    Public Sub New()
        InitializeComponent()
        InitializeChromium()
    End Sub

    Private Sub firststart()
        CheckBox1.CheckState = CheckState.Checked
        ChromiumWebBrowser1.Visible = True
        If browser IsNot Nothing Then
            browser.Load(url1)
        End If

    End Sub
    Private Sub checkbox1enable()
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox2.CheckState = CheckState.Unchecked
            CheckBox3.CheckState = CheckState.Unchecked
            CheckBox4.CheckState = CheckState.Unchecked
            CheckBox5.CheckState = CheckState.Unchecked
        End If
        If browser IsNot Nothing Then
            browser.Load(url1)
        End If
    End Sub
    Private Sub checkbox2enable()
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox1.CheckState = CheckState.Unchecked
            CheckBox3.CheckState = CheckState.Unchecked
            CheckBox4.CheckState = CheckState.Unchecked
            CheckBox5.CheckState = CheckState.Unchecked
        End If
        If browser IsNot Nothing Then
            browser.Load(url2)
        End If
    End Sub
    Private Sub checkbox3enable()
        If CheckBox3.CheckState = CheckState.Checked Then
            CheckBox1.CheckState = CheckState.Unchecked
            CheckBox2.CheckState = CheckState.Unchecked
            CheckBox4.CheckState = CheckState.Unchecked
            CheckBox5.CheckState = CheckState.Unchecked
        End If
        If browser IsNot Nothing Then
            browser.Load(url3)
        End If
    End Sub
    Private Sub checkbox4enable()
        If CheckBox4.CheckState = CheckState.Checked Then
            CheckBox1.CheckState = CheckState.Unchecked
            CheckBox2.CheckState = CheckState.Unchecked
            CheckBox3.CheckState = CheckState.Unchecked
            CheckBox5.CheckState = CheckState.Unchecked
        End If
        If browser IsNot Nothing Then
            browser.Load(url5)
        End If
    End Sub
    Private Sub checkbox5enable()
        If CheckBox5.CheckState = CheckState.Checked Then
            CheckBox1.CheckState = CheckState.Unchecked
            CheckBox2.CheckState = CheckState.Unchecked
            CheckBox3.CheckState = CheckState.Unchecked
            CheckBox4.CheckState = CheckState.Unchecked
        End If
        If browser IsNot Nothing Then
            browser.Load(url4)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firststart()
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        checkbox5enable()
    End Sub
    Private Sub CheckBox4_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        checkbox4enable()
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        checkbox3enable()
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        checkbox2enable()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        checkbox1enable()
    End Sub
    Private Sub ReciepeIdealsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReciepeIdealsToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub SideBySideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SideBySideToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub SingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SingleToolStripMenuItem.Click
        Form2.Hide()
    End Sub

    Private Sub MealPlannerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MealPlannerToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub MealPlannerCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MealPlannerCloseToolStripMenuItem.Click
        Form3.Close()
    End Sub

End Class
