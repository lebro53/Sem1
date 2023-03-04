// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
bool CompareIndexMatrix(int[,] matrixArray, int posX, int posY)
{
	if (posX < matrixArray.GetLength(0) & posY < matrixArray.GetLength(1)) return true;  // вот с этим я намучился. Итог: при & если оба значения true, тогда итог будет true,
	return false;                                                                        // но если одно из них false, тогда ответ будет false. Либо воспользоваться &&.
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
void PrintFoundElemMatrix(int[,] matrixArray, int posX, int posY)
{
	if (CompareIndexMatrix(matrixArray, posX, posY)) Console.WriteLine(matrixArray[posX, posY]);
	else Console.WriteLine($"{posX}, {posY} -> такого элемента в массиве нет");
}

// Program body--------------------------------------------
int matrixPositionElemX = Promt("Введите позицию элемента по оси Х: ");
int matrixPositionElemY = Promt("Введите позицию элемента по оси Y: ");
int[,] arr = CreateMatrixArrayInt(5, 5, -10, 10);
Console.Clear();
PrintMatrix(arr);
Console.WriteLine();
PrintFoundElemMatrix(arr, matrixPositionElemX, matrixPositionElemY);