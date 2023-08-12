/* Задача 54 Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив
7 4 2 1
9 5 3 2
8 4 4 2 */

 void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} " );
        }
        Console.WriteLine();
    }
}

void ReleaseArray(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // cтолбец
        for (int j = 0; j < matrix.GetLength(1); j++)// строки
            for (int t = 0; t < matrix.GetLength(1) - 1; t++)//  почему  GetLength(1), тк (1) - строка, а не столбец
                if (matrix[i, t] < matrix[i, t + 1])
                {
                    temp = matrix[i, t + 1];
                    matrix[i, t + 1] = matrix[i, t];
                    matrix[i, t] = temp;
                }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры массива ");
int[] size = Console.ReadLine().Split( ).Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputArray(matrix);
Console.WriteLine();
ReleaseArray(matrix);
PrintMatrix(matrix); 



/*Задача 56 Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов 1 строка  */

//создание массива
void InputArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           matrix[i, j] = new Random().Next(0, 10);
           Console.Write($"{matrix[i, j]} ");
       }
       Console.WriteLine();
   }
}

//основная операция суммирования и нахождения минимального
void ReleaseArray(int[,] matrix)
{
       int[] SumRowArray = new int[matrix.GetLength(0)]; // одномерный массив для записи сумм строк
   int sum;

    //заходим в массив и суммируем числа в строке
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       sum = 0; // чтобы с переходом на новую строку sum обнулялся
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           sum += matrix[i, j];
       }
       SumRowArray[i] = sum;// сохраняем сумирования каждой строки в массив и далее для можем вывести
   }

      for (int i = 0; i < SumRowArray.Length; i++)
         Console.Write($"{SumRowArray[i]} ");

   int MinSummArr = SumRowArray[0];  
   int numRow = 1;  //строка для пользователя

    //создаем цикл для сравнения этапа суммирования
   for (int v = 0; v < SumRowArray.Length; v++)
   {
       if (SumRowArray[v] < MinSummArr)  //MinSummArr - в ней, на данный момент хранится первое значение, 
        //после суммирования, далее будет сравнение и эта херня будет меняться и получится минимальное
        //SumRowArray - хранит в себе сумму каждой строки
       {
           MinSummArr = SumRowArray[v];  //сохранения нового минимального
           numRow = v + 1; // +1 - тк данная строка для пользователя, а v=0
       }
   }
   Console.WriteLine($"Минимальной является строка {numRow}, сумма строки равна {MinSummArr}");
}


Console.Clear();
Console.Write("Введите размеры массива" );
int[] size = Console.ReadLine().Split( ).Select(x =Ю int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputArray(matrix);
Console.WriteLine();
ReleaseArray(matrix); 



/*  Задача 58 Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы
2 4  3 4
3 2  3 3
Результирующая матрица будет
18 20
15 18 */


void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ReleaseArray(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixRes = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixRes[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixRes;
}
void Array(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите размеры A матрицы ");
int[] size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];

Console.Write("Введите размеры B матрицы ");
int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];

if (size1[0] != size2[1])
    Console.WriteLine("Error");
InputArray(matrix1);
Console.WriteLine();

InputArray(matrix2);
Console.WriteLine();

int[,] matrixResult = ReleaseArray(matrix1, matrix2);
Array(matrixResult);




/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)  */

int[,,] FillArray(int row, int coll, int depth)
{
    int[,,] FilledArr = new int[row, coll, depth];
    int TempSize = row * coll * depth;
    if (TempSize <= 90)
    {
        int[] tempArr = UniqueValue(TempSize);
        int iTemp = 0;
        for (int i = 0; i < row; i++)
            for (int j = 0; j < coll; j++)
                for (int k = 0; k < depth; k++)
                    if (iTemp >= 0 && iTemp < TempSize)
                    {
                        FilledArr[i, j, k] = tempArr[iTemp];
                        iTemp++;
                    }
    }
    return FilledArr;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]}({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] UniqueValue(int size) // size = r  c  d
{
    int[] uniqueAr = new int[size];
    for (int i = 0; i < size; i++)
    {
        uniqueAr[i] = new Random().Next(10, 100);
        if (i != 0)
        {
            for (int r = 0; r < i; r++)
            {
                while (uniqueAr[r] == uniqueAr[i])
                {
                    uniqueAr[r] = new Random().Next(10, 100);
                }
            }
        }
    }
    return uniqueAr;
}

int[,,] arrayTask60 = FillArray(4, 3, 2);
Print3DArray(arrayTask60);

/*  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
  */
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}