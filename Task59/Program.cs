// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


// Method--------------------------------------------------
// int[,] CreateMatrixArrayInt(int row, int column, int min, int max)
// {
// 	int[,] matrixArray = new int[row, column];
// 	Random rnd = new Random();
// 	for (int i = 0; i < matrixArray.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrixArray.GetLength(1); j++)
// 		{
// 			matrixArray[i, j] = rnd.Next(min, max + 1);
// 		}
// 	}
// 	return matrixArray;
// }
// void PrintMatrix(int[,] matrix)
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		Console.Write("|");
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 		{
// 			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
// 			else Console.Write($"{matrix[i, j],3}");
// 		}
// 		Console.WriteLine("|");
// 	}
// }
// int[] MinElemMatrixArray(int[,] matrix)
// {
// 	int minElem = matrix[0, 0];
// 	int row = 0;
// 	int column = 0;
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 		{
// 			if (matrix[row, column] >= matrix[i, j])
// 			{
// 				row = i;
// 				column = j;
// 			}
// 		}
// 	}
// 	return new int[] { row, column };
// }
// void PrintArray(int[] array)
// {
// 	Console.Write("[");
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
// 		else Console.WriteLine($"{array[i]}]");
// 	}
// }
// int[,] NewMatrixArray(int[,] matrix, int[] array)
// {
// 	int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
// 	int m = 0, n = 0;
// 	for (int i = 0; i < newMatrix.GetLength(0); i++)
// 	{
// 		if (m == array[0]) m++;
// 		for (int j = 0; j < newMatrix.GetLength(1); j++)
// 		{
// 			if (n == array[1]) n++;
// 			newMatrix[i, j] = matrix[m, n];
// 			n++;
// 		}
// 		m++;
// 		n = 0;
// 	}
// 	return newMatrix;
// }
int[,,] CreateThreeMatrixArrayInt(int row, int column, int depth, int min, int max)
{
	int[,,] matrixArray = new int[row, column, depth];
	Random rnd = new Random();
	for (int i = 0; i < matrixArray.GetLength(0); i++)
	{
		for (int j = 0; j < matrixArray.GetLength(1); j++)
		{
			for (int k = 0; k < matrixArray.GetLength(2); k++)
			{
				matrixArray[i, j, k] = rnd.Next(min, max + 1);
			}
		}
	}
	return matrixArray;
}
// // Program body--------------------------------------------
// int[,] matrixArray = CreateMatrixArrayInt(3, 4, -1, 10);
// int[] arr = MinElemMatrixArray(matrixArray);
// int[,] newMatrix = NewMatrixArray(matrixArray, arr);
// Console.Clear();
// PrintMatrix(matrixArray);
// Console.WriteLine();
// PrintArray(arr);
// Console.WriteLine();
// PrintMatrix(newMatrix);
int[,,] matrixArray = CreateThreeMatrixArrayInt(3, 4, 5, -1, 10);