using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? value1 = null;
            double? value2 = null;
            Console.WriteLine("Value1 has value - " + value1.HasValue);
            Console.WriteLine("Value2 has value - " + value2.HasValue);
            value1 = 5;
            value2 = value1;
            Console.WriteLine("Value1 has value - " + value1);
            Console.WriteLine("Value2 has value - " + value2);

        }
    }
}
