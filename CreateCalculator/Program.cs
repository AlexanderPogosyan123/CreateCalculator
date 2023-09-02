namespace CreateCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите операцию: ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int res;
            switch (ch)
            {
                case '+':
                    res = number1+number2;
                    break;
                case '-':
                    res = number1-number2;
                    break;
                case '*':
                    res = number1*number2;
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("нельзя делить на ноль!");
                        break;
                    }
                    res = number1/number2;
                    break;
                default:
                    break;
            }
        }
    }
}