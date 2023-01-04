// Составить программу вывода на экран «столбиком» пяти любых чисел, введенных пользователем с клавиатуры. //
Console.Clear();
int userInput1, userInput2, userInput3, userInput4, userInput5;

try
{
    Console.Write("Введите первое целое число: ");
    userInput1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите второе целое число: ");
    userInput2 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите третье целое число: ");
    userInput3 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите четвертое целое число: ");
    userInput4 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите пятое целое число: ");
    userInput5 = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

Console.WriteLine($"{userInput1}");
Console.WriteLine($"{userInput2}");
Console.WriteLine($"{userInput3}");
Console.WriteLine($"{userInput4}");
Console.WriteLine($"{userInput5}");