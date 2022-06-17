Console.WriteLine("Введите размер последовательности"); //Задаём размер массива 

int size = int.Parse(Console.ReadLine());
Console.Clear();

int[] nums = new int[size]; // Инициализируем массив

for (int i = 0; i < size; i++) // Заполняем индексы массива при помощи цикла
{
    Console.WriteLine("Введите число - ");
    nums[i] = int.Parse(Console.ReadLine());
    
}

Console.Clear();

int minValue = nums[0];
Console.WriteLine("Введеные числа - "); //Выводим массив на экран
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]} ");
    if (nums[i]<minValue) minValue = nums[i]; //Ищем минимальное число в массиве
}

Console.WriteLine($"\nСамое маленькое число  - {minValue,4}"); //Выводим минимальное число на экран.