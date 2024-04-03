using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Norbi
            const int MAXN = 10;
            int[] szamok = new int[MAXN];

            Random rnd = new Random();

            for (int i = 0; i < MAXN; i++)
            {
                szamok[i] = rnd.Next(0, 101);
            }
            /*
            foreach (int item in szamok)
            {
                Console.Write(item+",");
            }
            */


            Console.WriteLine("\nNyomjad neki");
            Console.ReadKey();
        }
    }
}
