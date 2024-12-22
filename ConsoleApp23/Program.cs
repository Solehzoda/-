using System;

namespace ConsoleApp23
{
    class Program
    { 
        static void chek(int a)
        {
            var d = a;
            if (d % 2 == 0)
            {
                Console.WriteLine("Чётное");
            }
            else
            {
                Console.WriteLine("Не чётное");
            }
        }

        static void Main(string[] args)
        {
            chek(1);
            chek(2);
        }
    }
}      
    
