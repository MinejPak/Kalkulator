using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        struct Enacba
        {
            public char operatorji;
            public double stevila;
        }

        static void Main(string[] args)
        {
            var count1 = 0;
            var count2 = 0;
            Enacba[] enacba = new Enacba[6];
 
            for (var i = 0; i <= 6; i = i + 1)
            {
                if (count1 >= 4)
                {
                    break;
                }

                Console.WriteLine("{0}. Stevilo>", i + 1);
                enacba[i].stevila = Convert.ToDouble(Console.ReadLine());

                while (enacba[i].stevila < 0)
                {
                    Console.WriteLine("Vnešeno število mora biti pozitivno.");
                    Console.WriteLine("{0}. Stevilo>", i + 1);
                    enacba[i].stevila = Convert.ToDouble(Console.ReadLine());
                }
                count1++;

                if (count2 >= 3)
                {
                    break;
                }
                Console.WriteLine("{0}. Operator>", i + 1);
                enacba[i].operatorji = Convert.ToChar(Console.ReadLine());

                while (!(enacba[i].operatorji == '/' || enacba[i].operatorji == '*' || enacba[i].operatorji == '-' || enacba[i].operatorji == '+' || enacba[i].operatorji == '^'))
                {
                    Console.WriteLine("Vnešen operator mora biti eden izmed znakov (+, -, *, / ali ^).");
                    Console.WriteLine("{0}. Operator>", i + 1);
                    enacba[i].operatorji = Convert.ToChar(Console.ReadLine());
                }
                count2++;
            }
        }
    }
}
