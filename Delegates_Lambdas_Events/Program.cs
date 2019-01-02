using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Lambdas_Events
{
    class Program
    {
        public delegate int MyDelegate(int i, int j);

        public static int add(int i, int j)
        {
            return i + j;
        }

        public static int subtract(int i, int j)
        {
            return i - j;
        }
        static void Main(string[] args)
        {
            int result = 0;
            MyDelegate fptr = add;

            result = add(10, 20);
            Console.WriteLine(result);

            result = subtract(10, 20);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
