using Program;

namespace Program.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void Main_NoArguments_PrintsBasicCommands()
    {
        // Arrange
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        Program.Main(new string[] { });

        // Assert
        var outputLines = consoleOutput.ToString().Split(Environment.NewLine);
        // +1 for the newLine at the end of the output
        Assert.That(outputLines.Length, Is.EqualTo(BasicCommands.CommandDictionary.Count + 1));
        foreach (var command in BasicCommands.CommandDictionary)
        {
            Assert.That(outputLines.Any(line => line.Contains(command.Key) && line.Contains(command.Value)), Is.True);
        }
    }

    [Test]
    public void Main_VersionOption_PrintsVersion()
    {
        // Arrange
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        Program.Main(new string[] { "-v" });

        // Assert
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("Version 0.0.1"));
    }

    [Test]
    public void Main_VerboseOption_PrintsVerboseOutput()
    {
        // Arrange
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        Program.Main(new string[] { "-V" });

        // Assert
        Assert.That(consoleOutput.ToString().Trim(), Is.EqualTo("Verbose output enabled"));
    }

    // Add more tests for the other command line options here...
}