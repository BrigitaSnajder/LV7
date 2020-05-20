using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberSequence sequence = new NumberSequence(new double[] { 8, 2, 1, 7, 6, 5, 4, 3, 10, 9 });
            NumberSequence sequencebubble = sequence;
            NumberSequence sequencecomb = sequence;
            sequence.SetSortStrategy(new SequentialSort());
            sequencebubble.SetSortStrategy(new BubbleSort());
            sequencecomb.SetSortStrategy(new CombSort());
            sequence.Sort();
            Console.WriteLine("Sequential sort:");
            Console.WriteLine(sequence.ToString());
            sequencebubble.Sort();
            Console.WriteLine("Bubble sort:");
            Console.WriteLine(sequencebubble.ToString());
            sequencecomb.Sort();
            Console.WriteLine("Comb sort:");
            Console.WriteLine(sequencecomb.ToString());

            sequence.SetSearchStrategy(new LinearSearch());
            int index=sequence.Search(11);
            if(index != -1)
            {
                Console.WriteLine("Index of given number in the array: " + index);
            }
            else
            {
                Console.WriteLine("There is not given number in the array!");
            }
            int index1 = sequence.Search(10);
            if (index1 != -1)
            {
                Console.WriteLine("Index of given number in the array: " + index1);
            }
            else
            {
                Console.WriteLine("There is not given number in the array!");
            }
        }
    }
}
