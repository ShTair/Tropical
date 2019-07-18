using System;

namespace Tropical
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<double>.Add = (t1, t2) => Math.Min(t1, t2);
            Matrix<double>.Multiply = (t1, t2) => t1 + t2;
            
            var a = new Matrix<double>(new double[,] {
{double.PositiveInfinity,   1,  10, double.PositiveInfinity,    double.PositiveInfinity,    double.PositiveInfinity,    double.PositiveInfinity},
{5, double.PositiveInfinity,    1,  6,  7,  double.PositiveInfinity,    double.PositiveInfinity},
{10,    3,  double.PositiveInfinity,    7,  double.PositiveInfinity,    1,  double.PositiveInfinity},
{double.PositiveInfinity,   6,  7,  double.PositiveInfinity,    3,  double.PositiveInfinity,    5},
{double.PositiveInfinity,   7,  double.PositiveInfinity,    3,  double.PositiveInfinity,    double.PositiveInfinity,    7},
{double.PositiveInfinity,   double.PositiveInfinity,    8,  double.PositiveInfinity,    double.PositiveInfinity,    double.PositiveInfinity,    1},
{double.PositiveInfinity,   double.PositiveInfinity,    double.PositiveInfinity,    5,  7,  8,  0}}
);

            Console.WriteLine(a[6, 0]);

            a = a * a;
            Console.WriteLine(a[6, 0]);

            a = a * a;
            Console.WriteLine(a[6, 0]);

            a = a * a;
            Console.WriteLine(a[6, 0]);

            a = a * a;
            Console.WriteLine(a[6, 0]);

            a = a * a;
            Console.WriteLine(a[6, 0]);

            a = a * a;
            Console.WriteLine(a[6, 0]);
        }
    }
}