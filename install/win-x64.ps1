#!pwsh

# Check if .NET SDK is installed
if (!(Get-Command dotnet -ErrorAction SilentlyContinue)) {
    Write-Host "The .NET SDK is not installed. Please install it and try again."
    Write-Host "https://dotnet.microsoft.com/download/dotnet/7.0"
    exit 1
}

# Get the directory of the script
$SCRIPT_DIR = Split-Path $MyInvocation.MyCommand.Path -Parent
$ROOT_DIR = Resolve-Path "$SCRIPT_DIR\.."

# Find the .Tests.csproj file
$CSProjFile =  Resolve-Path "$ROOT_DIR\Program.Tests\Program.Tests.csproj"
if (!$CSProjFile) {
    Write-Host "No .Tests.csproj file found. Please check the structure of the project."
    exit 1
}

Write-Host "Testing project..."
dotnet build
dotnet test $CSProjFile
if ($LASTEXITCODE -ne 0) {
    Write-Host "Tests failed. Please fix the issues and try again."
    exit 1
}
Write-Host "Project passed all tests."

Write-Host "Building project..."
dotnet publish -c Release -r win-x64 --self-contained true
if ($LASTEXITCODE -ne 0) {
    Write-Host "Build failed. Please fix the issues and try again."
    exit 1
}
Write-Host "Project successfully built."

# Find the publish directory
$PublishDir = "$ROOT_DIR\Program\bin\Release\net7.0\win-x64\publish"
if (!$PublishDir) {
    Write-Host "No publish directory found. Please check the build output."
    exit 1
}

Write-Host "Copying files..."
$InstallDir = "C:\Program Files\command-line-help"
if (!(Test-Path -Path $InstallDir)) {
    New-Item -ItemType Directory -Path $InstallDir
}
Copy-Item -Path "$PublishDir\*" -Destination $InstallDir -Recurse -Force
Write-Host "Files successfully copied."

Write-Host "Adding to PATH..."
$env:Path += ";$InstallDir"
[System.Environment]::SetEnvironmentVariable("Path", $env:Path, [System.EnvironmentVariableTarget]::Machine)
Write-Host "Path successfully updated."

Write-Host "Installation complete. To test the installation, run `help` in a new session."