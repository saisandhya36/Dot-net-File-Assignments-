using System;
using BankLibrary;

namespace SBIAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bank Object
            Bank bank = new Bank();
            bank.AccHolderName = "naveen";
            //bank.Balance = 2000;



            Console.WriteLine(bank);



            bank.Deposit(5000);
            Console.WriteLine(bank.ToString());



            bank.Withdraw(3000);
            Console.WriteLine(bank);



            Console.WriteLine("--------------------------");



            Bank bank1 = new Bank("rvv", 5000);
            Console.WriteLine(bank1);



            object obj = new object();
            Console.WriteLine(obj.ToString());
            #endregion




            #region Savings Object
            Savings savings = new Savings("naveen", 4000);
            Console.WriteLine(savings);



            try
            {
                savings.Withdraw(1000);
            }
            catch (BalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(savings);
            #endregion




            string str;
            string str1;



            object obj;
            object obj1;



        }
    }
}