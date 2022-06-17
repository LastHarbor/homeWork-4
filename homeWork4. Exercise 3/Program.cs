using System.Runtime.InteropServices;

Console.WriteLine("Введите максимальное число диапозона");
int size = Int32.Parse(Console.ReadLine());                     //Задаём диапозон в пределах которого, будем загадывать число

Console.Clear();

Random r = new Random();        //Инициализиурем рандомайзер и загадываем число

int count=0; //Создаем счётчик попыток

int number = r.Next(size);                  //Загадываем число


Console.WriteLine($"Компьютер загадал от 0 до {size}");  //Компьютер говорит, в каком диапозоне он загадал число

Console.WriteLine("Для выхода наберите - 1234"); // Пароль для выхода из игры

Console.WriteLine("Введите число - ");

var findNumber = int.Parse(Console.ReadLine());

bool flag = true; //флаг для цикла

while (flag)
{
    count++; 

    if (number < findNumber)
    {
        Console.WriteLine("Число больше загаданного\nВведите число - ");
        findNumber = int.Parse(Console.ReadLine());
    }

    else if (findNumber < number)
    {
        Console.WriteLine("Число меньше загаданного\nВведите число - ");
        findNumber = int.Parse(Console.ReadLine());
    }

   
    else if (findNumber == number)
    {
        Console.WriteLine($"Поздравляю, вы выйграли, загаданное число {number}");
        Console.WriteLine($"Количество попыток - {count}");
        Console.ReadKey();
        break;
    }

    switch (findNumber)
    {
        case 1234:
        {
            Console.WriteLine($"Загаданное число было - {number}\nВыход...");
            flag = false; break;
        }
    }
}
