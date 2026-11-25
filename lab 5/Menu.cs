using System;

public class Menu
{
    private readonly Database _database;

    public Menu()
    {
        _database = new Database();
    }

    public void Run()
    {
        Console.WriteLine(
            "=== ЛАБОРАТОРНАЯ №5 ===");
        Console.WriteLine(
            "LINQ-запросы. Выход: exit");
        while (true)
        {
            ShowMenu();
            string choice =
                InputHelper.ReadCommand(
                    "Выбор: ");
            if (choice == "exit"
                || choice == "0")
            {
                Console.WriteLine("Выход.");
                return;
            }
            if (!int.TryParse(choice,
                out int number))
            {
                Console.WriteLine(
                    "Неверный ввод.");
                continue;
            }
            Process(number);
        }
    }

    private void Process(int number)
    {
        switch (number)
        {
            case 1:
                LoadDatabase();
                break;
            case 2:
                _database.Show();
                break;
            case 3:
                DeleteElement();
                break;
            case 4:
                AddElement();
                break;
            case 5:
                _database.RunQueries();
                break;
            case 6:
                SaveDatabase();
                break;
            default:
                Console.WriteLine(
                    "Нет такого пункта.");
                break;
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("\n--- МЕНЮ ---");
        Console.WriteLine(
            "1. Чтение БД из Excel-файла");
        Console.WriteLine("2. Просмотр БД");
        Console.WriteLine(
            "3. Удаление элемента (по ключу)");
        Console.WriteLine(
            "4. Добавление элемента");
        Console.WriteLine("5. LINQ-запросы");
        Console.WriteLine(
            "6. Сохранение БД в Excel-файл");
        Console.WriteLine(
            "exit. Выход из программы");
    }

    private void LoadDatabase()
    {
        string path = InputHelper
            .ReadNonEmptyString(
                "Путь к .xls/.xlsx: ");
        _database.Load(path);
    }

    private void SaveDatabase()
    {
        string path = InputHelper
            .ReadNonEmptyString(
                "Путь для сохранения: ");
        _database.Save(path);
    }

    private void DeleteElement()
    {
        Console.WriteLine(
            "1-Страны, 2-Клубы, 3-Достижения");
        int table =
            InputHelper.ReadIntInRange(
                "Таблица (1-3): ", 1, 3);
        int id = InputHelper.ReadPositiveInt(
            "ID: ");
        _database.Delete(table, id);
    }

    private void AddElement()
    {
        Console.WriteLine(
            "1-Страны, 2-Клубы, 3-Достижения");
        int table =
            InputHelper.ReadIntInRange(
                "Таблица (1-3): ", 1, 3);
        _database.Add(table);
    }
}