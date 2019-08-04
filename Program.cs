using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Factorial
{

    public class MyMathFunctions
    {
        public static int Factorial(int value)
        {
            if (value < 0)
            {
                string s = String.Format(
                    "Illegal negative argument to Factorial {0}", value);
                throw new ArgumentException(s);
            }


            int factorial = 1;
            do
            {
                factorial *= value;
            } while (--value > 1);

            return factorial;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
