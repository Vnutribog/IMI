namespace Algo;

class Program
{
    static void Main(string[] args)
    {
        List<string> history = new List<string>();

        Console.WriteLine("Простой калькулятор\n");
        
        bool continueCalculations = true;
        while (continueCalculations)
        {
            Console.WriteLine("Введите первое число:");
            int first = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите второе число:");
            int second = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            Console.WriteLine("5 - Выход");
                
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш выбор: {userChoice}");
            switch (userChoice)
            {
                case 1:
                    history.Add($"{first} + {second} = {first + second}");
                    break;
                case 2:
                    history.Add($"{first} - {second} = {first - second}");
                    break;
                case 3:
                    history.Add($"{first} * {second} = {first * second}");
                    break;
                case 4:
                    if (second == 0)
                    {
                        Console.WriteLine("Ошибка! На ноль делить нельзя.\n");
                        continue;
                    } 
                    else
                    {
                        history.Add($"{first} / {second} = {(double)first / second}");
                    }
                    break;
                case 5:
                    continueCalculations = false;
                    continue;
                default:
                    Console.WriteLine("Ошибка! Некорректный номер операции.\n");
                    continue;

            }
            Console.WriteLine($"Результат: {history.Last()}\n");
        }
        
        Console.WriteLine();
        Console.WriteLine("История вычислений: ");
        foreach (var result in history.TakeLast(5))
        {
            Console.WriteLine(result);
        }
        
        Console.ReadLine();
    }
}