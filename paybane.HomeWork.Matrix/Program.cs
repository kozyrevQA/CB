using System;
using System.Threading;

namespace paybane.HomeWork.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив со строками на английском
            string[] linesArrEnglish = new string[4];
            linesArrEnglish[0] = "Wake up, Neo...";
            linesArrEnglish[1] = "The Matrix has you...";
            linesArrEnglish[2] = "Follow the white rabbit.";
            linesArrEnglish[3] = "Knok, knok, Neo.";
            
            //Массив со строками на русском
            string[] linesArrRussian = new string[4];
            linesArrRussian[0] = "Проснись, Нео...";
            linesArrRussian[1] = "Ты увяз в Матрице...";
            linesArrRussian[2] = "Следуй за белым кроликом.";
            linesArrRussian[3] = "Тук, тук, Нео.";

            string[] linesArr;

            Console.WriteLine("Привет! Это домашнее задание Матрица");
            Console.WriteLine("Для продолжения необходимо выбрать язык\nНажмите на клавишу:\n[1] - English\n[2] - Русский");
            
            //Ожидаем выбор языка
            while(true)
            {
                ConsoleKeyInfo key = new ConsoleKeyInfo();
                key = Console.ReadKey();
                if(key.Key == ConsoleKey.D1)
                {
                    linesArr = linesArrEnglish;
                    break;
                }
                else if(key.Key == ConsoleKey.D2)
                {
                    linesArr = linesArrRussian;
                    break;
                }
            }

            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            
            for(short i = 0; i < linesArr.Length; i++)
            {
                char[] charsArr = linesArr[i].ToCharArray();
                for(int j = 0; j < charsArr.Length; j++)
                {
                    Console.Write(charsArr[j]);
                    Thread.Sleep(200);
                }
                Console.ReadKey(true);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}