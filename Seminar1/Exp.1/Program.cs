// типы данных
// int, string, bool, float, double 
// int a = 20; // целочисленные значения
// string b = "hello, world"; // буквенный тип. Словосочетания, текст, буквы
// bool c = true or false // значения истина или ложь
// float d = 5.21; // дроби, например. Не целочисленные значения
// double e = 5.21; // также не целочисленные значения, но выше объём информации

while (true)
{
    Console.WriteLine("Введите оператор +. -. *. / или end для выхода");
    string Operator = Console.ReadLine();

    if (Operator == "end")
    {
        break;
    }

    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (Operator == "+")
    {
        Console.WriteLine(number1 + number2);
    }
    else if (Operator == "-")
    {
        Console.WriteLine(number1 - number2);
    }
    else if (Operator == "/")
    {
        Console.WriteLine(number1 / number2);
    }
    else if (Operator == "*")
    {
        Console.WriteLine(number1 * number2);
    }
}



