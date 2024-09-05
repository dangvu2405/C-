using System;
using System.Linq;
using System.Net;

class b5
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("nhap so luong phan tu:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a= new int [n];
        Console.WriteLine(" nhap mang :");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
            
        int size =a.Length-1;
        int dem = 0;
        int dk = a.Length / 2;
        Console.WriteLine("kiem tra xem mang co doi xung khong:");
        for (int i = 0; i < dk; i++)
        {
            if (a[i] == a[size])
            {
                dem++;
            }
            size--;
        }
        
        if (dem == dk)
        {
            Console.WriteLine("mang nay doi xung");
        }
        else
        {
            Console.WriteLine("mang nay khong doi xung");
        }
    }
}
