using System;
namespace baitap
{
    class b1
    {
        static void Main(String [] args)
        {
            int tong = 0;
            int n;
            Console.WriteLine("nhap so phan tu cua mang");
            n=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("nhap phan tu cua mang");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int i in a)
            {
                tong += i;
            }
            Console.WriteLine($"tong cua mang : {tong}");
        }
    }
}