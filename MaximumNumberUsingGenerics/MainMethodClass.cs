using System;

namespace MaximumNumberUsingGenerics
{
    class MainMethodClass
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Find Maximum Number");
            int output = GenericMaximum.MaximumIntegerNumber(22, 33, 44);
            Console.WriteLine(output);

            double doubleOutput = GenericMaximum.MaximumIntegerNumber(12.7, 80.56, 20.47);
            Console.WriteLine(doubleOutput);

            string stringOutput = GenericMaximum.MaximumStringNumber("Arun", "Hosur", "Shirahatti");
            Console.WriteLine(stringOutput);*/

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 11.2, 12.3, 13.4, 14.5, 15.6 };
            GenericMaximum<double> generic1 = new GenericMaximum<double>(doubleArray);
            generic1.PrintMaxValue();

            string[] stringArray = { "Arun", "Nagaling", "Jyotiprasad", "Chetan", "Rachoti" };
            GenericMaximum<string> generic2 = new GenericMaximum<string>(stringArray);
            generic2.PrintMaxValue();
        }
    }
}
