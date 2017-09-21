Imports System.Data.OleDb
Imports System.Object
Public Class frmLogIn
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        'conn.Open()
    End Sub
    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call connectDatabase()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblUsers " & _
            "WHERE UID='" & _
            TextBox1.Text & "' AND " & _
            "Upass='" & _
            txtPass.Text & "'"

        End With

        OleDBDR = OleDBC.ExecuteReader
        OleDBDR.Read()

        If OleDBDR.HasRows Then
            Me.Hide()
            frmMainMenu.ShowDialog()
        Else
            MsgBox("Access Denied!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            TextBox1.Text = ""
            txtPass.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
