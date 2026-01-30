using System;

namespace Eslavath_Aditya_assignment_Csharp
{
    class Numbers
    {
        public int x;
        public int y;

        public Numbers(int a, int b)
        {
            x = a;
            y = b;
        }
    }

    internal class q1
    {
        public static double[] CalculatePowers(Numbers[] arr)
        {
            double[] result = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = Math.Pow(arr[i].x, arr[i].y);
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Numbers[] arr = new Numbers[4];
            arr[0] = new Numbers(3, 3);
            arr[1] = new Numbers(2, 2);
            arr[2] = new Numbers(5, 4);
            arr[3] = new Numbers(16, 2);

            double[] results = CalculatePowers(arr);

            foreach (double n in results)
            {
                Console.WriteLine(n);
            }
        }
    }
}
