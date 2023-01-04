// Составить программу вывода на экран в одну строку четырех любых чисел с тремя пробелами между ними. //
Random rnd = new Random();

int number = rnd.Next(1,10);
int number1 = rnd.Next(1,10);
int number2 = rnd.Next(1,10);
int number3 = rnd.Next(1,10);

Console.WriteLine($"{number} {number1} {number2} {number3}");