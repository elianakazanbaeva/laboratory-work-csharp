using System;

internal class People
{
    private string name;
    private int height;

    public People(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value == null || value.Length == 0)
            {
                Console.WriteLine("Ошибка, пустой ввод");
                this.name = "Иван";
                return;
            }

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
                Console.WriteLine("Ошибка, имя не может " +
                                  "содержать цифры, имя " +
                                  "изменено на имя по " +
                                  "умолчанию");
                this.name = "Иван";
            }
            else
            {
                this.name = value;
            }
        }
    }

    public int Height
    {
        get { return this.height; }
        private set
        {
            if (22 < value && value < 272)
            {
                this.height = value;
            }
            else
            {
                Console.WriteLine("Недопустимое значение роста");
                this.height = 150;
            }
        }
    }

    public override string ToString()
    {
        string s = "Человек с именем " + name + " и ростом " + 
                   height;
        return s;
    }
}