using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base.File
{
    internal class File_3_Serialize
    {
        [Serializable]
        struct DATA
        {
            public int var1;
            public float var2;
            public string str1;
        }

        internal static void Serialize_()
        {
            DATA[] data = new DATA[2];

            data[0].var1 = 1;
            data[0].var2 = 0.5f;
            data[0].str1 = "테스트1";
            data[1].var1 = 2;
            data[1].var2 = 1.5f;
            data[1].str1 = "테스트2";

            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                // BinaryFormatter 관련 .Net5.0 이슈
                // https://learn.microsoft.com/ko-kr/dotnet/core/compatibility/core-libraries/5.0/binaryformatter-serialization-obsolete        
                bf.Serialize(fs1, data);

            }

            DATA[] ResultData;

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA[])bf2.Deserialize(fs2);
            }

            for (int i = 0; i < ResultData.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1, ResultData[i].var2, ResultData[i].str1);
            }
        }

        [Serializable]
        struct DATA2
        {
            public int var1;
            public float var2;

            [NonSerialized]
            public string str1;
        }

        internal static void Deserialize_()
        {

            DATA2[] data = new DATA2[2];

            data[0].var1 = 1;
            data[0].var2 = 0.5f;
            data[0].str1 = "테스트1";
            data[1].var1 = 2;
            data[1].var2 = 1.5f;
            data[1].str1 = "테스트2";

            using (FileStream fs1 = new FileStream("test2.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();  
                bf.Serialize(fs1, data);

            }

            DATA2[] ResultData;

            using (FileStream fs2 = new FileStream("test2.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA2[])bf2.Deserialize(fs2);
            }

            for (int i = 0; i < ResultData.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1, ResultData[i].var2, ResultData[i].str1);
            }
        }

        [Serializable]
        struct Data
        {
            public int data;
            public string str;

            public Data(int data1, string str1)
            {
                data = data1;
                str = str1;
            }

        }

        internal static void Serialize_Collection_()
        {
            List<Data> DataList = new List<Data>();

            DataList.Add(new Data(7, "test1"));
            DataList.Add(new Data(12, "test2"));
            DataList.Add(new Data(12, "test2"));
            DataList.Add(new Data(12, "test2"));
            DataList.Add(new Data(12, "test2"));

            using(FileStream fs1 = new FileStream("test3.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, DataList);
            }

            List<Data> ResultList;
            using (FileStream fs2 = new FileStream("test3.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultList = (List<Data>)bf2.Deserialize(fs2);
            }

            for (int i = 0; i < ResultList.Count; i++)
            {
                Console.WriteLine("{0} {1}", ResultList[i].data, ResultList[i].str);
            }

        }
    }
}
