!include MUI2.nsh
!define APPNAME "Calculadora"
!define APPVERSION "1.0"
!define APPDIR "publish-win"

Name "${APPNAME}"
OutFile "Calculadora-Setup.exe"
InstallDir "$PROGRAMFILES\Calculadora"
RequestExecutionLevel admin

!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_LANGUAGE "Spanish"

Section "Main"
  SetOutPath $INSTDIR
  File /r "${APPDIR}\*.*"
  CreateShortcut "$DESKTOP\Calculadora.lnk" "$INSTDIR\Calculadora.exe"
  CreateDirectory "$SMPROGRAMS\Calculadora"
  CreateShortcut "$SMPROGRAMS\Calculadora\Calculadora.lnk" "$INSTDIR\Calculadora.exe"
SectionEnd

Section "Uninstall"
  Delete "$INSTDIR\*.*"
  RMDir /r "$INSTDIR"
  Delete "$DESKTOP\Calculadora.lnk"
  Delete "$SMPROGRAMS\Calculadora\*.*"
  RMDir "$SMPROGRAMS\Calculadora"
SectionEnd
