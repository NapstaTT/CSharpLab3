using Lab3.Task1_3;
using Lab3.Task4_8;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nЛабораторная №3 (вариант 5)");
                Console.WriteLine("1 — Задания 1–3 (матрицы)");
                Console.WriteLine("2 — Задания 4–8 (файлы)");
                Console.WriteLine("0 — Выход");

                switch (Console.ReadLine())
                {
                    case "1":
                        MatrixOperations.Run();
                        break;
                    case "2":
                        FileOperations.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}
