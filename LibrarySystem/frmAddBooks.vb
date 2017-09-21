Imports System.Data.OleDb
Imports System.Object
Public Class frmAddBooks
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub frmAddBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call getLastID()
    End Sub

    Private Sub getLastID()
        Dim oleDBDR As OleDbDataReader
        Dim oleDBCommand As New OleDbCommand

        With oleDBCommand
            .Connection = conn
            .CommandText = "SELECT * FROM tblBooks ORDER BY BookID DESC"
        End With
        oleDBDR = oleDBCommand.ExecuteReader
        If oleDBDR.Read Then
            txtID.Text = Val(oleDBDR.Item(0)) + 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtPublisher.Text = "" Then
            MsgBox("Please Complete the Information Needed")
        ElseIf txtAuthor.Text = "" Then
            MsgBox("Please Complete the Information Needed")
        ElseIf txtCop.Text = "" Then
            MsgBox("Please Complete the Information Needed")
        ElseIf txtID.Text = "" Then
            MsgBox("Please Complete the Information Needed")
        Else
            If MsgBox("Are you sure you want to Add Data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                Dim OleDBC As New OleDbCommand
                With OleDBC

                    .Connection = conn
                    .CommandText = "Insert Into tblBooks VALUES ('" & txtID.Text & _
                    "','" & txtTitle.Text & _
                    "','" & txtAuthor.Text & _
                    "','" & txtPublisher.Text & _
                    "',#" & dtpPub.Text & _
                    "#,'" & txtCop.Text & _
                    "',#" & Textbox7.Text & "#)"
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                Call getLastID()
                Call clears()
            End If
        End If

    End Sub
    Private Sub clears()
        txtID.Text = ""
        txtAuthor.Text = ""
        txtPublisher.Text = ""
        txtCop.Text = ""
        Textbox7.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clears()
        conn.Close()
        Me.Hide()
    End Sub
End Class