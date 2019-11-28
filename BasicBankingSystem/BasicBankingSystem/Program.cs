using System;

namespace BasicBankingSystem
{
    public class Customer
    {
       public string firstName, lastName, gender;
    }
    public class Account
    {
        // public int accNbr;
        public string accType, currency, accNbr;
    }
    public class Transaction
    {
        public double deposit(double initBal, double amt )
        {
            double balance;
            balance = initBal + amt;
            return balance;
        }
        public double withdraw(double initBal, double amt)
        {
            double balance;
            balance = initBal - amt;
            return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction tr = new Transaction();
            Customer cust = new Customer();
            Account acc = new Account();
            double initBal = 50000.00, amt, iniBa=50.00;
            int choice;
            Console.WriteLine("Enter your Account Number:");
            acc.accNbr = Console.ReadLine();
            Console.WriteLine("Enter your First Name:");
            cust.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            cust.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Gender:");
            cust.gender = Console.ReadLine();
            Console.WriteLine("Enter your Account Type:");
            acc.accType = Console.ReadLine();
            Console.WriteLine("Enter type of currency (RWF/USD/EURO):");
            acc.currency = Console.ReadLine();
            if (acc.currency=="RWF")
            {
                Console.WriteLine("Press 1 to DEPOSIT or 2 to WITHDRAW: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter amount you wish to deposit:");
                        amt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Your new balance is {tr.deposit(initBal, amt)} RWF");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount you wish to withdraw:");
                        amt = Convert.ToInt32(Console.ReadLine());
                        if (amt > 50000)
                        {
                            Console.WriteLine("Sorry you don't have enough money!");
                        }
                        else
                        {
                            Console.WriteLine($"Your new balance is {tr.withdraw(initBal, amt)} RWF");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            else if (acc.currency == "USD")
            {
                Console.WriteLine("Press 1 to DEPOSIT or 2 to WITHDRAW: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter amount you wish to deposit:");
                        amt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Your new balance is {tr.deposit(iniBa, amt)} USD");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount you wish to withdraw:");
                        amt = Convert.ToInt32(Console.ReadLine());
                        if (amt > 50)
                        {
                            Console.WriteLine("Sorry you don't have enough money!");
                        }
                        else
                        {
                            Console.WriteLine($"Your new balance is {tr.withdraw(iniBa, amt)} USD");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            else if (acc.currency == "EURO")
            {
                Console.WriteLine("Press 1 to DEPOSIT or 2 to WITHDRAW: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter amount you wish to deposit:");
                        amt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Your new balance is {tr.deposit(iniBa, amt)} EURO");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount you wish to withdraw:");
                        amt = Convert.ToInt32(Console.ReadLine());
                        if (amt > 50)
                        {
                            Console.WriteLine("Sorry you don't have enough money!");
                        }
                        else
                        {
                            Console.WriteLine($"Your new balance is {tr.withdraw(iniBa, amt)} EURO");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            else
                Console.WriteLine("Unknown currency");
            
        }
    }
}
