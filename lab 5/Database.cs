using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

public class Database
{
    private List<Country> _countries;
    private List<Club> _clubs;
    private List<Achievement> _achievements;

    public Database()
    {
        _countries = new List<Country>();
        _clubs = new List<Club>();
        _achievements = new List<Achievement>();
    }

    // ===== ЧТЕНИЕ EXCEL =====

    public void Load(string path)
    {
        try
        {
            IWorkbook book =
                OpenWorkbook(path);
            _countries = ReadCountries(book);
            _clubs = ReadClubs(book);
            _achievements =
                ReadAchievements(book);
            Console.WriteLine(
                "Загружено: "
                + _countries.Count + " стран, "
                + _clubs.Count + " клубов, "
                + _achievements.Count
                + " достижений.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "Ошибка загрузки: "
                + ex.Message);
        }
    }

    private static IWorkbook OpenWorkbook(
        string path)
    {
        using var stream = new FileStream(
            path, FileMode.Open,
            FileAccess.Read);
        if (IsXls(path))
        {
            return new HSSFWorkbook(stream);
        }
        return new XSSFWorkbook(stream);
    }

    private static bool IsXls(string path)
    {
        return path.EndsWith(".xls",
            StringComparison
                .OrdinalIgnoreCase);
    }

    private static List<Country> ReadCountries(
        IWorkbook book)
    {
        var result = new List<Country>();
        var sheet = book.GetSheetAt(0);
        for (int i = 0;
            i <= sheet.LastRowNum; i++)
        {
            var row = sheet.GetRow(i);
            if (row == null)
            {
                continue;
            }
            int id = GetInt(row.GetCell(0));
            if (id <= 0)
            {
                continue;
            }
            string name =
                GetString(row.GetCell(1));
            result.Add(new Country(id, name));
        }
        return result;
    }

    private static List<Club> ReadClubs(
        IWorkbook book)
    {
        var result = new List<Club>();
        var sheet = book.GetSheetAt(1);
        for (int i = 0;
            i <= sheet.LastRowNum; i++)
        {
            var row = sheet.GetRow(i);
            if (row == null)
            {
                continue;
            }
            int id = GetInt(row.GetCell(0));
            if (id <= 0)
            {
                continue;
            }
            string name =
                GetString(row.GetCell(1));
            int countryId =
                GetInt(row.GetCell(2));
            result.Add(new Club(
                id, name, countryId));
        }
        return result;
    }

    private static List<Achievement>
        ReadAchievements(IWorkbook book)
    {
        var result = new List<Achievement>();
        var sheet = book.GetSheetAt(2);
        for (int i = 0;
            i <= sheet.LastRowNum; i++)
        {
            var row = sheet.GetRow(i);
            if (row == null)
            {
                continue;
            }
            int id = GetInt(row.GetCell(0));
            if (id <= 0)
            {
                continue;
            }
            var a = new Achievement();
            a.ClubId = id;
            a.Gold = GetInt(row.GetCell(1));
            a.Silver = GetInt(row.GetCell(2));
            a.Bronze = GetInt(row.GetCell(3));
            a.Cup = GetInt(row.GetCell(4));
            a.CupFinal = GetInt(row.GetCell(5));
            a.ChampionsLeague =
                GetInt(row.GetCell(6));
            a.CLFinal = GetInt(row.GetCell(7));
            a.EuropaLeague =
                GetInt(row.GetCell(8));
            a.ELFinal = GetInt(row.GetCell(9));
            a.CupWinners =
                GetInt(row.GetCell(10));
            a.CWFinal = GetInt(row.GetCell(11));
            a.ConferenceLeague =
                GetInt(row.GetCell(12));
            a.ConfFinal =
                GetInt(row.GetCell(13));
            result.Add(a);
        }
        return result;
    }

    private static int GetInt(ICell cell)
    {
        if (cell == null)
        {
            return 0;
        }
        if (cell.CellType == CellType.Numeric
            || cell.CellType == CellType.Formula)
        {
            return (int)cell.NumericCellValue;
        }
        if (int.TryParse(cell.StringCellValue,
            out int value))
        {
            return value;
        }
        return 0;
    }

    private static string GetString(ICell cell)
    {
        if (cell == null)
        {
            return string.Empty;
        }
        if (cell.CellType == CellType.String)
        {
            return cell.StringCellValue;
        }
        if (cell.CellType == CellType.Numeric)
        {
            return cell.NumericCellValue
                .ToString();
        }
        return cell.ToString();
    }

    // ===== СОХРАНЕНИЕ EXCEL =====

    public void Save(string path)
    {
        try
        {
            IWorkbook book =
                CreateWorkbook(path);
            WriteCountries(book);
            WriteClubs(book);
            WriteAchievements(book);
            using var stream = new FileStream(
                path, FileMode.Create,
                FileAccess.Write);
            book.Write(stream);
            Console.WriteLine(
                "Данные сохранены в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "Ошибка сохранения: "
                + ex.Message);
        }
    }

