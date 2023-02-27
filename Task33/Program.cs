// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
bool SearchElemArray(int[] array, int srchNum)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == srchNum) return true;
	}
	return false;
}

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int searchNumber = Promt("Введите искомое число: ");
int[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
if (SearchElemArray(arr, searchNumber)) Console.Write($"Число {searchNumber} присутствует в массиве -> ");
else Console.Write($"Число {searchNumber} отсутствует в массиве -> ");
PrintArray(arr);