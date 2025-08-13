Dim message, title
message = "custom build system example"
title = "test"

' Бесконечный цикл
Do While True
    MsgBox message, vbOKOnly, title
    ' Задержка в 1 секунду (1000 миллисекунд) перед следующим сообщением
    WScript.Sleep 1000
Loop