namespace Hw_2
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            City city = new City();

            city.Input();
            city.Show();

            Console.WriteLine("\nНазвание города: " + city.GetCityName());
        }
    }

    class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private string phoneCode;
        private string districtName;

        public void Input()
        {
            Console.Write("Название города: ");
            cityName = Console.ReadLine();

            Console.Write("Название страны: ");
            countryName = Console.ReadLine();

            Console.Write("Количество жителей: ");
            population = int.Parse(Console.ReadLine());

            Console.Write("Телефонный код города: ");
            phoneCode = Console.ReadLine();

            Console.Write("Название района: ");
            districtName = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("\nИнформация о городе:");
            Console.WriteLine("Город: " + cityName);
            Console.WriteLine("Страна: " + countryName);
            Console.WriteLine("Население: " + population);
            Console.WriteLine("Телефонный код: " + phoneCode);
            Console.WriteLine("Район: " + districtName);
        }

        public string GetCityName()
        {
            return cityName;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public int GetPopulation()
        {
            return population;
        }

        public string GetPhoneCode()
        {
            return phoneCode;
        }

        public string GetDistrictName()
        {
            return districtName;
        }
    }
}