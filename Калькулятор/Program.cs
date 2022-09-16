// Пользователь вводит первое число, знак вычисления, второе число, и получает результат. При вводе точки - выход.

string end = ".";
string? end1 = String.Empty;

while (end != end1)
{

    Console.Write("Введите первое число: ");
    double number1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите знак вычисления: ");
    string? sign = Console.ReadLine();

    Console.Write("Введите второе число: ");
    double number2 = Convert.ToDouble(Console.ReadLine());

    double result = 0;

    if (sign == "+") 
    {
        result = number1 + number2;
        Console.WriteLine($"Ответ: {number1} {sign} {number2} = {result}");
    }
    else if (sign == "-") 
    {
        result = number1 - number2;
        Console.WriteLine($"Ответ: {number1} {sign} {number2} = {result}");
    }
    else if (sign == "*") 
    {
        result = number1 * number2;
        Console.WriteLine($"Ответ: {number1} {sign} {number2} = {result}");
    }
    else if (sign == "/") 
    {
        result = number1 / number2;
        Console.WriteLine($"Ответ: {number1} {sign} {number2} = {result}");
    }
    else
    {
        Console.WriteLine("Ошибка! Введён некорректный оператор вычисления.");
    }

    Console.WriteLine("Для продолжения нажмите 'Enter', для выхода поставьте точку '.'");
    end1 = Console.ReadLine();
}
