using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] upper = new int[k * 2];
            int[] lower = new int[k * 2];
            int[] sum = new int[k * 2];

            for (int i = 0; i < k * 2; i++)
            {
                lower[i] = numbers[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                upper[i] = numbers[k - 1 - i];
                upper[i + k] = numbers[4 * k - 1 - i];
            }
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = lower[i] + upper[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
