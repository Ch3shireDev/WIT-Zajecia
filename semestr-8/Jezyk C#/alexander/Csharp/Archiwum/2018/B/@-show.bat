@echo off
setlocal EnableDelayedExpansion
powershell -Command $pword = read-host "Enter password" -AsSecureString ; $BSTR=[System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($pword) ; [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($BSTR) > .@ 
set /p password=<.@>nul
if exist .@ del .@
for %%i in (%*) do (
  set name=%%i
  set part=!name:P:\Barski\=/opt/windows/staf/Barski/!
  set unix=!part:\=/!
  echo chmod 777 !unix! > .@
  "c:\Program Files (x86)\PuTTY\putty.exe" -ssh alex@oceanic -pw %password% -m .@
)
set password=
if exist .@ del .@