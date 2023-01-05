// Ввести любой символ и определить его порядковый номер, а также указать предыдущий и последующий символы. //

class Program
{
    static void Main(string[] args)
    {
        char simbol = Console.ReadLine()[0];
        Console.WriteLine("Предыдущий символ: {0}", (char)(simbol - 1));
        Console.WriteLine("Следующий символ: {0}", (char)(simbol + 1));
        Console.ReadKey(false);
    }
}