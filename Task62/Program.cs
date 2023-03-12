// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Method--------------------------------------------------
int[,] CreateMatrixArrayInt(int row, int column)
{
	int i = 0;
	int j = 0;
	int number = 1;
	int[,] matrixArray = new int[row, column];
	for (j = 0; j < matrixArray.GetLength(1); j++)
	{
		matrixArray[i, j] = number++;
		if (j == matrixArray.GetLength(1) - 1)
		{
			for (i = 1; i < matrixArray.GetLength(0); i++)
			{
				matrixArray[i, j] = number++;
			}
		}
	}
	for (i = row - 1; i == row - 1; i++)
	{
		{
			for (j = column - 2; j >= 0; j--)
			{
				matrixArray[i, j] = number++;
			}
		}
	}
	for (j = 0; j == 0; j++)
	{
		for (i = row - 2; i > 0; i--)
		{
			matrixArray[i, j] = number++;
		}
	}
	for (i = 1; i == 1; i++)
	{
		for (j = 1; j < column - 1; j++)
		{
			matrixArray[i, j] = number++;
		}
	}
	for (j = 2; j == 2; j++)
	{
		for (i = 2; i <= row - 2; i++)
		{
			matrixArray[i, j] = number++;
		}
	}
	for (i = 2; i == 2; i++)
	{
		for (j = column - 3; j >= 1; j--)
		{
			matrixArray[i, j] = number++;
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


// Program body--------------------------------------------
int[,] arr = CreateMatrixArrayInt(4, 4);
Console.Clear();
PrintMatrix(arr);