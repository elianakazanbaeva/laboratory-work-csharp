using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Methods lab = new Methods();
        int x, y, z, result, start, end, num, a, b, c, size, size1, size2, number, pos, size3;
        /*
        Console.WriteLine("  1 Задание");



        Console.WriteLine("1 задача: дробная часть числа");
        double xFrac = lab.DoubleValidation("Введите дробное число X: ");
        Console.WriteLine("Результат: " + lab.Fraction(xFrac));
            
        Console.WriteLine(" 3 Задача: символ-цифра в число");
        char digit = lab.InputValidation3();
        result = lab.charToNum(digit);
        Console.WriteLine("Результат: " + result);
        
        Console.WriteLine("5 задача: двузначное ли число");
        x = lab.NumberValidation7("Введите целое число: ");
        Console.WriteLine("Результат: " + lab.is2Digits(x));
        
        Console.WriteLine(" 7 Задача: число в диапазоне");
        start = lab.NumberValidation7("Введите границу a: ");
        end   = lab.NumberValidation7("Введите границу b: ");
        num   = lab.NumberValidation7("Введите число num: ");
        bool inRange = lab.isInRange(start, end, num);
        Console.WriteLine("Результат: " + (inRange ? "true" : "false"));
        
        Console.WriteLine("9 задача: равны ли три числа");
        a = lab.NumberValidation7("Введите первое число: ");
        b = lab.NumberValidation7("Введите второе число: ");
        c = lab.NumberValidation7("Введите третье число: ");
        Console.WriteLine("Результат: " + lab.isEqual(a, b, c));
        
        Console.WriteLine("  2 Задание");
        Console.WriteLine("1 задача: модуль числа");
        x = lab.NumberValidation7("Введите число");
        Console.WriteLine("Результат: " + lab.abs(x));
        
        Console.WriteLine("3 задача: is35");
        x = lab.NumberValidation7("Введите целое число: ");
        Console.WriteLine("Результат: " + lab.is35(x));
        
        Console.WriteLine("5 задача: максимум из трех чисел");
        x = lab.NumberValidation7("Введите первое число ");
        y = lab.NumberValidation7("Введите второе число");
        z = lab.NumberValidation7("Введите третье число");
        Console.WriteLine("Результат: " + lab.max3(x, y, z));
        
        Console.WriteLine("7 задача: сумма двух чисел");
        x = lab.NumberValidation7("Введите первое число: ");
        y = lab.NumberValidation7("Введите второе число: ");
        Console.WriteLine("Результат: " + lab.sum2(x, y));
        
        Console.WriteLine("Задача 9: Дни недели");
        x = lab.NumberValidation7("Введите номер дня недели ");
        Console.WriteLine("Результат: " + lab.day(x));
        
        Console.WriteLine("  3 Задание");
        Console.WriteLine("1 задача: массив от X до 0");
        x = lab.NumberValidation7("Введите число X: ");
        Console.WriteLine("Результат: " + lab.reverseListNums(x) + " 0");
        
        Console.WriteLine("3 задача: только четные числа");
        x = lab.NumberValidation7("До какого числа будем искать четные? ");
        Console.WriteLine("Результат: " + lab.chet(x));
        
        Console.WriteLine("5 задача: количество знаков в числе");
        x = lab.NumberValidation7("Введите число: ");
        Console.WriteLine("Результат: " + lab.numLen(x));
    
        Console.WriteLine("7 задача: квадрат из *");
        x = lab.NumberValidation7("Введите сторону квадрата");
        lab.square(x);
        
        Console.WriteLine("9 задача: правый треугольник из *");
        x = lab.NumberValidation7("Введите высоту треугольника: ");
        lab.rightTriangle(x);
        
        Console.WriteLine("  4 Задание");
        Console.WriteLine("1 задача: поиск первого значения");
        size = lab.NumberValidation7("Введите размерность одномерного массива: ");
        int[] arr = lab.creat_array(size);
        Console.Write("массив: ");
        for (int k = 0; k < arr.Length; k++)
        {
            Console.Write(arr[k] + "  ");
        }
        Console.WriteLine();
        number = lab.NumberValidation7("индекс первого вхождения какого числа будем искать? ");
        Console.WriteLine("Результат: " + lab.findFirst(arr, number));
                */

        Console.WriteLine("3 задача: максимальный по модулю");
        int size_abs = lab.NumberValidation7("Введите размерность одномерного массива: ");
        int[] arr_abs = lab.creat_array(size_abs);
        for (int k = 0; k < arr_abs.Length; k++)
        {
            Console.Write(arr_abs[k] + "  ");
        }
        Console.WriteLine();
        Console.WriteLine("Результат: " + lab.maxAbs(arr_abs));

        Console.WriteLine("Задача 5: Добавление массива в массив.");
        size1 = lab.NumberValidation7(question: "Введите размерность первого одномерного массива: ");
        size2 = lab.NumberValidation7(question: "Введите размерность второго одномерного массива: ");
        pos = lab.NumberValidation7(question: "Введите позицию pos ");
        int[] arr1 = lab.creat_array(size1);
        Console.Write("Первый массив (arr): ");
        for (int k = 0; k < arr1.Length; k++)
        {
            Console.Write(arr1[k] + "  ");
        }
        Console.WriteLine();
        int[] ins = lab.creat_array(size2);
        Console.Write("Второй массив (ins): ");
        for (int k = 0; k < ins.Length; k++)
        {
            Console.Write(ins[k] + "  ");
        }
        Console.WriteLine();
        int[] mas = lab.add(arr1, ins, pos);
        Console.WriteLine();
        Console.WriteLine("Результат:");
        for (int k = 0; k < mas.Length; k++)
        {
            Console.Write(mas[k] + "  ");
        }
        Console.WriteLine();
        
        Console.WriteLine("7 задача: возвратный реверс");
        int size_rev = lab.NumberValidation7("Введите размерность одномерного массива: ");
        int[] arr_rev = lab.creat_array(size_rev);
        Console.Write("Исходный массив: ");
        for (int k = 0; k < arr_rev.Length; k++)
        {
            Console.Write(arr_rev[k] + "  ");
        }
        Console.WriteLine();
        int[] rev = lab.reverseBack(arr_rev);
        Console.Write("Результат: ");
        for (int k = 0; k < rev.Length; k++)
        {
            Console.Write(rev[k] + "  ");
        }
        Console.WriteLine();

        Console.WriteLine("Задача 9: все вхождения");
        size3 = lab.NumberValidation7("введите размерность одномерного массива");
        int[] arr3 = lab.creat_array(size3);
        Console.Write("массив: ");
        for (int k = 0; k < arr3.Length; k++)
        {
            Console.Write(arr3[k] + "  ");
        }
        Console.WriteLine();
        int number9 = lab.NumberValidation7("Введи число");

        int[] result9 = lab.findAll(arr3, number9);
        Console.WriteLine();
        Console.WriteLine("Результат:");
        for (int k = 0; k < result9.Length; k++)
        {
            Console.Write(result9[k] + "  ");
        }
        Console.ReadLine();
    
    }
}