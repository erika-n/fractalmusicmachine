; Setup for Fractal Music Machine

[Setup]
AppName="Fractal Music Machine"
AppVersion=0.0.1
DefaultDirName="{pf}\Fractal Music Machine"
DefaultGroupName="Fractal Music Machine"
Compression=lzma2
SolidCompression=yes
UninstallDisplayName="Fractal Music Machine"
OutputBaseFilename="FractalMusicMachineSetup"

[Dirs]

Name: "{userdocs}\Fractal Music Machine\saved"; Flags: uninsneveruninstall
Name: "{userdocs}\Fractal Music Machine\sounds"; Flags: uninsneveruninstall

[Files]
Source: "FractalMusicMachine\bin\Release\*"; DestDir: "{app}"
Source: "DefaultContent\*"; DestDir: "{userdocs}\Fractal Music Machine"; Flags: recursesubdirs



[Icons]
Name: "{group}\Fractal Music Machine"; Filename: "{app}\FractalMusicMachine.exe"; WorkingDir: "{app}"
Name: "{group}\Uninstall"; Filename: "{uninstallexe}"
Name: "{group}\Saved Files"; Filename: "{userdocs}\Fractal Music Machine\saved"

