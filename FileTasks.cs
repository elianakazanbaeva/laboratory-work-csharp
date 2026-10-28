using System;
using System.IO;
using System.Xml.Serialization;

internal static class FileTasks
{
    //4
    public static void FillBinaryFile(string fileName, int count)
    {
        FileStream f = null;
        try
        {
            f = new FileStream(fileName, FileMode.Create);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        BinaryWriter writer = new BinaryWriter(f);
        Random rnd = new Random();

        for (int k = 0; k < count; k++)
        {
            writer.Write(rnd.Next(1, 15));
        }

        writer.Close();
        f.Close();
    }

    //4
    public static void RemoveDuplicates(
        string inputFile, 
        string outputFile)
    {
        FileStream fIn = null;
        try
        {
            fIn = new FileStream(inputFile, FileMode.Open);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        BinaryReader reader = new BinaryReader(fIn);
        int count = (int)(fIn.Length / 4);
        int[] numbers = new int[count];

        for (int k = 0; k < count; k++)
        {
            numbers[k] = reader.ReadInt32();
        }

        reader.Close();
        fIn.Close();

        FileStream fOut = null;
        try
        {
            fOut = new FileStream(
                outputFile, FileMode.Create);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        BinaryWriter writer = new BinaryWriter(fOut);

        for (int k = 0; k < count; k++)
        {
            bool isDuplicate = false;
            for (int l = 0; l < k; l++)
            {
                if (numbers[k] == numbers[l])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                writer.Write(numbers[k]);
            }
        }

        writer.Close();
        fOut.Close();
    }

    //4
    public static void PrintBinaryFile(string fileName)
    {
        FileStream f = null;
        try
        {
            f = new FileStream(fileName, FileMode.Open);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        BinaryReader reader = new BinaryReader(f);

        while (f.Position < f.Length)
        {
            int value = reader.ReadInt32();
            Console.Write(value + " ");
        }
        Console.WriteLine();

        reader.Close();
        f.Close();
    }

    //5
    public static void FillXmlFile(string fileName, int count)
    {
        Toy[] toys = new Toy[count];
        Random rnd = new Random();

        for (int k = 0; k < count; k++)
        {
            toys[k].Name = "Игрушка" + (k + 1);
            toys[k].Price = rnd.Next(100, 1000);
            toys[k].MinAge = rnd.Next(1, 4);
            toys[k].MaxAge = rnd.Next(5, 10);
        }

        XmlSerializer serializer = new XmlSerializer(
            typeof(Toy[]));
        FileStream f = null;
        try
        {
            f = new FileStream(fileName, FileMode.Create);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        serializer.Serialize(f, toys);
        f.Close();
    }

    //5
    public static void FindToys(string fileName, int maxPrice)
    {
        XmlSerializer serializer = new XmlSerializer(
            typeof(Toy[]));
        FileStream f = null;
        try
        {
            f = new FileStream(fileName, FileMode.Open);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Toy[] toys = (Toy[])serializer.Deserialize(f);
        f.Close();

        Console.WriteLine(
            "Подходящие игрушки (цена до " + maxPrice 
            + " руб., для 5 лет):");
        bool isFound = false;

        for (int k = 0; k < toys.Length; k++)
        {
            if (toys[k].Price <= maxPrice 
                && toys[k].MinAge <= 5 
                && toys[k].MaxAge >= 5)
            {
                Console.WriteLine(
                    toys[k].Name + " - " + toys[k].Price 
                    + " руб. (от " + toys[k].MinAge 
                    + " до " + toys[k].MaxAge + " лет)");
                isFound = true;
            }
        }

        if (!isFound)
        {
            Console.WriteLine(
                "Подходящих игрушек не найдено.");
        }
    }

    //6
    public static void FillTextFile(string fileName, int count)
    {
        StreamWriter f = null;
        try
        {
            f = new StreamWriter(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Random rnd = new Random();

        for (int k = 0; k < count; k++)
        {
            f.WriteLine(rnd.Next(1, 100));
        }

        f.Close();
    }

    //6
    public static void PrintTextFile(string fileName)
    {
        StreamReader f = null;
        try
        {
            f = new StreamReader(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        string s = string.Empty;

        while ((s = f.ReadLine()) != null)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();

        f.Close();
    }

    //6
    public static bool ContainsNumber(string fileName, int b)
    {
        StreamReader f = null;
        try
        {
            f = new StreamReader(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }

        string s = string.Empty;

        while ((s = f.ReadLine()) != null)
        {
            int value = 0;
            if (int.TryParse(s, out value))
            {
                if (value == b)
                {
                    f.Close();
                    return true;
                }
            }
        }

        f.Close();
        return false;
    }

    //7
    public static void FillTextFileMultiple(
        string fileName, 
        int linesCount)
    {
        StreamWriter f = null;
        try
        {
            f = new StreamWriter(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Random rnd = new Random();

        for (int i = 0; i < linesCount; i++)
        {
            int numbersInLine = rnd.Next(1, 6);
            for (int j = 0; j < numbersInLine; j++)
            {
                f.Write(rnd.Next(1, 100) + " ");
            }
            f.WriteLine();
        }

        f.Close();
    }

    //7
    public static void SumMultiplesOfK(string fileName, int k)
    {
        if (k == 0)
        {
            Console.WriteLine(
                "Число k не может быть равно нулю.");
            return;
        }

        StreamReader f = null;
        try
        {
            f = new StreamReader(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        string s = string.Empty;
        int sum = 0;

        while ((s = f.ReadLine()) != null)
        {
            string[] parts = s.Split(
                new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                int value = 0;
                if (int.TryParse(parts[i], out value))
                {
                    if (value % k == 0)
                    {
                        sum = sum + value;
                    }
                }
            }
        }

        f.Close();
        Console.WriteLine(
            "Сумма элементов, кратных " + k + ": " + sum);
    }

    //8
    public static void CreateTextFileFromUser(string fileName)
    {
        StreamWriter f = null;
        try
        {
            f = new StreamWriter(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine(
            "Введите строки текста.");
        Console.WriteLine(
            "Для завершения введите пустую строку:");

        string s = string.Empty;
        while (true)
        {
            s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                break;
            }
            f.WriteLine(s);
        }

        f.Close();
    }

    //8
    public static void PrintTextFileLines(string fileName)
    {
        StreamReader f = null;
        try
        {
            f = new StreamReader(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        string s = string.Empty;

        while ((s = f.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }

        f.Close();
    }

    //8
    public static void RewriteLinesWithoutDigits(
        string inputFile, 
        string outputFile)
    {
        StreamReader fIn = null;
        try
        {
            fIn = new StreamReader(inputFile);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        StreamWriter fOut = null;
        try
        {
            fOut = new StreamWriter(outputFile);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            fIn.Close();
            return;
        }

        string s = string.Empty;

        while ((s = fIn.ReadLine()) != null)
        {
            bool hasDigit = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    hasDigit = true;
                    break;
                }
            }

            if (!hasDigit)
            {
                fOut.WriteLine(s);
            }
        }

        fIn.Close();
        fOut.Close();
    }
}