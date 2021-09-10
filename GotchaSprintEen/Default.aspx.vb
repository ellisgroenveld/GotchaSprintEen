Imports System.Data.SqlClient

Public Class _Default
    Inherits System.Web.UI.Page
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As List(Of String)
    Private idresult As List(Of String)
    Private commander As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub loginButton_Click(sender As Object, e As EventArgs)
        myConn = New SqlConnection("Data Source=(local);Initial Catalog=GotchaSprintOne;Integrated Security=True")
        myCmd = myConn.CreateCommand
        commander = "Select username, userid FROM Users WHERE username='" + usernameInput.Text + "';"
        myCmd.CommandText = commander

        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            commander = myReader.GetString(0)
            results.Append(commander)
        Loop
        myReader.Close()
        myConn.Close()
        If results.Count = 1 Then
            Session("username") = results.First
            Session("userid") = idresult.First
            Response.Redirect("Home.aspx")
        End If


    End Sub
End Class