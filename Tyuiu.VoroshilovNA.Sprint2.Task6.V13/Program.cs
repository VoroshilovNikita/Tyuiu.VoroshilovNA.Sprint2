using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VoroshilovNA.Sprint2.Task6.V13.Lib;

namespace Tyuiu.VoroshilovNA.Sprint2.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Ворошилов Н. А. | ИСТНБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Ворошилов Никита Андреевич | ИСТНБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:*");
            Console.WriteLine("* g(год), m(порядковый номер месяца) и n(число).По заданным g, n и m      *");
            Console.WriteLine("* определить дату следующего дня.Заданный год является високосным.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год (например, 2023): ");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц (1 - январь, 2 - февраль, и так далее): ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число (1 - 31): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
