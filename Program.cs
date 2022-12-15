using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int c = 20;


            //21 if else
            if (a > b && a > c)
            {
                Console.WriteLine("Bigger: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Bigger: " + b);
            }
            else
            {
                Console.WriteLine("Bigger: " + c);
            }

            //22 if else
            if (a < b && a < c)
            {
                Console.WriteLine("Smaller: " + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Smaller: " + b);
            }
            else
            {
                Console.WriteLine("Smaller: " + c);
            }                       

            //23
            if (a == b || b == c || c == a)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //24
            if (a == b && b == a || a == c && c == a || b == c && c == b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //25
            if ((a + b) > c && (a + c) > b && (c + b) > a)
            {
                Console.WriteLine("y=1");
            }
            else
            {
                Console.WriteLine("y=2");
            }

            //26
            if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                Console.WriteLine(1);
            }
            else { Console.WriteLine(2); }

            //27
            Console.Write("Tvabanakan progresia: ");
            if (b - a == c - b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //28
            Console.Write("Erkrachapakan progresia: ");
            if (b / a == c / b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //29
            if (a < b && a < c)
            {
                if (b < c)
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
                else
                {
                    Console.WriteLine($"{a} {c} {b}");
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
                else
                {
                    Console.WriteLine($"{b} {c} {a}");
                }
            }
            else if (c < a && c < b)
            {
                if (a < b)
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }

            //30
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
                else
                {
                    Console.WriteLine($"{a} {c} {b}");
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
                else
                {
                    Console.WriteLine($"{b} {c} {a}");
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
        }
    }
}
