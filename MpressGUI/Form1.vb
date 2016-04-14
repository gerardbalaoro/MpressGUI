Imports System.Text

Public Class MainFrm
    'Declarations
    Dim fileImp As New OpenFileDialog
    Dim Expfile As New SaveFileDialog
    Dim bin As String = "MpressGUI\bin"
    Dim output As String = bin & "\" & fileImp.SafeFileName.ToString
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IO.Directory.CreateDirectory("MpressGUI").Attributes = IO.FileAttributes.Hidden
        IO.Directory.CreateDirectory(bin)
        IO.File.WriteAllBytes(bin & "\mpress.exe", My.Resources.mpress)
        Import.AllowDrop = True
    End Sub
    Private Sub Import_File()
        Try
            IO.File.Copy(OrigFile.Text, bin & "\" & fileImp.SafeFileName.ToString, True)
        Catch e As IO.IOException
        End Try
    End Sub
    Private Sub Export_File()
        IO.File.Copy(bin & "\" & fileImp.SafeFileName.ToString, OutFile.Text, True)
        Dim backuplocation As String = IO.Path.GetDirectoryName(Expfile.FileName) & "\" & fileImp.SafeFileName.ToString & ".bak"
        If b.CheckState = CheckState.Checked Then
            IO.File.Copy(bin & "\" & fileImp.SafeFileName & ".bak", backuplocation, True)
        End If

    End Sub

    Private Sub Compress_File()
        Dim filename As String = """" & fileImp.SafeFileName & """"
        Dim options As New TextBox
        options.Text = " "

        'ignore compression result
        If i.CheckState = CheckState.Checked Then
            options.AppendText("-i ")
        Else
            options.Text.Replace("-i ", Nothing)
        End If
        'make backup
        If b.CheckState = CheckState.Checked Then
            options.AppendText("-b ")
        Else
            options.Text.Replace("-b ", Nothing)
        End If
        'dont merge exceptions
        If lowerx.CheckState = CheckState.Checked Then
            options.AppendText("-x ")
        Else
            options.Text.Replace("-x", Nothing)
        End If
        'do not patch
        If uppers.CheckState = CheckState.Checked Then
            options.AppendText("-S ")
        Else
            options.Text.Replace("-S", Nothing)
        End If
        'unsupported architectures
        If u.CheckState = CheckState.Checked Then
            options.AppendText("-u ")
        Else
            options.Text.Replace("-u ", Nothing)
        End If
        'force LZMAT
        If m.CheckState = CheckState.Checked Then
            options.AppendText("-m ")
        Else
            options.Text.Replace("-m ", Nothing)
        End If
        'dont compress resources
        If r.CheckState = CheckState.Checked Then
            options.AppendText("-r ")
        Else
            options.Text.Replace("-r ", Nothing)
        End If
        'find best LZMA Parameters
        If lowers.CheckState = CheckState.Checked Then
            options.AppendText("-s ")
        Else
            options.Text.Replace("-s ", Nothing)
        End If
        'short license
        If upperL.CheckState = CheckState.Checked Then
            options.AppendText("-L ")
        Else
            options.Text.Replace("-L ", Nothing)
        End If

        Dim command As String = "mpress.exe " & filename & options.Text


        Dim con As New Process
        Dim info As New System.Diagnostics.ProcessStartInfo
        info.FileName = "cmd.exe"
        info.Arguments = "/k cd mpressgui\bin"
        info.UseShellExecute = False
        info.CreateNoWindow = True
        info.RedirectStandardInput = True
        info.RedirectStandardError = True
        info.RedirectStandardOutput = True
        con.StartInfo = info
        con.Start()
        Dim Inpt As System.IO.StreamWriter = con.StandardInput
        Dim Outpt As System.IO.StreamReader = con.StandardOutput
        Dim Err As IO.StreamReader = con.StandardError

        Inpt.WriteLine("echo off")
        Inpt.WriteLine(command)
        Inpt.WriteLine("exit")
        Inpt.Close()

        Dim outputlog As String
        Dim errlog As String
        outputlog = Outpt.ReadToEnd
        errlog = Err.ReadToEnd
        If errlog <> Nothing Then
            MsgBox(errlog, MsgBoxStyle.Critical)
        Else
            MsgBox("Compression Complete! Check the log below for details.")
        End If
        Export_File()
        Log.Text = outputlog
        If Log.Text.Length <> 0 Then
            Log.Text = Log.Text.Substring(0, Log.Text.Length - 7)
        End If
        
        Log.SelectionLength = Log.Text.Length
        Log.ScrollToCaret()
        Outpt.Close()
        Err.Close()
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        fileImp.Filter = "All Supported Formats|*.exe;*.dll;*.Net;*.app;*.mach-o;*.ub;*.OCX|Executable Files (.exe)|*.exe|Libraries (.dll)|*.dll|.Net Applications (.NET)|.Net|Darwin-mac OSX Applications|*.app;*.mach-o|Universal Binary OSX Applications|*.ub"
        fileImp.Multiselect = False
        If fileImp.ShowDialog = Windows.Forms.DialogResult.OK Then
            OrigFile.Text = fileImp.FileName.ToString
        End If
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Expfile.Title = "Save Output As"
        Dim extfil As String = IO.Path.GetExtension(fileImp.FileName)
        Expfile.Filter = "All Supported Formats|*.exe;*.dll;*.Net;*.app;*.mach-o;*.ub;*.OCX|Executable Files (.exe)|*.exe|Libraries (.dll)|*.dll|.Net Applications (.NET)|.Net|Darwin-mac OSX Applications|*.app;*.mach-o|Universal Binary OSX Applications|*.ub"
        Expfile.FileName = fileImp.SafeFileName
        If Expfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            OutFile.Text = Expfile.FileName.ToString
        End If
    End Sub

    Private Sub Compress_Click(sender As Object, e As EventArgs) Handles Compress.Click
        If OrigFile.Text = Nothing Then
            MsgBox("No File Selected.", MsgBoxStyle.DefaultButton1)
        ElseIf My.Computer.FileSystem.FileExists(OrigFile.Text) = False Then
            MsgBox("Target file does not exist.")
        ElseIf OutFile.Text = Nothing Then
            MsgBox("No output file entered.", MsgBoxStyle.DefaultButton1)
        Else
            Import_File()
            Compress_File()
        End If
    End Sub

    Private Sub About_Open(sender As Object, e As EventArgs) Handles Aboutbtn.Click
        Dim abt = About
        abt.IsMdiContainer = False
        abt.StartPosition = FormStartPosition.Manual
        abt.Location = Me.Location
        abt.Show()
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles helpbtn.Click
        Cliver.Message.Ok("Help", Me.Icon, My.Resources.Help)
    End Sub

    Private Sub Cleanup_Closing(sender As Object, e As EventArgs) Handles Me.FormClosed
        If IO.Directory.Exists("MpressGUI") Then
            My.Computer.FileSystem.DeleteDirectory("MpressGUI", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub
End Class
