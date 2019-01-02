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
            MyDelegate fptr;
            
            //---Basic Delegates---
            fptr= add;
            result = fptr(10, 20);
            Console.WriteLine(result);

            fptr = subtract;
            result = fptr(10, 20);
            Console.WriteLine(result);

            //---Anonymous Delegates---
            fptr = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2);
            };

            result = fptr(30, 40);
            Console.WriteLine("Anonymous Delegate result:" + result);

            Console.ReadLine();
        }
    }
}
