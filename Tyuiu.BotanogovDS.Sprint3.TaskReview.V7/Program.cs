using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint3.TaskReview.V7.Lib;

namespace Tyuiu.BotanogovDS.Sprint3.TaskReview.V7
{
    class Program
    {
        static void Main(string[] args)
        {   
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Базовые навки работы в C#                                          *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:            *");
            Console.WriteLine("* F(x) = cos(x) + cos(x)/(x+2) - (3x)                                      *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* F(x) = cos(x) + cos(x)/(x+2) - (3x)                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            
            int startValue = 1;
            int stopValue = 10;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("Результаты вычисления функции:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("f(" + (i + startValue) + ") = " + result[i]);
            }

            Console.ReadLine();
        }
    }
}
