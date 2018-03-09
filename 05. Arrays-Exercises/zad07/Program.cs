using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int end = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] <numbers[i + 1])
                {
                    counter++;
                    if (counterMax < counter)
                    {
                        counterMax = counter;
                        end = i+1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            int[] result = new int[counterMax];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = numbers[end - counterMax + 1 + i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
