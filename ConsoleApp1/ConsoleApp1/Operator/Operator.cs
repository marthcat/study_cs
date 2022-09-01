using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base_1.Operator
{
    class A { }
    class B { }

    internal class Operator
    {
        internal static void UnaryOp()
        {
            bool bVal = true;
            Console.WriteLine(!bVal);

            int iVal = 12;
            Console.WriteLine("{0} {1} {2} {3}", +iVal, -iVal, ++iVal, --iVal);

            Console.WriteLine("{0} > {1}", iVal, Convert.ToString(iVal, 2));
            Console.WriteLine("{0} > {1}", ~iVal, Convert.ToString(~iVal,2) );
        }

        internal static void BinaryOp()
        {
            // 산술
            Console.WriteLine(+5);
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 + .5);
            Console.WriteLine(7 - 3);

            Console.WriteLine(7 * 3);
            Console.WriteLine(7 / 3);
            Console.WriteLine(7 % 3);

            // 문자열 합
            Console.WriteLine();
            Console.WriteLine("3" + ".14");
            Console.WriteLine(5.0f + "5");
            Console.WriteLine(3.14f + "5");

            // shift 연산자
            Console.WriteLine();
            Console.WriteLine(77 << 3); // bit 3 단위 좌측 시프트
            Console.WriteLine(77 >> 3); // bit 3 단위 우측 시프트 

            // 비교 >> bool 값
            Console.WriteLine();
            Console.WriteLine(7 == 3);
            Console.WriteLine(7 != 3);
            Console.WriteLine(7 > 3);
            Console.WriteLine(7 < 3);
            Console.WriteLine(7 >= 3);
            Console.WriteLine(7 <= 3);

            // 논리
            Console.WriteLine();
            Console.WriteLine(true & false); // AND  앞의 항 먼저 확인
            Console.WriteLine(true && false); // AND 두 항 전부 결과 확인
            Console.WriteLine(false | true); // OR  앞의 항 먼저 확인
            Console.WriteLine(false || true); // OR 두 항 전부 결과 확인
            Console.WriteLine(false ^ false); // XOR 두 항 전부 결과 확인
        }

        internal static void TypeCheckOper()
        {
            // 형식 호환 확인 연산자 is
            int val = 10;
            Console.WriteLine(val is int);
            Console.WriteLine(val is float);

            Console.WriteLine(val is object);
            object obj = val;
            Console.WriteLine(obj is int);
        }


        internal static void TypeChangeOper()
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;

            Console.WriteLine(test2 == null);
        }

        internal static void QuestionMarkOper()
        {
            // Check null and input select
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine(y);
            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);

            //
            Console.WriteLine();
        }

    }
}
