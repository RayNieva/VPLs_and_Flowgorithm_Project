using System;

public class MyProgram
{
    public static void Main(String[] args)
    {
        // This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
        Console.WriteLine("Calculating Weekly/ Budget");
        
        // Call Function to calculate total income
        double paySource1;
        
        input(out paySource1);
        double paySource2;
        
        input(out paySource2);
        double paySource3;
        
        input(out paySource3);
        GetIncome(paySource1, paySource2, paySource3);
        Console.WriteLine("Returning to Main");
        
        // At this point should have total income
        // At this point start inputting billing items. These are essentially billing items for the current week or period. 
        // The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
    }

    private static double GetIncome(double paySource1, double paySource2, double paySource3)
    {
        double totalPay;
        
        totalPay = paySource1 + paySource2 + paySource3;
        Console.WriteLine(totalPay);
        
        return totalPay;
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
