using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class LinearSearch : SearchStrategy
    {
        public override int Search(double[] array, double number)
        {
            int arraySize = array.Length;
            for(int i=0; i<arraySize; i++)
            {
                if (array[i] == number)
                    return i;
            }
            return -1;
        }
    }
}
