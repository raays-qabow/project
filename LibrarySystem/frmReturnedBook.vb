Imports System.Data.OleDb
Imports System.Object
Public Class frmReturnedBook
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=microsoft.Jet.OleDb.4.0;Data Source=dbLibrarySys.mdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub

    Private Sub Details()
        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        Dim c As Integer
        c = 0
        With OleDBC

            .Connection = conn
            .CommandText = "SELECT * FROM tblTransactionDetails WHERE TransactionNo='" & txtTransactionNo.Text & "'"

        End With
        OleDBDR = OleDBC.ExecuteReader
        dgList.Rows.Clear()
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                dgList.Rows.Add()
                dgList.Item(0, c).Value = OleDBDR.Item(0)
                dgList.Item(1, c).Value = OleDBDR.Item(1)
                dgList.Item(2, c).Value = OleDBDR.Item(9)
                dgList.Item(3, c).Value = OleDBDR.Item(10)
                dgList.Item(4, c).Value = OleDBDR.Item(11)
                dgList.Item(5, c).Value = OleDBDR.Item(12)
                dgList.Item(6, c).Value = OleDBDR.Item(13)
                dgList.Item(7, c).Value = OleDBDR.Item(14)
                c = c + 1
            End While
        Else

            MsgBox("Record Does Not Exist")

        End If
    End Sub

    Private Sub frmReturnedBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectDatabase()
        Call calldates()
        Call computes()
    End Sub
    Private Sub calldates()
        txtDReturned.Text = Format(Date.Today, "Short Date").ToString
    End Sub
    Private Sub computes()
        Try
            txtPenal.Text = CSng(txtInterval.Text) * 7
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Details()
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Me.Hide()
        frmListOfStudentsBorrowed.ShowDialog()
    End Sub

    Private Sub txtDReturned_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDReturned.TextChanged
        Try
            txtInterval.Text = DateDiff(DateInterval.Day, dtpDue.Value, dtpRet.Value)

            If dtpRet.Value < dtpDue.Text Then
                txtInterval.Text = "0"
            Else
            End If
        Catch
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If txtBDate.Text = "" Then
            MsgBox("Please complete the information")
        ElseIf txtStudName.Text = "" Then
            MsgBox("Please complete the information")
        ElseIf txtID.Text = "" Then
            MsgBox("Please complete the information")
        ElseIf txtMid.Text = "" Then
            MsgBox("Please complete the information")
        ElseIf txtTransactionNo.Text = "" Then
            MsgBox("Please complete the information")
        ElseIf txtLname.Text = "" Then
            MsgBox("Please complete the information")
        Else
            Call functions()
            Call Delete()
        End If

    End Sub

    Private Sub Delete()

        Dim oledc As New OleDbCommand
        With oledc
            .Connection = conn
            .CommandText = "DELETE FROM tblTransactionDetails WHERE TransactionNo='" & txtTransactionNo.Text & "'"
            .ExecuteNonQuery()

        End With
        MsgBox("The Book has Succesfully Returned", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
        Call clear()
        Me.Hide()
    End Sub
    Private Sub clear()
        txtCourse.Text = ""
        txtDDate.Text = ""
        txtTransactionNo.Text = ""
        txttransactiodate.Text = ""
        txtStudName.Text = ""
        txtSection.Text = ""
        txtMid.Text = ""
        txtLname.Text = ""
        txtInterval.Text = ""
        txtID.Text = ""
        txtDReturned.Text = ""
        txtDDate.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call clear()
        conn.Close()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        conn.Close()

    End Sub
    Private Sub functions()
        Dim OleDBC As New OleDbCommand
        With OleDBC

            .Connection = conn
            .CommandText = "Insert Into tblListOfReturnedBooks VALUES ('" & txtID.Text & _
            "','" & txtStudName.Text & _
            "','" & txtLname.Text & _
            "','" & txtMid.Text & _
            "','" & txtCourse.Text & _
            "','" & txtSection.Text & _
            "','" & txtBDate.Text & _
            "','" & txtDDate.Text & _
            "','" & txtDReturned.Text & _
            "','" & txtInterval.Text & _
            "','" & txtPenal.Text & "')"
            .ExecuteNonQuery()
        End With

    End Sub
End Class