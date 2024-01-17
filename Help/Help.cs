using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Help.Tests")]
namespace Help;
internal class Help
{
    public static void Main(string[] args)
    {
        string[] parsedArgs = ParseArgs(args);
        if (parsedArgs.Length == 0)
        {
            Console.WriteLine(BasicCommands.BasicOverview(""));
            return;
        }
    }

    private static string[] ParseArgs(string[] args)
    {
        if (args.Length == 0)
            return args;



        throw new NotImplementedException();
    }
}
