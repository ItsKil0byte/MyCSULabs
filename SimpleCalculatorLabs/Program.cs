namespace SimpleCalculatorLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите математическое выражение: ");
            string input = Console.ReadLine().Replace(" ", "");
            List<string> numbers = new List<string>();
            List<char> operations = new List<char>();

            string number = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    numbers.Add(number);
                    operations.Add(input[i]);
                    number = "";
                }
                else
                {
                    number += input[i];
                }
            }

            numbers.Add(number);

            Console.WriteLine($"Числа: {string.Join(" ", numbers)}");
            Console.WriteLine($"Операторы: {string.Join(" ", operations)}");
            Console.ReadLine();
        }
    }
}