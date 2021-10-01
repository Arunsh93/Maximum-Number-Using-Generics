using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberUsingGenerics
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return value;
        }

        public T MaxValue(params T[] values)
        {
            var sortedValues = Sort(value);
            return sortedValues[sortedValues.Length - 1];
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum  Value is: " + max);
        }
    }
}
