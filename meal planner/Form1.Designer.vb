<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciepeIdealsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SideBySideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsForDinnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MealPlannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MealPlannerCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChromiumWebBrowser1 = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 168)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grocery Ordering"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(6, 108)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox4.TabIndex = 8
        Me.CheckBox4.Text = "Walmart"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(6, 85)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "Save a Lot"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 65)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "Mejier"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Kroger"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(43, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Aldi"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.WhatsForDinnerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(665, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReciepeIdealsToolStripMenuItem})
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'ReciepeIdealsToolStripMenuItem
        '
        Me.ReciepeIdealsToolStripMenuItem.Name = "ReciepeIdealsToolStripMenuItem"
        Me.ReciepeIdealsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ReciepeIdealsToolStripMenuItem.Text = "Recipe Ideals"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleToolStripMenuItem, Me.SideBySideToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'SingleToolStripMenuItem
        '
        Me.SingleToolStripMenuItem.Name = "SingleToolStripMenuItem"
        Me.SingleToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SingleToolStripMenuItem.Text = "Single"
        '
        'SideBySideToolStripMenuItem
        '
        Me.SideBySideToolStripMenuItem.Name = "SideBySideToolStripMenuItem"
        Me.SideBySideToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SideBySideToolStripMenuItem.Text = "Side By Side"
        '
        'WhatsForDinnerToolStripMenuItem
        '
        Me.WhatsForDinnerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MealPlannerToolStripMenuItem, Me.MealPlannerCloseToolStripMenuItem})
        Me.WhatsForDinnerToolStripMenuItem.Name = "WhatsForDinnerToolStripMenuItem"
        Me.WhatsForDinnerToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.WhatsForDinnerToolStripMenuItem.Text = "Whats For Dinner"
        '
        'MealPlannerToolStripMenuItem
        '
        Me.MealPlannerToolStripMenuItem.Name = "MealPlannerToolStripMenuItem"
        Me.MealPlannerToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MealPlannerToolStripMenuItem.Text = "Meal Planner Open"
        '
        'MealPlannerCloseToolStripMenuItem
        '
        Me.MealPlannerCloseToolStripMenuItem.Name = "MealPlannerCloseToolStripMenuItem"
        Me.MealPlannerCloseToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MealPlannerCloseToolStripMenuItem.Text = "Meal Planner Close"
        '
        'ChromiumWebBrowser1
        '
        Me.ChromiumWebBrowser1.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser1.Location = New System.Drawing.Point(169, 27)
        Me.ChromiumWebBrowser1.Name = "ChromiumWebBrowser1"
        Me.ChromiumWebBrowser1.Size = New System.Drawing.Size(469, 600)
        Me.ChromiumWebBrowser1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 655)
        Me.Controls.Add(Me.ChromiumWebBrowser1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Grocery Online"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReciepeIdealsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SingleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SideBySideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhatsForDinnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MealPlannerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MealPlannerCloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChromiumWebBrowser1 As CefSharp.WinForms.ChromiumWebBrowser
End Class
