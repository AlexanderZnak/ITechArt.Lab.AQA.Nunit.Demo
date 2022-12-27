using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace ITechArt.Lab.AQA.SeleniumBeggining.Tests;

[SetUpFixture]
public class GlobalTestsSetUp
{
    [OneTimeSetUp]
    public void GlobalOneTimeSetUp()
    {
        Console.WriteLine("I am GlobalOneTimeSetUp. Doing smth one before all tests are started...\n");
    }
}