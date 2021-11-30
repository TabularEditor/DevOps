# Download URL for Tabular Editor portable:
$TabularEditorUrl = "https://github.com/TabularEditor/TabularEditor/releases/download/2.16.4/TabularEditor.Portable.zip" 

# Download destination (root of PowerShell script execution path):
$DownloadDestination = join-path (get-location) "TabularEditor.zip"

# Download from GitHub:
Invoke-WebRequest -Uri $TabularEditorUrl -OutFile $DownloadDestination

# Unzip Tabular Editor portable, and then delete the zip file:
Expand-Archive -Path $DownloadDestination -DestinationPath (get-location).Path
Remove-Item $DownloadDestination