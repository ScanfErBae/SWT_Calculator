using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Calc
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Sub(double a, double b)
    {
        return a - b;
    }

    public double Multi(double a, double b)
    {
        return a * b;
    }

    public double Power(double x, double exp)
    {
        return Math.Pow(x, exp);
    }

}

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Calc test = new Calc();
            Console.WriteLine(test.Add(2, 2));
            Console.WriteLine(test.Sub(4,2 ));
            Console.WriteLine(test.Multi(3, 3));
            Console.WriteLine(test.Power(3, 3));

        }
    }
}
