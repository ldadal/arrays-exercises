using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad09
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            char[] letter = letters.ToArray();
            int[] ascii = new int[letter.Length];
            for (int i = 0; i < letter.Length; i++)
            {
                ascii[i] = letter[i];
                for (int j = 97; j <= 122; j++)
                {
                    if (ascii[i]==j)
                    {
                        Console.WriteLine(letter[i]+" -> "+(j-97));
                    }
                }
            }
        }
    }
}
