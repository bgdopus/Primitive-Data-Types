using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double double1 = 1.123456;
            double double2 = 1.123451;
            double epsilon = 0.000001;

            if (Math.Abs(double1 - double2) <= epsilon)
                Console.WriteLine("double1 and double2 are equal.");
            else
                Console.WriteLine("double1 and double2 are unequal.");

        }
    }
}
