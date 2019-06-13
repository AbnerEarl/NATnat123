cd /d %~dp0
Net stop Nat123Service
taskkill /f /im Nat123Service.exe
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe /u Nat123Service.exe
