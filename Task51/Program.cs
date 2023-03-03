// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
int SumElemMainDiagonal(int[,] matrixArray)
{
	int mainDiagonal = matrixArray.GetLength(0);
	if (mainDiagonal > matrixArray.GetLength(1)) mainDiagonal = matrixArray.GetLength(1);
	int sumElem = 0;
	for (int i = 0; i < mainDiagonal; i++)
	{
		sumElem += matrixArray[i, i];
	}
	return sumElem;
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
		Console.WriteLine(" |");
	}
}


// Program body--------------------------------------------
int rows = Promt("Введите размер массива по оси Х: ");
int columns = Promt("Введите размер массива по оси У: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int[,] matrix = CreateMatrixArrayInt(rows, columns, minNumberArray, maxNumberArray);
int sumElemMainDiagonal = SumElemMainDiagonal(matrix);
Console.Clear();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали = {SumElemMainDiagonal(matrix)}");

