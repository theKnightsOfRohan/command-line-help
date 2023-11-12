using System;
using System.Collections.Generic;

namespace Program;
internal static class BasicCommands
{
    public static Dictionary<string, string> CommandDictionary = new()
    {
        {"ls", "List directory contents"},
        {"cd", "Change the current working directory"},
        {"mkdir", "Create a new directory"},
        {"touch", "Create a new file"},
        {"rm", "Remove a file or directory"},
        {"cp", "Copy a file or directory"},
        {"mv", "Move or rename a file or directory"},
        {"cat", "Display the contents of a file"},
        {"grep", "Search for a pattern in a file"},
        {"echo", "Print text to the terminal"},
        {"chmod", "Change the permissions of a file or directory"},
        {"sudo", "Run a command with administrative privileges"}
    };

    public static Dictionary<string, Dictionary<string, string>> CommandExplanations = new()
    {
        {"ls", new(){
            {"","The ls command lists the contents of the current directory.\n" +
                "For example, if we had a directory \"MyProject\" in our current directory, with the file structure:\n\n"+
                "MyProject\n"+
                "├── src\n"+
                "│   ├── main\n"+
                "│   │   ├── java\n"+
                "│   │   │   ├── App.java\n"+
                "│   │   │   └── Utils.java\n"+
                "│   │   └── resources\n"+
                "│   │       └── config.properties\n"+
                "│   └── test\n"+
                "│       ├── java\n"+
                "│       │   ├── AppTest.java\n"+
                "│       │   └── UtilsTest.java\n"+
                "│       └── resources\n"+
                "│           └── test.properties\n"+
                "├── lib\n"+
                "│   └── helper.jar\n"+
                "├── build.gradle\n"+
                "├── settings.gradle\n"+
                "└── README.md"+
                "We could run \"ls\" to list the contents of MyProject. This command would output:\n\n"+
                "src\t\tlib\t\tbuild.gradle\tsettings.gradle\tREADME.md\n\n"+
                "You can also specify a directory to list the current contents of that directory.\n"+
                "For example, if we wanted to list the contents of the \"src\" directory, we could run \"ls src/main\". This command would output:\n\n"+
                "java\t\tresources\n\n"+
                "For more information about this command, run the command \"help ls --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"ls\""},
        }},
        {"cd", new(){
            {"","The cd command changes the current working directory.\n" +
                "For example, if we had a directory \"MyProject\" in our current directory, with the file structure:\n\n"+
                "MyProject\n"+
                "├── src\n"+
                "│   ├── main\n"+
                "│   │   ├── java\n"+
                "│   │   │   ├── App.java\n"+
                "│   │   │   └── Utils.java\n"+
                "│   │   └── resources\n"+
                "│   │       └── config.properties\n"+
                "│   └── test\n"+
                "│       ├── java\n"+
                "│       │   ├── AppTest.java\n"+
                "│       │   └── UtilsTest.java\n"+
                "│       └── resources\n"+
                "│           └── test.properties\n"+
                "├── lib\n"+
                "│   └── helper.jar\n"+
                "├── build.gradle\n"+
                "├── settings.gradle\n"+
                "└── README.md"+
                "We could run \"cd src\" to change the current working directory to \"src\"\n."+
                "This command would output nothing, but you can look at your current working directory on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help cd --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"cd\""},
        }},
    };
}