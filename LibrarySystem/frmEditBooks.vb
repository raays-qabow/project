Imports System.Data.OleDb
Imports System.Object
Public Class frmEditBooks
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub frmEditBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call loadBooks()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBookID.SelectedIndexChanged

        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblBooks WHERE BookID='" & cmbBookID.Text & "'"
        End With
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                cmbBookID.Text = (OleDBDR.Item(0))
                txtTitle.Text = (OleDBDR.Item(1))
                txtAuthor.Text = (OleDBDR.Item(2))
                txtPublisher.Text = (OleDBDR.Item(3))
                txtDatePublish.Text = (OleDBDR.Item(4))
                txtCop.Text = (OleDBDR.Item(5))
                txtDateMod.Text = (OleDBDR.Item(6))
            End While
        End If
    End Sub
    Private Sub loadBooks()
        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT BookID FROM tblBooks"
        End With
        OleDBDR = OleDBC.ExecuteReader
        cmbBookID.Items.Clear()
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                cmbBookID.Items.Add(OleDBDR.Item(0))
            End While
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtAuthor.Text = "" Then
            MsgBox("Please Type Correct Information")
        ElseIf txtDatePublish.Text = "" Then
            MsgBox("Please Type Correct Information")
        ElseIf txtDateMod.Text = "" Then
            MsgBox("Please Type Correct Information")
        ElseIf txtTitle.Text = "" Then
            MsgBox("Please Type Correct Information")
        Else
            If MsgBox("Save Changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

                Dim oleDC As New OleDbCommand
                With oleDC
                    .Connection = conn
                    .CommandText = "UPDATE tblBooks SET BookTitle='" & txtTitle.Text & _
                "',BAuthor='" & txtAuthor.Text & _
                "',Publisher='" & txtPublisher.Text & _
                "',DatePublish='" & txtDatePublish.Text & _
                "',CopyRight='" & txtCop.Text & _
                "',DateModified='" & txtDateMod.Text & "'  WHERE BookID='" & cmbBookID.Text & "'"
                    .ExecuteNonQuery()
                    MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

                End With
            End If
        End If

       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtAuthor.Text = ""
        txtCop.Text = ""
        txtDatePublish.Text = ""
        txtPublisher.Text = ""
        txtTitle.Text = ""
        conn.Close()
        Me.Hide()
    End Sub
End Class