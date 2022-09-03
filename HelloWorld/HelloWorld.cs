namespace HelloWorld;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
    }
    
    public bool IsLeapYear(int year) {
        if (year % 100 == 0) {
            return (year % 400 == 0);
        }
        return (year % 4) == 0;
    }
}