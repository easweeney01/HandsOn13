namespace HelloWorldApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var res = Program.HW();

        Assert.True(res == "Hello, World!");
    }
}
