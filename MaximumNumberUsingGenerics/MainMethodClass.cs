using System;

namespace MaximumNumberUsingGenerics
{
    class MainMethodClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Number");
            int output = UC1_MaximumNumber.MaximumIntegerNumber(22, 33, 44);
            Console.WriteLine(output);

            double doubleOutput = UC1_MaximumNumber.MaximumIntegerNumber(12.7, 20.47, 80.56);
            Console.WriteLine(doubleOutput);
        }
    }
}
