// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация списка из двузначных чисел
List<int> GenTwoDigitNumsList()
{
    List<int> twoDigitNums = new List<int>();
    for (int i = 10; i < 100; i++)
    {
        twoDigitNums.Add(i);
    }
    return twoDigitNums;
}

// Генерация трёхмерного массива
int[,,] Gen3DArray(int m, int n, int p, List<int> nums)
{
    if (m * n * p > nums.Count)
        return new int[,,] { { { -1 } } };
    int[,,] res = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                int numIndex = new Random().Next(0, nums.Count);
                res[i, j, k] = nums[numIndex];
                nums.RemoveAt(numIndex);
            }
        }
    }
    return res;
}

// Вывод трёхмерного масива
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + " (" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int p = ReadData("Введите p: ");
int[,,] testArr = Gen3DArray(m, n, p, GenTwoDigitNumsList());
Print3DArray(testArr);