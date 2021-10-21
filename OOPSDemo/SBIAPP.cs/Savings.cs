using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankLibrary
{
    public class Savings : Bank
    {



        public Savings()
        {



        }



        public Savings(string name, double amt) : base(name, amt)
        {



        }



        public sealed override void Withdraw(double amount)
        {
            if ((Balance - amount) > 0)
            {
                //allow to withhdraw
                Balance -= amount;
            }
            else
            {
                throw new Exception("Balace not enough. Cannot withdraw");
            }





        }
    }
}