Public Class CodeExecuters

    Const compilerLoaction As String = "MinGW\bin\"
    Const runnerCommand = "Executers\codeRunner.bat"
    Const compilerCommand = "Executers\codeCompiler.bat"



    Shared Sub codeRunner(ByVal inputPath As String, ByVal outputPath As String, ByVal compileOnly As Boolean)
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

    Shared Sub callCodeRunner(ByVal compileOnly As Boolean)
        CodeEditor.fileManipulation.saveFile(CodeEditor.fileManipulation.tempFilePath)

        Dim inputPath As String

        'Setting input path
        If fileManipulation.filePath <> "\0" Then
            fileManipulation.saver()
            inputPath = CodeEditor.fileManipulation.putInsideDoubleQuouts(CodeEditor.fileManipulation.filePath)
        Else
            inputPath = CodeEditor.fileManipulation.putInsideDoubleQuouts(CodeEditor.fileManipulation.tempFilePath)
        End If

        'setting output path
        If CodeEditor.fileManipulation.Saved Then
            outputPath = CodeEditor.fileManipulation.setFileExtension(CodeEditor.fileManipulation.filePath, "exe")
        Else
            outputPath = CodeEditor.fileManipulation.setFileExtension(CodeEditor.fileManipulation.tempFilePath, "exe")
        End If
        outputPath = CodeEditor.fileManipulation.putInsideDoubleQuouts(outputPath)
        'calling code runner function
        codeRunner(inputPath, outputPath, compileOnly)
        'CodeBox.Text = inputPath & "   ***   " & outputPath
    End Sub


End Class
