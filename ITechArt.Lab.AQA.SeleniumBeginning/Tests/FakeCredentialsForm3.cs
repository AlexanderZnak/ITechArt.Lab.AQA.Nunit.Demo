using System.Collections;

namespace ITechArt.Lab.AQA.SeleniumBeggining.Tests;

public class FakeCredentialsForm3 : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        yield return new object[] { "Jack", "123" };
        yield return new object[] { "John", "GoodLuck123" };
        yield return new object[] { "Abraham", "mydog19" };
    }
}