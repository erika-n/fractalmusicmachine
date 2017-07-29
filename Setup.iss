; Setup for Fractal Music Machine

[Setup]
AppName="Fractal Music Machine 1.0.5 (noimage)"
AppVersion=1.0.2
DefaultDirName="{pf}\Fractal Music Machine 1.0.5"
DefaultGroupName="Fractal Music Machine 1.0.2"
Compression=lzma2
SolidCompression=yes
UninstallDisplayName="Fractal Music Machine 1.0.5"
OutputBaseFilename="FractalMusicMachineSetup"

[Dirs]

Name: "{userdocs}\Fractal Music Machine\saved"; Flags: uninsneveruninstall
Name: "{userdocs}\Fractal Music Machine\sounds"; Flags: uninsneveruninstall

[Files]
Source: "FractalMusicMachine\bin\Release\*"; DestDir: "{app}"
Source: "DefaultContent\*"; DestDir: "{userdocs}\Fractal Music Machine"; Flags: recursesubdirs



[Icons]
Name: "{group}\Fractal Music Machine 1.0.2"; Filename: "{app}\FractalMusicMachine.exe"; WorkingDir: "{app}"
Name: "{group}\Uninstall"; Filename: "{uninstallexe}"
Name: "{group}\Saved Files"; Filename: "{userdocs}\Fractal Music Machine\saved"

