Imports System.Data.OleDb
Imports System.Object
Public Class frmChooseStudents
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub frmChooseStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call StudentList()
    End Sub
    Private Sub loadsearchresult()
        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With OleDBC

            .Connection = conn
            .CommandText = "SELECT * FROM tblStudents WHERE StudentFName like '%" & TextBox1.Text & "%'"

        End With
        OleDBDR = OleDBC.ExecuteReader
        DataGridView1.Rows.Clear()
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, c).Value = OleDBDR.Item(0)
                DataGridView1.Item(1, c).Value = OleDBDR.Item(1)
                DataGridView1.Item(2, c).Value = OleDBDR.Item(2)
                DataGridView1.Item(3, c).Value = OleDBDR.Item(3)
                DataGridView1.Item(4, c).Value = OleDBDR.Item(4)
                DataGridView1.Item(5, c).Value = OleDBDR.Item(5)
                DataGridView1.Item(6, c).Value = OleDBDR.Item(6)


                c = c + 1
            End While
        End If
    End Sub


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        frmBorrowsBook.txtID.Text = DataGridView1.Item(0, e.RowIndex).Value
        frmBorrowsBook.txtStudName.Text = DataGridView1.Item(1, e.RowIndex).Value
        frmBorrowsBook.txtLname.Text = DataGridView1.Item(2, e.RowIndex).Value
        frmBorrowsBook.txtMid.Text = DataGridView1.Item(3, e.RowIndex).Value
        frmBorrowsBook.cmbGender.Text = DataGridView1.Item(4, e.RowIndex).Value
        frmBorrowsBook.txtCourse.Text = DataGridView1.Item(5, e.RowIndex).Value
        frmBorrowsBook.txtSection.Text = DataGridView1.Item(6, e.RowIndex).Value
        frmBorrowsBook.Button5.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmBorrowsBook.Show()
    End Sub

    Public Sub StudentList()

        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblStudents "
        End With
        OleDBDR = OleDBC.ExecuteReader
        DataGridView1.Rows.Clear()
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, c).Value = OleDBDR.Item(0)
                DataGridView1.Item(1, c).Value = OleDBDR.Item(1)
                DataGridView1.Item(2, c).Value = OleDBDR.Item(2)
                DataGridView1.Item(3, c).Value = OleDBDR.Item(3)
                DataGridView1.Item(4, c).Value = OleDBDR.Item(4)
                DataGridView1.Item(5, c).Value = OleDBDR.Item(5)
                DataGridView1.Item(6, c).Value = OleDBDR.Item(6)

                c = c + 1
            End While
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn.Close()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call loadsearchresult()
    End Sub
End Class