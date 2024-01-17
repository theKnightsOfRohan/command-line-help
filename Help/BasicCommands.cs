using System;
using System.Collections.Generic;

namespace Help;
internal static class BasicCommands
{
    public static string BasicOverview(string command)
    {
        if (command == "v")
        {
            return "Help version $(Version)";
        }
        if (command == "V")
        {
            return "TODO: Add verbose output as detailed explanation of command line concepts.";
        }
        else if (command == "c")
        {
            return "TODO: Add list of commands.";
        }
        else
        {
            string output = "";
            if (command != "")
            {
                output += "Error: Command \"" + command + "\" not found.\n\n";
            }
            return output + "TODO: Add basic overview of tool.";
        }
    }
    public static Dictionary<string, Dictionary<string, string>> CommandExplanations = new()
    {
        {"ls", new(){
            {"", @"
The ls command lists the contents of the current directory.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.

We could run ""ls"" to list the contents of MyProject. This command would output:

src" + "\t" + @"lib" + "\t" + @"build.gradle" + "\t" + @"settings.gradle" + "\t" + @"README.md

You can also specify a directory to list the current contents of that directory.
For example, if we wanted to list the contents of the ""src"" directory, we could run ""ls src/main"". This command would output:

java" + "\t" + @"resources

For more information about this command, run the command ""help ls --verbose""."
            },
            {"V", "TODO: Add verbose output for \"ls\""},
        }},
        {"cd", new(){
            {"",@"
The cd command changes the current working directory.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""cd src"" to change the current working directory to ""src"".
This command would output nothing, but you can look at your current working directory on the left to see that it has changed.

For more information about this command, run the command ""help cd --verbose""."
    },
            {"V", "TODO: Add verbose output for \"cd\""},
        }},
                {"mkdir", new(){
                    {"", @"
The mkdir command creates a new directory.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""mkdir src/main/java"" to create a new directory ""java"" in the ""src/main"" directory.
This command would output nothing, but you can look at the file structure on the left to see that it has changed.

For more information about this command, run the command ""help mkdir --verbose""." },
                    {"V", "TODO: Add verbose output for \"mkdir\""},
                }},
                {"touch", new(){
                    {"",@"
The touch command creates a new file.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""touch src/main/java/App.java"" to create a new file ""App.java"" in the ""src/main/java"" directory.
This command would output nothing, but you can look at the file structure on the left to see that it has changed.

For more information about this command, run the command ""help touch --verbose""."
                    },
                    {"V", "TODO: Add verbose output for \"touch\""},
                }},
        {"rm", new(){
                    {"",@"
The rm command removes a file or directory.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""rm src/main/java/App.java"" to remove the file ""App.java"" in the ""src/main/java"" directory.
This command would output nothing, but you can look at the file structure on the left to see that it has changed.

For more information about this command, run the command ""help rm --verbose""." },
                    {"V", "TODO: Add verbose output for \"rm\""},
                }},
        {"cp", new(){
                    {"", @"
The cp command copies a file or directory.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""cp src/main/java/App.java src/main/java/AppCopy.java"" to copy the file ""App.java"" in the ""src/main/java"" directory to ""AppCopy.java"".
This command would output nothing, but you can look at the file structure on the left to see that it has changed.

For more information about this command, run the command ""help cp --verbose""." },
                    {"V", "TODO: Add verbose output for \"cp\""},
                }},
                {"mv", new(){
                    {"",@"
The mv command moves or renames a file or directory.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""mv src/main/java/App.java src/main/java/AppCopy.java"" to move the file ""App.java"" in the ""src/main/java"" directory to ""AppCopy.java"".
This command would output nothing, but you can look at the file structure on the left to see that it has changed.
For more information about this command, run the command ""help mv --verbose""." },
                    {"V", "TODO: Add verbose output for \"mv\""},
                }},
                {"cat", new(){
                    {"",@"
The cat command displays the contents of a file.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""cat src/main/java/App.java"" to display the contents of the file ""App.java"" in the ""src/main/java"" directory.
This command would output:

public class App {
    public static void main(String[] args) {
        System.out.println(""Hello World!"");
    }
}

For more information about this command, run the command ""help cat --verbose""." },
                    {"V", "TODO: Add verbose output for \"cat\""},
                }},
        {"grep", new(){
                    {"",@"
The grep command searches for a pattern in a file.
For example, if we had a directory ""MyProject"" in our current directory, with the file structure:

MyProject
├── src
│   ├── main
│   │   ├── java
│   │   │   ├── App.java
│   │   │   └── Utils.java
│   │   └── resources
│   │       └── config.properties
│   └── test
│       ├── java
│       │   ├── AppTest.java
│       │   └── UtilsTest.java
│       └── resources
│           └── test.properties
├── lib
│   └── helper.jar
├── build.gradle
├── settings.gradle
└── README.md

We could run ""grep ""Hello World"" src/main/java/App.java"" to search for the pattern ""Hello World"" in the file ""App.java"" in the ""src/main/java"" directory.
This command would output:

Hello World!

For more information about this command, run the command ""help grep --verbose""." },
                    {"V", "TODO: Add verbose output for \"grep\""},
                }},
                {"echo", new(){
                    {"",@"
The echo command prints text to the terminal.
For example, we could run ""echo Hello World!"" to print ""Hello World!"" to the terminal.
This command would output:

Hello World!

For more information about this command, run the command ""help echo --verbose""." },
                    {"V", "TODO: Add verbose output for \"echo\""},
                }},
                {"chmod", new(){
                    {"",@"
The chmod command changes the permissions of a file or directory.
For example, we could run ""chmod 777 src/main/java/App.java"" to change the permissions of the file ""App.java"" in the ""src/main/java"" directory to ""777"".
This command would output nothing, but you can look at the file structure on the left to see that it has changed.
For more information about this command, run the command ""help chmod --verbose""." },
                    {"V", "TODO: Add verbose output for \"chmod\""},
                }},
                {"sudo", new(){
                    {"",@"
The sudo command runs a command with administrative privileges.
For example, we could run ""sudo rm src/main/java/App.java"" to remove the file ""App.java"" in the ""src/main/java"" directory with administrative privileges.
This command would output nothing, but you can look at the file structure on the left to see that it has changed.
For more information about this command, run the command ""help sudo --verbose""." },
                    {"V", "TODO: Add verbose output for \"sudo\""},
                }},
    };
}