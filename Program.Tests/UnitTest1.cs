using Program;

namespace Program.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestParseArgWithDoubleDash()
    {
        string arg = "--testArg";
        string expected = "t";
        string actual = Program.ParseArg(arg);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestParseArgWithSingleDash()
    {
        string arg = "-testArg";
        string expected = "t";
        string actual = Program.ParseArg(arg);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestParseArgWithoutDash()
    {
        string arg = "testArg";
        string expected = "testarg";
        string actual = Program.ParseArg(arg);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestParseArgWithEmptyString()
    {
        string arg = "";
        string expected = "";
        string actual = Program.ParseArg(arg);
        Assert.AreEqual(expected, actual);
    }
}