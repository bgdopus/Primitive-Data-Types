using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExchangeValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = 0;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }
}
