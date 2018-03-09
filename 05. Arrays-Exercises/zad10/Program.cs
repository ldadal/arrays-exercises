using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int equal = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length-1; j++)
                {
                    int sum = numbers[i] - numbers[j+1];
                    if (Math.Abs(sum)==equal)
                    {
                            counter++;
                    }
                }
            }

            Console.WriteLine(counter);

        }
    }
}
