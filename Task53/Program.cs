// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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
void SwapFirstLastRows(int[,] matrix)
{
	int temp = 0;
	for (int i = 0; i < matrix.GetLength(1); i++)
	{
		temp = matrix[0, i];
		matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
		matrix[matrix.GetLength(0) - 1, i] = temp;
	}
}


// Program body--------------------------------------------
int[,] arr = CreateMatrixArrayInt(5, 10, 1, 10);
Console.Clear();
PrintMatrix(arr);
SwapFirstLastRows(arr);
Console.WriteLine();
PrintMatrix(arr);
