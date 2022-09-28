using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base.DataType
{
    internal class DataType_2_Boxing
    {
        internal static void Boxing1()
        {
            int i = 123;
            object obj = i; // Boxing
            Console.WriteLine((int)obj); // Unboxing
        }

        internal static void Boxing2()
        {
            int i = 123;
            object obj = i;
            i = 456;
            Console.WriteLine("{0} / {1}", (int)obj, i);

        }

    }
}
