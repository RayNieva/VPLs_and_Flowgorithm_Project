using System;

public class MyProgram
{
    public static void Main(String[] args)
    {
        // This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
        Console.WriteLine("Calculating Weekly/ Budget");
        
        // This is usually weekly (net) income but can be another period like bi-weekly or monthly
        Console.WriteLine("Get Income for week/period");
        double income1;
        
        input(out income1);
        
        // At this point start inputting billing items. These are essentially billing items for the current week or period. 
        // The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
    }
    
    // .NET can only read single characters or entire lines from the console.
    // The following functions are designed to help input specific data types.
    // 'out' is a pass-by-reference modifier in C#.
    
    private static void input(out double result)
    {
        while (!double.TryParse(Console.ReadLine(), out result));
    }
    
    private static void input(out int result)
    {
        while (!int.TryParse(Console.ReadLine(), out result));
    }
    
    private static void input(out Boolean result)
    {
        while (!Boolean.TryParse(Console.ReadLine(), out result));
    }
    
    private static void input(out string result)
    {
        result = Console.ReadLine();
    }
}
