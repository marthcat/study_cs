
namespace ConsoleApp
{
    class Program_1_Input
    {
        internal static void Read_Key()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.A)
                    Console.WriteLine("A 또는 a 키 눌림");
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
        internal static void Read_KeyChar()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                Console.Write(keyInfo.KeyChar);
                if (keyInfo.KeyChar == 'A') // 대소문자 구분
                    Console.WriteLine("A키 눌림");
            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        internal static void Read_Line()
        {
            int Kor, Eng, Math, Total;
            float Avg;

            Console.Write("국어 점수 : ");
            Kor = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine();

            Console.Write("영어 점수 : ");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("수학 점수 : ");
            Math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Total = Kor + Eng + Math;
            Avg = Total / 3.0f;

            Console.WriteLine("{0} + {1} + {2} = {3}  // AVG : {4:f1}", Kor, Eng, Math, Total, Avg);

        }
    }

}
