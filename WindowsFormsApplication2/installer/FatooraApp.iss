; =============================================================
; FatooraApp Installer - Inno Setup Script
; =============================================================
; Prerequisites:
;   1. Install Inno Setup 6 from https://jrsoftware.org/isdl.php
;   2. Build the project in Release mode
;   3. Place SqlLocalDB.msi in the installer folder
;   4. Run export_schema.sql and create setup_database.sql
;   5. Open this file in Inno Setup Compiler and click Build
; =============================================================

#define MyAppName "shark"
#define MyAppNameAr "القرش لخدمات المحمول"
#define MyAppVersion "1.0"
#define MyAppPublisher "FatooraApp"
#define MyAppExeName "WindowsFormsApplication2.exe"

[Setup]
AppId={{A1B2C3D4-E5F6-7890-ABCD-EF1234567890}
AppName={#MyAppNameAr}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppNameAr}
AllowNoIcons=yes
OutputDir=..\installer_output
OutputBaseFilename=FatooraApp_Setup
Compression=lzma2/ultra64
SolidCompression=yes
PrivilegesRequired=admin
WizardStyle=modern
SetupIconFile=..\Resources\logo_trans.ico

[Languages]
Name: "arabic"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "Create Desktop Shortcut"; GroupDescription: "Additional:"

[Files]
; Application files (from Release build output)
Source: "..\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

; Database setup files
Source: "setup_database.sql"; DestDir: "{app}\dbsetup"; Flags: ignoreversion
Source: "seed_data.sql"; DestDir: "{app}\dbsetup"; Flags: ignoreversion
Source: "DatabaseSetup.bat"; DestDir: "{app}\dbsetup"; Flags: ignoreversion
Source: "DatabaseSetup.ps1"; DestDir: "{app}\dbsetup"; Flags: ignoreversion

; SQL Server LocalDB installer (download from Microsoft)
; https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb
Source: "SqlLocalDB.msi"; DestDir: "{tmp}"; Flags: ignoreversion; Check: not IsLocalDBInstalled

[Icons]
Name: "{group}\{#MyAppNameAr}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppNameAr}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
; Install LocalDB silently if not already installed
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\SqlLocalDB.msi"" /qn IACCEPTSQLLOCALDBLICENSETERMS=YES"; \
  StatusMsg: "Installing SQL Server LocalDB..."; Flags: waituntilterminated; Check: not IsLocalDBInstalled

; Database setup runs automatically on first app launch (as the current user)
; This avoids LocalDB per-user isolation issues when installer runs as admin

; Launch app after install
Filename: "{app}\{#MyAppExeName}"; Description: "Launch FatooraApp"; Flags: nowait postinstall skipifsilent

[UninstallDelete]
Type: filesandordirs; Name: "{app}\dbsetup"

[Code]
// Check if SQL Server LocalDB is already installed
function IsLocalDBInstalled: Boolean;
var
  ResultCode: Integer;
begin
  Result := RegKeyExists(HKLM, 'SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\15.0') or
            RegKeyExists(HKLM, 'SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\14.0') or
            RegKeyExists(HKLM, 'SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\13.0');

  if not Result then
  begin
    // Also check if sqllocaldb.exe exists in PATH
    Result := Exec('sqllocaldb.exe', 'info', '', SW_HIDE, ewWaitUntilTerminated, ResultCode) and (ResultCode = 0);
  end;
end;

// Check if .NET Framework 4.8 is installed
function IsDotNet48Installed: Boolean;
var
  Release: Cardinal;
begin
  Result := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', Release) and (Release >= 528040);
end;

function InitializeSetup: Boolean;
begin
  Result := True;

  // Check .NET Framework
  if not IsDotNet48Installed then
  begin
    MsgBox('This application requires .NET Framework 4.8.'#13#10 +
           'Please install it from Microsoft website and run this installer again.',
           mbError, MB_OK);
    Result := False;
  end;
end;
