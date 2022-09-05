using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base_1.Array_0
{
    internal class Array_0
    {
        internal static void UseArray()
        {
            int[] array = { 1, 2, 3, 4 };
            //for (int i = 0; i < 4; i++)
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine();

            foreach (int item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();


            string[] Days = { "Son", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            foreach (string item in Days)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        internal static void MultiDimensionalArray()
        {
            // 다차원 배열
            // Set
            int[,] i1_2d = new int[3, 3];
            int[,,] i1_3d = new int[2, 3, 2];

            int[,] i2_2d = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };
            int[,,] i2_3d = new int[3, 2, 3] {
                   { {1,2,3}, {2,3,4} },
                   { {4,5,6}, {5,6,7} },
                   { {7,8,9}, {8,9,0} }
            };

            int[,] i3_2d = { { 1, 2 }, { 2, 3 }, { 3, 4 } };
            int[,,] i3_3d = {   { {1,2,3}, {2,3,4} },
                                { {4,5,6}, {5,6,7} },
                                { {7,8,9}, {8,9,0} } };

            // Use
            i2_2d[0, 1] = 99;
            i2_2d[2, 0] = 88;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(i2_2d[i, j]);
            }
            Console.WriteLine();

            foreach (int ii in i2_2d)
            {
                Console.Write(ii.ToString(), " ");
            }
            Console.WriteLine();

        }

        internal static void JaggedArray()
        {
            // 가변 배열
            // -- use --
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            int[][] jaggedArray3 =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            // --  --

            for (int row = 0; row < jaggedArray3.Length; row++)
            {
                for (int col = 0; col < jaggedArray3[row].Length; col++)
                {
                    Console.Write(jaggedArray3[row][col].ToString() + " ");
                }
            }
            Console.WriteLine();

            foreach (int[] items in jaggedArray3)
            {
                foreach (int item in items)
                {
                    Console.Write(item.ToString() + " ");
                }
            }
            Console.WriteLine();
        }

        internal static void RetrunAraayMethod1()
        {
            string[] days = { "Sun", "Mon", "Tue", "Wen", "Thu", "Fri", "Sat" };
            TransArray1(days);
            foreach (string day in days)
            {
                Console.Write(day + " ");
            }
        }

        static void TransArray1(string[] days)
        {
            string[] transDays = { "일", "월", "화", "수", "목", "금", "토" };

            for (int i = 0; i < days.Length; i++)
            {
                days[i] = transDays[i];
            }
        }

        internal static void RetrunAraayMethod2()
        {
            int[] nArrays1 = CreateArray(5);
            int[,] nArrays2 = CreateArray_2d(2, 3);

            foreach(int item in nArrays1)
                Console.Write(item);
            Console.WriteLine();

            for (int i = 0; i < nArrays2.GetLength(0); i++)
                for (int j = 0; j < nArrays2.GetLength(1); j++)
                    Console.Write(nArrays2[i, j]);
            Console.WriteLine();
        }

        static int[] CreateArray(int nSize)
        {
            int[] result = new int[nSize];
            for (int i = 0; i < nSize; i++)
            {
                result[i] = i;
            }

            return result;
        }

        static int[,] CreateArray_2d(int nRow, int nCol)
        {
            int index = 0;
            int[,] result = new int[nRow, nCol];
            for (int i = 0; i < nRow; i++)
                for (int j = 0; j < nCol; j++)
                {
                    result[i, j] = index++;
                }

            return result;
        }

        internal static void ClearArray()
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            Array.Clear(nArray1, 2, 3);
            foreach (int item in nArray1)
                Console.Write(item);
            Console.WriteLine();

            Array.Clear(nArray1, 0, nArray1.Length);
            foreach (int item in nArray1)
                Console.Write(item);
            Console.WriteLine();

        }

        internal static void CloneArray()
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            int[] cloneArray = (int[])nArray1.Clone();


            cloneArray[2] = 30;
            foreach (int item in nArray1)
                Console.Write(item);
            Console.WriteLine();
            foreach (int item in cloneArray)
                Console.Write(item);
            Console.WriteLine();


            string[] days = { "일", "월", "화", "수", "목", "금", "토" };
            string[] cloneDays = (string[]) days.Clone();
            foreach (string item in cloneDays)
                Console.Write(item);
            Console.WriteLine();
        }
    }
}