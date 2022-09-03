namespace HelloWorld;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("Please enter year and continue with [Enter]");
        CommandLineLeapYear(Console.ReadLine());
    }

    public static void CommandLineLeapYear(string input) {
        throw new NotImplementedException();
    }
    
    public static bool IsLeapYear(int year) {
        if (year % 100 == 0) {
            return (year % 400 == 0);
        }
        return (year % 4) == 0;
    }
}