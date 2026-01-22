using System.Text;

namespace Lab3.Task1_3
{
    class Matrix
    {
        private double[,] data;

        public int Rows => data.GetLength(0);
        public int Cols => data.GetLength(1);

        public Matrix(int n, int m)
        {
            data = new double[n, m];
        }

        public Matrix(double[,] source)
        {
            data = source;
        }

        public double this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix r = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Cols; j++)
                    r[i, j] = a[i, j] + b[i, j];
            return r;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix r = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Cols; j++)
                    r[i, j] = a[i, j] - b[i, j];
            return r;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix r = new Matrix(a.Rows, b.Cols);
            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < b.Cols; j++)
                    for (int k = 0; k < a.Cols; k++)
                        r[i, j] += a[i, k] * b[k, j];
            return r;
        }

        public Matrix Transpose()
        {
            Matrix t = new Matrix(Cols, Rows);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    t[j, i] = data[i, j];
            return t;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    sb.Append($"{data[i, j],8:F2}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
