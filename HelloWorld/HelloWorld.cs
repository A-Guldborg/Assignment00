namespace HelloWorld;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
    }
    
    public bool IsLeapYear(int year) {
        return (year % 4) == 0;
    }
}