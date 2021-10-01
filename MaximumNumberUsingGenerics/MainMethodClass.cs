using System;

namespace MaximumNumberUsingGenerics
{
    class MainMethodClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Number");
            int output = UC3_MaximumString.MaximumIntegerNumber(22, 33, 44);
            Console.WriteLine(output);

            double doubleOutput = UC3_MaximumString.MaximumIntegerNumber(12.7, 80.56, 20.47);
            Console.WriteLine(doubleOutput);

            string stringOutput = UC3_MaximumString.MaximumStringNumber("Arun", "Hosur", "Shirahatti");
            Console.WriteLine(stringOutput);
        }
    }
}
