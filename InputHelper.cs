using System;

internal static class InputHelper
{
    public static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            int value = 0;
            if (int.TryParse(input, out value))
            {
                return value;
            }
            Console.WriteLine("Ошибка ввода.");
        }
    }

    public static int ReadPositiveInt(string message)
    {
        while (true)
        {
            int value = ReadInt(message);
            if (value > 0)
            {
                return value;
            }
            Console.WriteLine("Число должно быть" +
                              " положительным.");
        }
    }

    public static int ReadOddPositiveInt(string message)
    {
        while (true)
        {
            int value = ReadPositiveInt(message);
            if (value % 2 != 0)
            {
                return value;
            }
            Console.WriteLine("Число должно быть нечетным.");
        }
    }
}