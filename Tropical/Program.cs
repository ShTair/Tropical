using System;

namespace Tropical
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Matrix<int>(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
            var b = new Matrix<int>(new int[,] { { 7, 8, 9 }, { 10, 11, 12 } });

            var c = a + b;

            var d = c[1, 2];
        }
    }
}
