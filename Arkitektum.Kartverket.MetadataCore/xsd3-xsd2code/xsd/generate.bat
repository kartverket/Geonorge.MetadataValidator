@echo off

set XsdPath=C:\dev\test-schema
set OutPath=%XsdPath%\Code
set ExePath="c:\Program Files (x86)\Xsd2Code\Xsd2Code.exe"
set Namespace=www.opengis.net.csw

echo.Starting processing XSD files ...
for /f %%a IN ('dir %XsdPath%\*.xsd /a-d /b /s') do call:ProcessXsd %%a

echo.Finished processing XSD files ...
echo.&pause&
goto:eof

:ProcessXsd
%ExePath% %~1 %Namespace% %XsdPath%\Code\%~n1%.cs /pl Net35 /if- /dc /sc /eit
echo.Processed %~n1
goto:eof