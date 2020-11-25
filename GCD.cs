\*In the variable-size-decrease variety of decrease-and-conquer, the size-reduction pattern
varies from one iteration of an algorithm to another.
Problem:
Greatest common divisor of two nonnegative, not-both-zero integers m and n, denoted gcd(m,
n), is defined as the largest integer that divides both m and n evenly, i.e., with a remainder of
zero.*\



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcd
{
    class Program
    {

        public static int gcd(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }

            else
            {
                return gcd(y, x % y);

            }
        }
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Enter any two integers\t\tRemember that m should be greater than n");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int gcdd=0;
            for (int i = 1; i < m; i++)
            { if (m % i == 0 && n % i == 0)
                {
                    gcdd = i;
                }
            }
            Console.WriteLine("GCD is "+ gcdd);


            Console.WriteLine("GCD (with recursion) is:  " + gcd(m,n));


        }
    }
}
