using System;

internal class Matrix
{
    private int[,] _data = new int[0, 0];

    //1
    public Matrix(int n, int m)
    {
        _data = new int[n, m];
        for (int k = 0; k < _data.GetLength(0); k++)
        {
            for (int l = 0; l < _data.GetLength(1); l++)
            {
                string msg = string.Format(
                    "Введите элемент [{0},{1}]: ", k, l);
                _data[k, l] = InputHelper.ReadInt(msg);
            }
        }
    }

    //1
    public Matrix(int n, bool isRandom)
    {
        _data = new int[n, n];
        Random rnd = new Random();
        for (int k = 0; k < _data.GetLength(0); k++)
        {
            for (int l = 0; l < _data.GetLength(1); l++)
            {
                if (k > l)
                {
                    _data[k, l] = rnd.Next(-70, 151);
                }
                else
                {
                    _data[k, l] = rnd.Next(17, 171);
                }
            }
        }
    }

    //1
    public Matrix(int n, string pattern)
    {
        _data = new int[n, n];
        int center = n / 2;
        int maxRadius = n / 2;
        int count = 0;

        for (int r = 0; r <= maxRadius; r++)
        {
            if (r == 0)
            {
                count = count + 1;
            }
            else
            {
                count = count + 8 * r;
            }
        }

        int[] primes = new int[count];
        int primeIndex = 0;
        int candidate = 2;

        while (primeIndex < count)
        {
            if (IsPrime(candidate))
            {
                primes[primeIndex] = candidate;
                primeIndex++;
            }
            candidate++;
        }

        int pIndex = 0;
        for (int r = maxRadius; r >= 0; r--)
        {
            if (r == 0)
            {
                _data[center, center] = primes[pIndex];
                pIndex++;
            }
            else
            {
                int k = center;
                int l = center - r;
                _data[k, l] = primes[pIndex];
                pIndex++;

                for (int i = 1; i <= r; i++)
                {
                    _data[k - i, l + i] = primes[pIndex];
                    pIndex++;
                }

                k = center - r;
                l = center;

                for (int i = 1; i <= r; i++)
                {
                    _data[k + i, l + i] = primes[pIndex];
                    pIndex++;
                }

                k = center;
                l = center + r;

                for (int i = 1; i <= r; i++)
                {
                    _data[k + i, l - i] = primes[pIndex];
                    pIndex++;
                }

                k = center + r;
                l = center;

                for (int i = 1; i <= r - 1; i++)
                {
                    _data[k - i, l - i] = primes[pIndex];
                    pIndex++;
                }
            }
        }
    }

    //1
    private Matrix(int[,] data)
    {
        _data = data;
    }

    //2
    public int FindMaxDiagonalSum(out int maxOffset)
    {
        int n = _data.GetLength(0);
        int m = _data.GetLength(1);
        maxOffset = 0;

        if (n != m)
        {
            Console.WriteLine(
                "Матрица должна быть квадратной.");
            return 0;
        }

        if (n < 2)
        {
            Console.WriteLine(
                "Нет диагоналей, параллельных главной.");
            return 0;
        }

        int maxSum = int.MinValue;

        for (int d = -(n - 1); d < n; d++)
        {
            if (d == 0)
            {
                continue;
            }

            int currentSum = 0;

            if (d < 0)
            {
                for (int k = 0; k < n + d; k++)
                {
                    int l = k - d;
                    currentSum = currentSum + _data[k, l];
                }
            }
            else
            {
                for (int l = 0; l < n - d; l++)
                {
                    int k = l + d;
                    currentSum = currentSum + _data[k, l];
                }
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxOffset = d;
            }
        }

        return maxSum;
    }

    //3
    public Matrix Transpose()
    {
        int n = _data.GetLength(0);
        int m = _data.GetLength(1);
        int[,] transposedData = new int[m, n];

        for (int k = 0; k < m; k++)
        {
            for (int l = 0; l < n; l++)
            {
                transposedData[k, l] = _data[l, k];
            }
        }

        return new Matrix(transposedData);
    }

    //3
    public Matrix Multiply(Matrix right)
    {
        int n1 = _data.GetLength(0);
        int m1 = _data.GetLength(1);
        int n2 = right._data.GetLength(0);
        int m2 = right._data.GetLength(1);

        if (m1 != n2)
        {
            throw new ArgumentException(
                "Матрицы нельзя перемножить.");
        }

        int[,] result = new int[n1, m2];
        for (int k = 0; k < n1; k++)
        {
            for (int l = 0; l < m2; l++)
            {
                int sum = 0;
                for (int i = 0; i < m1; i++)
                {
                    sum = sum + _data[k, i] 
                        * right._data[i, l];
                }
                result[k, l] = sum;
            }
        }

        return new Matrix(result);
    }

    //3
    public Matrix Subtract(Matrix right)
    {
        int n1 = _data.GetLength(0);
        int m1 = _data.GetLength(1);
        int n2 = right._data.GetLength(0);
        int m2 = right._data.GetLength(1);

        if (n1 != n2 || m1 != m2)
        {
            throw new ArgumentException(
                "Размеры матриц не совпадают.");
        }

        int[,] result = new int[n1, m1];
        for (int k = 0; k < n1; k++)
        {
            for (int l = 0; l < m1; l++)
            {
                result[k, l] = _data[k, l] 
                    - right._data[k, l];
            }
        }

        return new Matrix(result);
    }

    //1
    private static bool IsPrime(int value)
    {
        if (value < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= value; i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    //1
    public override string ToString()
    {
        string result = string.Empty;
        for (int k = 0; k < _data.GetLength(0); k++)
        {
            for (int l = 0; l < _data.GetLength(1); l++)
            {
                result = result + _data[k, l] + "\t ";
            }
            result = result + Environment.NewLine;
        }

        return result;
    }
}