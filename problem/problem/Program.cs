using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    class Program
    {
        static int reverse(int x)
        {
            int y = 0;
            do
            {

                y = x % 10 + y * 10;
                x = x / 10;
            } while (x > 0);
            return y;
        }
        static bool odd(int a)
        {
            bool i = true;
            while (a > 0 && i == true)
            {
                int y = a;
                a = a / 10;
                int x = a * 10;
                int z = y - x;
                if (z == 0 || z == 2 || z == 4 || z == 6 || z == 8)
                {
                    i = false;
                }
                else i = true;
            }

            return i;

        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i <= 1000000000; i++)
            {
                if (i % 10 != 0)
                {
                    a = i + reverse(i);
                    if (odd(a) == true)
                    {
                        b++;
                    }
                }
            }

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}

    

