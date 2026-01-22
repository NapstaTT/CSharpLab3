using System.Xml.Serialization;

namespace Lab3.Task4_8
{
    public static class FileOperations
    {
        private static string fileName;

        public static void Run()
        {
            fileName = "toys.xml";

            CreateFile();

            Console.Write("Введите k: ");
            int k = int.Parse(Console.ReadLine());

            XmlSerializer xs = new XmlSerializer(typeof(List<Toy>));

            using FileStream fs = new FileStream(fileName, FileMode.Open);
            List<Toy> toys = (List<Toy>)xs.Deserialize(fs);

            Console.WriteLine("\nПодходящие игрушки:");
            foreach (Toy t in toys)
            {
                if (t.Price <= k && t.AgeFrom <= 5 && t.AgeTo >= 5)
                    Console.WriteLine(t.Name);
            }
        }

        private static void CreateFile()
        {
            List<Toy> toys = new List<Toy>
            {
                new Toy { Name = "Мяч", Price = 300, AgeFrom = 3, AgeTo = 7 },
                new Toy { Name = "Конструктор", Price = 800, AgeFrom = 5, AgeTo = 12 },
                new Toy { Name = "Кукла", Price = 600, AgeFrom = 4, AgeTo = 8 }
            };

            XmlSerializer xs = new XmlSerializer(typeof(List<Toy>));
            using FileStream fs = new FileStream(fileName, FileMode.Create);
            xs.Serialize(fs, toys);
        }
    }
}
