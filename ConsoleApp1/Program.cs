// See https://aka.ms/new-console-template for more informatio
//
//
//
using System;
namespace  ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter your message: ");
           string str = Console.ReadLine() ?? string.Empty;
           string revStr = ReverseString(str) ;
           Console.WriteLine("Reversed is equal to: ==>" + revStr);
           Console.ReadLine();

        }

        static string ReverseString(string str)
        {
            char[] charList = str.ToCharArray();
            Array.Reverse(charList);
            return new string(charList);
        }
    }
};                                   