using ITechArt.Lab.AQA.SeleniumBeggining.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ITechArt.Lab.AQA.SeleniumBeggining.Tests;

[Parallelizable(ParallelScope.Fixtures)]
[TestFixture]
public abstract class BaseTests
{
    protected IWebDriver WebDriver { get; set; }

    protected readonly string BaseUrl = Configurator.BaseUrl;
    
    [SetUp]
    public virtual void Setup()
    {
        Console.WriteLine("I am SetupFromBaseTests");
    }
}