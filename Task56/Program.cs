// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Method--------------------------------------------------
int[,] CreateMatrixArrayInt(int row, int column, int min, int max)
{
	int[,] matrixArray = new int[row, column];
	Random rnd = new Random();
	for (int i = 0; i < matrixArray.GetLength(0); i++)
	{
		for (int j = 0; j < matrixArray.GetLength(1); j++)
		{
			matrixArray[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrixArray;
}
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
			else Console.Write($"{matrix[i, j],3}");
		}
		Console.WriteLine("|");
	}
}
void PrintArray(int[] matrix)
{
	Console.Write("[");
	for (int i = 0; i < matrix.Length; i++)
	{
		if (i < matrix.Length - 1) Console.Write($"{matrix[i],3}, ");
		else Console.Write($"{matrix[i],3}");
	}
	Console.WriteLine("]");
}
int[] SumElemRowMatrix(int[,] matrix)
{
	int[] array = new int[matrix.GetLength(0)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		int sumRow = 0;
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			sumRow += matrix[i, j];
		}
		array[i] = sumRow;
	}
	return array;
}
void SearchMinSumElemRowMatrix(int[] array)
{
	int count = 1;
	int minSumElem = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < minSumElem)
		{
			minSumElem = array[i];
			count = i + 1;
		}
	}
	Console.WriteLine($"Наименьшая сумма элементов {minSumElem} находится в {count} строке ");
}

// Program body--------------------------------------------
int[,] matrixArray = CreateMatrixArrayInt(6, 4, 1, 10);
int[] arr = SumElemRowMatrix(matrixArray);
Console.Clear();
PrintMatrix(matrixArray);
Console.WriteLine();
PrintArray(arr);
SearchMinSumElemRowMatrix(arr);
