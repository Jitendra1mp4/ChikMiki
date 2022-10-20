@echo off
set tempFilePath=%1
set outputPath=%2
codeFormater\clang-format.exe %tempFilePath% > %outputPath%
