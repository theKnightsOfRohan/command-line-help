using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Help.Tests")]
namespace Help;
internal class Help
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            return;
        }
    }
}
