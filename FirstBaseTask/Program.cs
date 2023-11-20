namespace FirstBaseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float previousNumber = float.NaN;
            while (true)
            {
                Console.Write("Введите число (для выхода введите 'q'): ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("Завершение работы...");
                    Console.ReadLine();
                    break;
                }
                else if (int.TryParse(input, out int intNumber))
                {
                    char symbol = (char)intNumber;
                    Console.WriteLine($"Символ для введенного числа {intNumber} - {symbol}");
                }
                else if (float.TryParse(input, out float floatNumber))
                {
                    if (previousNumber == floatNumber)
                    {
                        Console.WriteLine("Введенное дробное число равно предыдущему. Завершение работы...");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        previousNumber = floatNumber;
                    }
                }
                else
                {
                    Console.WriteLine("Введенное значение не является числом.");
                }
            }
        }
    }
}