    private static IWorkbook CreateWorkbook(
        string path)
    {
        if (IsXls(path))
        {
            return new HSSFWorkbook();
        }
        return new XSSFWorkbook();
    }

    private void WriteCountries(IWorkbook book)
    {
        var sheet = book.CreateSheet("Страны");
        var header = sheet.CreateRow(0);
        header.CreateCell(0).SetCellValue(
            "ID страны");
        header.CreateCell(1).SetCellValue(
            "Название");
        int index = 1;
        foreach (var item in _countries)
        {
            var row = sheet.CreateRow(index++);
            row.CreateCell(0).SetCellValue(
                item.Id);
            row.CreateCell(1).SetCellValue(
                item.Name);
        }
    }

    private void WriteClubs(IWorkbook book)
    {
        var sheet = book.CreateSheet("Клубы");
        var header = sheet.CreateRow(0);
        header.CreateCell(0).SetCellValue(
            "ID клуба");
        header.CreateCell(1).SetCellValue(
            "Название");
        header.CreateCell(2).SetCellValue(
            "ID страны");
        int index = 1;
        foreach (var item in _clubs)
        {
            var row = sheet.CreateRow(index++);
            row.CreateCell(0).SetCellValue(
                item.Id);
            row.CreateCell(1).SetCellValue(
                item.Name);
            row.CreateCell(2).SetCellValue(
                item.CountryId);
        }
    }

    private void WriteAchievements(
        IWorkbook book)
    {
        var sheet = book.CreateSheet(
            "Достижения");
        var header = sheet.CreateRow(0);
        string[] titles =
        {
            "ID клуба", "З", "С", "Б", "К",
            "ФК", "ЛЧ", "ФЛЧ", "ЛЕ", "ФЛЕ",
            "КОК", "ФКОК", "ЛК", "ФЛК"
        };
        for (int i = 0;
            i < titles.Length; i++)
        {
            header.CreateCell(i).SetCellValue(
                titles[i]);
        }
        int index = 1;
        foreach (var item in _achievements)
        {
            var row = sheet.CreateRow(index++);
            row.CreateCell(0).SetCellValue(
                item.ClubId);
            int[] values =
            {
                item.Gold, item.Silver,
                item.Bronze, item.Cup,
                item.CupFinal,
                item.ChampionsLeague,
                item.CLFinal,
                item.EuropaLeague,
                item.ELFinal,
                item.CupWinners,
                item.CWFinal,
                item.ConferenceLeague,
                item.ConfFinal
            };
            for (int i = 0;
                i < values.Length; i++)
            {
                row.CreateCell(i + 1)
                    .SetCellValue(values[i]);
            }
        }
    }

    // ===== ПРОСМОТР =====

    public void Show()
    {
        Console.WriteLine("\n=== СТРАНЫ ===");
        foreach (var item in _countries)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n=== КЛУБЫ ===");
        foreach (var item in _clubs)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(
            "\n=== ДОСТИЖЕНИЯ ===");
        foreach (var item in _achievements)
        {
            Console.WriteLine(item);
        }
    }

    // ===== УДАЛЕНИЕ =====

    public void Delete(int table, int id)
    {
        switch (table)
        {
            case 1:
                DeleteCountry(id);
                break;
            case 2:
                DeleteClub(id);
                break;
            case 3:
                DeleteAchievement(id);
                break;
            default:
                Console.WriteLine(
                    "Неверная таблица.");
                break;
        }
    }

    private void DeleteCountry(int id)
    {
        var item = _countries
            .FirstOrDefault(c => c.Id == id);
        if (item != null)
        {
            _countries.Remove(item);
            Console.WriteLine(
                "Страна удалена.");
        }
        else
        {
            Console.WriteLine(
                "Страна не найдена.");
        }
    }

    private void DeleteClub(int id)
    {
        var item = _clubs
            .FirstOrDefault(c => c.Id == id);
        if (item != null)
        {
            _clubs.Remove(item);
            Console.WriteLine("Клуб удалён.");
        }
        else
        {
            Console.WriteLine(
                "Клуб не найден.");
        }
    }

    private void DeleteAchievement(int id)
    {
        var item = _achievements
            .FirstOrDefault(a =>
                a.ClubId == id);
        if (item != null)
        {
            _achievements.Remove(item);
            Console.WriteLine(
                "Достижения удалены.");
        }
        else
        {
            Console.WriteLine(
                "Достижения не найдены.");
        }
    }

    // ===== ДОБАВЛЕНИЕ =====

    public void Add(int table)
    {
        switch (table)
        {
            case 1:
                AddCountry();
                break;
            case 2:
                AddClub();
                break;
            case 3:
                AddAchievement();
                break;
            default:
                Console.WriteLine(
                    "Неверная таблица.");
                break;
        }
    }

    private void AddCountry()
    {
        int id = InputHelper.ReadPositiveInt(
            "ID страны: ");
        string name = InputHelper
            .ReadNonEmptyString("Название: ");
        _countries.Add(new Country(id, name));
        Console.WriteLine("Страна добавлена.");
    }

