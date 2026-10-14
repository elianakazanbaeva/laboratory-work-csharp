using System;

internal class FullName2
{
    private string name;
    private string surname;
    private string patronymic;

    public FullName2(string name)
    {
        Name = name;
        Surname = "";
        Patronymic = "";
    }

    public FullName2(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Patronymic = "";
    }

    public FullName2(string name, string surname,
        string patronymic)
    {
        Name = name;
        Surname = surname;
        Patronymic = patronymic;
    }

    public string Name
    {
        get { return name; }
        private set
        {
            bool hasDigit = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= '0' && value[i] <= '9')
                {
                    hasDigit = true;
                }
            }

            if (hasDigit)
            {
                Console.WriteLine("Ошибка, имя не может содержать цифры");
                name = "";
            }
            else
            {
                name = value;
            }
        }
    }

    public string Surname
    {
        get { return surname; }
        private set
        {
            bool hasDigit = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= '0' && value[i] <= '9')
                {
                    hasDigit = true;
                }
            }

            if (hasDigit)
            {
                Console.WriteLine("Ошибка, фамилия не может" +
                                  " содержать цифры");
                surname = "";
            }
            else
            {
                surname = value;
            }
        }
    }

    public string Patronymic
    {
        get { return patronymic; }
        private set
        {
            bool hasDigit = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= '0' && value[i] <= '9')
                {
                    hasDigit = true;
                }
            }

            if (hasDigit)
            {
                Console.WriteLine("Ошибка, отчество не может" +
                                  " содержать цифры");
                patronymic = "";
            }
            else
            {
                patronymic = value;
            }
        }
    }

    public override string ToString()
    {
        string result = "";

        if (name != "")
        {
            result += name;
        }

        if (patronymic != "")
        {
            if (result != "")
            {
                result += " ";
            }
            result += patronymic;
        }

        if (surname != "")
        {
            if (result != "")
            {
                result += " ";
            }
            result += surname;
        }

        return result;
    }
}