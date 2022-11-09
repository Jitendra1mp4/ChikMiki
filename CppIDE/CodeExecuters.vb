Public Class CodeExecuters

    Const compilerLoaction As String = "MinGW\bin\"
    Const runnerCommand = "Executers\codeRunner.bat"
    Const compilerCommand = "Executers\codeCompiler.bat"

    Const tempFileLocation As String = "Executers\Helper\"
    Const tempFileName As String = "tempCodeRunnerFile.cpp"
    Const tempFilePath As String = tempFileLocation + tempFileName

    Public programArgs As String = ""
    Private _editor As Editor

    Sub New(ByRef edtr As Editor)
        ' TODO: Complete member initialization 
        _editor = edtr
    End Sub

    Public Sub codeRunner(ByVal inputPath As String, ByVal compileOnly As Boolean)
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
        _editor.CodeBox.SaveFile(tempFilePath,RichTextBoxStreamType.PlainText)
        saveFile = True
    End Function

    Public Sub butifyCode()
        saveFile() 'saving file to tempPath
        MyUtilities.formateCode(tempFilePath) 'formating code
       _editor.CodeBox.LoadFile(tempFilePath, RichTextBoxStreamType.PlainText) 'Add formated code to codeBox
        _editor.EventMessage.Text = "Code Beautified..."
        _editor.AddLineNumbers()
    End Sub
End Class
