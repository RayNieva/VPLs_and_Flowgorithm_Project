import java.util.*;
import java.lang.Math;
import java.util.Scanner;

class JavaApplication {
    private static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
        // This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
        System.out.println("Calculating Weekly/ Budget");
        
        // Call Function to calculate total income
        double paySource1;
        
        paySource1 = input.nextDouble();
        double paySource2;
        
        paySource2 = input.nextDouble();
        double paySource3;
        
        paySource3 = input.nextDouble();
        GetIncome(paySource1, paySource2, paySource3);
        System.out.println("Returning to Main");
        
        // At this point should have total income
        // At this point start inputting billing items. These are essentially billing items for the current week or period. 
        // The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
    }

    private static double GetIncome(double paySource1, double paySource2, double paySource3) {
        double totalPay;
        
        totalPay = paySource1 + paySource2 + paySource3;
        System.out.println(totalPay);
        
        return totalPay;
    }
}
