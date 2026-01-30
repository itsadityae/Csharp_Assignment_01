using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    internal class q2
    {
        static Dictionary<int, double> CalculateRoots(int[] arr)
        {
            Dictionary<int, double> dict = new Dictionary<int, double>();

            foreach (int n in arr)
            {
                dict[n] = Math.Sqrt(n);
            }

            return dict;
        }

        static void PrintDictionary(Dictionary<int, double> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, double> result = CalculateRoots(arr);
            PrintDictionary(result);
        }
    }
}
