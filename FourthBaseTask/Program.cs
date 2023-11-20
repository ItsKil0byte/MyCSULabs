namespace FourthBaseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа через пробел: ");

            string[] userArray = Console.ReadLine().Split(' ');
            decimal[] resultArray = new decimal[userArray.Length];

            for (int i = 0; i < userArray.Length; i++)
            {
                if (int.TryParse(userArray[i], out int intNumber))
                {
                    if (intNumber > 0)
                    {
                        int factorialNumber = 1;

                        for (int j = 1; j <= intNumber; j++)
                        {
                            factorialNumber *= j;
                        }

                        resultArray[i] = factorialNumber;
                    }
                    else
                    {
                        resultArray[i] = intNumber;
                    }
                }
                else if (decimal.TryParse(userArray[i], out decimal doubleNumber))
                {
                    decimal roundedNumber = Math.Round(doubleNumber, 2);
                    decimal fractionPart = roundedNumber % 1;
                    resultArray[i] = Math.Abs(fractionPart / 0.01m);
                }
                else
                {
                    Console.WriteLine("Было введене некоректное значение. Завершение работы...");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine($"Первоначальный массив - {string.Join(" ", userArray)}");
            Console.WriteLine($"Обработанный массив - {string.Join(" ", resultArray)}");
            Console.ReadLine();
        }
    }
}