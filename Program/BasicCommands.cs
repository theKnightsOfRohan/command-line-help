using System.Collections.Generic;

namespace Program;
internal static class BasicCommands
{
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
                "src\tlib\tbuild.gradle\tsettings.gradle\tREADME.md\n\n"+
                "You can also specify a directory to list the current contents of that directory.\n"+
                "For example, if we wanted to list the contents of the \"src\" directory, we could run \"ls src/main\". This command would output:\n\n"+
                "java\tresources\n\n"+
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
        {"mkdir", new(){
            {"","The mkdir command creates a new directory.\n" +
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
                "We could run \"mkdir src/main/java\" to create a new directory \"java\" in the \"src/main\" directory.\n"+
                "This command would output nothing, but you can look at the file structure on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help mkdir --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"mkdir\""},
        }},
        {"touch", new(){
            {"","The touch command creates a new file.\n" +
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
                "We could run \"touch src/main/java/App.java\" to create a new file \"App.java\" in the \"src/main/java\" directory.\n"+
                "This command would output nothing, but you can look at the file structure on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help touch --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"touch\""},
        }},
        {"rm", new(){
            {"","The rm command removes a file or directory.\n" +
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
                "We could run \"rm src/main/java/App.java\" to remove the file \"App.java\" in the \"src/main/java\" directory.\n"+
                "This command would output nothing, but you can look at the file structure on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help rm --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"rm\""},
        }},
        {"cp", new(){
            {"","The cp command copies a file or directory.\n" +
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
                "We could run \"cp src/main/java/App.java src/main/java/AppCopy.java\" to copy the file \"App.java\" in the \"src/main/java\" directory to \"AppCopy.java\".\n"+
                "This command would output nothing, but you can look at the file structure on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help cp --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"cp\""},
        }},
        {"mv", new(){
            {"","The mv command moves or renames a file or directory.\n" +
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
                "We could run \"mv src/main/java/App.java src/main/java/AppCopy.java\" to move the file \"App.java\" in the \"src/main/java\" directory to \"AppCopy.java\".\n"+
                "This command would output nothing, but you can look at the file structure on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help mv --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"mv\""},
        }},
        {"cat", new(){
            {"","The cat command displays the contents of a file.\n" +
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
                "We could run \"cat src/main/java/App.java\" to display the contents of the file \"App.java\" in the \"src/main/java\" directory.\n"+
                "This command would output:\n\n"+
                "public class App {\n"+
                "    public static void main(String[] args) {\n"+
                "        System.out.println(\"Hello World!\");\n"+
                "    }\n"+
                "}\n\n"+
                "For more information about this command, run the command \"help cat --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"cat\""},
        }},
        {"grep", new(){
            {"","The grep command searches for a pattern in a file.\n" +
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
                "We could run \"grep \"Hello World\" src/main/java/App.java\" to search for the pattern \"Hello World\" in the file \"App.java\" in the \"src/main/java\" directory.\n"+
                "This command would output:\n\n"+
                "Hello World!\n\n"+
                "For more information about this command, run the command \"help grep --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"grep\""},
        }},
        {"echo", new(){
            {"","The echo command prints text to the terminal.\n" +
                "For example, we could run \"echo Hello World!\" to print \"Hello World!\" to the terminal.\n"+
                "This command would output:\n\n"+
                "Hello World!\n\n"+
                "For more information about this command, run the command \"help echo --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"echo\""},
        }},
        {"chmod", new(){
            {"","The chmod command changes the permissions of a file or directory.\n" +
                "For example, we could run \"chmod 777 src/main/java/App.java\" to change the permissions of the file \"App.java\" in the \"src/main/java\" directory to \"777\".\n"+
                "This command would output nothing, but you can look at the file structure on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help chmod --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"chmod\""},
        }},
        {"sudo", new(){
            {"","The sudo command runs a command with administrative privileges.\n" +
                "For example, we could run \"sudo rm src/main/java/App.java\" to remove the file \"App.java\" in the \"src/main/java\" directory with administrative privileges.\n"+
                "This command would output nothing, but you can look at the file structure on the left to see that it has changed.\n"+
                "For more information about this command, run the command \"help sudo --verbose\"."
            },
            {"V", "TODO: Add verbose output for \"sudo\""},
        }},
    };
}