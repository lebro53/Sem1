// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
int[] ReverseArray(int[] array)
{
	int[] newArray = new int[array.Length];
	for (int i = 0; i < array.Length; i++)
	{
		newArray[i] = array[array.Length - 1 - i];
	}
	return newArray;
}
// void ReverseArray(int[] arr)
// {
// 	for (int i = 0; i < arr.Length / 2; i++)
// 	{
// 		int temp = arr[i];
// 		arr[i] = arr[arr.Length - 1 - i];
// 		arr[arr.Length - 1 - i] = temp;
// 	}
// }

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
PrintArray(arr);
PrintArray(ReverseArray(arr));
Array.Reverse(arr);
PrintArray(arr);