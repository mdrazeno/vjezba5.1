using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("unesi neki broj:");
            n = int.Parse(Console.ReadLine());
           Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                 Console.WriteLine(GenerateDigit(rng));
            }
            Console.ReadLine();
        }

                static int GenerateDigit(Random rng)
                {
                  return rng.Next(10); 
                }
        }
    }






