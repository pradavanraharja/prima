using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Hello
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan bilangan prima: ");
            bool prima = true;
            int bilangan = int.Parse(Console.ReadLine());

            if (bilangan >= 2)
            {
                for (int i = 2; i <= bilangan; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }
                    if (prima)
                        Console.WriteLine(i);
                    prima = true;
                }
            }
            else
            {
                Console.WriteLine("Bukan bilangan prima");
            }
          Console.ReadLine();
        }
    }
}