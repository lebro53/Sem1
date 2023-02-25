// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Methods-----------------------------------------
int[] NewArray(int num, int min, int max)
{
	Random rnd = new Random();
	int[] array = new int[num];
	int i = 0;
	for (i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}
void PrintArray(int[] arr)
{
	Console.Write($"Получинный массив из {arr.Length} элементов = ");
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"{arr[i]} ");
	}
}


// Program body------------------------------------
Console.WriteLine("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintArray(NewArray(number, 0, 1));
