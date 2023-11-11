using System;
using System.Collections.Generic;

namespace Program;
internal static class BasicCommands
{
    public static Dictionary<string, string> CommandDictionary = new Dictionary<string, string>()
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
}