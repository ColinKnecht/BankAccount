using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//COLIN KNECHT
//PROGRAM 0 -- CPT 244
namespace Program0_Knecht
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;

            Console.WriteLine("Welcome to the Bank....  What is your starting balance?");
            String s = Console.ReadLine();
            double startBal = Double.Parse(s);
            Account myAccount = new Account(startBal);

             Console.WriteLine("Thank You, Please select from the menu");
             Console.WriteLine("(D)eposit---(W)ithdraw---(C)alculate Interest---(S)how Balance---(Q)uit");
             key = Console.ReadLine()[0];
             while (key != 'q' && key != 'Q')
             {
                  if (key == 'd' || key == 'D')
                  {
                     Console.WriteLine("How much would you like to deposit?");
                     String dep = Console.ReadLine();
                     double deposit = Double.Parse(dep);
                    if (deposit <= 0)
                    {
                        Console.WriteLine("You Can't deposit negative numbers!");
                        Console.WriteLine("(D)eposit---(W)ithdraw---(C)alculate Interest---(S)how Balance---(Q)uit");
                        key = Console.ReadLine()[0];
                    }
                     myAccount.deposit(deposit);

                     Console.WriteLine("(D)eposit---(W)ithdraw---(C)alculate Interest---(S)how Balance---(Q)uit");
                     key = Console.ReadLine()[0];
                   }

                        else if (key == 'w'|| key == 'W')
                        {
                            Console.WriteLine("WITHDRAW");
                            Console.WriteLine("How much would you like to withdraw?");
                            string wit = Console.ReadLine();
                            double withdraw = Double.Parse(wit);
                            if (withdraw <= 0)
                            {
                        Console.WriteLine("You Can't Withdraw 0 Dollars");
                            }
                            myAccount.withdraw(withdraw);

                            Console.WriteLine("(D)eposit---(W)ithdraw---(C)alculate Interest---(S)how Balance---(Q)uit");
                            key = Console.ReadLine()[0];
                        }

                        else if (key == 'c' || key == 'C')
                        {
                            Console.WriteLine("CALCULATE INTEREST");
                            Console.WriteLine("Adding Interest @ .05%");
                            myAccount.addInterest();

                            Console.WriteLine("(D)eposit---(W)ithdraw---(C)alculate Interest---(S)how Balance---(Q)uit");
                            key = Console.ReadLine()[0];
                        }

                        else if (key == 's' || key == 'S')
                        {
                            Console.WriteLine("SHOW BALANCE");
                            Console.WriteLine("Your Current Balance is " + myAccount.getCurrentBalance());

                            Console.WriteLine("(D)eposit---(W)ithdraw---(C)alculate Interest---(S)how Balance---(Q)uit");
                            key = Console.ReadLine()[0];
                        }

                        else
                        {
                            Console.WriteLine("Invalid Key, Please select from the menu!!");

                            Console.WriteLine("(D)eposit---(W)ithdraw---(C)alculate Interest---(S)how Balance---(Q)uit");
                            key = Console.ReadLine()[0];
                        }
                    }//end while
                
  
            Console.WriteLine("Thank You for Banking With Us. Here Is Your List of Transactions.");
            myAccount.showTransactions();
            Console.ReadKey();
        }
    }
}
