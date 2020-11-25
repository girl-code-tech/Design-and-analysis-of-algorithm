using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONACCI
{
    class Program
    {
        static int fibonacci(int n)
        {
            if (n<=1)
            {
                return n;
            }         
                return fibonacci(n - 1) + fibonacci(n - 2);
           }
        static void Main(string[] args)
        {
            //computing the nth fibonacci number
            Console.WriteLine(fibonacci(9));
        }
    }
}
