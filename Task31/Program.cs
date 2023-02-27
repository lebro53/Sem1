// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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
	Console.Write("Сгенерированный массив : [");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.WriteLine($"{array[i]}]");
	}
}
int GetSumPositiveNumbers(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0)
		{
			sum += array[i];
		}
	}
	return sum;
}
int GetSumNegativeNumbers(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < 0)
		{
			sum += array[i];
		}
	}
	return sum;
}

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
PrintArray(arr);
int sumPositiveNumbers = GetSumPositiveNumbers(arr);
int sumNegativeNumbers = GetSumNegativeNumbers(arr);
Console.WriteLine($"Сумма положительныйх элементов массива = {sumPositiveNumbers}");
Console.WriteLine($"Сумма отрицательнрых элементов массива = {sumNegativeNumbers}");
