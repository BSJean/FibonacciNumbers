using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    public class Program  //public set for unit tests
    {
        static void Main(string[] args)
        {
            foreach (int n in FibonacciNumbers(20))
            {
                Console.WriteLine(n);
            }
        }

        public static List<int> FibonacciNumbers(int count)  //public set for unit tests
        {
            List<int> numbers = new List<int> { 1, 1 };
            if (count <= 0)
                throw new ArgumentException("Count Cannot Be Less Or Equal Zero.");
            if (count == 1)
                return new List<int> { 1 };
                checked
            {
                try
                {
                    while (numbers.Count < count)
                    {
                        numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);
                    }
                }
                catch (OverflowException)
                {
                    throw new OverflowException($"Number Is More Than {int.MaxValue}.");
                }
            }     
            return numbers;
        }
    }
}
