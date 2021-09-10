Imports System.Data.SqlClient

Public Class WebFormSample
    Inherits System.Web.UI.Page
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myConn = New SqlConnection("Data Source=(local);Initial Catalog=GotchaSprintOne;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT username, realname, place FROM Users"

        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbTab &
    myReader.GetString(1) & vbTab &
    myReader.GetString(2) & vbLf
        Loop
        MsgBox(results)
        myReader.Close()
        myConn.Close()
        TestLabelX.Text = results

    End Sub

    Protected Sub ButtonSender_Click(sender As Object, e As EventArgs)

    End Sub
End Class