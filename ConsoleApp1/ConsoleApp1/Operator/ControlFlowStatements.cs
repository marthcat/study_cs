using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base_1.Operator
{
    internal class ControlFlowStatements
    {
        internal static void SelectionStatements()
        {
            int i = 10;
            // if, else
            if (i == 10)
                Console.WriteLine("Hello World!");
            else
                Console.WriteLine("Not 10");

            //Switch 

            string s = "yes";
            switch(s)
            {
                case "yes":
                    Console.WriteLine(9);
                    break;
                case "no":
                    Console.WriteLine(10);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        internal static void IterationStatements()
        {
            // for
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", i + 1);
            }
            Console.WriteLine();

            // while
            int j = 5;
            while (j > 0)
            {
                Console.Write("{0} ", j--);
            }
            Console.WriteLine();

            // do while
            int k = 0;
            do
            {
                Console.Write("{0} ", k++);

            } while (k < 5);
            Console.WriteLine();

            // foreach
            int[] array = { 1, 2, 3, 4, 5, 6 };
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();


            ArrayList list = new ArrayList();
            //list.Add(4);
            //list.Add(3);
            //list.Add(2);
            //list.Add(1);
            list.AddRange(array);
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        internal static void JumpStatements()
        {
            // goto 
            int i = 0;
            First:
            Console.Write("{0} ", i);
            i++;
            if (i >= 5) 
                goto Second;
            else
                goto First;
            Second:
            i++;
            if (i <= 10)
                goto First;
            Console.WriteLine();

            // continue , break;
            int j = 0;
            while(true)
            {
                if (j > 10)
                    break;

                j++;
                if (j % 2 != 0)
                    continue;
                Console.Write("{0} ", j);
            }
            Console.WriteLine();


            // return;
            return; // method 반환
        }

    }
}
