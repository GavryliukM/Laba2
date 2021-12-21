using System;

namespace LB2
{
    public class LB2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int max = arr[0];

            Console.WriteLine("Enter values:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < 0)
                    arr[i] = max;
            Console.WriteLine("Result:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
