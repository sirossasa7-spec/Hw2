namespace Hw_2
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Input();
            employee.Show();

            Console.WriteLine("\nДоступ через методы:");
            Console.WriteLine("ФИО: " + employee.GetFullName());
            Console.WriteLine("Телефон: " + employee.GetPhone());
            Console.WriteLine("Email: " + employee.GetEmail());
        }
    }

    class Employee
    {
        private string fullName;
        private string birthDate;
        private string phone;
        private string email;
        private string position;
        private string duties;

        public void Input()
        {
            Console.Write("ФИО: ");
            fullName = Console.ReadLine();

            Console.Write("Дата рождения: ");
            birthDate = Console.ReadLine();

            Console.Write("Контактный телефон: ");
            phone = Console.ReadLine();

            Console.Write("Рабочий email: ");
            email = Console.ReadLine();

            Console.Write("Должность: ");
            position = Console.ReadLine();

            Console.Write("Описание обязанностей: ");
            duties = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine("ФИО: " + fullName);
            Console.WriteLine("Дата рождения: " + birthDate);
            Console.WriteLine("Телефон: " + phone);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Обязанности: " + duties);
        }

        public string GetFullName()
        {
            return fullName;
        }

        public string GetPhone()
        {
            return phone;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPosition()
        {
            return position;
        }

        public string GetDuties()
        {
            return duties;
        }
    }
}