using System;

namespace Tropical
{
    class Matrix
    {
        private double[] _data;

        public int Width { get; private set; }

        public int Height { get; private set; }

        public double this[int x, int y]
        {
            get { return _data[y * Width + x]; }
            set { _data[y * Width + x] = value; }
        }

        public Matrix(int w, int h)
        {
            Width = w;
            Height = h;

            _data = new double[w * h];
        }

        public static Matrix StandardAddition(Matrix a, Matrix b)
        {
            if (a.Width != b.Width || a.Height != b.Height) throw new Exception();

            var result = new Matrix(a.Width, a.Height);
            for (int i = 0; i < result._data.Length; i++)
            {
                result._data[i] = a._data[i] + b._data[i];
            }

            return result;
        }

        public static Matrix StandardMultiplication(Matrix a, Matrix b)
        {

        }
    }
}
