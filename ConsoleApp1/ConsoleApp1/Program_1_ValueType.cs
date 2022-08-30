
using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    class Program_1_ValueType
    {
        static bool BoolVar;
        internal static void WriteBool()
        {
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", LocalBoolVar, BoolVar);

        }

        internal static void WriteCharacterCode()
        {
            Char Mun = '7';
            int Num = Mun;
            Num = Num + 1;
            Console.WriteLine("Mun = {0}, 문자 상수값 = {1}, 유니코드 문자 = {2}", (int)Mun, Num, (char)Num);

            Mun = (char)Num;
            Console.WriteLine(Mun);
        }

        internal static void WriteCalcIntegerNumberics()
        {
            int Result;
            byte x = 1, y = 2;
            Result = x + y;
            Console.WriteLine(Result);

        }
        
        internal static void WriteIntegerTypeRange()
        {
            Console.WriteLine("Int = {0} ~ {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Uint = {0} ~ {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Short = {0} ~ {1}", short.MinValue, short.MaxValue);
        }
        
        internal static void WriteFloatTypes()
        {
            double dblVal = 3.141;
            float fltVal = 1.3579f;

            Console.WriteLine("{0}, {1}, {2}", dblVal, fltVal);
        }
        internal static void WriteStringConnect()
        {
            string str1 = "Hello ";
            string str2 = "World!";
            string str3 = str1 + str2;
            string str4 = "Progra" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);

            if (str3 == "Hello World!")
            {
                Console.WriteLine("같음");
            }
            else
            {
                Console.WriteLine("다름");

            }

            Console.WriteLine(str3.Length);
        }


        internal static void WriteVar()
        {
            var val1 = 3.14f;
            float val2 = 10.0f;
            float sum = val1 + val2;
            Console.WriteLine("{0} + {1} = {2} ", val1, val2, sum);
        }

        internal static void WriteNullable()
        {
            int? Num1 = null;
            if (Num1.HasValue)
                Console.WriteLine("올바른 값");
            else
                Console.WriteLine("null 값");

            Console.WriteLine("null : {0}", Num1);

        }

        internal static void WriteConvertType()
        {
            Console.WriteLine(123.ToString());
            Console.WriteLine(Convert.ToInt32("1"));
            Console.WriteLine(Convert.ToSingle("3.131"));
            Console.WriteLine(float.Parse("3.14"));

            float fVal = 0.0f;
            float.TryParse("3.15", out fVal);
            Console.WriteLine("{0} : {1}", fVal.GetType().ToString(), fVal);            
        }
    }

}
