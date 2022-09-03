namespace HelloWorld.Tests;

public class HelloWorldTests
{
    [Fact]
    public void CLI_1996_Is_Leap_Year()
    {
        // Arrange 
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        HelloWorld.CommandLineLeapYear("1996");

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]
    public void CLI_1997_Is_Not_Leap_Year()
    {
        // Arrange 
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        HelloWorld.CommandLineLeapYear("1997");

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact] 
    public void CLI_Does_Not_Accept_Words() {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        HelloWorld.CommandLineLeapYear("Hello, World!");

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Please enter a valid year");
    }


    [Fact]
    public void Leap_Year_2004_When_Divisible_By_4() {
        // Arrange
        var year = 2004;

        // Act
        var isLeapYear = HelloWorld.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(true);
    }

    [Fact]
    public void Not_Leap_Year_1999_When_Not_Divisible_By_4() {
        // Arrange
        var year = 1999;

        // Act
        var isLeapYear = HelloWorld.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(false);
    }

    [Fact]
    public void Centennial_Not_Divisible_By_400_Is_Not_Leap_Year() {
        // Arrange
        var year = 1900;

        // Act
        var isLeapYear = HelloWorld.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(false);
    }
}