using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base.File
{
    internal class File_2_Binary
    {
        internal static void BinaryWrite()
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream("test.dat", FileMode.Create)))
            {
                bw.Write(12);
                bw.Write(3.14f);
                bw.Write("Hello World!");
            }
        }

        internal static void BinaryRead()
        {
            using (BinaryReader br = new BinaryReader(System.IO.File.Open("test.dat", FileMode.Open)))
            {
                int var1 = br.ReadInt32();
                float var2 = br.ReadSingle();
                string str1 = br.ReadString();

                Console.WriteLine("{0} {1} {2}", var1, var2, str1);
            }
        }
       


    }
}
