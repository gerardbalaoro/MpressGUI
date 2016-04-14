Imports System.IO

Public Class About
    Private Sub license_Click(sender As Object, e As EventArgs) Handles license.Click
        Cliver.Message.Ok("License", MainFrm.Icon, My.Resources.license)

    End Sub

    Private Sub changelog_Click(sender As Object, e As EventArgs) Handles changelog.Click
        Cliver.Message.Ok("Mpress Version History", MainFrm.Icon, My.Resources.History)
    End Sub

    Private Sub faq_Click(sender As Object, e As EventArgs) Handles faq.Click
        Cliver.Message.Ok("Frequently Asked Questions", MainFrm.Icon, My.Resources.FAQ)

    End Sub

    Private Sub bugreport_Click(sender As Object, e As EventArgs) Handles bugreport.Click
        Cliver.Message.Ok("Bug Reporting", MainFrm.Icon, My.Resources.BugReport)

    End Sub
End Class