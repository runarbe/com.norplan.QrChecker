  ; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName GetStringFileInfo("..\QRcodeTool\bin\x86\Release\QRToolUI.exe", "ProductName")
#define MyAppVersion GetStringFileInfo("..\QRcodeTool\bin\x86\Release\QRToolUI.exe", "FileVersion")
#define MyAppPublisher GetStringFileInfo("..\QRcodeTool\bin\x86\Release\QRToolUI.exe", "CompanyName")
#define MyAppCopyright GetStringFileInfo("..\QRcodeTool\bin\x86\Release\QRToolUI.exe", "LegalCopyright")
#define MyAppURL "http://www.norplan.org"
#define MyAppExeName "QRToolUI.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{FE4034B1-0880-42B6-8F26-0305EAA73766}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir=Output
OutputBaseFilename={#MyAppName} {#MyAppVersion}
Compression=lzma2/normal
SolidCompression=yes
AppCopyright={#MyAppCopyright}
ShowLanguageDialog=no
VersionInfoVersion={#MyAppVersion}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\QRcodeTool\AppIcon.ico"; DestDir: "{app}"
Source: "..\QRcodeTool\bin\x86\Release\*"; DestDir: "{app}"; Flags: ignoreversion createallsubdirs recursesubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\AppIcon.ico"; IconIndex: 0
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\AppIcon.ico"; IconIndex: 0; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent