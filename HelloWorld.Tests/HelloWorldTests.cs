namespace HelloWorld.Tests;

public class HelloWorldTests
{
    [Fact]
    public void Hello_World_Test()
    {
        // Arrange 
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        HelloWorld.Main(Array.Empty<string>());

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");
    }

    [Fact]
    public void Leap_Year_2004_When_Divisible_By_4() {
        // Arrange
        var year = 2004;
        var obj = new HelloWorld();

        // Act
        var isLeapYear = obj.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(true);
    }

    [Fact]
    public void Not_Leap_Year_1999_When_Not_Divisible_By_4() {
        // Arrange
        var year = 1999;
        var obj = new HelloWorld();

        // Act
        var isLeapYear = obj.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(false);
    }

    [Fact]
    public void Centennial_Not_Divisible_By_400_Is_Not_Leap_Year() {
        // Arrange
        var year = 1900;
        var obj = new HelloWorld();

        // Act
        var isLeapYear = obj.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(false);
    }
}