Imports System.Data.OleDb
Imports System.Object
Public Class frmListOfStudentsBorrowed
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub frmListofStudentsBorrowed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call Transac()
    End Sub

    Public Sub Transac()

        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblTransactionDetails "
        End With
        OleDBDR = OleDBC.ExecuteReader
        DatagridView1.Rows.Clear()
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                DatagridView1.Rows.Add()
                DatagridView1.Item(0, c).Value = OleDBDR.Item(0)
                DatagridView1.Item(1, c).Value = OleDBDR.Item(1)
                DatagridView1.Item(2, c).Value = OleDBDR.Item(2)
                DatagridView1.Item(3, c).Value = OleDBDR.Item(3)
                DatagridView1.Item(4, c).Value = OleDBDR.Item(4)
                DatagridView1.Item(5, c).Value = OleDBDR.Item(5)
                DatagridView1.Item(6, c).Value = OleDBDR.Item(6)
                DatagridView1.Item(7, c).Value = OleDBDR.Item(7)
                DatagridView1.Item(8, c).Value = OleDBDR.Item(8)
                DatagridView1.Item(9, c).Value = OleDBDR.Item(13)
                DatagridView1.Item(10, c).Value = OleDBDR.Item(14)

                c = c + 1
            End While
        End If
    End Sub

    Private Sub DatagridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DatagridView1.CellMouseClick

        If e.RowIndex < 0 Then Exit Sub
        frmReturnedBook.txtTransactionNo.Text = DatagridView1.Item(0, e.RowIndex).Value
        frmReturnedBook.txttransactiodate.Text = DatagridView1.Item(1, e.RowIndex).Value
        frmReturnedBook.txtID.Text = DatagridView1.Item(2, e.RowIndex).Value
        frmReturnedBook.txtStudName.Text = DatagridView1.Item(3, e.RowIndex).Value
        frmReturnedBook.txtLname.Text = DatagridView1.Item(4, e.RowIndex).Value
        frmReturnedBook.txtMid.Text = DatagridView1.Item(5, e.RowIndex).Value
        frmReturnedBook.cmbGender.Text = DatagridView1.Item(6, e.RowIndex).Value
        frmReturnedBook.txtCourse.Text = DatagridView1.Item(7, e.RowIndex).Value
        frmReturnedBook.txtSection.Text = DatagridView1.Item(8, e.RowIndex).Value
        frmReturnedBook.txtBDate.Text = DatagridView1.Item(9, e.RowIndex).Value
        frmReturnedBook.txtDDate.Text = DatagridView1.Item(10, e.RowIndex).Value
        frmReturnedBook.dtpBorrow.Text = DatagridView1.Item(9, e.RowIndex).Value
        frmReturnedBook.dtpDue.Text = DatagridView1.Item(10, e.RowIndex).Value
        frmReturnedBook.Button5.Enabled = False
        Me.Hide()
        frmReturnedBook.Show()



    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn.Close()
        Me.Hide()
    End Sub
    Private Sub loadsearchresult()
        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With OleDBC

            .Connection = conn
            .CommandText = "SELECT * FROM tblTransactionDetails WHERE TransactionNo like '%" & TextBox1.Text & "%'"

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
                DatagridView1.Item(5, c).Value = OleDBDR.Item(5)
                DatagridView1.Item(6, c).Value = OleDBDR.Item(6)
                DatagridView1.Item(7, c).Value = OleDBDR.Item(7)
                DatagridView1.Item(8, c).Value = OleDBDR.Item(8)
                DatagridView1.Item(9, c).Value = OleDBDR.Item(13)
                DatagridView1.Item(10, c).Value = OleDBDR.Item(14)


                c = c + 1
            End While
        End If
    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call loadsearchresult()
    End Sub
End Class