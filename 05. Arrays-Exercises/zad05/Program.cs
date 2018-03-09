using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad05
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool isFirst = false;

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (first[i] < second[i])
                {
                    isFirst = true;
                    break;
                }
                else if (first[i] > second[i])
                {
                    isFirst = false;
                    break;
                }
                if (i == Math.Min(first.Length, second.Length)-1)
                {
                    if (first.Length < second.Length)
                    {
                        isFirst = true;
                    }
                    else
                    {
                        isFirst = false;
                    }
                }
            }

            if (isFirst)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }

        }
    }
}
