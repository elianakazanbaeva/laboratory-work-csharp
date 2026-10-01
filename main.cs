using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var lab = new Methods();
        Console.WriteLine("  1 Задание");

        Console.WriteLine("1 задача: дробная часть числа");
        double xFrac = lab.DoubleValidation("Введите дробное число X: ");
        Console.WriteLine("Результат: " + lab.Fraction(xFrac));

        Console.WriteLine(" 3 Задача: символ-цифра в число");
        char digit = lab.InputValidation3();
        int result = lab.CharToNum(digit);
        Console.WriteLine("Результат: " + result);

        Console.WriteLine("5 задача: двузначное ли число");
        int x = lab.NumberValidation7("Введите целое число: ");
        Console.WriteLine("Результат: " + lab.Is2Digits(x));

        Console.WriteLine(" 7 Задача: число в диапазоне");
        int start = lab.NumberValidation7("Введите границу a: ");
        int end = lab.NumberValidation7("Введите границу b: ");
        int num = lab.NumberValidation7("Введите число num: ");
        bool inRange = lab.IsInRange(start, end, num);
        Console.WriteLine("Результат: " + (inRange ? "true" : "false"));

        Console.WriteLine("9 задача: равны ли три числа");
        int a = lab.NumberValidation7("Введите первое число: ");
        int b = lab.NumberValidation7("Введите второе число: ");
        int c = lab.NumberValidation7("Введите третье число: ");
        Console.WriteLine("Результат: " + lab.IsEqual(a, b, c));

        Console.WriteLine("  2 Задание");
        Console.WriteLine("1 задача: модуль числа");
        x = lab.NumberValidation7("Введите число");
        Console.WriteLine("Результат: " + lab.Abs(x));

        Console.WriteLine("3 задача: is35");
        x = lab.NumberValidation7("Введите целое число: ");
        Console.WriteLine("Результат: " + lab.Is35(x));

        Console.WriteLine("5 задача: максимум из трех чисел");
        x = lab.NumberValidation7("Введите первое число ");
        int y = lab.NumberValidation7("Введите второе число");
        int z = lab.NumberValidation7("Введите третье число");
        Console.WriteLine("Результат: " + lab.Max3(x, y, z));

        Console.WriteLine("7 задача: сумма двух чисел");
        x = lab.NumberValidation7("Введите первое число: ");
        y = lab.NumberValidation7("Введите второе число: ");
        Console.WriteLine("Результат: " + lab.Sum2(x, y));

        Console.WriteLine("Задача 9: Дни недели");
        x = lab.NumberValidation7("Введите номер дня недели ");
        Console.WriteLine("Результат: " + lab.Day(x));

        Console.WriteLine("  3 Задание");
        Console.WriteLine("1 задача: массив от X до 0");
        x = lab.NumberValidation7("Введите число X: ");
        Console.WriteLine("Результат: " + lab.ReverseListNums(x) + " 0");

        Console.WriteLine("3 задача: только четные числа");
        x = lab.NumberValidation7("До какого числа будем искать четные? ");
        Console.WriteLine("Результат: " + lab.Chet(x));

        Console.WriteLine("5 задача: количество знаков в числе");
        x = lab.NumberValidation7("Введите число: ");
        Console.WriteLine("Результат: " + lab.NumLen(x));

        Console.WriteLine("7 задача: квадрат из *");
        x = lab.NumberValidation7("Введите сторону квадрата");
        lab.Square(x);

        Console.WriteLine("9 задача: правый треугольник из *");
        x = lab.NumberValidation7("Введите высоту треугольника: ");
        lab.RightTriangle(x);

        Console.WriteLine("  4 Задание");
        Console.WriteLine("1 задача: поиск первого значения");
        int size = lab.NumberValidation7("Введите размерность одномерного массива: ");
        int[] arr = lab.CreatArray(size);
        Console.Write("массив: ");
        for (int k = 0; k < arr.Length; k++)
        {
            Console.Write(arr[k] + "  ");
        }
        Console.WriteLine();
        int number = lab.NumberValidation7("индекс первого вхождения какого числа будем искать? ");
        Console.WriteLine("Результат: " + lab.FindFirst(arr, number));

        Console.WriteLine("3 задача: максимальный по модулю");
        int sizeAbs = lab.NumberValidation7("Введите размерность одномерного массива: ");
        int[] arrAbs = lab.CreatArray(sizeAbs);
        for (int k = 0; k < arrAbs.Length; k++)
        {
            Console.Write(arrAbs[k] + "  ");
        }
        Console.WriteLine();
        Console.WriteLine("Результат: " + lab.MaxAbs(arrAbs));

        Console.WriteLine("Задача 5: Добавление массива в массив.");
        int size1 = lab.NumberValidation7(question: "Введите размерность первого одномерного массива: ");
        int size2 = lab.NumberValidation7(question: "Введите размерность второго одномерного массива: ");
        int pos = lab.NumberValidation7(question: "Введите позицию pos ");
        int[] arr1 = lab.CreatArray(size1);
        Console.Write("Первый массив (arr): ");
        for (int k = 0; k < arr1.Length; k++)
        {
            Console.Write(arr1[k] + "  ");
        }
        Console.WriteLine();
        int[] ins = lab.CreatArray(size2);
        Console.Write("Второй массив (ins): ");
        for (int k = 0; k < ins.Length; k++)
        {
            Console.Write(ins[k] + "  ");
        }
        Console.WriteLine();
        int[] mas = lab.Add(arr1, ins, pos);
        Console.WriteLine();
        Console.WriteLine("Результат:");
        for (int k = 0; k < mas.Length; k++)
        {
            Console.Write(mas[k] + "  ");
        }
        Console.WriteLine();

        Console.WriteLine("7 задача: возвратный реверс");
        int sizeRev = lab.NumberValidation7("Введите размерность одномерного массива: ");
        int[] arrRev = lab.CreatArray(sizeRev);
        Console.Write("Исходный массив: ");
        for (int k = 0; k < arrRev.Length; k++)
        {
            Console.Write(arrRev[k] + "  ");
        }
        Console.WriteLine();
        int[] rev = lab.ReverseBack(arrRev);
        Console.Write("Результат: ");
        for (int k = 0; k < rev.Length; k++)
        {
            Console.Write(rev[k] + "  ");
        }
        Console.WriteLine();

        Console.WriteLine("Задача 9: все вхождения");
        int size3 = lab.NumberValidation7("введите размерность одномерного массива");
        int[] arr3 = lab.CreatArray(size3);
        Console.Write("массив: ");
        for (int k = 0; k < arr3.Length; k++)
        {
            Console.Write(arr3[k] + "  ");
        }
        Console.WriteLine();
        int number9 = lab.NumberValidation7("Введи число");

        int[] result9 = lab.FindAll(arr3, number9);
        Console.WriteLine();
        Console.WriteLine("Результат:");
        for (int k = 0; k < result9.Length; k++)
        {
            Console.Write(result9[k] + "  ");
        }
        Console.ReadLine();
    }
}
