Imports System.Data.OleDb
Imports System.Object
Public Class frmCreateUserAccount
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MsgBox("Are you sure you want to Add Data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Dim OleDBC As New OleDbCommand
            With OleDBC

                .Connection = conn
                If txtConfirm.Text = txtPassword.Text Then
                    .CommandText = "Insert Into tblUsers VALUES ('" & txtUserName.Text & _
                    "','" & txtPassword.Text & "')"

                    .ExecuteNonQuery()
                    MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                Else
                    MsgBox("Password Mismatch")
                End If
                Me.Hide()
                conn.Close()
            End With
        End If
    End Sub

    Private Sub frmCreateUserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtConfirm.Text = ""
        txtPassword.Text = ""
        txtUserName.Text = ""
        conn.Close()
        Me.Hide()
    End Sub
End Class