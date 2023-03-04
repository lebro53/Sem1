// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
int[] SumElemColumnsMatrix(int[,] matrixArray)
{
	int[] array = new int[matrixArray.GetLength(1)];
	for (int j = 0; j < matrixArray.GetLength(1); j++)     //columns
	{
		for (int i = 0; i < matrixArray.GetLength(0); i++)    //rows
		{
			array[j] += matrixArray[i, j];
		}
	}
	return array;
}
double[] ArifmeticAverageColumns(int[] array)
{
	double[] arrayDouble = new double[array.Length];
	for (int i = 0; i < array.Length; i++)
	{
		double elem = array[i];
		arrayDouble[i] = Math.Round(elem / array.Length, 2, MidpointRounding.ToZero);
	}
	return arrayDouble;
}
void PrintArray(double[] array)
{
	Console.Write("Среднее арифметическое каждого столбца = [");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.WriteLine($"{array[i]}]");
	}
}
// Program body--------------------------------------------
int[,] matrix = CreateMatrixArrayInt(2, 5, 1, 5);
int[] arr = SumElemColumnsMatrix(matrix);
double[] arifmeticAverageColumns = ArifmeticAverageColumns(arr);
Console.Clear();
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(arifmeticAverageColumns);
