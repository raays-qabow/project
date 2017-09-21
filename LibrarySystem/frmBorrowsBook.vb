Imports System.Data.OleDb
Imports System.Object
Public Class frmBorrowsBook
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        frmChooseStudents.ShowDialog()
    End Sub

    Private Sub frmBorrowsBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call BookList()
        Call TransactionNo()
        Call calldate()
        Call loadTrans()
    End Sub
    Private Sub TransactionNo()
        Dim oleDBDR As OleDbDataReader
        Dim oleDBCommand As New OleDbCommand

        With oleDBCommand
            .Connection = conn
            .CommandText = "SELECT * FROM tblTransactionDetails ORDER BY TransactionNo DESC"
        End With
        oleDBDR = oleDBCommand.ExecuteReader
        If oleDBDR.Read Then
            txtTransactionNo.Text = Val(oleDBDR.Item(0)) + 1
        End If
    End Sub
    Private Sub calldate()
        txtTransacDate.Text = Format(Date.Today, "Short Date").ToString
    End Sub

    Public Sub BookList()

        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblBooks "
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

                c = c + 1
            End While
        End If
    End Sub
    Private Sub loadTrans()
        Dim oleDBC As New OleDbCommand
        Dim oleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With oleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblTransactionDetails Where TransactionNo='" & txtTransactionNo.Text & "'"
        End With
        oleDBDR = oleDBC.ExecuteReader
        dgList.Rows.Clear()
        If oleDBDR.HasRows Then
            While oleDBDR.Read
                dgList.Rows.Add()
                dgList.Item(0, c).Value = oleDBDR.Item(0)
                dgList.Item(1, c).Value = oleDBDR.Item(1)
                dgList.Item(2, c).Value = oleDBDR.Item(2)
                dgList.Item(3, c).Value = oleDBDR.Item(6)
                dgList.Item(4, c).Value = oleDBDR.Item(7)
                c = c + 1
            End While
        Else
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtAuthor.Text = "" Then
            MsgBox("Please Complete Information")
        ElseIf txtBID.Text = "" Then
            MsgBox("Please Complete Information")
        ElseIf txtTransactionNo.Text = "" Then
            MsgBox("Please Complete Information")
        ElseIf txtCourse.Text = "" Then
            MsgBox("Please Complete Information")
        ElseIf txtTitle.Text = "" Then
            MsgBox("Please Complete Information")
        ElseIf txtStudName.Text = "" Then
            MsgBox("Please Complete Information")
        Else
            Dim OleDBC1 As New OleDbCommand
            Dim oledbdr As OleDbDataReader
            With OleDBC1

                .Connection = conn
                .CommandText = "SELECT * FROM tblTransactionDetails WHERE StudentID='" & txtID.Text & "'"
                .ExecuteNonQuery()
            End With
            oledbdr = OleDBC1.ExecuteReader
            oledbdr.Read()

            If oledbdr.HasRows Then
                MsgBox("The Student Was'nt Still Returned the Books He/She Borrowed")
                Exit Sub
            Else
                Call functions()
            End If
        End If
    End Sub
    Private Sub functions()
        If MsgBox("Are you sure you want to Add Data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Dim OleDBC As New OleDbCommand
            With OleDBC

                .Connection = conn
                .CommandText = "Insert Into tblTransactionDetails VALUES ('" & txtTransactionNo.Text & _
                "','" & txtTransacDate.Text & _
                "','" & txtID.Text & _
                "','" & txtStudName.Text & _
                "','" & txtLname.Text & _
                "','" & txtMid.Text & _
                "','" & cmbGender.Text & _
                "','" & txtCourse.Text & _
                "','" & txtSection.Text & _
                "','" & txtBID.Text & _
                "','" & txtTitle.Text & _
                "','" & txtAuthor.Text & _
                "','" & txtPublisher.Text & _
                "','" & txtTransacDate.Text & _
                "',#" & DateTimePicker1.Text & "#)"
                .ExecuteNonQuery()
            End With
            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Call loadBorrowed()
        End If



    End Sub


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        txtBID.Text = DataGridView1.Item(0, e.RowIndex).Value
        txtTitle.Text = DataGridView1.Item(1, e.RowIndex).Value
        txtAuthor.Text = DataGridView1.Item(2, e.RowIndex).Value
        txtPublisher.Text = DataGridView1.Item(3, e.RowIndex).Value
        txtPlacePub.Text = DataGridView1.Item(4, e.RowIndex).Value
        txtCop.Text = DataGridView1.Item(5, e.RowIndex).Value
    End Sub
    Private Sub loadBorrowed()
        Dim oleDBC As New OleDbCommand
        Dim oleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With oleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblTransactionDetails Where TransactionNo='" & txtTransactionNo.Text & "'"
        End With
        oleDBDR = oleDBC.ExecuteReader
        dgList.Rows.Clear()
        If oleDBDR.HasRows Then
            While oleDBDR.Read
                dgList.Rows.Add()
                dgList.Item(0, c).Value = oleDBDR.Item(0)
                dgList.Item(1, c).Value = oleDBDR.Item(1)
                dgList.Item(2, c).Value = oleDBDR.Item(2)
                dgList.Item(3, c).Value = oleDBDR.Item(3)
                dgList.Item(4, c).Value = oleDBDR.Item(4)
                dgList.Item(5, c).Value = oleDBDR.Item(5)
                dgList.Item(6, c).Value = oleDBDR.Item(6)
                dgList.Item(7, c).Value = oleDBDR.Item(7)
                dgList.Item(8, c).Value = oleDBDR.Item(8)
                dgList.Item(9, c).Value = oleDBDR.Item(9)
                dgList.Item(10, c).Value = oleDBDR.Item(10)
                dgList.Item(11, c).Value = oleDBDR.Item(11)
                dgList.Item(12, c).Value = oleDBDR.Item(12)
                dgList.Item(13, c).Value = oleDBDR.Item(13)
                dgList.Item(14, c).Value = oleDBDR.Item(14)

                c = c + 1
            End While
        Else
        End If
    End Sub

    Private Sub dgList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgList.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        TextBox2.Text = dgList.Item(9, e.RowIndex).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oleDC As New OleDbCommand
        With oleDC
            .Connection = conn
            .CommandText = "DELETE FROM tblTransactionDetails WHERE BookID='" & TextBox2.Text & "'"
            .ExecuteNonQuery()
            Call loadBorrowed()
        End With
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        Call CLEARS()
        conn.Close()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call loadBooks()

    End Sub
    Private Sub CLEARS()
        txtAuthor.Text = ""
        txtBID.Text = ""
        txtCop.Text = ""
        txtCourse.Text = ""
        txtID.Text = ""
        txtLname.Text = ""
        txtMid.Text = ""
        txtPlacePub.Text = ""
        txtPublisher.Text = ""
        txtTitle.Text = ""
        txtTransactionNo.Text = ""
    End Sub
    Private Sub loadBooks()
        Dim oleDBC As New OleDbCommand
        Dim oleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With oleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblBooks WHERE BookTitle like '%" & TextBox1.Text & "%'"

        End With
        oleDBDR = oleDBC.ExecuteReader
        DataGridView1.Rows.Clear()
        If oleDBDR.HasRows Then
            While oleDBDR.Read
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, c).Value = oleDBDR.Item(0)
                DataGridView1.Item(1, c).Value = oleDBDR.Item(1)
                DataGridView1.Item(2, c).Value = oleDBDR.Item(2)
                DataGridView1.Item(3, c).Value = oleDBDR.Item(3)
                DataGridView1.Item(4, c).Value = oleDBDR.Item(4)
                DataGridView1.Item(5, c).Value = oleDBDR.Item(5)

                c = c + 1
            End While
        Else
            MsgBox("No Record to Display!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class