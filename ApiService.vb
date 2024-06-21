Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Threading.Tasks

Public Class ApiService
    Private client As HttpClient

    Public Sub New()
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000")
    End Sub

    Public Async Function SubmitSubmission(submission As Submission) As Task
        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync("/submit", content)
        response.EnsureSuccessStatusCode()
    End Function

    Public Async Function GetSubmission(index As Integer) As Task(Of Submission)
        Dim response = Await client.GetAsync($"/read?index={index}")
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of Submission)(json)
    End Function
End Class


Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As Integer
End Class