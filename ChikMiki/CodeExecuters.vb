Public Class CodeExecuters

    Const compilerLoaction As String = "MinGW\bin\"

    Enum languageMode
        C
        Cpp
    End Enum

    Const CRnrCmd As String = "Executers\cCodeRunner.bat"
    Const CcompilerCmd As String = "Executers\cCodeCompiler.bat"

    Const CppRnrCmd As String = "Executers\cppCodeRunner.bat"
    Const CppcompilerCmd As String = "Executers\cppCodeCompiler.bat"

    Const tempFileLocation As String = "Executers\Helper\"
    Const tempFileName As String = "tempCodeRunnerFile.cpp"
    Const tempFilePath As String = tempFileLocation + tempFileName

    Public programArgs As String = ""

    Public languageMD As languageMode = languageMode.C

    Private _editor As Editor

    Sub New(ByRef edtr As Editor)
         _editor = edtr
    End Sub

    Public Sub codeRunner(ByRef CodeBox As RichTextBox, ByVal inputPath As String, ByVal compileOnly As Boolean)

        Dim runnerCommand As String
        Dim compilerCommand As String

        If languageMD = languageMode.C Then
            runnerCommand = CRnrCmd
            compilerCommand = CcompilerCmd
        ElseIf (languageMD = languageMode.Cpp) Then
            runnerCommand = CppRnrCmd
            compilerCommand = CppcompilerCmd
        End If

        Dim outputPath As String = inputPath
        If (inputPath = "\0") Then
            saveFile()
            inputPath = tempFilePath
            outputPath = tempFilePath
        End If

        inputPath = MyUtilities.putInsideDoubleQuouts(inputPath)
        outputPath = MyUtilities.putInsideDoubleQuouts(MyUtilities.setFileExtension(outputPath, "exe"))

        Dim arguments As String = compilerLoaction + " " + inputPath + " " + outputPath

        If compileOnly Then
            MyUtilities.RunCommandCom(compilerCommand, arguments, False)
        Else
            arguments = arguments + " " + programArgs
            MyUtilities.RunCommandCom(runnerCommand, arguments, False)
        End If

    End Sub

    Private Function saveFile() As Boolean
        _editor.CodeBox.SaveFile(tempFilePath, RichTextBoxStreamType.PlainText)
        saveFile = True
    End Function

    Public Sub butifyCode()
        saveFile() 'saving file to tempPath
        MyUtilities.formateCode(tempFilePath) 'formating code
        _editor.CodeBox.LoadFile(tempFilePath, RichTextBoxStreamType.PlainText) 'Add formated code to codeBox
        _editor.EventMessage.Text = "Code Beautified..."
        _editor.AddLineNumbers()
        _editor.BringToFront()
    End Sub
End Class
