using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int.TryParse(Console.ReadLine(), out int n);
            int[] num = new int[n];
            string[] numStr = Console.ReadLine().Split(' ');
            List<int>[] abcd = new List<int>[n];
            for (int i = 0; i < numStr.Length; i++)
            {
                int.TryParse(numStr[i], out num[i]);
                for(int j = 0; j< num[i]; j++)
                {
                    if (num[i] % j == 0) abcd[i].Add(j);
                }
            }
            for(int i = 0; i < num.Length;)
        }
    }
}
