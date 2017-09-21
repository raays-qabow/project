Imports System.Data.OleDb
Imports System.Object
Public Class frmAddStudent
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub frmAddBorrowers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call dates()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCourse.Text = "" Then
            MsgBox("Please Complete The Information Needed")
        ElseIf txtDateModified.Text = "" Then
            MsgBox("Please Complete The Information Needed")
        ElseIf txtStudName.Text = "" Then
            MsgBox("Please Complete The Information Needed")
        ElseIf txtSection.Text = "" Then
            MsgBox("Please Complete The Information Needed")

        Else

            Dim OleDBC1 As New OleDbCommand
            Dim oledbdr As OleDbDataReader

            With OleDBC1

                .Connection = conn
                .CommandText = "SELECT * FROM tblStudents WHERE StudentID='" & txtID.Text & "'"
                .ExecuteNonQuery
            End With
            oledbdr = OleDBC1.ExecuteReader
            oledbdr.Read()

            If oledbdr.HasRows Then
                MsgBox("The Student Was Already Added")
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
                .CommandText = "Insert Into tblBorrowers  VALUES ('" & txtID.Text & _
                "','" & txtStudName.Text & _
                "','" & txtLname.Text & _
                "','" & txtMid.Text & _
                "','" & cmbGender.Text & _
                "','" & txtCourse.Text & _
                "','" & txtSection.Text & _
                "','" & txtDateModified.Text & "')"
                .ExecuteNonQuery()
            End With
            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Call cleartext()
        End If




    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateModified.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call cleartext()
        conn.Close()
        Me.Hide()
    End Sub
    Private Sub dates()
        txtDateModified.Text = Format(Date.Today, "Short Date").ToString
    End Sub
    Private Sub cleartext()
        txtCourse.Text = ""
        txtID.Text = ""
        txtLname.Text = ""
        txtMid.Text = ""
        txtSection.Text = ""
        txtStudName.Text = ""
    End Sub
End Class