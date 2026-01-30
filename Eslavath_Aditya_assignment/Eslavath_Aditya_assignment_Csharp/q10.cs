using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    internal class q10
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 10, 5, 20, 5, 10, 30 };

            Console.Write("Enter number to search: ");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int index = numbers.IndexOf(num);

            while (index != -1)
            {
                Console.WriteLine("Found at index: " + index);
                count++;
                index = numbers.IndexOf(num, index + 1);
            }

            Console.WriteLine("Total occurrences: " + count);
        }
    }
}
