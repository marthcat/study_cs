namespace Study_Base.DataType
{
    class DataType_5_Enumerable
    {
        enum Days1 { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };
        enum Days2 : byte { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };

        internal static void UseEnum1()
        {
            int nValue = (int)Days1.Mon;
            Days1 day = Days1.Tue;
            Console.WriteLine("{0} {1}", nValue, day);
        }

        internal static void UseEnum2()
        {
            byte nValue = (byte)Days2.Mon;
            Days2 day = Days2.Tue;
            Console.WriteLine("{0} {1}", nValue, day);
        }
    }

}
