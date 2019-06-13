cd /d %~dp0
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe Nat123Service.exe
Net Start Nat123Service
sc config Nat123Service start= auto
start Nat123Service.exe -nat