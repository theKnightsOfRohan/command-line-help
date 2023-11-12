using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CommandLine;


[assembly: InternalsVisibleTo("Program.Tests")]
namespace Program;
internal class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            foreach (KeyValuePair<string, string> command in BasicCommands.CommandDictionary)
            {
                Console.WriteLine($"{command.Key}\t\t{command.Value}");
            }
            return;
        }
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(RunOptions)
            .WithNotParsed(HandleParseError);
    }

    public static void RunOptions(Options opts)
    {
        if (opts.Version)
        {
            Console.WriteLine("Version 0.0.1");
        }
        else if (opts.Verbose)
        {
            Console.WriteLine("Verbose output enabled");
        }
    }

    public static void HandleParseError(IEnumerable<Error> errs)
    {
        // Handle errors
    }


    public class Options
    {
        [Option('v', "version", Required = false, HelpText = "Show the version number")]
        public bool Version { get; set; }

        [Option('V', "verbose", Required = false, HelpText = "Show verbose output")]
        public bool Verbose { get; set; }

        [Option("ls", Required = false, HelpText = "List directory contents")]
        public bool ListDirectoryContents { get; set; }

        [Option("cd", Required = false, HelpText = "Change the current working directory")]
        public string ChangeDirectory { get; set; }

        [Option("mkdir", Required = false, HelpText = "Create a new directory")]
        public string MakeDirectory { get; set; }

        [Option("touch", Required = false, HelpText = "Create a new file")]
        public string CreateFile { get; set; }

        [Option("rm", Required = false, HelpText = "Remove a file or directory")]
        public string RemoveFileOrDirectory { get; set; }

        [Option("cp", Required = false, HelpText = "Copy a file or directory")]
        public string CopyFileOrDirectory { get; set; }

        [Option("mv", Required = false, HelpText = "Move or rename a file or directory")]
        public string MoveOrRenameFileOrDirectory { get; set; }

        [Option("cat", Required = false, HelpText = "Display the contents of a file")]
        public string DisplayFileContents { get; set; }

        [Option("grep", Required = false, HelpText = "Search for a pattern in a file")]
        public string SearchFile { get; set; }

        [Option("echo", Required = false, HelpText = "Print text to the terminal")]
        public string PrintText { get; set; }

        [Option("chmod", Required = false, HelpText = "Change the permissions of a file or directory")]
        public string ChangePermissions { get; set; }

        [Option("sudo", Required = false, HelpText = "Run a command with administrative privileges")]
        public string RunWithAdminPrivileges { get; set; }
    }
}
