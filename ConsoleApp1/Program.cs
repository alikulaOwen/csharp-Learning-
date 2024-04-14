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
           Console.Write("Enter your password: ");
           string str = Console.ReadLine() ?? string.Empty;
           string valid = PaawordChecker(str);
           Console.WriteLine(valid);
           Console.ReadLine();

        }

        static string PaawordChecker(string str)
        {
            if(str.Length < 8)
            {
                return "Password is too short";
            }
            else if(str.Length > 20)
            {
                return "Password is too long";
            }
            else if(str.Contains(" "))
            {
                return "Password cannot contain spaces";
            }
            else if(str.Contains("password"))
            {
                return "Password cannot contain the word password";
            }else if(str.Contains("123456"))
            {
                return "Password cannot contain 123456";
            } 
            else
            {
                return "Password is valid";
            }
        }
        
    }
};                                   