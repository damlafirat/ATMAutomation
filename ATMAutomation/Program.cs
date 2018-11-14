using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAutomation
{
    class Program
    {
        static List<string> transactionInfo = new List<string>();

        static void Main(string[] args)
        {
            menu();
        }

        private static void menu()
        {
            Console.WriteLine("1.\tWithdraw money");
            Console.WriteLine("2.\tDeposit money");
            Console.WriteLine("3.\tAccount info");
            Console.WriteLine("4.\tExit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    withdrawMoney();
                    break;

                case "2":
                    depositMoney();
                    break;

                case "3":
                    getAccountInfo();
                    break;

                case "4":
                    exit();
                    break;

                default:
                    invalidChoice();
                    break;
            }
        }

        private static void invalidChoice()
        {
            Console.Clear();
            Console.WriteLine("İnvalid choice..");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        private static void exit()
        {
            System.Environment.Exit(0);
        }

        private static void getAccountInfo()
        {
            Console.Clear();

            if (transactionInfo.Count != 0)
            {
                foreach (var item in transactionInfo)
                {
                    Console.WriteLine(item);
                }
            }

            else
                Console.WriteLine("No transaction");
            
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        private static void depositMoney()
        {
            Console.Clear();

            Console.Write("Amount : ");

            string amount = Console.ReadLine();

            if (checkAmount(amount))
            {
                Account acc = new Account();
                transactionInfo.Add(acc.depositMoney(int.Parse(amount)));
            }

            else
            {
                Console.WriteLine("İnvalid amount...");
            }

            Console.ReadLine();
            Console.Clear();
            menu();
        }

        private static void withdrawMoney()
        {
            Console.Clear();

            Console.Write("Amount : ");
            string amount = Console.ReadLine();

            if (checkAmount(amount))
            {
                Account acc = new Account();
                transactionInfo.Add(acc.withdrawMoney(int.Parse(amount)));
            }
            else
            {
                Console.WriteLine("İnvalid amounnt...");
            }

            Console.ReadLine();
            Console.Clear();
            menu();
        }

        private static bool checkAmount(string line)
        {
            int result;

            if (int.TryParse(line, out result))
                return true;
            else
                return false;
        }
    }
}
