using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Calc
{
    public double Add(double a, double b)
    {
        Accumulator = a + b;
        return Accumulator;
    }

    public double Sub(double a, double b)
    {
        Accumulator = a - b;
        return Accumulator;
    }

    public double Multi(double a, double b)
    {
        Accumulator = a * b;
        return Accumulator;
    }

    public double Power(double x, double exp)
    {
        Accumulator = Math.Pow(x, exp);
        return Accumulator;
    }

    public double Divide(double dividend, double divisor)
    {
        Accumulator = dividend / divisor;
        return Accumulator;
    }

    public double Accumulator { get; private set; }

    public void Clear()
    {
        Accumulator = 0.0;
    }

    public double Sqrt(double x)
    {
        Accumulator = Math.Sqrt(x);
        return Accumulator;
    }

    public double Add(double addend)
    {
        Accumulator += addend;
        return Accumulator;
    }

    public double Subtract(double subtractor)
    {
        Accumulator -= subtractor;
        return Accumulator;
    }

    public double Multiply(double multiplier)
    {
        Accumulator *= multiplier;
        return Accumulator;
    }

    public double Divide(double divisor)
    {
        Accumulator /= divisor;
        return Accumulator;
    }

    public double Power(double exponent)
    {
        Accumulator = Math.Pow(Accumulator, exponent);
        return Accumulator;
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
            Console.WriteLine(test.Sqrt(9));

        }
    }
}
