using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string[] a = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] b = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
            string[] c = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] d = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        Restart: Console.Write("Your number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 999 || num < 0)
            {
                Console.WriteLine("Enter a number from 0 to 999 !");
                goto Restart;
            }

            Console.WriteLine("-----------------");

            // For numbers less than 10
            if (num.ToString().Length == 1)
            {
                Console.Write(a[num]);
                Console.ReadKey();
            }

            //For numbers less than 100
            else if (num.ToString().Length == 2)
            {
                if (num / 10 == 1)
                {
                    Console.Write(d[num - 10]);
                }
                else
                {
                    Console.Write(b[(num / 10) - 2]);
                    Console.Write(" ");
                    Console.Write(c[(num % 10)]);
                }
                Console.ReadKey();
            }

            //For numbers less than 1000
            else if (num.ToString().Length == 3)
            {
                Console.Write(c[(num / 100)]);
                Console.Write(" Hundred");
                if ((num % 100) == 0)
                {
                    goto End;
                }
                else if ((num % 100) < 10)
                {
                    Console.Write(" ");
                    Console.Write(a[(num % 100)]);
                }
                else if ((num % 100) / 10 == 1)
                {
                    Console.Write(" ");
                    Console.Write(d[(num % 100) - 10]);
                }
                else if ((num % 100) / 10 != 1)
                {
                    Console.Write(" ");
                    Console.Write(b[((num % 100) / 10) - 2]);
                    Console.Write(" ");
                    Console.Write(c[((num % 100) % 10)]);
                }
            End: Console.ReadKey();
            }
        }
    }
}