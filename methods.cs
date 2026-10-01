using System;

public class Methods
{
    public double DoubleValidation(string question) //валидация нецелых чисел
    {
        double result;
        Console.Write(question);
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Ошибка! Введите корректное число: ");
        }

        return result;
    }

    public double Fraction(double x) //1_1
    {
        int y = Convert.ToInt32(x);
        return x - y;
    }

    public char InputValidation3() //1_3
    {
        while (true)
        {
            Console.Write("Введите одну цифру от 0 до 9: ");
            string input = Console.ReadLine();
            if (input.Length != 1)
            {
                Console.WriteLine("Ошибка: нужно ввести ровно один символ.");
                continue;
            }

            char ch = input[0];
            if (ch < '0' || ch > '9')
            {
                Console.WriteLine("Ошибка: символ должен быть цифрой от 0 до 9.");
                continue;
            }

            return ch;
        }
    }

    public int CharToNum(char x) //1_3
    {
        return x - '0';
    }

    public bool Is2Digits(int x) //1_5
    {
        return x > 9 && x < 100;
    }

    public bool IsInRange(int a, int b, int num) //1_7
    {
        int min;
        int max;
        if (a < b)
        {
            min = a;
            max = b;
        }
        else
        {
            min = b;
            max = a;
        }

        return num >= min && num <= max;
    }

    public bool IsEqual(int a, int b, int c) //1_9
    {
        return a == b && c == a;
    }

    public int Abs(int x) //2_1
    {
        if (x < 0)
        {
            return -x;
        }

        return x;
    }

    public bool Is35(int x) //2_3
    {
        if ((x % 3 == 0) && (x % 5 != 0))
        {
            return true;
        }

        if ((x % 3 != 0) && (x % 5 == 0))
        {
            return true;
        }

        return false;
    }

    public int Max3(int x, int y, int z) //2_5
    {
        if (y > x)
        {
            x = y;
        }

        if (z > x)
        {
            x = z;
        }

        return x;
    }

    public int Sum2(int x, int y) //2_7
    {
        int summa = x + y;
        if (summa > 9 && summa < 20)
        {
            return 20;
        }

        return summa;
    }

    public string Day(int x) //2_9
    {
        switch (x)
        {
            case 1:
                return "понедельник";
            case 2:
                return "вторник";
            case 3:
                return "среда";
            case 4:
                return "четверг";
            case 5:
                return "пятница";
            case 6:
                return "суббота";
            case 7:
                return "воскресенье";
            default:
                return "это не день недели";
        }
    }

    public string ReverseListNums(int x) //3_1
    {
        if (x <= 0)
        {
            return "неверный размер массива";
        }

        string[] nums = new string[x];
        int j = 0;
        for (int i = x; i > 0; i--)
        {
            nums[j] = i.ToString();
            j++;
        }

        return string.Join(" ", nums);
    }

    public string Chet(int x) //3_3
    {
        string result = "";

        if (x >= 0)
        {
            for (int i = 0; i <= x; i += 2)
            {
                result += i;

                if (i + 2 <= x)
                {
                    result += " ";
                }
            }
        }
        else
        {
            for (int i = 0; i >= x; i -= 2)
            {
                result += i;

                if (i - 2 >= x)
                {
                    result += " ";
                }
            }
        }

        return result;
    }

    public int NumLen(long x) //3_5
    {
        return x.ToString().Length;
    }

    public void Square(int x) //3_7
    {
        if (x > 0)
        {
            string line = "";
            for (int k = 0; k < x; k++)
            {
                line += "*";
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Сторона квадрата должна быть целым числом");
        }
    }

    public void RightTriangle(int x) //3_9
    {
        char c = '*';
        char pr = ' ';
        for (int i = 1; i < x + 1; i++)
        {
            Console.WriteLine(new string(pr, x - i) + new string(c, i));
        }
    }

    public int[] CreatArray(int size)
    {
        while (size < 0)
        {
            Console.WriteLine("Ошибка: размер массива не может быть отрицательным.");
            size = NumberValidation7("Введите размер массива заново: ");
        }

        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = NumberValidation7("Введите элемент arr[" + i + "]: ");
        }

        return arr;
    }

    public int FindFirst(int[] arr, int x) //4_1
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }

        return -1;
    }

    public int MaxAbs(int[] arr) //4_3
    {
        int maxNum = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            int max = Math.Abs(arr[i]);
            maxNum = Math.Max(max, maxNum);
        }

        return maxNum;
    }

    public int[] Add(int[] arr, int[] ins, int pos) //4_5
    {
        if (pos < 0)
        {
            pos = 0;
        }

        if (pos > arr.Length)
        {
            pos = arr.Length;
        }

        int[] result = new int[arr.Length + ins.Length];

        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }

        for (int i = 0; i < ins.Length; i++)
        {
            result[pos + i] = ins[i];
        }

        for (int i = pos; i < arr.Length; i++)
        {
            result[i + ins.Length] = arr[i];
        }

        return result;
    }

    public int[] ReverseBack(int[] arr) //4_7
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }

        return arr;
    }

    public int[] FindAll(int[] arr, int x) //4_9
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }

        int[] result = new int[count];
        count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[count] = i;
                count++;
            }
        }

        return result;
    }

    public int NumberValidation7(string question) //проверка на число
    {
        string input;
        int result = 0;
        bool valid = false;

        while (!valid)
        {
            Console.WriteLine(question);
            input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("Ошибка: пустой ввод.");
                continue;
            }

            bool negative = false;
            int start = 0;

            if (input[0] == '-')
            {
                negative = true;
                start = 1;
            }

            if (input.Length == start)
            {
                Console.WriteLine("Ошибка: нужно ввести целое число.");
                continue;
            }

            int value = 0;
            valid = true;

            for (int i = start; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0':
                        value = value * 10 + 0;
                        break;
                    case '1':
                        value = value * 10 + 1;
                        break;
                    case '2':
                        value = value * 10 + 2;
                        break;
                    case '3':
                        value = value * 10 + 3;
                        break;
                    case '4':
                        value = value * 10 + 4;
                        break;
                    case '5':
                        value = value * 10 + 5;
                        break;
                    case '6':
                        value = value * 10 + 6;
                        break;
                    case '7':
                        value = value * 10 + 7;
                        break;
                    case '8':
                        value = value * 10 + 8;
                        break;
                    case '9':
                        value = value * 10 + 9;
                        break;
                    default:
                        Console.WriteLine("Ошибка: нужно ввести целое число.");
                        valid = false;
                        break;
                }

                if (!valid)
                {
                    break;
                }
            }

            if (!valid)
            {
                continue;
            }

            result = negative ? -value : value;
        }

        return result;
    }
}
