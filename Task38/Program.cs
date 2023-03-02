// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}
double[] CreateArray(int num, int min, int max)
{
	double[] array = new double[num];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2, MidpointRounding.ToZero);
	}
	return array;
}
void PrintArray(double[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.WriteLine($"{array[i]}]");
	}
}
double MaxElemArray(double[] array)
{
	double maxElem = Math.Round(array[0], 2, MidpointRounding.ToZero);
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] > maxElem) maxElem = array[i];
	}
	return maxElem;
}
double MinElemArray(double[] array)
{
	double minElem = Math.Round(array[0], 2, MidpointRounding.ToZero);
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] < minElem) minElem = array[i];
	}
	return minElem;
}
// Math.Round(root, 2, MidpointRounding.ToZero)

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
double[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
PrintArray(arr);
double difMaxMinElemArray = MaxElemArray(arr) - MinElemArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Math.Round(difMaxMinElemArray, 2, MidpointRounding.ToZero)} ");