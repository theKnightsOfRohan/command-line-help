#!/bin/zsh

set -e

if ! command -v dotnet &>/dev/null; then
    echo ".NET sdk could not be found. Please install it and try again."
    echo "https://dotnet.microsoft.com/download/dotnet/7.0"
    echo "Install the SDK using the installer for your platform."
    echo "M1 Macbook Pros require the ARM64 version of the sdk."
    echo "Intel Chip Macbook Pros require the x64 version of the sdk."
    exit
fi

SCRIPT_DIR="$(
    cd "$(dirname "$0")"
    pwd
)"
ROOT_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"

echo "Testing project..."
dotnet build
dotnet test $ROOT_DIR/Program.Tests/Program.tests.csproj
echo "Project passed all tests."

echo "Building project..."
dotnet publish -c Release -r osx-x64 --self-contained true
echo "Project successfully built."

echo "Copying files..."
if [ ! -d /usr/local/bin/command-line-help ]; then
    sudo mkdir /usr/local/bin/command-line-help
fi
sudo cp -r $ROOT_DIR/Program/bin/Release/net7.0/osx-x64/publish/ /usr/local/bin/command-line-help
echo "Files successfully copied."

echo "Creating alias..."
cp ~/.zshrc ~/.zshrc.bak
echo "alias help='/usr/local/bin/command-line-help/Program'" | sudo tee -a ~/.zshrc
source ~/.zshrc

if ! command -v help &>/dev/null; then
    echo "Failed to create alias. Please try again."
    exit
fi

echo "Alias successfully created."

echo "Testing installation"
help --version

echo "Installation complete."
