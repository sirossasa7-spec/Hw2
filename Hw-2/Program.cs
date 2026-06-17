namespace Hw_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 4 };

            Console.Write("1 - по возрастанию, 2 - по убыванию: ");
            int choice = int.Parse(Console.ReadLine());

            bool ascending = (choice == 1);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if ((ascending && numbers[i] > numbers[j]) ||
                        (!ascending && numbers[i] < numbers[j]))
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine("Отсортированный массив:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}