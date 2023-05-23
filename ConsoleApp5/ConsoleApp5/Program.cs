Console.WriteLine("Это приложение - простой калькулятор для математических выражений!");
bool go = true;
while (go)
{
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
    Console.WriteLine("Завершить работу программы?(Y/N)");
    string letter = Console.ReadLine();
    if(letter == "Y")
    {
        go = false;
    }
}

