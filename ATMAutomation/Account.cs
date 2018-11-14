using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAutomation
{
    class Account
    {
        static public int balance = 5000;

        public string depositMoney(int amount)
        {
            balance += amount;

            Console.WriteLine("Transaction successfull");

            string trnxDescription = $"Deposit Money\t +{amount}\tbalance : {balance}\t\tSuccessfull";

            return trnxDescription;
        }

        public string withdrawMoney(int amount)
        {
            string trnxDescription = "";

            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine("Transaction successfull");

                trnxDescription = $"Withdraw Money\t -{amount}\tbaalance : {balance}\t\tSuccessfull";
            }

            else
            {
                Console.WriteLine("Inadequate limit");
                Console.WriteLine("Transaction failed");

                trnxDescription = $"Withdraw Money\t -{amount}\tbalance : {balance}\t\tFailed";
            }

            return trnxDescription;
        }
    }
}
