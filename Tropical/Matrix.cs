using System;
using System.Linq;

namespace Tropical
{
    class Matrix<T>
    {
        public static Func<T, T, T> Add { get; set; }

        public static Func<T, T, T> Multiply { get; set; }

        private T[] _data;

        public int Width { get; private set; }

        public int Height { get; private set; }

        public T this[int y, int x]
        {
            get { return _data[y * Width + x]; }
            set { _data[y * Width + x] = value; }
        }

        public Matrix(int w, int h)
        {
            Width = w;
            Height = h;

            _data = new T[w * h];
        }

        public Matrix(T[,] raw)
        {
            Width = raw.GetLength(1);
            Height = raw.GetLength(0);

            _data = raw.Cast<T>().ToArray();
        }

        static Matrix()
        {
            var go = new GenericOperation<T>();
            Add = go.Add;
            Multiply = go.Multiply;
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Width != b.Width || a.Height != b.Height) throw new Exception();

            var result = new Matrix<T>(a.Width, a.Height);

            for (int i = 0; i < result._data.Length; i++)
            {
                result._data[i] = Add(a._data[i], b._data[i]);
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Width != b.Height) throw new Exception();

            var result = new Matrix<T>(b.Width, a.Height);

            for (int y = 0; y < a.Height; y++)
            {
                for (int x = 0; x < b.Width; x++)
                {
                    for (int i = 0; i < a.Width; i++)
                    {
                        result[y, x] = Add(result[y, x], Multiply(a[y, i], b[i, x]));
                    }
                }
            }

            return result;
        }
    }
}
