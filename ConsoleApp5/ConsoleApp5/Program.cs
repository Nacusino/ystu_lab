Console.WriteLine("Введите первое число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите операцию");
string op = Console.ReadLine();
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
        Console.WriteLine("Ответ: " + (first / second));
        break;
}

