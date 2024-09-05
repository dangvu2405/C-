using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_b1_2
{
     class b2
    {
       static void Main(string[] args)
        {
            Console.WriteLine("nhap chuoi ki tu:");
            string v1 = Convert.ToString(Console.ReadLine());
            v1.ToLower();
            v1.ToArray();
            int dem = 0;
            for (int i = 0; i < v1.Length; i++)
            {
               
                if (v1[i] >= 'a' && v1[i] <= 'z')
                {
                    dem++;
                }
            }
            Console.WriteLine($"so luong ki tu trong chuoi:{dem}");
        }
    }
}
