// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] CreateNewArray(int num, int[] array)
{
	int size = num / 2;
	if (num % 2 != 0) size = num / 2 + 1;
	int[] newArray = new int[size];
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = array[i] * array[array.Length - 1 - i];
	}
	newArray[newArray.Length - 1] = array[array.Length / 2];
	return newArray;

}

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
PrintArray(arr);
PrintArray(CreateNewArray(size, arr));
