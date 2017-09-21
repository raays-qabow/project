<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnedBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbGender = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtStudName = New System.Windows.Forms.TextBox
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.dgList = New System.Windows.Forms.DataGridView
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtTransactionNo = New System.Windows.Forms.TextBox
        Me.txttransactiodate = New System.Windows.Forms.TextBox
        Me.txtDDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDReturned = New System.Windows.Forms.TextBox
        Me.txtBDate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPenal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtInterval = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpDue = New System.Windows.Forms.DateTimePicker
        Me.dtpBorrow = New System.Windows.Forms.DateTimePicker
        Me.dtpRet = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtStudName)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 263)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'cmbGender
        '
        Me.cmbGender.Enabled = False
        Me.cmbGender.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbGender.Location = New System.Drawing.Point(150, 155)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(130, 24)
        Me.cmbGender.TabIndex = 77
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(257, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 23)
        Me.Button5.TabIndex = 76
        Me.Button5.Text = "List"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Student ID"
        '
        'txtMid
        '
        Me.txtMid.Enabled = False
        Me.txtMid.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtMid.Location = New System.Drawing.Point(150, 123)
        Me.txtMid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMid.Name = "txtMid"
        Me.txtMid.Size = New System.Drawing.Size(130, 24)
        Me.txtMid.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(34, 163)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(16, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Student Middle I"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(34, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Course"
        '
        'txtLname
        '
        Me.txtLname.Enabled = False
        Me.txtLname.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtLname.Location = New System.Drawing.Point(150, 91)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(130, 24)
        Me.txtLname.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(24, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Student Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(0, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Student Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(34, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Section"
        '
        'txtCourse
        '
        Me.txtCourse.Enabled = False
        Me.txtCourse.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCourse.Location = New System.Drawing.Point(150, 185)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(130, 24)
        Me.txtCourse.TabIndex = 67
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtID.Location = New System.Drawing.Point(150, 27)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 24)
        Me.txtID.TabIndex = 70
        '
        'txtStudName
        '
        Me.txtStudName.Enabled = False
        Me.txtStudName.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtStudName.Location = New System.Drawing.Point(150, 59)
        Me.txtStudName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.Size = New System.Drawing.Size(130, 24)
        Me.txtStudName.TabIndex = 68
        '
        'txtSection
        '
        Me.txtSection.Enabled = False
        Me.txtSection.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSection.Location = New System.Drawing.Point(150, 209)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(130, 24)
        Me.txtSection.TabIndex = 69
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.dgList)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 337)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(709, 210)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Information"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(574, 177)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 23)
        Me.Button3.TabIndex = 94
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(391, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 23)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "Returned Book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17})
        Me.dgList.Location = New System.Drawing.Point(7, 24)
        Me.dgList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.RowHeadersVisible = False
        Me.dgList.Size = New System.Drawing.Size(688, 146)
        Me.dgList.TabIndex = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "Transaction No."
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Transacaction Date"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "BookID"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "BookTitle"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Book Author"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Publisher"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "Date Borrowed"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.HeaderText = "Due Date"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Load Books Borrowed"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTransactionNo
        '
        Me.txtTransactionNo.Enabled = False
        Me.txtTransactionNo.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTransactionNo.Location = New System.Drawing.Point(1042, 109)
        Me.txtTransactionNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionNo.Name = "txtTransactionNo"
        Me.txtTransactionNo.Size = New System.Drawing.Size(130, 24)
        Me.txtTransactionNo.TabIndex = 78
        '
        'txttransactiodate
        '
        Me.txttransactiodate.Enabled = False
        Me.txttransactiodate.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txttransactiodate.Location = New System.Drawing.Point(1042, 141)
        Me.txttransactiodate.Margin = New System.Windows.Forms.Padding(4)
        Me.txttransactiodate.Name = "txttransactiodate"
        Me.txttransactiodate.Size = New System.Drawing.Size(130, 24)
        Me.txttransactiodate.TabIndex = 82
        '
        'txtDDate
        '
        Me.txtDDate.Enabled = False
        Me.txtDDate.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtDDate.Location = New System.Drawing.Point(139, 45)
        Me.txtDDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDDate.Name = "txtDDate"
        Me.txtDDate.Size = New System.Drawing.Size(130, 24)
        Me.txtDDate.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(23, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Due Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(18, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 17)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Date Returned"
        '
        'txtDReturned
        '
        Me.txtDReturned.Enabled = False
        Me.txtDReturned.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtDReturned.Location = New System.Drawing.Point(139, 77)
        Me.txtDReturned.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDReturned.Name = "txtDReturned"
        Me.txtDReturned.Size = New System.Drawing.Size(130, 24)
        Me.txtDReturned.TabIndex = 85
        '
        'txtBDate
        '
        Me.txtBDate.Enabled = False
        Me.txtBDate.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBDate.Location = New System.Drawing.Point(139, 16)
        Me.txtBDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBDate.Name = "txtBDate"
        Me.txtBDate.Size = New System.Drawing.Size(130, 24)
        Me.txtBDate.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(23, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Borrow Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPenal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtInterval)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtDReturned)
        Me.GroupBox3.Controls.Add(Me.txtBDate)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtDDate)
        Me.GroupBox3.Location = New System.Drawing.Point(354, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 180)
        Me.GroupBox3.TabIndex = 89
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Borrow Details"
        '
        'txtPenal
        '
        Me.txtPenal.Enabled = False
        Me.txtPenal.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPenal.Location = New System.Drawing.Point(139, 136)
        Me.txtPenal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPenal.Name = "txtPenal"
        Me.txtPenal.Size = New System.Drawing.Size(130, 24)
        Me.txtPenal.TabIndex = 92
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(34, 143)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Penalty"
        '
        'txtInterval
        '
        Me.txtInterval.Enabled = False
        Me.txtInterval.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtInterval.Location = New System.Drawing.Point(139, 108)
        Me.txtInterval.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(130, 24)
        Me.txtInterval.TabIndex = 90
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(34, 111)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Days D"
        '
        'dtpDue
        '
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(1042, 202)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(154, 24)
        Me.dtpDue.TabIndex = 90
        '
        'dtpBorrow
        '
        Me.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBorrow.Location = New System.Drawing.Point(1042, 174)
        Me.dtpBorrow.Name = "dtpBorrow"
        Me.dtpBorrow.Size = New System.Drawing.Size(154, 24)
        Me.dtpBorrow.TabIndex = 91
        '
        'dtpRet
        '
        Me.dtpRet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRet.Location = New System.Drawing.Point(1042, 232)
        Me.dtpRet.Name = "dtpRet"
        Me.dtpRet.Size = New System.Drawing.Size(154, 24)
        Me.dtpRet.TabIndex = 92
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(16, 9)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(477, 17)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Click the button ""List"" to lookup the list of the Students Borrowed"
        '
        'frmReturnedBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 570)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpRet)
        Me.Controls.Add(Me.dtpBorrow)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txttransactiodate)
        Me.Controls.Add(Me.txtTransactionNo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReturnedBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGender As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtStudName As System.Windows.Forms.TextBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgList As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtTransactionNo As System.Windows.Forms.TextBox
    Friend WithEvents txttransactiodate As System.Windows.Forms.TextBox
    Friend WithEvents txtDDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDReturned As System.Windows.Forms.TextBox
    Friend WithEvents txtBDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPenal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBorrow As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRet As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
