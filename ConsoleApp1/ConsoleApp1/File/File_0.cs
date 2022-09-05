using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Study_Base_1.File_
{
    internal class File_0
    {

        internal static void WriteFile1()
        {
            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello world!";

            FileStream fs = new FileStream("text1.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(value);
            sw.WriteLine(value2);
            sw.Write(str1);
            sw.Close();
        }

        internal static void WriteFile2()
        {
            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello world!";

            using (StreamWriter sw = new StreamWriter(new FileStream("text2.txt", FileMode.Create)))
            {
                sw.WriteLine(value);
                sw.WriteLine(value2);
                sw.Write(str1);
            }
        }

        internal static void WriteFile3()
        {
            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello world!";

            using (StreamWriter sw = new StreamWriter("text3.txt")) // 쓰기만 가능
            {
                sw.WriteLine(value);
                sw.WriteLine(value2);
                sw.Write(str1);
            }
        }

        internal static void ReadFile1()
        {
            FileStream fs = new FileStream("text3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //string str = sr.ReadToEnd();
            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine()); 
            string str1 = sr.ReadLine();
            Console.WriteLine("{0}   /   {1}   /   {2}", value, value2, str1);

            sr.Close();
        }

        internal static void ReadFile2()
        {
            using (StreamReader sr = new StreamReader(new FileStream("text3.txt", FileMode.Open, FileAccess.Read)))
            {
                //string str = sr.ReadToEnd();
                int value = int.Parse(sr.ReadLine());
                float value2 = float.Parse(sr.ReadLine());
                string str1 = sr.ReadLine();

                Console.WriteLine("{0}   /   {1}   /   {2}", value, value2, str1);
            }
        }
        internal static void ReadFile3()
        {
            using (StreamReader sr = new StreamReader("text3.txt"))
            {
                //string str = sr.ReadToEnd();
                int value = int.Parse(sr.ReadLine());
                float value2 = float.Parse(sr.ReadLine());
                string str1 = sr.ReadLine();

                Console.WriteLine("{0}   /   {1}   /   {2}", value, value2, str1);
            }
        }
    }
}
