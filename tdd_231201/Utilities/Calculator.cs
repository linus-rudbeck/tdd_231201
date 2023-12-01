using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_231201.Utilities
{
    internal class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public static int[] GetArray(int value,  int count)
        {
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = value;
            }

            return array;
        }
    }
}
