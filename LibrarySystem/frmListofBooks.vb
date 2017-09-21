Imports System.Data.OleDb
Imports System.Object
Public Class frmListofBooks
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub frmListofBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call loadBookss()
    End Sub


    Private Sub loadBookss()
        Dim oleDBC As New OleDbCommand
        Dim oleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With oleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblBooks "
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
                DataGridView1.Item(6, c).Value = oleDBDR.Item(6)

                c = c + 1
            End While
        Else
            MsgBox("No Record to Display!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
        End If
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
                DataGridView1.Item(6, c).Value = oleDBDR.Item(6)

                c = c + 1
            End While
        Else
            MsgBox("No Record to Display!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn.Close()
        Me.Hide()
    End Sub
     
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call loadBooks()
    End Sub
End Class