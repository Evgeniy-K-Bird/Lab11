using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStuct first = new MyStuct { K = 1.2, B = 12.5 };
            first.Root();
            Console.ReadKey();

        }
    }
   struct MyStuct
    {
        double k;
        double b;
        public double result;
        public double K
        {
            set
            {
                if (value > 0)
                {
                    k = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть больше 0");
                }
            }
            get
            {
                return k;
            }
        }
        public double B
        {
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть больше 0");
                }
            }
            get
            {
                return b;
            }
        }
        public void Root()
        {
            result = (-1 * b) / k;
            Console.WriteLine(result); // 0=kx+b   =   -b=kx   =   -b/k=x
        }
    }
}