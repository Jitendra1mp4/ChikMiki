Public Class CodeExecuters

    Const compilerLoaction As String = "MinGW\bin\"
    Const runnerCommand = "Executers\codeRunner.bat"
    Const compilerCommand = "Executers\codeCompiler.bat"

    Const tempFileLocation As String = "Executers\Helper\"
    Const tempFileName As String = "tempCodeRunnerFile.cpp"
    Const tempFilePath As String = tempFileLocation + tempFileName

    Public programArgs As String = ""
    Private inputPath As String
    Private _editor As Editor

    Sub New(ByRef edtr As Editor, ByVal filePath As String)
        ' TODO: Complete member initialization 
        inputPath = filePath
        _editor = edtr
    End Sub

    Public Sub codeRunner(ByVal Saved As Boolean, ByVal compileOnly As Boolean)
        Dim outputPath As String = inputPath
        If (Not Saved) Then
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
        My.Computer.FileSystem.WriteAllText _
            (tempFilePath, _editor.CodeBox.Text, False)
        saveFile = True
    End Function

    Public Sub butifyCode()
        saveFile() 'saving file to tempPath
        'adding formated code to codeBox
        _editor.CodeBox.Text = MyUtilities.formateCode(tempFilePath) 'formating code
    End Sub


End Class
