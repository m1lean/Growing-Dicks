using System;
class Program
{
    static void Main()
    {
        int snakeLength = 0;

        Console.WriteLine("Добро пожаловать в игру 'Вырости dick'!");
        Console.WriteLine("Введите команду '/dick' для увеличения длины dick'a.");
        Console.WriteLine("Для выхода из игры введите 'exit'.");

        while (true)
        {
            string command = Console.ReadLine().ToLower();

            if (command == "/dick")
            {
                int growth = new Random().Next(-10, 20);
                snakeLength += growth;

                Console.WriteLine($"Длина dick увеличилась на {growth} см. Текущая длина удава: {snakeLength} см.");
            }
            else if (command == "exit")
            {
                Console.WriteLine("Спасибо за игру! Длина dick: " + snakeLength + " см.");
                break;
            }
            else
            {
                Console.WriteLine("Недопустимая команда. Введите '/dick' для увеличения длины удава или 'exit' для выхода из игры.");
            }
        }
    }
}