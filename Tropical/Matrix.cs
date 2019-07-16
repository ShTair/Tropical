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
    }
}
