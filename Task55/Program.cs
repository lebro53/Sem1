// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
int[,] SwapRowsColumnsMatrix(int[,] matrix)
{
	int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			newMatrix[j, i] = matrix[i, j];
		}
	}
	return newMatrix;
}

// Program body--------------------------------------------
int[,] arr = CreateMatrixArrayInt(6, 10, 1, 10);
Console.Clear();
PrintMatrix(arr);
int[,] newArr = SwapRowsColumnsMatrix(arr);
Console.WriteLine();
PrintMatrix(newArr);