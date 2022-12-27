using ITechArt.Lab.AQA.SeleniumBeggining.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106;

namespace ITechArt.Lab.AQA.SeleniumBeggining.Tests;

public class FirstSeleniumTest : BaseTests
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        Console.WriteLine("I am OneTimeSetup. Doing smth...\n");
    }

    [SetUp]
    public override void Setup()
    {
        WebDriver = new ChromeDriver();
    }

    [Order(2)]
    [Test]
    public void FirstTest()
    {
        var baseUrlLikeUri = new Uri(BaseUrl, UriKind.Absolute);

        WebDriver.Navigate().GoToUrl(baseUrlLikeUri);
        WebDriver.Manage().Window.Maximize();
    }

    [Category("Selenium Test")]
    [Order(1)]
    [Test(Description = "In this test we are opening website", Author = "Alexander Znak")]
    [TestCase("Alex", "123")]
    [TestCase("Vasya", "GoodLuck123")]
    [TestCase("Oybek", "mydog19")]
    public void SecondTest(string username, string password)
    {
        var baseUrlLikeUri = new Uri(BaseUrl, UriKind.Absolute);

        WebDriver.Navigate().GoToUrl(baseUrlLikeUri);
        WebDriver.Manage().Window.Maximize();
        WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        // var usernameData = "email";
        // var passwordData = "pass";

        var loginButton = WebDriver.FindElement(By.CssSelector("#login2"));
        loginButton.Click();

        var usernameInput = WebDriver.FindElement(By.CssSelector("#loginusername"));
        usernameInput.SendKeys(username);

        var passwordInput = WebDriver.FindElement(By.CssSelector("#loginpassword"));
        passwordInput.SendKeys(password);

        var usernameInputText = usernameInput.GetAttribute("value");
        var passwordInputText = passwordInput.GetAttribute("value");

        Console.WriteLine($"Username: {usernameInputText}\n");
        Console.WriteLine($"Password: {passwordInputText}\n");

        Assert.Multiple(() =>
        {
            Assert.AreEqual(username, usernameInputText, "This data from username input");
            Assert.AreEqual(password, passwordInputText);
        });
    }

    [Category("Unit Test")]
    [Test]
    public void TestAssertions()
    {
        Assert.Throws<NotFoundException>(delegate { throw new Exception("message"); });

        // Assert.IsTrue(false);
        // DirectoryAssert.Exists(@"C:\Users\Aliaksandr.Znak\RiderProjects\ITechArt.Lab.AQA\ITechArt.Lab.AQA.SeleniumBeginning\Tests");
        Assert.AreEqual(1.4d, 1, .5);
    }

    [Test(Description = "Form 1", Author = "Alexander Znak")]
    [TestCaseSource(nameof(_fakeCredentials))]
    public void ParametrizedTestForm1(string username, string password)
    {
        var baseUrlLikeUri = new Uri(BaseUrl, UriKind.Absolute);

        WebDriver.Navigate().GoToUrl(baseUrlLikeUri);
        WebDriver.Manage().Window.Maximize();
        WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        var loginButton = WebDriver.FindElement(By.CssSelector("#login2"));
        loginButton.Click();

        var usernameInput = WebDriver.FindElement(By.CssSelector("#loginusername"));
        usernameInput.SendKeys(username);

        var passwordInput = WebDriver.FindElement(By.CssSelector("#loginpassword"));
        passwordInput.SendKeys(password);

        var usernameInputText = usernameInput.GetAttribute("value");
        var passwordInputText = passwordInput.GetAttribute("value");

        Console.WriteLine($"Username: {usernameInputText}\n");
        Console.WriteLine($"Password: {passwordInputText}\n");

        Assert.Multiple(() =>
        {
            Assert.AreEqual(username, usernameInputText, "This data from username input");
            Assert.AreEqual(password, passwordInputText);
        });
    }

    private static object[] _fakeCredentials =
    {
        new object[] { "Alex", "123" },
        new object[] { "Vasya", "GoodLuck123" },
        new object[] { "Oybek", "mydog19" },
    };
    
    [Test(Description = "Form 2", Author = "Alexander Znak")]
    [TestCaseSource(typeof(FakeCredentials), nameof(FakeCredentials.FakeCredentialsArray))]
    public void ParametrizedTestForm2(string username, string password)
    {
        var baseUrlLikeUri = new Uri(BaseUrl, UriKind.Absolute);

        WebDriver.Navigate().GoToUrl(baseUrlLikeUri);
        WebDriver.Manage().Window.Maximize();
        WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        var loginButton = WebDriver.FindElement(By.CssSelector("#login2"));
        loginButton.Click();

        var usernameInput = WebDriver.FindElement(By.CssSelector("#loginusername"));
        usernameInput.SendKeys(username);

        var passwordInput = WebDriver.FindElement(By.CssSelector("#loginpassword"));
        passwordInput.SendKeys(password);

        var usernameInputText = usernameInput.GetAttribute("value");
        var passwordInputText = passwordInput.GetAttribute("value");

        Console.WriteLine($"Username: {usernameInputText}\n");
        Console.WriteLine($"Password: {passwordInputText}\n");

        Assert.Multiple(() =>
        {
            Assert.AreEqual(username, usernameInputText, "This data from username input");
            Assert.AreEqual(password, passwordInputText);
        });
    }
    
    [Test(Description = "Form 3", Author = "Alexander Znak")]
    [TestCaseSource(typeof(FakeCredentialsForm3))]
    public void ParametrizedTestForm3(string username, string password)
    {
        var baseUrlLikeUri = new Uri(BaseUrl, UriKind.Absolute);

        WebDriver.Navigate().GoToUrl(baseUrlLikeUri);
        WebDriver.Manage().Window.Maximize();
        WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        var loginButton = WebDriver.FindElement(By.CssSelector("#login2"));
        loginButton.Click();

        var usernameInput = WebDriver.FindElement(By.CssSelector("#loginusername"));
        usernameInput.SendKeys(username);

        var passwordInput = WebDriver.FindElement(By.CssSelector("#loginpassword"));
        passwordInput.SendKeys(password);

        var usernameInputText = usernameInput.GetAttribute("value");
        var passwordInputText = passwordInput.GetAttribute("value");

        Console.WriteLine($"Username: {usernameInputText}\n");
        Console.WriteLine($"Password: {passwordInputText}\n");

        Assert.Multiple(() =>
        {
            Assert.AreEqual(username, usernameInputText, "This data from username input");
            Assert.AreEqual(password, passwordInputText);
        });
    }

    [Test]
    public void TestWithoutRunTime()
    {
        
    }

    [TearDown]
    public void TearDown()
    {
        WebDriver.Quit();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Console.WriteLine("I am OneTimeTearDown. Finishing smth...\n");
    }
}

public class User
{
    public string Name { get; set; }
}