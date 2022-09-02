namespace HelloWorld.Tests;

public class HelloWorldTests
{
    [Fact]
    public void Test1()
    {
        // Arrange 
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        HelloWorld.Main(null);

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");
    }
}