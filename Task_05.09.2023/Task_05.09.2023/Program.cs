using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir eded daxil edin: ");
            int a= Convert.ToInt32(Console.ReadLine());

            while (a % 3 == 0)
            {
                a/= 3;
            }

            bool b = a == 1;

            Console.WriteLine(b);
        }
    }
}
