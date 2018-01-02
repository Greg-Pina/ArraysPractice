' **************************************************************************
' <name>
' <date>
' This program shows how to use parrallel  arrays. There are 3 items in each
' array storing a student's name, ther total grade and how many grades entered
' This will allow calculation of an average grade
' **************************************************************************

Option Explicit On

Public Class Form1

   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strName As String ' variable for students name
        Dim dblGrade As Double ' variable for an entered grade

        txtGrade.BackColor = Color.White

        Try

            If Validation(txtGrade.Text, dblGrade) = True Then

               

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub AddGrade(ByVal Grade As Double, ByVal Name As String)
        ' add entered grade into array
    

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click

        ' figure out student's average
        Dim strAverage As String

     


        Display(strAverage) ' pass the output string to the sub to display it

    End Sub

    Public Function Validation(ByVal Grade As String, ByRef GradeNumber As Double) As Boolean

        ' validate grade is numeric
        If IsNumeric(Grade) Then
            GradeNumber = CDbl(Grade)
        Else
            MessageBox.Show("Please enter numbers only for grade.")
            txtGrade.BackColor = Color.Yellow
            txtGrade.Focus()
            Return False ' return false if there is an issue
        End If

        ' validate a name is selected
        If cboName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a name.")
            Return False  ' return false if there is an issue
        End If

        ' return true if everything is ok
        Return True

    End Function

    Public Sub Display(ByVal Output As String)

        MessageBox.Show(Output)

    End Sub

End Class
