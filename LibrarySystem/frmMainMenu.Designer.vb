<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddBorrowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrowBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditBooksRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditBorrowersRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewListsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewBorrowersListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewBooksListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewTransToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditRecordsToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ViewListsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1310, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBooksToolStripMenuItem, Me.AddBorrowersToolStripMenuItem, Me.BorrowBooksToolStripMenuItem, Me.ReturnedBooksToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(52, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddBooksToolStripMenuItem
        '
        Me.AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem"
        Me.AddBooksToolStripMenuItem.Size = New System.Drawing.Size(221, 28)
        Me.AddBooksToolStripMenuItem.Text = "Add Books"
        '
        'AddBorrowersToolStripMenuItem
        '
        Me.AddBorrowersToolStripMenuItem.Name = "AddBorrowersToolStripMenuItem"
        Me.AddBorrowersToolStripMenuItem.Size = New System.Drawing.Size(221, 28)
        Me.AddBorrowersToolStripMenuItem.Text = "Add Students"
        '
        'BorrowBooksToolStripMenuItem
        '
        Me.BorrowBooksToolStripMenuItem.Name = "BorrowBooksToolStripMenuItem"
        Me.BorrowBooksToolStripMenuItem.Size = New System.Drawing.Size(221, 28)
        Me.BorrowBooksToolStripMenuItem.Text = "Borrow Books"
        '
        'ReturnedBooksToolStripMenuItem
        '
        Me.ReturnedBooksToolStripMenuItem.Name = "ReturnedBooksToolStripMenuItem"
        Me.ReturnedBooksToolStripMenuItem.Size = New System.Drawing.Size(221, 28)
        Me.ReturnedBooksToolStripMenuItem.Text = "Returned Books"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 28)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditRecordsToolStripMenuItem
        '
        Me.EditRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditBooksRecordToolStripMenuItem, Me.EditBorrowersRecordToolStripMenuItem})
        Me.EditRecordsToolStripMenuItem.Name = "EditRecordsToolStripMenuItem"
        Me.EditRecordsToolStripMenuItem.Size = New System.Drawing.Size(137, 27)
        Me.EditRecordsToolStripMenuItem.Text = "Edit Records"
        '
        'EditBooksRecordToolStripMenuItem
        '
        Me.EditBooksRecordToolStripMenuItem.Name = "EditBooksRecordToolStripMenuItem"
        Me.EditBooksRecordToolStripMenuItem.Size = New System.Drawing.Size(283, 28)
        Me.EditBooksRecordToolStripMenuItem.Text = "Edit Books Record"
        '
        'EditBorrowersRecordToolStripMenuItem
        '
        Me.EditBorrowersRecordToolStripMenuItem.Name = "EditBorrowersRecordToolStripMenuItem"
        Me.EditBorrowersRecordToolStripMenuItem.Size = New System.Drawing.Size(283, 28)
        Me.EditBorrowersRecordToolStripMenuItem.Text = "Edit Borrowers Record"
        '
        'ViewListsToolStripMenuItem
        '
        Me.ViewListsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewBorrowersListToolStripMenuItem, Me.ViewBooksListToolStripMenuItem, Me.ViewTransToolStripMenuItem})
        Me.ViewListsToolStripMenuItem.Name = "ViewListsToolStripMenuItem"
        Me.ViewListsToolStripMenuItem.Size = New System.Drawing.Size(142, 27)
        Me.ViewListsToolStripMenuItem.Text = "View Records"
        '
        'ViewBorrowersListToolStripMenuItem
        '
        Me.ViewBorrowersListToolStripMenuItem.Name = "ViewBorrowersListToolStripMenuItem"
        Me.ViewBorrowersListToolStripMenuItem.Size = New System.Drawing.Size(305, 28)
        Me.ViewBorrowersListToolStripMenuItem.Text = "View Students Recrods"
        '
        'ViewBooksListToolStripMenuItem
        '
        Me.ViewBooksListToolStripMenuItem.Name = "ViewBooksListToolStripMenuItem"
        Me.ViewBooksListToolStripMenuItem.Size = New System.Drawing.Size(305, 28)
        Me.ViewBooksListToolStripMenuItem.Text = "View Books Record"
        '
        'ViewTransToolStripMenuItem
        '
        Me.ViewTransToolStripMenuItem.Name = "ViewTransToolStripMenuItem"
        Me.ViewTransToolStripMenuItem.Size = New System.Drawing.Size(305, 28)
        Me.ViewTransToolStripMenuItem.Text = "View Transaction Record"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateAccountToolStripMenuItem, Me.LogInToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(71, 27)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'CreateAccountToolStripMenuItem
        '
        Me.CreateAccountToolStripMenuItem.Name = "CreateAccountToolStripMenuItem"
        Me.CreateAccountToolStripMenuItem.Size = New System.Drawing.Size(233, 28)
        Me.CreateAccountToolStripMenuItem.Text = "Create Account"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(233, 28)
        Me.LogInToolStripMenuItem.Text = "Change Password"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(85, 27)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 628)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBorrowersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditBooksRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditBorrowersRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewListsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBorrowersListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBooksListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnedBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