    private void AddClub()
    {
        int id = InputHelper.ReadPositiveInt(
            "ID клуба: ");
        string name = InputHelper
            .ReadNonEmptyString("Название: ");
        int countryId = InputHelper
            .ReadPositiveInt("ID страны: ");
        _clubs.Add(new Club(
            id, name, countryId));
        Console.WriteLine("Клуб добавлен.");
    }

    private void AddAchievement()
    {
        int clubId =
            InputHelper.ReadPositiveInt(
                "ID клуба: ");
        Console.WriteLine(
            "Введите значения столбцов:");
        var a = new Achievement();
        a.ClubId = clubId;
        a.Gold = InputHelper
            .ReadNonNegativeInt("З: ");
        a.Silver = InputHelper
            .ReadNonNegativeInt("С: ");
        a.Bronze = InputHelper
            .ReadNonNegativeInt("Б: ");
        a.Cup = InputHelper
            .ReadNonNegativeInt("К: ");
        a.CupFinal = InputHelper
            .ReadNonNegativeInt("ФК: ");
        a.ChampionsLeague = InputHelper
            .ReadNonNegativeInt("ЛЧ: ");
        a.CLFinal = InputHelper
            .ReadNonNegativeInt("ФЛЧ: ");
        a.EuropaLeague = InputHelper
            .ReadNonNegativeInt("ЛЕ: ");
        a.ELFinal = InputHelper
            .ReadNonNegativeInt("ФЛЕ: ");
        a.CupWinners = InputHelper
            .ReadNonNegativeInt("КОК: ");
        a.CWFinal = InputHelper
            .ReadNonNegativeInt("ФКОК: ");
        a.ConferenceLeague = InputHelper
            .ReadNonNegativeInt("ЛК: ");
        a.ConfFinal = InputHelper
            .ReadNonNegativeInt("ФЛК: ");
        _achievements.Add(a);
        Console.WriteLine(
            "Достижения добавлены.");
    }

    // ===== LINQ-ЗАПРОСЫ =====

    public void RunQueries()
    {
        Console.WriteLine(
            "\n=== LINQ-ЗАПРОСЫ ===");
        QueryOneTableOneValue();
        QueryTwoTablesOneValue();
        QueryThreeTablesList();
        QueryThreeTablesList2();
    }

    // 1 таблица, одно значение
    private void QueryOneTableOneValue()
    {
        Console.WriteLine(
            "\n--- Запрос 1 ---");
        Console.WriteLine(
            "Клубов, выигрывавших ЛЧ:");
        int count =
            _achievements.Count(a =>
                a.ChampionsLeague > 0);
        Console.WriteLine(
            "Результат: " + count);
    }

    // 2 таблицы, одно значение
    // (запрос из примера к заданию)
    private void QueryTwoTablesOneValue()
    {
        Console.WriteLine(
            "\n--- Запрос 2 ---");
        Console.WriteLine(
            "ID страны клуба с макс. З при К=0:");
        var query = from club in _clubs
                    join ach in _achievements
                    on club.Id equals ach.ClubId
                    where ach.Gold > 0
                    where ach.Cup == 0
                    orderby ach.Gold descending,
                        club.CountryId descending
                    select club.CountryId;
        int result = query.FirstOrDefault();
        if (result > 0)
        {
            Console.WriteLine(
                "Результат: ID страны = "
                + result);
        }
        else
        {
            Console.WriteLine(
                "Ничего не найдено.");
        }
    }

    // 3 таблицы, перечень
    private void QueryThreeTablesList()
    {
        Console.WriteLine(
            "\n--- Запрос 3 ---");
        Console.WriteLine(
            "Клубы-победители ЛЧ и страны:");
        var query = from club in _clubs
                    join country in _countries
                    on club.CountryId equals
                        country.Id
                    join ach in _achievements
                    on club.Id equals ach.ClubId
                    where ach.ChampionsLeague > 0
                    orderby ach.ChampionsLeague
                        descending
                    select new
                    {
                        Club = club.Name,
                        Country = country.Name,
                        Wins = ach
                            .ChampionsLeague
                    };
        foreach (var item in query)
        {
            Console.WriteLine("  " + item.Club
                + " (" + item.Country + ") - "
                + item.Wins + " побед");
        }
    }

    // 3 таблицы, перечень
    private void QueryThreeTablesList2()
    {
        Console.WriteLine(
            "\n--- Запрос 4 ---");
        Console.WriteLine(
            "Страны с победителями ЛЕ:");
        var query = from country in _countries
                    join club in _clubs
                    on country.Id equals
                        club.CountryId
                    join ach in _achievements
                    on club.Id equals ach.ClubId
                    where ach.EuropaLeague > 0
                    select country.Name;
        var names = query.Distinct()
            .OrderBy(n => n).ToList();
        foreach (var name in names)
        {
            Console.WriteLine("  " + name);
        }
    }
}