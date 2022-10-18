using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(4));
            Console.WriteLine(solution.solution(3));
        }
        public class Solution
        {
            public string solution(int num)
            {
                string answer = "";

                if (num % 2 == 0)
                {
                    answer = "Even";
                }
                else
                {
                    answer = "Odd";
                }
                return answer;
            }
        }
    }
}
