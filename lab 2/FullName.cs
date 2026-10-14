using System;

internal class FullName
{
    private string surname;
    private string name;
    private string patronymic;

    public FullName(string name)
    {
        Surname = "";
        Name = name;
        Patronymic = "";
    }

    public FullName(string surname, string name)
    {
        Surname = surname;
        Name = name;
        Patronymic = "";
    }

    public FullName(string surname, string name,
        string patronymic)
    {
        Surname = surname;
        Name = name;
        Patronymic = patronymic;
    }

    public string Surname
    {
        get { return this.surname; }
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
                Console.WriteLine("Ошибка, фамилия не" +
                                  " может содержать цифры");
                this.surname = "";
            }
            else
            {
                this.surname = value;
            }
        }
    }

    public string Name
    {
        get { return this.name; }
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
                Console.WriteLine("Ошибка, имя не может" +
                                  " содержать цифры");
                this.name = "";
            }
            else
            {
                this.name = value;
            }
        }
    }

    public string Patronymic
    {
        get { return this.patronymic; }
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
                this.patronymic = "";
            }
            else
            {
                this.patronymic = value;
            }
        }
    }

    public override string ToString()
    {
        string result = "";

        if (surname != "")
        {
            result += surname;
        }

        if (name != "")
        {
            if (result != "")
            {
                result += " ";
            }

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

        return result;
    }
}