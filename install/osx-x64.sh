#!/bin/zsh

set -e

if ! command -v dotnet &>/dev/null; then
    echo ".NET sdk could not be found. Please install it and try again."
    echo "https://dotnet.microsoft.com/download/dotnet/7.0"
    echo "Install the SDK using the installer for your platform."
    echo "M1 Macs require the ARM64 version of the sdk."
    echo "Intel Chip Macs require the x64 version of the sdk."
    exit
fi

SCRIPT_DIR="$(
    cd "$(dirname "$0")"
    pwd
)"
ROOT_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"

# Find the .Tests.csproj file
TestProjFile="$ROOT_DIR/Help.Tests/Help.Tests.csproj"
if [ -z "$TestProjFile" ]; then
    echo "No .Tests.csproj file found. Please check the structure of the project."
    exit 1
fi

echo "Building and testing project..."
dotnet build
if [ $? -ne 0 ]; then
    echo "Build failed. Please fix the issues and try again."
    exit 1
fi
dotnet test $TestProjFile
if [ $? -ne 0 ]; then
    echo "Tests failed. Please fix the issues and try again."
    exit 1
fi
echo "Project passed all tests."

echo "Releasing project..."
dotnet publish -c Release -r osx-x64 --self-contained true
if [ $? -ne 0 ]; then
    echo "Build failed. Please fix the issues and try again."
    exit 1
fi
echo "Project successfully built."

# Find the publish directory
PublishDir=$(find $ROOT_DIR -name "publish" | head -n 1)
if [ -z "$PublishDir" ]; then
    echo "No publish directory found. Please check the build output."
    exit 1
fi

echo "Copying files..."
if [ ! -d /usr/local/bin/command-line-help ]; then
    echo "Creating directory in /usr/local/bin"
    sudo mkdir /usr/local/bin/command-line-help
elif [ "$(ls -A /usr/local/bin/command-line-help)" ]; then
    echo "Removing old files..."
    sudo rm -r /usr/local/bin/command-line-help/*
fi
sudo cp -r $PublishDir/* /usr/local/bin/command-line-help
echo "Files successfully copied."

echo "Creating alias..."
cp ~/.zshrc ~/.zshrc.bak

# Check if the alias already exists in .zshrc
if grep -q "alias help='/usr/local/bin/command-line-help/Help'" ~/.zshrc; then
    echo "Alias already exists in .zshrc. Skipping..."
else
    echo "Adding alias to .zshrc..."
    echo "alias help='/usr/local/bin/command-line-help/Help'" | sudo tee -a ~/.zshrc

    if [! grep -q "alias help='/usr/local/bin/command-line-help/Help'" ~/.zshrc]; then
        echo "Failed to create alias. Please try again, or manually add the alias to your .zshrc file."
        exit
    fi
fi

echo "Alias successfully created."

echo "Installation complete. To test the installation, run 'help' in your terminal."
source ~/.zshrc
