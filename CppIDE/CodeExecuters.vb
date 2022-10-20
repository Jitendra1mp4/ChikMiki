Public Class CodeExecuters

    Const compilerLoaction As String = "MinGW\bin\"
    Const runnerCommand = "Executers\codeRunner.bat"
    Const compilerCommand = "Executers\codeCompiler.bat"
    Const codeFormater As String = "codeFormater\codeFormater.bat"
    Public Const formatedOutputLocation As String = "codeFormater\"
    Public Const formatedOutputFileName As String = "formatedCode.out"
    Public Const FormatedOutputPath As String = formatedOutputLocation + formatedOutputFileName

    'Shared alreadyRemoved As Boolean = False


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
         Dim outputPath As String

        If ((Editor.CodeBox.Text.IndexOf("clrscr")) > -1 And (Editor.CodeBox.Text.IndexOf("// clrscr") = -1)) Then
            Editor.CodeBox.Text = Editor.CodeBox.Text.Replace("clrscr", "// clrscr")
            'alreadyRemoved = True
        End If

        'Editor.butifyCode() 'user may not able to undo code 

        CodeEditor.fileManipulation.saveFile(CodeEditor.fileManipulation.tempFilePath)
        Dim inputPath As String

        'Setting input path
        If fileManipulation.filePath <> "\0" Then
            fileManipulation.saver()
            inputPath = CodeEditor.fileManipulation.filePath
        Else
            inputPath = CodeEditor.fileManipulation.tempFilePath
        End If
        'setting output path
        If CodeEditor.fileManipulation.Saved Then
            outputPath = CodeEditor.fileManipulation.setFileExtension(CodeEditor.fileManipulation.filePath, "exe")
        Else
            outputPath = CodeEditor.fileManipulation.setFileExtension(CodeEditor.fileManipulation.tempFilePath, "exe")
        End If

        inputPath = CodeEditor.fileManipulation.putInsideDoubleQuouts(inputPath)
        outputPath = CodeEditor.fileManipulation.putInsideDoubleQuouts(outputPath)

        'calling code runner function
        codeRunner(inputPath, outputPath, compileOnly)
        'Editor.CodeBox.Text = inputPath & Environment.NewLine & outputPath
    End Sub


    Shared Sub formateCode(ByVal filePath As String)
        Const comd As String = codeFormater
        Dim arguments As String = filePath + " " + FormatedOutputPath
        'Editor.CodeBox.Text = comd + arguments
        MyUtilities.RunCommandCom(comd, arguments, False)
    End Sub

End Class
