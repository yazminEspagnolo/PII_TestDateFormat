namespace Library.Tests;
using TestDateFormat;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    
    [Test]
    public void Test1()
    {
        string? inputTest1 = null;    // Cuando declaro una varibale nula debo colocar ´?´ después del tipo de dato.
        Assert.IsNotNull(inputTest1);
    }

    [Test]
    public void Test2()
    {
        string expected = "10/11/1997";
        string inputTest2 = "19*12*2022";
       
        Assert.That(DateFormatter.ChangeFormat(inputTest2), Is.EqualTo(DateFormatter.ChangeFormat(expected)));
        
    }

    [Test]
    public void Test3()
    {
        string expected = "08/08/1993";
        string inputTest3 = "08/08/1993";
       
        Assert.That(DateFormatter.ChangeFormat(inputTest3), Is.EqualTo(DateFormatter.ChangeFormat(expected)));
    }



}
