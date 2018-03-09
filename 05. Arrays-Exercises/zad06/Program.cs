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
            int numberMax = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    counter++;
                }
                else
                {
                    if (counterMax < counter)
                    {
                        counterMax = counter;
                        numberMax = numbers[i];
                    }
                    counter = 1;
                }
                if (i + 1 == numbers.Length - 1)
                {
                    if (counterMax < counter)
                    {
                        counterMax = counter;
                        numberMax = numbers[i];
                    }
                    counter = 1;
                }
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numberMax+" ");
            }
        }
    }
}
