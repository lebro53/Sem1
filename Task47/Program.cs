// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}
double[,] CreateMatrixArrayDouble(int row, int column, int min, int max)
{
	double[,] matrixArray = new double[row, column];
	Random rnd = new Random();
	for (int i = 0; i < matrixArray.GetLength(0); i++)
	{
		for (int j = 0; j < matrixArray.GetLength(1); j++)
		{
			matrixArray[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
		}
	}
	return matrixArray;
}
void PrintMatrix(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
			else Console.Write($"{matrix[i, j],5}");
		}
		Console.WriteLine("|");
	}
}


// Program body--------------------------------------------
int rows = Promt("Введите размер массива по оси Х: ");
int columns = Promt("Введите размер массива по оси У: ");
double[,] arr = CreateMatrixArrayDouble(rows, columns, -10, 10);
Console.Clear();
PrintMatrix(arr);