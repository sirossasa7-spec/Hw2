namespace Hw_2
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            Airplane plane1 = new Airplane();
            plane1.Input();
            plane1.Show();

            Console.WriteLine();

            Airplane plane2 = new Airplane(
                "Boeing 737",
                "Boeing",
                2018,
                "Пассажирский"
            );

            plane2.Show();

            Console.WriteLine("\nДоступ через методы:");
            Console.WriteLine("Название: " + plane2.GetName());
            Console.WriteLine("Производитель: " + plane2.GetManufacturer());
        }
    }

    class Airplane
    {
        private string name;
        private string manufacturer;
        private int year;
        private string type;

        public Airplane()
        {
            name = "Неизвестно";
            manufacturer = "Неизвестно";
            year = 0;
            type = "Неизвестно";
        }

        public Airplane(string name, string manufacturer, int year, string type)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.year = year;
            this.type = type;
        }

        public void Input()
        {
            Console.Write("Название самолета: ");
            name = Console.ReadLine();

            Console.Write("Производитель: ");
            manufacturer = Console.ReadLine();

            Console.Write("Год выпуска: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Тип самолета: ");
            type = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("Информация о самолете:");
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Год выпуска: " + year);
            Console.WriteLine("Тип: " + type);
        }

        public string GetName()
        {
            return name;
        }

        public string GetManufacturer()
        {
            return manufacturer;
        }

        public int GetYear()
        {
            return year;
        }

        public string GetType()
        {
            return type;
        }
    }
}