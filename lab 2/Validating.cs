using System;

public class Validating
{
    public int ReadInt(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        int x = 0;
        while (true)
        {
            if (int.TryParse(input, out x))
            {
                return x;
            }
            else
            {
                Console.WriteLine("Ошибка ввода, введите" +
                                  " еще раз");
                input = Console.ReadLine();
            }
        }
    }

    public int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            int x = ReadInt(prompt);
            if (x >= min && x <= max)
            {
                return x;
            }
            else
            {
                Console.WriteLine("Ошибка: число должно быть " +
                                  "от " + min + " до " + max);
            }
        }
    }

    public int ReadNonNegativeInt(string prompt)
    {
        while (true)
        {
            int x = ReadInt(prompt);
            if (x >= 0)
            {
                return x;
            }
            else
            {
                Console.WriteLine("Ошибка: число не может" +
                                  " быть отрицательным");
            }
        }
    }

    public string ReadString(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        while (input == null || input.Length == 0)
        {
            Console.WriteLine("Ошибка, пустой ввод." +
                              " Введите еще раз");
            input = Console.ReadLine();
        }
        return input;
    }

    public string ReadStringOptional(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        if (input == null)
        {
            return "";
        }
        return input;
    }
}