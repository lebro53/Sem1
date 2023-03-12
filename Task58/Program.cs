// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
bool CheckingMultiplicationConditionMatrix(int[,] matrix1, int[,] matrix2)
{
	if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
	else return false;
}
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
	int[,] multiplicationMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
	for (int i = 0; i < multiplicationMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < multiplicationMatrix.GetLength(1); j++)
		{
			for (int m = 0; m < matrix1.GetLength(1); m++)
			{
				multiplicationMatrix[i, j] += matrix1[i, m] * matrix2[m, j];

			}
		}
	}
	return multiplicationMatrix;
}


// Program body--------------------------------------------
int[,] firstMatrix = CreateMatrixArrayInt(1, 1, 1, 6);
int[,] secondMAtrix = CreateMatrixArrayInt(1, 1, 1, 7);
int[,] newMatrix = MultiplicationMatrix(firstMatrix, secondMAtrix);
Console.Clear();
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMAtrix);
Console.WriteLine();
if (CheckingMultiplicationConditionMatrix(firstMatrix, secondMAtrix)) PrintMatrix(newMatrix);
else Console.WriteLine("Ошибка, количество столбцов первой матрциы, должно быть равно количеству строк второй матрицы!");