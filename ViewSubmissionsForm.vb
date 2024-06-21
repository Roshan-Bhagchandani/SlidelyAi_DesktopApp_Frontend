Imports System.Threading.Tasks

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0
    Private apiService As ApiService = New ApiService()

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        ShowSubmission()
        Me.KeyPreview = True


    End Sub

    Private Async Function LoadSubmissions() As Task
        submissions = New List(Of Submission)()

        Dim index As Integer = 0
        While True
            Try
                Dim submission = Await apiService.GetSubmission(index)
                submissions.Add(submission)
                index += 1
            Catch ex As Exception
                Exit While
            End Try
        End While
    End Function

    Private Sub ShowSubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            lblName.Text = submission.name
            lblEmail.Text = submission.email
            lblPhone.Text = submission.phone
            lblGithubLink.Text = submission.github_link
            lblStopwatchTime.Text = submission.stopwatch_time.ToString()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
            e.Handled = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class
