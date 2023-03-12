// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

// Method--------------------------------------------------
int[,,] CreateThreeMatrixArrayInt(int row, int column, int depth)
{
	int number = 10;
	int[,,] matrixArray = new int[row, column, depth];
	for (int i = 0; i < matrixArray.GetLength(0); i++)
	{
		for (int j = 0; j < matrixArray.GetLength(1); j++)
		{
			for (int k = 0; k < matrixArray.GetLength(2); k++)
			{
				matrixArray[i, j, k] = number++;
			}
		}
	}
	return matrixArray;
}
void PrintThreeMatrix(int[,,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(2); k++)
			{
				Console.Write($"{matrix[i, j, k],2}({i},{j,2},{k,2}) ");
			}
		}
	}
}
bool CheckDoubleELemMatrix(int[,,] matrix)
{
	if (matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2) <= 90) return true;
	return false;
}

// Program body--------------------------------------------
int[,,] matrix = CreateThreeMatrixArrayInt(1, 1, 1);
Console.Clear();
if (CheckDoubleELemMatrix(matrix)) PrintThreeMatrix(matrix);
else Console.WriteLine("Задайте массив другой размерностью");