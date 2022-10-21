using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution m_solution = new Solution();
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(m_solution.solution(arr));
        }
    }
    class Solution
    {
        public double solution(int[] arr)
        {
            double sum = 0;
            foreach (int num in arr)
                sum += num;
            double answer = sum / arr.Length;
            return answer;
        }
    }
}
