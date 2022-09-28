namespace Study_Base.DataType
{
    class DataType_0_WriteLine
    {
        internal static void WriteText()
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(true);
            Console.WriteLine("{0} {1} !!", "Hello", "World");

            // String 포멧 메타문자 옵션
            // https://docs.microsoft.com/ko-kr/dotnet/api/system.console.write?view=net-6.0
            // https://docs.microsoft.com/ko-kr/dotnet/standard/base-types/standard-numeric-format-strings
            Console.WriteLine("{0:C} {1:P} {0:X}", 123, 0.123f, 45);


        }
    }

}
