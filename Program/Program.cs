using System;
using System.IO;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("Program.Tests")]
namespace Program;
internal class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            WriteAllCommands();
        }
        else
        {
            HandleArgs(args);
        }
    }

    public static void HandleArgs(string[] args)
    {
        foreach (string arg in args)
        {
            switch (ParseArg(arg))
            {
                case "v":
                    Console.WriteLine("Version: 1.0.0");
                    break;
            }
        }
    }

    public static string ParseArg(string arg)
    {
        if (arg.StartsWith("-"))
        {
            if (arg.StartsWith("--"))
            {
                arg = arg[2..];
            }
            else
            {
                arg = arg[1..];
            }

            if (arg.Length > 1)
            {
                arg = arg[..1];
            }
        }

        return arg.ToLower();
    }

    public static void WriteAllCommands()
    {
        try
        {
            string[] commands = File.ReadAllLines("commands/commands.txt");
            foreach (string command in commands)
            {
                Console.WriteLine(command);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


}
