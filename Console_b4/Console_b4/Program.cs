using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập chuỗi ký tự:");
        string input = Console.ReadLine();

      
        string reversedString = new string(input.Reverse().ToArray());

        Console.WriteLine($"Chuỗi đảo ngược: {reversedString}");
    }
}
