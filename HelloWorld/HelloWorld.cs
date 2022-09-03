namespace HelloWorld;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("Please enter year and continue with [Enter]");
        CommandLineLeapYear(Console.ReadLine());
    }

    public static void CommandLineLeapYear(string input) {
        try {
            int year = Int32.Parse(input);
        
            Boolean isLeapYear = IsLeapYear(year);
            if (isLeapYear) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }    
        } catch {
            Console.WriteLine("Please enter a valid year");
        }
    }
    
    public static bool IsLeapYear(int year) {
        if (year % 100 == 0) {
            return (year % 400 == 0);
        }
        return (year % 4) == 0;
    }
}