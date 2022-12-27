using ITechArt.Lab.AQA.SeleniumBeggining.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ITechArt.Lab.AQA.SeleniumBeggining.Tests;

public class SecondSeleniumTest : BaseTests
{
    [SetUp]
    public void Setup()
    {
        WebDriver = new ChromeDriver();
    }
    
    [Category("Selenium Test")]
    [Test]
    public void FirstTest()
    {
        var baseUrlLikeUri = new Uri(BaseUrl, UriKind.Absolute);

        WebDriver.Navigate().GoToUrl(baseUrlLikeUri);
        WebDriver.Manage().Window.Maximize();
    }
    
    [TearDown]
    public void TearDown()
    {
        WebDriver.Quit();
    }
}