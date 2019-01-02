﻿using System;
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

        public static int composable_D1(int i, int j)
        {
            int r = i + j;
            Console.WriteLine("Result of func1 =" + r);
            return r;
        }

        public static int composable_D2(int i, int j)
        {
            int r = i - j;
            Console.WriteLine("Result of func2 =" + r);
            return r;
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
            Console.WriteLine("Anonymous Delegate result: " + result);

            //---Composable Delegates---
            MyDelegate fptr1 = composable_D1;
            MyDelegate fptr2 = composable_D2;
            MyDelegate fptr1fptr2 = fptr1 + fptr2; //create delegate chain
            result = fptr1fptr2(100, 10);
            Console.WriteLine("Composable Delegate Result1: " + result);
            fptr1fptr2 -= fptr2;    //remove delegates from chain
            result = fptr1fptr2(100, 10);
            Console.WriteLine("Composable Delegate Result2: " + result);

            Console.ReadLine();
        }
    }
}
