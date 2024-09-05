using System;
namespace baitap
{
    class b6
    {
        static void Main(string[] args)
        {
            string names = Convert.ToString(Console.ReadLine());
            names.ToArray();
            Console.WriteLine(" ki tu can tim so lan :");
            char kitu = Convert.ToChar(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < names.Length - 1; i++) {
                    if (names[i]== kitu ) {
                        dem++;
                    }
                
            }
            Console.WriteLine($" ki tu {kitu} xuat hien {dem} lan");
        }
    }
}