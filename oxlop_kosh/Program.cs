using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oxlop_kosh
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект Random
            Random random = new Random();

            // Генерируем случайное число от 1 до 100
            int randomNumber = random.Next(1, 101); 

            // Выводим сгенерированное число
            Console.WriteLine("Случайное число: " + randomNumber);
        }
    }
}
