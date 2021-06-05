Imports System.IO
Imports System.Text.RegularExpressions
Imports Student_Registration.FieldValidator

Public Class FrmMain
    'Copyright - Red x box. https://pixabay.com/en/button-stop-red-cross-warning-31222/ Creative Commons 1.0.

    Public Students(0) As StudentInfo 'Dynamically sized array of the structure StudentInfo
    Public Structure StudentInfo
        Dim FirstName As String
        Dim Surname As String
        Dim DateOfBirth As Date
        Dim StudentNo As Integer
    End Structure

    Public RecordNum As Integer = -1 'Stores the id of the active student record
    Dim DataTable1 As New DataTable 'Datatable created on runtime and parsed into the datagridviewer

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Formats the date time picker and sets its maximum and minimum date
        'Formats the datatable and grid
        'Loads the CSV file into the datatable
        DTP1.CustomFormat = "dd/MM/yyyy"
        DTP1.MinDate = New DateTime(1900, 1, 1)
        DTP1.MaxDate = Date.Now
        DataGrid1.AllowUserToAddRows = False

        If "StudentRegistration.csv" IsNot Nothing Then
            Dim sr As StreamReader = File.OpenText("StudentRegistration.csv")

            With DataTable1
                .Columns.Add("First Name", System.Type.GetType("System.String"))
                .Columns.Add("Surname", System.Type.GetType("System.String"))
                .Columns.Add("Date of Birth", System.Type.GetType("System.DateTime"))
                .Columns.Add("Student No.", System.Type.GetType("System.Int32"))
            End With

            Dim StrLine As String = ""
            Do 'reads from csv, adding a new line to the data table for each line of the csv and parsing the data to the correct column.
                StrLine = sr.ReadLine
                If StrLine Is Nothing Then Exit Do
                Dim Columns() As String = StrLine.Split(",")
                Dim newrow As DataRow = DataTable1.NewRow
                newrow("First Name") = Columns(0)
                newrow("Surname") = Columns(1)
                newrow("Date of Birth") = Columns(2)
                newrow("Student No.") = Columns(3)
                DataTable1.Rows.Add(newrow)
            Loop
            sr.Close()

            DataGrid1.DataSource = DataTable1
            DataGrid1.Columns(3).Width = 89
            DataGrid1.Columns(4).Width = 80
            PopulateStructure() 'Loads the the fields in each record of the csv to parts of the structure in each element of the Students array
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Delete Record")
        Select Case ask
            Case MsgBoxResult.No
                'do nothing
            Case MsgBoxResult.Yes
                Dim record As DataRow = DataTable1.Rows(RecordNum)
                record.Delete()
                DataTable1.AcceptChanges()
                ClearFields() 'Clears the textboxes and resets the Datetimepicker
                HideUI() 'Hides UI elements
                PopulateStructure() 'Loads the the fields in each record of the csv to parts of the structure in each element of the Students array
        End Select
    End Sub

    Sub PopulateStructure() 'Loads the the fields in each record of the csv to parts of the structure in each element of the Students array
        Dim Inc As Integer = 0
        For Each row As DataRow In DataTable1.Rows
            Students(Inc).FirstName = row(0)
            Students(Inc).Surname = row(1)
            Students(Inc).DateOfBirth = row(2)
            Students(Inc).StudentNo = row(3)
            Inc = Inc + 1
            ReDim Preserve Students(Inc)
        Next
    End Sub

    Sub ClearFields() 'Clears the textboxes and resets the Datetimepicker
        TxtFirstName.Clear()
        TxtSurname.Clear()
        DTP1.ResetText()
        TxtStudentNo.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Validates the textbox fields and prompts the user to save if data is valid.
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to save this record?", MsgBoxStyle.YesNo, "Save Record")

        Dim FV As FieldValidator = New FieldValidator
        If FV.ValidateName(TxtFirstName.Text) = False Then
            ErrFirstName.SetError(TxtFirstName, "Input is invalid. Please make sure that the name is in title case and contains no numbers or symbols")
        End If
        If FV.ValidateName(TxtSurname.Text) = False Then
            ErrSurname.SetError(TxtSurname, "Input is invalid. Please make sure that the name is in title case and contains no numbers or symbols")
        End If
        If FV.ValidateStudentNum(TxtStudentNo.Text) = False Then
            ErrStudentNum.SetError(TxtStudentNo, "Student Number is invalid. Please enter 6 digits without any letters or symbols.")
        Else
            ErrStudentNum.Clear()
        End If

        If FV.ValidateName(TxtFirstName.Text) = True AndAlso FV.ValidateName(TxtSurname.Text) = True AndAlso FV.ValidateStudentNum(TxtStudentNo.Text) = True Then
            Select Case ask
                Case MsgBoxResult.No
                'do nothing
                Case MsgBoxResult.Yes

                    'Writes field data to Students array of structure
                    Students(RecordNum).FirstName = TxtFirstName.Text
                    Students(RecordNum).Surname = TxtSurname.Text
                    Students(RecordNum).DateOfBirth = DTP1.Value.Date
                    Students(RecordNum).StudentNo = TxtStudentNo.Text

                    'Creates new record in the datatable, parsing data from the Students array to the correct columns in the datatable
                    Dim Record As DataRow = DataTable1.Rows(RecordNum)
                    Record(0) = Students(RecordNum).FirstName
                    Record(1) = Students(RecordNum).Surname
                    Record(2) = Students(RecordNum).DateOfBirth
                    Record(3) = Students(RecordNum).StudentNo

                    Dim sw As New StreamWriter("StudentRegistration.csv", False)
                    Dim output As String = ""
                    For Each Data As StudentInfo In Students
                        If Students.Length - 1 = 1 Then 'Prevents one record being output twice.
                            output &= String.Join(",", Data.FirstName, Data.Surname, Data.DateOfBirth.ToString("dd/MM/yyyy"), Data.StudentNo)
                            Exit For
                        End If
                        output &= String.Join(",", Data.FirstName, Data.Surname, Data.DateOfBirth.ToString("dd/MM/yyyy"), Data.StudentNo)
                        Console.WriteLine(output)
                        If output.EndsWith(vbCrLf) = False Then
                            output &= vbCrLf
                        End If
                    Next
                    output = output.Remove(output.Length - 2, 2) 'Removes two excess newline characters
                    sw.WriteLine(output)
                    sw.Close()
            End Select
        Else
            MsgBox("Failed to save due to invalid data in the fields.")
        End If

    End Sub

    Private Sub DataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick
        'Intended for activation when the user clicks the "Load" button
        Try
            If e.ColumnIndex > 0 Then 'Prevents activation if any other cell but the "Load" button in each row is clicked
                Exit Sub
            End If

            For i = 1 To DataTable1.Columns.Count - 2
                RecordNum = e.RowIndex 'parses the row number to RecordNum
                'Loads the structure fields from the Students array of the element corresponding to the row in question.
                TxtFirstName.Text = Students(RecordNum).FirstName
                TxtSurname.Text = Students(RecordNum).Surname
                DTP1.Value = Students(RecordNum).DateOfBirth
                TxtStudentNo.Text = Students(RecordNum).StudentNo
            Next

            ShowUI() 'Shows the UI elements
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ShowUI() 'Shows the UI elements
        ClearFields() 'Clears the textboxes and resets the Datetimepicker
        RecordNum = DataTable1.Rows.Count 'Sets RecordNum to position of the new row
        'Creates a new row for the data table while complying with its format
        Dim MyRow As DataRow
        MyRow = DataTable1.NewRow()
        MyRow("First Name") = ""
        MyRow("Surname") = ""
        MyRow("Date of Birth") = DateTime.Now.Date
        MyRow("Student No.") = 0
        DataTable1.Rows.Add(MyRow)
        DataTable1.AcceptChanges()
        DataGrid1.Refresh()
        DataGrid1.Rows(RecordNum).Selected = True
    End Sub

    Private Sub TxtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles TxtStudentNo.TextChanged
        'Provides non-intrusive on the field validation
        Dim FV As FieldValidator = New FieldValidator
        If FV.ValidateStudentNum(TxtStudentNo.Text) = False Then
            ErrStudentNum.SetError(TxtStudentNo, "Student Number is invalid. Please enter 6 digits without any letters or symbols.")
        Else
            ErrStudentNum.Clear()
        End If
    End Sub

    Private Sub TxtFirstName_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstName.TextChanged
        'Provides non-intrusive on the field validation
        Dim FV As FieldValidator = New FieldValidator
        If FV.ValidateName(TxtFirstName.Text) = False Then
            ErrFirstName.SetError(TxtFirstName, "Input is invalid. Please make sure that the name is in title case and contains no numbers or symbols")
        Else
            ErrFirstName.Clear()
        End If
    End Sub

    Private Sub TxtSurname_TextChanged(sender As Object, e As EventArgs) Handles TxtSurname.TextChanged
        'Provides non-intrusive on the field validation
        Dim FV As FieldValidator = New FieldValidator
        If FV.ValidateName(TxtSurname.Text) = False Then
            ErrSurname.SetError(TxtSurname, "Input is invalid. Please make sure that the name is in title case and contains no numbers or symbols")
        Else
            ErrSurname.Clear()
        End If
    End Sub

    Private Sub ShowUI()
        LblFirstName.Visible = True
        LblSurname.Visible = True
        LblDateOfBirth.Visible = True
        LblStudentNo.Visible = True
        TxtFirstName.Visible = True
        TxtSurname.Visible = True
        DTP1.Visible = True
        TxtStudentNo.Visible = True
        BtnSave.Visible = True
        BtnDelete.Visible = True
    End Sub

    Private Sub HideUI()
        LblFirstName.Visible = False
        LblSurname.Visible = False
        LblDateOfBirth.Visible = False
        LblStudentNo.Visible = False
        TxtFirstName.Visible = False
        TxtSurname.Visible = False
        DTP1.Visible = False
        TxtStudentNo.Visible = False
        BtnSave.Visible = False
        BtnDelete.Visible = False
    End Sub

End Class
