<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SpltProfile = New System.Windows.Forms.Splitter()
        Me.SpltSearch = New System.Windows.Forms.Splitter()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TxtSurname = New System.Windows.Forms.TextBox()
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.LblSurname = New System.Windows.Forms.Label()
        Me.LblDateOfBirth = New System.Windows.Forms.Label()
        Me.TxtStudentNo = New System.Windows.Forms.TextBox()
        Me.LblStudentNo = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.OpenRecord = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnDelete = New System.Windows.Forms.PictureBox()
        Me.ErrFirstName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrSurname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrStudentNum = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrSurname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrStudentNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpltProfile
        '
        Me.SpltProfile.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SpltProfile.Location = New System.Drawing.Point(0, 0)
        Me.SpltProfile.Name = "SpltProfile"
        Me.SpltProfile.Size = New System.Drawing.Size(402, 330)
        Me.SpltProfile.TabIndex = 0
        Me.SpltProfile.TabStop = False
        '
        'SpltSearch
        '
        Me.SpltSearch.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SpltSearch.Location = New System.Drawing.Point(402, 0)
        Me.SpltSearch.Name = "SpltSearch"
        Me.SpltSearch.Size = New System.Drawing.Size(462, 330)
        Me.SpltSearch.TabIndex = 1
        Me.SpltSearch.TabStop = False
        Me.SpltSearch.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(206, 136)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(190, 190)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        Me.BtnSave.Visible = False
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(10, 136)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(190, 190)
        Me.BtnNew.TabIndex = 5
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstName.Location = New System.Drawing.Point(128, 6)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(148, 26)
        Me.TxtFirstName.TabIndex = 6
        Me.TxtFirstName.Visible = False
        '
        'TxtSurname
        '
        Me.TxtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurname.Location = New System.Drawing.Point(128, 38)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.Size = New System.Drawing.Size(148, 26)
        Me.TxtSurname.TabIndex = 7
        Me.TxtSurname.Visible = False
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstName.Location = New System.Drawing.Point(32, 6)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Size = New System.Drawing.Size(90, 20)
        Me.LblFirstName.TabIndex = 9
        Me.LblFirstName.Text = "First Name:"
        Me.LblFirstName.Visible = False
        '
        'LblSurname
        '
        Me.LblSurname.AutoSize = True
        Me.LblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSurname.Location = New System.Drawing.Point(44, 38)
        Me.LblSurname.Name = "LblSurname"
        Me.LblSurname.Size = New System.Drawing.Size(78, 20)
        Me.LblSurname.TabIndex = 10
        Me.LblSurname.Text = "Surname:"
        Me.LblSurname.Visible = False
        '
        'LblDateOfBirth
        '
        Me.LblDateOfBirth.AutoSize = True
        Me.LblDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateOfBirth.Location = New System.Drawing.Point(16, 70)
        Me.LblDateOfBirth.Name = "LblDateOfBirth"
        Me.LblDateOfBirth.Size = New System.Drawing.Size(106, 20)
        Me.LblDateOfBirth.TabIndex = 11
        Me.LblDateOfBirth.Text = "Date Of Birth:"
        Me.LblDateOfBirth.Visible = False
        '
        'TxtStudentNo
        '
        Me.TxtStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStudentNo.Location = New System.Drawing.Point(128, 102)
        Me.TxtStudentNo.Name = "TxtStudentNo"
        Me.TxtStudentNo.Size = New System.Drawing.Size(148, 26)
        Me.TxtStudentNo.TabIndex = 16
        Me.TxtStudentNo.Visible = False
        '
        'LblStudentNo
        '
        Me.LblStudentNo.AutoSize = True
        Me.LblStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudentNo.Location = New System.Drawing.Point(24, 102)
        Me.LblStudentNo.Name = "LblStudentNo"
        Me.LblStudentNo.Size = New System.Drawing.Size(98, 20)
        Me.LblStudentNo.TabIndex = 17
        Me.LblStudentNo.Text = "Student No.:"
        Me.LblStudentNo.Visible = False
        '
        'DTP1
        '
        Me.DTP1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(128, 70)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(148, 26)
        Me.DTP1.TabIndex = 19
        Me.DTP1.Visible = False
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToResizeColumns = False
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OpenRecord})
        Me.DataGrid1.Location = New System.Drawing.Point(410, 12)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGrid1.Size = New System.Drawing.Size(443, 314)
        Me.DataGrid1.TabIndex = 20
        '
        'OpenRecord
        '
        Me.OpenRecord.HeaderText = ""
        Me.OpenRecord.Name = "OpenRecord"
        Me.OpenRecord.Text = "Load"
        Me.OpenRecord.UseColumnTextForButtonValue = True
        Me.OpenRecord.Width = 35
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImage = Global.Student_Registration.My.Resources.Resources.Delete_Button
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnDelete.Image = Global.Student_Registration.My.Resources.Resources.Delete_Button
        Me.BtnDelete.InitialImage = Nothing
        Me.BtnDelete.Location = New System.Drawing.Point(346, 12)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(50, 50)
        Me.BtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDelete.TabIndex = 15
        Me.BtnDelete.TabStop = False
        Me.BtnDelete.Visible = False
        '
        'ErrFirstName
        '
        Me.ErrFirstName.ContainerControl = Me
        '
        'ErrSurname
        '
        Me.ErrSurname.ContainerControl = Me
        '
        'ErrStudentNum
        '
        Me.ErrStudentNum.ContainerControl = Me
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 330)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.LblStudentNo)
        Me.Controls.Add(Me.TxtStudentNo)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LblDateOfBirth)
        Me.Controls.Add(Me.LblSurname)
        Me.Controls.Add(Me.LblFirstName)
        Me.Controls.Add(Me.TxtSurname)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.SpltSearch)
        Me.Controls.Add(Me.SpltProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Student Record"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrSurname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrStudentNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SpltProfile As Splitter
    Friend WithEvents SpltSearch As Splitter
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents LblFirstName As Label
    Friend WithEvents LblSurname As Label
    Friend WithEvents LblDateOfBirth As Label
    Friend WithEvents BtnDelete As PictureBox
    Friend WithEvents TxtStudentNo As TextBox
    Friend WithEvents LblStudentNo As Label
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents DataGrid1 As DataGridView
    Friend WithEvents OpenRecord As DataGridViewButtonColumn
    Friend WithEvents ErrFirstName As ErrorProvider
    Friend WithEvents ErrSurname As ErrorProvider
    Friend WithEvents ErrStudentNum As ErrorProvider
End Class
