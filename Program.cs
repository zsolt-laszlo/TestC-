using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double atlag = 0.00;
            double szorzata = 1;


            for (int i = 0; i <= 10; i++) 
            {
                sum += i;
               
            }



            int j = 1;
            while(j<=10)
            {
                szorzata = szorzata * j;
                j++;
            }

            atlag = sum / 10;
            Console.WriteLine("Szamok osszege:");
            Console.WriteLine(sum);
            Console.WriteLine("Szamok atlaga:");
            Console.WriteLine(atlag);
            Console.WriteLine("Szamok szorzata:");
            Console.WriteLine(szorzata);




            Console.ReadKey();
        }
    }
}
