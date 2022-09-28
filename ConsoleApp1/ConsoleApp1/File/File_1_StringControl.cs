using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base.File
{
    struct GRADE 
    {
        public int kor, eng, math, total;
        public float average;

    }

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

        internal static void SplitString2()
        {
            string str;
            Console.Write("성척처리 학생수");
            int nCount = int.Parse(Console.ReadLine());
            Console.WriteLine("국영수 순서");


            GRADE[] Grade = new GRADE[nCount];
            float average;
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("학생수: {0}", nCount);
            for( int i = 0; i< nCount; i++ )
            {
                str = Console.ReadLine();
                string[] DataString = str.Split(new char[]{ ' ' });
                Grade[i].kor = int.Parse(DataString[0]);
                Grade[i].eng = int.Parse(DataString[1]);
                Grade[i].math = int.Parse(DataString[2]);
                Grade[i].total = Grade[i].kor + Grade[i].eng + Grade[i].math;

                Grade[i].average = (int)Math.Round(Grade[i].total / 3.0f);
            }

            for (int i = 0; i < nCount; i++) 
            {
                sw.WriteLine("{0} + {1} + {2} = {3}  /// {4}",
                    Grade[i].kor,
                    Grade[i].eng,
                    Grade[i].math,
                    Grade[i].total,
                    Grade[i].average
                );
            }
            sw.Close();
        }
    }
}
