Public Class Form1
    Private isGenerated As Boolean = False ' indicate ID has been generated
    Private studentCounts As New Dictionary(Of String, Integer) From {
        {"Accounting", 0},
        {"Business Administration", 0},
        {"Computer Science", 0},
        {"Management", 0},
        {"Marketing", 0}
    }

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdep.SelectedIndexChanged
        ' Disable the Register button if the department is changed
        If isGenerated Then
            cmdregistred.Enabled = False
            isGenerated = False
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regular.CheckedChanged, extension.CheckedChanged, weekend.CheckedChanged
        ' Disable the Register button if the division is changed
        If isGenerated Then
            cmdregistred.Enabled = False
            isGenerated = False
        End If
    End Sub

    Private Sub cmdregistred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdregistred.Click
        ' Check if a department is selected
        If cmbdep.SelectedIndex = -1 Then
            MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get selected department name
        Dim selectedDepartment As String = cmbdep.SelectedItem.ToString()

        ' Increment the student count for the selected department
        If studentCounts.ContainsKey(selectedDepartment) Then
            studentCounts(selectedDepartment) += 1
        End If

        ' Proceed with the registration
        MessageBox.Show("Registration successful!", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Reset everything to default
        isGenerated = False

        ' Reset the form fields to default values
        cmbdep.SelectedIndex = 0
        regular.Checked = True

        ' Set the button text to "Generate ID" 
        cmdid.Text = "Generate ID"

        ' Disable the Register button 
        cmdregistred.Enabled = False
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        ' Close when the exit button is clicked
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set default selections when the form loads
        cmbdep.SelectedIndex = 0
        regular.Checked = True

        ' Disable the Register button initially
        cmdregistred.Enabled = False

        ' Generate and display a default ID
        GenerateDefaultID()
    End Sub

    Private Sub GenerateDefaultID()
        Dim departmentCode As String = "AC"
        Dim divisionCode As String = "R"
        Dim studentNumber As String = "0000"
        Dim registrationYear As String = (DateTime.Now.Year Mod 100).ToString("D2")

        Dim defaultID As String = String.Format("{0}{1}/{2}/{3}", departmentCode, divisionCode, studentNumber, registrationYear)
        cmdid.Text = defaultID
    End Sub

    Private Sub GenerateID()
        Dim departmentCode As String = ""

        ' Check if a department is selected and if a division is checked.
        If cmbdep.SelectedIndex = -1 Then
            MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not (regular.Checked Or extension.Checked Or weekend.Checked) Then
            MessageBox.Show("Please select a division.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get selected department name and corresponding count for generating ID.
        Dim selectedDepartment As String = cmbdep.SelectedItem.ToString()

        Dim studentNumber As Integer = studentCounts(selectedDepartment) + 1 ' Use department-specific count and increment for display.

        Dim registrationYear As String = (DateTime.Now.Year Mod 100).ToString("D2")

        Select Case selectedDepartment
            Case "Accounting"
                departmentCode = "AC"
            Case "Computer Science"
                departmentCode = "CS"
            Case "Management"
                departmentCode = "MG"
            Case "Business Administration"
                departmentCode = "BA"
            Case "Marketing"
                departmentCode = "MR"
            Case Else
                Return ' Exit if no valid department found.
        End Select

        Dim divisionCode As String = If(regular.Checked, "R", If(extension.Checked, "E", "W"))

        Dim studentNumberFormatted As String = studentNumber.ToString("D4") ' Format number as D4.

        Dim generatedID As String = String.Format("{0}{1}/{2}/{3}", departmentCode, divisionCode, studentNumberFormatted, registrationYear)

        ' Display the generated ID on the cmdid button.
        cmdid.Text = generatedID

        ' Set the flag to indicate that an ID has been generated.
        isGenerated = True

        ' Enable the Register button.
        cmdregistred.Enabled = True
    End Sub

    Private Sub cmdid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdid.Click
        GenerateID()
    End Sub

End Class