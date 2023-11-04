using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint3.Task1.V20.Lib;

namespace Tyuiu.ZuborevDA.Sprint3.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла while                                                 *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #20                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда      *");
            Console.WriteLine("* по формуле                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int startValue = 1;
            int stopValue = 16;

            Console.WriteLine($"Старт шага: {startValue}");
            Console.WriteLine($"Конец шага: {stopValue}");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine($"Сумма ряда = {ds.GetSumSeries(startValue, stopValue)}");

            Console.ReadKey();
        }
    }
}
