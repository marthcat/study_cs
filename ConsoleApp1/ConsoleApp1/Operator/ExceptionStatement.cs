using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Base_1.Operator
{
    internal class ExceptionStatement
    {
        internal static void TryCatch()
        {
            int[] array = { 1, 2, 3 };
            try
			{
                array[3] = 10;
            }
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine("-- 인덱스 예외 --");
                Console.WriteLine(iore.Message);

                array[2] = 9;
            }
            catch (Exception e)
            {
                Console.WriteLine("-- 에러 --");
                Console.WriteLine(e.Message);

                array[2] = 0;
            }
            //catch (Exception)
			//{

			//	throw;
			//}
            finally
            {
                array[0] = 0;
                Console.WriteLine("Finally");
            }

            foreach(int i in array) 
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
        internal static void TryCatch_throw()
        {
            try
            {
                int[] test = { 1, 2, 3, 4, 5, 6 };

                foreach(int i in test)
                {
                    if (i > 4)
                        throw new IndexOutOfRangeException("sssssssssss");
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("에러 ----");
                Console.WriteLine(e.ToString());
            }

            
        }

    }
}
