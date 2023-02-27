// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}
int[] CreateArray(int num, int min, int max)
{
	int[] array = new int[num];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
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
int QuantityDoubleElemArray(int[] array)
{
	int quantitu = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 9 && array[i] < 100) quantitu += 1;
	}
	return quantitu;
}

int size = Promt("Введите размер массива: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
PrintArray(arr);
Console.Write($"Количетсво элементов лежащих в отрезке [10, 99] = {QuantityDoubleElemArray(arr)}");