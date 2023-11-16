#!/bin/zsh
echo "Testing project..."
dotnet build
dotnet test Program.Tests/Program.tests.csproj
echo "Project passed all tests."

echo "Building project..."
dotnet publish -c Release -r osx-arm64 --self-contained true
echo "Project successfully built."

echo "Copying files..."
sudo mkdir /usr/local/bin/command-line-help
sudo cp -r Program/bin/Release/net7.0/osx-arm64/publish/ /usr/local/bin/command-line-help
echo "Files successfully copied."

echo "Creating alias..."
sudo echo "alias help='/usr/local/bin/command-line-help/Program'" >>~/.zshrc
echo "Alias successfully created."

echo "Testing installation"
source ~/.zshrc
help --version

echo "Installation complete."
