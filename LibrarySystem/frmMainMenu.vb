Imports System.Data.OleDb
Imports System.Object
Public Class frmMainMenu

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBooksToolStripMenuItem.Click
        Dim frmAddBooks As New frmAddBooks
        frmAddBooks.ShowDialog()
    End Sub

    Private Sub AddBorrowersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBorrowersToolStripMenuItem.Click
        Dim frmaddstudent As New frmAddStudent
        frmAddStudent.ShowDialog()

    End Sub

    Private Sub BorrowBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowBooksToolStripMenuItem.Click
        Dim frmborrowsbook As New frmBorrowsBook
        frmBorrowsBook.ShowDialog()
    End Sub

    Private Sub EditBooksRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBooksRecordToolStripMenuItem.Click
        Dim frmedibooks As New frmEditBooks
        frmEditBooks.ShowDialog()
    End Sub

    Private Sub EditBorrowersRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBorrowersRecordToolStripMenuItem.Click
        Dim frmeditstudentsrecord As New frmEditStudentsRecord
        frmEditStudentsRecord.ShowDialog()
    End Sub

    Private Sub ViewBooksReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ViewBorrowersListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBorrowersListToolStripMenuItem.Click
        Dim frmlistoofstudents As New frmListofStudents
        frmListofStudents.ShowDialog()
    End Sub

    Private Sub ViewBooksListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBooksListToolStripMenuItem.Click
        Dim frmlistofbooks As New frmListofBooks
        frmListofBooks.ShowDialog()
    End Sub

    Private Sub CreateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAccountToolStripMenuItem.Click
        Dim frmcreateuseracount As New frmCreateUserAccount
        frmCreateUserAccount.ShowDialog()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInToolStripMenuItem.Click
        Dim frmchangepassword As New frmChangePassword
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ReturnedBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnedBooksToolStripMenuItem.Click
        Dim frmReturnedBook As New frmReturnedBook
        frmReturnedBook.ShowDialog()
    End Sub

    Private Sub ViewTransToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTransToolStripMenuItem.Click
        Dim frmlist As New frmListOfStudentsBorrowed
        frmReturnedBooks.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub ViewReturnedBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FRM As New frmListOfStudentsBorrowed
        frmListOfStudentsBorrowed.ShowDialog()
    End Sub
End Class