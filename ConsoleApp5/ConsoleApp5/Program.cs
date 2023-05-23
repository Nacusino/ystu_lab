Console.WriteLine("Введите первое число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите операцию");
string op = Console.ReadLine();
if((op!="+") && (op != "-") && (op != "*") && (op != "/"))
{
    Console.WriteLine("Ошибка! Неверный знак операции");
    return;
}
Console.WriteLine("Введите второе число");
int second = int.Parse(Console.ReadLine());
int ans;
switch (op)
{
    case "+":
        Console.WriteLine("Ответ: " + (first + second));
        break;
    case "-":
        Console.WriteLine("Ответ: " + (first - second));
        break;
    case "*":
        Console.WriteLine("Ответ: " + (first * second));
        break;
    case "/":
<<<<<<< HEAD
            Console.WriteLine("Ответ: " + (first / second));
            break;
=======
        if (second == 0)
        {
            Console.WriteLine("Ошибка! Деление на ноль");
        }
        else 
        { 
            Console.WriteLine("Ответ: " + (first / second));
        }
        break;
>>>>>>> delnull
}

