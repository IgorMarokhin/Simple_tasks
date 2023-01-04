// Даны два действительных числа x и у. Вычислить их сумму, разность, произведение и частное. //

int X, Y;

try
{
    Console.Write("Введите целое число X: ");
    X = int.Parse(Console.ReadLine() ?? "");
    
    Console.Write("Введите целое число Y: ");
    Y = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

int Sum = X + Y;
int Div = X - Y;
int Prod = X * Y;
int Quot = X / Y;

Console.WriteLine($"Сумма чисел X и Y равна: {Sum}, ");
Console.WriteLine($"Разность чисел X и Y равна: {Div}, ");
Console.WriteLine($"Произведение чисел X и Y равно: {Prod}, ");
Console.WriteLine($"Частное чисел X и Y равно: {Quot}");