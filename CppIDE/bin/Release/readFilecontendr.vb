Module readFilecontendr
    Sub main()
        Const configurationFile As String = "Configuration\configure.conf"
        FileOpen(1, configurationFile, OpenMode.Random)
    End Sub
End Module
