namespace SecondBaseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целочисленное число: ");

            string userInput = Console.ReadLine();
            int sum = 0;
            bool negative = false;

            if (userInput[0] == '-')
            {
                negative = true;
                userInput = userInput.Replace("-", "");
            }

            foreach (char symbol in userInput)
            {
                if (symbol < '0' || symbol > '9')
                {
                    Console.WriteLine("Введенное значение не является целочисленным числом.");
                    Console.ReadLine();
                    return;
                }

                sum += symbol - '0';
            }

            if (negative) sum = -sum;

            Console.WriteLine($"Сумма цифр введенного числа: {sum}");
            Console.ReadLine();
        }
    }
}