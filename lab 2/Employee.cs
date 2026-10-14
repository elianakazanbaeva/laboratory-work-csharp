using System;

internal class Employee
{
    private string name;
    private string departmentName;
    private Employee head;

    public Employee(string name, string departmentName)
    {
        Name = name;
        DepartmentName = departmentName;
        this.head = null;
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
                Console.WriteLine("Ошибка, имя не может содержать цифры");
                this.name = "";
            }
            else
            {
                this.name = value;
            }
        }
    }

    public string DepartmentName
    {
        get { return this.departmentName; }
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
                Console.WriteLine("Ошибка, название отдела не может содержать цифры");
                this.departmentName = "";
            }
            else
            {
                this.departmentName = value;
            }
        }
    }

    public Employee Head
    {
        get { return this.head; }
        set { this.head = value; }
    }
    
    public static bool HasDigit(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= '0' && s[i] <= '9')
            {
                return true;
            }
        }
        return false;
    }

    public override string ToString()
    {
        if (this.head == this)
        {
            return name + " начальник отдела " + departmentName;
        }
        else
        {
            return name + " работает в отделе " + departmentName
                   + ", начальник которого " + head.Name;
        }
    }
}