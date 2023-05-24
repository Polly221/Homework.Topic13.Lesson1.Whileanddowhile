int number = new Random().Next(5) + 1;
int attempts = 0;

Console.WriteLine("Компьютер задумал число от 1 до 5");
Console.WriteLine("Угадайте его за 3 попытки.");
Console.WriteLine();

do
{
    int input = int.Parse(Console.ReadLine());
    //Условие, когда число угадано
    if (input == number)
    {
        Console.WriteLine();
        Console.WriteLine("Вы угадали число!");
        Console.WriteLine();
        Console.WriteLine("Спасибо за игру!");
    }

    // Условие, когда число больше нужного
    if (input > number)
    {
        Console.WriteLine("Вы ввели число больше нужного! Введите число от 1 до 5");
    }
    // Когда меньше нужного
    if (input != number && input < number)
    {
        Console.WriteLine("Вы ввели число ниже нужного! Введите число от 1 до 5");
    }
    attempts++;
}

while (attempts != 3);

Console.WriteLine();
Console.WriteLine("Вы не справились! Попробуйте еще раз!");
Console.WriteLine();
