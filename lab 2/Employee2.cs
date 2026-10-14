using System;

internal class Employee2
{
    private static Employee2[] all = new Employee2[100];
    private static int count = 0;

    private string name;
    private string departmentName;
    private Employee2 head;

    public Employee2(string name, string departmentName)
    {
        Name = name;
        DepartmentName = departmentName;
        this.head = null;

        if (count < all.Length)
        {
            all[count] = this;
            count++;
        }
        else
        {
            Console.WriteLine("Ошибка: массив сотрудников" +
                              " переполнен");
        }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (HasDigit(value))
            {
                Console.WriteLine("Ошибка, имя не может" +
                                  " содержать цифры");
                name = "";
            }
            else
            {
                name = value;
            }
        }
    }

    public string DepartmentName
    {
        get { return departmentName; }
        private set
        {
            if (HasDigit(value))
            {
                Console.WriteLine("Ошибка, название отдела не" +
                                  " может содержать цифры");
                departmentName = "";
            }
            else
            {
                departmentName = value;
            }
        }
    }

    public Employee2 Head
    {
        get { return head; }
        set { head = value; }
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

    public Employee2[] GetDepartmentEmployees2()
    {
        int size = 0;
        for (int i = 0; i < count; i++)
        {
            if (all[i].departmentName == departmentName)
            {
                size++;
            }
        }

        Employee2[] result = new Employee2[size];
        int j = 0;
        for (int i = 0; i < count; i++)
        {
            if (all[i].departmentName == departmentName)
            {
                result[j] = all[i];
                j++;
            }
        }

        return result;
    }

    public override string ToString()
    {
        if (head == this)
        {
            return name + " начальник отдела " + departmentName;
        }
        return name + " работает в отделе " + departmentName +
               ", начальник которого " + head.Name;
    }
}