using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//COLIN KNECHT
//PROGRAM 0 -- CPT 244
namespace Program0_Knecht
{
    class Account
    {
        enum TransactionType {DEPOSIT,WITHDRAWAL, ADD_INTEREST, STARTING_BALANCE};
        double startingBalance;
        double[] transactionHistory = new double[50];
        TransactionType[] transactionEnums = new TransactionType[50];
        double[] transactionAmount = new double[50];
        int index = 0;

        public Account(double startingBalance)
        {
            this.startingBalance = startingBalance;
            transactionHistory[index] = this.startingBalance;
            transactionEnums[index] = TransactionType.STARTING_BALANCE;
            transactionAmount[index] = startingBalance;
            index++;
        }

        public void deposit(double amount)
        {
            if (amount <= 0)
            {
                amount = 0;
            }
            startingBalance += amount;
            transactionHistory[index] = startingBalance;
            transactionEnums[index] = TransactionType.DEPOSIT;
            transactionAmount[index] = amount;
            index++;
        }

        public void withdraw(double amount)
        {
           
            if (transactionHistory[index - 1] - amount <= 0)
            {
                Console.WriteLine("Insufficient Funds!  You Can't Go Below 0 Dollars!!!");
            }
            else
            {
                transactionHistory[index] = transactionHistory[index - 1] - amount;
                transactionEnums[index] = TransactionType.WITHDRAWAL;
                transactionAmount[index] = amount;
                index++;
            }
          
        }

        public void addInterest()
        {
            transactionHistory[index] = (transactionHistory[index - 1] * .0005) + transactionHistory[index - 1];
            transactionEnums[index] = TransactionType.ADD_INTEREST;
            transactionAmount[index] = transactionHistory[index - 1] * .0005;
            index++;

        }

        public double getCurrentBalance()
        {
            return transactionHistory[index - 1];
        }

        public string getTransactionType()//return enum type in array value
        {
           return "" + transactionEnums[index - 1] + "";
        }

        public void showTransactions()
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write("Balance: " + transactionHistory[i] + " --------- ");
                Console.Write("Type: " + transactionEnums[i] + "----------- ");
                Console.Write("Amount: " + transactionAmount[i]);
                Console.WriteLine("");
                //Console.WriteLine("Balance: {0} " , transactionHistory[i] + " Type {1} " , transactionEnums[i] + "Amount {2} " , transactionAmount[i]);

                //Console.WriteLine("");
            }
        }

    }//END CLASS
}
