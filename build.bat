@echo off

C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\msbuild.exe /p:Platform=x86 /p:Configuration=Release src\rtext.x86.csproj
C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\msbuild.exe /p:Platform=x64 /p:Configuration=Release src\rtext.x64.csproj
