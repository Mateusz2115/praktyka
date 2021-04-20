using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5];
            for (int i = 0; i < 5; i++)
                tab[i] = i;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);

        }
    }
}
