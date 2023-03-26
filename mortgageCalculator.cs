using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter Your gross Monthly Income (Before Deductions)");
        double grossIncome = Convert.ToDouble(Console.ReadLine()); //Get the user's gross income and convert it to a double

        Console.WriteLine ("Enter Your Estimated Monthly Tax Deductions");
        double taxDeductions = Convert.ToDouble(Console.ReadLine()); //Get the user's tax deductions and convert it to a double

        Console.WriteLine ("Enter Your Estimated Monthly Expenditures ");
        double monthlyExpenditures = Convert.ToDouble(Console.ReadLine()); //Get the user's monthly expenditures and convert it to a double
        
        Console.WriteLine ("Rent or Buy? (R/B)");
        string rentOrBuy = Console.ReadLine() ?? ""; //Get the user's choice of rent or buy in a string

        if (rentOrBuy == "R") //If the user chooses to rent
        {
            Console.WriteLine ("Enter Your Monthly Rent");
            double monthlyRent = Convert.ToDouble(Console.ReadLine()); //Get the user's monthly rent and convert it to a double

            //Calculate the user's available money by subtracting the user's gross income, tax deductions, monthly expenditures and monthly rent
            double availableMoney = grossIncome - taxDeductions - monthlyExpenditures - monthlyRent; 
            Console.WriteLine ("You Will Have " + availableMoney + " Available Monthly"); //Display the user's available money
        }
        else if (rentOrBuy == "B") //If the user chooses to buy
        {
            Console.WriteLine ("Enter The Purchase Price of Your Home");
            double purchasePrice = Convert.ToDouble(Console.ReadLine()); //Get the user's purchase price and convert it to a double

            Console.WriteLine ("Enter The Total Deposit");
            double deposit = Convert.ToDouble(Console.ReadLine()); //Get the user's deposit and convert it to a double

            Console.WriteLine ("Enter The Interest Rate (without %)");
            double interestRate = Convert.ToDouble(Console.ReadLine()); //Get the user's interest rate and convert it to a double

            Console.WriteLine ("Enter The Number of Months to Repay");
            double monthsToRepay = Convert.ToDouble(Console.ReadLine()); //Get the user's number of months to repay and convert it to a double

            //Calculate the user's monthly repayment by subtracting the user's purchase price and deposit, multiplying the result by the user's interest rate and dividing the result by the user's number of months to repay
            double monthlyRepayment = (purchasePrice - deposit) * (interestRate / 100) / monthsToRepay; 
            Console.WriteLine ("Your Monthly Repayment is: " + monthlyRepayment); //Display the user's monthly repayment

            double third = grossIncome / 3.0; //Calculate a third of the user's gross income
            // Console.WriteLine ("A Third of Your Gross Income is: " + third); //Display a third of the user's gross income
            if (monthlyRepayment > third) //If the user's monthly repayment is greater than a third of the user's gross income
            {
                Console.WriteLine ("The Approval of The Home is Unlikely"); //Display that the approval of the home is unlikely
            }
            else
            {
                Console.WriteLine ("The Approval of The Home is Likely"); //Display that the approval of the home is likely
                
                //Calculate the user's available money by subtracting the user's gross income, tax deductions, monthly expenditures and monthly repayment
                double availableMoney = grossIncome - taxDeductions - monthlyExpenditures - monthlyRepayment; 
                Console.WriteLine ("You Will Have " + availableMoney + " Available Monthly"); //Display the user's available money
            }
        }
        else    //If the user's choice is invalid
        {
            Console.WriteLine ("Invalid Input"); //Display that the input is invalid
        }
        Console.WriteLine ("\nPress Enter to exit"); //Display that the user should press enter to exit
        Console.ReadLine();
    }
}   