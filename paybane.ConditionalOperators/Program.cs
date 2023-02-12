using System;
using System.Collections.Generic;

/*
  Что надо сделать:
   Принять с консоли 3 целых числа
   Вывести на консоль большее из них используя if-else
   Вывести на консоль инфу о четности этого числа используя switch-case
   Вывести на консоль инфу меньше/больше 100 используя тернарный оператор
   Не использовать массивы и циклы
*/

namespace paybane.ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа принимает 3 числа и определяет наибольшее из них\nСообщает четное число или нет\nСообщает больше или меньше 100\n");
            List<int> list = new List<int>();
            string errorText = "Вы ввели НЕ число!";
            int maxNumber;

            Console.WriteLine("Введите первое целое число:");
            if(Int32.TryParse(Console.ReadLine(), out int result))
            {
                list.Add(result);
            }
            else
            {
                Console.WriteLine(errorText);
                Console.ReadKey(true);
                return;
            }

            Console.WriteLine("Введите второе целое число:");
            if (Int32.TryParse(Console.ReadLine(), out int result2))
            {
                list.Add(result2);
            }
            else
            {
                Console.WriteLine(errorText);
                Console.ReadKey(true);
                return;
            }

            Console.WriteLine("Введите третье целое число:");
            if (Int32.TryParse(Console.ReadLine(), out int result3))
            {
                list.Add(result3);
            }
            else
            {
                Console.WriteLine(errorText);
                Console.ReadKey(true);
                return;
            }

            // Проверка, что в коллекции нужное кол-во элементов.
            if (list.Count != 3)
            {
                Console.WriteLine("Вы ввели недостаточно чисел!");
                return;
            }

            // Поиск наибольшего числа из списка
            if (list[0] >= list[1] && list[0] >= list[2])
            {
                maxNumber = list[0];
            }
            else if(list[1] >= list[2] && list[1] >= list[0])
            {
                maxNumber = list[1];
            }
            else
            {
                maxNumber = list[2];
            }

            Console.Write("Наибольшее число: " + maxNumber + ", ");

            // Определение четности числа.
            switch(maxNumber % 2)
            {
                case 0:
                    Console.Write("оно четное и ");
                    break;
                default:
                    Console.Write("оно нечетное и ");
                    break;
            }

            // Определение - число больше или меньше 100
            Console.Write(maxNumber > 100 ? "больше 100" : "не больше 100");
            Console.ReadKey(true);
        }
    }
}
