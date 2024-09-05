using System;
namespace b3
{
    class baitap
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"phan tu lon nhat cua mang : {max}");
        }
    }
}