Imports System.Data.OleDb
Imports System.Object
Public Class frmChangePassword
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Save Changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Dim oleDC As New OleDbCommand
            With oleDC
                .Connection = conn
                If txtNewPass.Text = txtConfirm.Text Then
                    .CommandText = "UPDATE tblUsers SET UPass='" & txtNewPass.Text & _
                    "' WHERE Upass='" & txtOld.Text & "'"
                    .ExecuteNonQuery()
                    MsgBox(" Password Change")
                    Me.Hide()
                Else
                    MsgBox("Password Mismatch")
                End If
            End With
        End If
        txtNewPass.Enabled = True
        txtConfirm.Enabled = True
        txtNewPass.Text = ""
        txtConfirm.Text = ""
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn.Close()
        Me.Hide()
    End Sub
End Class