using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Создать коллекцию целых чисел на 15 элементов

    Заполнить коллекцию пользовательским вводом

    Проверять, что вводится именно целое число

    Посчитать сумму всех элементов коллекции с помощью for

    Посчитать разность всех элементов с помощью while

    посчитать произведение всех элементов do-while

    вывести коллекцию foreach
 * 
*/

namespace paybane.HW7.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int result; // Переменная для подсчетов

            // Заполнить коллекцию
            while (list.Count < 15)
            {
                Console.WriteLine("Вам необходимо заполнить массив ЦЕЛЫМИ числами\nКаждое число не должно быть меньше -2147483648 и не должно быть больше 2147483647\n");
                StringBuilder messageStringBuilder = new StringBuilder();
                messageStringBuilder.Append("Введите ").Append(list.Count + 1).Append("-е целое число:");
                
                Console.WriteLine(messageStringBuilder.ToString());

                // Проверка на соответствие вводимого значения Int32
                if(Int32.TryParse(Console.ReadLine(), out int input))
                {
                    list.Add(input);
                }
                else
                {
                    Console.WriteLine("Введенное вами значение не является целым числом!");
                }
            }

            // Посчитать сумму всех элементов            
            result = 0;
            for(int index = 0; index < 15; index++)
            {
                result = result + list[index];               
            }

            Console.WriteLine("Сумма всех элементов равна: " + result);

            // Посчитать разность всех элементов
            result = 0;
            int step = 0; // Итерация цикла            
            while(step < list.Count)
            {
                result -= list[step];
                step++;
            }

            Console.WriteLine("Разность всех элементов массива равна: " + result);

            // Посчитать произведение всех элементов массива
            result = list[0];
            step = 1;
            do
            {
                result *= list[step];
                step++;
            }
            while (step < list.Count);

            Console.WriteLine("Произведение всех элементов массива равно: " + result);

            // Вывести на экран все элементы массива
            Console.WriteLine("Введенный вами массив целых чисел:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            {

            }

            Console.ReadKey(true);
        }
    }
}
