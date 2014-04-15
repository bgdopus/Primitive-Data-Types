using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Ivailo";
            string lastName = "Ivanov";
            byte age = 35;
            string gender = "M";
            long personalId = 7701217612;
            long employeeId = 038938276492782;
            Console.WriteLine("First Name - " + firstName);
            Console.WriteLine("Last Name - " + lastName);
            Console.WriteLine("Age - " + age);
            Console.WriteLine("Gender - " + gender);
            Console.WriteLine("Personal ID Number - " + personalId);
            Console.WriteLine("Unique Employee Number - " + employeeId);

        }
    }
}
