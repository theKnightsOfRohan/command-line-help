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

# Find the .csproj file
CSProjFile=$(find $ROOT_DIR -name "*.csproj" | head -n 1)
if [ -z "$CSProjFile" ]; then
    echo "No .csproj file found. Please check the structure of the project."
    exit 1
fi

echo "Testing project..."
dotnet build
dotnet test $CSProjFile
if [ $? -ne 0 ]; then
    echo "Tests failed. Please fix the issues and try again."
    exit 1
fi
echo "Project passed all tests."

echo "Building project..."
dotnet publish -c Release -r osx-arm64 --self-contained true
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
    sudo mkdir /usr/local/bin/command-line-help
fi
sudo cp -r $PublishDir/* /usr/local/bin/command-line-help
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
if [ $? -ne 0 ]; then
    echo "Installation test failed. Please check the installation."
    exit 1
fi

echo "Installation complete."
