/*decrease by a constant factor
Cutting a stick A stick n inches long needs to be cut into n 1-inch pieces. Outline an algorithm
that performs this task with the minimum number of cuts if several pieces of the stick can be
cut at the same time. Also give a formula for the minimum number of cuts.
4. Code the problem in C#
5. Show the tree of recursive calls if you use recursion
6. Find time and space complexity

 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int mincuts = 0;

        public static int cut(int n)
        {

            if (n > 1)
            {
                if (n / 2 == 0)
                {
                    n = cut(n / 2);
                    mincuts++;
                }

                else
                {
                    n = cut((n + 1) / 2);
                    mincuts++;
                }

           }

            return mincuts;

        }

        
        static void Main(string[] args)
        {

            Console.WriteLine("Input Length : ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("N number of cuts (with recursion) is: "+cut(n));



            int mincuts = 0;
            while (n != 1)
            {
                if (n == 1)
                {
                    break;
                }

                if (n / 2 == 0)
                {
                    n = n / 2;
                    mincuts++;
                }

                else
                {
                    n = (n + 1) / 2;
                    mincuts++;
                }

            }


            Console.WriteLine("N number of cuts (without recursion) is: " + mincuts);
        }
    }
}
