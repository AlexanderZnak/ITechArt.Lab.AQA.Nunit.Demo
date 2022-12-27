using NUnit.Framework;

namespace ITechArt.Lab.AQA.SeleniumBeggining.Utils;

public class Configurator
{
    private const string BaseUrlProperty = "baseUrl";
    
    public static readonly string BaseUrl = TestContext.Parameters[BaseUrlProperty];
}