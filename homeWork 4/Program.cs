Console.WriteLine("Введите количетсво строк в матрице - "); // Спрашиваем пользователя сколько строк в матрице
int str = int.Parse(Console.ReadLine()); // Запрос ввода числа

Console.WriteLine("Введите количество столбцов - "); //Спрашиваем пользователя сколько столбцов в матрице 
int column = int.Parse(Console.ReadLine()); // Запрос ввода числа

Console.WriteLine("Введите предел рандомизации чисел"); //Задаем предел максимального рандомного числа
int rand = int.Parse(Console.ReadLine());

Console.Clear();

//Создаём двумерный массив
//
int[,] nums = new int[str,column];

//Инициализация генератора рандомных чисел

Random r = new Random();

//Вывод матрицы с заполнением рандомными числами
Console.WriteLine("Полученная матрица - ");
int sum = 0;
for (int i = 0; i < str; i++)
{
    for (int j = 0; j < column; j++)
    {
        nums[i,j] = r.Next(rand); //Заполняем матрицу рандомными числами 
        Console.Write($" {nums[i,  j],3}"); //Выводим матрицу
        sum+=nums[i,j]; //Суммируем элементы матрицы 

    }
    Console.WriteLine();
}

Console.Write($"Сумма всех элементов матрицы - {sum} "); //Выводим сумму отдельной строкой 
Console.ReadKey();

