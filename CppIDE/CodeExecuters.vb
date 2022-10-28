Public Class CodeExecuters

    Const compilerLoaction As String = "MinGW\bin\"
    Const runnerCommand = "Executers\codeRunner.bat"
    Const compilerCommand = "Executers\codeCompiler.bat"

    Const tempFileLocation As String = "Executers\Helper\"
    Const tempFileName As String = "tempCodeRunnerFile.cpp"
    Const tempFilePath As String = tempFileLocation + tempFileName

    Const codeFormater As String = "codeFormater\codeFormater.bat"
    Const formatedOutputLocation As String = "codeFormater\"
    Const formatedOutputFileName As String = "formatedCode.out"
    Const FormatedOutputPath As String = formatedOutputLocation + formatedOutputFileName

    Private inputPath As String = "\0"

    'Shared alreadyRemoved As Boolean = False
    Public Sub CodeExecuters(ByVal input As String)
        inputPath = input
    End Sub

    Private Sub codeRunner(ByVal outputPath As String, ByVal compileOnly As Boolean)
        Dim arguments As String
        arguments = compilerLoaction + " " + inputPath + " " + outputPath
        If compileOnly Then
            MyUtilities.RunCommandCom(compilerCommand, arguments, False)
        Else
            arguments = arguments + " " + Editor.programArgs
            'Editor.CodeBox.Text = arguments
            MyUtilities.RunCommandCom(runnerCommand, arguments, False)
        End If

    End Sub

    Public Sub callCodeRunner(ByVal compileOnly As Boolean)
        Dim outputPath As String

        If ((Editor.CodeBox.Text.IndexOf("clrscr")) > -1 And (Editor.CodeBox.Text.IndexOf("// clrscr") = -1)) Then
            Editor.CodeBox.Text = Editor.CodeBox.Text.Replace("clrscr", "// clrscr")
            'alreadyRemoved = True
        End If

        'Editor.butifyCode() 'user may not able to undo code 

        saveFile()
        Dim inputPath As String

        'Setting input path
        If inputPath <> "\0" Then
            fileManipulator.saver()
            inputPath = inputPath
        Else
            inputPath = tempFilePath
        End If
        'setting output path
        If Alpha_C_CPP_IDE.fileManipulator.Saved Then
            outputPath = Alpha_C_CPP_IDE.fileManipulator.setFileExtension(Alpha_C_CPP_IDE.fileManipulator.filePath, "exe")
        Else
            outputPath = Alpha_C_CPP_IDE.fileManipulator.setFileExtension(Alpha_C_CPP_IDE.fileManipulator.tempFilePath, "exe")
        End If

        inputPath = Alpha_C_CPP_IDE.fileManipulator.putInsideDoubleQuouts(inputPath)
        outputPath = Alpha_C_CPP_IDE.fileManipulator.putInsideDoubleQuouts(outputPath)

        'calling code runner function
        codeRunner(outputPath, compileOnly)
        'Editor.CodeBox.Text = inputPath & Environment.NewLine & outputPath
    End Sub

    Private Function saveFile() As Boolean
        My.Computer.FileSystem.WriteAllText _
            (tempFilePath, Editor.CodeBox.Text, False)
        saveFile = True
    End Function

End Class
