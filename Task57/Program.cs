// Array.Sort(array);
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
int[] MatrixToArray(int[,] matrix)
{
	int c = 0;
	int[] array = new int[matrix.Length];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			array[c] = matrix[i, j];
			c += 1;
		}
	}
	return array;
}
void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.WriteLine($"{array[i]}]");
	}
}
void SumElemArray(int[] array)
{
	int count = 1;
	int curentNumber = array[0];
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] == curentNumber) count++;
		else
		{
			Console.WriteLine($"Число {curentNumber} встречается {count} раз.");
			curentNumber = array[i];
			count = 1;
		}
	}
	Console.Write($"Число {curentNumber} встречается {count} раз.");
}

// Program body--------------------------------------------
int[,] matrix = CreateMatrixArrayInt(3, 4, 1, 10);
int[] arr = MatrixToArray(matrix);
Console.Clear();
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Array.Sort(arr);
PrintArray(arr);
SumElemArray(arr);