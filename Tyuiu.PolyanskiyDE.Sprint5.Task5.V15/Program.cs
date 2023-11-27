using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.PolyanskiyDE.Sprint5.Task5.V15.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint5.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Полянский Д. Э. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Полянский Данил Эдуардович | АСОиУБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C: DataSprint5 InPutFileTask5V15, в котором есть набор         *");
            Console.WriteLine("* значений. Найти минимальное вещественное число в файле, которое делится *");
            Console.WriteLine("* на 5. Полученный результат вывести на консоль. У вещесвенных значений   *");
            Console.WriteLine("* окргулить до трёх знаков после запятой                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V15.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное вещественное число в файле, которое делится на 5: " + res);

            Console.ReadKey();
        }
    }
}
