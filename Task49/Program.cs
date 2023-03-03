// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}
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
int[,] EvenMatrixIndex(int[,] matrixArray)
{
	for (int i = 0; i < matrixArray.GetLength(0); i += 2)
	{
		for (int j = 0; j < matrixArray.GetLength(1); j += 2)
		{
			matrixArray[i, j] *= matrixArray[i, j];
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
int rows = Promt("Введите размер массива по оси Х: ");
int columns = Promt("Введите размер массива по оси У: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int[,] matrix = CreateMatrixArrayInt(rows, columns, minNumberArray, maxNumberArray);
Console.Clear();
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(EvenMatrixIndex(matrix));