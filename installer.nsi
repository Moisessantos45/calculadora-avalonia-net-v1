!include "MUI2.nsh"

!define MUI_ICON "Assets\icon.ico"
!define MUI_UNICON "Assets\icon.ico"

!define APPNAME "Calculadora"
!define APPVERSION "2.0"

Name "${APPNAME}"
OutFile "Calculadora-Setup.exe"
InstallDir "$PROGRAMFILES\Calculadora"
RequestExecutionLevel admin

!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_LANGUAGE "Spanish"

Section "Main"
  SetOutPath $INSTDIR
  
  # Copiar TODOS los archivos de publish-win (incluye runtime .NET y librerías nativas)
  File /r "publish-win\*.*"
  
  CreateShortcut "$DESKTOP\Calculadora.lnk" "$INSTDIR\Calculadora.exe"
  CreateDirectory "$SMPROGRAMS\Calculadora"
  CreateShortcut "$SMPROGRAMS\Calculadora\Calculadora.lnk" "$INSTDIR\Calculadora.exe"
  
  WriteUninstaller "$INSTDIR\Uninstall.exe"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "DisplayName" "${APPNAME}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "UninstallString" "$\"$INSTDIR\Uninstall.exe$\""
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "DisplayVersion" "${APPVERSION}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "Publisher" "Moises Santos"
SectionEnd

Section "Uninstall"
  Delete "$INSTDIR\*.*"
  RMDir "$INSTDIR"
  Delete "$DESKTOP\Calculadora.lnk"
  Delete "$SMPROGRAMS\Calculadora\Calculadora.lnk"
  RMDir "$SMPROGRAMS\Calculadora"
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}"
SectionEnd
