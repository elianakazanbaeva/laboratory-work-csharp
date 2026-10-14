using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Validating v = new Validating();

        Console.WriteLine("Задание 1.2");
        int nPeople = v.ReadInt("Сколько людей создать? " +
                                "(от 0 до 100)", 0, 100);
        People[] people = new People[nPeople];

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine("Человек №" + (i + 1));
            string name = v.ReadString("Введите имя " +
                                       "человека");
            int height = v.ReadInt("Введите рост", 22, 271);
            people[i] = new People(name, height);
        }

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine(people[i]);
        }

        Console.WriteLine("Задание 1.3");

        int nNames1 = v.ReadInt("Сколько имён создать? " +
                                "(от 0 до 100)", 0, 100);
        FullName[] names1 = new FullName[nNames1];

        for (int i = 0; i < names1.Length; i++)
        {
            Console.WriteLine("Имя №" + (i + 1));

            string s = v.ReadStringOptional("Введите " +
                "фамилию (Enter - пропустить)");
            string n = v.ReadStringOptional("Введите " +
                "личное имя (Enter - пропустить)");
            string p = v.ReadStringOptional("Введите " +
                "отчество (Enter - пропустить)");

            while (s == "" && n == "" && p == "")
            {
                Console.WriteLine("Ошибка: хотя бы одно поле " +
                                  "должно быть заполнено");
                s = v.ReadStringOptional("Введите " +
                                         "фамилию (Enter - " +
                                         "пропустить)");
                n = v.ReadStringOptional("Введите " +
                                         "личное имя (Enter - " +
                                         "пропустить)");
                p = v.ReadStringOptional("Введите " +
                                         "отчество (Enter - " +
                                         "пропустить)");
            }

            names1[i] = new FullName(s, n, p);
        }

        for (int i = 0; i < names1.Length; i++)
        {
            Console.WriteLine(names1[i]);
        }

        Console.WriteLine("Задание 2.4");

        int nEmployees = v.ReadInt("Сколько сотрудников? " +
                                   "(от 0 до 100)", 0, 100);
        Employee[] all = new Employee[nEmployees];
        string[] deps = new string[nEmployees];
        Employee[] heads = new Employee[nEmployees];
        int depCount = 0;

        for (int i = 0; i < nEmployees; i++)
        {
            string name = v.ReadString("Введите имя " +
                                       "сотрудника №" + (i + 1));
            string dep = v.ReadString("Введите название" +
                                      " отдела");

            all[i] = new Employee(name, dep);

            bool found = false;
            for (int j = 0; j < depCount; j++)
            {
                if (deps[j] == dep)
                {
                    found = true;
                }
            }

            if (!found)
            {
                deps[depCount] = dep;
                depCount++;
            }
        }

        for (int j = 0; j < depCount; j++)
        {
            Console.WriteLine("Отдел " + deps[j] + " — кто " +
                              "начальник?");
            for (int i = 0; i < nEmployees; i++)
            {
                if (all[i].DepartmentName == deps[j])
                {
                    Console.WriteLine((i + 1) + " - " + all[i].Name);
                }
            }

            int headNum = v.ReadInt
                ("Введите номер начальника (от 1 до "
                 + nEmployees + ")", 1, nEmployees);
            heads[j] = all[headNum - 1];
        }

        for (int i = 0; i < nEmployees; i++)
        {
            for (int j = 0; j < depCount; j++)
            {
                if (all[i].DepartmentName == deps[j])
                {
                    all[i].Head = heads[j];
                }
            }
        }

        for (int i = 0; i < nEmployees; i++)
        {
            Console.WriteLine(all[i]);
        }

        Console.WriteLine("Задание 3.4");

        int n2 = v.ReadInt("Сколько сотрудников? " +
                           "(от 0 до 99)", 0, 99);
        Employee2[] all2 = new Employee2[n2];
        string[] deps2 = new string[n2];
        Employee2[] heads2 = new Employee2[n2];
        int depCount2 = 0;

        for (int i = 0; i < n2; i++)
        {
            string name = v.ReadString("Введите имя " +
                                       "сотрудника №" + (i + 1));
            string dep = v.ReadString("Введите название" +
                                      " отдела");

            all2[i] = new Employee2(name, dep);

            bool found = false;
            for (int j = 0; j < depCount2; j++)
            {
                if (deps2[j] == dep)
                {
                    found = true;
                }
            }

            if (!found)
            {
                deps2[depCount2] = dep;
                depCount2++;
            }
        }

        for (int j = 0; j < depCount2; j++)
        {
            Console.WriteLine("Отдел " + deps2[j] + " — кто" +
                              " начальник?");
            for (int i = 0; i < n2; i++)
            {
                if (all2[i].DepartmentName == deps2[j])
                {
                    Console.WriteLine((i + 1) + " - " + all2[i].Name);
                }
            }

            int headNum = v.ReadInt
                ("Введите номер начальника (от 1 до " 
                 + n2 + ")", 1, n2);
            heads2[j] = all2[headNum - 1];
        }

        for (int i = 0; i < n2; i++)
        {
            for (int j = 0; j < depCount2; j++)
            {
                if (all2[i].DepartmentName == deps2[j])
                {
                    all2[i].Head = heads2[j];
                }
            }
        }

        if (n2 > 0)
        {
            int who = v.ReadInt("У какого сотрудника" +
                                " показать коллег? (от 1 до " +
                                n2 + ")", 1, n2);
            Employee2[] colleagues = 
                all2[who - 1].GetDepartmentEmployees2();
            for (int i = 0; i < colleagues.Length; i++)
            {
                Console.WriteLine(colleagues[i].Name);
            }
        }
    
        Console.WriteLine("Задание 4.5");

        int nNames2 = v.ReadInt("Сколько имён создать?" +
                                " (от 0 до 100)", 0, 100);
        FullName2[] names2 = new FullName2[nNames2];

        for (int i = 0; i < names2.Length; i++)
        {
            Console.WriteLine("Имя №" + (i + 1));

            string n = v.ReadString("Введите личное имя");
            string s = v.ReadStringOptional("Введите " +
                "фамилию (Enter - пропустить)");

            if (s == "")
            {
                names2[i] = new FullName2(n);
            }
            else
            {
                string p = v.ReadStringOptional
                    ("Введите отчество (Enter - пропустить)");

                if (p == "")
                {
                    names2[i] = new FullName2(n, s);
                }
                else
                {
                    names2[i] = new FullName2(n, s, p);
                }
            }
        }

        for (int i = 0; i < names2.Length; i++)
        {
            Console.WriteLine(names2[i]);
        }

        
        Console.WriteLine("Задание 5.1");

        int bullets = v.ReadNonNegativeInt
            ("Введите начальное количество патронов");
        int shots = v.ReadNonNegativeInt
            ("Введите количество выстрелов");

        Gun gun = new Gun(bullets);
        for (int i = 0; i < shots; i++)
        {
            gun.Shoot();
        }
    }
}