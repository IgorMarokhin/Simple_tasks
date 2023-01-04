// Составить программу вывода на экран числа, вводимого с клавиатуры. //
// Выводимому числу должно предшествовать сообщение «Вы ввели число». //

int userInput;

try
{
    Console.Write("Введите целое число: ");
    userInput = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

Console.WriteLine($"Вы ввели число {userInput}");