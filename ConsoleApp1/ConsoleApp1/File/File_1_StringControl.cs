using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base_1.File
{
    internal class File_1_StringControl
    {
        internal static void SplitString()
        {
            string str = "국어: 90 영어: 100 수학: 70";
            string[] str_element = str.Split(' ');
            //string[] str_element = str.Split(new char[] {' '});

            int kor = int.Parse( str_element[1]);
            int eng = int.Parse(str_element[3]);
            int math = int.Parse(str_element[5]);
            int total = kor + eng + math;
            float avg = total / 3.0f;
            Console.WriteLine("{0} {1} {2}  // {3}  // {4}", kor, eng, math, total, Math.Round(avg));
        }
    }
}
