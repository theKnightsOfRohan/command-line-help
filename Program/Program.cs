﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CommandLine;

[assembly: InternalsVisibleTo("Program.Tests")]
namespace Program;
internal class Program
{
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<LsOptions, CdOptions, MkDirOptions, TouchOptions, RmOptions, CpOptions, MvOptions, CatOptions, GrepOptions, EchoOptions, ChModOptions, SudoOptions>(args)
            .WithParsed<LsOptions>(opts => RunOptions("ls", opts.Verbose))
            .WithParsed<CdOptions>(opts => RunOptions("cd", opts.Verbose))
            .WithParsed<MkDirOptions>(opts => RunOptions("mkdir", opts.Verbose))
            .WithParsed<TouchOptions>(opts => RunOptions("touch", opts.Verbose))
            .WithParsed<RmOptions>(opts => RunOptions("rm", opts.Verbose))
            .WithParsed<CpOptions>(opts => RunOptions("cp", opts.Verbose))
            .WithParsed<MvOptions>(opts => RunOptions("mv", opts.Verbose))
            .WithParsed<CatOptions>(opts => RunOptions("cat", opts.Verbose))
            .WithParsed<GrepOptions>(opts => RunOptions("grep", opts.Verbose))
            .WithParsed<EchoOptions>(opts => RunOptions("echo", opts.Verbose))
            .WithParsed<ChModOptions>(opts => RunOptions("chmod", opts.Verbose))
            .WithParsed<SudoOptions>(opts => RunOptions("sudo", opts.Verbose))
            .WithNotParsed(HandleParseError);

        System.Console.WriteLine("Hello World!");
    }

    public static void RunOptions(string command, bool verbosity)
    {
        string v = verbosity ? "V" : "";
        System.Console.WriteLine(BasicCommands.CommandExplanations[command][v]);
    }

    public static void HandleParseError(IEnumerable<Error> errs)
    {
        foreach (Error err in errs)
        {
            if (err is VersionRequestedError)
            {
                continue;
            }
            System.Console.WriteLine(err.ToString());
        }
    }

    public class Options
    {
        [Option('V', "verbose", Required = false, HelpText = "Prints a detailed explanation of the command.")]
        public bool Verbose { get; set; }
    }

    [Verb("ls", HelpText = "List directory contents")]
    public class LsOptions : Options
    {
    }

    [Verb("cd", HelpText = "Change the current working directory")]
    public class CdOptions : Options
    {
    }

    [Verb("mkdir", HelpText = "Create a new directory")]
    public class MkDirOptions : Options
    {
    }

    [Verb("touch", HelpText = "Create a new file")]
    public class TouchOptions : Options
    {
    }

    [Verb("rm", HelpText = "Remove a file or directory")]
    public class RmOptions : Options
    {
    }

    [Verb("cp", HelpText = "Copy a file or directory")]
    public class CpOptions : Options
    {
    }

    [Verb("mv", HelpText = "Move or rename a file or directory")]
    public class MvOptions : Options
    {
    }

    [Verb("cat", HelpText = "Display the contents of a file")]
    public class CatOptions : Options
    {
    }

    [Verb("grep", HelpText = "Search for a pattern in a file")]
    public class GrepOptions : Options
    {
    }

    [Verb("echo", HelpText = "Print text to the terminal")]
    public class EchoOptions : Options
    {
    }

    [Verb("chmod", HelpText = "Change the permissions of a file or directory")]
    public class ChModOptions : Options
    {
    }

    [Verb("sudo", HelpText = "Run a command with administrative privileges")]
    public class SudoOptions : Options
    {
    }
}
