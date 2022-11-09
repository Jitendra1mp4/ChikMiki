@echo off
set tempFilePath=%1
codeFormater\clang-format.exe -i --style="{BasedOnStyle: microsoft,IndentWidth: 4}" %tempFilePath%
