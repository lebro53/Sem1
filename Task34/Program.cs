// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
		else Console.Write($"{array[i]}]");
	}
}
int PrintQuantEvenElemArray(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0) count += 1;
	}
	return count;
}

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
int minNumberArray = 100;
int maxNumberArray = 999;
int[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
PrintArray(arr);
Console.Write(" -> ");

int quantEven = PrintQuantEvenElemArray(arr);
Console.Write($"Количество четных чисел в массиве = {quantEven}");
