using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccoutData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Ivailo";
            string middleName = "Ivanov";
            string lastName = "Ivanov";
            decimal balance = 54122.74m;
            char euro = '\u20AC';
            string bankName = "HSBC";
            long iban = 9383743293937;
            long firstCCnumber = 756324937323;
            long secondCCnumber = 3248423742393;
            long thirdCCnumber = 2342349324323;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("First Name -" + firstName);
            Console.WriteLine("Middle Name - " + middleName);
            Console.WriteLine("Last Name - " + lastName);
            Console.WriteLine("Account Balance - " + balance + euro);
            Console.WriteLine("Bank Name -" + bankName);
            Console.WriteLine("IBAN - " + iban);
            Console.WriteLine("First Credit Card Number -" + firstCCnumber);
            Console.WriteLine("Second Credit Card Number - " + secondCCnumber);
            Console.WriteLine("Third Credit Card Number - " + thirdCCnumber);
        }
    }
}
