using System;
using System.IO;

internal static class InputHelper
{
    public static int ReadInt(string message)
    {
        int value = 0;
        string input = string.Empty;
        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();
            value = 0;
            if (int.TryParse(input, out value))
            {
                return value;
            }
            Console.WriteLine("Ошибка ввода.");
        }
    }

    public static int ReadPositiveInt(
        string message)
    {
        int value = 0;
        while (true)
        {
            value = ReadInt(message);
            if (value > 0)
            {
                return value;
            }
            Console.WriteLine(
                "Число должно быть "
                + "положительным.");
        }
    }

    public static int ReadOddPositiveInt(
        string message)
    {
        int value = 0;
        while (true)
        {
            value = ReadPositiveInt(message);
            if (value % 2 != 0)
            {
                return value;
            }
            Console.WriteLine(
                "Число должно быть нечетным.");
        }
    }

    public static int ReadNonNegativeInt(
        string message)
    {
        int value = 0;
        while (true)
        {
            value = ReadInt(message);
            if (value >= 0)
            {
                return value;
            }
            Console.WriteLine(
                "Число должно быть "
                + "неотрицательным.");
        }
    }

    public static int ReadIntInRange(
        string message, int min, int max)
    {
        int value = 0;
        while (true)
        {
            value = ReadInt(message);
            if (value >= min && value <= max)
            {
                return value;
            }
            Console.WriteLine(
                "Число должно быть в "
                + "диапазоне от " + min
                + " до " + max + ".");
        }
    }

    public static string ReadNonEmptyString(
        string message)
    {
        string input = string.Empty;
        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            Console.WriteLine(
                "Строка не должна быть пустой.");
        }
    }

    public static string ReadCommand(
        string message)
    {
        string input = string.Empty;
        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input.Trim()
                    .ToLowerInvariant();
            }
            Console.WriteLine(
                "Введите команду.");
        }
    }

    public static string ReadFileText(
        string message)
    {
        while (true)
        {
            string path =
                ReadNonEmptyString(message);
            string text =
                ReadFileTextByPath(path);
            if (text != null)
            {
                return text;
            }
        }
    }

    public static string ReadFileTextByPath(
        string path)
    {
        try
        {
            return File.ReadAllText(path);
        }
        catch (IOException)
        {
            Console.WriteLine(
                "Не удалось прочитать файл.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(
                "Нет доступа к файлу.");
        }
        return null;
    }

    public static bool WriteFileText(
        string path, string text)
    {
        try
        {
            File.WriteAllText(path, text);
            return true;
        }
        catch (IOException)
        {
            Console.WriteLine(
                "Не удалось записать файл.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(
                "Нет доступа к файлу.");
        }
        return false;
    }
}