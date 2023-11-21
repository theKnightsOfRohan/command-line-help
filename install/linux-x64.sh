#!/bin/bash

set -e

if ! command -v dotnet &>/dev/null; then
    echo ".NET sdk could not be found. Please install it and try again."
    echo "https://dotnet.microsoft.com/download/dotnet/7.0"
    echo "Install the SDK using the installer for your platform."
    exit
fi

SCRIPT_DIR="$(dirname "$(readlink -f "$0")")"
ROOT_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"

# Find the .Tests.csproj file
TestProjFile="$ROOT_DIR/Program.Tests/Program.Tests.csproj"
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
dotnet publish -c Release -r linux-x64 --self-contained true
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
cp ~/.bashrc ~/.bashrc.bak
echo "alias help='/usr/local/bin/command-line-help/Program'" | sudo tee -a ~/.bashrc
source ~/.bashrc

if ! command -v help &>/dev/null; then
    echo "Failed to create alias. Please try again."
    exit
fi

echo "Alias successfully created."

echo "Installation complete. To test the installation, run 'help' in your terminal."
source ~/.bashrc
