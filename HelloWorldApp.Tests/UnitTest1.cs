namespace HelloWorldApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var res = Program.hw();

        Assert.True(res == "Hello, World!");
    }
}
