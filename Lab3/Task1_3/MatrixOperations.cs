namespace Lab3.Task1_3
{
    static class MatrixOperations
    {
        public static void Run()
        {
            Console.WriteLine("\nЗадания 1–3 (вариант 5)");

            int n = 3;
            Random rnd = new Random();

            Matrix A = new Matrix(n, n);
            Matrix B = new Matrix(n, n);
            Matrix C = new Matrix(n, n);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.Next(1, 5);
                    B[i, j] = rnd.Next(1, 5);
                    C[i, j] = rnd.Next(1, 5);
                }

            Console.WriteLine("A:\n" + A);
            Console.WriteLine("B:\n" + B);
            Console.WriteLine("C:\n" + C);

            Matrix result = A.Transpose() * B - C.Transpose();
            Console.WriteLine("Aᵗ * B − Cᵗ:\n" + result);
        }
    }
}
