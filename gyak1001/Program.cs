using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Security.Policy;

namespace gyak1001
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        //nev10
        {
            int[] tomb = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Lakatos Balázs");
            }

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("Az {0}.-szám négyzete: {1}", i, i * i);
            }

            int value = 2;
            for (int power = 0; power <= 32; power++)
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} ");

            Console.WriteLine("100-ig a páratlan  számok csökkenő sorrendben: ");
            for (int i = 100; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
            //////visszaszamol
            //for (int i = 0; i < 1000000000; i++)
            //{
            //    if (i == 1000000000)
            //    {
            //        Console.WriteLine("Hamarosan kilép a program");
            //    }
            //}
            //for (int i = 0; i < 10000; i++)
            //{

            //}

            //System.Environment.Exit(1);

            for (int i = 0; i < 200; i++)
            {
                var k = "*";

                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth - k.Length),
                    rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write(k);
            }


            Console.ReadKey(true);
        }
    }
}
