using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        //1
        Console.WriteLine("Задача 1");
        int n = InputHelper.ReadOddPositiveInt(
            "Введите n (нечетное): ");
        int m = InputHelper.ReadPositiveInt(
            "Введите m: ");
        Matrix firstMatrix = new Matrix(n, m);
        Matrix secondMatrix = new Matrix(n, true);
        Matrix thirdMatrix = new Matrix(n, "diamond");

        Console.WriteLine("Первая матрица:");
        Console.WriteLine(firstMatrix);
        Console.WriteLine("Вторая матрица:");
        Console.WriteLine(secondMatrix);
        Console.WriteLine("Третья матрица:");
        Console.WriteLine(thirdMatrix);

        //2
        Console.WriteLine();
        Console.WriteLine("Задача 2");
        int n2 = InputHelper.ReadPositiveInt(
            "Введите размер матрицы n: ");
        Matrix matrixForTask2 = new Matrix(n2, n2);
        
        Console.WriteLine("Ваша матрица:");
        Console.WriteLine(matrixForTask2);

        int maxOffset = 0;
        int maxSum = matrixForTask2
            .FindMaxDiagonalSum(out maxOffset);

        Console.WriteLine(
            "Максимальная сумма диагонали: " 
            + maxSum);

        if (maxOffset > 0)
        {
            Console.WriteLine(
                "Это диагональ ниже главной на "
                + maxOffset + " позиций.");
        }
        else if (maxOffset < 0)
        {
            Console.WriteLine(
                "Это диагональ выше главной на "
                + (-maxOffset) + " позиций.");
        }
        else
        {
            Console.WriteLine("Это главная диагональ.");
        }

        //3
        Console.WriteLine();
        Console.WriteLine("Задача 3");
        Console.WriteLine("Ввод матрицы A (n x m):");
        int aRows = InputHelper.ReadPositiveInt(
            "Строки A (n): ");
        int aCols = InputHelper.ReadPositiveInt(
            "Столбцы A (m): ");
        Matrix matA = new Matrix(aRows, aCols);

        Console.WriteLine("Ввод матрицы B (n x k):");
        int bRows = aRows; 
        int bCols = InputHelper.ReadPositiveInt(
            "Столбцы B (k): ");
        Matrix matB = new Matrix(bRows, bCols);

        Console.WriteLine("Ввод матрицы C (k x m):");
        int cRows = bCols;
        int cCols = aCols;
        Matrix matC = new Matrix(cRows, cCols);

        Console.WriteLine("Матрица A:");
        Console.WriteLine(matA);
        Console.WriteLine("Матрица B:");
        Console.WriteLine(matB);
        Console.WriteLine("Матрица C:");
        Console.WriteLine(matC);

        Matrix transposedA = matA.Transpose();
        Matrix transposedC = matC.Transpose();
        
        Matrix product = transposedA.Multiply(matB);
        Matrix result = product.Subtract(transposedC);

        Console.WriteLine(
            "Результат выражения A^T * B - C^T:");
        Console.WriteLine(result);
        

        //4
        Console.WriteLine();
        Console.WriteLine("Задача 4");
        string file4Input = "task4_input.bin";
        string file4Output = "task4_output.bin";
        
        FileTasks.FillBinaryFile(file4Input, 20);
        Console.WriteLine("Исходный файл:");
        FileTasks.PrintBinaryFile(file4Input);
        
        FileTasks.RemoveDuplicates(
            file4Input, file4Output);
        Console.WriteLine("Новый файл без повторений:");
        FileTasks.PrintBinaryFile(file4Output);

        //5
        Console.WriteLine();
        Console.WriteLine("Задача 5");
        string file5 = "task5.xml";
        FileTasks.FillXmlFile(file5, 10);
        int k = InputHelper.ReadPositiveInt(
            "Введите максимальную цену k: ");
        FileTasks.FindToys(file5, k);
*/
        //6
        Console.WriteLine();
        Console.WriteLine("Задача 6");
        string file6 = "task6.txt";
        FileTasks.FillTextFile(file6, 20);
        Console.WriteLine("Исходный файл:");
        FileTasks.PrintTextFile(file6);
        
        int b = InputHelper.ReadInt(
            "Введите число b для поиска: ");
        bool contains = FileTasks
            .ContainsNumber(file6, b);
        
        Console.WriteLine(
            "Результат: " + contains.ToString().ToLower());

        //7
        Console.WriteLine();
        Console.WriteLine("Задача 7");
        string file7 = "task7.txt";
        FileTasks.FillTextFileMultiple(file7, 10);
        Console.WriteLine(
            "Исходный файл (числа в строке):");
        FileTasks.PrintTextFile(file7);

        int k7 = InputHelper.ReadPositiveInt(
            "Введите число k: ");
        FileTasks.SumMultiplesOfK(file7, k7);

        //8
        Console.WriteLine();
        Console.WriteLine("Задача 8");
        string file8Input = "task8_input.txt";
        string file8Output = "task8_output.txt";
        
        FileTasks.CreateTextFileFromUser(file8Input);
        Console.WriteLine("Исходный файл:");
        FileTasks.PrintTextFileLines(file8Input);
        
        FileTasks.RewriteLinesWithoutDigits(
            file8Input, file8Output);
        Console.WriteLine(
            "Новый файл (только строки без цифр):");
        FileTasks.PrintTextFileLines(file8Output);
    }
}