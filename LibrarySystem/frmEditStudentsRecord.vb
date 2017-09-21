Imports System.Data.OleDb
Imports System.Object
Public Class frmEditStudentsRecord
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub
    Private Sub frmEditBorrowersRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call loadBorrowers()
    End Sub

    Private Sub cmbStudID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStudID.SelectedIndexChanged

        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM tblStudents WHERE StudentID='" & cmbStudID.Text & "'"
        End With
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                cmbStudID.Text = (OleDBDR.Item(0))
                txtStudName.Text = (OleDBDR.Item(1))
                txtLname.Text = (OleDBDR.Item(2))
                txtMid.Text = (OleDBDR.Item(3))
                cmbGender.Text = (OleDBDR.Item(4))
                txtCourse.Text = (OleDBDR.Item(5))
                txtSection.Text = (OleDBDR.Item(6))
                txtDateAdded.Text = (OleDBDR.Item(7))

            End While
        End If
    End Sub
    Private Sub loadBorrowers()
        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT StudentID FROM tblStudents"
        End With
        OleDBDR = OleDBC.ExecuteReader
        cmbStudID.Items.Clear()
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                cmbStudID.Items.Add(OleDBDR.Item(0))
            End While
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Save Changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

            Dim oleDC As New OleDbCommand
            With oleDC
                .Connection = conn
                .CommandText = "UPDATE tblBorrowers SET StudentFName='" & txtStudName.Text & _
            "',StudentLName='" & cmbGender.Text & _
            "',StudentInitial='" & txtCourse.Text & _
            "',Genders='" & cmbGender.Text & _
            "',Courses='" & txtCourse.Text & _
            "',Sections='" & txtSection.Text & _
            "',DateModified='" & txtDateAdded.Text & "'  WHERE StudentID='" & cmbStudID.Text & "'"
                .ExecuteNonQuery()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

            End With
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn.Close()
        Me.Hide()
    End Sub
End Class