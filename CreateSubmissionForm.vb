Imports System.Diagnostics
Imports System.Threading.Tasks

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()
    Private apiService As ApiService = New ApiService()

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        txtStopwatch.Text = CInt(stopwatch.Elapsed.TotalSeconds)
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = CInt(stopwatch.Elapsed.TotalSeconds)
        }

        Try
            Await apiService.SubmitSubmission(submission)
            MessageBox.Show("Submission successful!")
        Catch ex As Exception
            MessageBox.Show("Error submitting form: " & ex.Message)
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
            e.Handled = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartStop.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub
End Class
