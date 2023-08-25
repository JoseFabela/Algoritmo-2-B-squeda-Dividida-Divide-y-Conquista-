using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_2_Búsqueda_Dividida__Divide_y_Conquista_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 12, 9, 20, 3, 15, 8 };

            int maxNumber = FindMaxDivideAndConquer(numbers, 0, numbers.Count - 1);

            Console.WriteLine($"The maximum number in the list is: {maxNumber}");
            Console.ReadLine();
             }
        static int FindMaxDivideAndConquer(List<int> numbers, int low, int high)
        {
            if (low == high)
                return numbers[low];

            int mid = (low + high) / 2;
            int leftMax = FindMaxDivideAndConquer(numbers, low, mid);
            int rightMax = FindMaxDivideAndConquer(numbers, mid + 1, high);

            return Math.Max(leftMax, rightMax);
        }
    }
}
