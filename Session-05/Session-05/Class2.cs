using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    class Multiplier
    {
        public int[] MultiplyArrays(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length * array2.Length];
            int counter = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    result[counter] = array1[i] * array2[j];
                    counter++;
                }
            }
            return result;
        }
    }
}
