using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Study_Base_1.DataType
{
    public struct MyStruct1
    {
        public const float PI = 3.14f; // 변경 불가능
        public static int Age = 12;  // 변경 가능
        public int val;  // 변수 선언으로만 호출 가능
    }

    public struct MyStruct2
    {
        public int Age;
        public MyStruct2(int InAge)
        {
            Age = InAge;

        }
    }

    public struct MyStruct3
    {
        public int Age;
    }

    class MyClass
    {
        public int Age;
    }

    public struct MyStruct4
    {
        public int Age;
        public float Num2;
        public bool IsReady;
    }

    public struct MyStruct5
    {

        public int Kor, Eng, Math, Total;
        public float Avg;

        public void Compute()
        {
            Total = Kor + Eng + Math;
            Avg = Total / 3.0f;
        }
    }

    internal class DataType_4_Structure
    {
        internal static void UseStruct1()
        {
            Console.WriteLine("{0} {1}", MyStruct1.PI, MyStruct1.Age);
            //Console.WriteLine(MyStruct.val); // 오류

            //MyStruct.PI = 3.141592f; //오류
            MyStruct1.Age = 111;
        }
        internal static void UseStruct2()
        {
            MyStruct2 TestStruct1;
            TestStruct1.Age = 12;
            Console.WriteLine(TestStruct1.Age);

            MyStruct2 TestStruct2 = new MyStruct2();
            Console.WriteLine(TestStruct2.Age);

            MyStruct2 TestStruct3 = new MyStruct2(13);
            Console.WriteLine(TestStruct3.Age);
        }

        internal static void UseStruct3()
        {
            MyStruct3 TestStruct1, TestStruct2;
            TestStruct1.Age = 12;
            //Console.WriteLine(TestStruct2.Age); // 오류
            TestStruct2 = TestStruct1;
            Console.WriteLine(TestStruct2.Age);


            MyStruct3 test = new MyStruct3();
            Console.WriteLine(test.Age); // 오류가 아님 : 0으로 초기화됨

        }

        internal static void UseStruct4()
        {
            MyStruct3 test1 = new MyStruct3(); // 값 형식
            test1.Age = 12;
            MyStruct3 test2 = test1;
            test2.Age = 23;
            Console.WriteLine("{0} {1}", test1.Age, test2.Age);

            MyClass test3 = new MyClass();  //참조 형식
            test3.Age = 12;
            MyClass test4 = test3;
            test4.Age = 23;   // 참조 '대상'의 값을 변경, 참조는 test3 4 가 같으므로 같이 변경된다.
            Console.WriteLine("{0} {1}", test3.Age, test4.Age);

        }

        internal static void UseStruct5()
        {
            MyStruct4 test = new MyStruct4();
            Console.WriteLine("{0} {1} {2}", test.Age, test.Num2, test.IsReady);
        }

        // 구조체는 구조체 또는 클래스에 상속 불가
        // 구조체는 인터페이스를 상속 받아 메서드 구현 가능        
        internal static void UseStruct6()
        {
            MyStruct5 test = new MyStruct5();
            test.Kor = 80;
            test.Eng = 90;
            test.Math = 88;
            test.Compute();

            Console.WriteLine("{0} + {1} + {2} = {3}  // AVG : {4:f1}",
                test.Kor, test.Eng, test.Math, test.Total, test.Avg);

        }
    }

}
