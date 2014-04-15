using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintASCIItable
{
    class PrintASCIItable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            for (byte counter = 0; counter < 255; counter++)
            {
                Console.WriteLine((char)counter);
            }
        }
    }
}
